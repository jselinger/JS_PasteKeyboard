﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        timeleftbar.Value = 3600 'Reset auto wipe if used
        counter1 = Delaycounterstart.Value 'Set countdown varable for timmer
        CountdownTimer1.Enabled = True 'start the timer that sends the key

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

        Dim expr As Integer = 300
        If Now > DateSerial(2000, 1, revisiondate + expr) Then
            MsgBox("This version has expired. Please get the Latest version")
            End
        Else
            'MsgBox("This Build expires: " & DateSerial(2000, 1, revisiondate + expr))
            TextBox2.Text = TextBox2.Text & " This Build expires: " & DateSerial(2000, 1, revisiondate + expr)
        End If
    End Sub

    Private Sub CountdownTimer1_Tick(sender As Object, e As EventArgs) Handles CountdownTimer1.Tick
        If counter1 = 0 Then
            CountdownTimer1.Enabled = False
            Sendkey(TextBox1.Text)
            Me.Text = Title1
        Else
            counter1 -= 1
            Me.Text = counter1.ToString
        End If
        timedisplay.Text = counter1.ToString

    End Sub


    Private Sub Buttonmask_Click(sender As Object, e As EventArgs) Handles Buttonmask.Click
        If Buttonmask.Text = "Masked" Then
            Buttonmask.Text = "UN-Masked"
            TextBox1.PasswordChar = ""
        Else
            Buttonmask.Text = "Masked"
            TextBox1.PasswordChar = "*"
        End If
    End Sub

    Private Sub ClearTimer_Tick(sender As Object, e As EventArgs) Handles ClearTimer.Tick
        If timeleftbar.Value < 2 Then
            ClearTimer.Enabled = False
            TextBox1.Text = ""
        Else
            timeleftbar.Value -= 1
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        timeleftbar.Value = 3600
        If TextBox1.TextLength > 0 Then
            ClearTimer.Enabled = True
        Else
            ClearTimer.Enabled = False
        End If

    End Sub
End Class
