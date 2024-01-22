<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Change_Password))
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.CurrentPasstxtbx = New System.Windows.Forms.TextBox()
        Me.NewPasstxtbx = New System.Windows.Forms.TextBox()
        Me.CurrPasslbl = New System.Windows.Forms.Label()
        Me.NewPasslbl = New System.Windows.Forms.Label()
        Me.ChangePassbtn = New System.Windows.Forms.Button()
        Me.ChangePassTitlelbl = New System.Windows.Forms.Label()
        Me.PassReqSubTitlelbl = New System.Windows.Forms.Label()
        Me.PassReqlbl = New System.Windows.Forms.Label()
        Me.ConfirmPasstxtbx = New System.Windows.Forms.TextBox()
        Me.ConfirmPasslbl = New System.Windows.Forms.Label()
        Me.Usernametxtbx = New System.Windows.Forms.TextBox()
        Me.Usernamelbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Backbtn
        '
        Me.Backbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(37, 356)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(262, 68)
        Me.Backbtn.TabIndex = 24
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'CurrentPasstxtbx
        '
        Me.CurrentPasstxtbx.Location = New System.Drawing.Point(80, 185)
        Me.CurrentPasstxtbx.Name = "CurrentPasstxtbx"
        Me.CurrentPasstxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CurrentPasstxtbx.Size = New System.Drawing.Size(247, 20)
        Me.CurrentPasstxtbx.TabIndex = 21
        '
        'NewPasstxtbx
        '
        Me.NewPasstxtbx.Location = New System.Drawing.Point(80, 249)
        Me.NewPasstxtbx.Name = "NewPasstxtbx"
        Me.NewPasstxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasstxtbx.Size = New System.Drawing.Size(247, 20)
        Me.NewPasstxtbx.TabIndex = 22
        '
        'CurrPasslbl
        '
        Me.CurrPasslbl.AutoSize = True
        Me.CurrPasslbl.Location = New System.Drawing.Point(43, 158)
        Me.CurrPasslbl.Name = "CurrPasslbl"
        Me.CurrPasslbl.Size = New System.Drawing.Size(90, 13)
        Me.CurrPasslbl.TabIndex = 12
        Me.CurrPasslbl.Text = "Current Password"
        '
        'NewPasslbl
        '
        Me.NewPasslbl.AutoSize = True
        Me.NewPasslbl.Location = New System.Drawing.Point(43, 218)
        Me.NewPasslbl.Name = "NewPasslbl"
        Me.NewPasslbl.Size = New System.Drawing.Size(78, 13)
        Me.NewPasslbl.TabIndex = 13
        Me.NewPasslbl.Text = "New Password"
        '
        'ChangePassbtn
        '
        Me.ChangePassbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.ChangePassbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangePassbtn.Location = New System.Drawing.Point(377, 356)
        Me.ChangePassbtn.Name = "ChangePassbtn"
        Me.ChangePassbtn.Size = New System.Drawing.Size(262, 68)
        Me.ChangePassbtn.TabIndex = 25
        Me.ChangePassbtn.Text = "Change Password"
        Me.ChangePassbtn.UseVisualStyleBackColor = True
        '
        'ChangePassTitlelbl
        '
        Me.ChangePassTitlelbl.AutoSize = True
        Me.ChangePassTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePassTitlelbl.Location = New System.Drawing.Point(194, 31)
        Me.ChangePassTitlelbl.Name = "ChangePassTitlelbl"
        Me.ChangePassTitlelbl.Size = New System.Drawing.Size(310, 31)
        Me.ChangePassTitlelbl.TabIndex = 15
        Me.ChangePassTitlelbl.Text = "Change Password Menu"
        '
        'PassReqSubTitlelbl
        '
        Me.PassReqSubTitlelbl.AutoSize = True
        Me.PassReqSubTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassReqSubTitlelbl.Location = New System.Drawing.Point(362, 142)
        Me.PassReqSubTitlelbl.Name = "PassReqSubTitlelbl"
        Me.PassReqSubTitlelbl.Size = New System.Drawing.Size(190, 20)
        Me.PassReqSubTitlelbl.TabIndex = 16
        Me.PassReqSubTitlelbl.Text = "Password Requirements: "
        '
        'PassReqlbl
        '
        Me.PassReqlbl.AutoSize = True
        Me.PassReqlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassReqlbl.Location = New System.Drawing.Point(386, 174)
        Me.PassReqlbl.Name = "PassReqlbl"
        Me.PassReqlbl.Size = New System.Drawing.Size(264, 119)
        Me.PassReqlbl.TabIndex = 17
        Me.PassReqlbl.Text = "Must be at least 6 characters long." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Must contain one number. (0-9)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Must con" & _
    "tain one lowercase letter. (a-z)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Must contain one uppercase letter. (A-Z)"
        '
        'ConfirmPasstxtbx
        '
        Me.ConfirmPasstxtbx.Location = New System.Drawing.Point(80, 311)
        Me.ConfirmPasstxtbx.Name = "ConfirmPasstxtbx"
        Me.ConfirmPasstxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasstxtbx.Size = New System.Drawing.Size(247, 20)
        Me.ConfirmPasstxtbx.TabIndex = 23
        '
        'ConfirmPasslbl
        '
        Me.ConfirmPasslbl.AutoSize = True
        Me.ConfirmPasslbl.Location = New System.Drawing.Point(44, 286)
        Me.ConfirmPasslbl.Name = "ConfirmPasslbl"
        Me.ConfirmPasslbl.Size = New System.Drawing.Size(91, 13)
        Me.ConfirmPasslbl.TabIndex = 19
        Me.ConfirmPasslbl.Text = "Confirm Password"
        '
        'Usernametxtbx
        '
        Me.Usernametxtbx.Location = New System.Drawing.Point(80, 125)
        Me.Usernametxtbx.Name = "Usernametxtbx"
        Me.Usernametxtbx.Size = New System.Drawing.Size(247, 20)
        Me.Usernametxtbx.TabIndex = 20
        '
        'Usernamelbl
        '
        Me.Usernamelbl.AutoSize = True
        Me.Usernamelbl.Location = New System.Drawing.Point(43, 95)
        Me.Usernamelbl.Name = "Usernamelbl"
        Me.Usernamelbl.Size = New System.Drawing.Size(314, 13)
        Me.Usernamelbl.TabIndex = 21
        Me.Usernamelbl.Text = "Username (For the account of the password you want to change)"
        '
        'Change_Password
        '
        Me.AcceptButton = Me.ChangePassbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 447)
        Me.Controls.Add(Me.Usernamelbl)
        Me.Controls.Add(Me.Usernametxtbx)
        Me.Controls.Add(Me.ConfirmPasslbl)
        Me.Controls.Add(Me.ConfirmPasstxtbx)
        Me.Controls.Add(Me.PassReqlbl)
        Me.Controls.Add(Me.PassReqSubTitlelbl)
        Me.Controls.Add(Me.ChangePassTitlelbl)
        Me.Controls.Add(Me.ChangePassbtn)
        Me.Controls.Add(Me.NewPasslbl)
        Me.Controls.Add(Me.CurrPasslbl)
        Me.Controls.Add(Me.NewPasstxtbx)
        Me.Controls.Add(Me.CurrentPasstxtbx)
        Me.Controls.Add(Me.Backbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Change_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents CurrentPasstxtbx As System.Windows.Forms.TextBox
    Friend WithEvents NewPasstxtbx As System.Windows.Forms.TextBox
    Friend WithEvents CurrPasslbl As System.Windows.Forms.Label
    Friend WithEvents NewPasslbl As System.Windows.Forms.Label
    Friend WithEvents ChangePassbtn As System.Windows.Forms.Button
    Friend WithEvents ChangePassTitlelbl As System.Windows.Forms.Label
    Friend WithEvents PassReqSubTitlelbl As System.Windows.Forms.Label
    Friend WithEvents PassReqlbl As System.Windows.Forms.Label
    Friend WithEvents ConfirmPasstxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPasslbl As System.Windows.Forms.Label
    Friend WithEvents Usernametxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Usernamelbl As System.Windows.Forms.Label
End Class
