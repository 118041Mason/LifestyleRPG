Public Class Form1
    Dim exp As Single
    Dim coin As Decimal
    Dim level As Decimal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        exp = exp + 100
        level = level + 1
        coin = coin + 20

        txtlevel.Text = level
        txtcoin.Text = coin

        If txtcoin.Text >= 25 Then
            btnred.Enabled = True
            btnblue.Enabled = True
            btnyellow.Enabled = True
            btngreen.Enabled = True
        End If

    End Sub
    Private Sub EnableButtonColour()
        coin = coin - 25
        txtcoin.Text = coin
        If txtcoin.Text >= 25 Then
            btnred.Enabled = True
            btnblue.Enabled = True
            btnyellow.Enabled = True
            btngreen.Enabled = True
        Else
            btnred.Enabled = False
            btnblue.Enabled = False
            btnyellow.Enabled = False
            btngreen.Enabled = False
        End If
    End Sub
    Private Sub btnred_Click(sender As Object, e As EventArgs) Handles btnred.Click
        Me.BackColor = Color.FromArgb(255, 100, 100)
        If btnred.Text = "Red Background" Then
            EnableButtonColour()
            btnred.Visible = False
            btnredtrue.Visible = True

        End If
    End Sub

    Private Sub btnyellow_Click(sender As Object, e As EventArgs) Handles btnyellow.Click
        Me.BackColor = Color.FromArgb(255, 255, 0)
        If btnyellow.Text = "Yellow Background" Then
            EnableButtonColour()
            btnyellow.Visible = False
            btnyellowtrue.Visible = True
        End If
    End Sub

    Private Sub btnblue_Click(sender As Object, e As EventArgs) Handles btnblue.Click
        Me.BackColor = Color.FromArgb(100, 255, 255)
        If btnblue.Text = "Blue Background" Then
            EnableButtonColour()
            btnblue.Visible = False
            btnbluetrue.Visible = True
        End If
    End Sub

    Private Sub btngreen_Click(sender As Object, e As EventArgs) Handles btngreen.Click
        Me.BackColor = Color.FromArgb(100, 255, 100)
        If btngreen.Text = "Green Background" Then
            EnableButtonColour()
            btngreen.Visible = False
            btngreentrue.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        level = 0
        coin = 0
        txtlevel.Text = level
        txtcoin.Text = coin


        btnred.Enabled = False
        btnblue.Enabled = False
        btnyellow.Enabled = False
        btngreen.Enabled = False
    End Sub

    Private Sub btnredtrue_Click(sender As Object, e As EventArgs) Handles btnredtrue.Click
        Me.BackColor = Color.FromArgb(255, 100, 100)
    End Sub

    Private Sub btnyellowtrue_Click(sender As Object, e As EventArgs) Handles btnyellowtrue.Click
        Me.BackColor = Color.FromArgb(255, 255, 0)
    End Sub

    Private Sub btnbluetrue_Click(sender As Object, e As EventArgs) Handles btnbluetrue.Click
        Me.BackColor = Color.FromArgb(100, 255, 255)
    End Sub

    Private Sub btngreentrue_Click(sender As Object, e As EventArgs) Handles btngreentrue.Click
        Me.BackColor = Color.FromArgb(100, 255, 100)
    End Sub
End Class
