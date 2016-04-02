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
using System.IO;
using TenTec.Windows.iGridLib;
using FolderSync.Utilities.FTP;
namespace FolderSync
{

	public partial class frm_main
	{
		MVPS.clsFormBorder m_border = new MVPS.clsFormBorder(this);
		iGProgressBarCellManager igProgBar1 = new iGProgressBarCellManager();
		string lastShowFilename;
		FTPdirectory dicServerFileList;
		vbAccelerator.Components.Controls.TextBoxMarginCustomise icon_txtSearch = new vbAccelerator.Components.Controls.TextBoxMarginCustomise();

		vbAccelerator.Components.Controls.TextBoxMarginCustomise icon_txtDiz = new vbAccelerator.Components.Controls.TextBoxMarginCustomise();

		public void processJobList()
		{
			 // ERROR: Not supported in C#: OnErrorStatement


			if (app_main.glob.Para("diz").Length < 2) {
				Interaction.MsgBox("Bitte Diktatzeichen eingeben!", MsgBoxStyle.Exclamation, "FolderSync " + app_main.fVersion);
			}

			Random randomizer = new Random();

			app_main.processingJoblist = true;
			app_main.cancelProcess = false;
			btnProcessJobList.Enabled = false;
			btnCancelProcess.Enabled = true;

			while (igBatchList.Rows.Count > 0) {
				iGRow r = igBatchList.Rows[0);


				if (r.Tag == "DOWN") {
					//download
					app_zipNload.download(r.Cells["locfolder"].Value, r.Cells["servername"].Value);

				} else {
					//upload
					app_zipNload.upload(r.Cells["locfolder"].Value, r.Cells["servername"].Value);

				}

				//r.Cells("progress").Value = randomizer.Next(28, 91) / 100

				while (app_zipNload.isBusy) {
					Application.DoEvents();
					System.Threading.Thread.Sleep(11);
				}

				igBatchList.Rows.RemoveAt(r.Index);

				if (app_main.cancelProcess)
					break;
			}

			app_main.processingJoblist = false;
			app_main.cancelProcess = false;
			btnProcessJobList.Enabled = true;
			btnCancelProcess.Enabled = false;
		}


		public void addJobToList(string locFolder, string serverName, bool upload, bool autoStart)
		{
			var _with1 = igBatchList.Rows.Add();
			_with1.Cells(0).Value = locFolder;
			_with1.Cells(1).Value = upload ? " UP >>>" : " <<< DOWN";
			_with1.Cells(2).Value = serverName;
			_with1.Cells(3).Value = "Warten...";
			if (upload) {
				_with1.Cells("servername").BackColor = Color.MistyRose;
			} else {
				_with1.Cells("locfolder").BackColor = Color.LemonChiffon;
			}
			_with1.Tag = upload ? "UP" : "DOWN";

			if (autoStart == true & app_main.processingJoblist == false)
				processJobList();

		}

		private void checkTopmost_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			this.TopMost = checkTopmost.Checked;
		}

		public void btnRefreshServerFileList_Click(System.Object sender, System.EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement


			//GroupBox1.Enabled = False
			labState.Text = "Dateiliste laden...";
			Timer1.Start();
			Application.DoEvents();

			int trys = 0;
			startmarke:

			//tvServerFile.Nodes.Clear()

			dicServerFileList = app_ftp.GetServerDirList();
			if (dicServerFileList == null) {
				//      trys += 1
				//
				//      If trys < 4 Then
				//        GoTo startmarke
				//      Else
				lvServerFile.Enabled = false;
				lvServerFile.ResumeLayout();
				Interaction.MsgBox("Fehler beim Laden der Dateiliste! Evtl. ist der Server zur Zeit nicht verfügbar. Versuche es bitte erneut.", MsgBoxStyle.Exclamation, "FolderSync - Fehler");
				app_zipNload.isBusy = false;
				return;
				//      End If

			}

			txtServerFolder.Items.Clear();
			txtServerFolder.Items.Add("<ohne Hauptordner>");

			string nPath = null;
			string nFile = null;
			int pos1 = 0;
			ListViewItem lvi = null;

			foreach (FTPfileInfo f in dicServerFileList) {
				if (f.Extension.ToLower() != "zip")
					continue;
				pos1 = f.Filename.LastIndexOf("__");
				if (pos1 > -1) {
					nPath = f.Filename.Substring(0, pos1);
					if (!txtServerFolder.Items.Contains(nPath))
						txtServerFolder.Items.Add(nPath);
				}


			}

			fillServerListview("");
			labState.Text = "Fertig";

			Timer1.Stop();
			ProgressBar1.Value = 0;
			//GroupBox1.Enabled = True
		}

