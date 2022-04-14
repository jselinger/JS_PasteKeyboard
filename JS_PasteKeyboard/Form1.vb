Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        timeleftbar.Value = 14400 '3600 'Reset auto wipe if used
        counter1 = Delaycounterstart.Value 'Set countdown varable for timmer
        CountdownTimer1.Enabled = True 'start the timer that sends the key

        Form1.ActiveForm.Height = 180

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click  'disabled sample code
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
        Title1 = Me.Text 'Store fore later

        Dim revisiondate As Integer = (Application.ProductVersion.Split(".")(2))

        'Dim expr As Integer = 330
        'If Now > DateSerial(2000, 1, revisiondate + expr) Then
        'MsgBox("This version has expired. Please get the Latest version")
        'End
        'Else
        ''MsgBox("This Build expires: " & DateSerial(2000, 1, revisiondate + expr))
        'TextBox2.Text = TextBox2.Text & " This Build expires: " & DateSerial(2000, 1, revisiondate + expr)
        'End If
    End Sub

    Private Sub CountdownTimer1_Tick(sender As Object, e As EventArgs) Handles CountdownTimer1.Tick
        If counter1 = 0 Then
            CountdownTimer1.Enabled = False
            Sendkey(TextBox_Input.Text)
            Me.Text = Title1
        Else
            counter1 -= 1
            Me.Text = counter1.ToString
        End If
        timedisplay.Text = counter1.ToString

    End Sub


    Private Sub Buttonmask_Click(sender As Object, e As EventArgs) Handles Buttonmask.Click
        timeleftbar.Value = 14400 'Reset auto wipe if used
        If Buttonmask.Text = "Masked" Then
            RemaskCounter = 30
            Buttonmask.Text = "UN-Masked"
            TextBox_Input.PasswordChar = ""
            remaskTimer.Enabled = True
        Else
            Buttonmask.Text = "Masked"
            TextBox_Input.PasswordChar = "*"
            remaskTimer.Enabled = False
        End If
    End Sub

    Private Sub ClearTimer_Tick(sender As Object, e As EventArgs) Handles ClearTimer.Tick
        If timeleftbar.Value < 2 Then
            ClearTimer.Enabled = False
            TextBox_Input.Text = ""
        Else
            timeleftbar.Value -= 1
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Input.TextChanged
        timeleftbar.Value = 14400
        If TextBox_Input.TextLength > 0 Then
            ClearTimer.Enabled = True
        Else
            ClearTimer.Enabled = False
        End If

    End Sub

    Private Sub remaskTimer_Tick(sender As Object, e As EventArgs) Handles remaskTimer.Tick
        Buttonmask.Text = "UN-Masked " & RemaskCounter
        RemaskCounter -= 1
        If RemaskCounter < 1 Then
            Buttonmask_Click(sender, e)
        End If
    End Sub

    Private Sub BClearSpace_Click(sender As Object, e As EventArgs) Handles BClearSpace.Click
        TextBox_Input.Text = TextBox_Input.Text.Trim
    End Sub
End Class
