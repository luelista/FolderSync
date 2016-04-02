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
	partial class frm_fileList : System.Windows.Forms.Form
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
			System.Windows.Forms.ListViewItem ListViewItem1 = new System.Windows.Forms.ListViewItem("funktion noch nicht implementiert ...");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_fileList));
			this.ListView1 = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			//
			//ListView1
			//
			this.ListView1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.ListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { ListViewItem1 });
			this.ListView1.Location = new System.Drawing.Point(3, 9);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new System.Drawing.Size(516, 404);
			this.ListView1.TabIndex = 0;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = System.Windows.Forms.View.List;
			//
			//frm_fileList
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 428);
			this.Controls.Add(this.ListView1);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "frm_fileList";
			this.Text = "Dateiliste - FolderSync";
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.ListView ListView1;
		public frm_fileList()
		{
			Load += frm_fileList_Load;
			InitializeComponent();
		}
	}
}
