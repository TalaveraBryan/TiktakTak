Public Class Form1
    Dim checker As Boolean
    Dim plusone As Integer

    Private Sub Enable_False()
        btnTik1.Enabled = False
        btnTik2.Enabled = False
        btnTik3.Enabled = False
        btnTik4.Enabled = False
        btnTik5.Enabled = False
        btnTik6.Enabled = False
        btnTik7.Enabled = False
        btnTik8.Enabled = False
        btnTik9.Enabled = False
    End Sub
    Private Sub score()
        If (btnTik1.Text = "X" And btnTik2.Text = "X" And btnTik3.Text = "X") Then

            btnTik1.BackColor = Color.PowderBlue
            btnTik2.BackColor = Color.PowderBlue
            btnTik3.BackColor = Color.PowderBlue
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTik1.Text = "X" And btnTik4.Text = "X" And btnTik7.Text = "X") Then

            btnTik1.BackColor = Color.Red
            btnTik2.BackColor = Color.Red
            btnTik3.BackColor = Color.Red
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (btnTik1.Text = "X" And btnTik5.Text = "X" And btnTik9.Text = "X") Then

            btnTik1.BackColor = Color.Aqua
            btnTik2.BackColor = Color.Aqua
            btnTik3.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTik3.Text = "X" And btnTik5.Text = "X" And btnTik7.Text = "X") Then

            btnTik3.BackColor = Color.Red
            btnTik5.BackColor = Color.Red
            btnTik7.BackColor = Color.Red
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (btnTik3.Text = "X" And btnTik6.Text = "X" And btnTik9.Text = "X") Then

            btnTik3.BackColor = Color.Aqua
            btnTik6.BackColor = Color.Aqua
            btnTik9.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTik4.Text = "X" And btnTik5.Text = "X" And btnTik6.Text = "X") Then

            btnTik3.BackColor = Color.Red
            btnTik5.BackColor = Color.Red
            btnTik7.BackColor = Color.Red
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (btnTik4.Text = "X" And btnTik5.Text = "X" And btnTik6.Text = "X") Then

            btnTik4.BackColor = Color.Aqua
            btnTik5.BackColor = Color.Aqua
            btnTik6.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTik7.Text = "X" And btnTik8.Text = "X" And btnTik9.Text = "X") Then

            btnTik7.BackColor = Color.Aqua
            btnTik8.BackColor = Color.Aqua
            btnTik9.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        '====================================================================================================='
        If (btnTik1.Text = "O" And btnTik2.Text = "O" And btnTik3.Text = "O") Then

            btnTik1.BackColor = Color.PowderBlue
            btnTik2.BackColor = Color.PowderBlue
            btnTik3.BackColor = Color.PowderBlue
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTik1.Text = "O" And btnTik4.Text = "O" And btnTik7.Text = "O") Then

            btnTik1.BackColor = Color.Red
            btnTik2.BackColor = Color.Red
            btnTik3.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (btnTik1.Text = "O" And btnTik5.Text = "O" And btnTik9.Text = "O") Then

            btnTik1.BackColor = Color.Aqua
            btnTik2.BackColor = Color.Aqua
            btnTik3.BackColor = Color.Aqua
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTik3.Text = "O" And btnTik5.Text = "O" And btnTik7.Text = "O") Then

            btnTik3.BackColor = Color.Red
            btnTik5.BackColor = Color.Red
            btnTik7.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (btnTik3.Text = "O" And btnTik6.Text = "O" And btnTik9.Text = "O") Then

            btnTik3.BackColor = Color.Aqua
            btnTik6.BackColor = Color.Aqua
            btnTik9.BackColor = Color.Aqua
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTik4.Text = "O" And btnTik5.Text = "O" And btnTik6.Text = "O") Then

            btnTik3.BackColor = Color.Red
            btnTik5.BackColor = Color.Red
            btnTik7.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (btnTik4.Text = "O" And btnTik5.Text = "O" And btnTik6.Text = "O") Then

            btnTik4.BackColor = Color.Aqua
            btnTik5.BackColor = Color.Aqua
            btnTik6.BackColor = Color.Aqua
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btnTik7.Text = "O" And btnTik8.Text = "O" And btnTik9.Text = "O") Then

            btnTik7.BackColor = Color.Aqua
            btnTik8.BackColor = Color.Aqua
            btnTik9.BackColor = Color.Aqua
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTik1_Click(sender As Object, e As EventArgs) Handles btnTik1.Click
        If (checker = False) Then
            btnTik1.Text = "X"
            checker = True
        Else
            btnTik1.Text = "O"
            checker = False
            score()
            btnTik1.Enabled = False
        End If
    End Sub

    Private Sub btnTik2_Click(sender As Object, e As EventArgs) Handles btnTik2.Click
        If (checker = False) Then
            btnTik2.Text = "X"
            checker = True
        Else
            btnTik2.Text = "O"
            checker = False
            score()
            btnTik2.Enabled = False
        End If
    End Sub

    Private Sub btnTik3_Click(sender As Object, e As EventArgs) Handles btnTik3.Click
        If (checker = False) Then
            btnTik3.Text = "X"
            checker = True
        Else
            btnTik3.Text = "O"
            checker = False
            score()
            btnTik3.Enabled = False
        End If
    End Sub

    Private Sub btnTik4_Click(sender As Object, e As EventArgs) Handles btnTik4.Click
        If (checker = False) Then
            btnTik4.Text = "X"
            checker = True
        Else
            btnTik4.Text = "O"
            checker = False
            score()
            btnTik4.Enabled = False
        End If
    End Sub

    Private Sub btnTik5_Click(sender As Object, e As EventArgs) Handles btnTik5.Click
        If (checker = False) Then
            btnTik5.Text = "X"
            checker = True
        Else
            btnTik5.Text = "O"
            checker = False
            score()
            btnTik5.Enabled = False
        End If
    End Sub

    Private Sub btnTik6_Click(sender As Object, e As EventArgs) Handles btnTik6.Click
        If (checker = False) Then
            btnTik6.Text = "X"
            checker = True
        Else
            btnTik6.Text = "O"
            checker = False
            score()
            btnTik6.Enabled = False
        End If
    End Sub

    Private Sub btnTik7_Click(sender As Object, e As EventArgs) Handles btnTik7.Click
        If (checker = False) Then
            btnTik7.Text = "X"
            checker = True
        Else
            btnTik7.Text = "O"
            checker = False
            score()
            btnTik7.Enabled = False
        End If
    End Sub

    Private Sub btnTik8_Click(sender As Object, e As EventArgs) Handles btnTik8.Click
        If (checker = False) Then
            btnTik8.Text = "X"
            checker = True
        Else
            btnTik8.Text = "O"
            checker = False
            score()
            btnTik8.Enabled = False
        End If
    End Sub

    Private Sub btnTik9_Click(sender As Object, e As EventArgs) Handles btnTik9.Click
        If (checker = False) Then
            btnTik9.Text = "X"
            checker = True
        Else
            btnTik9.Text = "O"
            checker = False
            score()
            btnTik9.Enabled = False
        End If
    End Sub

    Private Sub Newgamebtn_Click(sender As Object, e As EventArgs) Handles Newgamebtn.Click
        btnTik1.Enabled = True
        btnTik2.Enabled = True
        btnTik3.Enabled = True
        btnTik4.Enabled = True
        btnTik5.Enabled = True
        btnTik6.Enabled = True
        btnTik7.Enabled = True
        btnTik8.Enabled = True
        btnTik9.Enabled = True

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.Text = "" ' Clear the text of each button
            End If
        Next

        Xtxt.Text = "0"
        Otxt.Text = "0"

        For Each i As Control In Me.Controls
            If TypeOf i Is Button Then
                Dim btn As Button = DirectCast(i, Button)
                btn.BackColor = Color.WhiteSmoke ' Change the back color to Red (you can use any color)
            End If
        Next


    End Sub

    Private Sub Rsbtn_Click(sender As Object, e As EventArgs) Handles Rsbtn.Click
        btnTik1.Enabled = True
        btnTik2.Enabled = True
        btnTik3.Enabled = True
        btnTik4.Enabled = True
        btnTik5.Enabled = True
        btnTik6.Enabled = True
        btnTik7.Enabled = True
        btnTik8.Enabled = True
        btnTik9.Enabled = True

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.Text = "" ' Clear the text of each button
            End If
        Next
        Newgamebtn.Enabled = True

        For Each i As Control In Me.Controls
            If TypeOf i Is Button Then
                Dim btn As Button = DirectCast(i, Button)
                btn.BackColor = Color.WhiteSmoke ' Change the back color to Red (you can use any color)
            End If
        Next

    End Sub

    Private Sub Extbtn_Click(sender As Object, e As EventArgs) Handles Extbtn.Click
        Dim iExit As DialogResult


        iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
