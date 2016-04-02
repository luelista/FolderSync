Imports FolderSync

Public Class frm_fileList

  Private Sub frm_fileList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Friend Sub LoadFromInfo(info As ArchiveInfoFile)
    TextBox1.Text = info.UserName
    TextBox2.Text = info.Comment

    ListView1.Items.Clear()
    For Each lin As String In info.FileList
      ListView1.Items.Add(lin)
    Next

    Text = "Eigenschaften von " + info.ArchiveName + ""
  End Sub
End Class