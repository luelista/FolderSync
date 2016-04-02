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
	static class app_main
	{
		public static cls_globPara glob = new cls_globPara();

		public static Utilities.FTP.FTPclient FTP;
		public static string fVersion = FolderSync.My.MyProject.Application.Info.Version.Major + "." + FolderSync.My.MyProject.Application.Info.Version.Minor;
		public static bool processingJoblist = false;

		public static bool cancelProcess = false;

		public static frm_main MainWnd;
		
		public static void startWebUpdate(bool autoUpdate)
		{
			string updaterFilespec = sys_mwRegistry.ExePath("mwwebupdate");

			if (string.IsNullOrEmpty(updaterFilespec) || FolderSync.My.MyProject.Computer.FileSystem.FileExists(updaterFilespec) == false || FileSystem.FileLen(updaterFilespec) < 40000) {
				if (!autoUpdate)
					Interaction.MsgBox("Der Updater wurde nicht gefunden bzw. du hast eine veraltete Version. " + Constants.vbNewLine + "Wenn du die neuste Version hast, starte den Updater einmal von Hand und versuche es nochmals. Ansonsten melde dich bei Max Weller ;-)");
				return;
			}

			string[] updaterPara = new string[6];
			updaterPara[0] = "foldersync";
			//appID
			updaterPara[1] = glob.appPath();
			//localFolder
			updaterPara[2] = "/autostart";
			//autostart?
			updaterPara[3] = "/autoclose";
			//autoclose?
			updaterPara[4] = Application.ExecutablePath;
			//startAfterUpdate(1)
			updaterPara[5] = "";
			//startAfterUpdate(2)
			string updaterArguments = Strings.Join(updaterPara, "#²#");

			//MsgBox(updaterFilespec + " " + updaterArguments, , "Updater wird aufgerufen...")

			glob.saveParaFile();
			Process.Start(updaterFilespec, updaterArguments);

		}

		public static void onCommandLinePara(System.Collections.ObjectModel.ReadOnlyCollection<string> cm)
		{
			if (cm.Count > 2) {
				if (cm[0] == "up") {
					app_zipNload.upload(cm[1], cm[2]);


				} else {
					app_zipNload.download(cm[1], cm[2]);

				}

			}


		}

		public static string FP(string p, string f = "")
		{
			return p + (p.EndsWith("\\") ? "" : "\\") + f;
		}

		public static string FP_linux(string p, string f = "")
		{
			string path = null;
			string file = null;
			path = p.Replace("\\", "/");
			file = f.Replace("\\", "/");
			return path + (path.EndsWith("/") ? "" : "/") + file;
		}

	}
}
