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
using System.IO;

namespace FolderSync
{
	public class cls_globPara
	{

		//: ========== Globale Variablen ==========================================

		string m_paraFileSpec;
		Dictionary<string, string> m_content = new Dictionary<string, string>();

		const string tabDelimiter = "<=" + Constants.vbTab;


		//: ========== Konstruktor + Destruktor ==================================

		public cls_globPara(string fileSpec = "")
		{
			m_paraFileSpec = fileSpec;
			if (string.IsNullOrEmpty(m_paraFileSpec)) {
				m_paraFileSpec = fp(FolderSync.My.MyProject.Application.Info.DirectoryPath, FolderSync.My.MyProject.Application.Info.AssemblyName + ".ini");
			}
			string folder = FolderSync.My.MyProject.Computer.FileSystem.GetParentPath(m_paraFileSpec);
			System.IO.Directory.CreateDirectory(folder);

			readFile();
		}
		~cls_globPara()
		{
			saveParaFile();
		}



		//: ========== Haupteigenschaft ========================

		public string this[string key] {
			get {
				return Para(key, "");
			}
			set {
				if (m_content.ContainsKey(key)) {
					m_content[key] = value;
				} else {
					m_content.Add(key, value);
				}
			}
		}
		
		public string Para(string key) {
			return this.Para(key,"");
		}
		public string Para(string key, string def) {
				string functionReturnValue = null;
				if (m_content.ContainsKey(key)) {
					functionReturnValue = m_content[key];
				} else {
					functionReturnValue = def;
				}
				return functionReturnValue;
		}


		//: ========== Hilfsfunktionen ========================

		public string appPath()
		{
			return fp(FolderSync.My.MyProject.Computer.FileSystem.GetParentPath(Application.ExecutablePath));
		}
		public object fp(string path, string fileName = "")
		{
			return path + (path.EndsWith("\\") ? "" : "\\") + fileName;
		}

		public object fpUNIX(string path, string fileName = "")
		{
			return path + (path.EndsWith("/") ? "" : "/") + fileName;
		}


		public bool Contains(string key)
		{
			return m_content.ContainsKey(key);

		}



		//: ========== Form-Tools ========================

		public void readFormPos(Form frm, bool readSize = true)
		{
			try {
				string paraName = frm.Name.ToLower() + "__" + "Rect";
				string[] formPos = Strings.Split(this.para[paraName], ";");
				frm.Left = Convert.ToInt32(formPos[0]);
				frm.Top = Convert.ToInt32(formPos[1]);
				if (readSize) {
					frm.Width = Convert.ToInt32(formPos[2]);
					frm.Height = Convert.ToInt32(formPos[3]);
				}


			} catch (Exception ex) {
			}
		}

		public void saveFormPos(Form frm)
		{
			string formPos = null;

			var _with1 = frm;
			if (_with1.WindowState == FormWindowState.Minimized)
				_with1.WindowState = FormWindowState.Normal;
			formPos = _with1.Left.ToString + ";" + _with1.Top.ToString + ";" + _with1.Width.ToString + ";" + _with1.Height.ToString;
			string paraName = frm.Name.ToLower() + "__" + "Rect";
			this.para[paraName] = formPos;
		}

		public void readTuttiFrutti(Form frm)
		{
			recursive_readTuttiFrutti(frm, frm);
		}

		public void saveTuttiFrutti(Form frm)
		{
			recursive_saveTuttiFrutti(frm, frm);
		}


