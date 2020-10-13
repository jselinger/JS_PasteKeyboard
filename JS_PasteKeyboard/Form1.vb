Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter1 = Delaycounterstart.Value
        CountdownTimer1.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ProcID As Integer
        ' Start the Notepad application, and store the process id.
        ProcID = Shell("NOTEPAD.EXE", AppWinStyle.NormalFocus)
        ' Activate the Notepad application.
        AppActivate(ProcID)
        ' Send the keystrokes to the Notepad application.
        My.Computer.Keyboard.SendKeys("I ", True)
        My.Computer.Keyboard.SendKeys("♥", True)
        My.Computer.Keyboard.SendKeys(" Visual Basic!", True)
        ' The sentence I ♥ Visual Basic! is printed on Notepad.
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text &= " V" & Application.ProductVersion


        Dim revisiondate As Integer = (Application.ProductVersion.Split(".")(2))

        Dim expr As Integer = 20
        If Now > DateSerial(2000, 1, revisiondate + expr) Then
            MsgBox("This version has expired. Please get the Latest version")
            End
        Else
            'MsgBox("This Build expires: " & DateSerial(2000, 1, revisiondate + 90))
            TextBox2.Text = TextBox2.Text & " This Build expires: " & DateSerial(2000, 1, revisiondate + expr)
        End If
    End Sub

    Private Sub CountdownTimer1_Tick(sender As Object, e As EventArgs) Handles CountdownTimer1.Tick
        If counter1 = 0 Then
            CountdownTimer1.Enabled = False
            Sendkey(TextBox1.Text)
        Else
            counter1 -= 1
        End If
        timedisplay.Text = counter1.ToString

    End Sub


End Class
