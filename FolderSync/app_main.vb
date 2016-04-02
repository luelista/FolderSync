Module app_main
  Public glob As New cls_globPara()
  Public FTP As Utilities.FTP.FTPclient

  Public fVersion As String = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
  Public processingJoblist As Boolean = False
  Public cancelProcess As Boolean = False

  Sub startWebUpdate(ByVal autoUpdate As Boolean)

    Dim updaterFilespec As String = ExePath("mwwebupdate")

    If updaterFilespec = "" OrElse My.Computer.FileSystem.FileExists(updaterFilespec) = False OrElse FileLen(updaterFilespec) < 40000 Then
      If Not autoUpdate Then MsgBox("Der Updater wurde nicht gefunden bzw. du hast eine veraltete Version. " + vbNewLine + "Wenn du die neuste Version hast, starte den Updater einmal von Hand und versuche es nochmals. Ansonsten melde dich bei Max Weller ;-)")
      Exit Sub
    End If

    Dim updaterPara(5) As String
    updaterPara(0) = "foldersync" 'appID
    updaterPara(1) = glob.appPath 'localFolder
    updaterPara(2) = "/autostart" 'autostart?
    updaterPara(3) = "/autoclose" 'autoclose?
    updaterPara(4) = Application.ExecutablePath 'startAfterUpdate(1)
    updaterPara(5) = "" 'startAfterUpdate(2)
    Dim updaterArguments As String = Join(updaterPara, "#²#")

    'MsgBox(updaterFilespec + " " + updaterArguments, , "Updater wird aufgerufen...")

    glob.saveParaFile()
    Process.Start(updaterFilespec, updaterArguments)

  End Sub

  Sub onCommandLinePara(ByVal cm As System.Collections.ObjectModel.ReadOnlyCollection(Of String))
    If cm.Count > 2 Then
      If cm(0) = "up" Then
        upload(cm(1), cm(2))

      Else

        download(cm(1), cm(2))

      End If

    End If


  End Sub

  Function FP(ByVal p As String, Optional ByVal f As String = "") As String
    FP = p + IIf(p.EndsWith("\"), "", "\") + f
  End Function

  Function FP_linux(ByVal p As String, Optional ByVal f As String = "") As String
    Dim path, file As String
    path = p.Replace("\", "/")
    file = f.Replace("\", "/")
    FP_linux = path + IIf(path.EndsWith("/"), "", "/") + file
  End Function

End Module
