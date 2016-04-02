<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_options
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_options))
    Me.Label1 = New System.Windows.Forms.Label
    Me.txt_sourceFolder = New System.Windows.Forms.TextBox
    Me.txt_destFolder = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.txt_serverHomedir = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Button1 = New System.Windows.Forms.Button
    Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.Label11 = New System.Windows.Forms.Label
    Me.Label10 = New System.Windows.Forms.Label
    Me.shortcut4 = New System.Windows.Forms.TextBox
    Me.shortcut_text4 = New System.Windows.Forms.TextBox
    Me.Label7 = New System.Windows.Forms.Label
    Me.shortcut3 = New System.Windows.Forms.TextBox
    Me.shortcut_text3 = New System.Windows.Forms.TextBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.shortcut2 = New System.Windows.Forms.TextBox
    Me.shortcut_text2 = New System.Windows.Forms.TextBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.shortcut1 = New System.Windows.Forms.TextBox
    Me.shortcut_text1 = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.Button3 = New System.Windows.Forms.Button
    Me.finish_soundfile = New System.Windows.Forms.TextBox
    Me.chk_finish_windowtotop = New System.Windows.Forms.CheckBox
    Me.chk_finish_playsound = New System.Windows.Forms.CheckBox
    Me.chk_finish_messagebox = New System.Windows.Forms.CheckBox
    Me.btnApply = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.btnCancel = New System.Windows.Forms.Button
    Me.btnOK = New System.Windows.Forms.Button
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.Button2 = New System.Windows.Forms.Button
    Me.backupFolder = New System.Windows.Forms.TextBox
    Me.GroupBox4 = New System.Windows.Forms.GroupBox
    Me.checkShowServerFolderList = New System.Windows.Forms.CheckBox
    Me.checkLocalVertical = New System.Windows.Forms.CheckBox
    Me.PictureBox3 = New System.Windows.Forms.PictureBox
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.GroupBox5 = New System.Windows.Forms.GroupBox
    Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
    Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
    Me.ftp_dir = New System.Windows.Forms.TextBox
    Me.Label15 = New System.Windows.Forms.Label
    Me.ftp_pass = New System.Windows.Forms.TextBox
    Me.Label14 = New System.Windows.Forms.Label
    Me.ftp_user = New System.Windows.Forms.TextBox
    Me.Label13 = New System.Windows.Forms.Label
    Me.ftp_host = New System.Windows.Forms.TextBox
    Me.Label12 = New System.Windows.Forms.Label
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox5.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(8, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(64, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Quellordner:"
    '
    'txt_sourceFolder
    '
    Me.txt_sourceFolder.Location = New System.Drawing.Point(6, 34)
    Me.txt_sourceFolder.Name = "txt_sourceFolder"
    Me.txt_sourceFolder.Size = New System.Drawing.Size(414, 20)
    Me.txt_sourceFolder.TabIndex = 2
    '
    'txt_destFolder
    '
    Me.txt_destFolder.Location = New System.Drawing.Point(6, 91)
    Me.txt_destFolder.Name = "txt_destFolder"
    Me.txt_destFolder.Size = New System.Drawing.Size(414, 20)
    Me.txt_destFolder.TabIndex = 4
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(8, 73)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(138, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Zielordner (auf dem Server):"
    '
    'txt_serverHomedir
    '
    Me.txt_serverHomedir.Location = New System.Drawing.Point(6, 150)
    Me.txt_serverHomedir.Name = "txt_serverHomedir"
    Me.txt_serverHomedir.Size = New System.Drawing.Size(414, 20)
    Me.txt_serverHomedir.TabIndex = 6
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(8, 132)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(85, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Server-HomeDir:"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(335, 26)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(37, 30)
    Me.Button1.TabIndex = 7
    Me.Button1.Tag = "txt_sourceFolder"
    Me.Button1.Text = "..."
    Me.Button1.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Label11)
    Me.GroupBox1.Controls.Add(Me.Label10)
    Me.GroupBox1.Controls.Add(Me.shortcut4)
    Me.GroupBox1.Controls.Add(Me.shortcut_text4)
    Me.GroupBox1.Controls.Add(Me.Label7)
    Me.GroupBox1.Controls.Add(Me.shortcut3)
    Me.GroupBox1.Controls.Add(Me.shortcut_text3)
    Me.GroupBox1.Controls.Add(Me.Label6)
    Me.GroupBox1.Controls.Add(Me.shortcut2)
    Me.GroupBox1.Controls.Add(Me.shortcut_text2)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.shortcut1)
    Me.GroupBox1.Controls.Add(Me.shortcut_text1)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 129)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(564, 160)
    Me.GroupBox1.TabIndex = 8
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Funktionstasten (Treeview auf Ordner navigieren)"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(221, 28)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(28, 13)
    Me.Label11.TabIndex = 14
    Me.Label11.Text = "pfad"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(85, 27)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(29, 13)
    Me.Label10.TabIndex = 13
    Me.Label10.Text = "label"
    '
    'shortcut4
    '
    Me.shortcut4.Location = New System.Drawing.Point(212, 122)
    Me.shortcut4.Name = "shortcut4"
    Me.shortcut4.Size = New System.Drawing.Size(336, 20)
    Me.shortcut4.TabIndex = 11
    '
    'shortcut_text4
    '
    Me.shortcut_text4.Location = New System.Drawing.Point(74, 122)
    Me.shortcut_text4.Name = "shortcut_text4"
    Me.shortcut_text4.Size = New System.Drawing.Size(132, 20)
    Me.shortcut_text4.TabIndex = 10
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(19, 125)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(28, 13)
    Me.Label7.TabIndex = 9
    Me.Label7.Text = "F 12"
    '
    'shortcut3
    '
    Me.shortcut3.Location = New System.Drawing.Point(212, 96)
    Me.shortcut3.Name = "shortcut3"
    Me.shortcut3.Size = New System.Drawing.Size(336, 20)
    Me.shortcut3.TabIndex = 8
    '
    'shortcut_text3
    '
    Me.shortcut_text3.Location = New System.Drawing.Point(74, 96)
    Me.shortcut_text3.Name = "shortcut_text3"
    Me.shortcut_text3.Size = New System.Drawing.Size(132, 20)
    Me.shortcut_text3.TabIndex = 7
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(19, 99)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(28, 13)
    Me.Label6.TabIndex = 6
    Me.Label6.Text = "F 11"
    '
    'shortcut2
    '
    Me.shortcut2.Location = New System.Drawing.Point(212, 70)
    Me.shortcut2.Name = "shortcut2"
    Me.shortcut2.Size = New System.Drawing.Size(336, 20)
    Me.shortcut2.TabIndex = 5
    '
    'shortcut_text2
    '
    Me.shortcut_text2.Location = New System.Drawing.Point(74, 70)
    Me.shortcut_text2.Name = "shortcut_text2"
    Me.shortcut_text2.Size = New System.Drawing.Size(132, 20)
    Me.shortcut_text2.TabIndex = 4
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(19, 73)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(28, 13)
    Me.Label5.TabIndex = 3
    Me.Label5.Text = "F 10"
    '
    'shortcut1
    '
    Me.shortcut1.Location = New System.Drawing.Point(212, 44)
    Me.shortcut1.Name = "shortcut1"
    Me.shortcut1.Size = New System.Drawing.Size(336, 20)
    Me.shortcut1.TabIndex = 2
    '
    'shortcut_text1
    '
    Me.shortcut_text1.Location = New System.Drawing.Point(74, 44)
    Me.shortcut_text1.Name = "shortcut_text1"
    Me.shortcut_text1.Size = New System.Drawing.Size(132, 20)
    Me.shortcut_text1.TabIndex = 1
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(19, 47)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(22, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "F 9"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.Button3)
    Me.GroupBox2.Controls.Add(Me.finish_soundfile)
    Me.GroupBox2.Controls.Add(Me.chk_finish_windowtotop)
    Me.GroupBox2.Controls.Add(Me.chk_finish_playsound)
    Me.GroupBox2.Controls.Add(Me.chk_finish_messagebox)
    Me.GroupBox2.Location = New System.Drawing.Point(588, 193)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(268, 129)
    Me.GroupBox2.TabIndex = 9
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Wenn ein Up-/Download fertig ist ..."
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(212, 82)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(32, 23)
    Me.Button3.TabIndex = 5
    Me.Button3.Text = ">>"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'finish_soundfile
    '
    Me.finish_soundfile.Location = New System.Drawing.Point(22, 84)
    Me.finish_soundfile.Name = "finish_soundfile"
    Me.finish_soundfile.Size = New System.Drawing.Size(184, 20)
    Me.finish_soundfile.TabIndex = 4
    '
    'chk_finish_windowtotop
    '
    Me.chk_finish_windowtotop.AutoSize = True
    Me.chk_finish_windowtotop.Location = New System.Drawing.Point(22, 48)
    Me.chk_finish_windowtotop.Name = "chk_finish_windowtotop"
    Me.chk_finish_windowtotop.Size = New System.Drawing.Size(192, 17)
    Me.chk_finish_windowtotop.TabIndex = 2
    Me.chk_finish_windowtotop.Text = "Fenster in den Vordergrund bringen"
    Me.chk_finish_windowtotop.UseVisualStyleBackColor = True
    '
    'chk_finish_playsound
    '
    Me.chk_finish_playsound.AutoSize = True
    Me.chk_finish_playsound.Location = New System.Drawing.Point(22, 67)
    Me.chk_finish_playsound.Name = "chk_finish_playsound"
    Me.chk_finish_playsound.Size = New System.Drawing.Size(105, 17)
    Me.chk_finish_playsound.TabIndex = 1
    Me.chk_finish_playsound.Text = "Sound abspielen"
    Me.chk_finish_playsound.UseVisualStyleBackColor = True
    '
    'chk_finish_messagebox
    '
    Me.chk_finish_messagebox.AutoSize = True
    Me.chk_finish_messagebox.Location = New System.Drawing.Point(22, 29)
    Me.chk_finish_messagebox.Name = "chk_finish_messagebox"
    Me.chk_finish_messagebox.Size = New System.Drawing.Size(133, 17)
    Me.chk_finish_messagebox.TabIndex = 0
    Me.chk_finish_messagebox.Text = "MessageBox anzeigen"
    Me.chk_finish_messagebox.UseVisualStyleBackColor = True
    '
    'btnApply
    '
    Me.btnApply.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnApply.Location = New System.Drawing.Point(3, 3)
    Me.btnApply.Name = "btnApply"
    Me.btnApply.Size = New System.Drawing.Size(86, 24)
    Me.btnApply.TabIndex = 10
    Me.btnApply.Text = "Übernehmen"
    Me.btnApply.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Button1)
    Me.Panel1.Controls.Add(Me.txt_serverHomedir)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.txt_destFolder)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.txt_sourceFolder)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Location = New System.Drawing.Point(884, 17)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(452, 200)
    Me.Panel1.TabIndex = 11
    Me.Panel1.Visible = False
    '
    'btnCancel
    '
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnCancel.Location = New System.Drawing.Point(95, 3)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(86, 24)
    Me.btnCancel.TabIndex = 16
    Me.btnCancel.Text = "Abbrechen"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'btnOK
    '
    Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnOK.Location = New System.Drawing.Point(187, 3)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(87, 24)
    Me.btnOK.TabIndex = 17
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.Controls.Add(Me.btnApply, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(582, 340)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(277, 30)
    Me.TableLayoutPanel1.TabIndex = 18
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.Button2)
    Me.GroupBox3.Controls.Add(Me.backupFolder)
    Me.GroupBox3.Location = New System.Drawing.Point(12, 303)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(564, 69)
    Me.GroupBox3.TabIndex = 19
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Backup-Ordner"
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(525, 26)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(32, 23)
    Me.Button2.TabIndex = 1
    Me.Button2.Text = ">>"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'backupFolder
    '
    Me.backupFolder.Location = New System.Drawing.Point(20, 28)
    Me.backupFolder.Name = "backupFolder"
    Me.backupFolder.Size = New System.Drawing.Size(498, 20)
    Me.backupFolder.TabIndex = 0
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.checkShowServerFolderList)
    Me.GroupBox4.Controls.Add(Me.checkLocalVertical)
    Me.GroupBox4.Location = New System.Drawing.Point(588, 100)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(268, 84)
    Me.GroupBox4.TabIndex = 20
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "Aussehen"
    '
    'checkShowServerFolderList
    '
    Me.checkShowServerFolderList.AutoSize = True
    Me.checkShowServerFolderList.Checked = True
    Me.checkShowServerFolderList.CheckState = System.Windows.Forms.CheckState.Checked
    Me.checkShowServerFolderList.Location = New System.Drawing.Point(20, 50)
    Me.checkShowServerFolderList.Name = "checkShowServerFolderList"
    Me.checkShowServerFolderList.Size = New System.Drawing.Size(215, 17)
    Me.checkShowServerFolderList.TabIndex = 1
    Me.checkShowServerFolderList.Text = "Server: Liste aller Hauptordner anzeigen"
    Me.checkShowServerFolderList.UseVisualStyleBackColor = True
    '
    'checkLocalVertical
    '
    Me.checkLocalVertical.AutoSize = True
    Me.checkLocalVertical.Location = New System.Drawing.Point(20, 25)
    Me.checkLocalVertical.Name = "checkLocalVertical"
    Me.checkLocalVertical.Size = New System.Drawing.Size(239, 17)
    Me.checkLocalVertical.TabIndex = 0
    Me.checkLocalVertical.Text = "Lokal: Baumansicht und Liste nebeneinander"
    Me.checkLocalVertical.UseVisualStyleBackColor = True
    '
    'PictureBox3
    '
    Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
    Me.PictureBox3.Location = New System.Drawing.Point(617, 12)
    Me.PictureBox3.Name = "PictureBox3"
    Me.PictureBox3.Size = New System.Drawing.Size(100, 72)
    Me.PictureBox3.TabIndex = 40
    Me.PictureBox3.TabStop = False
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'GroupBox5
    '
    Me.GroupBox5.Controls.Add(Me.LinkLabel2)
    Me.GroupBox5.Controls.Add(Me.LinkLabel1)
    Me.GroupBox5.Controls.Add(Me.ftp_dir)
    Me.GroupBox5.Controls.Add(Me.Label15)
    Me.GroupBox5.Controls.Add(Me.ftp_pass)
    Me.GroupBox5.Controls.Add(Me.Label14)
    Me.GroupBox5.Controls.Add(Me.ftp_user)
    Me.GroupBox5.Controls.Add(Me.Label13)
    Me.GroupBox5.Controls.Add(Me.ftp_host)
    Me.GroupBox5.Controls.Add(Me.Label12)
    Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox5.Name = "GroupBox5"
    Me.GroupBox5.Size = New System.Drawing.Size(564, 103)
    Me.GroupBox5.TabIndex = 21
    Me.GroupBox5.TabStop = False
    Me.GroupBox5.Text = "Server"
    '
    'LinkLabel2
    '
    Me.LinkLabel2.AutoSize = True
    Me.LinkLabel2.Location = New System.Drawing.Point(68, 78)
    Me.LinkLabel2.Name = "LinkLabel2"
    Me.LinkLabel2.Size = New System.Drawing.Size(49, 13)
    Me.LinkLabel2.TabIndex = 13
    Me.LinkLabel2.TabStop = True
    Me.LinkLabel2.Text = "Einfügen"
    '
    'LinkLabel1
    '
    Me.LinkLabel1.AutoSize = True
    Me.LinkLabel1.Location = New System.Drawing.Point(13, 78)
    Me.LinkLabel1.Name = "LinkLabel1"
    Me.LinkLabel1.Size = New System.Drawing.Size(49, 13)
    Me.LinkLabel1.TabIndex = 12
    Me.LinkLabel1.TabStop = True
    Me.LinkLabel1.Text = "Kopieren"
    '
    'ftp_dir
    '
    Me.ftp_dir.Location = New System.Drawing.Point(378, 21)
    Me.ftp_dir.Name = "ftp_dir"
    Me.ftp_dir.Size = New System.Drawing.Size(166, 20)
    Me.ftp_dir.TabIndex = 9
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(296, 24)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(65, 13)
    Me.Label15.TabIndex = 8
    Me.Label15.Text = "FTP-Ordner:"
    '
    'ftp_pass
    '
    Me.ftp_pass.Location = New System.Drawing.Point(378, 47)
    Me.ftp_pass.Name = "ftp_pass"
    Me.ftp_pass.Size = New System.Drawing.Size(166, 20)
    Me.ftp_pass.TabIndex = 7
    Me.ftp_pass.UseSystemPasswordChar = True
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(296, 50)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(76, 13)
    Me.Label14.TabIndex = 6
    Me.Label14.Text = "FTP-Passwort:"
    '
    'ftp_user
    '
    Me.ftp_user.Location = New System.Drawing.Point(118, 47)
    Me.ftp_user.Name = "ftp_user"
    Me.ftp_user.Size = New System.Drawing.Size(166, 20)
    Me.ftp_user.TabIndex = 5
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(13, 50)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(81, 13)
    Me.Label13.TabIndex = 4
    Me.Label13.Text = "FTP-Username:"
    '
    'ftp_host
    '
    Me.ftp_host.Location = New System.Drawing.Point(118, 21)
    Me.ftp_host.Name = "ftp_host"
    Me.ftp_host.Size = New System.Drawing.Size(166, 20)
    Me.ftp_host.TabIndex = 3
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(13, 24)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(55, 13)
    Me.Label12.TabIndex = 2
    Me.Label12.Text = "FTP-Host:"
    '
    'frm_options
    '
    Me.AcceptButton = Me.btnOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancel
    Me.ClientSize = New System.Drawing.Size(868, 384)
    Me.Controls.Add(Me.GroupBox5)
    Me.Controls.Add(Me.PictureBox3)
    Me.Controls.Add(Me.GroupBox4)
    Me.Controls.Add(Me.GroupBox3)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frm_options"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Einstellungen"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox4.PerformLayout()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox5.ResumeLayout(False)
    Me.GroupBox5.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txt_sourceFolder As System.Windows.Forms.TextBox
  Friend WithEvents txt_destFolder As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txt_serverHomedir As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents fbd1 As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents shortcut1 As System.Windows.Forms.TextBox
  Friend WithEvents shortcut_text1 As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents shortcut4 As System.Windows.Forms.TextBox
  Friend WithEvents shortcut_text4 As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents shortcut3 As System.Windows.Forms.TextBox
  Friend WithEvents shortcut_text3 As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents shortcut2 As System.Windows.Forms.TextBox
  Friend WithEvents shortcut_text2 As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents chk_finish_windowtotop As System.Windows.Forms.CheckBox
  Friend WithEvents chk_finish_playsound As System.Windows.Forms.CheckBox
  Friend WithEvents chk_finish_messagebox As System.Windows.Forms.CheckBox
  Friend WithEvents finish_soundfile As System.Windows.Forms.TextBox
  Friend WithEvents btnApply As System.Windows.Forms.Button
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents backupFolder As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents checkShowServerFolderList As System.Windows.Forms.CheckBox
  Friend WithEvents checkLocalVertical As System.Windows.Forms.CheckBox
  Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
  Friend WithEvents ftp_pass As System.Windows.Forms.TextBox
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents ftp_user As System.Windows.Forms.TextBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents ftp_host As System.Windows.Forms.TextBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents ftp_dir As System.Windows.Forms.TextBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
  Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
