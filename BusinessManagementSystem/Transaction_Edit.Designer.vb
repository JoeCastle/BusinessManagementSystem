<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_Edit))
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.EditInstructlbl = New System.Windows.Forms.Label()
        Me.SearchTransIDlbl = New System.Windows.Forms.Label()
        Me.SearchInstructlbl = New System.Windows.Forms.Label()
        Me.IDSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.EditTransTitlelbl = New System.Windows.Forms.Label()
        Me.TransDateEditdttmpkr = New System.Windows.Forms.DateTimePicker()
        Me.QuantityExlbl = New System.Windows.Forms.Label()
        Me.DateExlbl = New System.Windows.Forms.Label()
        Me.PriceExlbl = New System.Windows.Forms.Label()
        Me.ProdIDExlbl = New System.Windows.Forms.Label()
        Me.CustIDExlbl = New System.Windows.Forms.Label()
        Me.TransIDExlbl = New System.Windows.Forms.Label()
        Me.Pricelbl = New System.Windows.Forms.Label()
        Me.ProdIDEdittxtbx = New System.Windows.Forms.TextBox()
        Me.Quantitylbl = New System.Windows.Forms.Label()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.ProdIDlbl = New System.Windows.Forms.Label()
        Me.QuantEdittxtbx = New System.Windows.Forms.TextBox()
        Me.PriceEdittxtbx = New System.Windows.Forms.TextBox()
        Me.TransIDlbl = New System.Windows.Forms.Label()
        Me.CustIDlbl = New System.Windows.Forms.Label()
        Me.CustIDEdittxtbx = New System.Windows.Forms.TextBox()
        Me.TransIDEdittxtbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(207, 132)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(156, 29)
        Me.Searchbtn.TabIndex = 95
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Location = New System.Drawing.Point(283, 452)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(250, 37)
        Me.Editbtn.TabIndex = 78
        Me.Editbtn.Text = "Edit/Save"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(27, 452)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(250, 37)
        Me.Backbtn.TabIndex = 77
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'EditInstructlbl
        '
        Me.EditInstructlbl.AutoSize = True
        Me.EditInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditInstructlbl.Location = New System.Drawing.Point(40, 178)
        Me.EditInstructlbl.Name = "EditInstructlbl"
        Me.EditInstructlbl.Size = New System.Drawing.Size(204, 13)
        Me.EditInstructlbl.TabIndex = 72
        Me.EditInstructlbl.Text = "Enter the details that you want to change:"
        '
        'SearchTransIDlbl
        '
        Me.SearchTransIDlbl.AutoSize = True
        Me.SearchTransIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTransIDlbl.Location = New System.Drawing.Point(71, 104)
        Me.SearchTransIDlbl.Name = "SearchTransIDlbl"
        Me.SearchTransIDlbl.Size = New System.Drawing.Size(77, 13)
        Me.SearchTransIDlbl.TabIndex = 71
        Me.SearchTransIDlbl.Text = "Transaction ID"
        '
        'SearchInstructlbl
        '
        Me.SearchInstructlbl.AutoSize = True
        Me.SearchInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInstructlbl.Location = New System.Drawing.Point(40, 69)
        Me.SearchInstructlbl.Name = "SearchInstructlbl"
        Me.SearchInstructlbl.Size = New System.Drawing.Size(231, 13)
        Me.SearchInstructlbl.TabIndex = 69
        Me.SearchInstructlbl.Text = "Search for the transaction that you want to edit:"
        '
        'IDSrchtxtbx
        '
        Me.IDSrchtxtbx.Location = New System.Drawing.Point(151, 101)
        Me.IDSrchtxtbx.Name = "IDSrchtxtbx"
        Me.IDSrchtxtbx.Size = New System.Drawing.Size(339, 20)
        Me.IDSrchtxtbx.TabIndex = 68
        '
        'EditTransTitlelbl
        '
        Me.EditTransTitlelbl.AutoSize = True
        Me.EditTransTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditTransTitlelbl.Location = New System.Drawing.Point(180, 17)
        Me.EditTransTitlelbl.Name = "EditTransTitlelbl"
        Me.EditTransTitlelbl.Size = New System.Drawing.Size(211, 31)
        Me.EditTransTitlelbl.TabIndex = 66
        Me.EditTransTitlelbl.Text = "Edit Transaction"
        '
        'TransDateEditdttmpkr
        '
        Me.TransDateEditdttmpkr.Location = New System.Drawing.Point(213, 203)
        Me.TransDateEditdttmpkr.Name = "TransDateEditdttmpkr"
        Me.TransDateEditdttmpkr.Size = New System.Drawing.Size(127, 20)
        Me.TransDateEditdttmpkr.TabIndex = 132
        '
        'QuantityExlbl
        '
        Me.QuantityExlbl.AutoSize = True
        Me.QuantityExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityExlbl.Location = New System.Drawing.Point(345, 417)
        Me.QuantityExlbl.Name = "QuantityExlbl"
        Me.QuantityExlbl.Size = New System.Drawing.Size(52, 13)
        Me.QuantityExlbl.TabIndex = 131
        Me.QuantityExlbl.Text = "(e.g. 100)"
        '
        'DateExlbl
        '
        Me.DateExlbl.AutoSize = True
        Me.DateExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateExlbl.Location = New System.Drawing.Point(346, 207)
        Me.DateExlbl.Name = "DateExlbl"
        Me.DateExlbl.Size = New System.Drawing.Size(118, 13)
        Me.DateExlbl.TabIndex = 130
        Me.DateExlbl.Text = "(e.g. DD/Month/YYYY)"
        '
        'PriceExlbl
        '
        Me.PriceExlbl.AutoSize = True
        Me.PriceExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceExlbl.Location = New System.Drawing.Point(346, 376)
        Me.PriceExlbl.Name = "PriceExlbl"
        Me.PriceExlbl.Size = New System.Drawing.Size(61, 13)
        Me.PriceExlbl.TabIndex = 129
        Me.PriceExlbl.Text = "(e.g. 50.00)"
        '
        'ProdIDExlbl
        '
        Me.ProdIDExlbl.AutoSize = True
        Me.ProdIDExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdIDExlbl.Location = New System.Drawing.Point(346, 332)
        Me.ProdIDExlbl.Name = "ProdIDExlbl"
        Me.ProdIDExlbl.Size = New System.Drawing.Size(88, 13)
        Me.ProdIDExlbl.TabIndex = 128
        Me.ProdIDExlbl.Text = "(e.g. ProductID1)"
        '
        'CustIDExlbl
        '
        Me.CustIDExlbl.AutoSize = True
        Me.CustIDExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustIDExlbl.Location = New System.Drawing.Point(346, 290)
        Me.CustIDExlbl.Name = "CustIDExlbl"
        Me.CustIDExlbl.Size = New System.Drawing.Size(95, 13)
        Me.CustIDExlbl.TabIndex = 127
        Me.CustIDExlbl.Text = "(e.g. CustomerID1)"
        '
        'TransIDExlbl
        '
        Me.TransIDExlbl.AutoSize = True
        Me.TransIDExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransIDExlbl.Location = New System.Drawing.Point(346, 248)
        Me.TransIDExlbl.Name = "TransIDExlbl"
        Me.TransIDExlbl.Size = New System.Drawing.Size(107, 13)
        Me.TransIDExlbl.TabIndex = 126
        Me.TransIDExlbl.Text = "(e.g. TransactionID1)"
        '
        'Pricelbl
        '
        Me.Pricelbl.AutoSize = True
        Me.Pricelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pricelbl.Location = New System.Drawing.Point(168, 376)
        Me.Pricelbl.Name = "Pricelbl"
        Me.Pricelbl.Size = New System.Drawing.Size(31, 13)
        Me.Pricelbl.TabIndex = 125
        Me.Pricelbl.Text = "Price"
        '
        'ProdIDEdittxtbx
        '
        Me.ProdIDEdittxtbx.Location = New System.Drawing.Point(213, 330)
        Me.ProdIDEdittxtbx.Name = "ProdIDEdittxtbx"
        Me.ProdIDEdittxtbx.Size = New System.Drawing.Size(127, 20)
        Me.ProdIDEdittxtbx.TabIndex = 124
        '
        'Quantitylbl
        '
        Me.Quantitylbl.AutoSize = True
        Me.Quantitylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantitylbl.Location = New System.Drawing.Point(153, 417)
        Me.Quantitylbl.Name = "Quantitylbl"
        Me.Quantitylbl.Size = New System.Drawing.Size(46, 13)
        Me.Quantitylbl.TabIndex = 123
        Me.Quantitylbl.Text = "Quantity"
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.Location = New System.Drawing.Point(169, 207)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(30, 13)
        Me.Datelbl.TabIndex = 122
        Me.Datelbl.Text = "Date"
        '
        'ProdIDlbl
        '
        Me.ProdIDlbl.AutoSize = True
        Me.ProdIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdIDlbl.Location = New System.Drawing.Point(141, 333)
        Me.ProdIDlbl.Name = "ProdIDlbl"
        Me.ProdIDlbl.Size = New System.Drawing.Size(58, 13)
        Me.ProdIDlbl.TabIndex = 121
        Me.ProdIDlbl.Text = "Product ID"
        '
        'QuantEdittxtbx
        '
        Me.QuantEdittxtbx.Location = New System.Drawing.Point(213, 414)
        Me.QuantEdittxtbx.Name = "QuantEdittxtbx"
        Me.QuantEdittxtbx.Size = New System.Drawing.Size(127, 20)
        Me.QuantEdittxtbx.TabIndex = 120
        '
        'PriceEdittxtbx
        '
        Me.PriceEdittxtbx.Location = New System.Drawing.Point(213, 373)
        Me.PriceEdittxtbx.Name = "PriceEdittxtbx"
        Me.PriceEdittxtbx.Size = New System.Drawing.Size(127, 20)
        Me.PriceEdittxtbx.TabIndex = 119
        '
        'TransIDlbl
        '
        Me.TransIDlbl.AutoSize = True
        Me.TransIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransIDlbl.Location = New System.Drawing.Point(122, 248)
        Me.TransIDlbl.Name = "TransIDlbl"
        Me.TransIDlbl.Size = New System.Drawing.Size(77, 13)
        Me.TransIDlbl.TabIndex = 118
        Me.TransIDlbl.Text = "Transaction ID"
        '
        'CustIDlbl
        '
        Me.CustIDlbl.AutoSize = True
        Me.CustIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustIDlbl.Location = New System.Drawing.Point(134, 291)
        Me.CustIDlbl.Name = "CustIDlbl"
        Me.CustIDlbl.Size = New System.Drawing.Size(65, 13)
        Me.CustIDlbl.TabIndex = 117
        Me.CustIDlbl.Text = "Customer ID"
        '
        'CustIDEdittxtbx
        '
        Me.CustIDEdittxtbx.Location = New System.Drawing.Point(213, 288)
        Me.CustIDEdittxtbx.Name = "CustIDEdittxtbx"
        Me.CustIDEdittxtbx.Size = New System.Drawing.Size(127, 20)
        Me.CustIDEdittxtbx.TabIndex = 116
        '
        'TransIDEdittxtbx
        '
        Me.TransIDEdittxtbx.Location = New System.Drawing.Point(213, 245)
        Me.TransIDEdittxtbx.Name = "TransIDEdittxtbx"
        Me.TransIDEdittxtbx.Size = New System.Drawing.Size(127, 20)
        Me.TransIDEdittxtbx.TabIndex = 115
        '
        'Transaction_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 516)
        Me.Controls.Add(Me.TransDateEditdttmpkr)
        Me.Controls.Add(Me.QuantityExlbl)
        Me.Controls.Add(Me.DateExlbl)
        Me.Controls.Add(Me.PriceExlbl)
        Me.Controls.Add(Me.ProdIDExlbl)
        Me.Controls.Add(Me.CustIDExlbl)
        Me.Controls.Add(Me.TransIDExlbl)
        Me.Controls.Add(Me.Pricelbl)
        Me.Controls.Add(Me.ProdIDEdittxtbx)
        Me.Controls.Add(Me.Quantitylbl)
        Me.Controls.Add(Me.Datelbl)
        Me.Controls.Add(Me.ProdIDlbl)
        Me.Controls.Add(Me.QuantEdittxtbx)
        Me.Controls.Add(Me.PriceEdittxtbx)
        Me.Controls.Add(Me.TransIDlbl)
        Me.Controls.Add(Me.CustIDlbl)
        Me.Controls.Add(Me.CustIDEdittxtbx)
        Me.Controls.Add(Me.TransIDEdittxtbx)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.EditInstructlbl)
        Me.Controls.Add(Me.SearchTransIDlbl)
        Me.Controls.Add(Me.SearchInstructlbl)
        Me.Controls.Add(Me.IDSrchtxtbx)
        Me.Controls.Add(Me.EditTransTitlelbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transaction_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction_Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents EditInstructlbl As System.Windows.Forms.Label
    Friend WithEvents SearchTransIDlbl As System.Windows.Forms.Label
    Friend WithEvents SearchInstructlbl As System.Windows.Forms.Label
    Friend WithEvents IDSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents EditTransTitlelbl As System.Windows.Forms.Label
    Friend WithEvents TransDateEditdttmpkr As System.Windows.Forms.DateTimePicker
    Friend WithEvents QuantityExlbl As System.Windows.Forms.Label
    Friend WithEvents DateExlbl As System.Windows.Forms.Label
    Friend WithEvents PriceExlbl As System.Windows.Forms.Label
    Friend WithEvents ProdIDExlbl As System.Windows.Forms.Label
    Friend WithEvents CustIDExlbl As System.Windows.Forms.Label
    Friend WithEvents TransIDExlbl As System.Windows.Forms.Label
    Friend WithEvents Pricelbl As System.Windows.Forms.Label
    Friend WithEvents ProdIDEdittxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Quantitylbl As System.Windows.Forms.Label
    Friend WithEvents Datelbl As System.Windows.Forms.Label
    Friend WithEvents ProdIDlbl As System.Windows.Forms.Label
    Friend WithEvents QuantEdittxtbx As System.Windows.Forms.TextBox
    Friend WithEvents PriceEdittxtbx As System.Windows.Forms.TextBox
    Friend WithEvents TransIDlbl As System.Windows.Forms.Label
    Friend WithEvents CustIDlbl As System.Windows.Forms.Label
    Friend WithEvents CustIDEdittxtbx As System.Windows.Forms.TextBox
    Friend WithEvents TransIDEdittxtbx As System.Windows.Forms.TextBox
End Class
