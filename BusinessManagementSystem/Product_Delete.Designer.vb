<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Delete))
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.ProdNameSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.ProdIDSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.ProdNamelbl = New System.Windows.Forms.Label()
        Me.ProdIDlbl = New System.Windows.Forms.Label()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.DeleteProductTitlelbl = New System.Windows.Forms.Label()
        Me.SearchInstructlbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(313, 228)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(173, 35)
        Me.Searchbtn.TabIndex = 0
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'ProdNameSrchtxtbx
        '
        Me.ProdNameSrchtxtbx.Location = New System.Drawing.Point(99, 138)
        Me.ProdNameSrchtxtbx.Name = "ProdNameSrchtxtbx"
        Me.ProdNameSrchtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.ProdNameSrchtxtbx.TabIndex = 1
        '
        'ProdIDSrchtxtbx
        '
        Me.ProdIDSrchtxtbx.Location = New System.Drawing.Point(361, 137)
        Me.ProdIDSrchtxtbx.Name = "ProdIDSrchtxtbx"
        Me.ProdIDSrchtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.ProdIDSrchtxtbx.TabIndex = 3
        '
        'ProdNamelbl
        '
        Me.ProdNamelbl.AutoSize = True
        Me.ProdNamelbl.Location = New System.Drawing.Point(20, 140)
        Me.ProdNamelbl.Name = "ProdNamelbl"
        Me.ProdNamelbl.Size = New System.Drawing.Size(78, 13)
        Me.ProdNamelbl.TabIndex = 4
        Me.ProdNamelbl.Text = "Product Name:"
        '
        'ProdIDlbl
        '
        Me.ProdIDlbl.AutoSize = True
        Me.ProdIDlbl.Location = New System.Drawing.Point(302, 141)
        Me.ProdIDlbl.Name = "ProdIDlbl"
        Me.ProdIDlbl.Size = New System.Drawing.Size(61, 13)
        Me.ProdIDlbl.TabIndex = 5
        Me.ProdIDlbl.Text = "Product ID:"
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(18, 228)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(173, 35)
        Me.Backbtn.TabIndex = 6
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'DeleteProductTitlelbl
        '
        Me.DeleteProductTitlelbl.AutoSize = True
        Me.DeleteProductTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProductTitlelbl.Location = New System.Drawing.Point(153, 22)
        Me.DeleteProductTitlelbl.Name = "DeleteProductTitlelbl"
        Me.DeleteProductTitlelbl.Size = New System.Drawing.Size(194, 31)
        Me.DeleteProductTitlelbl.TabIndex = 7
        Me.DeleteProductTitlelbl.Text = "Delete Product"
        '
        'SearchInstructlbl
        '
        Me.SearchInstructlbl.AutoSize = True
        Me.SearchInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInstructlbl.Location = New System.Drawing.Point(129, 85)
        Me.SearchInstructlbl.Name = "SearchInstructlbl"
        Me.SearchInstructlbl.Size = New System.Drawing.Size(227, 13)
        Me.SearchInstructlbl.TabIndex = 8
        Me.SearchInstructlbl.Text = "Search for the product that you want to delete:"
        '
        'Product_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 301)
        Me.Controls.Add(Me.SearchInstructlbl)
        Me.Controls.Add(Me.DeleteProductTitlelbl)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.ProdIDlbl)
        Me.Controls.Add(Me.ProdNamelbl)
        Me.Controls.Add(Me.ProdIDSrchtxtbx)
        Me.Controls.Add(Me.ProdNameSrchtxtbx)
        Me.Controls.Add(Me.Searchbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Product_Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
    Friend WithEvents ProdNameSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ProdIDSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ProdNamelbl As System.Windows.Forms.Label
    Friend WithEvents ProdIDlbl As System.Windows.Forms.Label
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents DeleteProductTitlelbl As System.Windows.Forms.Label
    Friend WithEvents SearchInstructlbl As System.Windows.Forms.Label
End Class
