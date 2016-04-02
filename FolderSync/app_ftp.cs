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
using System.Web;
using System.Text;
using System.Security.Cryptography;
using FolderSync.Utilities.FTP;
namespace FolderSync
{

	static class app_ftp
	{


		private static string GenerateHash(string SourceText)
		{
			//Create an encoding object to ensure the encoding standard for the source text
			UnicodeEncoding Ue = new UnicodeEncoding();
			//Retrieve a byte array based on the source text
			byte[] ByteSourceText = Ue.GetBytes(SourceText);
			//Instantiate an MD5 Provider object
			MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
			//Compute the hash value from the source
			byte[] ByteHash = Md5.ComputeHash(ByteSourceText);
			//And convert it to String format for return
			return Convert.ToBase64String(ByteHash);
		}


		public static FTPdirectory GetServerDirList()
		{
			// On Error Resume Next
			//Stop

			return app_main.FTP.ListDirectoryDetail(app_main.glob.Para("frm_options__ftp_dir"));


		}

		public static string GetUrlContent(string url, bool stripWikitext = false)
		{

			string content = TwAjax.getUrlContent(url);

			if (stripWikitext & content.Contains("<!--### WIKITEXT-START ###")) {
				content = content.Substring(content.IndexOf("<!--### WIKITEXT-START ###") + 26);
				content = content.Substring(0, content.Length - 23);
			}

			return content;

		}


		//Function ReadTwFile(ByVal fileSpec As String) As String
		//  Dim cont As String
		//  Dim xPara As Integer = Now.Millisecond * Now.Minute
		//  cont = GetUrlContent("http://teamwiki.de" + fileSpec + "?cache_tricky=" + xPara.ToString, True)
		//  Return getSplitPart(cont)
		//End Function

		public static string getSplitPart(string str)
		{
			string[] Parts = Strings.Split(str, "===[]SPLIT[*#377375890]===");
			if (Parts.Length < 2) {
				return "";
			}
			return Parts[1];
		}

		//Sub WriteTwFile(ByVal fileSpec As String, ByVal newContent As String)
		//  With frm_main
		//    Dim post As Byte()
		//    Dim extraHeader As String
		//    Dim url As String
		//    Dim key As String
		//    key = "b71e3ce0-d667-11dc-95ff-0800200c9a66" + fileSpec
		//    key = GenerateHash(key)
		//    ' der key ist zur zeit bedeutungslos ...

		//    url = "http://teamwiki.de/twiki/write_post.php?filespec=" + fileSpec + "&key=" + key


		//    newContent = HttpUtility.UrlEncode(newContent)
		//    post = StrToByteArray("DATA=" + newContent)
		//    extraHeader = "content-type: application/x-www-form-urlencoded"
		//    .WebBrowser1.Navigate(url, "", post, extraHeader)

		//    Dim wasBusy As Boolean = False, c As Integer = 0
		//    Do
		//      Application.DoEvents()
		//      c += 1
		//      If c > 22222 Then Exit Do
		//      If .WebBrowser1.IsBusy Then wasBusy = True
		//      If .WebBrowser1.IsBusy = False And wasBusy Then Exit Do
		//    Loop

		//  End With
		//End Sub

		// VB.NET to convert a string to a byte array
		public static byte[] StrToByteArray(string str)
		{
			System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
			return encoding.GetBytes(str);
		}
		//StrToByteArray


	}
}
