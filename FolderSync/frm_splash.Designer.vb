﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splash
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splash))
    Me.Label1 = New System.Windows.Forms.Label
    Me.Button1 = New System.Windows.Forms.Button
    Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(32, 262)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(193, 18)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Programm wird initialisiert ..."
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(297, 259)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(107, 26)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "OK"
    Me.Button1.UseVisualStyleBackColor = True
    Me.Button1.Visible = False
    '
    'LinkLabel1
    '
    Me.LinkLabel1.AutoSize = True
    Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
    Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
    Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(9, 40)
    Me.LinkLabel1.Location = New System.Drawing.Point(32, 209)
    Me.LinkLabel1.Name = "LinkLabel1"
    Me.LinkLabel1.Size = New System.Drawing.Size(273, 19)
    Me.LinkLabel1.TabIndex = 2
    Me.LinkLabel1.TabStop = True
    Me.LinkLabel1.Text = "Website: http://vbnet.teamwiki.de/foldersync.html"
    Me.LinkLabel1.UseCompatibleTextRendering = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(32, 230)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(68, 15)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Version 4.0"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.Transparent
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(32, 175)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(91, 15)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "von Max Weller"
    '
    'frm_splash
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(440, 300)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.LinkLabel1)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frm_splash"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "FolderSync 2.0"
    Me.TopMost = True
    Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
End Class