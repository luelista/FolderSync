<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trash
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
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPage4 = New System.Windows.Forms.TabPage
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.Button3 = New System.Windows.Forms.Button
    Me.Button2 = New System.Windows.Forms.Button
    Me.Button1 = New System.Windows.Forms.Button
    Me.ListView2 = New System.Windows.Forms.ListView
    Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
    Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
    Me.ListView1 = New System.Windows.Forms.ListView
    Me.chClientName = New System.Windows.Forms.ColumnHeader
    Me.chServerName = New System.Windows.Forms.ColumnHeader
    Me.chDirection = New System.Windows.Forms.ColumnHeader
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.TabPage3 = New System.Windows.Forms.TabPage
    Me.txtZip_Folder = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Button7 = New System.Windows.Forms.Button
    Me.txtZipFile = New System.Windows.Forms.TextBox
    Me.Button6 = New System.Windows.Forms.Button
    Me.ListBox1 = New System.Windows.Forms.ListBox
    Me.Button5 = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TabControl1.Controls.Add(Me.TabPage4)
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabControl1.Location = New System.Drawing.Point(12, 12)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(676, 566)
    Me.TabControl1.TabIndex = 12
    '
    'TabPage4
    '
    Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabPage4.Location = New System.Drawing.Point(4, 25)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage4.Size = New System.Drawing.Size(668, 537)
    Me.TabPage4.TabIndex = 3
    Me.TabPage4.Text = "ZIP & load"
    Me.TabPage4.UseVisualStyleBackColor = True
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.Button3)
    Me.TabPage1.Controls.Add(Me.Button2)
    Me.TabPage1.Controls.Add(Me.Button1)
    Me.TabPage1.Controls.Add(Me.ListView2)
    Me.TabPage1.Controls.Add(Me.ListView1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 25)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(668, 537)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "alte Version"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'Button3
    '
    Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button3.Location = New System.Drawing.Point(466, 501)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(169, 30)
    Me.Button3.TabIndex = 15
    Me.Button3.Text = "get server file list"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button2.Location = New System.Drawing.Point(291, 501)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(169, 30)
    Me.Button2.TabIndex = 14
    Me.Button2.Text = "start sync"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button1.Location = New System.Drawing.Point(116, 501)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(169, 30)
    Me.Button1.TabIndex = 13
    Me.Button1.Text = "create List"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'ListView2
    '
    Me.ListView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
    Me.ListView2.FullRowSelect = True
    Me.ListView2.HideSelection = False
    Me.ListView2.Location = New System.Drawing.Point(6, 288)
    Me.ListView2.Name = "ListView2"
    Me.ListView2.Size = New System.Drawing.Size(627, 207)
    Me.ListView2.TabIndex = 12
    Me.ListView2.UseCompatibleStateImageBehavior = False
    Me.ListView2.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Width = 433
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Width = 138
    '
    'ListView1
    '
    Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chClientName, Me.chServerName, Me.chDirection})
    Me.ListView1.FullRowSelect = True
    Me.ListView1.HideSelection = False
    Me.ListView1.Location = New System.Drawing.Point(6, 1)
    Me.ListView1.Name = "ListView1"
    Me.ListView1.Size = New System.Drawing.Size(627, 282)
    Me.ListView1.TabIndex = 11
    Me.ListView1.UseCompatibleStateImageBehavior = False
    Me.ListView1.View = System.Windows.Forms.View.Details
    '
    'chClientName
    '
    Me.chClientName.Text = "Name auf Client"
    Me.chClientName.Width = 247
    '
    'chServerName
    '
    Me.chServerName.Text = "Name auf Server"
    Me.chServerName.Width = 224
    '
    'chDirection
    '
    Me.chDirection.Text = "Aktion"
    '
    'TabPage2
    '
    Me.TabPage2.Location = New System.Drawing.Point(4, 25)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(668, 537)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "webBrowser"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.txtZip_Folder)
    Me.TabPage3.Controls.Add(Me.Label2)
    Me.TabPage3.Controls.Add(Me.Button7)
    Me.TabPage3.Controls.Add(Me.txtZipFile)
    Me.TabPage3.Controls.Add(Me.Button6)
    Me.TabPage3.Controls.Add(Me.ListBox1)
    Me.TabPage3.Controls.Add(Me.Button5)
    Me.TabPage3.Controls.Add(Me.Label1)
    Me.TabPage3.Location = New System.Drawing.Point(4, 25)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(668, 537)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "SharpZipLib (test)"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'txtZip_Folder
    '
    Me.txtZip_Folder.Location = New System.Drawing.Point(182, 48)
    Me.txtZip_Folder.Name = "txtZip_Folder"
    Me.txtZip_Folder.Size = New System.Drawing.Size(284, 22)
    Me.txtZip_Folder.TabIndex = 7
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(57, 51)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(126, 16)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "source/targetFolder"
    '
    'Button7
    '
    Me.Button7.Location = New System.Drawing.Point(364, 92)
    Me.Button7.Name = "Button7"
    Me.Button7.Size = New System.Drawing.Size(116, 31)
    Me.Button7.TabIndex = 5
    Me.Button7.Text = "zip it"
    Me.Button7.UseVisualStyleBackColor = True
    '
    'txtZipFile
    '
    Me.txtZipFile.Location = New System.Drawing.Point(182, 22)
    Me.txtZipFile.Name = "txtZipFile"
    Me.txtZipFile.Size = New System.Drawing.Size(284, 22)
    Me.txtZipFile.TabIndex = 4
    '
    'Button6
    '
    Me.Button6.Location = New System.Drawing.Point(182, 92)
    Me.Button6.Name = "Button6"
    Me.Button6.Size = New System.Drawing.Size(116, 31)
    Me.Button6.TabIndex = 3
    Me.Button6.Text = "extract all"
    Me.Button6.UseVisualStyleBackColor = True
    '
    'ListBox1
    '
    Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ListBox1.FormattingEnabled = True
    Me.ListBox1.ItemHeight = 16
    Me.ListBox1.Location = New System.Drawing.Point(60, 143)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(523, 244)
    Me.ListBox1.TabIndex = 2
    '
    'Button5
    '
    Me.Button5.Location = New System.Drawing.Point(60, 92)
    Me.Button5.Name = "Button5"
    Me.Button5.Size = New System.Drawing.Size(116, 31)
    Me.Button5.TabIndex = 1
    Me.Button5.Text = "list"
    Me.Button5.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(57, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(47, 16)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "zipFile"
    '
    'frm_trash
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(700, 590)
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "frm_trash"
    Me.Text = "frm_trash"
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage3.ResumeLayout(False)
    Me.TabPage3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents ListView2 As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ListView1 As System.Windows.Forms.ListView
  Friend WithEvents chClientName As System.Windows.Forms.ColumnHeader
  Friend WithEvents chServerName As System.Windows.Forms.ColumnHeader
  Friend WithEvents chDirection As System.Windows.Forms.ColumnHeader
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents txtZip_Folder As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Button7 As System.Windows.Forms.Button
  Friend WithEvents txtZipFile As System.Windows.Forms.TextBox
  Friend WithEvents Button6 As System.Windows.Forms.Button
  Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
  Friend WithEvents Button5 As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