		public void fillServerListview(string @group = "")
		{
			string nPath = null;
			string nFile = null;
			int pos1 = 0;
			ListViewItem lvi = null;
			var suchString = txtSearch.Text.ToLower();
			lvServerFile.SuspendLayout();
			lvServerFile.Hide();

			lvServerFile.Items.Clear();
			lvServerFile.Groups.Clear();

			//If group = "" Then lvServerFile.Groups.Add("VbNetProjekte", "VbNetProjekte")

			ListViewGroup noGroup = lvServerFile.Groups.Add("___nogroup", "<ohne Hauptordner>");

			foreach (FTPfileInfo f in dicServerFileList) {
				if (f.Extension.ToLower() != "zip")
					continue;
				if (!string.IsNullOrEmpty(suchString) & f.Filename.ToLower().Contains(suchString) == false)
					continue;
				pos1 = f.Filename.LastIndexOf("__");
				if (pos1 > -1) {
					nPath = f.Filename.Substring(0, pos1);
					nFile = f.Filename.Substring(pos1 + 2);
					if (!string.IsNullOrEmpty(@group) & @group != nPath)
						continue;
				} else {
					nPath = "";
					nFile = f.Filename;
					if (!string.IsNullOrEmpty(@group) & @group != "__nogroup")
						continue;
				}


				lvi = lvServerFile.Items.Add(f.Filename, nFile, "zip");
				int fileSize = f.Size;
				string sFileSize = "";
				if (fileSize > 1000000) {
					sFileSize = Convert.ToInt32(fileSize / 1000000).ToString() + " MB";
				} else if (fileSize > 1000) {
					sFileSize = Convert.ToInt32(fileSize / 1000).ToString() + " kB";
				} else {
					sFileSize = fileSize.ToString() + " B";
				}
				lvi.SubItems.AddRange(new string[] {
					nPath,
					f.FileDateTime.ToString(),
					"diz",
					sFileSize
				});
				lvi.Tag = f;

				if (string.IsNullOrEmpty(nPath)) {
					lvi.Group = noGroup;

					//tvServerFile.Nodes.Add(f, nFile, "zip").ToolTipText = "Letzte Änderung: " + files(f)(0)

				} else {
					if (lvServerFile.Groups[nPath] == null) {
						lvServerFile.Groups.Add(nPath, nPath);
					}
					lvi.Group = lvServerFile.Groups[nPath];

					//If tvServerFile.Nodes(nPath) Is Nothing Then
					//  tvServerFile.Nodes.Add(nPath, nPath, "fld", "fld")
					//End If
					//tvServerFile.Nodes(nPath).Nodes.Add(f, nFile, "zip").ToolTipText = "Letzte Änderung: " + files(f)(0)



				}

			}

			app_zipNload.isBusy = false;
			lvServerFile.ResumeLayout();
			lvServerFile.Show();
		}

