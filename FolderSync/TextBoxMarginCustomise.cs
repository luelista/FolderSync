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
namespace FolderSync.vbAccelerator.Components.Controls
{


	/// <summary>
	/// A class for adding right and left margins to a TextBox
	/// or the embedded TextBox within a DropDown ComboBox.
	/// The margin can display an m_icon, a m_control or can
	/// be drawn using a custom routine implemented by the
	/// user.
	/// </summary>
	public class TextBoxMarginCustomise : NativeWindow
	{


		#region "Unmanaged Code"
		[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
		private struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}
		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]

		private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]

		private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, 		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPTStr)]
string lpszClass, 		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPTStr)]
string lpszWindow);
		[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
		private static extern int GetWindowLong(IntPtr hWnd, int dwStyle);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern IntPtr GetDC(IntPtr hwnd);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]

		private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]

		private static extern int GetClientRect(IntPtr hwnd, ref RECT rc);
		[DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern int GetWindowRect(IntPtr hwnd, ref RECT rc);

		private const int EC_LEFTMARGIN = 0x1;
		private const int EC_RIGHTMARGIN = 0x2;
		private const int EC_USEFONTINFO = 0xffff;
		private const int EM_SETMARGINS = 0xd3;

		private const int EM_GETMARGINS = 0xd4;

		private const int WM_PAINT = 0xf;
		private const int WM_SETFOCUS = 0x7;

		private const int WM_KILLFOCUS = 0x8;

		private const int WM_SETFONT = 0x30;
		private const int WM_MOUSEMOVE = 0x200;
		private const int WM_LBUTTONDOWN = 0x201;
		private const int WM_RBUTTONDOWN = 0x204;
		private const int WM_MBUTTONDOWN = 0x207;
		private const int WM_LBUTTONUP = 0x202;
		private const int WM_RBUTTONUP = 0x205;
		private const int WM_MBUTTONUP = 0x208;
		private const int WM_LBUTTONDBLCLK = 0x203;
		private const int WM_RBUTTONDBLCLK = 0x206;

		private const int WM_MBUTTONDBLCLK = 0x209;
		private const int WM_KEYDOWN = 0x100;
		private const int WM_KEYUP = 0x101;

		private const int WM_CHAR = 0x102;
		private const int GWL_EXSTYLE = (-20);
		private const int WS_EX_RIGHT = 0x1000;
		private const int WS_EX_LEFT = 0x0;
		private const int WS_EX_RTLREADING = 0x2000;
		private const int WS_EX_LTRREADING = 0x0;
		private const int WS_EX_LEFTSCROLLBAR = 0x4000;

		private const int WS_EX_RIGHTSCROLLBAR = 0x0;
		#endregion

		#region "Member Variables"
		private System.Windows.Forms.ImageList m_imageList = null;
		private int m_icon = -1;
		private Control m_control = null;
		private ITextBoxMarginCustomisePainter m_customPainter = null;
			#endregion
		private int customWidth = 0;

		/// <summary>
		/// Gets whether a Window is <c>RightToLeft.Yes</c> from
		/// its <c>Handle</c>.
		/// </summary>
		/// <param name="theHandle">Handle of window to check.</param>
		/// <returns><c>True</c> if Window is RightToLeft, <c>False</c> otherwise.</returns>
		private static bool IsRightToLeft(IntPtr theHandle)
		{
			int style = GetWindowLong(theHandle, GWL_EXSTYLE);
			return ((style & WS_EX_RIGHT) == WS_EX_RIGHT) | ((style & WS_EX_RTLREADING) == WS_EX_RTLREADING) | ((style & WS_EX_LEFTSCROLLBAR) == WS_EX_LEFTSCROLLBAR);
		}

		/// <summary>
		/// Gets the far margin of a TextBox m_control or the
		/// TextBox contained within a ComboBox.
		/// </summary>
		/// <param name="ctl">The Control to get the far margin
		/// for</param>
		/// <returns>Far margin, in pixels.</returns>
		public static int FarMargin(Control ctl)
		{

			IntPtr theHandle = ctl.Handle;

			if (ctl is System.Windows.Forms.ComboBox) {
				theHandle = ComboEdithWnd(theHandle);
			}

			return FarMargin(theHandle);

		}

		private static int FarMargin(IntPtr theHandle)
		{
			int theMargin = SendMessage(theHandle, EM_GETMARGINS, 0, 0);
			if ((IsRightToLeft(theHandle))) {
				theMargin = theMargin & 0xffff;
			} else {
				theMargin = (theMargin / 0x10000);
			}
			return theMargin;
		}


		/// <summary>
		/// Sets the far margin of a TextBox m_control or the
		/// TextBox contained within a ComboBox.
		/// </summary>
		/// <param name="ctl">The Control to set the far margin
		/// for</param>
		/// <param name="margin">New far margin in pixels, or -1
		/// to use the default far margin.</param>
		public static void FarMargin(Control ctl, int margin)
		{
			IntPtr theHandle = ctl.Handle;
			if (ctl is System.Windows.Forms.ComboBox) {
				theHandle = ComboEdithWnd(theHandle);
			}
			FarMargin(theHandle, margin);
		}

		private static void FarMargin(IntPtr theHandle, int margin)
		{
			int message = (IsRightToLeft(theHandle) ? EC_LEFTMARGIN : EC_RIGHTMARGIN);
			if ((message == EC_LEFTMARGIN)) {
				margin = margin + 0xffff;
			} else {
				margin = margin * 0x10000;
			}
			SendMessage(theHandle, EM_SETMARGINS, message, margin);
		}

		/// <summary>
		/// Gets the near margin of a TextBox m_control or the
		/// TextBox contained within a ComboBox.
		/// </summary>
		/// <param name="ctl">The Control to get the near margin
		/// for</param>
		/// <returns>Near margin, in pixels.</returns>
		public static int NearMargin(Control ctl)
		{
			IntPtr theHandle = ctl.Handle;
			if (ctl is System.Windows.Forms.ComboBox) {
				theHandle = ComboEdithWnd(theHandle);
			}
			return NearMargin(theHandle);
		}

		private static int NearMargin(IntPtr theHandle)
		{
			int theMargin = SendMessage(theHandle, EM_GETMARGINS, 0, 0);
			if ((IsRightToLeft(theHandle))) {
				theMargin = theMargin / 0x10000;
			} else {
				theMargin = theMargin & 0xffff;
			}
			return theMargin;
		}

		/// <summary>
		/// Sets the near margin of a TextBox m_control or the
		/// TextBox contained within a ComboBox.
		/// </summary>
		/// <param name="ctl">The Control to set the near margin
		/// for</param>
		/// <param name="margin">New near margin in pixels, or -1
		/// to use the default near margin.</param>
		public static void NearMargin(Control ctl, int margin)
		{
			IntPtr theHandle = ctl.Handle;
			if (ctl is System.Windows.Forms.ComboBox) {
				theHandle = ComboEdithWnd(theHandle);
			}
			NearMargin(theHandle, margin);
		}

		private static void NearMargin(IntPtr theHandle, int margin)
		{
			int message = (IsRightToLeft(theHandle) ? EC_RIGHTMARGIN : EC_LEFTMARGIN);
			if ((message == EC_LEFTMARGIN)) {
				margin = margin & 0xffff;
			} else {
				margin = margin * 0x10000;
			}
			SendMessage(theHandle, EM_SETMARGINS, message, margin);
		}

		/// <summary>
		/// Gets the handle of the TextBox contained within a 
		/// ComboBox m_control.
		/// </summary>
		/// <param name="handle">The ComboBox window handle.</param>
		/// <returns>The handle of the contained text box.</returns>
		public static IntPtr ComboEdithWnd(IntPtr theHandle)
		{
			IntPtr findHandle = FindWindowEx(theHandle, IntPtr.Zero, "EDIT", Constants.vbNullString);
			return findHandle;
		}

		/// <summary>
		/// Attaches an instance of this class to a ComboBox m_control.
		/// The m_control must have the "DropDown" style so it has a 
		/// TextBox.
		/// </summary>
		/// <param name="comboBox">ComboBox with DropDown style to
		/// attach to.</param>
		/// <remarks>Use the <see cref="AssignHandle"/> method to attach 
		/// this class to an arbitrary TextBox m_control using its
		/// handle.</remarks>
		public void Attach(System.Windows.Forms.ComboBox comboBox)
		{
			if (!(this.Handle.Equals(IntPtr.Zero))) {
				this.ReleaseHandle();
			}
			IntPtr theHandle = ComboEdithWnd(comboBox.Handle);
			this.AssignHandle(theHandle);
			setMargin();
		}

		/// <summary>
		/// Attaches an instance of this class to a TextBox m_control.
		/// </summary>
		/// <param name="textBox">TextBox to attach to.</param>
		/// <remarks>Use the <see cref="AssignHandle"/> method to attach 
		/// this class to an arbitrary TextBox m_control using its
		/// handle.</remarks>
		public void Attach(System.Windows.Forms.TextBox textBox)
		{
			if (!(this.Handle.Equals(IntPtr.Zero))) {
				this.ReleaseHandle();
			}
			this.AssignHandle(textBox.Handle);
			setMargin();
		}

		/// <summary>
		/// Gets/sets the ImageList used to draw icons in the control.
		/// </summary>
		public System.Windows.Forms.ImageList ImageList {
			get { return m_imageList; }
			set {
				m_imageList = value;
				setMargin();
			}
		}

		/// <summary>
		/// Gets/sets the 0-based icon index to draw in the control.
		/// If the index is set < 0 then the icon is not drawn.
		/// </summary>
		public int Icon {
			get { return m_icon; }
			set {
				m_icon = value;
				setMargin();
			}
		}

		/// <summary>
		/// Gets/sets the control to be displayed in the near margin.
		/// The <see cref="ImageList"/> property must be <c>Nothing</c> if you
		/// want to display a m_control.
		/// </summary>
		public System.Windows.Forms.Control Control {
			get { return m_control; }
			set {
				m_control = value;
				setMargin();
			}
		}


		/// <summary>
		/// Gets/sets a class which implements the <see cref="ITextBoxMarginCustomisePainter "/>
		/// interface to perform customised painting in the margin.
		/// The <see cref="ImageList"/> and <see cref="Control"/> properties must 
		/// be <c>Nothing</c> if you want to use this technique.
		/// </summary>
		public ITextBoxMarginCustomisePainter CustomPainter {
			get { return m_customPainter; }
			set {
				m_customPainter = value;
				setMargin();
			}
		}


		/// <summary>
		/// Sets the near margin to accommodate the specified m_control.
		/// </summary>
		private void setMargin()
		{
			if (!(this.Handle.Equals(IntPtr.Zero))) {
				if ((m_control != null)) {
					NearMargin(this.Handle, m_control.Width + 4);
					moveControl();
				} else if ((m_icon > -1)) {
					if ((m_imageList != null)) {
						NearMargin(this.Handle, m_imageList.ImageSize.Width + 4);
					} else {
						NearMargin(this.Handle, 20);
					}
				} else if ((CustomPainter != null)) {
					customWidth = CustomPainter.GetMarginWidth();
					NearMargin(this.Handle, customWidth);
				}
			}
		}

		/// <summary>
		/// Moves the contained m_control to the appropriate 
		/// position
		/// </summary>
		private void moveControl()
		{
			if ((m_control != null)) {
				Point currentLocation = m_control.Location;
				RECT rcWindow = new RECT();
				GetWindowRect(this.Handle, ref rcWindow);
				Point moveTo = new Point(rcWindow.left + 2, rcWindow.top + ((rcWindow.bottom - rcWindow.top) - m_control.Height) / 2);
				if ((IsRightToLeft(this.Handle))) {
					moveTo.X = rcWindow.right - m_control.Width - 2;
				}
				moveTo = m_control.Parent.PointToClient(moveTo);
				if (!(currentLocation.Equals(moveTo))) {
					m_control.Location = moveTo;
					m_control.BringToFront();
				}
			}
		}

		/// <summary>
		/// Calls the base WndProc and performs WM_PAINT
		/// processing to draw the m_icon if necessary.
		/// </summary>
		/// <param name="m">Windows Message</param>

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if ((m_control == null)) {
				switch (m.Msg) {
					case WM_SETFONT:
						setMargin();
						break;
					case WM_PAINT:
						RePaint();
						break;
					case WM_SETFOCUS:
					case WM_KILLFOCUS:
						RePaint();
						break;
					case WM_LBUTTONDOWN:
					case WM_RBUTTONDOWN:
					case WM_MBUTTONDOWN:
						RePaint();
						break;
					case WM_LBUTTONUP:
					case WM_RBUTTONUP:
					case WM_MBUTTONUP:
						RePaint();
						break;
					case WM_LBUTTONDBLCLK:
					case WM_RBUTTONDBLCLK:
					case WM_MBUTTONDBLCLK:
						RePaint();
						break;
					case WM_KEYDOWN:
					case WM_KEYUP:
					case WM_CHAR:
						RePaint();
						break;
					case WM_MOUSEMOVE:
						if (!(m.WParam.Equals(IntPtr.Zero))) {
							RePaint();
						}
						break;
				}
			} else {
				switch (m.Msg) {
					case WM_PAINT:
						moveControl();
						break;
				}
			}
		}

		/// <summary>
		/// Paints the control if necessary:
		/// </summary>
		private void RePaint()
		{
			 // ERROR: Not supported in C#: OnErrorStatement


			if ((((m_icon >= 0) & (m_imageList != null)) | (m_customPainter != null))) {
				RECT rcClient = new RECT();
				GetClientRect(this.Handle, ref rcClient);
				bool rightToLeft = IsRightToLeft(this.Handle);

				IntPtr theHandle = this.Handle;
				IntPtr hdc = GetDC(theHandle);
				Graphics gfx = Graphics.FromHdc(hdc);

				if ((m_customPainter == null)) {
					int itemSize = m_imageList.ImageSize.Height;
					Point pt = new Point(0, rcClient.top + (rcClient.bottom - rcClient.top - itemSize) / 2);
					if ((rightToLeft)) {
						pt.X = rcClient.right - itemSize - 2;
					} else {
						pt.X = 2;
					}

					m_imageList.Draw(gfx, pt.X, pt.Y, m_icon);

				} else {
					Rectangle rcDraw = new Rectangle(new Point(0, 0), new Size(customWidth, rcClient.bottom - rcClient.top));
					m_customPainter.Draw(gfx, rcDraw, rightToLeft);
				}

				gfx.Dispose();
				ReleaseDC(theHandle, hdc);
			}

		}

		/// <summary>
		/// Constructs a new instance of this class
		/// </summary>
		public TextBoxMarginCustomise()
		{
			// intentionally blank
		}

	}

	/// <summary>
	/// An interface which users of the <see cref="TextBoxMarginCustomise"/>
	/// class can use to provide a customised painting routine for the
	/// margin area.  Create an instance of this class and install it
	/// using the <see cref="TextBoxMarginCustomise.CustomPainter"/>
	/// accessor.
	/// </summary>
	public interface ITextBoxMarginCustomisePainter
	{

		/// <summary>
		/// Called to obtain the width of the margin.
		/// </summary>
		/// <returns>Width of the margin</returns>
		int GetMarginWidth();

		/// <summary>
		/// Called whenever the margin area needs to
		/// be repainted.
		/// </summary>
		/// <param name="gfx">Graphics object to paint on.</param>
		/// <param name="rcDraw">Boundary of margin area.</param>
		/// <param name="rightToLeft">Whether the m_control is right 
		/// to left or not</param>

		void Draw(Graphics gfx, Rectangle rcDraw, bool rightToLeft);
	}


}
