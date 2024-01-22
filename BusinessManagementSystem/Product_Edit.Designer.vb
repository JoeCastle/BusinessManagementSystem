<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Edit))
        Me.EditProductTitlelbl = New System.Windows.Forms.Label()
        Me.NameSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.IDSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.SearchInstructlbl = New System.Windows.Forms.Label()
        Me.NameSearchlbl = New System.Windows.Forms.Label()
        Me.IDSearchlbl = New System.Windows.Forms.Label()
        Me.EditInstructlbl = New System.Windows.Forms.Label()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.NameChngtxtbx = New System.Windows.Forms.TextBox()
        Me.IDChngtxtbx = New System.Windows.Forms.TextBox()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.DescChngtxtbx = New System.Windows.Forms.TextBox()
        Me.WeiChngtxtbx = New System.Windows.Forms.TextBox()
        Me.PriChngtxtbx = New System.Windows.Forms.TextBox()
        Me.MatChngtxtbx = New System.Windows.Forms.TextBox()
        Me.StockChngtxtbx = New System.Windows.Forms.TextBox()
        Me.DimChngtxtbx = New System.Windows.Forms.TextBox()
        Me.MacNumChngtxtbx = New System.Windows.Forms.TextBox()
        Me.WiSiChngtxtbx = New System.Windows.Forms.TextBox()
        Me.Desclbl = New System.Windows.Forms.Label()
        Me.Weilbl = New System.Windows.Forms.Label()
        Me.Prilbl = New System.Windows.Forms.Label()
        Me.Matlbl = New System.Windows.Forms.Label()
        Me.Stocklbl = New System.Windows.Forms.Label()
        Me.Dimenslbl = New System.Windows.Forms.Label()
        Me.MacNumlbl = New System.Windows.Forms.Label()
        Me.WiSilbl = New System.Windows.Forms.Label()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EditProductTitlelbl
        '
        Me.EditProductTitlelbl.AutoSize = True
        Me.EditProductTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditProductTitlelbl.Location = New System.Drawing.Point(173, 9)
        Me.EditProductTitlelbl.Name = "EditProductTitlelbl"
        Me.EditProductTitlelbl.Size = New System.Drawing.Size(162, 31)
        Me.EditProductTitlelbl.TabIndex = 5
        Me.EditProductTitlelbl.Text = "Edit Product"
        '
        'NameSrchtxtbx
        '
        Me.NameSrchtxtbx.Location = New System.Drawing.Point(123, 97)
        Me.NameSrchtxtbx.Name = "NameSrchtxtbx"
        Me.NameSrchtxtbx.Size = New System.Drawing.Size(339, 20)
        Me.NameSrchtxtbx.TabIndex = 6
        '
        'IDSrchtxtbx
        '
        Me.IDSrchtxtbx.Location = New System.Drawing.Point(123, 131)
        Me.IDSrchtxtbx.Name = "IDSrchtxtbx"
        Me.IDSrchtxtbx.Size = New System.Drawing.Size(339, 20)
        Me.IDSrchtxtbx.TabIndex = 7
        '
        'SearchInstructlbl
        '
        Me.SearchInstructlbl.AutoSize = True
        Me.SearchInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInstructlbl.Location = New System.Drawing.Point(12, 61)
        Me.SearchInstructlbl.Name = "SearchInstructlbl"
        Me.SearchInstructlbl.Size = New System.Drawing.Size(215, 13)
        Me.SearchInstructlbl.TabIndex = 8
        Me.SearchInstructlbl.Text = "Search for the product that you want to edit:"
        '
        'NameSearchlbl
        '
        Me.NameSearchlbl.AutoSize = True
        Me.NameSearchlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameSearchlbl.Location = New System.Drawing.Point(42, 97)
        Me.NameSearchlbl.Name = "NameSearchlbl"
        Me.NameSearchlbl.Size = New System.Drawing.Size(75, 13)
        Me.NameSearchlbl.TabIndex = 9
        Me.NameSearchlbl.Text = "Product Name"
        '
        'IDSearchlbl
        '
        Me.IDSearchlbl.AutoSize = True
        Me.IDSearchlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDSearchlbl.Location = New System.Drawing.Point(59, 131)
        Me.IDSearchlbl.Name = "IDSearchlbl"
        Me.IDSearchlbl.Size = New System.Drawing.Size(58, 13)
        Me.IDSearchlbl.TabIndex = 10
        Me.IDSearchlbl.Text = "Product ID"
        '
        'EditInstructlbl
        '
        Me.EditInstructlbl.AutoSize = True
        Me.EditInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditInstructlbl.Location = New System.Drawing.Point(12, 208)
        Me.EditInstructlbl.Name = "EditInstructlbl"
        Me.EditInstructlbl.Size = New System.Drawing.Size(204, 13)
        Me.EditInstructlbl.TabIndex = 11
        Me.EditInstructlbl.Text = "Enter the details that you want to change:"
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelbl.Location = New System.Drawing.Point(42, 240)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(75, 13)
        Me.Namelbl.TabIndex = 12
        Me.Namelbl.Text = "Product Name"
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDlbl.Location = New System.Drawing.Point(59, 266)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(55, 13)
        Me.IDlbl.TabIndex = 13
        Me.IDlbl.Text = "Unique ID"
        '
        'NameChngtxtbx
        '
        Me.NameChngtxtbx.Location = New System.Drawing.Point(123, 240)
        Me.NameChngtxtbx.Name = "NameChngtxtbx"
        Me.NameChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.NameChngtxtbx.TabIndex = 14
        '
        'IDChngtxtbx
        '
        Me.IDChngtxtbx.Location = New System.Drawing.Point(123, 266)
        Me.IDChngtxtbx.Name = "IDChngtxtbx"
        Me.IDChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.IDChngtxtbx.TabIndex = 15
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(12, 395)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(250, 37)
        Me.Backbtn.TabIndex = 16
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Location = New System.Drawing.Point(268, 395)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(250, 37)
        Me.Editbtn.TabIndex = 17
        Me.Editbtn.Text = "Edit/Save"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'DescChngtxtbx
        '
        Me.DescChngtxtbx.Location = New System.Drawing.Point(123, 292)
        Me.DescChngtxtbx.Name = "DescChngtxtbx"
        Me.DescChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.DescChngtxtbx.TabIndex = 18
        '
        'WeiChngtxtbx
        '
        Me.WeiChngtxtbx.Location = New System.Drawing.Point(123, 318)
        Me.WeiChngtxtbx.Name = "WeiChngtxtbx"
        Me.WeiChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.WeiChngtxtbx.TabIndex = 19
        '
        'PriChngtxtbx
        '
        Me.PriChngtxtbx.Location = New System.Drawing.Point(123, 344)
        Me.PriChngtxtbx.Name = "PriChngtxtbx"
        Me.PriChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.PriChngtxtbx.TabIndex = 20
        '
        'MatChngtxtbx
        '
        Me.MatChngtxtbx.Location = New System.Drawing.Point(341, 237)
        Me.MatChngtxtbx.Name = "MatChngtxtbx"
        Me.MatChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.MatChngtxtbx.TabIndex = 22
        '
        'StockChngtxtbx
        '
        Me.StockChngtxtbx.Location = New System.Drawing.Point(341, 266)
        Me.StockChngtxtbx.Name = "StockChngtxtbx"
        Me.StockChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.StockChngtxtbx.TabIndex = 23
        '
        'DimChngtxtbx
        '
        Me.DimChngtxtbx.Location = New System.Drawing.Point(341, 292)
        Me.DimChngtxtbx.Name = "DimChngtxtbx"
        Me.DimChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.DimChngtxtbx.TabIndex = 24
        '
        'MacNumChngtxtbx
        '
        Me.MacNumChngtxtbx.Location = New System.Drawing.Point(341, 318)
        Me.MacNumChngtxtbx.Name = "MacNumChngtxtbx"
        Me.MacNumChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.MacNumChngtxtbx.TabIndex = 25
        '
        'WiSiChngtxtbx
        '
        Me.WiSiChngtxtbx.Location = New System.Drawing.Point(341, 344)
        Me.WiSiChngtxtbx.Name = "WiSiChngtxtbx"
        Me.WiSiChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.WiSiChngtxtbx.TabIndex = 26
        '
        'Desclbl
        '
        Me.Desclbl.AutoSize = True
        Me.Desclbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desclbl.Location = New System.Drawing.Point(57, 292)
        Me.Desclbl.Name = "Desclbl"
        Me.Desclbl.Size = New System.Drawing.Size(60, 13)
        Me.Desclbl.TabIndex = 27
        Me.Desclbl.Text = "Description"
        '
        'Weilbl
        '
        Me.Weilbl.AutoSize = True
        Me.Weilbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weilbl.Location = New System.Drawing.Point(76, 318)
        Me.Weilbl.Name = "Weilbl"
        Me.Weilbl.Size = New System.Drawing.Size(41, 13)
        Me.Weilbl.TabIndex = 28
        Me.Weilbl.Text = "Weight"
        '
        'Prilbl
        '
        Me.Prilbl.AutoSize = True
        Me.Prilbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prilbl.Location = New System.Drawing.Point(86, 344)
        Me.Prilbl.Name = "Prilbl"
        Me.Prilbl.Size = New System.Drawing.Size(31, 13)
        Me.Prilbl.TabIndex = 29
        Me.Prilbl.Text = "Price"
        '
        'Matlbl
        '
        Me.Matlbl.AutoSize = True
        Me.Matlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matlbl.Location = New System.Drawing.Point(291, 237)
        Me.Matlbl.Name = "Matlbl"
        Me.Matlbl.Size = New System.Drawing.Size(44, 13)
        Me.Matlbl.TabIndex = 30
        Me.Matlbl.Text = "Material"
        '
        'Stocklbl
        '
        Me.Stocklbl.AutoSize = True
        Me.Stocklbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stocklbl.Location = New System.Drawing.Point(300, 266)
        Me.Stocklbl.Name = "Stocklbl"
        Me.Stocklbl.Size = New System.Drawing.Size(35, 13)
        Me.Stocklbl.TabIndex = 31
        Me.Stocklbl.Text = "Stock"
        '
        'Dimenslbl
        '
        Me.Dimenslbl.AutoSize = True
        Me.Dimenslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dimenslbl.Location = New System.Drawing.Point(274, 292)
        Me.Dimenslbl.Name = "Dimenslbl"
        Me.Dimenslbl.Size = New System.Drawing.Size(61, 13)
        Me.Dimenslbl.TabIndex = 32
        Me.Dimenslbl.Text = "Dimensions"
        '
        'MacNumlbl
        '
        Me.MacNumlbl.AutoSize = True
        Me.MacNumlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MacNumlbl.Location = New System.Drawing.Point(247, 318)
        Me.MacNumlbl.Name = "MacNumlbl"
        Me.MacNumlbl.Size = New System.Drawing.Size(88, 13)
        Me.MacNumlbl.TabIndex = 33
        Me.MacNumlbl.Text = "Machine Number"
        '
        'WiSilbl
        '
        Me.WiSilbl.AutoSize = True
        Me.WiSilbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WiSilbl.Location = New System.Drawing.Point(283, 347)
        Me.WiSilbl.Name = "WiSilbl"
        Me.WiSilbl.Size = New System.Drawing.Size(52, 13)
        Me.WiSilbl.TabIndex = 34
        Me.WiSilbl.Text = "Wire Size"
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(179, 162)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(156, 29)
        Me.Searchbtn.TabIndex = 35
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Product_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 444)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.WiSilbl)
        Me.Controls.Add(Me.MacNumlbl)
        Me.Controls.Add(Me.Dimenslbl)
        Me.Controls.Add(Me.Stocklbl)
        Me.Controls.Add(Me.Matlbl)
        Me.Controls.Add(Me.Prilbl)
        Me.Controls.Add(Me.Weilbl)
        Me.Controls.Add(Me.Desclbl)
        Me.Controls.Add(Me.WiSiChngtxtbx)
        Me.Controls.Add(Me.MacNumChngtxtbx)
        Me.Controls.Add(Me.DimChngtxtbx)
        Me.Controls.Add(Me.StockChngtxtbx)
        Me.Controls.Add(Me.MatChngtxtbx)
        Me.Controls.Add(Me.PriChngtxtbx)
        Me.Controls.Add(Me.WeiChngtxtbx)
        Me.Controls.Add(Me.DescChngtxtbx)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.IDChngtxtbx)
        Me.Controls.Add(Me.NameChngtxtbx)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.EditInstructlbl)
        Me.Controls.Add(Me.IDSearchlbl)
        Me.Controls.Add(Me.NameSearchlbl)
        Me.Controls.Add(Me.SearchInstructlbl)
        Me.Controls.Add(Me.IDSrchtxtbx)
        Me.Controls.Add(Me.NameSrchtxtbx)
        Me.Controls.Add(Me.EditProductTitlelbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Product_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EditProductTitlelbl As System.Windows.Forms.Label
    Friend WithEvents NameSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents IDSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents SearchInstructlbl As System.Windows.Forms.Label
    Friend WithEvents NameSearchlbl As System.Windows.Forms.Label
    Friend WithEvents IDSearchlbl As System.Windows.Forms.Label
    Friend WithEvents EditInstructlbl As System.Windows.Forms.Label
    Friend WithEvents Namelbl As System.Windows.Forms.Label
    Friend WithEvents IDlbl As System.Windows.Forms.Label
    Friend WithEvents NameChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents IDChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents DescChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents WeiChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents PriChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents MatChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents StockChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents DimChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents MacNumChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents WiSiChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Desclbl As System.Windows.Forms.Label
    Friend WithEvents Weilbl As System.Windows.Forms.Label
    Friend WithEvents Prilbl As System.Windows.Forms.Label
    Friend WithEvents Matlbl As System.Windows.Forms.Label
    Friend WithEvents Stocklbl As System.Windows.Forms.Label
    Friend WithEvents Dimenslbl As System.Windows.Forms.Label
    Friend WithEvents MacNumlbl As System.Windows.Forms.Label
    Friend WithEvents WiSilbl As System.Windows.Forms.Label
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
End Class
