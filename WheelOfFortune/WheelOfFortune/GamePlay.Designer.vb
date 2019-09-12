<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamePlay
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
        Me.txtHowHard = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PuzzlePanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_arrow = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHowHard
        '
        Me.txtHowHard.Location = New System.Drawing.Point(225, 4)
        Me.txtHowHard.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHowHard.Name = "txtHowHard"
        Me.txtHowHard.Size = New System.Drawing.Size(32, 20)
        Me.txtHowHard.TabIndex = 16
        Me.txtHowHard.Text = "100"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(88, 1)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 19)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Rotate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(676, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 25
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(565, 63)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 19)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Guess Letter"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(532, 63)
        Me.txtGuess.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGuess.MaxLength = 1
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(25, 20)
        Me.txtGuess.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(565, 6)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 19)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "New Puzzle"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PuzzlePanel
        '
        Me.PuzzlePanel.Location = New System.Drawing.Point(9, 273)
        Me.PuzzlePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.PuzzlePanel.Name = "PuzzlePanel"
        Me.PuzzlePanel.Size = New System.Drawing.Size(664, 261)
        Me.PuzzlePanel.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 19)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "QuickSpin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(306, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WheelOfFortune.My.Resources.Resources.White
        Me.PictureBox1.Location = New System.Drawing.Point(9, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 244)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WheelOfFortune.My.Resources.Resources._3
        Me.PictureBox2.Location = New System.Drawing.Point(18, 29)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(207, 232)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'lbl_arrow
        '
        Me.lbl_arrow.AutoSize = True
        Me.lbl_arrow.Location = New System.Drawing.Point(230, 127)
        Me.lbl_arrow.Name = "lbl_arrow"
        Me.lbl_arrow.Size = New System.Drawing.Size(91, 13)
        Me.lbl_arrow.TabIndex = 26
        Me.lbl_arrow.Text = "<<<<<<<<<<<<<<"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Label3"
        '
        'GamePlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 591)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_arrow)
        Me.Controls.Add(Me.txtHowHard)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PuzzlePanel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GamePlay"
        Me.Text = "GamePlay"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHowHard As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PuzzlePanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_arrow As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
