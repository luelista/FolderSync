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
	partial class frm_news : System.Windows.Forms.Form
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
			TenTec.Windows.iGridLib.iGColPattern IGColPattern1 = new TenTec.Windows.iGridLib.iGColPattern();
			TenTec.Windows.iGridLib.iGColPattern IGColPattern2 = new TenTec.Windows.iGridLib.iGColPattern();
			TenTec.Windows.iGridLib.iGColPattern IGColPattern3 = new TenTec.Windows.iGridLib.iGColPattern();
			TenTec.Windows.iGridLib.iGColPattern IGColPattern4 = new TenTec.Windows.iGridLib.iGColPattern();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_news));
			this.IGrid1Col0CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.IGrid1Col0ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.IGrid1Col1CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.IGrid1Col1ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.IGrid1Col2CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.IGrid1Col2ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.IGrid1Col3CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.IGrid1Col3ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.IGrid1 = new TenTec.Windows.iGridLib.iGrid();
			this.IGrid1DefaultCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.IGrid1DefaultColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.IGrid1RowTextColCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			((System.ComponentModel.ISupportInitialize)this.IGrid1).BeginInit();
			this.SuspendLayout();
			//
			//IGrid1Col0CellStyle
			//
			this.IGrid1Col0CellStyle.ContentIndent = new TenTec.Windows.iGridLib.iGIndent(1, 1, 8, 1);
			this.IGrid1Col0CellStyle.TextAlign = TenTec.Windows.iGridLib.iGContentAlignment.TopRight;
			//
			//IGrid1Col1CellStyle
			//
			this.IGrid1Col1CellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.IGrid1Col1CellStyle.ContentIndent = new TenTec.Windows.iGridLib.iGIndent(5, 1, 1, 1);
			this.IGrid1Col1CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			//
			//Button1
			//
			this.Button1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button1.Location = new System.Drawing.Point(670, 332);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(99, 25);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.Button2.Location = new System.Drawing.Point(495, 332);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(169, 25);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "markierte downloaden";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//IGrid1
			//
			this.IGrid1.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.IGrid1.Appearance = TenTec.Windows.iGridLib.iGControlPaintAppearance.StyleFlat;
			this.IGrid1.AutoResizeCols = true;
			this.IGrid1.BorderStyle = TenTec.Windows.iGridLib.iGBorderStyle.Flat;
			IGColPattern1.CellStyle = this.IGrid1Col0CellStyle;
			IGColPattern1.ColHdrStyle = this.IGrid1Col0ColHdrStyle;
			IGColPattern1.Text = "Hauptordner";
			IGColPattern1.Width = 179;
			IGColPattern2.CellStyle = this.IGrid1Col1CellStyle;
			IGColPattern2.ColHdrStyle = this.IGrid1Col1ColHdrStyle;
			IGColPattern2.Text = "Datei";
			IGColPattern2.Width = 287;
			IGColPattern3.CellStyle = this.IGrid1Col2CellStyle;
			IGColPattern3.ColHdrStyle = this.IGrid1Col2ColHdrStyle;
			IGColPattern3.Text = "Letzter Upload";
			IGColPattern3.Width = 191;
			IGColPattern4.CellStyle = this.IGrid1Col3CellStyle;
			IGColPattern4.ColHdrStyle = this.IGrid1Col3ColHdrStyle;
			IGColPattern4.Text = "Dateigröße";
			IGColPattern4.Width = 132;
			this.IGrid1.Cols.AddRange(new TenTec.Windows.iGridLib.iGColPattern[] {
				IGColPattern1,
				IGColPattern2,
				IGColPattern3,
				IGColPattern4
			});
			this.IGrid1.DefaultCol.CellStyle = this.IGrid1DefaultCellStyle;
			this.IGrid1.DefaultCol.ColHdrStyle = this.IGrid1DefaultColHdrStyle;
			this.IGrid1.DefaultRow.Height = 19;
			this.IGrid1.DefaultRow.NormalCellHeight = 19;
			this.IGrid1.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.IGrid1.GridLines.Mode = TenTec.Windows.iGridLib.iGGridLinesMode.None;
			this.IGrid1.Header.Height = 24;
			this.IGrid1.Location = new System.Drawing.Point(0, 0);
			this.IGrid1.Name = "IGrid1";
			this.IGrid1.ReadOnly = true;
			this.IGrid1.RowMode = true;
			this.IGrid1.RowTextCol.CellStyle = this.IGrid1RowTextColCellStyle;
			this.IGrid1.SelectionMode = TenTec.Windows.iGridLib.iGSelectionMode.MultiExtended;
			this.IGrid1.Size = new System.Drawing.Size(791, 327);
			this.IGrid1.TabIndex = 4;
			//
			//frm_news
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 360);
			this.Controls.Add(this.IGrid1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_news";
			this.Text = "Neuste Uploads - FolderSync";
			((System.ComponentModel.ISupportInitialize)this.IGrid1).EndInit();
			this.ResumeLayout(false);

		}
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
		internal System.Windows.Forms.Button Button2;
		internal TenTec.Windows.iGridLib.iGrid IGrid1;
		internal TenTec.Windows.iGridLib.iGCellStyle IGrid1DefaultCellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle IGrid1DefaultColHdrStyle;
		internal TenTec.Windows.iGridLib.iGCellStyle IGrid1RowTextColCellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle IGrid1Col0ColHdrStyle;
		internal TenTec.Windows.iGridLib.iGCellStyle IGrid1Col1CellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle IGrid1Col1ColHdrStyle;
		internal TenTec.Windows.iGridLib.iGCellStyle IGrid1Col2CellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle IGrid1Col2ColHdrStyle;
		internal TenTec.Windows.iGridLib.iGCellStyle IGrid1Col3CellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle IGrid1Col3ColHdrStyle;
		internal TenTec.Windows.iGridLib.iGCellStyle IGrid1Col0CellStyle;
		public frm_news()
		{
			Load += frm_news_Load;
			FormClosing += frm_news_FormClosing;
			InitializeComponent();
		}
	}
}
