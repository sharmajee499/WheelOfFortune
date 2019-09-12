Imports System.Math


Public Class Form1


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
            '''Move the origin to the centre of the PictureBox.
            ''.TranslateTransform(PictureBox2.Width \ 2, PictureBox2.Height \ 2)

            '''Rotate the world.
            ''.RotateTransform(angle)

            '''Draw the image so its centre coincides with the origin.
            ''.DrawImage(picture,
            ''           -picture.Width \ 2,
            ''           -picture.Height \ 2)
        End With
    End Sub










    'Dim bitmap1 As Bitmap

    'Private Sub InitializeBitmap()
    '    Try
    '        bitmap1 = CType(Bitmap.FromFile("temp.bmp"), Bitmap)
    '        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
    '        PictureBox2.Image = bitmap1
    '    Catch ex As System.IO.FileNotFoundException
    '        MessageBox.Show("There was an error. Check the path to the bitmap.")
    '    End Try


    'End Sub


    'Private Sub Button1_Click_1(sender As Object, e As EventArgs)
    '    InitializeBitmap()
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SpinWheel(txtHowHard.Text, False)
        txtHowHard.Text = 100
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SpinWheel(txtHowHard.Text, True)
        txtHowHard.Text = 100

    End Sub

    Private Function GetANewPuzzle() As String()
        '        Dim puzzle(4) As String
        puzzle(0) = ""
        puzzle(1) = "  can you "
        puzzle(2) = "  guess"
        puzzle(3) = "  "
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim r, c As Integer
        Dim lbl As Label
        Dim ch As String

        For r = 0 To PuzzleRows - 1
            For c = 0 To PuzzleCols - 1
                lbl = PuzzlePanel.Controls(PuzzleTileName(r, c))
                lbl.Text = GetPuzzleChar(puzzle, r, c)
            Next
        Next
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
                'If ch = txtGuess.Text Then
                lbl.Text = ch
                '    found = True
                'End If
            Next
        Next

        'If found Then
        '    Label2.Text = (txtGuess.Text & " was found ")
        'Else
        '    Label2.Text = (txtGuess.Text & " was NOT found ")
        'End If
    End Sub



    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Timer1_Tick()
    'End Sub


End Class