		public void refreshServerFileName(string fileName = "")
		{
			txtServerFile.Text = "";
			string serverFolder = txtServerFolder.Text;
			if (serverFolder == "<ohne Hauptordner>")
				serverFolder = "";
			if (!string.IsNullOrEmpty(serverFolder))
				txtServerFile.Text += serverFolder + "__";

			if (string.IsNullOrEmpty(fileName) & string.IsNullOrEmpty(lastShowFilename)) {
				txtServerFile.Text = "";
			} else if (string.IsNullOrEmpty(fileName)) {
				txtServerFile.Text += lastShowFilename;
			} else {
				txtServerFile.Text += fileName;
			}

			if (!string.IsNullOrEmpty(txtServerFile.Text) & !txtServerFile.Text.ToLower().EndsWith(".zip"))
				txtServerFile.Text += ".zip";
		}


		private void ftvLocalFolder_FolderClick(System.Object sender, AxCCRPFolderTV6.__FolderTreeview_FolderClickEvent e)
		{
			if (!string.IsNullOrEmpty(e.folder.FullPath) & e.folder.FullPath.StartsWith("::") == false) {
				txtLocalFolder.Text = e.folder.FullPath;
			} else {
				txtLocalFolder.Text = "";
			}
		}

		private void txtLocalFolder_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				//Try

