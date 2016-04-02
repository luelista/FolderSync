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
	public partial class frm_splash
	{

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frm_splash_Load(System.Object sender, System.EventArgs e)
		{
			Label2.Text = "Version " + app_main.fVersion;
			Show();
			Application.DoEvents();

		}
		public frm_splash()
		{
			Load += frm_splash_Load;
			InitializeComponent();
		}
	}
}
