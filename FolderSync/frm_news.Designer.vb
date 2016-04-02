<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_news
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim IGColPattern1 As TenTec.Windows.iGridLib.iGColPattern = New TenTec.Windows.iGridLib.iGColPattern
    Dim IGColPattern2 As TenTec.Windows.iGridLib.iGColPattern = New TenTec.Windows.iGridLib.iGColPattern
    Dim IGColPattern3 As TenTec.Windows.iGridLib.iGColPattern = New TenTec.Windows.iGridLib.iGColPattern
    Dim IGColPattern4 As TenTec.Windows.iGridLib.iGColPattern = New TenTec.Windows.iGridLib.iGColPattern
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_news))
    Me.IGrid1Col0CellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.IGrid1Col0ColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.IGrid1Col1CellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.IGrid1Col1ColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.IGrid1Col2CellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.IGrid1Col2ColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.IGrid1Col3CellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.IGrid1Col3ColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.Button1 = New System.Windows.Forms.Button
    Me.Button2 = New System.Windows.Forms.Button
    Me.IGrid1 = New TenTec.Windows.iGridLib.iGrid
    Me.IGrid1DefaultCellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.IGrid1DefaultColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.IGrid1RowTextColCellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    CType(Me.IGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'IGrid1Col0CellStyle
    '
    Me.IGrid1Col0CellStyle.ContentIndent = New TenTec.Windows.iGridLib.iGIndent(1, 1, 8, 1)
    Me.IGrid1Col0CellStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.TopRight
    '
    'IGrid1Col1CellStyle
    '
    Me.IGrid1Col1CellStyle.BackColor = System.Drawing.Color.WhiteSmoke
    Me.IGrid1Col1CellStyle.ContentIndent = New TenTec.Windows.iGridLib.iGIndent(5, 1, 1, 1)
    Me.IGrid1Col1CellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    '
    'Button1
    '
    Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button1.Location = New System.Drawing.Point(670, 332)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(99, 25)
    Me.Button1.TabIndex = 2
    Me.Button1.Text = "OK"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button2.Location = New System.Drawing.Point(495, 332)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(169, 25)
    Me.Button2.TabIndex = 3
    Me.Button2.Text = "markierte downloaden"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'IGrid1
    '
    Me.IGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.IGrid1.Appearance = TenTec.Windows.iGridLib.iGControlPaintAppearance.StyleFlat
    Me.IGrid1.AutoResizeCols = True
    Me.IGrid1.BorderStyle = TenTec.Windows.iGridLib.iGBorderStyle.Flat
    IGColPattern1.CellStyle = Me.IGrid1Col0CellStyle
    IGColPattern1.ColHdrStyle = Me.IGrid1Col0ColHdrStyle
    IGColPattern1.Text = "Hauptordner"
    IGColPattern1.Width = 179
    IGColPattern2.CellStyle = Me.IGrid1Col1CellStyle
    IGColPattern2.ColHdrStyle = Me.IGrid1Col1ColHdrStyle
    IGColPattern2.Text = "Datei"
    IGColPattern2.Width = 287
    IGColPattern3.CellStyle = Me.IGrid1Col2CellStyle
    IGColPattern3.ColHdrStyle = Me.IGrid1Col2ColHdrStyle
    IGColPattern3.Text = "Letzter Upload"
    IGColPattern3.Width = 191
    IGColPattern4.CellStyle = Me.IGrid1Col3CellStyle
    IGColPattern4.ColHdrStyle = Me.IGrid1Col3ColHdrStyle
    IGColPattern4.Text = "Dateigröße"
    IGColPattern4.Width = 132
    Me.IGrid1.Cols.AddRange(New TenTec.Windows.iGridLib.iGColPattern() {IGColPattern1, IGColPattern2, IGColPattern3, IGColPattern4})
    Me.IGrid1.DefaultCol.CellStyle = Me.IGrid1DefaultCellStyle
    Me.IGrid1.DefaultCol.ColHdrStyle = Me.IGrid1DefaultColHdrStyle
    Me.IGrid1.DefaultRow.Height = 19
    Me.IGrid1.DefaultRow.NormalCellHeight = 19
    Me.IGrid1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.IGrid1.GridLines.Mode = TenTec.Windows.iGridLib.iGGridLinesMode.None
    Me.IGrid1.Header.Height = 24
    Me.IGrid1.Location = New System.Drawing.Point(0, 0)
    Me.IGrid1.Name = "IGrid1"
    Me.IGrid1.ReadOnly = True
    Me.IGrid1.RowMode = True
    Me.IGrid1.RowTextCol.CellStyle = Me.IGrid1RowTextColCellStyle
    Me.IGrid1.SelectionMode = TenTec.Windows.iGridLib.iGSelectionMode.MultiExtended
    Me.IGrid1.Size = New System.Drawing.Size(791, 327)
    Me.IGrid1.TabIndex = 4
    '
    'frm_news
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(791, 360)
    Me.Controls.Add(Me.IGrid1)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frm_news"
    Me.Text = "Neuste Uploads - FolderSync"
    CType(Me.IGrid1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents IGrid1 As TenTec.Windows.iGridLib.iGrid
  Friend WithEvents IGrid1DefaultCellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents IGrid1DefaultColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents IGrid1RowTextColCellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents IGrid1Col0ColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents IGrid1Col1CellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents IGrid1Col1ColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents IGrid1Col2CellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents IGrid1Col2ColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents IGrid1Col3CellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents IGrid1Col3ColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents IGrid1Col0CellStyle As TenTec.Windows.iGridLib.iGCellStyle
End Class
