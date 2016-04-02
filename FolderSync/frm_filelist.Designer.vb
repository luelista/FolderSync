<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fileList
  Inherits System.Windows.Forms.Form

  'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

  'Wird vom Windows Form-Designer benötigt.
  Private components As System.ComponentModel.IContainer

  'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
  'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
  'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("funktion noch nicht implementiert ...")
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fileList))
    Me.ListView1 = New System.Windows.Forms.ListView()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.TextBox2 = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Button1 = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'ListView1
    '
    Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
    Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
    Me.ListView1.Location = New System.Drawing.Point(12, 74)
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(492, 400)
    Me.ListView1.TabIndex = 0
    Me.ListView1.UseCompatibleStateImageBehavior = False
    Me.ListView1.View = System.Windows.Forms.View.Details
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(95, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Hochgeladen von:"
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(131, 10)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(373, 20)
    Me.TextBox1.TabIndex = 2
    '
    'TextBox2
    '
    Me.TextBox2.Location = New System.Drawing.Point(131, 36)
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(373, 20)
    Me.TextBox2.TabIndex = 4
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(13, 39)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(63, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Kommentar:"
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Datei"
    Me.ColumnHeader1.Width = 340
    '
    'Button1
    '
    Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Button1.Location = New System.Drawing.Point(395, 480)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(109, 23)
    Me.Button1.TabIndex = 5
    Me.Button1.Text = "OK"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'frm_fileList
    '
    Me.AcceptButton = Me.Button1
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Button1
    Me.ClientSize = New System.Drawing.Size(516, 515)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.TextBox2)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ListView1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frm_fileList"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Dateiliste - FolderSync"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ListView1 As System.Windows.Forms.ListView
  Friend WithEvents Label1 As Label
  Friend WithEvents TextBox1 As TextBox
  Friend WithEvents TextBox2 As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents ColumnHeader1 As ColumnHeader
  Friend WithEvents Button1 As Button
End Class
