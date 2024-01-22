<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Continuebtn = New System.Windows.Forms.Button()
        Me.Titlelbl = New System.Windows.Forms.Label()
        Me.LoginChoicelbl = New System.Windows.Forms.Label()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Continuebtn
        '
        Me.Continuebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Continuebtn.Location = New System.Drawing.Point(272, 157)
        Me.Continuebtn.Name = "Continuebtn"
        Me.Continuebtn.Size = New System.Drawing.Size(144, 86)
        Me.Continuebtn.TabIndex = 0
        Me.Continuebtn.Text = "Continue"
        Me.Continuebtn.UseVisualStyleBackColor = True
        '
        'Titlelbl
        '
        Me.Titlelbl.AutoSize = True
        Me.Titlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titlelbl.Location = New System.Drawing.Point(62, 36)
        Me.Titlelbl.Name = "Titlelbl"
        Me.Titlelbl.Size = New System.Drawing.Size(338, 31)
        Me.Titlelbl.TabIndex = 1
        Me.Titlelbl.Text = "Welcome to DJD's system."
        '
        'LoginChoicelbl
        '
        Me.LoginChoicelbl.AutoSize = True
        Me.LoginChoicelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginChoicelbl.Location = New System.Drawing.Point(49, 95)
        Me.LoginChoicelbl.Name = "LoginChoicelbl"
        Me.LoginChoicelbl.Size = New System.Drawing.Size(355, 34)
        Me.LoginChoicelbl.TabIndex = 3
        Me.LoginChoicelbl.Text = "                       Welcome to the main menu. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To select an option please cli" & _
    "ck the appropriate button:"
        '
        'Exitbtn
        '
        Me.Exitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exitbtn.Location = New System.Drawing.Point(40, 157)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(144, 86)
        Me.Exitbtn.TabIndex = 4
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 288)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.LoginChoicelbl)
        Me.Controls.Add(Me.Titlelbl)
        Me.Controls.Add(Me.Continuebtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Continuebtn As System.Windows.Forms.Button
    Friend WithEvents Titlelbl As System.Windows.Forms.Label
    Friend WithEvents LoginChoicelbl As System.Windows.Forms.Label
    Friend WithEvents Exitbtn As System.Windows.Forms.Button

End Class
