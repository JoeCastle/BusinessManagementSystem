<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transactions))
        Me.TransactionsTitlelbl = New System.Windows.Forms.Label()
        Me.TransDisplayrchtxtbx = New System.Windows.Forms.RichTextBox()
        Me.CustIDlbl = New System.Windows.Forms.Label()
        Me.ProdIDlbl = New System.Windows.Forms.Label()
        Me.CustIDtxtbx = New System.Windows.Forms.TextBox()
        Me.ProdIDtxtbx = New System.Windows.Forms.TextBox()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.SearchAllbtn = New System.Windows.Forms.Button()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.Datedttmpkr = New System.Windows.Forms.DateTimePicker()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.TransIDlbl = New System.Windows.Forms.Label()
        Me.TransIDtxtbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TransactionsTitlelbl
        '
        Me.TransactionsTitlelbl.AutoSize = True
        Me.TransactionsTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionsTitlelbl.Location = New System.Drawing.Point(139, 27)
        Me.TransactionsTitlelbl.Name = "TransactionsTitlelbl"
        Me.TransactionsTitlelbl.Size = New System.Drawing.Size(324, 31)
        Me.TransactionsTitlelbl.TabIndex = 3
        Me.TransactionsTitlelbl.Text = "Transaction Search Menu"
        '
        'TransDisplayrchtxtbx
        '
        Me.TransDisplayrchtxtbx.Location = New System.Drawing.Point(12, 80)
        Me.TransDisplayrchtxtbx.Name = "TransDisplayrchtxtbx"
        Me.TransDisplayrchtxtbx.ReadOnly = True
        Me.TransDisplayrchtxtbx.Size = New System.Drawing.Size(370, 315)
        Me.TransDisplayrchtxtbx.TabIndex = 42
        Me.TransDisplayrchtxtbx.Text = ""
        '
        'CustIDlbl
        '
        Me.CustIDlbl.AutoSize = True
        Me.CustIDlbl.Location = New System.Drawing.Point(390, 162)
        Me.CustIDlbl.Name = "CustIDlbl"
        Me.CustIDlbl.Size = New System.Drawing.Size(62, 13)
        Me.CustIDlbl.TabIndex = 23
        Me.CustIDlbl.Text = "CustomerID"
        '
        'ProdIDlbl
        '
        Me.ProdIDlbl.AutoSize = True
        Me.ProdIDlbl.Location = New System.Drawing.Point(390, 134)
        Me.ProdIDlbl.Name = "ProdIDlbl"
        Me.ProdIDlbl.Size = New System.Drawing.Size(58, 13)
        Me.ProdIDlbl.TabIndex = 22
        Me.ProdIDlbl.Text = "Product ID"
        '
        'CustIDtxtbx
        '
        Me.CustIDtxtbx.Location = New System.Drawing.Point(466, 161)
        Me.CustIDtxtbx.Name = "CustIDtxtbx"
        Me.CustIDtxtbx.Size = New System.Drawing.Size(130, 20)
        Me.CustIDtxtbx.TabIndex = 33
        '
        'ProdIDtxtbx
        '
        Me.ProdIDtxtbx.Location = New System.Drawing.Point(466, 134)
        Me.ProdIDtxtbx.Name = "ProdIDtxtbx"
        Me.ProdIDtxtbx.Size = New System.Drawing.Size(130, 20)
        Me.ProdIDtxtbx.TabIndex = 32
        '
        'Clearbtn
        '
        Me.Clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clearbtn.Location = New System.Drawing.Point(400, 328)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(81, 67)
        Me.Clearbtn.TabIndex = 37
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'SearchAllbtn
        '
        Me.SearchAllbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchAllbtn.Location = New System.Drawing.Point(496, 242)
        Me.SearchAllbtn.Name = "SearchAllbtn"
        Me.SearchAllbtn.Size = New System.Drawing.Size(80, 67)
        Me.SearchAllbtn.TabIndex = 36
        Me.SearchAllbtn.Text = "Show All"
        Me.SearchAllbtn.UseVisualStyleBackColor = True
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(496, 328)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(80, 67)
        Me.Backbtn.TabIndex = 41
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Datedttmpkr
        '
        Me.Datedttmpkr.Location = New System.Drawing.Point(466, 191)
        Me.Datedttmpkr.Name = "Datedttmpkr"
        Me.Datedttmpkr.ShowCheckBox = True
        Me.Datedttmpkr.Size = New System.Drawing.Size(130, 20)
        Me.Datedttmpkr.TabIndex = 34
        Me.Datedttmpkr.Value = New Date(2014, 12, 10, 0, 0, 0, 0)
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.Location = New System.Drawing.Point(390, 193)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(30, 13)
        Me.Datelbl.TabIndex = 25
        Me.Datelbl.Text = "Date"
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(400, 242)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(81, 67)
        Me.Searchbtn.TabIndex = 35
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Deletebtn
        '
        Me.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Deletebtn.Location = New System.Drawing.Point(400, 413)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(176, 52)
        Me.Deletebtn.TabIndex = 40
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Location = New System.Drawing.Point(204, 413)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(176, 52)
        Me.Editbtn.TabIndex = 39
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Addbtn
        '
        Me.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Addbtn.Location = New System.Drawing.Point(12, 413)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(170, 52)
        Me.Addbtn.TabIndex = 38
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'TransIDlbl
        '
        Me.TransIDlbl.AutoSize = True
        Me.TransIDlbl.Location = New System.Drawing.Point(389, 106)
        Me.TransIDlbl.Name = "TransIDlbl"
        Me.TransIDlbl.Size = New System.Drawing.Size(74, 13)
        Me.TransIDlbl.TabIndex = 30
        Me.TransIDlbl.Text = "TransactionID"
        '
        'TransIDtxtbx
        '
        Me.TransIDtxtbx.Location = New System.Drawing.Point(466, 103)
        Me.TransIDtxtbx.Name = "TransIDtxtbx"
        Me.TransIDtxtbx.Size = New System.Drawing.Size(130, 20)
        Me.TransIDtxtbx.TabIndex = 31
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 488)
        Me.Controls.Add(Me.TransIDtxtbx)
        Me.Controls.Add(Me.TransIDlbl)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Datelbl)
        Me.Controls.Add(Me.Datedttmpkr)
        Me.Controls.Add(Me.CustIDlbl)
        Me.Controls.Add(Me.ProdIDlbl)
        Me.Controls.Add(Me.CustIDtxtbx)
        Me.Controls.Add(Me.ProdIDtxtbx)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.SearchAllbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.TransDisplayrchtxtbx)
        Me.Controls.Add(Me.TransactionsTitlelbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransactionsTitlelbl As System.Windows.Forms.Label
    Friend WithEvents TransDisplayrchtxtbx As System.Windows.Forms.RichTextBox
    Friend WithEvents CustIDlbl As System.Windows.Forms.Label
    Friend WithEvents ProdIDlbl As System.Windows.Forms.Label
    Friend WithEvents CustIDtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ProdIDtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Clearbtn As System.Windows.Forms.Button
    Friend WithEvents SearchAllbtn As System.Windows.Forms.Button
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents Datedttmpkr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Datelbl As System.Windows.Forms.Label
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
    Friend WithEvents Deletebtn As System.Windows.Forms.Button
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents Addbtn As System.Windows.Forms.Button
    Friend WithEvents TransIDlbl As System.Windows.Forms.Label
    Friend WithEvents TransIDtxtbx As System.Windows.Forms.TextBox
End Class
