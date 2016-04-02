using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
namespace FolderSync
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class frm_options : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_options));
			this.Label1 = new System.Windows.Forms.Label();
			this.txt_sourceFolder = new System.Windows.Forms.TextBox();
			this.txt_destFolder = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txt_serverHomedir = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.shortcut4 = new System.Windows.Forms.TextBox();
			this.shortcut_text4 = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.shortcut3 = new System.Windows.Forms.TextBox();
			this.shortcut_text3 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.shortcut2 = new System.Windows.Forms.TextBox();
			this.shortcut_text2 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.shortcut1 = new System.Windows.Forms.TextBox();
			this.shortcut_text1 = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Button3 = new System.Windows.Forms.Button();
			this.finish_soundfile = new System.Windows.Forms.TextBox();
			this.chk_finish_windowtotop = new System.Windows.Forms.CheckBox();
			this.chk_finish_playsound = new System.Windows.Forms.CheckBox();
			this.chk_finish_messagebox = new System.Windows.Forms.CheckBox();
			this.btnApply = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.backupFolder = new System.Windows.Forms.TextBox();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.checkShowServerFolderList = new System.Windows.Forms.CheckBox();
			this.checkLocalVertical = new System.Windows.Forms.CheckBox();
			this.PictureBox3 = new System.Windows.Forms.PictureBox();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
			this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.ftp_dir = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.ftp_pass = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.ftp_user = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.ftp_host = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
			this.GroupBox5.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(8, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Quellordner:";
			//
			//txt_sourceFolder
			//
			this.txt_sourceFolder.Location = new System.Drawing.Point(6, 34);
			this.txt_sourceFolder.Name = "txt_sourceFolder";
			this.txt_sourceFolder.Size = new System.Drawing.Size(414, 20);
			this.txt_sourceFolder.TabIndex = 2;
			//
			//txt_destFolder
			//
			this.txt_destFolder.Location = new System.Drawing.Point(6, 91);
			this.txt_destFolder.Name = "txt_destFolder";
			this.txt_destFolder.Size = new System.Drawing.Size(414, 20);
			this.txt_destFolder.TabIndex = 4;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(8, 73);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(138, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Zielordner (auf dem Server):";
			//
			//txt_serverHomedir
			//
			this.txt_serverHomedir.Location = new System.Drawing.Point(6, 150);
			this.txt_serverHomedir.Name = "txt_serverHomedir";
			this.txt_serverHomedir.Size = new System.Drawing.Size(414, 20);
			this.txt_serverHomedir.TabIndex = 6;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(8, 132);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(85, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Server-HomeDir:";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(335, 26);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(37, 30);
			this.Button1.TabIndex = 7;
			this.Button1.Tag = "txt_sourceFolder";
			this.Button1.Text = "...";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label11);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.shortcut4);
			this.GroupBox1.Controls.Add(this.shortcut_text4);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.shortcut3);
			this.GroupBox1.Controls.Add(this.shortcut_text3);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.shortcut2);
			this.GroupBox1.Controls.Add(this.shortcut_text2);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.shortcut1);
			this.GroupBox1.Controls.Add(this.shortcut_text1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Location = new System.Drawing.Point(12, 129);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(564, 160);
			this.GroupBox1.TabIndex = 8;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Funktionstasten (Treeview auf Ordner navigieren)";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(221, 28);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(28, 13);
			this.Label11.TabIndex = 14;
			this.Label11.Text = "pfad";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(85, 27);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(29, 13);
			this.Label10.TabIndex = 13;
			this.Label10.Text = "label";
			//
			//shortcut4
			//
			this.shortcut4.Location = new System.Drawing.Point(212, 122);
			this.shortcut4.Name = "shortcut4";
			this.shortcut4.Size = new System.Drawing.Size(336, 20);
			this.shortcut4.TabIndex = 11;
			//
			//shortcut_text4
			//
			this.shortcut_text4.Location = new System.Drawing.Point(74, 122);
			this.shortcut_text4.Name = "shortcut_text4";
			this.shortcut_text4.Size = new System.Drawing.Size(132, 20);
			this.shortcut_text4.TabIndex = 10;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(19, 125);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(28, 13);
			this.Label7.TabIndex = 9;
			this.Label7.Text = "F 12";
			//
			//shortcut3
			//
			this.shortcut3.Location = new System.Drawing.Point(212, 96);
			this.shortcut3.Name = "shortcut3";
			this.shortcut3.Size = new System.Drawing.Size(336, 20);
			this.shortcut3.TabIndex = 8;
			//
			//shortcut_text3
			//
			this.shortcut_text3.Location = new System.Drawing.Point(74, 96);
			this.shortcut_text3.Name = "shortcut_text3";
			this.shortcut_text3.Size = new System.Drawing.Size(132, 20);
			this.shortcut_text3.TabIndex = 7;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(19, 99);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(28, 13);
			this.Label6.TabIndex = 6;
			this.Label6.Text = "F 11";
			//
			//shortcut2
			//
			this.shortcut2.Location = new System.Drawing.Point(212, 70);
			this.shortcut2.Name = "shortcut2";
			this.shortcut2.Size = new System.Drawing.Size(336, 20);
			this.shortcut2.TabIndex = 5;
			//
			//shortcut_text2
			//
			this.shortcut_text2.Location = new System.Drawing.Point(74, 70);
			this.shortcut_text2.Name = "shortcut_text2";
			this.shortcut_text2.Size = new System.Drawing.Size(132, 20);
			this.shortcut_text2.TabIndex = 4;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(19, 73);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(28, 13);
			this.Label5.TabIndex = 3;
			this.Label5.Text = "F 10";
			//
			//shortcut1
			//
			this.shortcut1.Location = new System.Drawing.Point(212, 44);
			this.shortcut1.Name = "shortcut1";
			this.shortcut1.Size = new System.Drawing.Size(336, 20);
			this.shortcut1.TabIndex = 2;
			//
			//shortcut_text1
			//
			this.shortcut_text1.Location = new System.Drawing.Point(74, 44);
			this.shortcut_text1.Name = "shortcut_text1";
			this.shortcut_text1.Size = new System.Drawing.Size(132, 20);
			this.shortcut_text1.TabIndex = 1;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(19, 47);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(22, 13);
			this.Label4.TabIndex = 0;
			this.Label4.Text = "F 9";
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.Button3);
			this.GroupBox2.Controls.Add(this.finish_soundfile);
			this.GroupBox2.Controls.Add(this.chk_finish_windowtotop);
			this.GroupBox2.Controls.Add(this.chk_finish_playsound);
			this.GroupBox2.Controls.Add(this.chk_finish_messagebox);
			this.GroupBox2.Location = new System.Drawing.Point(588, 193);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(268, 129);
			this.GroupBox2.TabIndex = 9;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Wenn ein Up-/Download fertig ist ...";
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(212, 82);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(32, 23);
			this.Button3.TabIndex = 5;
			this.Button3.Text = ">>";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//finish_soundfile
			//
			this.finish_soundfile.Location = new System.Drawing.Point(22, 84);
			this.finish_soundfile.Name = "finish_soundfile";
			this.finish_soundfile.Size = new System.Drawing.Size(184, 20);
			this.finish_soundfile.TabIndex = 4;
			//
			//chk_finish_windowtotop
			//
			this.chk_finish_windowtotop.AutoSize = true;
			this.chk_finish_windowtotop.Location = new System.Drawing.Point(22, 48);
			this.chk_finish_windowtotop.Name = "chk_finish_windowtotop";
			this.chk_finish_windowtotop.Size = new System.Drawing.Size(192, 17);
			this.chk_finish_windowtotop.TabIndex = 2;
			this.chk_finish_windowtotop.Text = "Fenster in den Vordergrund bringen";
			this.chk_finish_windowtotop.UseVisualStyleBackColor = true;
			//
			//chk_finish_playsound
			//
			this.chk_finish_playsound.AutoSize = true;
			this.chk_finish_playsound.Location = new System.Drawing.Point(22, 67);
			this.chk_finish_playsound.Name = "chk_finish_playsound";
			this.chk_finish_playsound.Size = new System.Drawing.Size(105, 17);
			this.chk_finish_playsound.TabIndex = 1;
			this.chk_finish_playsound.Text = "Sound abspielen";
			this.chk_finish_playsound.UseVisualStyleBackColor = true;
			//
			//chk_finish_messagebox
			//
			this.chk_finish_messagebox.AutoSize = true;
			this.chk_finish_messagebox.Location = new System.Drawing.Point(22, 29);
			this.chk_finish_messagebox.Name = "chk_finish_messagebox";
			this.chk_finish_messagebox.Size = new System.Drawing.Size(133, 17);
			this.chk_finish_messagebox.TabIndex = 0;
			this.chk_finish_messagebox.Text = "MessageBox anzeigen";
			this.chk_finish_messagebox.UseVisualStyleBackColor = true;
			//
			//btnApply
			//
			this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnApply.Location = new System.Drawing.Point(3, 3);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(86, 24);
			this.btnApply.TabIndex = 10;
			this.btnApply.Text = "Übernehmen";
			this.btnApply.UseVisualStyleBackColor = true;
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.txt_serverHomedir);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.txt_destFolder);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.txt_sourceFolder);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location = new System.Drawing.Point(884, 17);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(452, 200);
			this.Panel1.TabIndex = 11;
			this.Panel1.Visible = false;
			//
			//btnCancel
			//
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(95, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(86, 24);
			this.btnCancel.TabIndex = 16;
			this.btnCancel.Text = "Abbrechen";
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//btnOK
			//
			this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnOK.Location = new System.Drawing.Point(187, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(87, 24);
			this.btnOK.TabIndex = 17;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			//
			//TableLayoutPanel1
			//
			this.TableLayoutPanel1.ColumnCount = 3;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.TableLayoutPanel1.Controls.Add(this.btnApply, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnOK, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(582, 340);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(277, 30);
			this.TableLayoutPanel1.TabIndex = 18;
			//
			//GroupBox3
			//
			this.GroupBox3.Controls.Add(this.Button2);
			this.GroupBox3.Controls.Add(this.backupFolder);
			this.GroupBox3.Location = new System.Drawing.Point(12, 303);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(564, 69);
			this.GroupBox3.TabIndex = 19;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Backup-Ordner";
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(525, 26);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(32, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = ">>";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//backupFolder
			//
			this.backupFolder.Location = new System.Drawing.Point(20, 28);
			this.backupFolder.Name = "backupFolder";
			this.backupFolder.Size = new System.Drawing.Size(498, 20);
			this.backupFolder.TabIndex = 0;
			//
			//GroupBox4
			//
			this.GroupBox4.Controls.Add(this.checkShowServerFolderList);
			this.GroupBox4.Controls.Add(this.checkLocalVertical);
			this.GroupBox4.Location = new System.Drawing.Point(588, 100);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(268, 84);
			this.GroupBox4.TabIndex = 20;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Aussehen";
			//
			//checkShowServerFolderList
			//
			this.checkShowServerFolderList.AutoSize = true;
			this.checkShowServerFolderList.Checked = true;
			this.checkShowServerFolderList.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkShowServerFolderList.Location = new System.Drawing.Point(20, 50);
			this.checkShowServerFolderList.Name = "checkShowServerFolderList";
			this.checkShowServerFolderList.Size = new System.Drawing.Size(215, 17);
			this.checkShowServerFolderList.TabIndex = 1;
			this.checkShowServerFolderList.Text = "Server: Liste aller Hauptordner anzeigen";
			this.checkShowServerFolderList.UseVisualStyleBackColor = true;
			//
			//checkLocalVertical
			//
			this.checkLocalVertical.AutoSize = true;
			this.checkLocalVertical.Location = new System.Drawing.Point(20, 25);
			this.checkLocalVertical.Name = "checkLocalVertical";
			this.checkLocalVertical.Size = new System.Drawing.Size(239, 17);
			this.checkLocalVertical.TabIndex = 0;
			this.checkLocalVertical.Text = "Lokal: Baumansicht und Liste nebeneinander";
			this.checkLocalVertical.UseVisualStyleBackColor = true;
			//
			//PictureBox3
			//
			this.PictureBox3.Image = (System.Drawing.Image)resources.GetObject("PictureBox3.Image");
			this.PictureBox3.Location = new System.Drawing.Point(617, 12);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new System.Drawing.Size(100, 72);
			this.PictureBox3.TabIndex = 40;
			this.PictureBox3.TabStop = false;
			//
			//OpenFileDialog1
			//
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			//
			//GroupBox5
			//
			this.GroupBox5.Controls.Add(this.LinkLabel2);
			this.GroupBox5.Controls.Add(this.LinkLabel1);
			this.GroupBox5.Controls.Add(this.ftp_dir);
			this.GroupBox5.Controls.Add(this.Label15);
			this.GroupBox5.Controls.Add(this.ftp_pass);
			this.GroupBox5.Controls.Add(this.Label14);
			this.GroupBox5.Controls.Add(this.ftp_user);
			this.GroupBox5.Controls.Add(this.Label13);
			this.GroupBox5.Controls.Add(this.ftp_host);
			this.GroupBox5.Controls.Add(this.Label12);
			this.GroupBox5.Location = new System.Drawing.Point(12, 12);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new System.Drawing.Size(564, 103);
			this.GroupBox5.TabIndex = 21;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Server";
			//
			//LinkLabel2
			//
			this.LinkLabel2.AutoSize = true;
			this.LinkLabel2.Location = new System.Drawing.Point(68, 78);
			this.LinkLabel2.Name = "LinkLabel2";
			this.LinkLabel2.Size = new System.Drawing.Size(49, 13);
			this.LinkLabel2.TabIndex = 13;
			this.LinkLabel2.TabStop = true;
			this.LinkLabel2.Text = "Einfügen";
			//
			//LinkLabel1
			//
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Location = new System.Drawing.Point(13, 78);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new System.Drawing.Size(49, 13);
			this.LinkLabel1.TabIndex = 12;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "Kopieren";
			//
			//ftp_dir
			//
			this.ftp_dir.Location = new System.Drawing.Point(378, 21);
			this.ftp_dir.Name = "ftp_dir";
			this.ftp_dir.Size = new System.Drawing.Size(166, 20);
			this.ftp_dir.TabIndex = 9;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Location = new System.Drawing.Point(296, 24);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(65, 13);
			this.Label15.TabIndex = 8;
			this.Label15.Text = "FTP-Ordner:";
			//
			//ftp_pass
			//
			this.ftp_pass.Location = new System.Drawing.Point(378, 47);
			this.ftp_pass.Name = "ftp_pass";
			this.ftp_pass.Size = new System.Drawing.Size(166, 20);
			this.ftp_pass.TabIndex = 7;
			this.ftp_pass.UseSystemPasswordChar = true;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(296, 50);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(76, 13);
			this.Label14.TabIndex = 6;
			this.Label14.Text = "FTP-Passwort:";
			//
			//ftp_user
			//
			this.ftp_user.Location = new System.Drawing.Point(118, 47);
			this.ftp_user.Name = "ftp_user";
			this.ftp_user.Size = new System.Drawing.Size(166, 20);
			this.ftp_user.TabIndex = 5;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(13, 50);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(81, 13);
			this.Label13.TabIndex = 4;
			this.Label13.Text = "FTP-Username:";
			//
			//ftp_host
			//
			this.ftp_host.Location = new System.Drawing.Point(118, 21);
			this.ftp_host.Name = "ftp_host";
			this.ftp_host.Size = new System.Drawing.Size(166, 20);
			this.ftp_host.TabIndex = 3;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(13, 24);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(55, 13);
			this.Label12.TabIndex = 2;
			this.Label12.Text = "FTP-Host:";
			//
			//frm_options
			//
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(868, 384);
			this.Controls.Add(this.GroupBox5);
			this.Controls.Add(this.PictureBox3);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_options";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Einstellungen";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txt_sourceFolder;
		internal System.Windows.Forms.TextBox txt_destFolder;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txt_serverHomedir;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.FolderBrowserDialog fbd1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox shortcut1;
		internal System.Windows.Forms.TextBox shortcut_text1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox shortcut4;
		internal System.Windows.Forms.TextBox shortcut_text4;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox shortcut3;
		internal System.Windows.Forms.TextBox shortcut_text3;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox shortcut2;
		internal System.Windows.Forms.TextBox shortcut_text2;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.CheckBox chk_finish_windowtotop;
		internal System.Windows.Forms.CheckBox chk_finish_playsound;
		internal System.Windows.Forms.CheckBox chk_finish_messagebox;
		internal System.Windows.Forms.TextBox finish_soundfile;
		private System.Windows.Forms.Button withEventsField_btnApply;
		internal System.Windows.Forms.Button btnApply {
			get { return withEventsField_btnApply; }
			set {
				if (withEventsField_btnApply != null) {
					withEventsField_btnApply.Click -= Button2_Click;
				}
				withEventsField_btnApply = value;
				if (withEventsField_btnApply != null) {
					withEventsField_btnApply.Click += Button2_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Button withEventsField_btnCancel;
		internal System.Windows.Forms.Button btnCancel {
			get { return withEventsField_btnCancel; }
			set {
				if (withEventsField_btnCancel != null) {
					withEventsField_btnCancel.Click -= btnCancel_Click;
				}
				withEventsField_btnCancel = value;
				if (withEventsField_btnCancel != null) {
					withEventsField_btnCancel.Click += btnCancel_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOK;
		internal System.Windows.Forms.Button btnOK {
			get { return withEventsField_btnOK; }
			set {
				if (withEventsField_btnOK != null) {
					withEventsField_btnOK.Click -= btnOK_Click;
				}
				withEventsField_btnOK = value;
				if (withEventsField_btnOK != null) {
					withEventsField_btnOK.Click += btnOK_Click;
				}
			}
		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.TextBox backupFolder;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.CheckBox checkShowServerFolderList;
		internal System.Windows.Forms.CheckBox checkLocalVertical;
		internal System.Windows.Forms.PictureBox PictureBox3;
		private System.Windows.Forms.Button withEventsField_Button2;
		internal System.Windows.Forms.Button Button2 {
			get { return withEventsField_Button2; }
			set {
				if (withEventsField_Button2 != null) {
					withEventsField_Button2.Click -= Button2_Click_1;
				}
				withEventsField_Button2 = value;
				if (withEventsField_Button2 != null) {
					withEventsField_Button2.Click += Button2_Click_1;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_Button3;
		internal System.Windows.Forms.Button Button3 {
			get { return withEventsField_Button3; }
			set {
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click -= Button3_Click;
				}
				withEventsField_Button3 = value;
				if (withEventsField_Button3 != null) {
					withEventsField_Button3.Click += Button3_Click;
				}
			}
		}
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.TextBox ftp_pass;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox ftp_user;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox ftp_host;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox ftp_dir;
		internal System.Windows.Forms.Label Label15;
		private System.Windows.Forms.LinkLabel withEventsField_LinkLabel2;
		internal System.Windows.Forms.LinkLabel LinkLabel2 {
			get { return withEventsField_LinkLabel2; }
			set {
				if (withEventsField_LinkLabel2 != null) {
					withEventsField_LinkLabel2.LinkClicked -= LinkLabel2_LinkClicked;
				}
				withEventsField_LinkLabel2 = value;
				if (withEventsField_LinkLabel2 != null) {
					withEventsField_LinkLabel2.LinkClicked += LinkLabel2_LinkClicked;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_LinkLabel1;
		internal System.Windows.Forms.LinkLabel LinkLabel1 {
			get { return withEventsField_LinkLabel1; }
			set {
				if (withEventsField_LinkLabel1 != null) {
					withEventsField_LinkLabel1.LinkClicked -= LinkLabel1_LinkClicked;
				}
				withEventsField_LinkLabel1 = value;
				if (withEventsField_LinkLabel1 != null) {
					withEventsField_LinkLabel1.LinkClicked += LinkLabel1_LinkClicked;
				}
			}

		}
	}
}
