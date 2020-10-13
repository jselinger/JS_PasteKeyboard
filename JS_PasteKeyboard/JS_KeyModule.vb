Module JS_KeyModule
    Public Title1 As String
    Public counter1 As Int16 = 10
    Public Function Sendkey(TexttoType As String)

        My.Computer.Keyboard.SendKeys(TexttoType, True)
        Return (0)
    End Function
End Module
