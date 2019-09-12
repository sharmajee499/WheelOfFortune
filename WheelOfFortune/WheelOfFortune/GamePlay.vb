
Public Class GamePlay
    Private angle As Integer
    Private puzzle As String()
    Private Const PuzzleRows = 4
    Private Const PuzzleCols = 12

    Private Function PuzzleTileName(row As Integer, col As Integer) As String
        Return "PuzzleTile_" & row & "_" & col
    End Function

    Private Sub FormatTileAsBlank(lbl As Label)
        lbl.Visible = True
        lbl.BackColor = Color.Purple
        lbl.BorderStyle = BorderStyle.Fixed3D
        lbl.Font = New Font("Stencil", 40)
        lbl.ForeColor = Color.AntiqueWhite
        lbl.AutoSize = False
        lbl.TextAlign = ContentAlignment.MiddleCenter

    End Sub
    Private Sub FormatTileAsActive(lbl As Label)
        lbl.Visible = True
        lbl.BackColor = Color.AntiqueWhite
        lbl.BorderStyle = BorderStyle.Fixed3D
        lbl.Font = New Font("Stencil", 40)
        lbl.ForeColor = Color.Black
        lbl.AutoSize = False
        lbl.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub CreatePuzzlePanel()
        Dim r, c As Integer
        Dim lbl As Label


        For r = 0 To PuzzleRows - 1
            For c = 0 To PuzzleCols - 1
                lbl = New Label
                PuzzlePanel.Controls.Add(lbl)
                lbl.Name = PuzzleTileName(r, c)
                FormatTileAsBlank(lbl)

                lbl.Width = PuzzlePanel.Width \ PuzzleCols
                lbl.Height = PuzzlePanel.Height \ PuzzleRows
                lbl.Left = (c) * lbl.Width
                lbl.Top = (r) * lbl.Height

            Next
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim puz(4) As String
        CreatePuzzlePanel()
        puzzle = puz
        LoadPuzzle()
    End Sub


    Private Sub SpinWheel(SpinPct As Double, QuickSpin As Boolean)
        Dim i As Double
        Dim maxval As Double = 4
        Dim spinstrength As Double = 2

        If SpinPct > 1 Then
            SpinPct = 1 'max is 100%
        End If

        i = SpinPct * maxval
        While (i > 0)
            'Rotate the image by a further 1 degree.
            ' Label1.Text = Label1.Text & " " & Math.Tanh(i) * 5
            Me.angle = Me.angle + (Math.Tanh(i - 2) + 1) * spinstrength
            Me.angle = Me.angle Mod 360
            Label1.Text = Me.angle

            'Repaint the image.
            Me.PictureBox1.Refresh()
            Me.Label1.Refresh()
            If Not QuickSpin Then
                Threading.Thread.Sleep(10)
            End If

            i = i - 0.01
        End While
        'repaint the image
        Me.angle = Me.angle Mod 360
        Me.angle = (Int(angle / 15) * 15)
        Me.PictureBox1.Refresh()
        'step 1 add wheel result to label
        wheelresult()

    End Sub
    Private Sub wheelresult()
        'number of slices is 24 thus 15 degree each
        Label3.Text = "step 1: "
        Dim sliceNbr As Integer = Int(angle / 15)
        Select Case sliceNbr
            Case 1 : Label3.Text = Label3.Text & Me.angle & " 300 slice 01"
            Case 2 : Label3.Text = Label3.Text & Me.angle & " 250 Slice 02"
            Case 3 : Label3.Text = Label3.Text & Me.angle & " 750 slice 03"
            Case 4 : Label3.Text = Label3.Text & Me.angle & " Bankrupt 04"
            Case 5 : Label3.Text = Label3.Text & Me.angle & " 300 slice 05"
            Case 6 : Label3.Text = Label3.Text & Me.angle & " 250 slice 06"
            Case 7 : Label3.Text = Label3.Text & Me.angle & " 600 slice 07"
            Case 8 : Label3.Text = Label3.Text & Me.angle & " 400 slice 08"
            Case 9 : Label3.Text = Label3.Text & Me.angle & " 150 slice 09"
            Case 10 : Label3.Text = Label3.Text & Me.angle & " 900 slice 10"
            Case 11 : Label3.Text = Label3.Text & Me.angle & " 200 slice 11"
            Case 12 : Label3.Text = Label3.Text & Me.angle & " 400 slice 12"
            Case 13 : Label3.Text = Label3.Text & Me.angle & " Lose a Turn Slice 13"
            Case 14 : Label3.Text = Label3.Text & Me.angle & " 450 slice 14"
            Case 15 : Label3.Text = Label3.Text & Me.angle & " 500 slice 15"
            Case 16 : Label3.Text = Label3.Text & Me.angle & " 200 slice 16"
            Case 17 : Label3.Text = Label3.Text & Me.angle & " 5000 slice 17"
            Case 18 : Label3.Text = Label3.Text & Me.angle & " Bankrupty slice 18"
            Case 19 : Label3.Text = Label3.Text & Me.angle & " 200 slice 19"
            Case 20 : Label3.Text = Label3.Text & Me.angle & " 300 slice 20"
            Case 21 : Label3.Text = Label3.Text & Me.angle & " 400 slice 21"
            Case 22 : Label3.Text = Label3.Text & Me.angle & " 500 slice 22"
            Case 23 : Label3.Text = Label3.Text & Me.angle & " 2500 slice 23"
            Case 24 : Label3.Text = Label3.Text & Me.angle & " 200 slice 24"


        End Select

    End Sub
    Private Sub PictureBox1_Paint(ByVal sender As Object,
                                  ByVal e As PaintEventArgs) Handles PictureBox1.Paint

        Dim picture As Image
        picture = PictureBox2.Image
        PictureBox1.Width = picture.Width
        PictureBox1.Height = picture.Height
        With e.Graphics
            'Move the origin to the centre of the PictureBox.
            .TranslateTransform(CSng(picture.Width / 2), CSng(picture.Height / 2))

            'Rotate the world.
            .RotateTransform(angle)

            'Draw the image so its centre coincides with the origin.
            .DrawImage(picture,
                       CSng(-picture.Width / 2),
                       CSng(-picture.Height / 2))

        End With
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SpinWheel(txtHowHard.Text, False)

        txtHowHard.Text = 100  'this is not spining the wheel hard
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SpinWheel(txtHowHard.Text, True)
        txtHowHard.Text = 100 'this is spining hard

    End Sub

    Private Function GetANewPuzzle() As String()
        '        Dim puzzle(4) As String
        puzzle(0) = ""
        puzzle(1) = "  can you "
        puzzle(2) = "  guess"
        puzzle(3) = "  "
        Dim filereader As System.IO.StreamReader
        filereader = My.Computer.FileSystem.OpenTextFileReader("puzzle.txt")
        Dim stringreader As String
        Dim n As Integer = Math.Ceiling(Rnd() * 3) + 1
        For i = 1 To n
            stringreader = filereader.ReadLine
            puzzle = stringreader.Split(",")
        Next
        Return puzzle
    End Function

    Function GetPuzzleChar(puzzle() As String, row As Integer, col As Integer)
        Dim s As String
        s = puzzle(row)
        If Len(s) > col Then
            Return s(col)
        Else
            Return " "
        End If
    End Function

    Private Sub LoadPuzzle()
        '        Dim puzzle(4) As String
        Dim r, c As Integer
        Dim lbl As Label
        Dim ch As String

        puzzle = GetANewPuzzle()

        For r = 0 To PuzzleRows - 1
            For c = 0 To PuzzleCols - 1
                lbl = PuzzlePanel.Controls(PuzzleTileName(r, c))
                ch = GetPuzzleChar(puzzle, r, c)
                lbl.Text = ""
                If ch = " " Then
                    FormatTileAsBlank(lbl)
                Else
                    FormatTileAsActive(lbl)
                End If
            Next
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadPuzzle()

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim r, c As Integer
        Dim lbl As Label
        Dim ch As String
        Dim found As Boolean


        found = False

        For r = 0 To PuzzleRows - 1
            For c = 0 To PuzzleCols - 1
                lbl = PuzzlePanel.Controls(PuzzleTileName(r, c))
                ch = GetPuzzleChar(puzzle, r, c)
                'Questions to consider: What is lbl?  look closely at the code for this procedure
                '     Note that this code uses a similar solution to that presented in Problem #7 from the 
                '     initial set of Debugging Problems from early this semester.
                'What is the effect of setting lbl's text property below?
                lbl.Text = ch
            Next
        Next

        txtGuess.Text = txtGuess.Text.ToLower
        If puzzle(0).Contains(txtGuess.Text) Or puzzle(1).Contains(txtGuess.Text) Or puzzle(2).Contains(txtGuess.Text) Or puzzle(3).Contains(txtGuess.Text) Then
            'Label4.Text = Visible
            MessageBox.Show("That's right guess")
        Else
            'Label5.Text = Visible
            MessageBox.Show("That's wrong. try another")
        End If

    End Sub

    Private Sub txtHowHard_TextChanged(sender As Object, e As EventArgs) Handles txtHowHard.TextChanged

    End Sub

    Private Sub lbl_arrow_Click(sender As Object, e As EventArgs) Handles lbl_arrow.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub txtGuess_TextChanged(sender As Object, e As EventArgs) Handles txtGuess.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
End Class