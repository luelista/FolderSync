Imports System.Web
Imports System.Runtime.InteropServices
Public Class TwAjax

  <DllImport("urlmon.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
  Public Shared Function URLDownloadToFile(<MarshalAs(UnmanagedType.IUnknown)> _
  ByVal pCaller As Object, <MarshalAs(UnmanagedType.LPWStr)> _
  ByVal szURL As String, <MarshalAs(UnmanagedType.LPWStr)> _
  ByVal szFileName As String, ByVal dwReserved As Int32, ByVal lpfnCB As IntPtr) As Int32
  End Function
  Public Declare Function DeleteUrlCacheEntry Lib "Wininet.dll" _
    Alias "DeleteUrlCacheEntryA" _
  (ByVal lpszUrlName As String) As Integer


  Public Shared ReadOnly Property ajaxURL() As String
    Get
      Return glob.para("frm_options__twajax_url", "http://teamwiki.de/twiki/vb_tool.php")
    End Get
  End Property

  Public Shared Function getUrlContent(ByVal url As String) As String
    Dim xmlhttp As Object = CreateObject("MSXML2.ServerXMLHTTP")
    xmlhttp.Open("GET", url, True)
    xmlhttp.send("")

    While xmlhttp.ReadyState <> 4
      idle()
    End While
    'Stop
    getUrlContent = xmlhttp.ResponseText
    xmlhttp = Nothing
  End Function


  Public Shared Function postUrl(ByVal url As String, ByVal post As String) As String
    Dim xmlhttp As Object = CreateObject("MSXML2.ServerXMLHTTP")
    xmlhttp.Open("POST", url, True)
    xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded")
    xmlhttp.send("" + post)

    While xmlhttp.ReadyState <> 4
      idle()
    End While

    postUrl = xmlhttp.ResponseText
    xmlhttp = Nothing
  End Function


  Public Shared Sub idle(Optional ByVal sleepTime As Integer = 10)
    System.Threading.Thread.Sleep(sleepTime)
    Application.DoEvents()
  End Sub


  Public Shared Sub SaveFile(ByVal appName As String, ByVal fileName As String, ByVal content As String, Optional ByRef errMes As String = "")
    Dim strURL As String
    strURL = TwAjax.ajaxURL + "?m=save&app=" + appName + "&file=" + fileName

    errMes = postUrl(strURL, "DATA=" + HttpUtility.UrlEncode(content))
  End Sub


  Public Shared Function ReadFile(ByVal appName As String, ByVal fileName As String) As String
    Dim strURL As String
    strURL = TwAjax.ajaxURL + "?m=read&app=" + appName + "&file=" + fileName

    ReadFile = getUrlContent(strURL)
  End Function
End Class

