<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Delete))
        Me.SearchInstructlbl = New System.Windows.Forms.Label()
        Me.DeleteCustomerTitlelbl = New System.Windows.Forms.Label()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.CustIDSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.CustNameSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SearchInstructlbl
        '
        Me.SearchInstructlbl.AutoSize = True
        Me.SearchInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInstructlbl.Location = New System.Drawing.Point(129, 85)
        Me.SearchInstructlbl.Name = "SearchInstructlbl"
        Me.SearchInstructlbl.Size = New System.Drawing.Size(234, 13)
        Me.SearchInstructlbl.TabIndex = 16
        Me.SearchInstructlbl.Text = "Search for the customer that you want to delete:"
        '
        'DeleteCustomerTitlelbl
        '
        Me.DeleteCustomerTitlelbl.AutoSize = True
        Me.DeleteCustomerTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteCustomerTitlelbl.Location = New System.Drawing.Point(153, 22)
        Me.DeleteCustomerTitlelbl.Name = "DeleteCustomerTitlelbl"
        Me.DeleteCustomerTitlelbl.Size = New System.Drawing.Size(218, 31)
        Me.DeleteCustomerTitlelbl.TabIndex = 15
        Me.DeleteCustomerTitlelbl.Text = "Delete Customer"
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(18, 228)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(173, 35)
        Me.Backbtn.TabIndex = 14
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Location = New System.Drawing.Point(295, 141)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(68, 13)
        Me.IDlbl.TabIndex = 13
        Me.IDlbl.Text = "Customer ID:"
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Location = New System.Drawing.Point(15, 140)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(85, 13)
        Me.Namelbl.TabIndex = 12
        Me.Namelbl.Text = "Customer Name:"
        '
        'CustIDSrchtxtbx
        '
        Me.CustIDSrchtxtbx.Location = New System.Drawing.Point(361, 137)
        Me.CustIDSrchtxtbx.Name = "CustIDSrchtxtbx"
        Me.CustIDSrchtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.CustIDSrchtxtbx.TabIndex = 11
        '
        'CustNameSrchtxtbx
        '
        Me.CustNameSrchtxtbx.Location = New System.Drawing.Point(99, 138)
        Me.CustNameSrchtxtbx.Name = "CustNameSrchtxtbx"
        Me.CustNameSrchtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.CustNameSrchtxtbx.TabIndex = 10
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(313, 228)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(173, 35)
        Me.Searchbtn.TabIndex = 9
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Customer_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 301)
        Me.Controls.Add(Me.SearchInstructlbl)
        Me.Controls.Add(Me.DeleteCustomerTitlelbl)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.CustIDSrchtxtbx)
        Me.Controls.Add(Me.CustNameSrchtxtbx)
        Me.Controls.Add(Me.Searchbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Customer_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer_Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchInstructlbl As System.Windows.Forms.Label
    Friend WithEvents DeleteCustomerTitlelbl As System.Windows.Forms.Label
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents IDlbl As System.Windows.Forms.Label
    Friend WithEvents Namelbl As System.Windows.Forms.Label
    Friend WithEvents CustIDSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents CustNameSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
End Class
