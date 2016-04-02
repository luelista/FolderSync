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

	public partial class frm_options
	{

		private void frm_options_Load(System.Object sender, System.EventArgs e)
		{
			app_main.glob.readTuttiFrutti(this);
			app_main.glob.readFormPos(this, false);
			this.Size = new Size(874, 406);
		}

		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			save();
		}

		private void btnHelp1_Click(System.Object sender, System.EventArgs e)
		{
			string tx = "Um die Shortcuts aufzurufen, drücke ..." + Constants.vbNewLine + "* [STRG] + [F-Taste] um das 'Lokal Upload'-Treeview zu navigieren oder" + Constants.vbNewLine + "*   [ALT] + [F-Taste] um das 'Lokal Download'-Treeview zu navigieren";

			MessageBox.Show(tx, "Benutzung der Shortcut-Tasten", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();

		}
		public void save()
		{
			app_main.glob.saveTuttiFrutti(this);
			app_main.glob.saveFormPos(this);
			My.MyProject.Forms.frm_main.initShortcutButtons();
			My.MyProject.Forms.frm_main.initSplitterDesign();
			app_main.FTP = new Utilities.FTP.FTPclient(app_main.glob.Para("frm_options__ftp_host"), app_main.glob.Para("frm_options__ftp_user"), app_main.glob.Para("frm_options__ftp_pass"));

		}
		private void btnOK_Click(System.Object sender, System.EventArgs e)
		{
			save();
			this.Close();

		}

		private void Button2_Click_1(System.Object sender, System.EventArgs e)
		{
			var _with1 = fbd1;
			_with1.Description = "Bitte wähle den Backupordner aus...";
			_with1.SelectedPath = backupFolder.Text;
			if (_with1.ShowDialog == System.Windows.Forms.DialogResult.OK) {
				backupFolder.Text = _with1.SelectedPath;
			}
		}

		private void Button3_Click(System.Object sender, System.EventArgs e)
		{
			var _with2 = OpenFileDialog1;
			_with2.Filter = "Wave-Sounddateien (.wav)|*.wav";
			_with2.FileName = !string.IsNullOrEmpty(finish_soundfile.Text) ? finish_soundfile.Text : "C:\\windows\\media\\ding.wav";
			if (_with2.ShowDialog == System.Windows.Forms.DialogResult.OK) {
				finish_soundfile.Text = _with2.FileName;
			}
		}

		private void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string[] parts = new string[] {
				"[fsPwdList",
				"",
				"",
				ftp_host.Text,
				ftp_dir.Text,
				ftp_user.Text,
				ftp_pass.Text,
				"eot]"
			};
			Clipboard.Clear();
			var @out = Strings.Join(parts, "$fs$");

			Clipboard.SetText(@out);

		}

		private void LinkLabel2_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			[] parts = Strings.Split(Clipboard.GetText(), "$fs$");
			if (parts.Length != 8 || parts(0).EndsWith("[fsPwdList") == false || parts(7).StartsWith("eot]") == false) {
				Interaction.MsgBox("ungültiges Format");
				return;
			}
			ftp_host.Text = parts(3);
			ftp_dir.Text = parts(4);
			ftp_user.Text = parts(5);
			ftp_pass.Text = parts(6);


		}
		public frm_options()
		{
			Load += frm_options_Load;
			InitializeComponent();
		}
	}
}
