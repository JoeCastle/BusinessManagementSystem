<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Menu))
        Me.Usernametxtbx = New System.Windows.Forms.TextBox()
        Me.LoginMenuTitlelbl = New System.Windows.Forms.Label()
        Me.Passwordtxtbx = New System.Windows.Forms.TextBox()
        Me.LoginInstructlbl = New System.Windows.Forms.Label()
        Me.Usernamelbl = New System.Windows.Forms.Label()
        Me.Passwordlbl = New System.Windows.Forms.Label()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.Enterbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Usernametxtbx
        '
        Me.Usernametxtbx.Location = New System.Drawing.Point(248, 128)
        Me.Usernametxtbx.Name = "Usernametxtbx"
        Me.Usernametxtbx.Size = New System.Drawing.Size(190, 20)
        Me.Usernametxtbx.TabIndex = 0
        '
        'LoginMenuTitlelbl
        '
        Me.LoginMenuTitlelbl.AutoSize = True
        Me.LoginMenuTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginMenuTitlelbl.Location = New System.Drawing.Point(181, 18)
        Me.LoginMenuTitlelbl.Name = "LoginMenuTitlelbl"
        Me.LoginMenuTitlelbl.Size = New System.Drawing.Size(154, 31)
        Me.LoginMenuTitlelbl.TabIndex = 1
        Me.LoginMenuTitlelbl.Text = "Login Menu"
        '
        'Passwordtxtbx
        '
        Me.Passwordtxtbx.Location = New System.Drawing.Point(248, 200)
        Me.Passwordtxtbx.Name = "Passwordtxtbx"
        Me.Passwordtxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passwordtxtbx.Size = New System.Drawing.Size(190, 20)
        Me.Passwordtxtbx.TabIndex = 2
        '
        'LoginInstructlbl
        '
        Me.LoginInstructlbl.AutoSize = True
        Me.LoginInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginInstructlbl.Location = New System.Drawing.Point(57, 64)
        Me.LoginInstructlbl.Name = "LoginInstructlbl"
        Me.LoginInstructlbl.Size = New System.Drawing.Size(381, 17)
        Me.LoginInstructlbl.TabIndex = 3
        Me.LoginInstructlbl.Text = "To access the system, enter your username and password."
        '
        'Usernamelbl
        '
        Me.Usernamelbl.AutoSize = True
        Me.Usernamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernamelbl.Location = New System.Drawing.Point(57, 128)
        Me.Usernamelbl.Name = "Usernamelbl"
        Me.Usernamelbl.Size = New System.Drawing.Size(77, 17)
        Me.Usernamelbl.TabIndex = 4
        Me.Usernamelbl.Text = "Username:"
        '
        'Passwordlbl
        '
        Me.Passwordlbl.AutoSize = True
        Me.Passwordlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordlbl.Location = New System.Drawing.Point(57, 200)
        Me.Passwordlbl.Name = "Passwordlbl"
        Me.Passwordlbl.Size = New System.Drawing.Size(73, 17)
        Me.Passwordlbl.TabIndex = 5
        Me.Passwordlbl.Text = "Password:"
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(60, 288)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(160, 68)
        Me.Backbtn.TabIndex = 7
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Enterbtn
        '
        Me.Enterbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enterbtn.Location = New System.Drawing.Point(278, 288)
        Me.Enterbtn.Name = "Enterbtn"
        Me.Enterbtn.Size = New System.Drawing.Size(160, 68)
        Me.Enterbtn.TabIndex = 6
        Me.Enterbtn.Text = "Login"
        Me.Enterbtn.UseVisualStyleBackColor = True
        '
        'Login_Menu
        '
        Me.AcceptButton = Me.Enterbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 418)
        Me.Controls.Add(Me.Enterbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.Passwordlbl)
        Me.Controls.Add(Me.Usernamelbl)
        Me.Controls.Add(Me.LoginInstructlbl)
        Me.Controls.Add(Me.Passwordtxtbx)
        Me.Controls.Add(Me.LoginMenuTitlelbl)
        Me.Controls.Add(Me.Usernametxtbx)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Login_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Usernametxtbx As System.Windows.Forms.TextBox
    Friend WithEvents LoginMenuTitlelbl As System.Windows.Forms.Label
    Friend WithEvents Passwordtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents LoginInstructlbl As System.Windows.Forms.Label
    Friend WithEvents Usernamelbl As System.Windows.Forms.Label
    Friend WithEvents Passwordlbl As System.Windows.Forms.Label
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents Enterbtn As System.Windows.Forms.Button
End Class
