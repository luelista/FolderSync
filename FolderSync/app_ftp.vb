Imports System.Web
Imports System.Text
Imports System.Security.Cryptography
Imports FolderSync.Utilities.FTP

Module app_ftp


  Private Function GenerateHash(ByVal SourceText As String) As String
    'Create an encoding object to ensure the encoding standard for the source text
    Dim Ue As New UnicodeEncoding()
    'Retrieve a byte array based on the source text
    Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
    'Instantiate an MD5 Provider object
    Dim Md5 As New MD5CryptoServiceProvider()
    'Compute the hash value from the source
    Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
    'And convert it to String format for return
    Return Convert.ToBase64String(ByteHash)
  End Function


  Function GetServerDirList() As FTPDirectory
    ' On Error Resume Next
    'Stop

    Return FTP.ListDirectoryDetail(glob.para("frm_options__ftp_dir"))


  End Function

  Function GetUrlContent(ByVal url As String, Optional ByVal stripWikitext As Boolean = False) As String

    Dim content As String = TwAjax.getUrlContent(url)

    If stripWikitext And content.Contains("<!--### WIKITEXT-START ###") Then
      content = content.Substring(content.IndexOf("<!--### WIKITEXT-START ###") + 26)
      content = content.Substring(0, content.Length - 23)
    End If

    GetUrlContent = content

  End Function


  'Function ReadTwFile(ByVal fileSpec As String) As String
  '  Dim cont As String
  '  Dim xPara As Integer = Now.Millisecond * Now.Minute
  '  cont = GetUrlContent("http://teamwiki.de" + fileSpec + "?cache_tricky=" + xPara.ToString, True)
  '  Return getSplitPart(cont)
  'End Function

  Function getSplitPart(ByVal str As String) As String
    Dim Parts() As String = Split(str, "===[]SPLIT[*#377375890]===")
    If Parts.Length < 2 Then
      Return ""
    End If
    Return Parts(1)
  End Function

  'Sub WriteTwFile(ByVal fileSpec As String, ByVal newContent As String)
  '  With frm_main
  '    Dim post As Byte()
  '    Dim extraHeader As String
  '    Dim url As String
  '    Dim key As String
  '    key = "b71e3ce0-d667-11dc-95ff-0800200c9a66" + fileSpec
  '    key = GenerateHash(key)
  '    ' der key ist zur zeit bedeutungslos ...

  '    url = "http://teamwiki.de/twiki/write_post.php?filespec=" + fileSpec + "&key=" + key


  '    newContent = HttpUtility.UrlEncode(newContent)
  '    post = StrToByteArray("DATA=" + newContent)
  '    extraHeader = "content-type: application/x-www-form-urlencoded"
  '    .WebBrowser1.Navigate(url, "", post, extraHeader)

  '    Dim wasBusy As Boolean = False, c As Integer = 0
  '    Do
  '      Application.DoEvents()
  '      c += 1
  '      If c > 22222 Then Exit Do
  '      If .WebBrowser1.IsBusy Then wasBusy = True
  '      If .WebBrowser1.IsBusy = False And wasBusy Then Exit Do
  '    Loop

  '  End With
  'End Sub

  ' VB.NET to convert a string to a byte array
  Public Function StrToByteArray(ByVal str As String) As Byte()
    Dim encoding As New System.Text.ASCIIEncoding()
    Return encoding.GetBytes(str)
  End Function 'StrToByteArray


End Module
