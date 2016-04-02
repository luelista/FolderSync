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
namespace FolderSync.MVPS
{

	// *********************************************************************
	//  Copyright ©1995-2001 Karl E. Peterson, All Rights Reserved
	//  http://www.mvps.org/vb
	// *********************************************************************
	//  You are free to use this code within your own applications, but you
	//  are expressly forbidden from selling or otherwise distributing this
	//  source code without prior written consent.
	// *********************************************************************
	//  GENERAL USAGE NOTE:  Be sure to set the Client form with these
	//  properties, in order to insure the toggles in this class work:
	//   * BorderStyle:  2 - Sizable
	//   * ControlBox:   True
	//  You may freely change these and all other properties at runtime.
	// *********************************************************************

	class clsFormBorder
	{


		// Point type used to track cursor.
		private struct POINTAPI
		{
			public int x;
			public int Y;
		}
		[DllImport("user32", EntryPoint = "GetWindowLongA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]

		// Win32 APIs used to toggle border styles.
		private static extern int GetWindowLong(int hwnd, int nIndex);
		[DllImport("user32", EntryPoint = "SetWindowLongA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int SetWindowLong(int hwnd, int nIndex, int dwNewLong);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int ShowWindow(int hwnd, int nCmdShow);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int LockWindowUpdate(int hWndLock);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]

		// Win32 APIs used to automate drag and sysmenu support.
		private static extern int GetSystemMenu(int hwnd, int revert);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int GetMenuItemID(int hMenu, int nPos);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int GetMenuItemCount(int hMenu);
		[DllImport("user32", EntryPoint = "GetMenuItemInfoA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int GetMenuItemInfo(int hMenu, int un, int b, MENUITEMINFO lpMenuItemInfo);
		[DllImport("user32", EntryPoint = "SetMenuItemInfoA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int SetMenuItemInfo(int hMenu, int un, int @bool, MENUITEMINFO lpcMenuItemInfo);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int RemoveMenu(int hMenu, int nPosition, int wFlags);
		[DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int ReleaseCapture();
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int GetCursorPos(POINTAPI lpPoint);

		// Used to get menu information.
		[StructLayout(LayoutKind.Sequential)]
		public struct MENUITEMINFO
		{
			public int cbSize;
			public int fMask;
			public int fType;
			public int fState;
			public int wID;
			public IntPtr hSubMenu;
			public IntPtr hbmpChecked;
			public IntPtr hbmpUnchecked;
			public IntPtr dwItemData;
			public string dwTypeData;
			public int cch;
			public IntPtr hbmpItem;
		}


		// Used to support captionless drag
		private const int WM_NCLBUTTONDOWN = 0xa1;

		private const int HTCAPTION = 2;
		// Undocumented message constant.

		private const int WM_GETSYSMENU = 0x313;
		// Used to select which menu to remove.
		private const long MF_BYCOMMAND = 0x0L;

		private const int MF_BYPOSITION = 0x400;
		// Toggles enabled state of menu item.
		private const long MF_ENABLED = 0x0L;
		private const long MF_GRAYED = 0x1L;

		private const long  MF_DISABLED = 0x2L;
		// Menu information constants.
		private const int MIIM_STATE = 0x1;
		private const int MIIM_ID = 0x2;
		private const int MIIM_SUBMENU = 0x4;
		private const int MIIM_CHECKMARKS = 0x8;
		private const int MIIM_TYPE = 0x10;

		private const int MIIM_DATA = 0x20;
		// Used to get window style bits.
		private const int GWL_STYLE = (-16);

		private const int GWL_EXSTYLE = (-20);
		// Style bits.
		private const int WS_MAXIMIZEBOX = 0x10000;
		private const int WS_MINIMIZEBOX = 0x20000;
		private const int WS_THICKFRAME = 0x40000;
		private const int WS_SYSMENU = 0x80000;

		private const int WS_CAPTION = 0xc00000;
		// Extended Style bits.
		private const int WS_EX_TOPMOST = 0x8;
		private const int WS_EX_TOOLWINDOW = 0x80;
		private const int WS_EX_CONTEXTHELP = 0x400;

		private const int WS_EX_APPWINDOW = 0x40000;
		// Force total redraw that shows new styles.
		private const int SWP_FRAMECHANGED = 0x20;
		private const int SWP_NOMOVE = 0x2;
		private const int SWP_NOZORDER = 0x4;

		private const int SWP_NOSIZE = 0x1;
		// Used to toggle into topmost layer.
		private const int HWND_TOPMOST = -1;

		private const int HWND_NOTOPMOST = -2;
		// System menu command values commonly used by VB.
		private const long SC_SIZE = 0xf000L;
		private const long SC_MOVE = 0xf010L;
		private const long SC_MINIMIZE = 0xf020L;
		private const long SC_MAXIMIZE = 0xf030L;
		private const long SC_CLOSE = 0xf060L;

		private const long SC_RESTORE = 0xf120L;
		// Enumerated sysmenu items.
		public enum SysMenuItems : long
		{
			smRestore = clsFormBorder.SC_RESTORE,
			smMove = clsFormBorder.SC_MOVE,
			smSize = clsFormBorder.SC_SIZE,
			smMinimize = clsFormBorder.SC_MINIMIZE,
			smMaximize = clsFormBorder.SC_MAXIMIZE,
			smClose = clsFormBorder.SC_CLOSE
		}

		// References to client form.
		private Form m_Client;
		//Attribute m_Client.VB_VarHelpID = -1
		//Private WithEvents m_MdiClient As MDIForm
		//Attribute m_MdiClient.VB_VarHelpID = -1

		private int m_hWnd;
		// Member variables
		private bool m_AutoSysMenu;

		private bool m_AutoDrag;

		// ************************************************
		//  Sunken Client Events
		// ************************************************
		private void m_Client_MouseDown(int Button, int Shift, float x, float Y)
		{
			ClientMouseDown(Button, Shift, x, Y);
		}

		private void m_Client_MouseUp(int Button, int Shift, float x, float Y)
		{
			ClientMouseUp(Button, Shift, x, Y);
		}

		private void m_MdiClient_MouseDown(int Button, int Shift, float x, float Y)
		{
			ClientMouseDown(Button, Shift, x, Y);
		}

		private void m_MdiClient_MouseUp(int Button, int Shift, float x, float Y)
		{
			ClientMouseUp(Button, Shift, x, Y);
		}
		public void moveMeHwnd(int hwnd)
		{
			ReleaseCapture();
			SendMessage(m_hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0L);
		}

		public void MoveMe()
		{
			ReleaseCapture();
			SendMessage(m_hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0L);
		}

		private void ClientMouseDown(int Button, int Shift, float x, float Y)
		{
			// Automatically allow user to drag using
			// any portion of form, not just titlebar,
			// when user depresses left mousebutton.
			// Useful for captionless forms.
			if (Button == MouseButtons.Left) {
				if (m_AutoDrag) {
					ReleaseCapture();
					SendMessage(m_hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0L);
				}
			}
		}

		private void ClientMouseUp(int Button, int Shift, float x, float Y)
		{
			// Automatically handle system menu display
			// when user right-clicks anywhere on form.
			// Useful for captionless forms.
			POINTAPI pt = default(POINTAPI);
			// This is relative to the screen, so we can't
			// use the coordinates passed in the event
			GetCursorPos(pt);
			if (Button == MouseButtons.Right) {
				if (m_AutoSysMenu) {
					// Thanks to Klaus Probst for this trick!
					// http://www.vbbox.com/
					ShowSysMenu(pt.x, pt.Y);
				}
			}
		}


		// ************************************************
		//  Public Properties: Read/Write
		// ************************************************
		public bool AutoDrag {

			// Automatically allow user to drag using
			// any portion of form, not just titlebar,
			// when user depresses left mousebutton.
			// Useful for captionless forms.
			get { return m_AutoDrag; }
			set { m_AutoDrag = value; }
		}


		public bool AutoSysMenu {

			// Automatically allow user to drag using
			// any portion of form, not just titlebar,
			// when user depresses left mousebutton.
			// Useful for captionless forms.
			get { return m_AutoSysMenu; }
			set { m_AutoSysMenu = value; }
		}

		public object client {
			get {
				object functionReturnValue = null;
				// Return reference to client.
				if ((m_Client != null)) {
					functionReturnValue = m_Client;
				}
				return functionReturnValue;
			}
			set {
				// Clear cached handle.
				m_hWnd = 0;

				// Store object reference and handle to client.
				if (value is Form) {
					m_Client = value;
					m_hWnd = m_Client.Handle;
				}
			}
		}

		public bool controlBox {
// Return value of WS_SYSMENU bit.
			get { return Convert.ToBoolean(Style() & WS_SYSMENU); }
// Set WS_SYSMENU On or Off as requested.
			set { FlipBit(WS_SYSMENU, value); }
		}

		public bool MaxButton {
// Return value of WS_MAXIMIZEBOX bit.
			get { return Convert.ToBoolean(Style() & WS_MAXIMIZEBOX); }
			set {
				// Set WS_MAXIMIZEBOX On or Off as requested.
				FlipBit(WS_MAXIMIZEBOX, value);
				EnableMenuItem(SysMenuItems.smMaximize, value);
			}
		}

		public bool MinButton {
// Return value of WS_MINIMIZEBOX bit.
			get { return Convert.ToBoolean(Style() & WS_MINIMIZEBOX); }
			set {
				// Set WS_MINIMIZEBOX On or Off as requested.
				FlipBit(WS_MINIMIZEBOX, value);
				EnableMenuItem(SysMenuItems.smMinimize, value);
			}
		}

		public bool Moveable {
// Return whether SC_MOVE menu is enabled.
			get { return !Convert.ToBoolean(GetMenuItemState(GetSystemMenu(m_hWnd, false), GetMenuItemPosition(SysMenuItems.smMove))); }
// Toggle SC_MOVE menu appropriately.
			set { EnableMenuItem(SysMenuItems.smMove, value); }
		}
		public bool Sizeable {
// Return value of WS_THICKFRAME bit.
			get { return Convert.ToBoolean(Style() & WS_THICKFRAME); }
			set {
				// Toggle SC_SIZE menu appropriately,
				// or else it gets removed!
				EnableMenuItem(SysMenuItems.smSize, value);
				// Set WS_THICKFRAME On or Off as requested.
				FlipBit(WS_THICKFRAME, value);
			}
		}
		public bool ShowInTaskbar {
// Return value of WS_EX_APPWINDOW bit.
			get { return Convert.ToBoolean(StyleEx() & WS_EX_APPWINDOW); }
			set {
				// Set WS_EX_APPWINDOW On or Off as requested.
				// Toggling this value requires that we also toggle
				// visibility, flipping the bit while invisible,
				// forcing the taskbar to update on reshow.
				// Using LockWindowUpdate prevents some flicker.
				LockWindowUpdate(m_hWnd);
				ShowWindow(m_hWnd, Constants.vbHide);
				FlipBitEx(WS_EX_APPWINDOW, value);
				ShowWindow(m_hWnd, Constants.vbNormalFocus);
				LockWindowUpdate(0L);
			}
		}



		public bool Titlebar {
// Return value of WS_CAPTION bit.
			get { return Convert.ToBoolean(Style() & WS_CAPTION); }
// Set WS_CAPTION On or Off as requested.
			set { FlipBit(WS_CAPTION, value); }
		}

		public bool ToolWindow {
// Return value of WS_EX_TOOLWINDOW bit.
			get { return Convert.ToBoolean(StyleEx() & WS_EX_TOOLWINDOW); }
// Set WS_EX_TOOLWINDOW On or Off as requested.
			set { FlipBitEx(WS_EX_TOOLWINDOW, value); }
		}

		public bool TopMost {
// Return value of WS_EX_TOPMOST bit.
			get { return Convert.ToBoolean(StyleEx() & WS_EX_TOPMOST); }
			set {
				const var swpFlags = SWP_NOMOVE | SWP_NOSIZE;
				// Unlike most style bits, WS_EX_TOPMOST must be
				// set with SetWindowPos rather than SetWindowLong.
				if (value) {
					SetWindowPos(m_hWnd, HWND_TOPMOST, 0, 0, 0, 0, swpFlags);
				} else {
					SetWindowPos(m_hWnd, HWND_NOTOPMOST, 0, 0, 0, 0, swpFlags);
				}
				// Additional references on VB use of SetWindowPos...
				// BUG: SetWindowPos API Does Not Set Topmost Window in VB
				// -- http://support.microsoft.com/support/kb/articles/Q192/2/54.ASP
				// FIX: TopMost Window Does Not Stay on Top in Design Environment
				// -- http://support.microsoft.com/support/kb/articles/Q150/2/33.ASP
			}
		}

		public bool WhatsThisButton {
// Return value of WS_EX_CONTEXTHELP bit.
			get { return Convert.ToBoolean(StyleEx() & WS_EX_CONTEXTHELP); }
// Set WS_EX_CONTEXTHELP On or Off as requested.
			set { FlipBitEx(WS_EX_CONTEXTHELP, value); }
		}


		// ************************************************
		//  Public Properties: Read-only

		public bool hwnd {
			get { return m_hWnd; }
		}

		// ************************************************
		//  Public Methods
		// ************************************************
		public void EnableMenuItem(SysMenuItems MenuItem, bool Enabled = true)
		{
			// This routine is automatically called whenever the
			// MinButton, MaxButton, or Movable properties are
			// set.
			int hMenu = 0;
			int nPosition = 0;
			//Dim uFlags As Integer
			MENUITEMINFO mii = default(MENUITEMINFO);
			const int HighBit = 0x8000L;

			// Retrieve handle to system menu.
			hMenu = GetSystemMenu(m_hWnd, false);

			// Translate ID to position.
			nPosition = GetMenuItemPosition(MenuItem);

			if (nPosition >= 0) {
				// Initialize structure.
				mii.cbSize = Strings.Len(mii);
				mii.fMask = MIIM_STATE | MIIM_ID | MIIM_DATA | MIIM_TYPE;
				mii.dwTypeData = Strings.StrDup(80, Constants.vbNullChar);
				mii.cch = Strings.Len(mii.dwTypeData);
				GetMenuItemInfo(hMenu, nPosition, MF_BYPOSITION, mii);

				// Set appropriate state.
				if (Enabled) {
					mii.fState = MF_ENABLED;
				} else {
					mii.fState = MF_GRAYED;
				}

				// New ID uses highbit to signify that
				// the menu item is enabled.
				if (Enabled) {
					mii.wID = MenuItem;
				} else {
					mii.wID = MenuItem & !HighBit;
				}

				// Modify the menu!
				mii.fMask = MIIM_STATE | MIIM_ID;
				SetMenuItemInfo(hMenu, nPosition, MF_BYPOSITION, mii);
			}
		}

		public void Redraw()
		{
			// Redraw window with new style.
			const int swpFlags = SWP_FRAMECHANGED | SWP_NOMOVE | SWP_NOZORDER | SWP_NOSIZE;
			SetWindowPos(m_hWnd, 0, 0, 0, 0, 0, swpFlags);
		}

		public void RemoveMenuItem(SysMenuItems MenuItem)
		{
			int hMenu = 0;

			// Retrieve handle to system menu.
			hMenu = GetSystemMenu(m_hWnd, false);

			// Special case processing...
			switch (MenuItem) {
				case SysMenuItems.smClose:
					// when removing the Close menu, also
					// remove the separator over it
					RemoveMenu(hMenu, GetMenuItemPosition(MenuItem) - 1, MF_BYPOSITION);

					break;
				case SysMenuItems.smMinimize:
					// Ensure buttons are consistent.
					this.MinButton = false;

					break;
				case SysMenuItems.smMaximize:
					// Ensure buttons are consistent.
					this.MaxButton = false;
					break;
			}

			// Remove requested entry.
			RemoveMenu(hMenu, MenuItem, MF_BYCOMMAND);
		}

		public void ShowSysMenu(int x, int Y)
		{
			// Must be in screen coordinates.
			SendMessage(m_hWnd, WM_GETSYSMENU, 0, MakeLong(Y, x));
		}

		// ************************************************
		//  Private Methods
		// ************************************************
		private int MakeLong(int WordHi, int WordLo)
		{
			// High word is coerced to Long to allow it to
			// overflow limits of multiplication which shifts
			// it left.
			return (Convert.ToInt64(WordHi) * 0x10000) | (WordLo & 0xffffL);
		}

		private int Style(int NewBits = 0)
		{
			// Attempt to set new style bits.
			if (NewBits) {
				SetWindowLong(m_hWnd, GWL_STYLE, NewBits);
			}
			// Retrieve current style bits.
			return GetWindowLong(m_hWnd, GWL_STYLE);
		}

		private int StyleEx(int NewBits = 0)
		{
			// Attempt to set new style bits.
			if (NewBits) {
				SetWindowLong(m_hWnd, GWL_EXSTYLE, NewBits);
			}
			// Retrieve current style bits.
			return GetWindowLong(m_hWnd, GWL_EXSTYLE);
		}

		private bool FlipBit(int Bit, bool Value)
		{
			int nStyle = 0;

			// Retrieve current style bits.
			nStyle = GetWindowLong(m_hWnd, GWL_STYLE);

			// Attempt to set requested bit On or Off,
			// and redraw
			if (Value) {
				nStyle = nStyle | Bit;
			} else {
				nStyle = nStyle & !Bit;
			}
			SetWindowLong(m_hWnd, GWL_STYLE, nStyle);
			Redraw();

			// Return success code.
			return (nStyle == GetWindowLong(m_hWnd, GWL_STYLE));
		}

		private bool FlipBitEx(int Bit, bool Value)
		{
			int nStyleEx = 0;

			// Retrieve current style bits.
			nStyleEx = GetWindowLong(m_hWnd, GWL_EXSTYLE);

			// Attempt to set requested bit On or Off,
			// and redraw.
			if (Value) {
				nStyleEx = nStyleEx | Bit;
			} else {
				nStyleEx = nStyleEx & !Bit;
			}
			SetWindowLong(m_hWnd, GWL_EXSTYLE, nStyleEx);
			Redraw();

			// Return success code.
			return (nStyleEx == GetWindowLong(m_hWnd, GWL_EXSTYLE));
		}

		private int GetMenuItemPosition(SysMenuItems MenuItem)
		{
			int functionReturnValue = 0;
			int hMenu = 0;
			int ID = 0;
			int i = 0;
			const int HighBit = 0x8000L;

			// Default to returning -1 in case of
			// failure, since menu is 0-based.
			functionReturnValue = -1;

			// Retrieve handle to system menu.
			hMenu = GetSystemMenu(m_hWnd, false);

			// Loop through system menu, scanning
			// for requested standard menu item.
			for (i = 0; i <= GetMenuItemCount(hMenu) - 1; i++) {
				ID = GetMenuItemID(hMenu, i);
				if (ID == MenuItem) {
					// Return position of normal
					// enabled menu item.
					functionReturnValue = i;
					break;
				} else if (ID == (MenuItem & !HighBit)) {
					// This item is disabled.
					// Return position and alter
					// MenuItem with new ID.
					MenuItem = ID;
					functionReturnValue = i;
					break;
				}
			}
			return functionReturnValue;
		}

		private string GetMenuItemText(int hMenu, int nPosition)
		{
			string functionReturnValue = null;
			MENUITEMINFO mii = default(MENUITEMINFO);

			// Initialize structure.
			mii.cbSize = Strings.Len(mii);
			mii.fMask = MIIM_TYPE;
			mii.dwTypeData = Strings.StrDup(80, Constants.vbNullChar);
			mii.cch = Strings.Len(mii.dwTypeData);
			GetMenuItemInfo(hMenu, nPosition, MF_BYPOSITION, mii);

			// Return current menu text
			if (mii.cch > 0) {
				functionReturnValue = Strings.Left(mii.dwTypeData, mii.cch);
			}
			return functionReturnValue;
		}

		private int GetMenuItemState(int hMenu, int nPosition)
		{
			MENUITEMINFO mii = default(MENUITEMINFO);

			// Initialize structure.
			mii.cbSize = Strings.Len(mii);
			mii.fMask = MIIM_STATE;
			GetMenuItemInfo(hMenu, nPosition, MF_BYPOSITION, mii);

			// Return current state.
			return mii.fState;
		}




		public clsFormBorder(Form frm)
		{
			client = frm;

		}
	}
}
