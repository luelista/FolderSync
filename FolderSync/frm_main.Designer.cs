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
	partial class frm_main : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
			TenTec.Windows.iGridLib.iGColPattern IGColPattern1 = new TenTec.Windows.iGridLib.iGColPattern();
			TenTec.Windows.iGridLib.iGColPattern IGColPattern2 = new TenTec.Windows.iGridLib.iGColPattern();
			TenTec.Windows.iGridLib.iGColPattern IGColPattern3 = new TenTec.Windows.iGridLib.iGColPattern();
			TenTec.Windows.iGridLib.iGColPattern IGColPattern4 = new TenTec.Windows.iGridLib.iGColPattern();
			this.igBatchListCol1CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.igBatchListCol1ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.igBatchListCol2CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.igBatchListCol2ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.igBatchListCol3CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.igBatchListCol3ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.igBatchListCol5CellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.igBatchListCol5ColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkTopmost = new System.Windows.Forms.CheckBox();
			this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.lnkShortcutF9 = new System.Windows.Forms.LinkLabel();
			this.lnkShortcutF10 = new System.Windows.Forms.LinkLabel();
			this.lnkShortcutF11 = new System.Windows.Forms.LinkLabel();
			this.lnkShortcutF12 = new System.Windows.Forms.LinkLabel();
			this.splLocal = new System.Windows.Forms.SplitContainer();
			this.ftvLocalUpload_Folder = new AxCCRPFolderTV6.AxFolderTreeview();
			this.lvLocalFolder = new System.Windows.Forms.ListView();
			this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.imlLocalFolder = new System.Windows.Forms.ImageList(this.components);
			this.txtLocalFolder = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.cmstripServerTreeview = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DateilisteAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UmbennenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OrdnerLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imlTreeView = new System.Windows.Forms.ImageList(this.components);
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
			this.labState = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.tmrCheckUpdate = new System.Windows.Forms.Timer(this.components);
			this.cmstripExtras = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ÜberMwFolderSyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PoweredByTeamwikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AutomatischesUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splHorizontal = new System.Windows.Forms.SplitContainer();
			this.splMainVert = new System.Windows.Forms.SplitContainer();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnNewestUploads = new System.Windows.Forms.Button();
			this.txtDiz = new System.Windows.Forms.TextBox();
			this.btnRefreshServerFileList = new System.Windows.Forms.Button();
			this.lnkTeamwiki = new System.Windows.Forms.LinkLabel();
			this.Label2 = new System.Windows.Forms.Label();
			this.lnkUpdate = new System.Windows.Forms.LinkLabel();
			this.txtServerFile = new System.Windows.Forms.TextBox();
			this.lnkAbout = new System.Windows.Forms.LinkLabel();
			this.checkCreateBackup = new System.Windows.Forms.CheckBox();
			this.btnServerList_showAll = new System.Windows.Forms.Button();
			this.splServer = new System.Windows.Forms.SplitContainer();
			this.txtServerFolder = new System.Windows.Forms.ComboBox();
			this.lvServerFile = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.lnkClearSuchbox = new System.Windows.Forms.LinkLabel();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.PictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnDelJob = new System.Windows.Forms.Button();
			this.igBatchList = new TenTec.Windows.iGridLib.iGrid();
			this.IGrid1DefaultCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.IGrid1DefaultColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
			this.IGrid1RowTextColCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
			this.btnProcessJobList = new System.Windows.Forms.Button();
			this.btnCancelProcess = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.FlowLayoutPanel1.SuspendLayout();
			this.splLocal.Panel1.SuspendLayout();
			this.splLocal.Panel2.SuspendLayout();
			this.splLocal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.ftvLocalUpload_Folder).BeginInit();
			this.cmstripServerTreeview.SuspendLayout();
			this.cmstripExtras.SuspendLayout();
			this.splHorizontal.Panel1.SuspendLayout();
			this.splHorizontal.Panel2.SuspendLayout();
			this.splHorizontal.SuspendLayout();
			this.splMainVert.Panel1.SuspendLayout();
			this.splMainVert.Panel2.SuspendLayout();
			this.splMainVert.SuspendLayout();
			this.splServer.Panel1.SuspendLayout();
			this.splServer.Panel2.SuspendLayout();
			this.splServer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.igBatchList).BeginInit();
			this.SuspendLayout();
			//
			//igBatchListCol1CellStyle
			//
			this.igBatchListCol1CellStyle.ReadOnly = TenTec.Windows.iGridLib.iGBool.True;
			//
			//igBatchListCol2CellStyle
			//
			this.igBatchListCol2CellStyle.ReadOnly = TenTec.Windows.iGridLib.iGBool.True;
			//
			//igBatchListCol3CellStyle
			//
			this.igBatchListCol3CellStyle.ReadOnly = TenTec.Windows.iGridLib.iGBool.True;
			//
			//igBatchListCol5CellStyle
			//
			this.igBatchListCol5CellStyle.ReadOnly = TenTec.Windows.iGridLib.iGBool.True;
			//
			//PictureBox1
			//
			this.PictureBox1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.PictureBox1.BackColor = System.Drawing.Color.White;
			this.PictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("PictureBox1.BackgroundImage");
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(-87, -37);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Padding = new System.Windows.Forms.Padding(88, 0, 0, 0);
			this.PictureBox1.Size = new System.Drawing.Size(125, 12);
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			//
			//checkTopmost
			//
			this.checkTopmost.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.checkTopmost.AutoSize = true;
			this.checkTopmost.BackColor = System.Drawing.Color.Transparent;
			this.checkTopmost.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkTopmost.ForeColor = System.Drawing.Color.Black;
			this.checkTopmost.Location = new System.Drawing.Point(-66, 0);
			this.checkTopmost.Name = "checkTopmost";
			this.checkTopmost.Size = new System.Drawing.Size(41, 17);
			this.checkTopmost.TabIndex = 6;
			this.checkTopmost.Text = "top";
			this.checkTopmost.UseVisualStyleBackColor = false;
			this.checkTopmost.Visible = false;
			//
			//FlowLayoutPanel1
			//
			this.FlowLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.FlowLayoutPanel1.Controls.Add(this.lnkShortcutF9);
			this.FlowLayoutPanel1.Controls.Add(this.lnkShortcutF10);
			this.FlowLayoutPanel1.Controls.Add(this.lnkShortcutF11);
			this.FlowLayoutPanel1.Controls.Add(this.lnkShortcutF12);
			this.FlowLayoutPanel1.Location = new System.Drawing.Point(4, 440);
			this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
			this.FlowLayoutPanel1.Size = new System.Drawing.Size(288, 23);
			this.FlowLayoutPanel1.TabIndex = 8;
			//
			//lnkShortcutF9
			//
			this.lnkShortcutF9.AutoSize = true;
			this.lnkShortcutF9.Location = new System.Drawing.Point(3, 0);
			this.lnkShortcutF9.Name = "lnkShortcutF9";
			this.lnkShortcutF9.Size = new System.Drawing.Size(59, 13);
			this.lnkShortcutF9.TabIndex = 0;
			this.lnkShortcutF9.TabStop = true;
			this.lnkShortcutF9.Tag = "1";
			this.lnkShortcutF9.Text = "LinkLabel1";
			//
			//lnkShortcutF10
			//
			this.lnkShortcutF10.AutoSize = true;
			this.lnkShortcutF10.Location = new System.Drawing.Point(68, 0);
			this.lnkShortcutF10.Name = "lnkShortcutF10";
			this.lnkShortcutF10.Size = new System.Drawing.Size(59, 13);
			this.lnkShortcutF10.TabIndex = 1;
			this.lnkShortcutF10.TabStop = true;
			this.lnkShortcutF10.Tag = "2";
			this.lnkShortcutF10.Text = "LinkLabel2";
			//
			//lnkShortcutF11
			//
			this.lnkShortcutF11.AutoSize = true;
			this.lnkShortcutF11.Location = new System.Drawing.Point(133, 0);
			this.lnkShortcutF11.Name = "lnkShortcutF11";
			this.lnkShortcutF11.Size = new System.Drawing.Size(59, 13);
			this.lnkShortcutF11.TabIndex = 2;
			this.lnkShortcutF11.TabStop = true;
			this.lnkShortcutF11.Tag = "3";
			this.lnkShortcutF11.Text = "LinkLabel3";
			//
			//lnkShortcutF12
			//
			this.lnkShortcutF12.AutoSize = true;
			this.lnkShortcutF12.Location = new System.Drawing.Point(198, 0);
			this.lnkShortcutF12.Name = "lnkShortcutF12";
			this.lnkShortcutF12.Size = new System.Drawing.Size(59, 13);
			this.lnkShortcutF12.TabIndex = 3;
			this.lnkShortcutF12.TabStop = true;
			this.lnkShortcutF12.Tag = "4";
			this.lnkShortcutF12.Text = "LinkLabel4";
			//
			//splLocal
			//
			this.splLocal.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.splLocal.Location = new System.Drawing.Point(10, 46);
			this.splLocal.Name = "splLocal";
			this.splLocal.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//splLocal.Panel1
			//
			this.splLocal.Panel1.Controls.Add(this.ftvLocalUpload_Folder);
			//
			//splLocal.Panel2
			//
			this.splLocal.Panel2.Controls.Add(this.lvLocalFolder);
			this.splLocal.Size = new System.Drawing.Size(282, 392);
			this.splLocal.SplitterDistance = 163;
			this.splLocal.TabIndex = 7;
			//
			//ftvLocalUpload_Folder
			//
			this.ftvLocalUpload_Folder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ftvLocalUpload_Folder.Location = new System.Drawing.Point(0, 0);
			this.ftvLocalUpload_Folder.Name = "ftvLocalUpload_Folder";
			this.ftvLocalUpload_Folder.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("ftvLocalUpload_Folder.OcxState");
			this.ftvLocalUpload_Folder.Size = new System.Drawing.Size(282, 163);
			this.ftvLocalUpload_Folder.TabIndex = 1;
			//
			//lvLocalFolder
			//
			this.lvLocalFolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ColumnHeader5 });
			this.lvLocalFolder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvLocalFolder.FullRowSelect = true;
			this.lvLocalFolder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvLocalFolder.HideSelection = false;
			this.lvLocalFolder.Location = new System.Drawing.Point(0, 0);
			this.lvLocalFolder.MultiSelect = false;
			this.lvLocalFolder.Name = "lvLocalFolder";
			this.lvLocalFolder.Size = new System.Drawing.Size(282, 225);
			this.lvLocalFolder.SmallImageList = this.imlLocalFolder;
			this.lvLocalFolder.TabIndex = 0;
			this.lvLocalFolder.UseCompatibleStateImageBehavior = false;
			this.lvLocalFolder.View = System.Windows.Forms.View.Details;
			//
			//ColumnHeader5
			//
			this.ColumnHeader5.Width = 269;
			//
			//imlLocalFolder
			//
			this.imlLocalFolder.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imlLocalFolder.ImageSize = new System.Drawing.Size(16, 16);
			this.imlLocalFolder.TransparentColor = System.Drawing.Color.Transparent;
			//
			//txtLocalFolder
			//
			this.txtLocalFolder.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtLocalFolder.Location = new System.Drawing.Point(10, 22);
			this.txtLocalFolder.Name = "txtLocalFolder";
			this.txtLocalFolder.Size = new System.Drawing.Size(254, 20);
			this.txtLocalFolder.TabIndex = 6;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(6, 5);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(42, 15);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "Lokal";
			//
			//Label6
			//
			this.Label6.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.Label6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Label6.Image = (System.Drawing.Image)resources.GetObject("Label6.Image");
			this.Label6.Location = new System.Drawing.Point(269, 23);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(17, 17);
			this.Label6.TabIndex = 8;
			//
			//cmstripServerTreeview
			//
			this.cmstripServerTreeview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.DateilisteAnzeigenToolStripMenuItem,
				this.UmbennenToolStripMenuItem,
				this.OrdnerLöschenToolStripMenuItem
			});
			this.cmstripServerTreeview.Name = "cmstripServerTreeview";
			this.cmstripServerTreeview.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.cmstripServerTreeview.Size = new System.Drawing.Size(164, 70);
			//
			//DateilisteAnzeigenToolStripMenuItem
			//
			this.DateilisteAnzeigenToolStripMenuItem.Name = "DateilisteAnzeigenToolStripMenuItem";
			this.DateilisteAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.DateilisteAnzeigenToolStripMenuItem.Text = "Dateiliste anzeigen";
			//
			//UmbennenToolStripMenuItem
			//
			this.UmbennenToolStripMenuItem.Name = "UmbennenToolStripMenuItem";
			this.UmbennenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.UmbennenToolStripMenuItem.Text = "Umbennen";
			//
			//OrdnerLöschenToolStripMenuItem
			//
			this.OrdnerLöschenToolStripMenuItem.Name = "OrdnerLöschenToolStripMenuItem";
			this.OrdnerLöschenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.OrdnerLöschenToolStripMenuItem.Text = "Ordner löschen";
			//
			//imlTreeView
			//
			this.imlTreeView.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imlTreeView.ImageStream");
			this.imlTreeView.TransparentColor = System.Drawing.Color.Transparent;
			this.imlTreeView.Images.SetKeyName(0, "fld");
			this.imlTreeView.Images.SetKeyName(1, "zip");
			this.imlTreeView.Images.SetKeyName(2, "wmploc_602.png");
			this.imlTreeView.Images.SetKeyName(3, "benutzer1.png");
			//
			//btnDownload
			//
			this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnDownload.ForeColor = System.Drawing.Color.Black;
			this.btnDownload.Image = (System.Drawing.Image)resources.GetObject("btnDownload.Image");
			this.btnDownload.Location = new System.Drawing.Point(-1, 181);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(87, 46);
			this.btnDownload.TabIndex = 2;
			this.btnDownload.Text = "down load";
			this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDownload.UseVisualStyleBackColor = true;
			//
			//btnUpload
			//
			this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnUpload.Image = (System.Drawing.Image)resources.GetObject("btnUpload.Image");
			this.btnUpload.Location = new System.Drawing.Point(-1, 133);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(87, 47);
			this.btnUpload.TabIndex = 1;
			this.btnUpload.Text = "upload";
			this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnUpload.UseVisualStyleBackColor = true;
			//
			//ProgressBar1
			//
			this.ProgressBar1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.ProgressBar1.Location = new System.Drawing.Point(127, 114);
			this.ProgressBar1.Maximum = 222;
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(768, 22);
			this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBar1.TabIndex = 17;
			this.ProgressBar1.Visible = false;
			//
			//WebBrowser1
			//
			this.WebBrowser1.Location = new System.Drawing.Point(-333, 461);
			this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.Size = new System.Drawing.Size(220, 107);
			this.WebBrowser1.TabIndex = 18;
			this.WebBrowser1.Visible = false;
			//
			//labState
			//
			this.labState.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.labState.AutoSize = true;
			this.labState.Location = new System.Drawing.Point(269, 114);
			this.labState.Name = "labState";
			this.labState.Size = new System.Drawing.Size(37, 13);
			this.labState.TabIndex = 19;
			this.labState.Text = "Bereit.";
			//
			//Timer1
			//
			this.Timer1.Interval = 88;
			//
			//btnClose
			//
			this.btnClose.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnClose.ForeColor = System.Drawing.Color.Red;
			this.btnClose.Location = new System.Drawing.Point(869, -35);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(36, 24);
			this.btnClose.TabIndex = 31;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//btnMinimize
			//
			this.btnMinimize.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnMinimize.Location = new System.Drawing.Point(841, -35);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(26, 24);
			this.btnMinimize.TabIndex = 30;
			this.btnMinimize.Text = "_";
			this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnMinimize.UseVisualStyleBackColor = true;
			//
			//tmrCheckUpdate
			//
			this.tmrCheckUpdate.Interval = 10000;
			//
			//cmstripExtras
			//
			this.cmstripExtras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.ÜberMwFolderSyncToolStripMenuItem,
				this.PoweredByTeamwikiToolStripMenuItem,
				this.AutomatischesUpdateToolStripMenuItem
			});
			this.cmstripExtras.Name = "cmstripExtras";
			this.cmstripExtras.Size = new System.Drawing.Size(196, 70);
			//
			//ÜberMwFolderSyncToolStripMenuItem
			//
			this.ÜberMwFolderSyncToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ÜberMwFolderSyncToolStripMenuItem.Image");
			this.ÜberMwFolderSyncToolStripMenuItem.Name = "ÜberMwFolderSyncToolStripMenuItem";
			this.ÜberMwFolderSyncToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.ÜberMwFolderSyncToolStripMenuItem.Text = "Über mwFolderSync ...";
			//
			//PoweredByTeamwikiToolStripMenuItem
			//
			this.PoweredByTeamwikiToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("PoweredByTeamwikiToolStripMenuItem.Image");
			this.PoweredByTeamwikiToolStripMenuItem.Name = "PoweredByTeamwikiToolStripMenuItem";
			this.PoweredByTeamwikiToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.PoweredByTeamwikiToolStripMenuItem.Text = "powered by: Teamwiki.de";
			//
			//AutomatischesUpdateToolStripMenuItem
			//
			this.AutomatischesUpdateToolStripMenuItem.Name = "AutomatischesUpdateToolStripMenuItem";
			this.AutomatischesUpdateToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.AutomatischesUpdateToolStripMenuItem.Text = "Automatisches Update";
			//
			//splHorizontal
			//
			this.splHorizontal.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.splHorizontal.BackColor = System.Drawing.SystemColors.Control;
			this.splHorizontal.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splHorizontal.Location = new System.Drawing.Point(0, 0);
			this.splHorizontal.Name = "splHorizontal";
			this.splHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//splHorizontal.Panel1
			//
			this.splHorizontal.Panel1.Controls.Add(this.splMainVert);
			//
			//splHorizontal.Panel2
			//
			this.splHorizontal.Panel2.Controls.Add(this.btnDelJob);
			this.splHorizontal.Panel2.Controls.Add(this.igBatchList);
			this.splHorizontal.Panel2.Controls.Add(this.ProgressBar1);
			this.splHorizontal.Panel2.Controls.Add(this.labState);
			this.splHorizontal.Panel2.Controls.Add(this.btnProcessJobList);
			this.splHorizontal.Panel2.Controls.Add(this.btnCancelProcess);
			this.splHorizontal.Size = new System.Drawing.Size(911, 606);
			this.splHorizontal.SplitterDistance = 463;
			this.splHorizontal.TabIndex = 29;
			//
			//splMainVert
			//
			this.splMainVert.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splMainVert.Location = new System.Drawing.Point(0, 0);
			this.splMainVert.Name = "splMainVert";
			//
			//splMainVert.Panel1
			//
			this.splMainVert.Panel1.Controls.Add(this.FlowLayoutPanel1);
			this.splMainVert.Panel1.Controls.Add(this.Label4);
			this.splMainVert.Panel1.Controls.Add(this.splLocal);
			this.splMainVert.Panel1.Controls.Add(this.txtLocalFolder);
			this.splMainVert.Panel1.Controls.Add(this.Label6);
			//
			//splMainVert.Panel2
			//
			this.splMainVert.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splMainVert.Panel2.Controls.Add(this.btnSettings);
			this.splMainVert.Panel2.Controls.Add(this.btnNewestUploads);
			this.splMainVert.Panel2.Controls.Add(this.txtDiz);
			this.splMainVert.Panel2.Controls.Add(this.btnRefreshServerFileList);
			this.splMainVert.Panel2.Controls.Add(this.lnkTeamwiki);
			this.splMainVert.Panel2.Controls.Add(this.Label2);
			this.splMainVert.Panel2.Controls.Add(this.lnkUpdate);
			this.splMainVert.Panel2.Controls.Add(this.txtServerFile);
			this.splMainVert.Panel2.Controls.Add(this.lnkAbout);
			this.splMainVert.Panel2.Controls.Add(this.checkCreateBackup);
			this.splMainVert.Panel2.Controls.Add(this.btnDownload);
			this.splMainVert.Panel2.Controls.Add(this.btnServerList_showAll);
			this.splMainVert.Panel2.Controls.Add(this.btnUpload);
			this.splMainVert.Panel2.Controls.Add(this.splServer);
			this.splMainVert.Panel2.Controls.Add(this.lnkClearSuchbox);
			this.splMainVert.Panel2.Controls.Add(this.txtSearch);
			this.splMainVert.Panel2.Controls.Add(this.PictureBox2);
			this.splMainVert.Panel2.Controls.Add(this.PictureBox3);
			this.splMainVert.Size = new System.Drawing.Size(911, 463);
			this.splMainVert.SplitterDistance = 292;
			this.splMainVert.TabIndex = 14;
			//
			//btnSettings
			//
			this.btnSettings.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnSettings.Location = new System.Drawing.Point(526, 5);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(82, 23);
			this.btnSettings.TabIndex = 41;
			this.btnSettings.Text = "Einstellungen";
			this.btnSettings.UseVisualStyleBackColor = true;
			//
			//btnNewestUploads
			//
			this.btnNewestUploads.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnNewestUploads.Location = new System.Drawing.Point(425, 5);
			this.btnNewestUploads.Name = "btnNewestUploads";
			this.btnNewestUploads.Size = new System.Drawing.Size(100, 23);
			this.btnNewestUploads.TabIndex = 40;
			this.btnNewestUploads.Text = "Neuste Uploads";
			this.btnNewestUploads.UseVisualStyleBackColor = true;
			//
			//txtDiz
			//
			this.txtDiz.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.txtDiz.Location = new System.Drawing.Point(4, 417);
			this.txtDiz.Name = "txtDiz";
			this.txtDiz.Size = new System.Drawing.Size(82, 20);
			this.txtDiz.TabIndex = 39;
			this.txtDiz.Text = "DIZ";
			//
			//btnRefreshServerFileList
			//
			this.btnRefreshServerFileList.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnRefreshServerFileList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefreshServerFileList.Image = (System.Drawing.Image)resources.GetObject("btnRefreshServerFileList.Image");
			this.btnRefreshServerFileList.Location = new System.Drawing.Point(476, 438);
			this.btnRefreshServerFileList.Name = "btnRefreshServerFileList";
			this.btnRefreshServerFileList.Size = new System.Drawing.Size(133, 25);
			this.btnRefreshServerFileList.TabIndex = 3;
			this.btnRefreshServerFileList.Text = "Liste aktualisieren";
			this.btnRefreshServerFileList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRefreshServerFileList.UseVisualStyleBackColor = true;
			//
			//lnkTeamwiki
			//
			this.lnkTeamwiki.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.lnkTeamwiki.AutoSize = true;
			this.lnkTeamwiki.BackColor = System.Drawing.SystemColors.Control;
			this.lnkTeamwiki.ForeColor = System.Drawing.Color.Black;
			this.lnkTeamwiki.LinkColor = System.Drawing.Color.Blue;
			this.lnkTeamwiki.Location = new System.Drawing.Point(542, 33);
			this.lnkTeamwiki.Name = "lnkTeamwiki";
			this.lnkTeamwiki.Size = new System.Drawing.Size(63, 13);
			this.lnkTeamwiki.TabIndex = 36;
			this.lnkTeamwiki.TabStop = true;
			this.lnkTeamwiki.Text = "teamwiki.de";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(127, 59);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(35, 13);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Name";
			//
			//lnkUpdate
			//
			this.lnkUpdate.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.lnkUpdate.AutoSize = true;
			this.lnkUpdate.BackColor = System.Drawing.SystemColors.Control;
			this.lnkUpdate.ForeColor = System.Drawing.Color.Black;
			this.lnkUpdate.LinkColor = System.Drawing.Color.Blue;
			this.lnkUpdate.Location = new System.Drawing.Point(446, 33);
			this.lnkUpdate.Name = "lnkUpdate";
			this.lnkUpdate.Size = new System.Drawing.Size(42, 13);
			this.lnkUpdate.TabIndex = 35;
			this.lnkUpdate.TabStop = true;
			this.lnkUpdate.Text = "Update";
			//
			//txtServerFile
			//
			this.txtServerFile.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.txtServerFile.Location = new System.Drawing.Point(165, 56);
			this.txtServerFile.Name = "txtServerFile";
			this.txtServerFile.ReadOnly = true;
			this.txtServerFile.Size = new System.Drawing.Size(257, 20);
			this.txtServerFile.TabIndex = 7;
			//
			//lnkAbout
			//
			this.lnkAbout.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.lnkAbout.AutoSize = true;
			this.lnkAbout.BackColor = System.Drawing.SystemColors.Control;
			this.lnkAbout.ForeColor = System.Drawing.Color.Black;
			this.lnkAbout.LinkColor = System.Drawing.Color.Blue;
			this.lnkAbout.Location = new System.Drawing.Point(494, 33);
			this.lnkAbout.Name = "lnkAbout";
			this.lnkAbout.Size = new System.Drawing.Size(44, 13);
			this.lnkAbout.TabIndex = 34;
			this.lnkAbout.TabStop = true;
			this.lnkAbout.Text = "About...";
			//
			//checkCreateBackup
			//
			this.checkCreateBackup.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.checkCreateBackup.AutoSize = true;
			this.checkCreateBackup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkCreateBackup.Location = new System.Drawing.Point(230, 443);
			this.checkCreateBackup.Name = "checkCreateBackup";
			this.checkCreateBackup.Size = new System.Drawing.Size(134, 17);
			this.checkCreateBackup.TabIndex = 12;
			this.checkCreateBackup.Text = "bei Download: Backup";
			this.checkCreateBackup.UseVisualStyleBackColor = true;
			//
			//btnServerList_showAll
			//
			this.btnServerList_showAll.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnServerList_showAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnServerList_showAll.Location = new System.Drawing.Point(374, 438);
			this.btnServerList_showAll.Name = "btnServerList_showAll";
			this.btnServerList_showAll.Size = new System.Drawing.Size(96, 25);
			this.btnServerList_showAll.TabIndex = 10;
			this.btnServerList_showAll.Text = "Alle anzeigen";
			this.btnServerList_showAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnServerList_showAll.UseVisualStyleBackColor = true;
			//
			//splServer
			//
			this.splServer.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.splServer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splServer.Location = new System.Drawing.Point(88, 80);
			this.splServer.Name = "splServer";
			//
			//splServer.Panel1
			//
			this.splServer.Panel1.Controls.Add(this.txtServerFolder);
			//
			//splServer.Panel2
			//
			this.splServer.Panel2.Controls.Add(this.lvServerFile);
			this.splServer.Size = new System.Drawing.Size(520, 357);
			this.splServer.SplitterDistance = 120;
			this.splServer.TabIndex = 11;
			//
			//txtServerFolder
			//
			this.txtServerFolder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtServerFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.txtServerFolder.FormattingEnabled = true;
			this.txtServerFolder.IntegralHeight = false;
			this.txtServerFolder.Location = new System.Drawing.Point(0, 0);
			this.txtServerFolder.Name = "txtServerFolder";
			this.txtServerFolder.Size = new System.Drawing.Size(120, 357);
			this.txtServerFolder.TabIndex = 8;
			//
			//lvServerFile
			//
			this.lvServerFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader3,
				this.ColumnHeader6,
				this.ColumnHeader4
			});
			this.lvServerFile.ContextMenuStrip = this.cmstripServerTreeview;
			this.lvServerFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvServerFile.FullRowSelect = true;
			this.lvServerFile.HideSelection = false;
			this.lvServerFile.Location = new System.Drawing.Point(0, 0);
			this.lvServerFile.MultiSelect = false;
			this.lvServerFile.Name = "lvServerFile";
			this.lvServerFile.ShowItemToolTips = true;
			this.lvServerFile.Size = new System.Drawing.Size(396, 357);
			this.lvServerFile.SmallImageList = this.imlTreeView;
			this.lvServerFile.TabIndex = 9;
			this.lvServerFile.UseCompatibleStateImageBehavior = false;
			this.lvServerFile.View = System.Windows.Forms.View.Details;
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.DisplayIndex = 1;
			this.ColumnHeader1.Text = "Dateiname";
			this.ColumnHeader1.Width = 127;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.DisplayIndex = 0;
			this.ColumnHeader2.Text = "Pfad";
			this.ColumnHeader2.Width = 0;
			//
			//ColumnHeader3
			//
			this.ColumnHeader3.Text = "Datum";
			this.ColumnHeader3.Width = 111;
			//
			//ColumnHeader6
			//
			this.ColumnHeader6.Text = "DIZ";
			this.ColumnHeader6.Width = 59;
			//
			//ColumnHeader4
			//
			this.ColumnHeader4.Text = "Größe";
			this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ColumnHeader4.Width = 62;
			//
			//lnkClearSuchbox
			//
			this.lnkClearSuchbox.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.lnkClearSuchbox.AutoSize = true;
			this.lnkClearSuchbox.BackColor = System.Drawing.Color.White;
			this.lnkClearSuchbox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lnkClearSuchbox.Image = (System.Drawing.Image)resources.GetObject("lnkClearSuchbox.Image");
			this.lnkClearSuchbox.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lnkClearSuchbox.Location = new System.Drawing.Point(586, 60);
			this.lnkClearSuchbox.Name = "lnkClearSuchbox";
			this.lnkClearSuchbox.Size = new System.Drawing.Size(16, 13);
			this.lnkClearSuchbox.TabIndex = 32;
			this.lnkClearSuchbox.TabStop = true;
			this.lnkClearSuchbox.Text = "   ";
			//
			//txtSearch
			//
			this.txtSearch.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.txtSearch.Location = new System.Drawing.Point(425, 56);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(183, 20);
			this.txtSearch.TabIndex = 31;
			//
			//PictureBox2
			//
			this.PictureBox2.BackColor = System.Drawing.SystemColors.Control;
			this.PictureBox2.Image = (System.Drawing.Image)resources.GetObject("PictureBox2.Image");
			this.PictureBox2.Location = new System.Drawing.Point(132, -35);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(246, 92);
			this.PictureBox2.TabIndex = 37;
			this.PictureBox2.TabStop = false;
			//
			//PictureBox3
			//
			this.PictureBox3.Image = (System.Drawing.Image)resources.GetObject("PictureBox3.Image");
			this.PictureBox3.Location = new System.Drawing.Point(28, -21);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new System.Drawing.Size(100, 100);
			this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox3.TabIndex = 38;
			this.PictureBox3.TabStop = false;
			//
			//btnDelJob
			//
			this.btnDelJob.Location = new System.Drawing.Point(9, 114);
			this.btnDelJob.Name = "btnDelJob";
			this.btnDelJob.Size = new System.Drawing.Size(87, 23);
			this.btnDelJob.TabIndex = 21;
			this.btnDelJob.Text = "entfernen";
			this.btnDelJob.UseVisualStyleBackColor = true;
			//
			//igBatchList
			//
			this.igBatchList.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.igBatchList.AutoResizeCols = true;
			IGColPattern1.CellStyle = this.igBatchListCol1CellStyle;
			IGColPattern1.ColHdrStyle = this.igBatchListCol1ColHdrStyle;
			IGColPattern1.Key = "locfolder";
			IGColPattern1.Text = "Lokaler Ordner";
			IGColPattern1.Width = 317;
			IGColPattern2.CellStyle = this.igBatchListCol2CellStyle;
			IGColPattern2.ColHdrStyle = this.igBatchListCol2ColHdrStyle;
			IGColPattern2.Key = "direction";
			IGColPattern2.Text = "<-->";
			IGColPattern2.Width = 58;
			IGColPattern3.CellStyle = this.igBatchListCol3CellStyle;
			IGColPattern3.ColHdrStyle = this.igBatchListCol3ColHdrStyle;
			IGColPattern3.Key = "servername";
			IGColPattern3.Text = "Archivname auf Server";
			IGColPattern3.Width = 317;
			IGColPattern4.CellStyle = this.igBatchListCol5CellStyle;
			IGColPattern4.ColHdrStyle = this.igBatchListCol5ColHdrStyle;
			IGColPattern4.Key = "progress";
			IGColPattern4.Text = "Fortschritt";
			IGColPattern4.Width = 110;
			this.igBatchList.Cols.AddRange(new TenTec.Windows.iGridLib.iGColPattern[] {
				IGColPattern1,
				IGColPattern2,
				IGColPattern3,
				IGColPattern4
			});
			this.igBatchList.DefaultCol.CellStyle = this.IGrid1DefaultCellStyle;
			this.igBatchList.DefaultCol.ColHdrStyle = this.IGrid1DefaultColHdrStyle;
			this.igBatchList.Header.AllowPress = false;
			this.igBatchList.Location = new System.Drawing.Point(99, 8);
			this.igBatchList.Name = "igBatchList";
			this.igBatchList.RowTextCol.CellStyle = this.IGrid1RowTextColCellStyle;
			this.igBatchList.Size = new System.Drawing.Size(806, 129);
			this.igBatchList.TabIndex = 20;
			//
			//btnProcessJobList
			//
			this.btnProcessJobList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProcessJobList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnProcessJobList.ForeColor = System.Drawing.Color.Black;
			this.btnProcessJobList.Image = (System.Drawing.Image)resources.GetObject("btnProcessJobList.Image");
			this.btnProcessJobList.Location = new System.Drawing.Point(9, 8);
			this.btnProcessJobList.Name = "btnProcessJobList";
			this.btnProcessJobList.Size = new System.Drawing.Size(87, 80);
			this.btnProcessJobList.TabIndex = 10;
			this.btnProcessJobList.Text = "Start";
			this.btnProcessJobList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnProcessJobList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnProcessJobList.UseVisualStyleBackColor = true;
			//
			//btnCancelProcess
			//
			this.btnCancelProcess.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelProcess.Enabled = false;
			this.btnCancelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnCancelProcess.ForeColor = System.Drawing.Color.Black;
			this.btnCancelProcess.Image = (System.Drawing.Image)resources.GetObject("btnCancelProcess.Image");
			this.btnCancelProcess.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnCancelProcess.Location = new System.Drawing.Point(9, 88);
			this.btnCancelProcess.Name = "btnCancelProcess";
			this.btnCancelProcess.Size = new System.Drawing.Size(87, 25);
			this.btnCancelProcess.TabIndex = 11;
			this.btnCancelProcess.Text = "Stopp";
			this.btnCancelProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelProcess.UseVisualStyleBackColor = true;
			this.btnCancelProcess.Visible = false;
			//
			//frm_main
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(910, 606);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnMinimize);
			this.Controls.Add(this.checkTopmost);
			this.Controls.Add(this.WebBrowser1);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.splHorizontal);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(793, 572);
			this.Name = "frm_main";
			this.Text = "frm_main";
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.FlowLayoutPanel1.ResumeLayout(false);
			this.FlowLayoutPanel1.PerformLayout();
			this.splLocal.Panel1.ResumeLayout(false);
			this.splLocal.Panel2.ResumeLayout(false);
			this.splLocal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.ftvLocalUpload_Folder).EndInit();
			this.cmstripServerTreeview.ResumeLayout(false);
			this.cmstripExtras.ResumeLayout(false);
			this.splHorizontal.Panel1.ResumeLayout(false);
			this.splHorizontal.Panel2.ResumeLayout(false);
			this.splHorizontal.Panel2.PerformLayout();
			this.splHorizontal.ResumeLayout(false);
			this.splMainVert.Panel1.ResumeLayout(false);
			this.splMainVert.Panel1.PerformLayout();
			this.splMainVert.Panel2.ResumeLayout(false);
			this.splMainVert.Panel2.PerformLayout();
			this.splMainVert.ResumeLayout(false);
			this.splServer.Panel1.ResumeLayout(false);
			this.splServer.Panel2.ResumeLayout(false);
			this.splServer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)this.igBatchList).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox withEventsField_PictureBox1;
		internal System.Windows.Forms.PictureBox PictureBox1 {
			get { return withEventsField_PictureBox1; }
			set {
				if (withEventsField_PictureBox1 != null) {
					withEventsField_PictureBox1.MouseDown -= PictureBox1_MouseDown;
				}
				withEventsField_PictureBox1 = value;
				if (withEventsField_PictureBox1 != null) {
					withEventsField_PictureBox1.MouseDown += PictureBox1_MouseDown;
				}
			}
		}
		private System.Windows.Forms.CheckBox withEventsField_checkTopmost;
		internal System.Windows.Forms.CheckBox checkTopmost {
			get { return withEventsField_checkTopmost; }
			set {
				if (withEventsField_checkTopmost != null) {
					withEventsField_checkTopmost.CheckedChanged -= checkTopmost_CheckedChanged;
				}
				withEventsField_checkTopmost = value;
				if (withEventsField_checkTopmost != null) {
					withEventsField_checkTopmost.CheckedChanged += checkTopmost_CheckedChanged;
				}
			}
		}
		internal System.Windows.Forms.ImageList imlTreeView;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		private System.Windows.Forms.Button withEventsField_btnDownload;
		internal System.Windows.Forms.Button btnDownload {
			get { return withEventsField_btnDownload; }
			set {
				if (withEventsField_btnDownload != null) {
					withEventsField_btnDownload.Click -= btnDownload_Click;
					withEventsField_btnDownload.MouseDown -= btnDownload_Mousedown;
				}
				withEventsField_btnDownload = value;
				if (withEventsField_btnDownload != null) {
					withEventsField_btnDownload.Click += btnDownload_Click;
					withEventsField_btnDownload.MouseDown += btnDownload_Mousedown;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnUpload;
		internal System.Windows.Forms.Button btnUpload {
			get { return withEventsField_btnUpload; }
			set {
				if (withEventsField_btnUpload != null) {
					withEventsField_btnUpload.MouseDown -= btnUpload_Mousedown;
				}
				withEventsField_btnUpload = value;
				if (withEventsField_btnUpload != null) {
					withEventsField_btnUpload.MouseDown += btnUpload_Mousedown;
				}
			}
		}
		internal System.Windows.Forms.WebBrowser WebBrowser1;
		internal System.Windows.Forms.Label labState;
		internal System.Windows.Forms.SplitContainer splLocal;
		private AxCCRPFolderTV6.AxFolderTreeview withEventsField_ftvLocalUpload_Folder;
		internal AxCCRPFolderTV6.AxFolderTreeview ftvLocalUpload_Folder {
			get { return withEventsField_ftvLocalUpload_Folder; }
			set {
				if (withEventsField_ftvLocalUpload_Folder != null) {
					withEventsField_ftvLocalUpload_Folder.SelectionChange -= ftvLocalUpload_Folder_SelectionChange;
				}
				withEventsField_ftvLocalUpload_Folder = value;
				if (withEventsField_ftvLocalUpload_Folder != null) {
					withEventsField_ftvLocalUpload_Folder.SelectionChange += ftvLocalUpload_Folder_SelectionChange;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtLocalFolder;
		internal System.Windows.Forms.TextBox txtLocalFolder {
			get { return withEventsField_txtLocalFolder; }
			set {
				if (withEventsField_txtLocalFolder != null) {
					withEventsField_txtLocalFolder.KeyDown -= txtLocalFolder_KeyDown;
				}
				withEventsField_txtLocalFolder = value;
				if (withEventsField_txtLocalFolder != null) {
					withEventsField_txtLocalFolder.KeyDown += txtLocalFolder_KeyDown;
				}
			}
		}
		internal System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label withEventsField_Label6;
		internal System.Windows.Forms.Label Label6 {
			get { return withEventsField_Label6; }
			set {
				if (withEventsField_Label6 != null) {
					withEventsField_Label6.Click -= Label6_Click;
				}
				withEventsField_Label6 = value;
				if (withEventsField_Label6 != null) {
					withEventsField_Label6.Click += Label6_Click;
				}
			}
		}
		internal System.Windows.Forms.ContextMenuStrip cmstripServerTreeview;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_DateilisteAnzeigenToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DateilisteAnzeigenToolStripMenuItem {
			get { return withEventsField_DateilisteAnzeigenToolStripMenuItem; }
			set {
				if (withEventsField_DateilisteAnzeigenToolStripMenuItem != null) {
					withEventsField_DateilisteAnzeigenToolStripMenuItem.Click -= DateilisteAnzeigenToolStripMenuItem_Click;
				}
				withEventsField_DateilisteAnzeigenToolStripMenuItem = value;
				if (withEventsField_DateilisteAnzeigenToolStripMenuItem != null) {
					withEventsField_DateilisteAnzeigenToolStripMenuItem.Click += DateilisteAnzeigenToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_UmbennenToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem UmbennenToolStripMenuItem {
			get { return withEventsField_UmbennenToolStripMenuItem; }
			set {
				if (withEventsField_UmbennenToolStripMenuItem != null) {
					withEventsField_UmbennenToolStripMenuItem.Click -= UmbennenToolStripMenuItem_Click;
				}
				withEventsField_UmbennenToolStripMenuItem = value;
				if (withEventsField_UmbennenToolStripMenuItem != null) {
					withEventsField_UmbennenToolStripMenuItem.Click += UmbennenToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.ToolStripMenuItem withEventsField_OrdnerLöschenToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OrdnerLöschenToolStripMenuItem {
			get { return withEventsField_OrdnerLöschenToolStripMenuItem; }
			set {
				if (withEventsField_OrdnerLöschenToolStripMenuItem != null) {
					withEventsField_OrdnerLöschenToolStripMenuItem.Click -= OrdnerLöschenToolStripMenuItem_Click;
				}
				withEventsField_OrdnerLöschenToolStripMenuItem = value;
				if (withEventsField_OrdnerLöschenToolStripMenuItem != null) {
					withEventsField_OrdnerLöschenToolStripMenuItem.Click += OrdnerLöschenToolStripMenuItem_Click;
				}
			}
		}
		private System.Windows.Forms.Timer withEventsField_Timer1;
		internal System.Windows.Forms.Timer Timer1 {
			get { return withEventsField_Timer1; }
			set {
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick -= Timer1_Tick;
				}
				withEventsField_Timer1 = value;
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick += Timer1_Tick;
				}
			}
		}
		private System.Windows.Forms.Timer withEventsField_tmrCheckUpdate;
		internal System.Windows.Forms.Timer tmrCheckUpdate {
			get { return withEventsField_tmrCheckUpdate; }
			set {
				if (withEventsField_tmrCheckUpdate != null) {
					withEventsField_tmrCheckUpdate.Tick -= tmrCheckUpdate_Tick;
				}
				withEventsField_tmrCheckUpdate = value;
				if (withEventsField_tmrCheckUpdate != null) {
					withEventsField_tmrCheckUpdate.Tick += tmrCheckUpdate_Tick;
				}
			}
		}
		internal System.Windows.Forms.ContextMenuStrip cmstripExtras;
		internal System.Windows.Forms.ToolStripMenuItem PoweredByTeamwikiToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AutomatischesUpdateToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ÜberMwFolderSyncToolStripMenuItem;
		private System.Windows.Forms.Button withEventsField_btnClose;
		internal System.Windows.Forms.Button btnClose {
			get { return withEventsField_btnClose; }
			set {
				if (withEventsField_btnClose != null) {
					withEventsField_btnClose.Click -= btnClose_Click;
				}
				withEventsField_btnClose = value;
				if (withEventsField_btnClose != null) {
					withEventsField_btnClose.Click += btnClose_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnMinimize;
		internal System.Windows.Forms.Button btnMinimize {
			get { return withEventsField_btnMinimize; }
			set {
				if (withEventsField_btnMinimize != null) {
					withEventsField_btnMinimize.Click -= btnMinimize_Click;
				}
				withEventsField_btnMinimize = value;
				if (withEventsField_btnMinimize != null) {
					withEventsField_btnMinimize.Click += btnMinimize_Click;
				}
			}
		}
		internal System.Windows.Forms.SplitContainer splHorizontal;
		private TenTec.Windows.iGridLib.iGrid withEventsField_igBatchList;
		internal TenTec.Windows.iGridLib.iGrid igBatchList {
			get { return withEventsField_igBatchList; }
			set {
				if (withEventsField_igBatchList != null) {
					withEventsField_igBatchList.CellMouseUp -= igBatchList_CellMouseUp;
				}
				withEventsField_igBatchList = value;
				if (withEventsField_igBatchList != null) {
					withEventsField_igBatchList.CellMouseUp += igBatchList_CellMouseUp;
				}
			}
		}
		internal TenTec.Windows.iGridLib.iGCellStyle IGrid1DefaultCellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle IGrid1DefaultColHdrStyle;
		internal TenTec.Windows.iGridLib.iGCellStyle IGrid1RowTextColCellStyle;
		private System.Windows.Forms.ListView withEventsField_lvLocalFolder;
		internal System.Windows.Forms.ListView lvLocalFolder {
			get { return withEventsField_lvLocalFolder; }
			set {
				if (withEventsField_lvLocalFolder != null) {
					withEventsField_lvLocalFolder.Resize -= lvLocalFolder_Resize;
					withEventsField_lvLocalFolder.SelectedIndexChanged -= lvLocalFolder_SelectedIndexChanged;
				}
				withEventsField_lvLocalFolder = value;
				if (withEventsField_lvLocalFolder != null) {
					withEventsField_lvLocalFolder.Resize += lvLocalFolder_Resize;
					withEventsField_lvLocalFolder.SelectedIndexChanged += lvLocalFolder_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ImageList imlLocalFolder;
		internal TenTec.Windows.iGridLib.iGCellStyle igBatchListCol1CellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle igBatchListCol1ColHdrStyle;
		internal TenTec.Windows.iGridLib.iGCellStyle igBatchListCol2CellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle igBatchListCol2ColHdrStyle;
		internal TenTec.Windows.iGridLib.iGCellStyle igBatchListCol3CellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle igBatchListCol3ColHdrStyle;
		internal TenTec.Windows.iGridLib.iGCellStyle igBatchListCol5CellStyle;
		internal TenTec.Windows.iGridLib.iGColHdrStyle igBatchListCol5ColHdrStyle;
		private System.Windows.Forms.Button withEventsField_btnProcessJobList;
		internal System.Windows.Forms.Button btnProcessJobList {
			get { return withEventsField_btnProcessJobList; }
			set {
				if (withEventsField_btnProcessJobList != null) {
					withEventsField_btnProcessJobList.Click -= Button1_Click;
				}
				withEventsField_btnProcessJobList = value;
				if (withEventsField_btnProcessJobList != null) {
					withEventsField_btnProcessJobList.Click += Button1_Click;
				}
			}
		}
		internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
		private System.Windows.Forms.LinkLabel withEventsField_lnkShortcutF9;
		internal System.Windows.Forms.LinkLabel lnkShortcutF9 {
			get { return withEventsField_lnkShortcutF9; }
			set {
				if (withEventsField_lnkShortcutF9 != null) {
					withEventsField_lnkShortcutF9.LinkClicked -= lnkShortcut_LinkClicked;
				}
				withEventsField_lnkShortcutF9 = value;
				if (withEventsField_lnkShortcutF9 != null) {
					withEventsField_lnkShortcutF9.LinkClicked += lnkShortcut_LinkClicked;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_lnkShortcutF10;
		internal System.Windows.Forms.LinkLabel lnkShortcutF10 {
			get { return withEventsField_lnkShortcutF10; }
			set {
				if (withEventsField_lnkShortcutF10 != null) {
					withEventsField_lnkShortcutF10.LinkClicked -= lnkShortcut_LinkClicked;
				}
				withEventsField_lnkShortcutF10 = value;
				if (withEventsField_lnkShortcutF10 != null) {
					withEventsField_lnkShortcutF10.LinkClicked += lnkShortcut_LinkClicked;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_lnkShortcutF11;
		internal System.Windows.Forms.LinkLabel lnkShortcutF11 {
			get { return withEventsField_lnkShortcutF11; }
			set {
				if (withEventsField_lnkShortcutF11 != null) {
					withEventsField_lnkShortcutF11.LinkClicked -= lnkShortcut_LinkClicked;
				}
				withEventsField_lnkShortcutF11 = value;
				if (withEventsField_lnkShortcutF11 != null) {
					withEventsField_lnkShortcutF11.LinkClicked += lnkShortcut_LinkClicked;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_lnkShortcutF12;
		internal System.Windows.Forms.LinkLabel lnkShortcutF12 {
			get { return withEventsField_lnkShortcutF12; }
			set {
				if (withEventsField_lnkShortcutF12 != null) {
					withEventsField_lnkShortcutF12.LinkClicked -= lnkShortcut_LinkClicked;
				}
				withEventsField_lnkShortcutF12 = value;
				if (withEventsField_lnkShortcutF12 != null) {
					withEventsField_lnkShortcutF12.LinkClicked += lnkShortcut_LinkClicked;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_txtSearch;
		internal System.Windows.Forms.TextBox txtSearch {
			get { return withEventsField_txtSearch; }
			set {
				if (withEventsField_txtSearch != null) {
					withEventsField_txtSearch.TextChanged -= TextBox1_TextChanged;
				}
				withEventsField_txtSearch = value;
				if (withEventsField_txtSearch != null) {
					withEventsField_txtSearch.TextChanged += TextBox1_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnCancelProcess;
		internal System.Windows.Forms.Button btnCancelProcess {
			get { return withEventsField_btnCancelProcess; }
			set {
				if (withEventsField_btnCancelProcess != null) {
					withEventsField_btnCancelProcess.Click -= btnCancelProcess_Click;
				}
				withEventsField_btnCancelProcess = value;
				if (withEventsField_btnCancelProcess != null) {
					withEventsField_btnCancelProcess.Click += btnCancelProcess_Click;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_lnkClearSuchbox;
		internal System.Windows.Forms.LinkLabel lnkClearSuchbox {
			get { return withEventsField_lnkClearSuchbox; }
			set {
				if (withEventsField_lnkClearSuchbox != null) {
					withEventsField_lnkClearSuchbox.MouseClick -= lnkClearSuchbox_MouseClick;
				}
				withEventsField_lnkClearSuchbox = value;
				if (withEventsField_lnkClearSuchbox != null) {
					withEventsField_lnkClearSuchbox.MouseClick += lnkClearSuchbox_MouseClick;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_lnkAbout;
		internal System.Windows.Forms.LinkLabel lnkAbout {
			get { return withEventsField_lnkAbout; }
			set {
				if (withEventsField_lnkAbout != null) {
					withEventsField_lnkAbout.LinkClicked -= lnkAbout_LinkClicked;
				}
				withEventsField_lnkAbout = value;
				if (withEventsField_lnkAbout != null) {
					withEventsField_lnkAbout.LinkClicked += lnkAbout_LinkClicked;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_lnkUpdate;
		internal System.Windows.Forms.LinkLabel lnkUpdate {
			get { return withEventsField_lnkUpdate; }
			set {
				if (withEventsField_lnkUpdate != null) {
					withEventsField_lnkUpdate.LinkClicked -= lnkUpdate_LinkClicked;
				}
				withEventsField_lnkUpdate = value;
				if (withEventsField_lnkUpdate != null) {
					withEventsField_lnkUpdate.LinkClicked += lnkUpdate_LinkClicked;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_lnkTeamwiki;
		internal System.Windows.Forms.LinkLabel lnkTeamwiki {
			get { return withEventsField_lnkTeamwiki; }
			set {
				if (withEventsField_lnkTeamwiki != null) {
					withEventsField_lnkTeamwiki.LinkClicked -= lnkTeamwiki_LinkClicked;
				}
				withEventsField_lnkTeamwiki = value;
				if (withEventsField_lnkTeamwiki != null) {
					withEventsField_lnkTeamwiki.LinkClicked += lnkTeamwiki_LinkClicked;
				}
			}
		}
		private System.Windows.Forms.CheckBox withEventsField_checkCreateBackup;
		internal System.Windows.Forms.CheckBox checkCreateBackup {
			get { return withEventsField_checkCreateBackup; }
			set {
				if (withEventsField_checkCreateBackup != null) {
					withEventsField_checkCreateBackup.CheckedChanged -= checkCreateBackup_CheckedChanged;
				}
				withEventsField_checkCreateBackup = value;
				if (withEventsField_checkCreateBackup != null) {
					withEventsField_checkCreateBackup.CheckedChanged += checkCreateBackup_CheckedChanged;
				}
			}
		}
		internal System.Windows.Forms.SplitContainer splServer;
		private System.Windows.Forms.ComboBox withEventsField_txtServerFolder;
		internal System.Windows.Forms.ComboBox txtServerFolder {
			get { return withEventsField_txtServerFolder; }
			set {
				if (withEventsField_txtServerFolder != null) {
					withEventsField_txtServerFolder.MouseUp -= txtServerFolder_MouseUp;
					withEventsField_txtServerFolder.TextChanged -= txtServerFolder_TextChanged;
				}
				withEventsField_txtServerFolder = value;
				if (withEventsField_txtServerFolder != null) {
					withEventsField_txtServerFolder.MouseUp += txtServerFolder_MouseUp;
					withEventsField_txtServerFolder.TextChanged += txtServerFolder_TextChanged;
				}
			}
		}
		private System.Windows.Forms.ListView withEventsField_lvServerFile;
		internal System.Windows.Forms.ListView lvServerFile {
			get { return withEventsField_lvServerFile; }
			set {
				if (withEventsField_lvServerFile != null) {
					withEventsField_lvServerFile.Resize -= lvServerFile_Resize;
					withEventsField_lvServerFile.SelectedIndexChanged -= lvServerFile_SelectedIndexChanged;
				}
				withEventsField_lvServerFile = value;
				if (withEventsField_lvServerFile != null) {
					withEventsField_lvServerFile.Resize += lvServerFile_Resize;
					withEventsField_lvServerFile.SelectedIndexChanged += lvServerFile_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		private System.Windows.Forms.Button withEventsField_btnServerList_showAll;
		internal System.Windows.Forms.Button btnServerList_showAll {
			get { return withEventsField_btnServerList_showAll; }
			set {
				if (withEventsField_btnServerList_showAll != null) {
					withEventsField_btnServerList_showAll.Click -= btnServerList_showAll_Click;
				}
				withEventsField_btnServerList_showAll = value;
				if (withEventsField_btnServerList_showAll != null) {
					withEventsField_btnServerList_showAll.Click += btnServerList_showAll_Click;
				}
			}
		}
		internal System.Windows.Forms.TextBox txtServerFile;
		internal System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Button withEventsField_btnRefreshServerFileList;
		internal System.Windows.Forms.Button btnRefreshServerFileList {
			get { return withEventsField_btnRefreshServerFileList; }
			set {
				if (withEventsField_btnRefreshServerFileList != null) {
					withEventsField_btnRefreshServerFileList.Click -= btnRefreshServerFileList_Click;
				}
				withEventsField_btnRefreshServerFileList = value;
				if (withEventsField_btnRefreshServerFileList != null) {
					withEventsField_btnRefreshServerFileList.Click += btnRefreshServerFileList_Click;
				}
			}
		}
		internal System.Windows.Forms.SplitContainer splMainVert;
		private System.Windows.Forms.PictureBox withEventsField_PictureBox2;
		internal System.Windows.Forms.PictureBox PictureBox2 {
			get { return withEventsField_PictureBox2; }
			set {
				if (withEventsField_PictureBox2 != null) {
					withEventsField_PictureBox2.Click -= PictureBox2_Click;
				}
				withEventsField_PictureBox2 = value;
				if (withEventsField_PictureBox2 != null) {
					withEventsField_PictureBox2.Click += PictureBox2_Click;
				}
			}
		}
		internal System.Windows.Forms.PictureBox PictureBox3;
		private System.Windows.Forms.TextBox withEventsField_txtDiz;
		internal System.Windows.Forms.TextBox txtDiz {
			get { return withEventsField_txtDiz; }
			set {
				if (withEventsField_txtDiz != null) {
					withEventsField_txtDiz.TextChanged -= txtDiz_TextChanged;
				}
				withEventsField_txtDiz = value;
				if (withEventsField_txtDiz != null) {
					withEventsField_txtDiz.TextChanged += txtDiz_TextChanged;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnDelJob;
		internal System.Windows.Forms.Button btnDelJob {
			get { return withEventsField_btnDelJob; }
			set {
				if (withEventsField_btnDelJob != null) {
					withEventsField_btnDelJob.Click -= btnDelJob_Click;
				}
				withEventsField_btnDelJob = value;
				if (withEventsField_btnDelJob != null) {
					withEventsField_btnDelJob.Click += btnDelJob_Click;
				}
			}
		}
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		private System.Windows.Forms.Button withEventsField_btnSettings;
		internal System.Windows.Forms.Button btnSettings {
			get { return withEventsField_btnSettings; }
			set {
				if (withEventsField_btnSettings != null) {
					withEventsField_btnSettings.Click -= btnSettings_Click;
				}
				withEventsField_btnSettings = value;
				if (withEventsField_btnSettings != null) {
					withEventsField_btnSettings.Click += btnSettings_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnNewestUploads;
		internal System.Windows.Forms.Button btnNewestUploads {
			get { return withEventsField_btnNewestUploads; }
			set {
				if (withEventsField_btnNewestUploads != null) {
					withEventsField_btnNewestUploads.Click -= btnNewestUploads_Click;
				}
				withEventsField_btnNewestUploads = value;
				if (withEventsField_btnNewestUploads != null) {
					withEventsField_btnNewestUploads.Click += btnNewestUploads_Click;
				}
			}

		}
	}
}
