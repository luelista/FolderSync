Public Class frm_splash

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Me.Close()
  End Sub

  Private Sub frm_splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Label2.Text = "Version " & fVersion
    Show()
    Application.DoEvents()

  End Sub
End Class