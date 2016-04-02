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
	// Implements the manual sorting of items by columns.
	class mw_ListViewItemComparer : IComparer
	{


		private int col;
		public mw_ListViewItemComparer()
		{
			col = 0;
		}

		public mw_ListViewItemComparer(int column)
		{
			col = column;
		}

		public int Compare(object x, object y)
		{
			 // ERROR: Not supported in C#: OnErrorStatement

			return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
		}
	}
}

