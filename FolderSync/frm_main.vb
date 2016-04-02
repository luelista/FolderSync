Imports System.IO
Imports TenTec.Windows.iGridLib
Imports FolderSync.Utilities.FTP

Public Class frm_main
  Dim m_border As New MVPS.clsFormBorder(Me)
  Dim igProgBar1 As New iGProgressBarCellManager()
  Dim lastShowFilename As String
  Dim dicServerFileList As FTPDirectory
  Dim icon_txtSearch As New vbAccelerator.Components.Controls.TextBoxMarginCustomise()
  Dim icon_txtDiz As New vbAccelerator.Components.Controls.TextBoxMarginCustomise()


  Sub processJobList()
    On Error Resume Next

    If glob.para("diz").Length < 2 Then
      MsgBox("Bitte Diktatzeichen eingeben!", MsgBoxStyle.Exclamation, "FolderSync " & fVersion)
    End If

    Dim randomizer As New Random()

    processingJoblist = True
    cancelProcess = False
    btnProcessJobList.Enabled = False
    btnCancelProcess.Enabled = True

    While igBatchList.Rows.Count > 0
      Dim r As iGRow = igBatchList.Rows(0)


      If r.Tag = "DOWN" Then
        'download
        download(r.Cells("locfolder").Value, r.Cells("servername").Value)

      Else
        'upload
        upload(r.Cells("locfolder").Value, r.Cells("servername").Value)

      End If

      'r.Cells("progress").Value = randomizer.Next(28, 91) / 100

      While isBusy
        Application.DoEvents()
        Threading.Thread.Sleep(11)
      End While

      igBatchList.Rows.RemoveAt(r.Index)

      If cancelProcess Then Exit While
    End While

    processingJoblist = False
    cancelProcess = False
    btnProcessJobList.Enabled = True
    btnCancelProcess.Enabled = False
  End Sub

  Sub addJobToList(ByVal locFolder As String, ByVal serverName As String, ByVal upload As Boolean, ByVal autoStart As Boolean)

    With igBatchList.Rows.Add()
      .Cells(0).Value = locFolder
      .Cells(1).Value = If(upload, " UP >>>", " <<< DOWN")
      .Cells(2).Value = serverName
      .Cells(3).Value = "Warten..."
      If upload Then
        .Cells("servername").BackColor = Color.MistyRose
      Else
        .Cells("locfolder").BackColor = Color.LemonChiffon
      End If
      .Tag = If(upload, "UP", "DOWN")
    End With

    If autoStart = True And processingJoblist = False Then processJobList()

  End Sub

  Private Sub checkTopmost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTopmost.CheckedChanged
    Me.TopMost = checkTopmost.Checked
  End Sub

  Sub btnRefreshServerFileList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshServerFileList.Click
    On Error Resume Next

    'GroupBox1.Enabled = False
    labState.Text = "Dateiliste laden..."
    Timer1.Start()
    Application.DoEvents()

    Dim trys As Integer = 0
