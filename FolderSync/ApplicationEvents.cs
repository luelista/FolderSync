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
namespace FolderSync.My
{

	// Für MyApplication sind folgende Ereignisse verfügbar:
	// 
	// Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
	// Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
	// UnhandledException: Wird ausgelöst, wenn in der Anwendung eine unbehandelte Ausnahme auftritt.
	// StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist. 
	// NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
	internal partial class MyApplication
	{

		private void MyApplication_Startup(object sender, Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
		{
			My.MyProject.Forms.frm_splash.Show();




		}


		private void MyApplication_StartupNextInstance(object sender, Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs e)
		{

			My.MyProject.Forms.frm_main.Activate();
			app_main.onCommandLinePara(e.CommandLine);

		}


	}

}

