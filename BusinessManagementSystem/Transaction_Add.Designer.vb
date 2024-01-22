<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_Add))
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.AddTransTitlelbl = New System.Windows.Forms.Label()
        Me.TransIDAddtxtbx = New System.Windows.Forms.TextBox()
        Me.CustIDAddtxtbx = New System.Windows.Forms.TextBox()
        Me.CustIDlbl = New System.Windows.Forms.Label()
        Me.TransIDlbl = New System.Windows.Forms.Label()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.PriceAddtxtbx = New System.Windows.Forms.TextBox()
        Me.QuantAddtxtbx = New System.Windows.Forms.TextBox()
        Me.ProdIDlbl = New System.Windows.Forms.Label()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.Quantlbl = New System.Windows.Forms.Label()
        Me.ProdIDAddtxtbx = New System.Windows.Forms.TextBox()
        Me.Pricelbl = New System.Windows.Forms.Label()
        Me.TransIDExlbl = New System.Windows.Forms.Label()
        Me.CustIDExlbl = New System.Windows.Forms.Label()
        Me.ProdIDExlbl = New System.Windows.Forms.Label()
        Me.PriceExlbl = New System.Windows.Forms.Label()
        Me.DateExlbl = New System.Windows.Forms.Label()
        Me.QuantityExlbl = New System.Windows.Forms.Label()
        Me.TransDatedttmpkr = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(21, 336)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(109, 43)
        Me.Backbtn.TabIndex = 90
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'AddTransTitlelbl
        '
        Me.AddTransTitlelbl.AutoSize = True
        Me.AddTransTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTransTitlelbl.Location = New System.Drawing.Point(118, 20)
        Me.AddTransTitlelbl.Name = "AddTransTitlelbl"
        Me.AddTransTitlelbl.Size = New System.Drawing.Size(212, 31)
        Me.AddTransTitlelbl.TabIndex = 82
        Me.AddTransTitlelbl.Text = "Add Transaction"
        '
        'TransIDAddtxtbx
        '
        Me.TransIDAddtxtbx.Location = New System.Drawing.Point(144, 118)
        Me.TransIDAddtxtbx.Name = "TransIDAddtxtbx"
        Me.TransIDAddtxtbx.Size = New System.Drawing.Size(127, 20)
        Me.TransIDAddtxtbx.TabIndex = 83
        '
        'CustIDAddtxtbx
        '
        Me.CustIDAddtxtbx.Location = New System.Drawing.Point(144, 161)
        Me.CustIDAddtxtbx.Name = "CustIDAddtxtbx"
        Me.CustIDAddtxtbx.Size = New System.Drawing.Size(127, 20)
        Me.CustIDAddtxtbx.TabIndex = 84
        '
        'CustIDlbl
        '
        Me.CustIDlbl.AutoSize = True
        Me.CustIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustIDlbl.Location = New System.Drawing.Point(65, 164)
        Me.CustIDlbl.Name = "CustIDlbl"
        Me.CustIDlbl.Size = New System.Drawing.Size(65, 13)
        Me.CustIDlbl.TabIndex = 87
        Me.CustIDlbl.Text = "Customer ID"
        '
        'TransIDlbl
        '
        Me.TransIDlbl.AutoSize = True
        Me.TransIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransIDlbl.Location = New System.Drawing.Point(53, 121)
        Me.TransIDlbl.Name = "TransIDlbl"
        Me.TransIDlbl.Size = New System.Drawing.Size(77, 13)
        Me.TransIDlbl.TabIndex = 88
        Me.TransIDlbl.Text = "Transaction ID"
        '
        'Clearbtn
        '
        Me.Clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clearbtn.Location = New System.Drawing.Point(162, 336)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(109, 43)
        Me.Clearbtn.TabIndex = 89
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'Addbtn
        '
        Me.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Addbtn.Location = New System.Drawing.Point(303, 336)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(109, 43)
        Me.Addbtn.TabIndex = 88
        Me.Addbtn.Text = "Add/Save"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'PriceAddtxtbx
        '
        Me.PriceAddtxtbx.Location = New System.Drawing.Point(144, 246)
        Me.PriceAddtxtbx.Name = "PriceAddtxtbx"
        Me.PriceAddtxtbx.Size = New System.Drawing.Size(127, 20)
        Me.PriceAddtxtbx.TabIndex = 86
        '
        'QuantAddtxtbx
        '
        Me.QuantAddtxtbx.Location = New System.Drawing.Point(144, 287)
        Me.QuantAddtxtbx.Name = "QuantAddtxtbx"
        Me.QuantAddtxtbx.Size = New System.Drawing.Size(127, 20)
        Me.QuantAddtxtbx.TabIndex = 87
        '
        'ProdIDlbl
        '
        Me.ProdIDlbl.AutoSize = True
        Me.ProdIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdIDlbl.Location = New System.Drawing.Point(72, 206)
        Me.ProdIDlbl.Name = "ProdIDlbl"
        Me.ProdIDlbl.Size = New System.Drawing.Size(58, 13)
        Me.ProdIDlbl.TabIndex = 99
        Me.ProdIDlbl.Text = "Product ID"
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.Location = New System.Drawing.Point(100, 80)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(30, 13)
        Me.Datelbl.TabIndex = 100
        Me.Datelbl.Text = "Date"
        '
        'Quantlbl
        '
        Me.Quantlbl.AutoSize = True
        Me.Quantlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantlbl.Location = New System.Drawing.Point(84, 290)
        Me.Quantlbl.Name = "Quantlbl"
        Me.Quantlbl.Size = New System.Drawing.Size(46, 13)
        Me.Quantlbl.TabIndex = 101
        Me.Quantlbl.Text = "Quantity"
        '
        'ProdIDAddtxtbx
        '
        Me.ProdIDAddtxtbx.Location = New System.Drawing.Point(144, 203)
        Me.ProdIDAddtxtbx.Name = "ProdIDAddtxtbx"
        Me.ProdIDAddtxtbx.Size = New System.Drawing.Size(127, 20)
        Me.ProdIDAddtxtbx.TabIndex = 85
        '
        'Pricelbl
        '
        Me.Pricelbl.AutoSize = True
        Me.Pricelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pricelbl.Location = New System.Drawing.Point(99, 249)
        Me.Pricelbl.Name = "Pricelbl"
        Me.Pricelbl.Size = New System.Drawing.Size(31, 13)
        Me.Pricelbl.TabIndex = 105
        Me.Pricelbl.Text = "Price"
        '
        'TransIDExlbl
        '
        Me.TransIDExlbl.AutoSize = True
        Me.TransIDExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransIDExlbl.Location = New System.Drawing.Point(277, 121)
        Me.TransIDExlbl.Name = "TransIDExlbl"
        Me.TransIDExlbl.Size = New System.Drawing.Size(107, 13)
        Me.TransIDExlbl.TabIndex = 106
        Me.TransIDExlbl.Text = "(e.g. TransactionID1)"
        '
        'CustIDExlbl
        '
        Me.CustIDExlbl.AutoSize = True
        Me.CustIDExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustIDExlbl.Location = New System.Drawing.Point(277, 163)
        Me.CustIDExlbl.Name = "CustIDExlbl"
        Me.CustIDExlbl.Size = New System.Drawing.Size(95, 13)
        Me.CustIDExlbl.TabIndex = 107
        Me.CustIDExlbl.Text = "(e.g. CustomerID1)"
        '
        'ProdIDExlbl
        '
        Me.ProdIDExlbl.AutoSize = True
        Me.ProdIDExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdIDExlbl.Location = New System.Drawing.Point(277, 205)
        Me.ProdIDExlbl.Name = "ProdIDExlbl"
        Me.ProdIDExlbl.Size = New System.Drawing.Size(88, 13)
        Me.ProdIDExlbl.TabIndex = 108
        Me.ProdIDExlbl.Text = "(e.g. ProductID1)"
        '
        'PriceExlbl
        '
        Me.PriceExlbl.AutoSize = True
        Me.PriceExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceExlbl.Location = New System.Drawing.Point(277, 249)
        Me.PriceExlbl.Name = "PriceExlbl"
        Me.PriceExlbl.Size = New System.Drawing.Size(61, 13)
        Me.PriceExlbl.TabIndex = 111
        Me.PriceExlbl.Text = "(e.g. 50.00)"
        '
        'DateExlbl
        '
        Me.DateExlbl.AutoSize = True
        Me.DateExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateExlbl.Location = New System.Drawing.Point(277, 80)
        Me.DateExlbl.Name = "DateExlbl"
        Me.DateExlbl.Size = New System.Drawing.Size(118, 13)
        Me.DateExlbl.TabIndex = 112
        Me.DateExlbl.Text = "(e.g. DD/Month/YYYY)"
        '
        'QuantityExlbl
        '
        Me.QuantityExlbl.AutoSize = True
        Me.QuantityExlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityExlbl.Location = New System.Drawing.Point(276, 290)
        Me.QuantityExlbl.Name = "QuantityExlbl"
        Me.QuantityExlbl.Size = New System.Drawing.Size(52, 13)
        Me.QuantityExlbl.TabIndex = 113
        Me.QuantityExlbl.Text = "(e.g. 100)"
        '
        'TransDatedttmpkr
        '
        Me.TransDatedttmpkr.Location = New System.Drawing.Point(144, 76)
        Me.TransDatedttmpkr.Name = "TransDatedttmpkr"
        Me.TransDatedttmpkr.Size = New System.Drawing.Size(127, 20)
        Me.TransDatedttmpkr.TabIndex = 114
        '
        'Transaction_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 405)
        Me.Controls.Add(Me.TransDatedttmpkr)
        Me.Controls.Add(Me.QuantityExlbl)
        Me.Controls.Add(Me.DateExlbl)
        Me.Controls.Add(Me.PriceExlbl)
        Me.Controls.Add(Me.ProdIDExlbl)
        Me.Controls.Add(Me.CustIDExlbl)
        Me.Controls.Add(Me.TransIDExlbl)
        Me.Controls.Add(Me.Pricelbl)
        Me.Controls.Add(Me.ProdIDAddtxtbx)
        Me.Controls.Add(Me.Quantlbl)
        Me.Controls.Add(Me.Datelbl)
        Me.Controls.Add(Me.ProdIDlbl)
        Me.Controls.Add(Me.QuantAddtxtbx)
        Me.Controls.Add(Me.PriceAddtxtbx)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.TransIDlbl)
        Me.Controls.Add(Me.CustIDlbl)
        Me.Controls.Add(Me.CustIDAddtxtbx)
        Me.Controls.Add(Me.TransIDAddtxtbx)
        Me.Controls.Add(Me.AddTransTitlelbl)
        Me.Controls.Add(Me.Backbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transaction_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction_Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents AddTransTitlelbl As System.Windows.Forms.Label
    Friend WithEvents TransIDAddtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents CustIDAddtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents CustIDlbl As System.Windows.Forms.Label
    Friend WithEvents TransIDlbl As System.Windows.Forms.Label
    Friend WithEvents Clearbtn As System.Windows.Forms.Button
    Friend WithEvents Addbtn As System.Windows.Forms.Button
    Friend WithEvents PriceAddtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents QuantAddtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ProdIDlbl As System.Windows.Forms.Label
    Friend WithEvents Datelbl As System.Windows.Forms.Label
    Friend WithEvents Quantlbl As System.Windows.Forms.Label
    Friend WithEvents ProdIDAddtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Pricelbl As System.Windows.Forms.Label
    Friend WithEvents TransIDExlbl As System.Windows.Forms.Label
    Friend WithEvents CustIDExlbl As System.Windows.Forms.Label
    Friend WithEvents ProdIDExlbl As System.Windows.Forms.Label
    Friend WithEvents PriceExlbl As System.Windows.Forms.Label
    Friend WithEvents DateExlbl As System.Windows.Forms.Label
    Friend WithEvents QuantityExlbl As System.Windows.Forms.Label
    Friend WithEvents TransDatedttmpkr As System.Windows.Forms.DateTimePicker
End Class
