﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CountdownTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Delaycounterstart = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timedisplay = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.Delaycounterstart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start Countdown"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(35, 52)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 97)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Text:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(339, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "notepad Test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CountdownTimer1
        '
        Me.CountdownTimer1.Interval = 1000
        '
        'Delaycounterstart
        '
        Me.Delaycounterstart.Location = New System.Drawing.Point(372, 26)
        Me.Delaycounterstart.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Delaycounterstart.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Delaycounterstart.Name = "Delaycounterstart"
        Me.Delaycounterstart.Size = New System.Drawing.Size(62, 20)
        Me.Delaycounterstart.TabIndex = 4
        Me.Delaycounterstart.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Seconds to Wait:"
        '
        'timedisplay
        '
        Me.timedisplay.AutoSize = True
        Me.timedisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedisplay.Location = New System.Drawing.Point(148, 10)
        Me.timedisplay.Name = "timedisplay"
        Me.timedisplay.Size = New System.Drawing.Size(31, 33)
        Me.timedisplay.TabIndex = 6
        Me.timedisplay.Text = "_"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(35, 166)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(368, 76)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "(1) Paste Text into Box Above" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(2) Set seconds to Wait" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(3) Press Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(4) Swit" &
    "ch curser to window and place where you want the password pasted"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 247)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.timedisplay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Delaycounterstart)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(472, 286)
        Me.MinimumSize = New System.Drawing.Size(340, 194)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "(JS) Paste > Keyboard"
        CType(Me.Delaycounterstart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CountdownTimer1 As Timer
    Friend WithEvents Delaycounterstart As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents timedisplay As Label
    Friend WithEvents TextBox2 As TextBox
End Class