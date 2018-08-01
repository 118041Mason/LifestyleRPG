Public Class Form1
    Dim exp As Integer
    Dim level As Integer = 1
    Dim coins As Integer = 0
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        exp = 50
        pgbExperience.Value = pgbExperience.Value + 50
        lblExpCount.Text = "Exp " & pgbExperience.Value & "/" & pgbExperience.Maximum

        If pgbExperience.Value = pgbExperience.Maximum Then
            lblLevel.Text = level + 1
            level = level + 1
            If level Mod 10 = 0 Then
                coins = coins + level
            Else coins = coins + 10
            End If
            lblCoinCounter.Text = "Coins: " & coins
            pgbExperience.Value = 0
            pgbExperience.Maximum = level * 100
            lblExpCount.Text = "Exp " & pgbExperience.Value & "/" & pgbExperience.Maximum
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click


    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        If btnShop.Text = "Open Shop" Then
            Me.Size = New Size(552, 550)
            btnShop.Text = "Close Shop"
        Else Me.Size = New Size(552, 300)
            btnShop.Text = "Open Shop"
        End If
        If coins < 25 Then
            btnBlackbg.Enabled = False
            btnBluebg.Enabled = False
            btnRedbg.Enabled = False
            btnYellowbg.Enabled = False
            btnGreenbg.Enabled = False
            btnOrangebg.Enabled = False
            btnWhitebg.Enabled = False
            btnCandyThm.Enabled = False
            btnMatrixThm.Enabled = False
            btnChristmasThm.Enabled = False
            btnIceThm.Enabled = False
            btnFireThm.Enabled = False
            btnDevThm1.Enabled = False
            btnDevThm2.Enabled = False
        ElseIf coins >= 25 And coins < 50 Then
            btnBlackbg.Enabled = True
            btnBluebg.Enabled = True
            btnRedbg.Enabled = True
            btnYellowbg.Enabled = True
            btnGreenbg.Enabled = True
            btnOrangebg.Enabled = True
            btnWhitebg.Enabled = True
            btnCandyThm.Enabled = False
            btnMatrixThm.Enabled = False
            btnChristmasThm.Enabled = False
            btnIceThm.Enabled = False
            btnFireThm.Enabled = False
            btnDevThm1.Enabled = False
            btnDevThm2.Enabled = False
        ElseIf coins >= 50 And coins < 75 Then
            btnBlackbg.Enabled = True
            btnBluebg.Enabled = True
            btnRedbg.Enabled = True
            btnYellowbg.Enabled = True
            btnGreenbg.Enabled = True
            btnOrangebg.Enabled = True
            btnWhitebg.Enabled = True
            btnCandyThm.Enabled = True
            btnMatrixThm.Enabled = True
            btnChristmasThm.Enabled = True
            btnIceThm.Enabled = False
            btnFireThm.Enabled = False
            btnDevThm1.Enabled = False
            btnDevThm2.Enabled = False
        ElseIf coins >= 75 And coins <= 200 Then
            btnBlackbg.Enabled = True
            btnBluebg.Enabled = True
            btnRedbg.Enabled = True
            btnYellowbg.Enabled = True
            btnGreenbg.Enabled = True
            btnOrangebg.Enabled = True
            btnWhitebg.Enabled = True
            btnCandyThm.Enabled = True
            btnMatrixThm.Enabled = True
            btnChristmasThm.Enabled = True
            btnIceThm.Enabled = True
            btnFireThm.Enabled = True
            btnDevThm1.Enabled = False
            btnDevThm2.Enabled = False
        ElseIf coins >= 200 Then
            btnBlackbg.Enabled = True
            btnBluebg.Enabled = True
            btnRedbg.Enabled = True
            btnYellowbg.Enabled = True
            btnGreenbg.Enabled = True
            btnOrangebg.Enabled = True
            btnWhitebg.Enabled = True
            btnCandyThm.Enabled = True
            btnMatrixThm.Enabled = True
            btnChristmasThm.Enabled = True
            btnIceThm.Enabled = True
            btnFireThm.Enabled = True
            btnDevThm1.Enabled = True
            btnDevThm2.Enabled = True
        End If

    End Sub

    Private Sub EnableButtonBackground()
        coins = coins - 25
        lblCoinCounter.Text = "Coins:" & coins
        If coins < 25 Then
            btnBlackbg.Enabled = False
            btnBluebg.Enabled = False
            btnRedbg.Enabled = False
            btnYellowbg.Enabled = False
            btnGreenbg.Enabled = False
            btnOrangebg.Enabled = False
            btnWhitebg.Enabled = False
            btnCandyThm.Enabled = False
            btnMatrixThm.Enabled = False
            btnChristmasThm.Enabled = False
            btnIceThm.Enabled = False
            btnFireThm.Enabled = False
            btnDevThm1.Enabled = False
            btnDevThm2.Enabled = False
        ElseIf coins >= 25 And coins < 50 Then
            btnBlackbg.Enabled = True
            btnBluebg.Enabled = True
            btnRedbg.Enabled = True
            btnYellowbg.Enabled = True
            btnGreenbg.Enabled = True
            btnOrangebg.Enabled = True
            btnWhitebg.Enabled = True
            btnCandyThm.Enabled = False
            btnMatrixThm.Enabled = False
            btnChristmasThm.Enabled = False
            btnIceThm.Enabled = False
            btnFireThm.Enabled = False
            btnDevThm1.Enabled = False
            btnDevThm2.Enabled = False
        ElseIf coins >= 50 And coins < 75 Then
            btnBlackbg.Enabled = True
            btnBluebg.Enabled = True
            btnRedbg.Enabled = True
            btnYellowbg.Enabled = True
            btnGreenbg.Enabled = True
            btnOrangebg.Enabled = True
            btnWhitebg.Enabled = True
            btnCandyThm.Enabled = True
            btnMatrixThm.Enabled = True
            btnChristmasThm.Enabled = True
            btnIceThm.Enabled = False
            btnFireThm.Enabled = False
            btnDevThm1.Enabled = False
            btnDevThm2.Enabled = False
        ElseIf coins >= 75 And coins <= 200 Then
            btnBlackbg.Enabled = True
            btnBluebg.Enabled = True
            btnRedbg.Enabled = True
            btnYellowbg.Enabled = True
            btnGreenbg.Enabled = True
            btnOrangebg.Enabled = True
            btnWhitebg.Enabled = True
            btnCandyThm.Enabled = True
            btnMatrixThm.Enabled = True
            btnChristmasThm.Enabled = True
            btnIceThm.Enabled = True
            btnFireThm.Enabled = True
            btnDevThm1.Enabled = False
            btnDevThm2.Enabled = False
        ElseIf coins >= 200 Then
            btnBlackbg.Enabled = True
            btnBluebg.Enabled = True
            btnRedbg.Enabled = True
            btnYellowbg.Enabled = True
            btnGreenbg.Enabled = True
            btnOrangebg.Enabled = True
            btnWhitebg.Enabled = True
            btnCandyThm.Enabled = True
            btnMatrixThm.Enabled = True
            btnChristmasThm.Enabled = True
            btnIceThm.Enabled = True
            btnFireThm.Enabled = True
            btnDevThm1.Enabled = True
            btnDevThm2.Enabled = True
        End If
    End Sub

    Private Sub btnBluebg_Click(sender As Object, e As EventArgs) Handles btnBluebg.Click
        Me.BackColor = Color.FromArgb(100, 150, 255)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
        EnableButtonBackground()
        btnBluebg.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnGreenbg_Click(sender As Object, e As EventArgs) Handles btnGreenbg.Click
        Me.BackColor = Color.FromArgb(100, 255, 100)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
        EnableButtonBackground()
        btnGreenbg.Visible = False
        Button11.Visible = True
    End Sub

    Private Sub btnYellowbg_Click(sender As Object, e As EventArgs) Handles btnYellowbg.Click
        Me.BackColor = Color.FromArgb(255, 255, 0)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
        EnableButtonBackground()
        btnYellowbg.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnOrangebg_Click(sender As Object, e As EventArgs) Handles btnOrangebg.Click
        Me.BackColor = Color.FromArgb(255, 150, 20)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
        EnableButtonBackground()
        btnOrangebg.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnBlackbg_Click(sender As Object, e As EventArgs) Handles btnBlackbg.Click
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 255, 255)
        EnableButtonBackground()
        btnBlackbg.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnWhitebg_Click(sender As Object, e As EventArgs) Handles btnWhitebg.Click
        Me.BackColor = Color.FromArgb(255, 255, 255)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
        EnableButtonBackground()
        btnWhitebg.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnRedbg_Click(sender As Object, e As EventArgs) Handles btnRedbg.Click
        Me.BackColor = Color.FromArgb(255, 70, 70)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
        EnableButtonBackground()
        btnRedbg.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnMatrixThm_Click(sender As Object, e As EventArgs) Handles btnMatrixThm.Click
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.ForeColor = Color.FromArgb(70, 255, 70)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(70, 255, 70)
        Me.lblExpCount.ForeColor = Color.FromArgb(70, 255, 70)
        EnableButtonBackground()
        btnMatrixThm.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnCandyThm_Click(sender As Object, e As EventArgs) Handles btnCandyThm.Click
        Me.BackColor = Color.FromArgb(255, 100, 170)
        Me.ForeColor = Color.FromArgb(100, 255, 100)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(100, 255, 100)
        Me.lblExpCount.ForeColor = Color.FromArgb(100, 255, 100)
        EnableButtonBackground()
        btnCandyThm.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnChristmasThm_Click(sender As Object, e As EventArgs) Handles btnChristmasThm.Click
        Me.BackColor = Color.FromArgb(255, 70, 70)
        Me.ForeColor = Color.FromArgb(255, 250, 250)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 250, 250)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 250, 250)
        EnableButtonBackground()
        btnChristmasThm.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnFireThm_Click(sender As Object, e As EventArgs) Handles btnFireThm.Click
        Me.BackColor = Color.FromArgb(255, 70, 70)
        Me.ForeColor = Color.FromArgb(255, 150, 70)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 150, 70)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 150, 70)
        EnableButtonBackground()
        btnFireThm.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnIceThm_Click(sender As Object, e As EventArgs) Handles btnIceThm.Click
        Me.BackColor = Color.FromArgb(150, 200, 255)
        Me.ForeColor = Color.FromArgb(100, 100, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 250, 250)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 250, 250)
        EnableButtonBackground()
        btnIceThm.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnDevThm1_Click(sender As Object, e As EventArgs) Handles btnDevThm1.Click
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.ForeColor = Color.FromArgb(100, 100, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(100, 100, 255)
        Me.lblExpCount.ForeColor = Color.FromArgb(100, 100, 255)
        EnableButtonBackground()
        btnDevThm1.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub btnDevThm2_Click(sender As Object, e As EventArgs) Handles btnDevThm2.Click
        Me.BackColor = Color.FromArgb(175, 50, 255)
        Me.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 255, 255)
        EnableButtonBackground()
        btnDevThm2.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.BackColor = SystemColors.Control
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.BackColor = Color.FromArgb(100, 150, 255)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.BackColor = Color.FromArgb(100, 255, 100)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.BackColor = Color.FromArgb(255, 255, 0)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.BackColor = Color.FromArgb(255, 150, 20)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.BackColor = Color.FromArgb(255, 255, 255)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.BackColor = Color.FromArgb(255, 70, 70)
        If Not Me.ForeColor = Color.FromArgb(0, 0, 0) Then
            Me.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)
            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.ForeColor = Color.FromArgb(70, 255, 70)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(70, 255, 70)
        Me.lblExpCount.ForeColor = Color.FromArgb(70, 255, 70)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.BackColor = Color.FromArgb(255, 100, 170)
        Me.ForeColor = Color.FromArgb(100, 255, 100)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(100, 255, 100)
        Me.lblExpCount.ForeColor = Color.FromArgb(100, 255, 100)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.BackColor = Color.FromArgb(255, 70, 70)
        Me.ForeColor = Color.FromArgb(255, 250, 250)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 250, 250)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 250, 250)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.BackColor = Color.FromArgb(255, 70, 70)
        Me.ForeColor = Color.FromArgb(255, 150, 70)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 150, 70)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 150, 70)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BackColor = Color.FromArgb(150, 200, 255)
        Me.ForeColor = Color.FromArgb(100, 100, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 250, 250)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 250, 250)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.ForeColor = Color.FromArgb(100, 100, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(100, 100, 255)
        Me.lblExpCount.ForeColor = Color.FromArgb(100, 100, 255)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = Color.FromArgb(175, 50, 255)
        Me.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
End Class
