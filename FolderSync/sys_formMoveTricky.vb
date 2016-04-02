Imports System.Runtime.InteropServices

Module sys_formMoveTricky
  Const WM_NCLBUTTONDOWN As Integer = &HA1
  'Const HTCAPTION As Integer = 2
  Const HTCAPTION As Integer = &H2

  Declare Function SendMessageA Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As IntPtr, _
   ByVal wParam As IntPtr, ByRef lParam As IntPtr) As IntPtr

  <DllImport("user32.dll")> _
  Private Function ReleaseCapture() As Boolean
  End Function

  Sub FormMoveTricky(ByVal hWnd As IntPtr)
    ReleaseCapture()
    SendMessageA(hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&)

  End Sub




End Module
