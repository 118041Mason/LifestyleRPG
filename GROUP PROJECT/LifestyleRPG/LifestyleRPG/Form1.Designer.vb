Public Class Form1
    'when the form loads it sets these variables
    Dim exp As Integer
    Dim level As Integer = 1
    Dim coins As Integer = 0
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        'if the user hasn't made a mission then this process won't happen
        If lboMissions.Items.Count = 0 Then
            MsgBox("You need to create a mission")
        Else
            'If the user does have an open mission then the user can complete it
            MsgBox("Select the mission from the list and click on the complete button")
            btnComplete.Visible = True
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'This makes it so that spaces left and right of the missions will be trimmed
        ' also makes it so that a space can't be made as a mission
        If tboMission.Text.Trim() = "" Then
            MsgBox("Please input A mission title")
        Else
            'makes it so that whatever is in the textbox goes into the listbox and the textbox is cleared
            lboMissions.Items.Add(tboMission.Text)
            tboMission.Text = ""
        End If
    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        'Expands the form when the button is pressed and checks if the user has enough coins
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
        If btnShop.Text = "Open Shop" Then
            Me.Size = New Size(552, 550)
            btnShop.Text = "Close Shop"
        Else Me.Size = New Size(552, 300)
            btnShop.Text = "Open Shop"
        End If

    End Sub
    'These private subs are used to check whether or not the user has enough coins to buy anything and to subtract coins when they do have enough
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
    Private Sub EnableButtonThemes()
        coins = coins - 50
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
    Private Sub EnableButtonElements()
        coins = coins - 75
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
    Private Sub EnableButtonDevThemes()
        coins = coins - 200
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

    'Chooses the colour or theme for the bakground of the form (line 368-634)
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
        Button9.Visible = True
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
        Button7.Visible = True
    End Sub

    Private Sub btnBlackbg_Click(sender As Object, e As EventArgs) Handles btnBlackbg.Click
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 255, 255)
        EnableButtonBackground()
        btnBlackbg.Visible = False
        Button14.Visible = True
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
        Button12.Visible = True
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
        Button10.Visible = True
    End Sub

    Private Sub btnMatrixThm_Click(sender As Object, e As EventArgs) Handles btnMatrixThm.Click
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.ForeColor = Color.FromArgb(70, 255, 70)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(70, 255, 70)
        Me.lblExpCount.ForeColor = Color.FromArgb(70, 255, 70)
        EnableButtonThemes()
        btnMatrixThm.Visible = False
        Button8.Visible = True
    End Sub

    Private Sub btnCandyThm_Click(sender As Object, e As EventArgs) Handles btnCandyThm.Click
        Me.BackColor = Color.FromArgb(255, 100, 170)
        Me.ForeColor = Color.FromArgb(100, 255, 100)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(100, 255, 100)
        Me.lblExpCount.ForeColor = Color.FromArgb(100, 255, 100)
        EnableButtonThemes()
        btnCandyThm.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub btnChristmasThm_Click(sender As Object, e As EventArgs) Handles btnChristmasThm.Click
        Me.BackColor = Color.FromArgb(255, 70, 70)
        Me.ForeColor = Color.FromArgb(255, 250, 250)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 250, 250)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 250, 250)
        EnableButtonThemes()
        btnChristmasThm.Visible = False
        Button5.Visible = True
    End Sub

    Private Sub btnFireThm_Click(sender As Object, e As EventArgs) Handles btnFireThm.Click
        Me.BackColor = Color.FromArgb(255, 70, 70)
        Me.ForeColor = Color.FromArgb(255, 150, 70)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 150, 70)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 150, 70)
        EnableButtonElements()
        btnFireThm.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub btnIceThm_Click(sender As Object, e As EventArgs) Handles btnIceThm.Click
        Me.BackColor = Color.FromArgb(150, 200, 255)
        Me.ForeColor = Color.FromArgb(100, 100, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 250, 250)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 250, 250)
        EnableButtonElements()
        btnIceThm.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub btnDevThm1_Click(sender As Object, e As EventArgs) Handles btnDevThm1.Click
        Me.BackColor = Color.FromArgb(0, 0, 0)
        Me.ForeColor = Color.FromArgb(100, 100, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(100, 100, 255)
        Me.lblExpCount.ForeColor = Color.FromArgb(100, 100, 255)
        EnableButtonDevThemes()
        btnDevThm1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub btnDevThm2_Click(sender As Object, e As EventArgs) Handles btnDevThm2.Click
        Me.BackColor = Color.FromArgb(175, 50, 255)
        Me.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 255, 255)
        Me.lblExpCount.ForeColor = Color.FromArgb(255, 255, 255)
        EnableButtonDevThemes()
        btnDevThm2.Visible = False
        Button1.Visible = True
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

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click

        If lboMissions.Items.Count = 1 Then
            lboMissions.Items.Clear()
        ElseIf lboMissions.Items.Count > 1 Then
            If lboMissions.SelectedItem = "" Then
                MsgBox("Select a mission")
            Else
                lboMissions.Items.Remove(lboMissions.SelectedItem)

                'the code for the progress bar to update it and to tell the form how to give experience and how to increae the amount per level
                pgbExperience.Value = pgbExperience.Value + 50
                coins = coins + 5
                lblCoinCounter.Text = "Coins: " & coins
                lblExpCount.Text = "Exp " & pgbExperience.Value & "/" & pgbExperience.Maximum
                exp = pgbExperience.Value
                'tells the form what to do when it reaches the max amount of experience for a level
                If pgbExperience.Value = pgbExperience.Maximum Then
                    lblLevel.Text = level + 1
                    level = level + 1
                    If level Mod 5 = 0 Then
                        coins = coins + level
                    End If
                    lblCoinCounter.Text = "Coins: " & coins
                    pgbExperience.Value = 0
                    pgbExperience.Maximum = level * 100
                    lblExpCount.Text = "Exp " & pgbExperience.Value & "/" & pgbExperience.Maximum
                End If
                btnComplete.Visible = False
            End If
        End If
        ' this if statement checks if there are enough coins and enables the corresponding buttons
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

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim SaveLocal As String = My.Application.Info.DirectoryPath + "\Save.txt"
        If System.IO.File.Exists(SaveLocal) = True Then
            Dim objWriter As New System.IO.StreamWriter(SaveLocal)
            objWriter.Write("Level: " & level)
            objWriter.Write(vbNewLine & "Experience: " & pgbExperience.Value)
            objWriter.Write(vbNewLine & "Task1 Data:")
            If lboMissions.Items.Count > 0 Then

                For i = 0 To lboMissions.Items.Count - 1
                    objWriter.Write(vbNewLine & lboMissions.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If
            objWriter.Write(vbNewLine & "Exp: " & exp)
            objWriter.Write(vbNewLine & "Level: " & level)
            objWriter.Write(vbNewLine & "coins " & coins)
            objWriter.Close()
            MsgBox("Game Saved")
        Else
            System.IO.File.Create(SaveLocal).Dispose()
            MsgBox("Save File Created")
            Dim objWriter As New System.IO.StreamWriter(SaveLocal)

        End If
    End Sub
    ' This is supposed to load the form data
    'Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
    '    Dim SaveLocal As String = My.Application.Info.DirectoryPath + "\Save.txt"
    '    Dim TextLine As String
    '    If System.IO.File.Exists(SaveLocal) = True Then
    '        Dim objReader As New System.IO.StreamReader(SaveLocal)
    '        Do While objReader.Peek() <> -1
    '            TextLine = TextLine & objReader.ReadLine() & vbNewLine
    '        Loop
    '        .Text = TextLine
    '    Else
    '        MessageBox.Show("File Does Not Exist")
    '    End If
    'End Sub
End Class



