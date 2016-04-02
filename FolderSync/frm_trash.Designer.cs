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
	partial class frm_trash : System.Windows.Forms.Form
	{

		//Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

		//Wird vom Windows Form-Designer benötigt.

		private System.ComponentModel.IContainer components;
		//Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
		//Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
		//Das Bearbeiten mit dem Code-Editor ist nicht möglich.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage4 = new System.Windows.Forms.TabPage();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.ListView2 = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.ListView1 = new System.Windows.Forms.ListView();
			this.chClientName = new System.Windows.Forms.ColumnHeader();
			this.chServerName = new System.Windows.Forms.ColumnHeader();
			this.chDirection = new System.Windows.Forms.ColumnHeader();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.txtZip_Folder = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Button7 = new System.Windows.Forms.Button();
			this.txtZipFile = new System.Windows.Forms.TextBox();
			this.Button6 = new System.Windows.Forms.Button();
			this.ListBox1 = new System.Windows.Forms.ListBox();
			this.Button5 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TabControl1.Location = new System.Drawing.Point(12, 12);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(676, 566);
			this.TabControl1.TabIndex = 12;
			//
			//TabPage4
			//
			this.TabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TabPage4.Location = new System.Drawing.Point(4, 25);
			this.TabPage4.Name = "TabPage4";
			this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage4.Size = new System.Drawing.Size(668, 537);
			this.TabPage4.TabIndex = 3;
			this.TabPage4.Text = "ZIP & load";
			this.TabPage4.UseVisualStyleBackColor = true;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.Button3);
			this.TabPage1.Controls.Add(this.Button2);
			this.TabPage1.Controls.Add(this.Button1);
			this.TabPage1.Controls.Add(this.ListView2);
			this.TabPage1.Controls.Add(this.ListView1);
			this.TabPage1.Location = new System.Drawing.Point(4, 25);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(668, 537);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "alte Version";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button3.Location = new System.Drawing.Point(466, 501);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(169, 30);
			this.Button3.TabIndex = 15;
			this.Button3.Text = "get server file list";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button2.Location = new System.Drawing.Point(291, 501);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(169, 30);
			this.Button2.TabIndex = 14;
			this.Button2.Text = "start sync";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button1.Location = new System.Drawing.Point(116, 501);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(169, 30);
			this.Button1.TabIndex = 13;
			this.Button1.Text = "create List";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//ListView2
			//
			this.ListView2.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader2
			});
			this.ListView2.FullRowSelect = true;
			this.ListView2.HideSelection = false;
			this.ListView2.Location = new System.Drawing.Point(6, 288);
			this.ListView2.Name = "ListView2";
			this.ListView2.Size = new System.Drawing.Size(627, 207);
			this.ListView2.TabIndex = 12;
			this.ListView2.UseCompatibleStateImageBehavior = false;
			this.ListView2.View = System.Windows.Forms.View.Details;
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.Width = 433;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Width = 138;
			//
			//ListView1
			//
			this.ListView1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.chClientName,
				this.chServerName,
				this.chDirection
			});
			this.ListView1.FullRowSelect = true;
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new System.Drawing.Point(6, 1);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new System.Drawing.Size(627, 282);
			this.ListView1.TabIndex = 11;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = System.Windows.Forms.View.Details;
			//
			//chClientName
			//
			this.chClientName.Text = "Name auf Client";
			this.chClientName.Width = 247;
			//
			//chServerName
			//
			this.chServerName.Text = "Name auf Server";
			this.chServerName.Width = 224;
			//
			//chDirection
			//
			this.chDirection.Text = "Aktion";
			//
			//TabPage2
			//
			this.TabPage2.Location = new System.Drawing.Point(4, 25);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(668, 537);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "webBrowser";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//TabPage3
			//
			this.TabPage3.Controls.Add(this.txtZip_Folder);
			this.TabPage3.Controls.Add(this.Label2);
			this.TabPage3.Controls.Add(this.Button7);
			this.TabPage3.Controls.Add(this.txtZipFile);
			this.TabPage3.Controls.Add(this.Button6);
			this.TabPage3.Controls.Add(this.ListBox1);
			this.TabPage3.Controls.Add(this.Button5);
			this.TabPage3.Controls.Add(this.Label1);
			this.TabPage3.Location = new System.Drawing.Point(4, 25);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage3.Size = new System.Drawing.Size(668, 537);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "SharpZipLib (test)";
			this.TabPage3.UseVisualStyleBackColor = true;
			//
			//txtZip_Folder
			//
			this.txtZip_Folder.Location = new System.Drawing.Point(182, 48);
			this.txtZip_Folder.Name = "txtZip_Folder";
			this.txtZip_Folder.Size = new System.Drawing.Size(284, 22);
			this.txtZip_Folder.TabIndex = 7;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(57, 51);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(126, 16);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "source/targetFolder";
			//
			//Button7
			//
			this.Button7.Location = new System.Drawing.Point(364, 92);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(116, 31);
			this.Button7.TabIndex = 5;
			this.Button7.Text = "zip it";
			this.Button7.UseVisualStyleBackColor = true;
			//
			//txtZipFile
			//
			this.txtZipFile.Location = new System.Drawing.Point(182, 22);
			this.txtZipFile.Name = "txtZipFile";
			this.txtZipFile.Size = new System.Drawing.Size(284, 22);
			this.txtZipFile.TabIndex = 4;
			//
			//Button6
			//
			this.Button6.Location = new System.Drawing.Point(182, 92);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(116, 31);
			this.Button6.TabIndex = 3;
			this.Button6.Text = "extract all";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//ListBox1
			//
			this.ListBox1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.ItemHeight = 16;
			this.ListBox1.Location = new System.Drawing.Point(60, 143);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new System.Drawing.Size(523, 244);
			this.ListBox1.TabIndex = 2;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(60, 92);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(116, 31);
			this.Button5.TabIndex = 1;
			this.Button5.Text = "list";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(57, 25);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(47, 16);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "zipFile";
			//
			//frm_trash
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 590);
			this.Controls.Add(this.TabControl1);
			this.Name = "frm_trash";
			this.Text = "frm_trash";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage4;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.ListView ListView2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ListView ListView1;
		internal System.Windows.Forms.ColumnHeader chClientName;
		internal System.Windows.Forms.ColumnHeader chServerName;
		internal System.Windows.Forms.ColumnHeader chDirection;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.TextBox txtZip_Folder;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.TextBox txtZipFile;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.ListBox ListBox1;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Label Label1;
		public frm_trash()
		{
			InitializeComponent();
		}
	}
}
