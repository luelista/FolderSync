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
	public partial class frm_news
	{

		private void frm_news_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			app_main.glob.saveFormPos(this);
			app_main.glob.Para("frm_news__igDesign") = IGrid1.LayoutObject.Text;
		}

		private void frm_news_Load(System.Object sender, System.EventArgs e)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			this.Text = "Neuste Uploads - FolderSync " + app_main.fVersion;
			app_main.glob.readFormPos(this);
			IGrid1.LayoutObject.Text = app_main.glob.Para("frm_news__igDesign");

			//Stop
			refreshNewUploads();
		}

		public void refreshNewUploads()
		{
			string cont = TwAjax.getUrlContent("http://teamwiki.de/twiki/tools/foldersync_news.php?format=vbfriendly");
			string[] LINES = Strings.Split(cont, Constants.vbLf);
			if (LINES(0) != "OK")
				Interaction.MsgBox(cont);

			IGrid1.Rows.Clear();
			IGrid1.SortObject.Clear();

			foreach (string lin in LINES) {
				if (string.IsNullOrEmpty(lin) | lin == "OK")
					continue;
				string [] PARTS = Strings.Split(lin, "|##|");
				var _with1 = IGrid1.Rows.Add();
				_with1.Cells(0).Value = PARTS(0);
				_with1.Cells(1).Value = PARTS(1);
				_with1.Cells(2).Value = PARTS(2);
				int size = PARTS(3);
				string sFileSize = "";
				if (size > 1000000) {
					sFileSize = Convert.ToInt32(size / 1000000).ToString() + " MB";
				} else if (size > 1000) {
					sFileSize = Convert.ToInt32(size / 1000).ToString() + " kB";
				} else {
					sFileSize = size.ToString() + " B";
				}
				_with1.Cells(3).Value = sFileSize;
			}

			IGrid1.SortObject.Add(2, TenTec.Windows.iGridLib.iGSortOrder.Descending);
			IGrid1.Sort();
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();

		}

		private void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			//WebBrowser1.Navigate("http://teamwiki.de/twiki/tools/foldersync_news.php?maxcount=")

		}
	}
}