startmarke:

    'tvServerFile.Nodes.Clear()

    dicServerFileList = GetServerDirList()
    If dicServerFileList Is Nothing Then
      trys += 1

      If trys < 4 Then
        GoTo startmarke
      Else
        lvServerFile.Enabled = False
        lvServerFile.ResumeLayout()
        MsgBox("Fehler beim Laden der Dateiliste! Evtl. ist der Server zur Zeit nicht verfügbar. Versuche es bitte erneut.", MsgBoxStyle.Exclamation, "FolderSync - Fehler")
        isBusy = False
        Exit Sub
      End If

    End If

    txtServerFolder.Items.Clear()
    txtServerFolder.Items.Add("<ohne Hauptordner>")

    Dim nPath, nFile As String
    Dim pos1 As Integer, lvi As ListViewItem

    For Each f As FTPfileInfo In dicServerFileList
      If f.Extension.ToLower <> "zip" Then Continue For
      pos1 = f.Filename.LastIndexOf("__")
      If pos1 > -1 Then
        nPath = f.Filename.Substring(0, pos1)
        If Not txtServerFolder.Items.Contains(nPath) Then txtServerFolder.Items.Add(nPath)
      End If


    Next

    fillServerListview("")
    labState.Text = "Fertig"

    Timer1.Stop()
    ProgressBar1.Value = 0
    'GroupBox1.Enabled = True
  End Sub

  Sub fillServerListview(Optional ByVal group As String = "")
    Dim nPath, nFile As String
    Dim pos1 As Integer, lvi As ListViewItem
    Dim suchString = txtSearch.Text.ToLower
    lvServerFile.SuspendLayout()
    lvServerFile.Hide()

    lvServerFile.Items.Clear()
    lvServerFile.Groups.Clear()

    'If group = "" Then lvServerFile.Groups.Add("VbNetProjekte", "VbNetProjekte")

    Dim noGroup As ListViewGroup = lvServerFile.Groups.Add("___nogroup", "<ohne Hauptordner>")

    For Each f As FTPfileInfo In dicServerFileList
      If f.Extension.ToLower <> "zip" Then Continue For
      If suchString <> "" And f.Filename.ToLower.Contains(suchString) = False Then Continue For
      pos1 = f.Filename.LastIndexOf("__")
      If pos1 > -1 Then
        nPath = f.Filename.Substring(0, pos1)
        nFile = f.Filename.Substring(pos1 + 2)
        If group <> "" And group <> nPath Then Continue For
      Else
        nPath = ""
        nFile = f.Filename
        If group <> "" And group <> "__nogroup" Then Continue For
      End If


      lvi = lvServerFile.Items.Add(f.Filename, nFile, "zip")
      Dim fileSize As Integer = f.Size
      Dim sFileSize As String = ""
      If fileSize > 1000000 Then
        sFileSize = CInt(fileSize / 1000000).ToString + " MB"
      ElseIf fileSize > 1000 Then
        sFileSize = CInt(fileSize / 1000).ToString + " kB"
      Else
        sFileSize = fileSize.ToString + " B"
      End If
      lvi.SubItems.AddRange(New String() {nPath, f.FileDateTime.ToString(), dicServerFileList(f)(2), sFileSize})
      lvi.Tag = f

      If nPath = "" Then
        lvi.Group = noGroup

        'tvServerFile.Nodes.Add(f, nFile, "zip").ToolTipText = "Letzte Änderung: " + files(f)(0)
      Else

        If lvServerFile.Groups(nPath) Is Nothing Then
          lvServerFile.Groups.Add(nPath, nPath)
        End If
        lvi.Group = lvServerFile.Groups(nPath)

        'If tvServerFile.Nodes(nPath) Is Nothing Then
        '  tvServerFile.Nodes.Add(nPath, nPath, "fld", "fld")
        'End If
        'tvServerFile.Nodes(nPath).Nodes.Add(f, nFile, "zip").ToolTipText = "Letzte Änderung: " + files(f)(0)



      End If

    Next

    isBusy = False
    lvServerFile.ResumeLayout()
    lvServerFile.Show()
  End Sub

  Sub refreshServerFileName(Optional ByVal fileName As String = "")
    txtServerFile.Text = ""
    Dim serverFolder As String = txtServerFolder.Text
    If serverFolder = "<ohne Hauptordner>" Then serverFolder = ""
    If serverFolder <> "" Then txtServerFile.Text += serverFolder + "__"

    If fileName = "" And lastShowFilename = "" Then
      txtServerFile.Text = ""
    ElseIf fileName = "" Then
      txtServerFile.Text += lastShowFilename
    Else
      txtServerFile.Text += fileName
    End If

    If txtServerFile.Text <> "" And Not txtServerFile.Text.ToLower.EndsWith(".zip") Then txtServerFile.Text += ".zip"
  End Sub


  Private Sub ftvLocalFolder_FolderClick(ByVal sender As System.Object, ByVal e As AxCCRPFolderTV6.__FolderTreeview_FolderClickEvent)
    If e.folder.FullPath <> "" And e.folder.FullPath.StartsWith("::") = False Then
      txtLocalFolder.Text = e.folder.FullPath
    Else
      txtLocalFolder.Text = ""
    End If
  End Sub

  Private Sub txtLocalFolder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocalFolder.KeyDown
    If e.KeyCode = Keys.Enter Then
      'Try

      DirectCast(ftvLocalUpload_Folder.SelectedFolder, CCRPFolderTV6.Folder).Name = txtLocalFolder.Text
      'Catch : End Try
      e.SuppressKeyPress = True


    End If
  End Sub

  Private Sub frm_main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    glob.saveTuttiFrutti(Me)
    glob.saveFormPos(Me)

    If (e.CloseReason <> CloseReason.TaskManagerClosing) And (isBusy Or processingJoblist) Then
      MsgBox("FolderSync kann nicht beendet werden, während noch Dateien hoch oder herunter geladen werden.", MsgBoxStyle.Exclamation, "Beenden nicht möglich")
      e.Cancel = True
    End If
    'startWebUpdate(True)
  End Sub

  Private Sub frm_main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode >= 120 And e.KeyCode <= 123 Then
      Dim fKey As Integer = e.KeyCode - 111
      Dim pathIndex As Integer = e.KeyCode - 119
      Dim path As String = glob.para("frm_options__shortcut" + pathIndex.ToString)
      If path = "" Then
        Dim res As MsgBoxResult = MsgBox("Für die Taste F" + fKey.ToString + " ist noch kein Shortcut festgelegt. Soll der Dialog 'Einstellungen' jetzt geöffnet werden?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "FolderSync Shortcuts")
        If res = MsgBoxResult.Yes Then frm_options.Show()
        Exit Sub
      End If

      'If e.Control Then
      ftvLocalUpload_Folder.SelectedFolder.Name = path
      txtLocalFolder.Text = path
      'ElseIf e.Alt Then
      '  ftvLocalTargetFolder.SelectedFolder.Name = path
      '  txtLocalTargetFolder.Text = path
      'Else
      '  MsgBox("pfad: " + path + vbNewLine + "[STRG] + [F-Taste] öffnet den Pfad im Uploadteil" + vbNewLine + _
      '         "[ALT] + [F-Taste] öffnet den Pfad im Downloadteil", MsgBoxStyle.Information)

      'End If




    End If
  End Sub

  Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    glob.readFormPos(Me)

    With m_border
      '  .Titlebar = False
    End With

    icon_txtSearch.Attach(txtSearch)
    icon_txtDiz.Attach(txtDiz)
    icon_txtSearch.ImageList = imlTreeView
    icon_txtDiz.ImageList = imlTreeView
    icon_txtSearch.Icon = 2
    icon_txtDiz.Icon = 3

    initShortcutButtons()
    initSplitterDesign()

    glob.readTuttiFrutti(Me)

    Me.Show()
    Application.DoEvents()

    Me.Text = "FolderSync " & fVersion
    Try
      FTP = New Utilities.FTP.FTPclient(glob.para("frm_options__ftp_host"), glob.para("frm_options__ftp_user"), glob.para("frm_options__ftp_pass"))

    Catch ex As Exception
      MsgBox("Fehler beim Aufbau der FTP-Verbindung!" + vbNewLine + "Bitte die entsprechenden Daten in den Einstellungen eintragen.")
      frm_options.Show()

    End Try
    Try
      ftvLocalUpload_Folder.SelectedFolder.name = glob.para("frm_main__txtLocalFolder")
    Catch : End Try


    btnRefreshServerFileList_Click(Nothing, Nothing)

    mwRegisterSelf()
    onCommandLinePara(My.Application.CommandLineArgs)

    frm_splash.Close()

    ' igProgBar1.Attach(igBatchList, igBatchList.Cols("progress"))

    tmrCheckUpdate.Enabled = True

  End Sub

  Sub initSplitterDesign()

    If glob.para("frm_options__checkLocalVertical", "FALSE") = "TRUE" Then
      splLocal.Orientation = Orientation.Vertical
    Else
      splLocal.Orientation = Orientation.Horizontal
    End If

    If glob.para("frm_options__checkShowServerFolderList", "TRUE") = "FALSE" Then
      splServer.Panel1Collapsed = True
    Else
      splServer.Panel1Collapsed = False
    End If


  End Sub
  Sub initShortcutButtons()
    lnkShortcutF9.Text = "F9: " + glob.para("frm_options__shortcut_text1")
    lnkShortcutF10.Text = "F10: " + glob.para("frm_options__shortcut_text2")
    lnkShortcutF11.Text = "F11: " + glob.para("frm_options__shortcut_text3")
    lnkShortcutF12.Text = "F12: " + glob.para("frm_options__shortcut_text4")

  End Sub

  Private Sub OrdnerLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdnerLöschenToolStripMenuItem.Click
    If lvServerFile.SelectedItems.Count = 0 Then Exit Sub
    Dim lvi As ListViewItem = lvServerFile.SelectedItems(0)

    If lvi.Tag.ToLower.EndsWith(".zip") Then
      Dim res As MsgBoxResult
      res = MsgBox("Möchten Sie den Ordner " + lvi.Tag + " endgültig vom Server löschen?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "FolderSync - Ordner löschen")

      If res = MsgBoxResult.Yes Then
        FTP.FtpDelete(glob.para("frm_options__ftp_dir") + lvi.Tag)
        btnRefreshServerFileList_Click(Nothing, Nothing)
      End If

    End If

  End Sub

  Sub processBatchList()


  End Sub

  Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
    'For Each item As ListViewItem In lvServerFile.CheckedItems
    '  item.Selected = True
    '  item.EnsureVisible()

    '  Dim localTargetFolder As String = lvServerFile.SelectedItems(0).Text
    '  localTargetFolder = localTargetFolder.Substring(0, localTargetFolder.Length - 4)
    '  localTargetFolder = FP(txtLocalFolder.Text, localTargetFolder)

    '  download(localTargetFolder, txtServerFile.Text)

    '  While isBusy
    '    Application.DoEvents()
    '    Threading.Thread.Sleep(11)
    '  End While

    'Next

    'finishMessage()

  End Sub

  Private Sub ftvLocalUpload_Folder_SelectionChange(ByVal sender As Object, ByVal e As AxCCRPFolderTV6.__FolderTreeview_SelectionChangeEvent) Handles ftvLocalUpload_Folder.SelectionChange
    txtLocalFolder.Text = e.folder.FullPath

    'Stop
    lvLocalFolder.Items.Clear()
    imlLocalFolder.Images.Clear()
    For Each fld As String In Directory.GetDirectories(e.folder.FullPath)
      imlLocalFolder.Images.Add(fld, GetAssociatedIcon(fld, assoc_iconSize.SHGFI_SMALLICON))
      lvLocalFolder.Items.Add(fld.Substring(fld.LastIndexOf("\") + 1), fld)
    Next
  End Sub

  Private Sub lvLocalFolder_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLocalFolder.Resize
    lvLocalFolder.Columns(0).Width = lvLocalFolder.Width - 24
  End Sub

  'Private Sub clbLocalUpload_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
  '  If e.Button = Windows.Forms.MouseButtons.Right Then
  '    Dim idx As Integer = clbLocalUpload.IndexFromPoint(e.Location)
  '    If idx = -1 Then Exit Sub
  '    Dim f As String = ftvLocalUpload_Folder.SelectedFolder.name
  '    ftvLocalUpload_Folder.SelectedFolder.name = glob.fp(f, clbLocalUpload.Items(idx))


  '  End If
  'End Sub

  Private Sub lvLocalFolder_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvLocalFolder.SelectedIndexChanged
    On Error Resume Next
    lastShowFilename = ""
    lastShowFilename = lvLocalFolder.SelectedItems(0).Text
    refreshServerFileName("")

  End Sub

  Private Sub txtServerFolder_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtServerFolder.MouseUp
    If e.Button = Windows.Forms.MouseButtons.Right Then
      Dim index As Integer = (e.Y - 20) / txtServerFolder.ItemHeight
      If index > txtServerFolder.Items.Count - 2 Then fillServerListview("") : Exit Sub
      txtServerFolder.SelectedIndex = index + 1

      Dim serverFolder As String = txtServerFolder.Items(index + 1)
      If serverFolder = "<ohne Hauptordner>" Then serverFolder = "__nogroup"

      txtSearch.Text = ""
      fillServerListview(serverFolder)


    End If
  End Sub

  'Private Sub ftvLocalTargetFolder_FolderClick(ByVal sender As System.Object, ByVal e As AxCCRPFolderTV6.__FolderTreeview_FolderClickEvent)
  '  txtLocalTargetFolder.Text = e.folder.FullPath
  'End Sub

  Private Sub txtServerFolder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServerFolder.TextChanged
    txtServerFile.Text = ""
  End Sub

  'Private Sub lnkTargetExplorer_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
  '  Process.Start("explorer.exe", "/e," + txtLocalTargetFolder.Text)
  'End Sub

  'Private Sub txtLocalTargetFolder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
  '  If e.KeyCode = Keys.Enter Then
  '    Try
  '      ftvLocalTargetFolder.SelectedFolder.name = txtLocalTargetFolder.Text
  '    Catch : End Try
  '    e.SuppressKeyPress = True
  '  End If
  'End Sub


  Private Sub lvServerFile_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvServerFile.Resize
    lvServerFile.Columns(0).Width = lvServerFile.Width - 252

  End Sub

  Private Sub lvServerFile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvServerFile.SelectedIndexChanged
    If lvServerFile.SelectedItems.Count = 0 Then Exit Sub

    Dim lvi As ListViewItem = lvServerFile.SelectedItems(0)
    txtServerFolder.Text = lvi.SubItems(1).Text
    lastShowFilename = ""
    refreshServerFileName(lvi.Text)


  End Sub

  Private Sub DateilisteAnzeigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateilisteAnzeigenToolStripMenuItem.Click
    If lvServerFile.SelectedItems.Count = 0 Then Exit Sub

    Dim lvi As ListViewItem = lvServerFile.SelectedItems(0)

    'Dim fileList As String = TwAjax.getUrlContent("http://teamwiki.de/twiki/write_post.php?mode=getzipfilecontent&file=/foldersync/" + lvi.Tag)
    Dim fileList As String = TwAjax.ReadFile("foldersync_meta", "filelist_" + lvi.Tag + ".txt")

    Dim lines() As String = Split(fileList, vbNewLine)

    frm_fileList.ListView1.Items.Clear()
    For Each lin As String In lines
      frm_fileList.ListView1.Items.Add(lin)
    Next


    frm_fileList.Text = "Dateiliste " + lvi.Tag + " - FolderSync"
    frm_fileList.Show()

  End Sub


  Sub finishMessage()
    On Error Resume Next

    If glob.para("frm_options__chk_finish_windowtotop") = "TRUE" Then
      AppActivate(Me.Text)

    End If

    If glob.para("frm_options__chk_finish_playsound") = "TRUE" Then
      If glob.para("frm_options__finish_soundfile") = "" Then
        My.Computer.Audio.Play("C:\windows\media\tada.wav")
      Else

        My.Computer.Audio.Play(glob.para("frm_options__finish_soundfile"))
      End If

    End If

    If glob.para("frm_options__chk_finish_messagebox") = "TRUE" Then
      MsgBox("Der Up-/Download ist jetzt abgeschlossen.", MsgBoxStyle.Information, "FolderSync")

    End If

  End Sub


  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    On Error Resume Next
    ProgressBar1.Value += 1
    If ProgressBar1.Value = ProgressBar1.Maximum Then ProgressBar1.Value = 0
  End Sub

  Private Sub lnkShortcut_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkShortcutF9.LinkClicked, lnkShortcutF12.LinkClicked, lnkShortcutF11.LinkClicked, lnkShortcutF10.LinkClicked
    Dim path As String = glob.para("frm_options__shortcut" + sender.tag)
    If path = "" Then
      Dim res As MsgBoxResult = MsgBox("Für diesen Link ist noch kein Ordner festgelegt. Soll der Dialog 'Einstellungen' jetzt geöffnet werden?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "FolderSync Shortcuts")
      If res = MsgBoxResult.Yes Then frm_options.Show()
      Exit Sub
    End If

    ftvLocalUpload_Folder.SelectedFolder.Name = path
    txtLocalFolder.Text = path
  End Sub

  Private Sub btnServerList_showAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServerList_showAll.Click
    txtSearch.Text = ""
    txtServerFolder.Text = ""
    txtServerFolder.SelectedIndex = -1
    'fillServerListview("")

  End Sub

  Private Sub UmbennenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UmbennenToolStripMenuItem.Click
    If lvServerFile.SelectedItems.Count = 0 Then Exit Sub
    Dim lvi As ListViewItem = lvServerFile.SelectedItems(0)

    If lvi.Tag.ToLower.EndsWith(".zip") Then
      Dim newName As String = InputBox("Umbennenen des Ordners " + lvi.Tag + " in:", "Foldersync", lvi.Tag)
      If newName = "" Then Exit Sub

      Try
        FTP.FtpRename(glob.para("frm_options__ftp_dir") + lvi.Tag, glob.para("frm_options__ftp_dir") + newName)
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical)
      End Try
      btnRefreshServerFileList_Click(Nothing, Nothing)


    End If
  End Sub


  Private Sub checkCreateBackup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCreateBackup.CheckedChanged
    If checkCreateBackup.Checked = True And glob.para("frm_options__backupFolder") = "" Then
      MsgBox("bitte erst einen Backupfolder in den Optionen einstellen")
      checkCreateBackup.Checked = False

    End If
  End Sub


  Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
  Handles PictureBox1.MouseDown
    If e.Button = Windows.Forms.MouseButtons.Left Then
      FormMoveTricky(Me.Handle)

    End If
  End Sub

  Private Sub tmrCheckUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckUpdate.Tick
    'tmrCheckUpdate.Interval = 1800000 'alle halbe Stunde ernaut suchen
    tmrCheckUpdate.Stop()

    startWebUpdate(True)
  End Sub




  Private Sub lnkUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkUpdate.LinkClicked
    startWebUpdate(False)

  End Sub

  Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    Me.Close()

  End Sub

  Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
    Me.WindowState = FormWindowState.Minimized
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessJobList.Click
    processJobList()
  End Sub

  Private Sub btnUpload_Mousedown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnUpload.MouseDown

    If lvLocalFolder.SelectedItems.Count <> 1 Then Exit Sub
    Dim remote As String, loc As String
    loc = lvLocalFolder.SelectedItems(0).Text
    refreshServerFileName()
    Dim lw = txtServerFile.Text.ToLower
    If lw.Contains("ä"c) Or lw.Contains("ö"c) Or lw.Contains("ü"c) Or lw.Contains(" "c) Or lw.Contains("ß"c) Then
      MsgBox("der Dateiname darf keine Sonderzeichen enthalten!")
      Exit Sub
    End If

    addJobToList(FP(txtLocalFolder.Text, loc), txtServerFile.Text, True, e.Button = Windows.Forms.MouseButtons.Right)

  End Sub

  Private Sub btnDownload_Mousedown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnDownload.MouseDown
    If lvServerFile.SelectedItems.Count = 0 Then Exit Sub

    Dim lvi As ListViewItem = lvServerFile.SelectedItems(0)
    txtServerFolder.Text = lvi.SubItems(1).Text
    lastShowFilename = ""
    refreshServerFileName(lvi.Text)

    Dim localTargetFolder As String = lvServerFile.SelectedItems(0).Text
    localTargetFolder = localTargetFolder.Substring(0, localTargetFolder.Length - 4)
    localTargetFolder = FP(txtLocalFolder.Text, localTargetFolder)

    addJobToList(localTargetFolder, txtServerFile.Text, False, e.Button = Windows.Forms.MouseButtons.Right)

  End Sub

  Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
    fillServerListview()
  End Sub


  Private Sub btnCancelProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelProcess.Click
    cancelProcess = True
  End Sub

  Private Sub igBatchList_CellMouseUp(ByVal sender As Object, ByVal e As TenTec.Windows.iGridLib.iGCellMouseUpEventArgs) Handles igBatchList.CellMouseUp
    If e.Button = Windows.Forms.MouseButtons.Right Then
      deleteJob(e.RowIndex)

    End If
  End Sub

  Private Sub lnkTeamwiki_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTeamwiki.LinkClicked
    Process.Start("http://vbnet.teamwiki.de/foldersync.html")

  End Sub

  Private Sub lnkAbout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAbout.LinkClicked
    frm_splash.Label1.Hide()
    frm_splash.Button1.Show()
    frm_splash.Show()

  End Sub


  Private Sub lnkClearSuchbox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lnkClearSuchbox.MouseClick
    txtSearch.Text = ""

  End Sub

  Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

  End Sub

  Private Sub txtDiz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiz.TextChanged
    If txtDiz.Text = "DIZ" Then
      glob.para("diz") = ""
    Else
      glob.para("diz") = txtDiz.Text

    End If

  End Sub

  Private Sub btnDelJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelJob.Click
    If igBatchList.CurRow IsNot Nothing Then deleteJob(igBatchList.CurRow.Index)
  End Sub

  Sub deleteJob(ByVal rowIndex As Integer)
    If igBatchList.Cells(rowIndex, "progress").Value = "Warten..." Then
      igBatchList.Rows.RemoveAt(rowIndex)

    End If
  End Sub

  Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
    frm_options.Show()
    frm_options.Activate()

  End Sub

  Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
    If lvLocalFolder.SelectedItems.Count <> 1 Then
      Process.Start("explorer.exe", "/e," + txtLocalFolder.Text)
    Else
      Process.Start("explorer.exe", "/e,/select," + FP(txtLocalFolder.Text, lvLocalFolder.SelectedItems(0).Text))
    End If
  End Sub

  Private Sub btnNewestUploads_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewestUploads.Click
    frm_news.Show()
    frm_news.Activate()
  End Sub

End Class
