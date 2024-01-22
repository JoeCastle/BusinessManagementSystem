<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Main))
        Me.Productsbtn = New System.Windows.Forms.Button()
        Me.Customersbtn = New System.Windows.Forms.Button()
        Me.Suppliersbtn = New System.Windows.Forms.Button()
        Me.Logoutbtn = New System.Windows.Forms.Button()
        Me.EmployeeMainTitlelbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Productsbtn
        '
        Me.Productsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Productsbtn.Location = New System.Drawing.Point(49, 94)
        Me.Productsbtn.Name = "Productsbtn"
        Me.Productsbtn.Size = New System.Drawing.Size(160, 68)
        Me.Productsbtn.TabIndex = 8
        Me.Productsbtn.Text = "Products"
        Me.Productsbtn.UseVisualStyleBackColor = True
        '
        'Customersbtn
        '
        Me.Customersbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Customersbtn.Location = New System.Drawing.Point(236, 94)
        Me.Customersbtn.Name = "Customersbtn"
        Me.Customersbtn.Size = New System.Drawing.Size(160, 68)
        Me.Customersbtn.TabIndex = 9
        Me.Customersbtn.Text = "Customers"
        Me.Customersbtn.UseVisualStyleBackColor = True
        '
        'Suppliersbtn
        '
        Me.Suppliersbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Suppliersbtn.Location = New System.Drawing.Point(49, 178)
        Me.Suppliersbtn.Name = "Suppliersbtn"
        Me.Suppliersbtn.Size = New System.Drawing.Size(347, 68)
        Me.Suppliersbtn.TabIndex = 10
        Me.Suppliersbtn.Text = "Suppliers"
        Me.Suppliersbtn.UseVisualStyleBackColor = True
        '
        'Logoutbtn
        '
        Me.Logoutbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logoutbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Logoutbtn.Location = New System.Drawing.Point(365, 10)
        Me.Logoutbtn.Name = "Logoutbtn"
        Me.Logoutbtn.Size = New System.Drawing.Size(66, 29)
        Me.Logoutbtn.TabIndex = 11
        Me.Logoutbtn.Text = "Logout"
        Me.Logoutbtn.UseVisualStyleBackColor = True
        '
        'EmployeeMainTitlelbl
        '
        Me.EmployeeMainTitlelbl.AutoSize = True
        Me.EmployeeMainTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeMainTitlelbl.Location = New System.Drawing.Point(86, 25)
        Me.EmployeeMainTitlelbl.Name = "EmployeeMainTitlelbl"
        Me.EmployeeMainTitlelbl.Size = New System.Drawing.Size(273, 31)
        Me.EmployeeMainTitlelbl.TabIndex = 16
        Me.EmployeeMainTitlelbl.Text = "Employee Main Menu"
        '
        'Employee_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Logoutbtn
        Me.ClientSize = New System.Drawing.Size(443, 277)
        Me.Controls.Add(Me.EmployeeMainTitlelbl)
        Me.Controls.Add(Me.Logoutbtn)
        Me.Controls.Add(Me.Suppliersbtn)
        Me.Controls.Add(Me.Customersbtn)
        Me.Controls.Add(Me.Productsbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Employee_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee_Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Productsbtn As System.Windows.Forms.Button
    Friend WithEvents Customersbtn As System.Windows.Forms.Button
    Friend WithEvents Suppliersbtn As System.Windows.Forms.Button
    Friend WithEvents Logoutbtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeMainTitlelbl As System.Windows.Forms.Label
End Class
