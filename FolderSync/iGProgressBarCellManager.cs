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
using TenTec.Windows.iGridLib;
namespace FolderSync
{

	public class iGProgressBarCellManager
	{

		public void Attach(iGrid pGrid, iGCol pCol)
		{
			pCol.CellStyle.CustomDrawFlags = pCol.CellStyle.CustomDrawFlags | iGCustomDrawFlags.Foreground;
			pGrid.CustomDrawCellForeground += CustomDrawCellForeground;
		}

		private void CustomDrawCellForeground(object sender, iGCustomDrawCellEventArgs e)
		{
			iGrid grid = (iGrid)sender;

			object myObjValue = grid.Cells[e.RowIndex, e.ColIndex].Value;

			if (myObjValue == null) {
				return;
			}

			string textDesc = null;
			Rectangle myBounds = e.Bounds;
			myBounds.Inflate(-2, -2);
			myBounds.Width = myBounds.Width - 1;
			myBounds.Height = myBounds.Height - 1;
			if ((myBounds.Width > 0)) {
				e.Graphics.FillRectangle(Brushes.Bisque, myBounds);

				double myValue = 0;
				try {
					myValue = Convert.ToDouble(myObjValue);
					textDesc = "";
				} catch {
					myValue = 0;
					textDesc = myObjValue;
				}

				int myWidth = Convert.ToInt32(myBounds.Width * myValue);
				e.Graphics.FillRectangle(Brushes.SandyBrown, myBounds.X, myBounds.Y, myWidth, myBounds.Height);

				e.Graphics.DrawRectangle(Pens.SaddleBrown, myBounds);

				StringFormat myStringFormat = new StringFormat();
				myStringFormat.Alignment = StringAlignment.Center;
				myStringFormat.LineAlignment = StringAlignment.Center;
				if (string.IsNullOrEmpty(textDesc))
					textDesc = string.Format("{0:F2}%", myValue * 100);
				e.Graphics.DrawString(textDesc, grid.Font, SystemBrushes.ControlText, new Rectangle(myBounds.X, myBounds.Y, myBounds.Width, myBounds.Height), myStringFormat);
			}
		}

	}
}
