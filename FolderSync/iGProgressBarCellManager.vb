Imports TenTec.Windows.iGridLib

Public Class iGProgressBarCellManager

	Public Sub Attach(ByVal pGrid As iGrid, ByVal pCol As iGCol)
		pCol.CellStyle.CustomDrawFlags = pCol.CellStyle.CustomDrawFlags Or iGCustomDrawFlags.Foreground
		AddHandler pGrid.CustomDrawCellForeground, AddressOf CustomDrawCellForeground
	End Sub

	Private Sub CustomDrawCellForeground(ByVal sender As Object, ByVal e As iGCustomDrawCellEventArgs)
		Dim grid As iGrid = DirectCast(sender, iGrid)

		Dim myObjValue As Object = grid.Cells(e.RowIndex, e.ColIndex).Value

		If myObjValue Is Nothing Then
			Return
    End If

    Dim textDesc As String
		Dim myBounds As Rectangle = e.Bounds
		myBounds.Inflate(-2, -2)
		myBounds.Width = myBounds.Width - 1
		myBounds.Height = myBounds.Height - 1
		If (myBounds.Width > 0) Then
      e.Graphics.FillRectangle(Brushes.Bisque, myBounds)

      Dim myValue As Double
      Try : myValue = CDbl(myObjValue) : textDesc = ""
      Catch : myValue = 0 : textDesc = myObjValue
      End Try

			Dim myWidth As Integer = CInt(myBounds.Width * myValue)
			e.Graphics.FillRectangle(Brushes.SandyBrown, myBounds.X, myBounds.Y, myWidth, myBounds.Height)

			e.Graphics.DrawRectangle(Pens.SaddleBrown, myBounds)

			Dim myStringFormat As StringFormat = New StringFormat
			myStringFormat.Alignment = StringAlignment.Center
      myStringFormat.LineAlignment = StringAlignment.Center
      If textDesc = "" Then textDesc = String.Format("{0:F2}%", myValue * 100)
      e.Graphics.DrawString(textDesc, grid.Font, SystemBrushes.ControlText, New Rectangle(myBounds.X, myBounds.Y, myBounds.Width, myBounds.Height), myStringFormat)
		End If
	End Sub

End Class