				((CCRPFolderTV6.Folder)ftvLocalUpload_Folder.SelectedFolder).Name = txtLocalFolder.Text;
				//Catch : End Try
				e.SuppressKeyPress = true;


			}
		}


		private void frm_main_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			app_main.glob.saveTuttiFrutti(this);
			app_main.glob.saveFormPos(this);

			if ((e.CloseReason != CloseReason.TaskManagerClosing) & (app_zipNload.isBusy | app_main.processingJoblist)) {
				Interaction.MsgBox("FolderSync kann nicht beendet werden, während noch Dateien hoch oder herunter geladen werden.", MsgBoxStyle.Exclamation, "Beenden nicht möglich");
				e.Cancel = true;
			}
			//startWebUpdate(True)
		}

		private void frm_main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode >= 120 & e.KeyCode <= 123) {
				int fKey = e.KeyCode - 111;
				int pathIndex = e.KeyCode - 119;
				string path = app_main.glob.Para("frm_options__shortcut" + pathIndex.ToString());
				if (string.IsNullOrEmpty(path)) {
					MsgBoxResult res = Interaction.MsgBox("Für die Taste F" + fKey.ToString() + " ist noch kein Shortcut festgelegt. Soll der Dialog 'Einstellungen' jetzt geöffnet werden?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "FolderSync Shortcuts");
					if (res == MsgBoxResult.Yes)
						My.MyProject.Forms.frm_options.Show();
					return;
				}

				//If e.Control Then
				ftvLocalUpload_Folder.SelectedFolder.Name = path;
				txtLocalFolder.Text = path;
				//ElseIf e.Alt Then
				//  ftvLocalTargetFolder.SelectedFolder.Name = path
				//  txtLocalTargetFolder.Text = path
				//Else
				//  MsgBox("pfad: " + path + vbNewLine + "[STRG) + [F-Taste] öffnet den Pfad im Uploadteil" + vbNewLine + _
				//         "[ALT] + [F-Taste] öffnet den Pfad im Downloadteil", MsgBoxStyle.Information)

				//End If




			}
		}


		private void frm_main_Load(System.Object sender, System.EventArgs e)
		{
			app_main.glob.readFormPos(this);

			var _with2 = m_border;
			//  .Titlebar = False

			icon_txtSearch.Attach(txtSearch);
			icon_txtDiz.Attach(txtDiz);
			icon_txtSearch.ImageList = imlTreeView;
			icon_txtDiz.ImageList = imlTreeView;
			icon_txtSearch.Icon = 2;
			icon_txtDiz.Icon = 3;

			initShortcutButtons();
			initSplitterDesign();

			app_main.glob.readTuttiFrutti(this);

			this.Show();
			Application.DoEvents();

			this.Text = "FolderSync " + app_main.fVersion;
			try {
				app_main.FTP = new Utilities.FTP.FTPclient(app_main.glob.Para("frm_options__ftp_host"), app_main.glob.Para("frm_options__ftp_user"), app_main.glob.Para("frm_options__ftp_pass"));

			} catch (Exception ex) {
				Interaction.MsgBox("Fehler beim Aufbau der FTP-Verbindung!" + Constants.vbNewLine + "Bitte die entsprechenden Daten in den Einstellungen eintragen.");
				My.MyProject.Forms.frm_options.Show();

			}
			try {
				ftvLocalUpload_Folder.SelectedFolder.name = app_main.glob.Para("frm_main__txtLocalFolder");
			} catch {
			}


			btnRefreshServerFileList_Click(null, null);

			sys_mwRegistry.mwRegisterSelf();
			app_main.onCommandLinePara(FolderSync.My.MyProject.Application.CommandLineArgs);

			My.MyProject.Forms.frm_splash.Close();

			// igProgBar1.Attach(igBatchList, igBatchList.Cols("progress"))

			tmrCheckUpdate.Enabled = true;

		}


		public void initSplitterDesign()
		{
			if (app_main.glob.Para("frm_options__checkLocalVertical", "FALSE") == "TRUE") {
				splLocal.Orientation = Orientation.Vertical;
			} else {
				splLocal.Orientation = Orientation.Horizontal;
			}

			if (app_main.glob.Para("frm_options__checkShowServerFolderList", "TRUE") == "FALSE") {
				splServer.Panel1Collapsed = true;
			} else {
				splServer.Panel1Collapsed = false;
			}


		}
		public void initShortcutButtons()
		{
			lnkShortcutF9.Text = "F9: " + app_main.glob.Para("frm_options__shortcut_text1");
			lnkShortcutF10.Text = "F10: " + app_main.glob.Para("frm_options__shortcut_text2");
			lnkShortcutF11.Text = "F11: " + app_main.glob.Para("frm_options__shortcut_text3");
			lnkShortcutF12.Text = "F12: " + app_main.glob.Para("frm_options__shortcut_text4");

		}

		private void OrdnerLöschenToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			if (lvServerFile.SelectedItems.Count == 0)
				return;
			ListViewItem lvi = lvServerFile.SelectedItems[0];

			if (lvi.Tag.ToLower.EndsWith(".zip")) {
				MsgBoxResult res = default(MsgBoxResult);
				res = Interaction.MsgBox("Möchten Sie den Ordner " + lvi.Tag + " endgültig vom Server löschen?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "FolderSync - Ordner löschen");

				if (res == MsgBoxResult.Yes) {
					app_main.FTP.FtpDelete(app_main.glob.Para("frm_options__ftp_dir") + lvi.Tag);
					btnRefreshServerFileList_Click(null, null);
				}

			}

		}


		public void processBatchList()
		{

		}

		private void btnDownload_Click(System.Object sender, System.EventArgs e)
		{
			//For Each item As ListViewItem In lvServerFile.CheckedItems
			//  item.Selected = True
			//  item.EnsureVisible()

			//  Dim localTargetFolder As String = lvServerFile.SelectedItems(0).Text
			//  localTargetFolder = localTargetFolder.Substring(0, localTargetFolder.Length - 4)
			//  localTargetFolder = FP(txtLocalFolder.Text, localTargetFolder)

			//  download(localTargetFolder, txtServerFile.Text)

			//  While isBusy
			//    Application.DoEvents()
			//    Threading.Thread.Sleep(11)
			//  End While

			//Next

			//finishMessage()

		}

		private void ftvLocalUpload_Folder_SelectionChange(object sender, AxCCRPFolderTV6.__FolderTreeview_SelectionChangeEvent e)
		{
			txtLocalFolder.Text = e.folder.FullPath;

			//Stop
			lvLocalFolder.Items.Clear();
			imlLocalFolder.Images.Clear();
			foreach (string fld in Directory.GetDirectories(e.folder.FullPath)) {
				imlLocalFolder.Images.Add(fld, sys_assocIcon.GetAssociatedIcon(fld, assoc_iconSize.SHGFI_SMALLICON));
				lvLocalFolder.Items.Add(fld.Substring(fld.LastIndexOf("\\") + 1), fld);
			}
		}

		private void lvLocalFolder_Resize(object sender, System.EventArgs e)
		{
			lvLocalFolder.Columns[0].Width = lvLocalFolder.Width - 24;
		}

		//Private Sub clbLocalUpload_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
		//  If e.Button = Windows.Forms.MouseButtons.Right Then
		//    Dim idx As Integer = clbLocalUpload.IndexFromPoint(e.Location)
		//    If idx = -1 Then Exit Sub
		//    Dim f As String = ftvLocalUpload_Folder.SelectedFolder.name
		//    ftvLocalUpload_Folder.SelectedFolder.name = glob.fp(f, clbLocalUpload.Items(idx))


		//  End If
		//End Sub

		private void lvLocalFolder_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			lastShowFilename = "";
			lastShowFilename = lvLocalFolder.SelectedItems[0].Text;
			refreshServerFileName("");

		}

		private void txtServerFolder_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right) {
				int index = (e.Y - 20) / txtServerFolder.ItemHeight;
				if (index > txtServerFolder.Items.Count - 2){fillServerListview("");return;
}
				txtServerFolder.SelectedIndex = index + 1;

				string serverFolder = txtServerFolder.Items[index + 1];
				if (serverFolder == "<ohne Hauptordner>")
					serverFolder = "__nogroup";

				txtSearch.Text = "";
				fillServerListview(serverFolder);


			}
		}

		//Private Sub ftvLocalTargetFolder_FolderClick(ByVal sender As System.Object, ByVal e As AxCCRPFolderTV6.__FolderTreeview_FolderClickEvent)
		//  txtLocalTargetFolder.Text = e.folder.FullPath
		//End Sub

		private void txtServerFolder_TextChanged(System.Object sender, System.EventArgs e)
		{
			txtServerFile.Text = "";
		}

		//Private Sub lnkTargetExplorer_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
		//  Process.Start("explorer.exe", "/e," + txtLocalTargetFolder.Text)
		//End Sub

		//Private Sub txtLocalTargetFolder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
		//  If e.KeyCode = Keys.Enter Then
		//    Try
		//      ftvLocalTargetFolder.SelectedFolder.name = txtLocalTargetFolder.Text
		//    Catch : End Try
		//    e.SuppressKeyPress = True
		//  End If
		//End Sub


		private void lvServerFile_Resize(object sender, System.EventArgs e)
		{
			lvServerFile.Columns[0].Width = lvServerFile.Width - 252;

		}

		private void lvServerFile_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (lvServerFile.SelectedItems.Count == 0)
				return;

			ListViewItem lvi = lvServerFile.SelectedItems[0];
			txtServerFolder.Text = lvi.SubItems[1].Text;
			lastShowFilename = "";
			refreshServerFileName(lvi.Text);


		}

		private void DateilisteAnzeigenToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			if (lvServerFile.SelectedItems.Count == 0)
				return;

			ListViewItem lvi = lvServerFile.SelectedItems[0];

			//Dim fileList As String = TwAjax.getUrlContent("http://teamwiki.de/twiki/write_post.php?mode=getzipfilecontent&file=/foldersync/" + lvi.Tag)
			string fileList = TwAjax.ReadFile("foldersync_meta", "filelist_" + lvi.Tag + ".txt");

			string[] lines = Strings.Split(fileList, Constants.vbNewLine);

			My.MyProject.Forms.frm_fileList.ListView1.Items.Clear();
			foreach (string lin in lines) {
				My.MyProject.Forms.frm_fileList.ListView1.Items.Add(lin);
			}


			My.MyProject.Forms.frm_fileList.Text = "Dateiliste " + lvi.Tag + " - FolderSync";
			My.MyProject.Forms.frm_fileList.Show();

		}


		public void finishMessage()
		{
			 // ERROR: Not supported in C#: OnErrorStatement


			if (app_main.glob.Para("frm_options__chk_finish_windowtotop") == "TRUE") {
				Interaction.AppActivate(this.Text);

			}

			if (app_main.glob.Para("frm_options__chk_finish_playsound") == "TRUE") {
				if (string.IsNullOrEmpty(app_main.glob.Para("frm_options__finish_soundfile"))) {
					FolderSync.My.MyProject.Computer.Audio.Play("C:\\windows\\media\\tada.wav");

				} else {
					FolderSync.My.MyProject.Computer.Audio.Play(app_main.glob.Para("frm_options__finish_soundfile"));
				}

			}

			if (app_main.glob.Para("frm_options__chk_finish_messagebox") == "TRUE") {
				Interaction.MsgBox("Der Up-/Download ist jetzt abgeschlossen.", MsgBoxStyle.Information, "FolderSync");

			}

		}


		private void Timer1_Tick(System.Object sender, System.EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			ProgressBar1.Value += 1;
			if (ProgressBar1.Value == ProgressBar1.Maximum)
				ProgressBar1.Value = 0;
		}

		private void lnkShortcut_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string path = app_main.glob.Para("frm_options__shortcut" + sender.tag);
			if (string.IsNullOrEmpty(path)) {
				MsgBoxResult res = Interaction.MsgBox("Für diesen Link ist noch kein Ordner festgelegt. Soll der Dialog 'Einstellungen' jetzt geöffnet werden?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "FolderSync Shortcuts");
				if (res == MsgBoxResult.Yes)
					My.MyProject.Forms.frm_options.Show();
				return;
			}

			ftvLocalUpload_Folder.SelectedFolder.Name = path;
			txtLocalFolder.Text = path;
		}

		private void btnServerList_showAll_Click(System.Object sender, System.EventArgs e)
		{
			txtSearch.Text = "";
			txtServerFolder.Text = "";
			txtServerFolder.SelectedIndex = -1;
			//fillServerListview("")

		}

		private void UmbennenToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (lvServerFile.SelectedItems.Count == 0)
				return;
			ListViewItem lvi = lvServerFile.SelectedItems[0];

			if (lvi.Tag.ToLower.EndsWith(".zip")) {
				string newName = Interaction.InputBox("Umbennenen des Ordners " + lvi.Tag + " in:", "Foldersync", lvi.Tag);
				if (string.IsNullOrEmpty(newName))
					return;

				try {
					app_main.FTP.FtpRename(app_main.glob.Para("frm_options__ftp_dir") + lvi.Tag, app_main.glob.Para("frm_options__ftp_dir") + newName);
				} catch (Exception ex) {
					Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical);
				}
				btnRefreshServerFileList_Click(null, null);


			}
		}


		private void checkCreateBackup_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (checkCreateBackup.Checked == true & string.IsNullOrEmpty(app_main.glob.Para("frm_options__backupFolder"))) {
				Interaction.MsgBox("bitte erst einen Backupfolder in den Optionen einstellen");
				checkCreateBackup.Checked = false;

			}
		}


		private void PictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left) {
				sys_formMoveTricky.FormMoveTricky(this.Handle);

			}
		}

		private void tmrCheckUpdate_Tick(System.Object sender, System.EventArgs e)
		{
			//tmrCheckUpdate.Interval = 1800000 'alle halbe Stunde ernaut suchen
			tmrCheckUpdate.Stop();

			app_main.startWebUpdate(true);
		}




		private void lnkUpdate_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			app_main.startWebUpdate(false);

		}

		private void btnClose_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();

		}

		private void btnMinimize_Click(System.Object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			processJobList();
		}


		private void btnUpload_Mousedown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (lvLocalFolder.SelectedItems.Count != 1)
				return;
			string remote = null;
			string loc = null;
			loc = lvLocalFolder.SelectedItems[0].Text;
			refreshServerFileName();
			var lw = txtServerFile.Text.ToLower();
			if (lw.Contains('ä') | lw.Contains('ö') | lw.Contains('ü') | lw.Contains(' ') | lw.Contains('ß')) {
				Interaction.MsgBox("der Dateiname darf keine Sonderzeichen enthalten!");
				return;
			}

			addJobToList(app_main.FP(txtLocalFolder.Text, loc), txtServerFile.Text, true, e.Button == System.Windows.Forms.MouseButtons.Right);

		}

		private void btnDownload_Mousedown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (lvServerFile.SelectedItems.Count == 0)
				return;

			ListViewItem lvi = lvServerFile.SelectedItems[0];
			txtServerFolder.Text = lvi.SubItems[1].Text;
			lastShowFilename = "";
			refreshServerFileName(lvi.Text);

			string localTargetFolder = lvServerFile.SelectedItems[0].Text;
			localTargetFolder = localTargetFolder.Substring(0, localTargetFolder.Length - 4);
			localTargetFolder = app_main.FP(txtLocalFolder.Text, localTargetFolder);

			addJobToList(localTargetFolder, txtServerFile.Text, false, e.Button == System.Windows.Forms.MouseButtons.Right);

		}

		private void TextBox1_TextChanged(System.Object sender, System.EventArgs e)
		{
			fillServerListview();
		}


		private void btnCancelProcess_Click(System.Object sender, System.EventArgs e)
		{
			app_main.cancelProcess = true;
		}

		private void igBatchList_CellMouseUp(object sender, TenTec.Windows.iGridLib.iGCellMouseUpEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right) {
				deleteJob(e.RowIndex);

			}
		}

		private void lnkTeamwiki_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://vbnet.teamwiki.de/foldersync.html");

		}

		private void lnkAbout_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			My.MyProject.Forms.frm_splash.Label1.Hide();
			My.MyProject.Forms.frm_splash.Button1.Show();
			My.MyProject.Forms.frm_splash.Show();

		}


		private void lnkClearSuchbox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			txtSearch.Text = "";

		}


		private void PictureBox2_Click(System.Object sender, System.EventArgs e)
		{
		}

		private void txtDiz_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (txtDiz.Text == "DIZ") {
				app_main.glob.Para("diz") = "";
			} else {
				app_main.glob.Para("diz") = txtDiz.Text;

			}

		}

		private void btnDelJob_Click(System.Object sender, System.EventArgs e)
		{
			if (igBatchList.CurRow != null)
				deleteJob(igBatchList.CurRow.Index);
		}

		public void deleteJob(int rowIndex)
		{
			if (igBatchList.Cells[rowIndex, "progress"].Value == "Warten...") {
				igBatchList.Rows.RemoveAt(rowIndex);

			}
		}

		private void btnSettings_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frm_options.Show();
			My.MyProject.Forms.frm_options.Activate();

		}

		private void Label6_Click(System.Object sender, System.EventArgs e)
		{
			if (lvLocalFolder.SelectedItems.Count != 1) {
				Process.Start("explorer.exe", "/e," + txtLocalFolder.Text);
			} else {
				Process.Start("explorer.exe", "/e,/select," + app_main.FP(txtLocalFolder.Text, lvLocalFolder.SelectedItems[0].Text));
			}
		}

		private void btnNewestUploads_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.frm_news.Show();
			My.MyProject.Forms.frm_news.Activate();
		}
		public frm_main()
		{
			Load += frm_main_Load;
			KeyDown += frm_main_KeyDown;
			FormClosing += frm_main_FormClosing;
			InitializeComponent();
		}

	}
}
