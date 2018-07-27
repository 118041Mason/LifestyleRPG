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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtlevel = New System.Windows.Forms.TextBox()
        Me.txtcoin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnblue = New System.Windows.Forms.Button()
        Me.btnyellow = New System.Windows.Forms.Button()
        Me.btngreen = New System.Windows.Forms.Button()
        Me.btnred = New System.Windows.Forms.Button()
        Me.btnredtrue = New System.Windows.Forms.Button()
        Me.btngreentrue = New System.Windows.Forms.Button()
        Me.btnbluetrue = New System.Windows.Forms.Button()
        Me.btnyellowtrue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Gain exp"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtlevel
        '
        Me.txtlevel.Location = New System.Drawing.Point(50, 38)
        Me.txtlevel.Name = "txtlevel"
        Me.txtlevel.Size = New System.Drawing.Size(100, 20)
        Me.txtlevel.TabIndex = 4
        '
        'txtcoin
        '
        Me.txtcoin.Location = New System.Drawing.Point(50, 89)
        Me.txtcoin.Name = "txtcoin"
        Me.txtcoin.Size = New System.Drawing.Size(100, 20)
        Me.txtcoin.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Coin"
        '
        'btnblue
        '
        Me.btnblue.Location = New System.Drawing.Point(59, 148)
        Me.btnblue.Name = "btnblue"
        Me.btnblue.Size = New System.Drawing.Size(75, 23)
        Me.btnblue.TabIndex = 8
        Me.btnblue.Text = "Blue Background"
        Me.btnblue.UseVisualStyleBackColor = True
        '
        'btnyellow
        '
        Me.btnyellow.Location = New System.Drawing.Point(140, 148)
        Me.btnyellow.Name = "btnyellow"
        Me.btnyellow.Size = New System.Drawing.Size(75, 23)
        Me.btnyellow.TabIndex = 9
        Me.btnyellow.Text = "Yellow Background"
        Me.btnyellow.UseVisualStyleBackColor = True
        '
        'btngreen
        '
        Me.btngreen.Location = New System.Drawing.Point(140, 177)
        Me.btngreen.Name = "btngreen"
        Me.btngreen.Size = New System.Drawing.Size(75, 23)
        Me.btngreen.TabIndex = 10
        Me.btngreen.Text = "Green Background"
        Me.btngreen.UseVisualStyleBackColor = True
        '
        'btnred
        '
        Me.btnred.Location = New System.Drawing.Point(59, 177)
        Me.btnred.Name = "btnred"
        Me.btnred.Size = New System.Drawing.Size(75, 23)
        Me.btnred.TabIndex = 11
        Me.btnred.Text = "Red Background"
        Me.btnred.UseVisualStyleBackColor = True
        '
        'btnredtrue
        '
        Me.btnredtrue.Location = New System.Drawing.Point(59, 177)
        Me.btnredtrue.Name = "btnredtrue"
        Me.btnredtrue.Size = New System.Drawing.Size(75, 23)
        Me.btnredtrue.TabIndex = 12
        Me.btnredtrue.Text = "Use Red"
        Me.btnredtrue.UseVisualStyleBackColor = True
        Me.btnredtrue.Visible = False
        '
        'btngreentrue
        '
        Me.btngreentrue.Location = New System.Drawing.Point(140, 177)
        Me.btngreentrue.Name = "btngreentrue"
        Me.btngreentrue.Size = New System.Drawing.Size(75, 23)
        Me.btngreentrue.TabIndex = 13
        Me.btngreentrue.Text = "Use Green"
        Me.btngreentrue.UseVisualStyleBackColor = True
        Me.btngreentrue.Visible = False
        '
        'btnbluetrue
        '
        Me.btnbluetrue.Location = New System.Drawing.Point(59, 148)
        Me.btnbluetrue.Name = "btnbluetrue"
        Me.btnbluetrue.Size = New System.Drawing.Size(75, 23)
        Me.btnbluetrue.TabIndex = 14
        Me.btnbluetrue.Text = "Use Blue"
        Me.btnbluetrue.UseVisualStyleBackColor = True
        Me.btnbluetrue.Visible = False
        '
        'btnyellowtrue
        '
        Me.btnyellowtrue.Location = New System.Drawing.Point(141, 148)
        Me.btnyellowtrue.Name = "btnyellowtrue"
        Me.btnyellowtrue.Size = New System.Drawing.Size(75, 23)
        Me.btnyellowtrue.TabIndex = 15
        Me.btnyellowtrue.Text = "Use Yellow"
        Me.btnyellowtrue.UseVisualStyleBackColor = True
        Me.btnyellowtrue.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnyellowtrue)
        Me.Controls.Add(Me.btnbluetrue)
        Me.Controls.Add(Me.btngreentrue)
        Me.Controls.Add(Me.btnredtrue)
        Me.Controls.Add(Me.btnred)
        Me.Controls.Add(Me.btngreen)
        Me.Controls.Add(Me.btnyellow)
        Me.Controls.Add(Me.btnblue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcoin)
        Me.Controls.Add(Me.txtlevel)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents txtlevel As TextBox
    Friend WithEvents txtcoin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnblue As Button
    Friend WithEvents btnyellow As Button
    Friend WithEvents btngreen As Button
    Friend WithEvents btnred As Button
    Friend WithEvents btnredtrue As Button
    Friend WithEvents btngreentrue As Button
    Friend WithEvents btnbluetrue As Button
    Friend WithEvents btnyellowtrue As Button
End Class
