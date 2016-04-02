'Public Class frm_trash


'  Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    frm_options.ShowDialog()

'  End Sub


'  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim sourceFolder, destFolder As String
'    sourceFolder = FP(glob.para("sourceFolder"))
'    destFolder = glob.para("destFolder")
'    If Not Directory.Exists(sourceFolder) Then Directory.CreateDirectory(sourceFolder)

'    'Dim tmp As Utilities.FTP.FTPdirectory
'    'tmp = FTP.ListDirectoryDetail(destFolder)

'    Dim serverDirs As Dictionary(Of String, String)
'    serverDirs = GetServerDirList(destFolder)
'    'Dim serverDirs As New Dictionary(Of String, Utilities.FTP.FTPfileInfo)
'    'For Each f As Utilities.FTP.FTPfileInfo In tmp
'    '  serverDirs.Add(f.FullName, f)
'    'Next

'    Dim lvi As ListViewItem, fileSpecPart, serverFileSpec As String
'    Dim serverDateTime, clientDateTime As Date
'    ListView1.Items.Clear()
'    For Each file As String In My.Computer.FileSystem.GetFiles(sourceFolder, FileIO.SearchOption.SearchAllSubDirectories)
'      fileSpecPart = file.Replace(sourceFolder, "")
'      serverFileSpec = FP_linux(destFolder, fileSpecPart)

'      lvi = ListView1.Items.Add(file)
'      lvi.SubItems.Add(serverFileSpec)


'      clientDateTime = System.IO.File.GetLastWriteTime(file)

'      If serverDirs.ContainsKey(serverFileSpec) Then
'        Date.TryParse(serverDirs(serverFileSpec), serverDateTime)

'        If clientDateTime > serverDateTime Then
'          lvi.SubItems.Add("-> upload")
'        ElseIf clientDateTime < serverDateTime Then
'          lvi.SubItems.Add("<- download")
'        End If

'      Else
'        lvi.SubItems.Add("->upload")
'      End If


'    Next
'  End Sub

'  Private Sub frm_main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
'    glob.saveTuttiFrutti(Me)
'    glob.saveFormPos(Me)

'  End Sub

'  Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'    FTP = New Utilities.FTP.FTPclient("teamwiki.de", "vserver3", "lezifato")
'    glob.readTuttiFrutti(Me)
'    glob.readFormPos(Me)
'    Try
'      ftvLocalFolder.SelectedFolder.name = txtLocalFolder.Text
'    Catch : End Try
'  End Sub

'  Function FP(ByVal p As String, Optional ByVal f As String = "") As String
'    FP = p + IIf(p.EndsWith("\"), "", "\") + f
'  End Function

'  Function FP_linux(ByVal p As String, Optional ByVal f As String = "") As String
'    Dim path, file As String
'    path = p.Replace("\", "/")
'    file = f.Replace("\", "/")
'    FP_linux = path + IIf(path.EndsWith("/"), "", "/") + file
'  End Function

'  Function un_FP(ByVal p As String) As String

'  End Function

'  Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



'  End Sub

'  Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim sourceFolder, destFolder As String
'    sourceFolder = FP(glob.para("sourceFolder"))
'    destFolder = glob.para("destFolder")

'    ListView2.Items.Clear()
'    Dim dirList As Dictionary(Of String, String)
'    dirList = GetServerDirList(destFolder)
'    Dim lvi As ListViewItem
'    For Each fileSpec As String In dirList.Keys
'      lvi = ListView2.Items.Add(fileSpec)
'      lvi.SubItems.Add(dirList(fileSpec))
'    Next

'    'Dim cont As String = GetUrlContent("http://teamwiki.de/twiki/write_post.php?mode=dirlist_r&dir=" + destFolder)
'    'cont = getSplitPart(cont)
'    'Dim dirList() As String = cont.Split(vbLf)
'    'For Each line As String In dirList
'    '  ListView2.Items.Add(line)
'    'Next
'  End Sub


'  Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
'    WebBrowser1.Visible = Not WebBrowser1.Visible
'    WebBrowser1.BringToFront()


'  End Sub

'  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim serverFileSpec, clientFileSpec, serverHomedir, serverFolder, last_serverFolder As String
'    Dim result As Boolean, lvi2 As ListViewItem
'    serverHomedir = glob.para("serverHomedir")
'    ListView2.Items.Clear()
'    last_serverFolder = ""
'    For Each lvi As ListViewItem In ListView1.Items
'      lvi.EnsureVisible()
'      serverFileSpec = lvi.SubItems(1).Text

'      If lvi.SubItems(2).Text.EndsWith("upload") = False Then
'        lvi2 = ListView2.Items.Add(serverFileSpec)
'        lvi2.SubItems.Add("SKIP")
'        lvi2.EnsureVisible()
'        Application.DoEvents()
'        Continue For
'      End If

'      clientFileSpec = lvi.SubItems(0).Text
'      serverFolder = serverHomedir + serverFileSpec.Substring(0, serverFileSpec.LastIndexOf("/"))
'      If last_serverFolder <> serverFolder Then
'        FTP.FtpCreateDirectory(serverFolder)
'        last_serverFolder = serverFolder
'      End If

'      'MsgBox("clientFileSpec: " + clientFileSpec + vbNewLine + "serverFileSpec: " + serverFileSpec, , "FolderSync - upload")
'      lvi2 = ListView2.Items.Add(serverFileSpec)
'      lvi2.SubItems.Add("upload ...")
'      lvi2.EnsureVisible()
'      Application.DoEvents()
'      result = FTP.Upload(clientFileSpec, serverHomedir + serverFileSpec)


'      If result Then
'        lvi2.SubItems(1).Text = "ok"
'      Else
'        lvi2.SubItems(1).Text = "err"
'      End If
'      Application.DoEvents()
'    Next
'  End Sub

'  Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    ListBox1.Items.Clear()

'    Application.DoEvents()
'    Dim zipFile As New ICSharpCode.SharpZipLib.Zip.ZipFile(txtZipFile.Text)


'    For Each zipEntry As ICSharpCode.SharpZipLib.Zip.ZipEntry In zipFile
'      ListBox1.Items.Add(zipEntry.Name)

'    Next

'  End Sub

'  Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    Dim fastZip As New ICSharpCode.SharpZipLib.Zip.FastZip
'    Directory.CreateDirectory(txtZip_Folder.Text)
'    fastZip.ExtractZip(txtZipFile.Text, txtZip_Folder.Text, "")

'  End Sub

'  Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    Dim fastZip As New ICSharpCode.SharpZipLib.Zip.FastZip
'    fastZip.CreateZip(txtZipFile.Text, txtZip_Folder.Text, True, "")


'  End Sub
'End Class