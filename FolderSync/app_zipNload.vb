Imports System.IO

Module app_zipNload
  Const fileInfoSplitter = vbNewLine + ";-) fsfi-Splitter]~#|"
  Dim WithEvents bgWork As New System.ComponentModel.BackgroundWorker()

  Dim locFolder, serverFile As String
  Dim direction_up As Boolean
  Dim _busy As Boolean
  Dim actJobListRowIndex As Integer


  Property isBusy() As Boolean
    Get
      isBusy = _busy
    End Get
    Set(ByVal value As Boolean)
      With frm_main
        '.SuspendLayout()
        '.GroupBox1.Enabled = Not value
        '.GroupBox2.Enabled = Not value
        '.GroupBox3.Enabled = Not value

        '.btnShortcutF10.Enabled = Not value
        '.btnShortcutF11.Enabled = Not value
        '.btnShortcutF12.Enabled = Not value
        '.btnShortcutF9.Enabled = Not value

        .Timer1.Enabled = value
        If value = False Then .ProgressBar1.Value = 0
        '.btnUpload.Enabled = Not value
        '.btnDownload.Enabled = Not value

        '.ResumeLayout()
        Application.DoEvents()

        _busy = value
      End With
    End Set
  End Property

  Sub upload(ByVal loc As String, ByVal remote As String)
    'If frm_main.txtLocalFolder.Text = "" Or frm_main.txtServerFile.Text = "" Then
    '  Beep()
    '  Exit Sub
    'End If

    direction_up = True
    locFolder = loc
    serverFile = remote
    

    isBusy = True

    bgWork.WorkerReportsProgress = True
    bgWork.RunWorkerAsync()


  End Sub

  Sub download(ByVal loc As String, ByVal remote As String)
    'If frm_main.txtLocalFolder.Text = "" Or frm_main.txtServerFile.Text = "" Then
    '  Beep()
    '  Exit Sub
    'End If

    direction_up = False
    locFolder = loc
    serverFile = remote
    If Directory.Exists(locFolder) Then
      If glob.para("frm_options__checkCreateBackup", "TRUE") = "TRUE" Then
        Dim backup As String = getBackupFolder(loc)
        '  MsgBox(backup)
        Try
          IO.Directory.Move(loc, backup)
        Catch ex As Exception
          MsgBox("Der Zielordner konnte nicht in den Backupordner verschoben werden. Bitte stelle sicher, dass er nicht mehr verwendet wird." + vbNewLine + "Grund: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
      Else
        Select Case MsgBox("Achtung! Der lokale Ordner " + locFolder + " existiert schon. Der Ordner wird nicht überschrieben. Soll der Ordner vorher gelöscht werden? Andernfalls wird der Ordner nicht gedownloadet!", MsgBoxStyle.YesNoCancel)
          Case MsgBoxResult.Yes
            Try
              Directory.Delete(locFolder, True)
            Catch ex As Exception
              If MsgBox("Der Ordner konnte nicht gelöscht werden." + vbNewLine + "Grund: " + ex.Message + vbNewLine + "Trotzdem downloaden?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
            End Try
          Case MsgBoxResult.No
          Case MsgBoxResult.Cancel
            Exit Sub
        End Select

      End If
      
    End If
    Directory.CreateDirectory(locFolder)

    isBusy = True

    bgWork.WorkerReportsProgress = True
    bgWork.RunWorkerAsync()

  End Sub
  Sub saveFilelist()
    '!!! locFolder+serverFile sind globVars

    Dim files() As String = IO.Directory.GetFiles(locFolder, "*", SearchOption.AllDirectories)
    Dim fileList As String = Join(files, vbNewLine)

    TwAjax.SaveFile("foldersync_meta", "filelist_" + serverFile + ".txt", fileList)

  End Sub
  Private Sub bgWork_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgWork.DoWork
    Dim fastZip As New ICSharpCode.SharpZipLib.Zip.FastZip

    If direction_up Then 'upload
      bgWork.ReportProgress(1)

      Dim tmpZipName As String = _
        FP(My.Computer.FileSystem.SpecialDirectories.Temp, _
           "temp_" + Microsoft.VisualBasic.Timer().ToString + ".zip")

      writeFileInformation()

      fastZip.CreateZip(tmpZipName, locFolder, True, "")

      If cancelProcess Then Exit Sub
      bgWork.ReportProgress(2)

      FTP.Upload(tmpZipName, glob.para("frm_options__ftp_dir") + serverFile)

      File.Delete(tmpZipName)

    Else 'download
      bgWork.ReportProgress(3)

      'Stop
      Dim tmpZipName As String = _
        FP(My.Computer.FileSystem.SpecialDirectories.Temp, _
           "temp_" + Microsoft.VisualBasic.Timer.ToString() + ".zip")

      FTP.Download(glob.para("frm_options__ftp_dir") + serverFile, tmpZipName)

      If cancelProcess Then Exit Sub
      bgWork.ReportProgress(4)

      fastZip.ExtractZip(tmpZipName, locFolder, ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Always, Nothing, "", "", True)

      File.Delete(tmpZipName)

    End If
  End Sub

  Function confirmOverwrite(ByVal fileName As String) As Boolean

  End Function

  Private Sub bgWork_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWork.ProgressChanged
    Dim text As String = ""
    Select Case e.ProgressPercentage
      Case 1 : text = "Komprimieren ..."
      Case 2 : text = "Hochladen ..."
      Case 3 : text = "Herunterladen ..."
      Case 4 : text = "Dekomprimieren ..."
    End Select
    frm_main.igBatchList.Cells(0, "progress").Value = text
  End Sub

  Private Sub bgWork_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWork.RunWorkerCompleted
    If direction_up Then frm_main.btnRefreshServerFileList_Click(Nothing, Nothing)

    isBusy = False

    frm_main.labState.Text = "Bereit."
    frm_main.finishMessage()
  End Sub

  Function getBackupFolder(ByVal loc As String) As String
    Return glob.fp(glob.para("frm_options__backupFolder"), IO.Path.GetFileName(loc) + Now.ToString("_yyyy-MM-dd__HHmmss"))

  End Function

  Sub writeFileInformation()
    Dim info As New ArchiveInfoFile
    info.FileList = New List(Of String)

    Dim fileList() As String = Directory.GetFiles(locFolder, "*", SearchOption.AllDirectories)
    Dim startPos As Integer = locFolder.Length
    For i As Integer = 0 To fileList.Length - 1
      info.FileList.Add(fileList(i).Substring(startPos))
    Next

    info.UserName = glob.para("diz").PadRight(22)
    info.Comment = "KOM"
    info.ArchiveName = serverFile

    Dim tmpName As String =
        FP(My.Computer.FileSystem.SpecialDirectories.Temp,
           serverFile + ".nfo")
    info.Write(tmpName)
    FTP.Upload(tmpName, glob.para("frm_options__ftp_dir") + IO.Path.ChangeExtension(serverFile, "nfo"))

  End Sub

  Function getFileInformation(ByVal serverFileName As String) As ArchiveInfoFile
    Dim tmpName As String =
        FP(My.Computer.FileSystem.SpecialDirectories.Temp,
           serverFileName + ".nfo")
    FTP.Download(glob.para("frm_options__ftp_dir") + IO.Path.ChangeExtension(serverFileName, "nfo"), tmpName, True)

    Return ArchiveInfoFile.Read(tmpName)

  End Function

End Module
