<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtHowHard = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PuzzlePanel = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Rotate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtHowHard
        '
        Me.txtHowHard.Location = New System.Drawing.Point(194, 16)
        Me.txtHowHard.Name = "txtHowHard"
        Me.txtHowHard.Size = New System.Drawing.Size(41, 22)
        Me.txtHowHard.TabIndex = 3
        Me.txtHowHard.Text = "100"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WheelOfFortune.My.Resources.Resources.White
        Me.PictureBox1.Location = New System.Drawing.Point(27, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WheelOfFortune.My.Resources.Resources._3
        Me.PictureBox2.Location = New System.Drawing.Point(39, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(276, 285)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "QuickSpin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PuzzlePanel
        '
        Me.PuzzlePanel.Location = New System.Drawing.Point(63, 366)
        Me.PuzzlePanel.Name = "PuzzlePanel"
        Me.PuzzlePanel.Size = New System.Drawing.Size(885, 322)
        Me.PuzzlePanel.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(804, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "New Puzzle"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(804, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Solve Puzzle"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(761, 92)
        Me.txtGuess.MaxLength = 1
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(32, 22)
        Me.txtGuess.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(804, 92)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Guess Letter"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(758, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 695)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PuzzlePanel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtHowHard)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtHowHard As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PuzzlePanel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
End Class
