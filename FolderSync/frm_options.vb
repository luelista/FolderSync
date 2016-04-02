Imports System.Windows.Forms

Public Class frm_options

  Private Sub frm_options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    glob.readTuttiFrutti(Me)
  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
    save()
  End Sub

  Private Sub btnHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim tx As String = "Um die Shortcuts aufzurufen, drücke ..." + vbNewLine + _
    "* [STRG] + [F-Taste] um das 'Lokal Upload'-Treeview zu navigieren oder" + vbNewLine + _
    "*   [ALT] + [F-Taste] um das 'Lokal Download'-Treeview zu navigieren"

    MessageBox.Show(tx, "Benutzung der Shortcut-Tasten", MessageBoxButtons.OK, MessageBoxIcon.Information)

  End Sub

  Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    Me.Close()

  End Sub
  Function save() As Boolean
    If checkCreateBackup.Checked And backupFolder.Text = "" Then
      MsgBox("Bitte einen Backupfolder einstellen")
      Return False
    End If
    glob.saveTuttiFrutti(Me)
    frm_main.initShortcutButtons()
    frm_main.initSplitterDesign()
    FTP = New Utilities.FTP.FTPclient(glob.para("frm_options__ftp_host"), glob.para("frm_options__ftp_user"), glob.para("frm_options__ftp_pass"))
    Try
      FTP.ListDirectory(glob.para("frm_options__ftp_dir"))

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Ungültige FTP-Zugangsdaten oder Server nicht erreichbar")
      Return False
    End Try

    Return True
  End Function
  Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
    If save() Then _
      Me.Close()

  End Sub

  Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    With fbd1
      .Description = "Bitte wähle den Backupordner aus..."
      .SelectedPath = backupFolder.Text
      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        backupFolder.Text = .SelectedPath
      End If
    End With
  End Sub

  Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    With OpenFileDialog1
      .Filter = "Wave-Sounddateien (.wav)|*.wav"
      .FileName = If(finish_soundfile.Text <> "", finish_soundfile.Text, "C:\windows\media\ding.wav")
      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        finish_soundfile.Text = .FileName
      End If
    End With
  End Sub

  Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    Dim parts() As String = New String() {"[fsPwdList", "", "", ftp_host.Text, ftp_dir.Text, ftp_user.Text, ftp_pass.Text, "eot]"}
    Clipboard.Clear()
    Dim out = Join(parts, "$fs$")

    Clipboard.SetText(out)

  End Sub

  Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
    Dim parts() = Split(Clipboard.GetText, "$fs$")
    If parts.Length <> 8 OrElse parts(0).EndsWith("[fsPwdList") = False OrElse parts(7).StartsWith("eot]") = False Then
      MsgBox("ungültiges Format")
      Exit Sub
    End If
    ftp_host.Text = parts(3)
    ftp_dir.Text = parts(4)
    ftp_user.Text = parts(5)
    ftp_pass.Text = parts(6)


  End Sub

  Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

  End Sub
End Class
