<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Suppliers))
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.SuppliersTitlelbl = New System.Windows.Forms.Label()
        Me.SupplierDisplayrchtxtbx = New System.Windows.Forms.RichTextBox()
        Me.Nametxtbx = New System.Windows.Forms.TextBox()
        Me.IDtxtbx = New System.Windows.Forms.TextBox()
        Me.SearchAllbtn = New System.Windows.Forms.Button()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDlbl.Location = New System.Drawing.Point(399, 146)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(18, 13)
        Me.IDlbl.TabIndex = 25
        Me.IDlbl.Text = "ID"
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelbl.Location = New System.Drawing.Point(399, 102)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(35, 13)
        Me.Namelbl.TabIndex = 24
        Me.Namelbl.Text = "Name"
        '
        'Deletebtn
        '
        Me.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Deletebtn.Location = New System.Drawing.Point(260, 430)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(100, 40)
        Me.Deletebtn.TabIndex = 22
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Location = New System.Drawing.Point(135, 430)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(100, 40)
        Me.Editbtn.TabIndex = 21
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Addbtn
        '
        Me.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Addbtn.Location = New System.Drawing.Point(10, 430)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(100, 40)
        Me.Addbtn.TabIndex = 20
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(400, 430)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(190, 40)
        Me.Backbtn.TabIndex = 23
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Clearbtn
        '
        Me.Clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clearbtn.Location = New System.Drawing.Point(400, 345)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(190, 40)
        Me.Clearbtn.TabIndex = 19
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'SuppliersTitlelbl
        '
        Me.SuppliersTitlelbl.AutoSize = True
        Me.SuppliersTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliersTitlelbl.Location = New System.Drawing.Point(169, 25)
        Me.SuppliersTitlelbl.Name = "SuppliersTitlelbl"
        Me.SuppliersTitlelbl.Size = New System.Drawing.Size(280, 31)
        Me.SuppliersTitlelbl.TabIndex = 18
        Me.SuppliersTitlelbl.Text = "Supplier Search Menu"
        '
        'SupplierDisplayrchtxtbx
        '
        Me.SupplierDisplayrchtxtbx.Location = New System.Drawing.Point(12, 99)
        Me.SupplierDisplayrchtxtbx.Name = "SupplierDisplayrchtxtbx"
        Me.SupplierDisplayrchtxtbx.ReadOnly = True
        Me.SupplierDisplayrchtxtbx.Size = New System.Drawing.Size(370, 315)
        Me.SupplierDisplayrchtxtbx.TabIndex = 17
        Me.SupplierDisplayrchtxtbx.TabStop = False
        Me.SupplierDisplayrchtxtbx.Text = ""
        '
        'Nametxtbx
        '
        Me.Nametxtbx.Location = New System.Drawing.Point(455, 99)
        Me.Nametxtbx.Name = "Nametxtbx"
        Me.Nametxtbx.Size = New System.Drawing.Size(135, 20)
        Me.Nametxtbx.TabIndex = 15
        '
        'IDtxtbx
        '
        Me.IDtxtbx.Location = New System.Drawing.Point(455, 143)
        Me.IDtxtbx.Name = "IDtxtbx"
        Me.IDtxtbx.Size = New System.Drawing.Size(135, 20)
        Me.IDtxtbx.TabIndex = 16
        '
        'SearchAllbtn
        '
        Me.SearchAllbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchAllbtn.Location = New System.Drawing.Point(400, 265)
        Me.SearchAllbtn.Name = "SearchAllbtn"
        Me.SearchAllbtn.Size = New System.Drawing.Size(190, 40)
        Me.SearchAllbtn.TabIndex = 18
        Me.SearchAllbtn.Text = "Show All"
        Me.SearchAllbtn.UseVisualStyleBackColor = True
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(400, 185)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(190, 40)
        Me.Searchbtn.TabIndex = 17
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 522)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.SuppliersTitlelbl)
        Me.Controls.Add(Me.SupplierDisplayrchtxtbx)
        Me.Controls.Add(Me.Nametxtbx)
        Me.Controls.Add(Me.IDtxtbx)
        Me.Controls.Add(Me.SearchAllbtn)
        Me.Controls.Add(Me.Searchbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Suppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suppliers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IDlbl As System.Windows.Forms.Label
    Friend WithEvents Namelbl As System.Windows.Forms.Label
    Friend WithEvents Deletebtn As System.Windows.Forms.Button
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents Addbtn As System.Windows.Forms.Button
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents Clearbtn As System.Windows.Forms.Button
    Friend WithEvents SuppliersTitlelbl As System.Windows.Forms.Label
    Friend WithEvents SupplierDisplayrchtxtbx As System.Windows.Forms.RichTextBox
    Friend WithEvents Nametxtbx As System.Windows.Forms.TextBox
    Friend WithEvents IDtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents SearchAllbtn As System.Windows.Forms.Button
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
End Class
