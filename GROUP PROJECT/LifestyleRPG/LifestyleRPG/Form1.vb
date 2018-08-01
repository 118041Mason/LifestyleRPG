Public Class Form1
    Dim exp As Integer

    Dim level As Integer = 1

    Dim coin As Integer = 0

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        MsgBox("Select the mission from the list and click on the complete button")
        Button1.Enabled = True
        Button1.Visible = True
    End Sub


    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click

        If btnShop.Text = "Open Shop" Then

            Me.Size = New Size(552, 550)

            btnShop.Text = "Close Shop"

        Else Me.Size = New Size(552, 300)

            btnShop.Text = "Open Shop"

        End If



    End Sub

    Private Sub btnDefaultbg_Click(sender As Object, e As EventArgs) Handles btnDefaultbg.Click

        Me.BackColor = SystemColors.Control

        If Me.ForeColor = Color.FromArgb(255, 255, 255) Then

            Me.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)

        End If

    End Sub



    Private Sub btnBluebg_Click(sender As Object, e As EventArgs) Handles btnBluebg.Click

        Me.BackColor = Color.FromArgb(100, 150, 255)

        If Me.ForeColor = Color.FromArgb(255, 255, 255) Then

            Me.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)

        End If



    End Sub



    Private Sub btnGreenbg_Click(sender As Object, e As EventArgs) Handles btnGreenbg.Click

        Me.BackColor = Color.FromArgb(100, 255, 100)

        If Me.ForeColor = Color.FromArgb(255, 255, 255) Then

            Me.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)

        End If



    End Sub



    Private Sub btnYellowbg_Click(sender As Object, e As EventArgs) Handles btnYellowbg.Click

        Me.BackColor = Color.FromArgb(255, 255, 0)

        If Me.ForeColor = Color.FromArgb(255, 255, 255) Then

            Me.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)

        End If



    End Sub



    Private Sub btnOrangebg_Click(sender As Object, e As EventArgs) Handles btnOrangebg.Click

        Me.BackColor = Color.FromArgb(255, 150, 20)

        If Me.ForeColor = Color.FromArgb(255, 255, 255) Then

            Me.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblCoinCounter.ForeColor = Color.FromArgb(0, 0, 0)

            Me.lblExpCount.ForeColor = Color.FromArgb(0, 0, 0)

        End If

    End Sub



    Private Sub btnBlackbg_Click(sender As Object, e As EventArgs) Handles btnBlackbg.Click

        Me.BackColor = Color.FromArgb(0, 0, 0)

        Me.ForeColor = Color.FromArgb(255, 255, 255)

        Me.lblCoinCounter.ForeColor = Color.FromArgb(255, 255, 255)

        Me.lblExpCount.ForeColor = Color.FromArgb(255, 255, 255)



    End Sub



    Private Sub btnWhitebg_Click(sender As Object, e As EventArgs) Handles btnWhitebg.Click

        Me.BackColor = Color.FromArgb(255, 255, 255)

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        If txtAddMission.Text.Trim() = "" Then
            MsgBox("There is an error with what has been inputted. Only input words")
        Else
            lboMissions.Items.Add(txtAddMission.Text)
            txtAddMission.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        exp = 50

        pgbExperience.Value = pgbExperience.Value + 50

        lblExpCount.Text = "Exp " & pgbExperience.Value & "/" & pgbExperience.Maximum



        If pgbExperience.Value = pgbExperience.Maximum Then

            lblLevel.Text = level + 1

            level = level + 1

            If level Mod 10 = 0 Then

                coin = coin + level

            Else coin = coin + 1

            End If

            lblCoinCounter.Text = "Coins: " & coin

            pgbExperience.Value = 0

            pgbExperience.Maximum = level * 100

            lblExpCount.Text = "Exp " & pgbExperience.Value & "/" & pgbExperience.Maximum

        End If

        If lboMissions.Items.Count = 1 Then
            lboMissions.Items.Clear()
        ElseIf lboMissions.Items.Count > 1 Then
            lboMissions.Items.Remove(lboMissions.SelectedItem)
        End If
        Button1.Enabled = False
        Button1.Visible = False


    End Sub
End Class
