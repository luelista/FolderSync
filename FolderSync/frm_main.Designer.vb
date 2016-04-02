<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
    Dim IGColPattern17 As TenTec.Windows.iGridLib.iGColPattern = New TenTec.Windows.iGridLib.iGColPattern()
    Dim IGColPattern18 As TenTec.Windows.iGridLib.iGColPattern = New TenTec.Windows.iGridLib.iGColPattern()
    Dim IGColPattern19 As TenTec.Windows.iGridLib.iGColPattern = New TenTec.Windows.iGridLib.iGColPattern()
    Dim IGColPattern20 As TenTec.Windows.iGridLib.iGColPattern = New TenTec.Windows.iGridLib.iGColPattern()
    Me.igBatchListCol1CellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.igBatchListCol1ColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.igBatchListCol2CellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.igBatchListCol2ColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.igBatchListCol3CellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.igBatchListCol3ColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.igBatchListCol5CellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.igBatchListCol5ColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.checkTopmost = New System.Windows.Forms.CheckBox()
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.lnkShortcutF9 = New System.Windows.Forms.LinkLabel()
    Me.lnkShortcutF10 = New System.Windows.Forms.LinkLabel()
    Me.lnkShortcutF11 = New System.Windows.Forms.LinkLabel()
    Me.lnkShortcutF12 = New System.Windows.Forms.LinkLabel()
    Me.splLocal = New System.Windows.Forms.SplitContainer()
    Me.ftvLocalUpload_Folder = New AxCCRPFolderTV6.AxFolderTreeview()
    Me.lvLocalFolder = New System.Windows.Forms.ListView()
    Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.imlLocalFolder = New System.Windows.Forms.ImageList(Me.components)
    Me.txtLocalFolder = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cmstripServerTreeview = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.DateilisteAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.UmbennenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OrdnerLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.imlTreeView = New System.Windows.Forms.ImageList(Me.components)
    Me.btnDownload = New System.Windows.Forms.Button()
    Me.btnUpload = New System.Windows.Forms.Button()
    Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
    Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
    Me.labState = New System.Windows.Forms.Label()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnMinimize = New System.Windows.Forms.Button()
    Me.tmrCheckUpdate = New System.Windows.Forms.Timer(Me.components)
    Me.cmstripExtras = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.ÜberMwFolderSyncToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.PoweredByTeamwikiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AutomatischesUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.splHorizontal = New System.Windows.Forms.SplitContainer()
    Me.splMainVert = New System.Windows.Forms.SplitContainer()
    Me.txtDiz = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtServerFile = New System.Windows.Forms.TextBox()
    Me.splServer = New System.Windows.Forms.SplitContainer()
    Me.txtServerFolder = New System.Windows.Forms.ComboBox()
    Me.btnServerList_showAll = New System.Windows.Forms.Button()
    Me.lvServerFile = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.lnkClearSuchbox = New System.Windows.Forms.LinkLabel()
    Me.txtSearch = New System.Windows.Forms.TextBox()
    Me.btnDelJob = New System.Windows.Forms.Button()
    Me.igBatchList = New TenTec.Windows.iGridLib.iGrid()
    Me.IGrid1DefaultCellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.IGrid1DefaultColHdrStyle = New TenTec.Windows.iGridLib.iGColHdrStyle(True)
    Me.IGrid1RowTextColCellStyle = New TenTec.Windows.iGridLib.iGCellStyle(True)
    Me.btnProcessJobList = New System.Windows.Forms.Button()
    Me.btnCancelProcess = New System.Windows.Forms.Button()
    Me.btnSettings = New System.Windows.Forms.Button()
    Me.btnRefreshServerFileList = New System.Windows.Forms.Button()
    Me.PictureBox2 = New System.Windows.Forms.PictureBox()
    Me.PictureBox3 = New System.Windows.Forms.PictureBox()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.btnAboutbox = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.FlowLayoutPanel1.SuspendLayout()
    Me.splLocal.Panel1.SuspendLayout()
    Me.splLocal.Panel2.SuspendLayout()
    Me.splLocal.SuspendLayout()
    CType(Me.ftvLocalUpload_Folder, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.cmstripServerTreeview.SuspendLayout()
    Me.cmstripExtras.SuspendLayout()
    Me.splHorizontal.Panel1.SuspendLayout()
    Me.splHorizontal.Panel2.SuspendLayout()
    Me.splHorizontal.SuspendLayout()
    Me.splMainVert.Panel1.SuspendLayout()
    Me.splMainVert.Panel2.SuspendLayout()
    Me.splMainVert.SuspendLayout()
    Me.splServer.Panel1.SuspendLayout()
    Me.splServer.Panel2.SuspendLayout()
    Me.splServer.SuspendLayout()
    CType(Me.igBatchList, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'igBatchListCol1CellStyle
    '
    Me.igBatchListCol1CellStyle.ReadOnly = TenTec.Windows.iGridLib.iGBool.[True]
    '
    'igBatchListCol2CellStyle
    '
    Me.igBatchListCol2CellStyle.ReadOnly = TenTec.Windows.iGridLib.iGBool.[True]
    '
    'igBatchListCol3CellStyle
    '
    Me.igBatchListCol3CellStyle.ReadOnly = TenTec.Windows.iGridLib.iGBool.[True]
    '
    'igBatchListCol5CellStyle
    '
    Me.igBatchListCol5CellStyle.ReadOnly = TenTec.Windows.iGridLib.iGBool.[True]
    '
    'PictureBox1
    '
    Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PictureBox1.BackColor = System.Drawing.Color.White
    Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
    Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
    Me.PictureBox1.Location = New System.Drawing.Point(-87, -37)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Padding = New System.Windows.Forms.Padding(88, 0, 0, 0)
    Me.PictureBox1.Size = New System.Drawing.Size(125, 12)
    Me.PictureBox1.TabIndex = 1
    Me.PictureBox1.TabStop = False
    '
    'checkTopmost
    '
    Me.checkTopmost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.checkTopmost.AutoSize = True
    Me.checkTopmost.BackColor = System.Drawing.Color.Transparent
    Me.checkTopmost.Cursor = System.Windows.Forms.Cursors.Hand
    Me.checkTopmost.ForeColor = System.Drawing.Color.Black
    Me.checkTopmost.Location = New System.Drawing.Point(-66, 0)
    Me.checkTopmost.Name = "checkTopmost"
    Me.checkTopmost.Size = New System.Drawing.Size(41, 17)
    Me.checkTopmost.TabIndex = 6
    Me.checkTopmost.Text = "top"
    Me.checkTopmost.UseVisualStyleBackColor = False
    Me.checkTopmost.Visible = False
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.FlowLayoutPanel1.Controls.Add(Me.lnkShortcutF9)
    Me.FlowLayoutPanel1.Controls.Add(Me.lnkShortcutF10)
    Me.FlowLayoutPanel1.Controls.Add(Me.lnkShortcutF11)
    Me.FlowLayoutPanel1.Controls.Add(Me.lnkShortcutF12)
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 403)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(287, 23)
    Me.FlowLayoutPanel1.TabIndex = 8
    '
    'lnkShortcutF9
    '
    Me.lnkShortcutF9.AutoSize = True
    Me.lnkShortcutF9.Location = New System.Drawing.Point(3, 0)
    Me.lnkShortcutF9.Name = "lnkShortcutF9"
    Me.lnkShortcutF9.Size = New System.Drawing.Size(59, 13)
    Me.lnkShortcutF9.TabIndex = 0
    Me.lnkShortcutF9.TabStop = True
    Me.lnkShortcutF9.Tag = "1"
    Me.lnkShortcutF9.Text = "LinkLabel1"
    '
    'lnkShortcutF10
    '
    Me.lnkShortcutF10.AutoSize = True
    Me.lnkShortcutF10.Location = New System.Drawing.Point(68, 0)
    Me.lnkShortcutF10.Name = "lnkShortcutF10"
    Me.lnkShortcutF10.Size = New System.Drawing.Size(59, 13)
    Me.lnkShortcutF10.TabIndex = 1
    Me.lnkShortcutF10.TabStop = True
    Me.lnkShortcutF10.Tag = "2"
    Me.lnkShortcutF10.Text = "LinkLabel2"
    '
    'lnkShortcutF11
    '
    Me.lnkShortcutF11.AutoSize = True
    Me.lnkShortcutF11.Location = New System.Drawing.Point(133, 0)
    Me.lnkShortcutF11.Name = "lnkShortcutF11"
    Me.lnkShortcutF11.Size = New System.Drawing.Size(59, 13)
    Me.lnkShortcutF11.TabIndex = 2
    Me.lnkShortcutF11.TabStop = True
    Me.lnkShortcutF11.Tag = "3"
    Me.lnkShortcutF11.Text = "LinkLabel3"
    '
    'lnkShortcutF12
    '
    Me.lnkShortcutF12.AutoSize = True
    Me.lnkShortcutF12.Location = New System.Drawing.Point(198, 0)
    Me.lnkShortcutF12.Name = "lnkShortcutF12"
    Me.lnkShortcutF12.Size = New System.Drawing.Size(59, 13)
    Me.lnkShortcutF12.TabIndex = 3
    Me.lnkShortcutF12.TabStop = True
    Me.lnkShortcutF12.Tag = "4"
    Me.lnkShortcutF12.Text = "LinkLabel4"
    '
    'splLocal
    '
    Me.splLocal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.splLocal.Location = New System.Drawing.Point(10, 46)
    Me.splLocal.Name = "splLocal"
    Me.splLocal.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'splLocal.Panel1
    '
    Me.splLocal.Panel1.Controls.Add(Me.ftvLocalUpload_Folder)
    '
    'splLocal.Panel2
    '
    Me.splLocal.Panel2.Controls.Add(Me.lvLocalFolder)
    Me.splLocal.Size = New System.Drawing.Size(281, 355)
    Me.splLocal.SplitterDistance = 146
    Me.splLocal.TabIndex = 7
    '
    'ftvLocalUpload_Folder
    '
    Me.ftvLocalUpload_Folder.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ftvLocalUpload_Folder.Location = New System.Drawing.Point(0, 0)
    Me.ftvLocalUpload_Folder.Name = "ftvLocalUpload_Folder"
    Me.ftvLocalUpload_Folder.OcxState = CType(resources.GetObject("ftvLocalUpload_Folder.OcxState"), System.Windows.Forms.AxHost.State)
    Me.ftvLocalUpload_Folder.Size = New System.Drawing.Size(281, 146)
    Me.ftvLocalUpload_Folder.TabIndex = 1
    '
    'lvLocalFolder
    '
    Me.lvLocalFolder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5})
    Me.lvLocalFolder.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvLocalFolder.FullRowSelect = True
    Me.lvLocalFolder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    Me.lvLocalFolder.HideSelection = False
    Me.lvLocalFolder.Location = New System.Drawing.Point(0, 0)
    Me.lvLocalFolder.MultiSelect = False
    Me.lvLocalFolder.Name = "lvLocalFolder"
    Me.lvLocalFolder.Size = New System.Drawing.Size(281, 205)
    Me.lvLocalFolder.SmallImageList = Me.imlLocalFolder
    Me.lvLocalFolder.TabIndex = 0
    Me.lvLocalFolder.UseCompatibleStateImageBehavior = False
    Me.lvLocalFolder.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader5
    '
    Me.ColumnHeader5.Width = 269
    '
    'imlLocalFolder
    '
    Me.imlLocalFolder.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.imlLocalFolder.ImageSize = New System.Drawing.Size(16, 16)
    Me.imlLocalFolder.TransparentColor = System.Drawing.Color.Transparent
    '
    'txtLocalFolder
    '
    Me.txtLocalFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtLocalFolder.Location = New System.Drawing.Point(10, 22)
    Me.txtLocalFolder.Name = "txtLocalFolder"
    Me.txtLocalFolder.Size = New System.Drawing.Size(253, 20)
    Me.txtLocalFolder.TabIndex = 6
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(6, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(42, 15)
    Me.Label4.TabIndex = 5
    Me.Label4.Text = "Lokal"
    '
    'Label6
    '
    Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
    Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
    Me.Label6.Location = New System.Drawing.Point(268, 23)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(17, 17)
    Me.Label6.TabIndex = 8
    '
    'cmstripServerTreeview
    '
    Me.cmstripServerTreeview.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateilisteAnzeigenToolStripMenuItem, Me.UmbennenToolStripMenuItem, Me.OrdnerLöschenToolStripMenuItem})
    Me.cmstripServerTreeview.Name = "cmstripServerTreeview"
    Me.cmstripServerTreeview.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.cmstripServerTreeview.Size = New System.Drawing.Size(173, 70)
    '
    'DateilisteAnzeigenToolStripMenuItem
    '
    Me.DateilisteAnzeigenToolStripMenuItem.Name = "DateilisteAnzeigenToolStripMenuItem"
    Me.DateilisteAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
    Me.DateilisteAnzeigenToolStripMenuItem.Text = "Dateiliste anzeigen"
    '
    'UmbennenToolStripMenuItem
    '
    Me.UmbennenToolStripMenuItem.Name = "UmbennenToolStripMenuItem"
    Me.UmbennenToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
    Me.UmbennenToolStripMenuItem.Text = "Umbennen"
    '
    'OrdnerLöschenToolStripMenuItem
    '
    Me.OrdnerLöschenToolStripMenuItem.Name = "OrdnerLöschenToolStripMenuItem"
    Me.OrdnerLöschenToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
    Me.OrdnerLöschenToolStripMenuItem.Text = "Ordner löschen"
    '
    'imlTreeView
    '
    Me.imlTreeView.ImageStream = CType(resources.GetObject("imlTreeView.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imlTreeView.TransparentColor = System.Drawing.Color.Transparent
    Me.imlTreeView.Images.SetKeyName(0, "fld")
    Me.imlTreeView.Images.SetKeyName(1, "zip")
    Me.imlTreeView.Images.SetKeyName(2, "wmploc_602.png")
    Me.imlTreeView.Images.SetKeyName(3, "benutzer1.png")
    '
    'btnDownload
    '
    Me.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDownload.ForeColor = System.Drawing.Color.Black
    Me.btnDownload.Image = CType(resources.GetObject("btnDownload.Image"), System.Drawing.Image)
    Me.btnDownload.Location = New System.Drawing.Point(223, 4)
    Me.btnDownload.Name = "btnDownload"
    Me.btnDownload.Size = New System.Drawing.Size(105, 30)
    Me.btnDownload.TabIndex = 2
    Me.btnDownload.Text = "download"
    Me.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnDownload.UseVisualStyleBackColor = True
    '
    'btnUpload
    '
    Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnUpload.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnUpload.Image = CType(resources.GetObject("btnUpload.Image"), System.Drawing.Image)
    Me.btnUpload.Location = New System.Drawing.Point(334, 4)
    Me.btnUpload.Name = "btnUpload"
    Me.btnUpload.Size = New System.Drawing.Size(87, 30)
    Me.btnUpload.TabIndex = 1
    Me.btnUpload.Text = "upload"
    Me.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
    Me.btnUpload.UseVisualStyleBackColor = True
    '
    'ProgressBar1
    '
    Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ProgressBar1.Location = New System.Drawing.Point(127, 99)
    Me.ProgressBar1.Maximum = 222
    Me.ProgressBar1.Name = "ProgressBar1"
    Me.ProgressBar1.Size = New System.Drawing.Size(767, 22)
    Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
    Me.ProgressBar1.TabIndex = 17
    Me.ProgressBar1.Visible = False
    '
    'WebBrowser1
    '
    Me.WebBrowser1.Location = New System.Drawing.Point(-333, 461)
    Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
    Me.WebBrowser1.Name = "WebBrowser1"
    Me.WebBrowser1.Size = New System.Drawing.Size(220, 107)
    Me.WebBrowser1.TabIndex = 18
    Me.WebBrowser1.Visible = False
    '
    'labState
    '
    Me.labState.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.labState.AutoSize = True
    Me.labState.Location = New System.Drawing.Point(269, 99)
    Me.labState.Name = "labState"
    Me.labState.Size = New System.Drawing.Size(37, 13)
    Me.labState.TabIndex = 19
    Me.labState.Text = "Bereit."
    '
    'Timer1
    '
    Me.Timer1.Interval = 88
    '
    'btnClose
    '
    Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnClose.ForeColor = System.Drawing.Color.Red
    Me.btnClose.Location = New System.Drawing.Point(869, -35)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(36, 24)
    Me.btnClose.TabIndex = 31
    Me.btnClose.Text = "X"
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'btnMinimize
    '
    Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnMinimize.Location = New System.Drawing.Point(841, -35)
    Me.btnMinimize.Name = "btnMinimize"
    Me.btnMinimize.Size = New System.Drawing.Size(26, 24)
    Me.btnMinimize.TabIndex = 30
    Me.btnMinimize.Text = "_"
    Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.btnMinimize.UseVisualStyleBackColor = True
    '
    'tmrCheckUpdate
    '
    Me.tmrCheckUpdate.Interval = 10000
    '
    'cmstripExtras
    '
    Me.cmstripExtras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜberMwFolderSyncToolStripMenuItem, Me.PoweredByTeamwikiToolStripMenuItem, Me.AutomatischesUpdateToolStripMenuItem})
    Me.cmstripExtras.Name = "cmstripExtras"
    Me.cmstripExtras.Size = New System.Drawing.Size(209, 70)
    '
    'ÜberMwFolderSyncToolStripMenuItem
    '
    Me.ÜberMwFolderSyncToolStripMenuItem.Image = CType(resources.GetObject("ÜberMwFolderSyncToolStripMenuItem.Image"), System.Drawing.Image)
    Me.ÜberMwFolderSyncToolStripMenuItem.Name = "ÜberMwFolderSyncToolStripMenuItem"
    Me.ÜberMwFolderSyncToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
    Me.ÜberMwFolderSyncToolStripMenuItem.Text = "Über mwFolderSync ..."
    '
    'PoweredByTeamwikiToolStripMenuItem
    '
    Me.PoweredByTeamwikiToolStripMenuItem.Image = CType(resources.GetObject("PoweredByTeamwikiToolStripMenuItem.Image"), System.Drawing.Image)
    Me.PoweredByTeamwikiToolStripMenuItem.Name = "PoweredByTeamwikiToolStripMenuItem"
    Me.PoweredByTeamwikiToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
    Me.PoweredByTeamwikiToolStripMenuItem.Text = "powered by: Teamwiki.de"
    '
    'AutomatischesUpdateToolStripMenuItem
    '
    Me.AutomatischesUpdateToolStripMenuItem.Name = "AutomatischesUpdateToolStripMenuItem"
    Me.AutomatischesUpdateToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
    Me.AutomatischesUpdateToolStripMenuItem.Text = "Automatisches Update"
    '
    'splHorizontal
    '
    Me.splHorizontal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.splHorizontal.Dock = System.Windows.Forms.DockStyle.Fill
    Me.splHorizontal.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
    Me.splHorizontal.Location = New System.Drawing.Point(0, 39)
    Me.splHorizontal.Name = "splHorizontal"
    Me.splHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'splHorizontal.Panel1
    '
    Me.splHorizontal.Panel1.Controls.Add(Me.splMainVert)
    '
    'splHorizontal.Panel2
    '
    Me.splHorizontal.Panel2.Controls.Add(Me.btnDelJob)
    Me.splHorizontal.Panel2.Controls.Add(Me.igBatchList)
    Me.splHorizontal.Panel2.Controls.Add(Me.ProgressBar1)
    Me.splHorizontal.Panel2.Controls.Add(Me.labState)
    Me.splHorizontal.Panel2.Controls.Add(Me.btnProcessJobList)
    Me.splHorizontal.Panel2.Controls.Add(Me.btnCancelProcess)
    Me.splHorizontal.Size = New System.Drawing.Size(910, 567)
    Me.splHorizontal.SplitterDistance = 426
    Me.splHorizontal.SplitterWidth = 10
    Me.splHorizontal.TabIndex = 29
    '
    'splMainVert
    '
    Me.splMainVert.Dock = System.Windows.Forms.DockStyle.Fill
    Me.splMainVert.Location = New System.Drawing.Point(0, 0)
    Me.splMainVert.Name = "splMainVert"
    '
    'splMainVert.Panel1
    '
    Me.splMainVert.Panel1.Controls.Add(Me.FlowLayoutPanel1)
    Me.splMainVert.Panel1.Controls.Add(Me.Label4)
    Me.splMainVert.Panel1.Controls.Add(Me.splLocal)
    Me.splMainVert.Panel1.Controls.Add(Me.txtLocalFolder)
    Me.splMainVert.Panel1.Controls.Add(Me.Label6)
    '
    'splMainVert.Panel2
    '
    Me.splMainVert.Panel2.Controls.Add(Me.Label1)
    Me.splMainVert.Panel2.Controls.Add(Me.Label2)
    Me.splMainVert.Panel2.Controls.Add(Me.txtServerFile)
    Me.splMainVert.Panel2.Controls.Add(Me.splServer)
    Me.splMainVert.Panel2.Controls.Add(Me.lnkClearSuchbox)
    Me.splMainVert.Panel2.Controls.Add(Me.txtSearch)
    Me.splMainVert.Size = New System.Drawing.Size(910, 426)
    Me.splMainVert.SplitterDistance = 291
    Me.splMainVert.SplitterWidth = 7
    Me.splMainVert.TabIndex = 14
    '
    'txtDiz
    '
    Me.txtDiz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtDiz.Location = New System.Drawing.Point(527, 10)
    Me.txtDiz.Name = "txtDiz"
    Me.txtDiz.Size = New System.Drawing.Size(82, 20)
    Me.txtDiz.TabIndex = 39
    Me.txtDiz.Text = "DIZ"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(-1, 25)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(35, 13)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "Name"
    '
    'txtServerFile
    '
    Me.txtServerFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtServerFile.Location = New System.Drawing.Point(39, 22)
    Me.txtServerFile.Name = "txtServerFile"
    Me.txtServerFile.ReadOnly = True
    Me.txtServerFile.Size = New System.Drawing.Size(349, 20)
    Me.txtServerFile.TabIndex = 7
    '
    'splServer
    '
    Me.splServer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.splServer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
    Me.splServer.Location = New System.Drawing.Point(1, 46)
    Me.splServer.Name = "splServer"
    '
    'splServer.Panel1
    '
    Me.splServer.Panel1.Controls.Add(Me.txtServerFolder)
    Me.splServer.Panel1.Controls.Add(Me.btnServerList_showAll)
    '
    'splServer.Panel2
    '
    Me.splServer.Panel2.Controls.Add(Me.lvServerFile)
    Me.splServer.Size = New System.Drawing.Size(607, 380)
    Me.splServer.SplitterDistance = 120
    Me.splServer.TabIndex = 11
    '
    'txtServerFolder
    '
    Me.txtServerFolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtServerFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
    Me.txtServerFolder.FormattingEnabled = True
    Me.txtServerFolder.IntegralHeight = False
    Me.txtServerFolder.Location = New System.Drawing.Point(0, 0)
    Me.txtServerFolder.Name = "txtServerFolder"
    Me.txtServerFolder.Size = New System.Drawing.Size(120, 353)
    Me.txtServerFolder.TabIndex = 8
    '
    'btnServerList_showAll
    '
    Me.btnServerList_showAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnServerList_showAll.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnServerList_showAll.Location = New System.Drawing.Point(0, 355)
    Me.btnServerList_showAll.Name = "btnServerList_showAll"
    Me.btnServerList_showAll.Size = New System.Drawing.Size(119, 25)
    Me.btnServerList_showAll.TabIndex = 10
    Me.btnServerList_showAll.Text = "Alle anzeigen"
    Me.btnServerList_showAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnServerList_showAll.UseVisualStyleBackColor = True
    '
    'lvServerFile
    '
    Me.lvServerFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader4})
    Me.lvServerFile.ContextMenuStrip = Me.cmstripServerTreeview
    Me.lvServerFile.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvServerFile.FullRowSelect = True
    Me.lvServerFile.HideSelection = False
    Me.lvServerFile.Location = New System.Drawing.Point(0, 0)
    Me.lvServerFile.MultiSelect = False
    Me.lvServerFile.Name = "lvServerFile"
    Me.lvServerFile.ShowItemToolTips = True
    Me.lvServerFile.Size = New System.Drawing.Size(483, 380)
    Me.lvServerFile.SmallImageList = Me.imlTreeView
    Me.lvServerFile.TabIndex = 9
    Me.lvServerFile.UseCompatibleStateImageBehavior = False
    Me.lvServerFile.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.DisplayIndex = 1
    Me.ColumnHeader1.Text = "Dateiname"
    Me.ColumnHeader1.Width = 127
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.DisplayIndex = 0
    Me.ColumnHeader2.Text = "Pfad"
    Me.ColumnHeader2.Width = 0
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Datum"
    Me.ColumnHeader3.Width = 111
    '
    'ColumnHeader6
    '
    Me.ColumnHeader6.Text = "DIZ"
    Me.ColumnHeader6.Width = 59
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Größe"
    Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.ColumnHeader4.Width = 62
    '
    'lnkClearSuchbox
    '
    Me.lnkClearSuchbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lnkClearSuchbox.AutoSize = True
    Me.lnkClearSuchbox.BackColor = System.Drawing.Color.White
    Me.lnkClearSuchbox.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lnkClearSuchbox.Image = CType(resources.GetObject("lnkClearSuchbox.Image"), System.Drawing.Image)
    Me.lnkClearSuchbox.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
    Me.lnkClearSuchbox.Location = New System.Drawing.Point(586, 26)
    Me.lnkClearSuchbox.Name = "lnkClearSuchbox"
    Me.lnkClearSuchbox.Size = New System.Drawing.Size(16, 13)
    Me.lnkClearSuchbox.TabIndex = 32
    Me.lnkClearSuchbox.TabStop = True
    Me.lnkClearSuchbox.Text = "   "
    '
    'txtSearch
    '
    Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtSearch.Location = New System.Drawing.Point(394, 22)
    Me.txtSearch.Name = "txtSearch"
    Me.txtSearch.Size = New System.Drawing.Size(214, 20)
    Me.txtSearch.TabIndex = 31
    '
    'btnDelJob
    '
    Me.btnDelJob.Location = New System.Drawing.Point(9, 103)
    Me.btnDelJob.Name = "btnDelJob"
    Me.btnDelJob.Size = New System.Drawing.Size(87, 23)
    Me.btnDelJob.TabIndex = 21
    Me.btnDelJob.Text = "entfernen"
    Me.btnDelJob.UseVisualStyleBackColor = True
    '
    'igBatchList
    '
    Me.igBatchList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.igBatchList.AutoResizeCols = True
    IGColPattern17.CellStyle = Me.igBatchListCol1CellStyle
    IGColPattern17.ColHdrStyle = Me.igBatchListCol1ColHdrStyle
    IGColPattern17.Key = "locfolder"
    IGColPattern17.Text = "Lokaler Ordner"
    IGColPattern17.Width = 316
    IGColPattern18.CellStyle = Me.igBatchListCol2CellStyle
    IGColPattern18.ColHdrStyle = Me.igBatchListCol2ColHdrStyle
    IGColPattern18.Key = "direction"
    IGColPattern18.Text = "<-->"
    IGColPattern18.Width = 58
    IGColPattern19.CellStyle = Me.igBatchListCol3CellStyle
    IGColPattern19.ColHdrStyle = Me.igBatchListCol3ColHdrStyle
    IGColPattern19.Key = "servername"
    IGColPattern19.Text = "Archivname auf Server"
    IGColPattern19.Width = 317
    IGColPattern20.CellStyle = Me.igBatchListCol5CellStyle
    IGColPattern20.ColHdrStyle = Me.igBatchListCol5ColHdrStyle
    IGColPattern20.Key = "progress"
    IGColPattern20.Text = "Fortschritt"
    IGColPattern20.Width = 110
    Me.igBatchList.Cols.AddRange(New TenTec.Windows.iGridLib.iGColPattern() {IGColPattern17, IGColPattern18, IGColPattern19, IGColPattern20})
    Me.igBatchList.DefaultCol.CellStyle = Me.IGrid1DefaultCellStyle
    Me.igBatchList.DefaultCol.ColHdrStyle = Me.IGrid1DefaultColHdrStyle
    Me.igBatchList.Header.AllowPress = False
    Me.igBatchList.Header.Height = 19
    Me.igBatchList.Location = New System.Drawing.Point(99, 1)
    Me.igBatchList.Name = "igBatchList"
    Me.igBatchList.RowTextCol.CellStyle = Me.IGrid1RowTextColCellStyle
    Me.igBatchList.Size = New System.Drawing.Size(805, 127)
    Me.igBatchList.TabIndex = 20
    '
    'btnProcessJobList
    '
    Me.btnProcessJobList.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnProcessJobList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnProcessJobList.ForeColor = System.Drawing.Color.Black
    Me.btnProcessJobList.Image = CType(resources.GetObject("btnProcessJobList.Image"), System.Drawing.Image)
    Me.btnProcessJobList.Location = New System.Drawing.Point(9, 0)
    Me.btnProcessJobList.Name = "btnProcessJobList"
    Me.btnProcessJobList.Size = New System.Drawing.Size(87, 76)
    Me.btnProcessJobList.TabIndex = 10
    Me.btnProcessJobList.Text = "Start"
    Me.btnProcessJobList.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.btnProcessJobList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.btnProcessJobList.UseVisualStyleBackColor = True
    '
    'btnCancelProcess
    '
    Me.btnCancelProcess.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnCancelProcess.Enabled = False
    Me.btnCancelProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelProcess.ForeColor = System.Drawing.Color.Black
    Me.btnCancelProcess.Image = CType(resources.GetObject("btnCancelProcess.Image"), System.Drawing.Image)
    Me.btnCancelProcess.ImageAlign = System.Drawing.ContentAlignment.BottomRight
    Me.btnCancelProcess.Location = New System.Drawing.Point(9, 77)
    Me.btnCancelProcess.Name = "btnCancelProcess"
    Me.btnCancelProcess.Size = New System.Drawing.Size(87, 25)
    Me.btnCancelProcess.TabIndex = 11
    Me.btnCancelProcess.Text = "Stopp"
    Me.btnCancelProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnCancelProcess.UseVisualStyleBackColor = True
    Me.btnCancelProcess.Visible = False
    '
    'btnSettings
    '
    Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSettings.Location = New System.Drawing.Point(754, 4)
    Me.btnSettings.Name = "btnSettings"
    Me.btnSettings.Size = New System.Drawing.Size(82, 30)
    Me.btnSettings.TabIndex = 41
    Me.btnSettings.Text = "Einstellungen"
    Me.btnSettings.UseVisualStyleBackColor = True
    '
    'btnRefreshServerFileList
    '
    Me.btnRefreshServerFileList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRefreshServerFileList.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnRefreshServerFileList.Image = CType(resources.GetObject("btnRefreshServerFileList.Image"), System.Drawing.Image)
    Me.btnRefreshServerFileList.Location = New System.Drawing.Point(615, 4)
    Me.btnRefreshServerFileList.Name = "btnRefreshServerFileList"
    Me.btnRefreshServerFileList.Size = New System.Drawing.Size(133, 30)
    Me.btnRefreshServerFileList.TabIndex = 3
    Me.btnRefreshServerFileList.Text = "Liste aktualisieren"
    Me.btnRefreshServerFileList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnRefreshServerFileList.UseVisualStyleBackColor = True
    '
    'PictureBox2
    '
    Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
    Me.PictureBox2.Location = New System.Drawing.Point(54, -37)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(135, 92)
    Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBox2.TabIndex = 37
    Me.PictureBox2.TabStop = False
    '
    'PictureBox3
    '
    Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
    Me.PictureBox3.Location = New System.Drawing.Point(4, 2)
    Me.PictureBox3.Name = "PictureBox3"
    Me.PictureBox3.Size = New System.Drawing.Size(41, 37)
    Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBox3.TabIndex = 38
    Me.PictureBox3.TabStop = False
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
    Me.Panel1.Controls.Add(Me.txtDiz)
    Me.Panel1.Controls.Add(Me.btnSettings)
    Me.Panel1.Controls.Add(Me.btnRefreshServerFileList)
    Me.Panel1.Controls.Add(Me.PictureBox3)
    Me.Panel1.Controls.Add(Me.btnDownload)
    Me.Panel1.Controls.Add(Me.btnUpload)
    Me.Panel1.Controls.Add(Me.PictureBox2)
    Me.Panel1.Controls.Add(Me.btnAboutbox)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(910, 39)
    Me.Panel1.TabIndex = 32
    '
    'btnAboutbox
    '
    Me.btnAboutbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAboutbox.Location = New System.Drawing.Point(839, 4)
    Me.btnAboutbox.Name = "btnAboutbox"
    Me.btnAboutbox.Size = New System.Drawing.Size(64, 30)
    Me.btnAboutbox.TabIndex = 42
    Me.btnAboutbox.Text = "Info"
    Me.btnAboutbox.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(-2, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(78, 15)
    Me.Label1.TabIndex = 33
    Me.Label1.Text = "FTP-Server"
    '
    'frm_main
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(910, 606)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.btnMinimize)
    Me.Controls.Add(Me.checkTopmost)
    Me.Controls.Add(Me.WebBrowser1)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.splHorizontal)
    Me.Controls.Add(Me.Panel1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.MinimumSize = New System.Drawing.Size(793, 572)
    Me.Name = "frm_main"
    Me.Text = "frm_main"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.FlowLayoutPanel1.PerformLayout()
    Me.splLocal.Panel1.ResumeLayout(False)
    Me.splLocal.Panel2.ResumeLayout(False)
    Me.splLocal.ResumeLayout(False)
    CType(Me.ftvLocalUpload_Folder, System.ComponentModel.ISupportInitialize).EndInit()
    Me.cmstripServerTreeview.ResumeLayout(False)
    Me.cmstripExtras.ResumeLayout(False)
    Me.splHorizontal.Panel1.ResumeLayout(False)
    Me.splHorizontal.Panel2.ResumeLayout(False)
    Me.splHorizontal.Panel2.PerformLayout()
    Me.splHorizontal.ResumeLayout(False)
    Me.splMainVert.Panel1.ResumeLayout(False)
    Me.splMainVert.Panel1.PerformLayout()
    Me.splMainVert.Panel2.ResumeLayout(False)
    Me.splMainVert.Panel2.PerformLayout()
    Me.splMainVert.ResumeLayout(False)
    Me.splServer.Panel1.ResumeLayout(False)
    Me.splServer.Panel2.ResumeLayout(False)
    Me.splServer.ResumeLayout(False)
    CType(Me.igBatchList, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents checkTopmost As System.Windows.Forms.CheckBox
  Friend WithEvents imlTreeView As System.Windows.Forms.ImageList
  Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
  Friend WithEvents btnDownload As System.Windows.Forms.Button
  Friend WithEvents btnUpload As System.Windows.Forms.Button
  Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
  Friend WithEvents labState As System.Windows.Forms.Label
  Friend WithEvents splLocal As System.Windows.Forms.SplitContainer
  Friend WithEvents ftvLocalUpload_Folder As AxCCRPFolderTV6.AxFolderTreeview
  Friend WithEvents txtLocalFolder As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents cmstripServerTreeview As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents DateilisteAnzeigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents UmbennenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents OrdnerLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents tmrCheckUpdate As System.Windows.Forms.Timer
  Friend WithEvents cmstripExtras As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents PoweredByTeamwikiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AutomatischesUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ÜberMwFolderSyncToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents btnClose As System.Windows.Forms.Button
  Friend WithEvents btnMinimize As System.Windows.Forms.Button
  Friend WithEvents splHorizontal As System.Windows.Forms.SplitContainer
  Friend WithEvents igBatchList As TenTec.Windows.iGridLib.iGrid
  Friend WithEvents IGrid1DefaultCellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents IGrid1DefaultColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents IGrid1RowTextColCellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents lvLocalFolder As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
  Friend WithEvents imlLocalFolder As System.Windows.Forms.ImageList
  Friend WithEvents igBatchListCol1CellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents igBatchListCol1ColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents igBatchListCol2CellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents igBatchListCol2ColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents igBatchListCol3CellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents igBatchListCol3ColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents igBatchListCol5CellStyle As TenTec.Windows.iGridLib.iGCellStyle
  Friend WithEvents igBatchListCol5ColHdrStyle As TenTec.Windows.iGridLib.iGColHdrStyle
  Friend WithEvents btnProcessJobList As System.Windows.Forms.Button
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents lnkShortcutF9 As System.Windows.Forms.LinkLabel
  Friend WithEvents lnkShortcutF10 As System.Windows.Forms.LinkLabel
  Friend WithEvents lnkShortcutF11 As System.Windows.Forms.LinkLabel
  Friend WithEvents lnkShortcutF12 As System.Windows.Forms.LinkLabel
  Friend WithEvents txtSearch As System.Windows.Forms.TextBox
  Friend WithEvents btnCancelProcess As System.Windows.Forms.Button
  Friend WithEvents lnkClearSuchbox As System.Windows.Forms.LinkLabel
  Friend WithEvents splServer As System.Windows.Forms.SplitContainer
  Friend WithEvents txtServerFolder As System.Windows.Forms.ComboBox
  Friend WithEvents lvServerFile As System.Windows.Forms.ListView
  Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
  Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
  Friend WithEvents btnServerList_showAll As System.Windows.Forms.Button
  Friend WithEvents txtServerFile As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnRefreshServerFileList As System.Windows.Forms.Button
  Friend WithEvents splMainVert As System.Windows.Forms.SplitContainer
  Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
  Friend WithEvents txtDiz As System.Windows.Forms.TextBox
  Friend WithEvents btnDelJob As System.Windows.Forms.Button
  Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
  Friend WithEvents btnSettings As System.Windows.Forms.Button
  Friend WithEvents Panel1 As Panel
  Friend WithEvents btnAboutbox As Button
  Friend WithEvents Label1 As Label
End Class
