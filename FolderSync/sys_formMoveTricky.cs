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
using System.Runtime.InteropServices;
namespace FolderSync
{

	static class sys_formMoveTricky
	{
		const int WM_NCLBUTTONDOWN = 0xa1;
		//Const HTCAPTION As Integer = 2

		const int HTCAPTION = 0x2;
		[DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		public static extern IntPtr SendMessageA(IntPtr hWnd, IntPtr Msg, IntPtr wParam, ref IntPtr lParam);

		[DllImport("user32.dll")]
		private static bool ReleaseCapture()
		{
		}

		public static void FormMoveTricky(IntPtr hWnd)
		{
			ReleaseCapture();
			SendMessageA(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, ref 0L);

		}




	}
}
