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
	static class sys_mwRegistry
	{

		const string  mwRegistryPath = "C:\\yPara\\mwRegistry\\";

		private static object fp(string path, string fileName = "")
		{
			return path + (path.EndsWith("\\") ? "" : "\\") + fileName;
		}
		private static string appPath()
		{
			return fp(FolderSync.My.MyProject.Computer.FileSystem.GetParentPath(Application.ExecutablePath));
		}

		public static void mwRegisterSelf()
		{
			string exeName = System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath);
			System.IO.Directory.CreateDirectory(mwRegistryPath);
			System.IO.File.WriteAllText(mwRegistryPath + exeName + ".mwreg", Application.ExecutablePath);
		}

		public static string ExePath(string appName)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			string fileName = mwRegistryPath + appName + ".mwreg";
			if (System.IO.File.Exists(fileName))
				return System.IO.File.ReadAllText(fileName);
			if (System.IO.File.Exists(appPath() + appName + ".exe"))
				return appPath() + appName + ".exe";
		}

	}
}
