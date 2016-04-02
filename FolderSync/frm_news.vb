Public Class frm_news

  Private Sub frm_news_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    glob.saveFormPos(Me)
    glob.para("frm_news__igDesign") = IGrid1.LayoutObject.Text
  End Sub

  Private Sub frm_news_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    On Error Resume Next
    Me.Text = "Neuste Uploads - FolderSync " & fVersion
    glob.readFormPos(Me)
    IGrid1.LayoutObject.Text = glob.para("frm_news__igDesign")

    'Stop
    refreshNewUploads()
  End Sub

  Sub refreshNewUploads()
    Dim cont As String = TwAjax.getUrlContent("http://teamwiki.de/twiki/tools/foldersync_news.php?format=vbfriendly")
    Dim LINES() = Split(cont, vbLf)
    If LINES(0) <> "OK" Then MsgBox(cont)

    IGrid1.Rows.Clear()
    IGrid1.SortObject.Clear()

    For Each lin In LINES
      If lin = "" Or lin = "OK" Then Continue For
      Dim PARTS() = Split(lin, "|##|")
      With IGrid1.Rows.Add
        .Cells(0).Value = PARTS(0)
        .Cells(1).Value = PARTS(1)
        .Cells(2).Value = PARTS(2)
        Dim size As Integer = PARTS(3), sFileSize As String = ""
        If size > 1000000 Then
          sFileSize = CInt(size / 1000000).ToString + " MB"
        ElseIf size > 1000 Then
          sFileSize = CInt(size / 1000).ToString + " kB"
        Else
          sFileSize = size.ToString + " B"
        End If
        .Cells(3).Value = sFileSize
      End With
    Next

    IGrid1.SortObject.Add(2, TenTec.Windows.iGridLib.iGSortOrder.Descending)
    IGrid1.Sort()
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Me.Close()

  End Sub

  Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    'WebBrowser1.Navigate("http://teamwiki.de/twiki/tools/foldersync_news.php?maxcount=")

  End Sub
End Class