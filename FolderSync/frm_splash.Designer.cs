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
	partial class frm_splash : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_splash));
			this.Label1 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(32, 262);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(193, 18);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Programm wird initialisiert ...";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(297, 259);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(107, 26);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Visible = false;
			//
			//LinkLabel1
			//
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.LinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.LinkLabel1.LinkArea = new System.Windows.Forms.LinkArea(9, 40);
			this.LinkLabel1.Location = new System.Drawing.Point(32, 209);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new System.Drawing.Size(273, 19);
			this.LinkLabel1.TabIndex = 2;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "Website: http://vbnet.teamwiki.de/foldersync.html";
			this.LinkLabel1.UseCompatibleTextRendering = true;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(32, 230);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(63, 15);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Version xx";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(32, 175);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(91, 15);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "von Max Weller";
			//
			//frm_splash
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			this.ClientSize = new System.Drawing.Size(440, 300);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.LinkLabel1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_splash";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FolderSync 2.0";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(254)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(254)));
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Button withEventsField_Button1;
		internal System.Windows.Forms.Button Button1 {
			get { return withEventsField_Button1; }
			set {
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click -= Button1_Click;
				}
				withEventsField_Button1 = value;
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click += Button1_Click;
				}
			}
		}
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
	}
}
