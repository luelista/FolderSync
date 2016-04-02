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
	static class sys_assocIcon
	{

		private struct SHFILEINFO
		{
				// : icon
			public IntPtr hIcon;
				// : icondex
			public int iIcon;
				// : SFGAO_ flags
			public int dwAttributes;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szDisplayName;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szTypeName;
		}
		[DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]

		private static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, int uFlags);

		private const int SHGFI_ICON = 0x100;
		public enum assoc_iconSize
		{
			SHGFI_SMALLICON = 0x1,
			SHGFI_LARGEICON = 0x0
			// Large icon
		}

		public static Image GetAssociatedIcon(string fileSpec, assoc_iconSize iconSize = assoc_iconSize.SHGFI_LARGEICON)
		{

			IntPtr hImg = default(IntPtr);
			//The handle to the system image list.
			SHFILEINFO shinfo = default(SHFILEINFO);
			shinfo = new SHFILEINFO();

			hImg = SHGetFileInfo(fileSpec, 0, ref shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON | iconSize);

			//The icon is returned in the hIcon member of the
			//shinfo struct.
			System.Drawing.Icon myIcon = null;
			myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon);

			return myIcon.ToBitmap();
		}

	}
}