		public void recursive_readTuttiFrutti(Form frm, Control ctrl)
		{
			string typ = null;
			string prefix = frm.Name + "__";
			foreach (object subctrl in ctrl.Controls) {
				if (subctrl.Controls.Count() > 0)
					recursive_readTuttiFrutti(frm, subctrl);
				try {
					if (!Contains(prefix + subctrl.Name))
						continue;

					typ = subctrl.GetType().ToString();

					if (typ == "System.Windows.Forms.TextBox") {
						subctrl.Text = this.para[prefix + subctrl.Name];
					}
					if (typ == "System.Windows.Forms.ComboBox") {
						subctrl.Text = this.para[prefix + subctrl.Name];
					}
					if (typ == "System.Windows.Forms.CheckBox") {
						subctrl.Checked = (this.para[prefix + subctrl.Name] == "TRUE");
					}
					if (typ == "System.Windows.Forms.SplitContainer") {
						subctrl.SplitterDistance = this.para[prefix + subctrl.Name];
					}
					if (typ == "System.Windows.Forms.NumericUpDown") {
						subctrl.Value = Conversion.Val(this.para[prefix + subctrl.Name]);
					}
					if (typ == "System.Windows.Forms.RadioButton") {
						string[] paras = Strings.Split(subctrl.Name, "__");
						if (this.para[prefix + paras[0]] == paras[1]) {
							subctrl.Checked = true;
						} else {
							subctrl.@checked = false;
						}
					}
				} catch {
				}
			}
		}
		public void recursive_saveTuttiFrutti(Form frm, Control ctrl)
		{
			string typ = null;
			//Stop
			string prefix = frm.Name + "__";
			foreach (Control subctrl in ctrl.Controls) {
				typ = subctrl.GetType().ToString();

				if (typ == "System.Windows.Forms.TextBox") {
					this.para[prefix + subctrl.Name] = ((TextBox)subctrl).Text;
				}
				if (typ == "System.Windows.Forms.ComboBox") {
					this.para[prefix + subctrl.Name] = ((ComboBox)subctrl).Text;
				}
				if (typ == "System.Windows.Forms.NumericUpDown") {
					this.para[prefix + subctrl.Name] = ((NumericUpDown)subctrl).Value;
				}
				if (typ == "System.Windows.Forms.CheckBox") {
					this.para[prefix + subctrl.Name] = (((CheckBox)subctrl).Checked ? "TRUE" : "FALSE");
				}
				if (typ == "System.Windows.Forms.SplitContainer") {
					this.para[prefix + subctrl.Name] = ((SplitContainer)subctrl).SplitterDistance.ToString();
				}
				if (typ == "System.Windows.Forms.RadioButton") {
					RadioButton radioBox = subctrl;
					if (radioBox.Checked) {
						string[] paras = Strings.Split(subctrl.Name, "__");
						this.para[prefix + paras[0]] = paras[1];
					}
				}

				if (subctrl.Controls.Count > 0)
					recursive_saveTuttiFrutti(frm, subctrl);
			}
		}


		//: ========== Private Funktionen ====================

		private void readFile()
		{
			if (!File.Exists(m_paraFileSpec))
				return;

			try {
				string[] cont = Strings.Split(FolderSync.My.MyProject.Computer.FileSystem.ReadAllText(m_paraFileSpec), Constants.vbNewLine);
	
				string[] line = null;
				string lineString = null;
				foreach (string lineString_loopVariable in cont) {
					lineString = lineString_loopVariable;
					line = Strings.Split(lineString, tabDelimiter);
					if (line.Length < 2)
						continue;
	
					m_content.Add(line[0], Strings.Replace(line[1], "|²ZS³|", Constants.vbNewLine));
					Debug.Print(lineString);
					//Stop
				}

			}catch(Exception ex) {
				Interaction.MsgBox("beim Laden der Einstellungen ist ein Fehler aufgetreten:" + Constants.vbNewLine + Err().Description + Constants.vbNewLine + "(cls_globPara)");
			}

		}

		public void saveParaFile()
		{
			string cont = "";
			string key = null;
			string item = null;

			foreach (string key_loopVariable in m_content.Keys) {
				key = key_loopVariable;
				item = m_content[key];
				item = Strings.Replace(item, Constants.vbNewLine, "|²ZS³|");
				cont += key + tabDelimiter + item + tabDelimiter + Constants.vbNewLine;
			}
			//MsgBox(cont)
			FolderSync.My.MyProject.Computer.FileSystem.WriteAllText(m_paraFileSpec, cont, false);
		}




	}
}
