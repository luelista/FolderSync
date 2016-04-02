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
namespace FolderSync
{

	static class app_zipNload
	{
		const string fileInfoSplitter = Constants.vbNewLine + ";-) fsfi-Splitter]~#|";
		private static System.ComponentModel.BackgroundWorker withEventsField_bgWork = new System.ComponentModel.BackgroundWorker();
		public static System.ComponentModel.BackgroundWorker bgWork {
			get { return withEventsField_bgWork; }
			set {
				if (withEventsField_bgWork != null) {
					withEventsField_bgWork.DoWork -= bgWork_DoWork;
					withEventsField_bgWork.ProgressChanged -= bgWork_ProgressChanged;
					withEventsField_bgWork.RunWorkerCompleted -= bgWork_RunWorkerCompleted;
				}
				withEventsField_bgWork = value;
				if (withEventsField_bgWork != null) {
					withEventsField_bgWork.DoWork += bgWork_DoWork;
					withEventsField_bgWork.ProgressChanged += bgWork_ProgressChanged;
					withEventsField_bgWork.RunWorkerCompleted += bgWork_RunWorkerCompleted;
				}
			}

		}
		static string locFolder;
		static string serverFile;
		static bool direction_up;
		static bool _busy;

		static int actJobListRowIndex;

		public static bool isBusy {
			get { return _busy; }
			set {
				var _with1 = app_main.MainWnd;
				//.SuspendLayout()
				//.GroupBox1.Enabled = Not value
				//.GroupBox2.Enabled = Not value
				//.GroupBox3.Enabled = Not value

				//.btnShortcutF10.Enabled = Not value
				//.btnShortcutF11.Enabled = Not value
				//.btnShortcutF12.Enabled = Not value
				//.btnShortcutF9.Enabled = Not value

				_with1.Timer1.Enabled = value;
				if (value == false)
					_with1.ProgressBar1.Value = 0;
				//.btnUpload.Enabled = Not value
				//.btnDownload.Enabled = Not value

				//.ResumeLayout()
				Application.DoEvents();

				_busy = value;
			}
		}

		public static void upload(string loc, string remote)
		{
			//If frm_main.txtLocalFolder.Text = "" Or frm_main.txtServerFile.Text = "" Then
			//  Beep()
			//  Exit Sub
			//End If

			direction_up = true;
			locFolder = loc;
			serverFile = remote;


			isBusy = true;

			bgWork.WorkerReportsProgress = true;
			bgWork.RunWorkerAsync();


		}

