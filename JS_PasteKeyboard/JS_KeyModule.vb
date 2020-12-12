Imports System.Text.RegularExpressions
Module JS_KeyModule
    Public Title1 As String
    Public counter1 As Int16 = 10  'Countdown Timer for typing keys
    Public RemaskCounter As Int16 = 30  'Countdown Timer for remasking password

    Public Function Sendkey(TexttoType As String)
        TexttoType = Regex.Replace(TexttoType, "[+^%~()\\{\\}]", "{$0}")  'escape special characters for sendkey
        My.Computer.Keyboard.SendKeys(TexttoType, True)
        Return (0)
    End Function
End Module