		public static void download(string loc, string remote)
		{
			//If frm_main.txtLocalFolder.Text = "" Or frm_main.txtServerFile.Text = "" Then
			//  Beep()
			//  Exit Sub
			//End If

			direction_up = false;
			locFolder = loc;
			serverFile = remote;
			if (Directory.Exists(locFolder)) {
				if (My.MyProject.Forms.frm_main.checkCreateBackup.Checked) {
					string backup = getBackupFolder(loc);
					//  MsgBox(backup)
					try {
						System.IO.Directory.Move(loc, backup);
					} catch (Exception ex) {
						Interaction.MsgBox("Der Zielordner konnte nicht in den Backupordner verschoben werden. Bitte stelle sicher, dass er nicht mehr verwendet wird." + Constants.vbNewLine + "Grund: " + ex.Message, MsgBoxStyle.Exclamation);
					}
				} else {
					switch (Interaction.MsgBox("Achtung! Der lokale Ordner " + locFolder + " existiert schon. Der Ordner wird nicht überschrieben. Soll der Ordner vorher gelöscht werden? Andernfalls wird der Ordner nicht gedownloadet!", MsgBoxStyle.YesNoCancel)) {
						case MsgBoxResult.Yes:
							try {
								Directory.Delete(locFolder, true);
							} catch (Exception ex) {
								if (Interaction.MsgBox("Der Ordner konnte nicht gelöscht werden." + Constants.vbNewLine + "Grund: " + ex.Message + Constants.vbNewLine + "Trotzdem downloaden?", MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
									return;
							}
							break;
						case MsgBoxResult.No:
							break;
						case MsgBoxResult.Cancel:
							return;

							break;
					}

				}

			}
			Directory.CreateDirectory(locFolder);

			isBusy = true;

			bgWork.WorkerReportsProgress = true;
			bgWork.RunWorkerAsync();

		}
		public static void saveFilelist()
		{
			//!!! locFolder+serverFile sind globVars

			string[] files = System.IO.Directory.GetFiles(locFolder, "*", SearchOption.AllDirectories);
			string fileList = Strings.Join(files, Constants.vbNewLine);

			TwAjax.SaveFile("foldersync_meta", "filelist_" + serverFile + ".txt", fileList);

		}
		private static void bgWork_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			ICSharpCode.SharpZipLib.Zip.FastZip fastZip = new ICSharpCode.SharpZipLib.Zip.FastZip();

			//upload
			if (direction_up) {
				bgWork.ReportProgress(1);

				string tmpZipName = app_main.FP(FolderSync.My.MyProject.Computer.FileSystem.SpecialDirectories.Temp, "temp_" + DateAndTime.Timer().ToString + ".zip");

				writeFileInformation();

				fastZip.CreateZip(tmpZipName, locFolder, true, "");

				if (app_main.cancelProcess)
					return;
				bgWork.ReportProgress(2);

				app_main.FTP.Upload(tmpZipName, app_main.glob.Para("frm_options__ftp_dir") + serverFile);

				File.Delete(tmpZipName);

			//download
			} else {
				bgWork.ReportProgress(3);

				//Stop
				string tmpZipName = app_main.FP(FolderSync.My.MyProject.Computer.FileSystem.SpecialDirectories.Temp, "temp_" + DateAndTime.Timer.ToString() + ".zip");

				app_main.FTP.Download(app_main.glob.Para("frm_options__ftp_dir") + serverFile, tmpZipName);

				if (app_main.cancelProcess)
					return;
				bgWork.ReportProgress(4);

				fastZip.ExtractZip(tmpZipName, locFolder, ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Always, null, "", "", true);

				File.Delete(tmpZipName);

			}
		}

		public static bool confirmOverwrite(string fileName)
		{

		}

		private static void bgWork_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			string text = "";
			switch (e.ProgressPercentage) {
				case 1:
					text = "Komprimieren ...";
					break;
				case 2:
					text = "Hochladen ...";
					break;
				case 3:
					text = "Herunterladen ...";
					break;
				case 4:
					text = "Dekomprimieren ...";
					break;
			}
			My.MyProject.Forms.frm_main.igBatchList.Cells[0, "progress"].Value = text;
		}

		private static void bgWork_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if (direction_up)
				My.MyProject.Forms.frm_main.btnRefreshServerFileList_Click(null, null);

			isBusy = false;

			My.MyProject.Forms.frm_main.labState.Text = "Bereit.";
			My.MyProject.Forms.frm_main.finishMessage();
		}

		public static string getBackupFolder(string loc)
		{
			return app_main.glob.fp(app_main.glob.Para("frm_options__backupFolder"), System.IO.Path.GetFileName(loc) + DateAndTime.Now.ToString("_yyyy-MM-dd__HHmmss"));

		}

		public static void writeFileInformation()
		{
			string[] fileList = Directory.GetFiles(locFolder, "*", SearchOption.AllDirectories);
			int startPos = locFolder.Length;
			for (int i = 0; i <= fileList.Length - 1; i++) {
				fileList[i] = fileList[i].Substring(startPos);
			}

			string[] INFO = new string[6];
			//0=diz 1=kennung 2=filelist 3=kom
			INFO[0] = app_main.glob.Para("diz").PadRight(22);
			INFO[1] = "MW_FOLDERSYNC_FILEINFO";
			INFO[2] = Strings.Join(fileList, "|##|");
			INFO[3] = "KOM";

			TwAjax.SaveFile("foldersync", "fileinfo," + serverFile + ".txt", Strings.Join(INFO, fileInfoSplitter));
		}

		public static string[] getFileInformation(string serverFileName)
		{
			string CONTENT = TwAjax.ReadFile("foldersync", "fileinfo," + serverFileName);

			string[] INFO = Strings.Split(CONTENT, fileInfoSplitter);
			//0=diz 1=kennung 2=filelist 3=kom

			return INFO;
		}

	}
}
