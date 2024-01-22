<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Edit))
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Countrylbl = New System.Windows.Forms.Label()
        Me.PCodelbl = New System.Windows.Forms.Label()
        Me.Citylbl = New System.Windows.Forms.Label()
        Me.Streetlbl = New System.Windows.Forms.Label()
        Me.ConNamlbl = New System.Windows.Forms.Label()
        Me.Emaillbl = New System.Windows.Forms.Label()
        Me.Telelbl = New System.Windows.Forms.Label()
        Me.Desclbl = New System.Windows.Forms.Label()
        Me.CountryChngtxtbx = New System.Windows.Forms.TextBox()
        Me.PCodeChngtxtbx = New System.Windows.Forms.TextBox()
        Me.CityChngtxtbx = New System.Windows.Forms.TextBox()
        Me.StreetChngtxtbx = New System.Windows.Forms.TextBox()
        Me.ConNamChngtxtbx = New System.Windows.Forms.TextBox()
        Me.EmailChngtxtbx = New System.Windows.Forms.TextBox()
        Me.TeleChngtxtbx = New System.Windows.Forms.TextBox()
        Me.DescChngtxtbx = New System.Windows.Forms.TextBox()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.IDChngtxtbx = New System.Windows.Forms.TextBox()
        Me.NameChngtxtbx = New System.Windows.Forms.TextBox()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.EditInstructlbl = New System.Windows.Forms.Label()
        Me.IDSearchlbl = New System.Windows.Forms.Label()
        Me.NameSearchlbl = New System.Windows.Forms.Label()
        Me.SearchInstructlbl = New System.Windows.Forms.Label()
        Me.IDSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.NameSrchtxtbx = New System.Windows.Forms.TextBox()
        Me.EditCustomerTitlelbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(178, 164)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(156, 29)
        Me.Searchbtn.TabIndex = 39
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Countrylbl
        '
        Me.Countrylbl.AutoSize = True
        Me.Countrylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Countrylbl.Location = New System.Drawing.Point(289, 348)
        Me.Countrylbl.Name = "Countrylbl"
        Me.Countrylbl.Size = New System.Drawing.Size(43, 13)
        Me.Countrylbl.TabIndex = 64
        Me.Countrylbl.Text = "Country"
        '
        'PCodelbl
        '
        Me.PCodelbl.AutoSize = True
        Me.PCodelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCodelbl.Location = New System.Drawing.Point(280, 320)
        Me.PCodelbl.Name = "PCodelbl"
        Me.PCodelbl.Size = New System.Drawing.Size(52, 13)
        Me.PCodelbl.TabIndex = 63
        Me.PCodelbl.Text = "Postcode"
        '
        'Citylbl
        '
        Me.Citylbl.AutoSize = True
        Me.Citylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Citylbl.Location = New System.Drawing.Point(308, 294)
        Me.Citylbl.Name = "Citylbl"
        Me.Citylbl.Size = New System.Drawing.Size(24, 13)
        Me.Citylbl.TabIndex = 62
        Me.Citylbl.Text = "City"
        '
        'Streetlbl
        '
        Me.Streetlbl.AutoSize = True
        Me.Streetlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Streetlbl.Location = New System.Drawing.Point(299, 268)
        Me.Streetlbl.Name = "Streetlbl"
        Me.Streetlbl.Size = New System.Drawing.Size(35, 13)
        Me.Streetlbl.TabIndex = 61
        Me.Streetlbl.Text = "Street"
        '
        'ConNamlbl
        '
        Me.ConNamlbl.AutoSize = True
        Me.ConNamlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConNamlbl.Location = New System.Drawing.Point(261, 239)
        Me.ConNamlbl.Name = "ConNamlbl"
        Me.ConNamlbl.Size = New System.Drawing.Size(75, 13)
        Me.ConNamlbl.TabIndex = 60
        Me.ConNamlbl.Text = "Contact Name"
        '
        'Emaillbl
        '
        Me.Emaillbl.AutoSize = True
        Me.Emaillbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emaillbl.Location = New System.Drawing.Point(85, 346)
        Me.Emaillbl.Name = "Emaillbl"
        Me.Emaillbl.Size = New System.Drawing.Size(32, 13)
        Me.Emaillbl.TabIndex = 59
        Me.Emaillbl.Text = "Email"
        '
        'Telelbl
        '
        Me.Telelbl.AutoSize = True
        Me.Telelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telelbl.Location = New System.Drawing.Point(61, 320)
        Me.Telelbl.Name = "Telelbl"
        Me.Telelbl.Size = New System.Drawing.Size(58, 13)
        Me.Telelbl.TabIndex = 58
        Me.Telelbl.Text = "Telephone"
        '
        'Desclbl
        '
        Me.Desclbl.AutoSize = True
        Me.Desclbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desclbl.Location = New System.Drawing.Point(60, 294)
        Me.Desclbl.Name = "Desclbl"
        Me.Desclbl.Size = New System.Drawing.Size(60, 13)
        Me.Desclbl.TabIndex = 57
        Me.Desclbl.Text = "Description"
        '
        'CountryChngtxtbx
        '
        Me.CountryChngtxtbx.Location = New System.Drawing.Point(340, 346)
        Me.CountryChngtxtbx.Name = "CountryChngtxtbx"
        Me.CountryChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.CountryChngtxtbx.TabIndex = 54
        '
        'PCodeChngtxtbx
        '
        Me.PCodeChngtxtbx.Location = New System.Drawing.Point(340, 320)
        Me.PCodeChngtxtbx.Name = "PCodeChngtxtbx"
        Me.PCodeChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.PCodeChngtxtbx.TabIndex = 53
        '
        'CityChngtxtbx
        '
        Me.CityChngtxtbx.Location = New System.Drawing.Point(340, 294)
        Me.CityChngtxtbx.Name = "CityChngtxtbx"
        Me.CityChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.CityChngtxtbx.TabIndex = 52
        '
        'StreetChngtxtbx
        '
        Me.StreetChngtxtbx.Location = New System.Drawing.Point(340, 268)
        Me.StreetChngtxtbx.Name = "StreetChngtxtbx"
        Me.StreetChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.StreetChngtxtbx.TabIndex = 51
        '
        'ConNamChngtxtbx
        '
        Me.ConNamChngtxtbx.Location = New System.Drawing.Point(340, 239)
        Me.ConNamChngtxtbx.Name = "ConNamChngtxtbx"
        Me.ConNamChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.ConNamChngtxtbx.TabIndex = 50
        '
        'EmailChngtxtbx
        '
        Me.EmailChngtxtbx.Location = New System.Drawing.Point(122, 346)
        Me.EmailChngtxtbx.Name = "EmailChngtxtbx"
        Me.EmailChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.EmailChngtxtbx.TabIndex = 49
        '
        'TeleChngtxtbx
        '
        Me.TeleChngtxtbx.Location = New System.Drawing.Point(122, 320)
        Me.TeleChngtxtbx.Name = "TeleChngtxtbx"
        Me.TeleChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.TeleChngtxtbx.TabIndex = 48
        '
        'DescChngtxtbx
        '
        Me.DescChngtxtbx.Location = New System.Drawing.Point(122, 294)
        Me.DescChngtxtbx.Name = "DescChngtxtbx"
        Me.DescChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.DescChngtxtbx.TabIndex = 47
        '
        'Editbtn
        '
        Me.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editbtn.Location = New System.Drawing.Point(267, 397)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(250, 37)
        Me.Editbtn.TabIndex = 55
        Me.Editbtn.Text = "Edit/Save"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(11, 397)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(250, 37)
        Me.Backbtn.TabIndex = 56
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'IDChngtxtbx
        '
        Me.IDChngtxtbx.Location = New System.Drawing.Point(122, 268)
        Me.IDChngtxtbx.Name = "IDChngtxtbx"
        Me.IDChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.IDChngtxtbx.TabIndex = 46
        '
        'NameChngtxtbx
        '
        Me.NameChngtxtbx.Location = New System.Drawing.Point(122, 242)
        Me.NameChngtxtbx.Name = "NameChngtxtbx"
        Me.NameChngtxtbx.Size = New System.Drawing.Size(100, 20)
        Me.NameChngtxtbx.TabIndex = 45
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDlbl.Location = New System.Drawing.Point(64, 268)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(55, 13)
        Me.IDlbl.TabIndex = 44
        Me.IDlbl.Text = "Unique ID"
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelbl.Location = New System.Drawing.Point(84, 242)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(35, 13)
        Me.Namelbl.TabIndex = 43
        Me.Namelbl.Text = "Name"
        '
        'EditInstructlbl
        '
        Me.EditInstructlbl.AutoSize = True
        Me.EditInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditInstructlbl.Location = New System.Drawing.Point(11, 210)
        Me.EditInstructlbl.Name = "EditInstructlbl"
        Me.EditInstructlbl.Size = New System.Drawing.Size(204, 13)
        Me.EditInstructlbl.TabIndex = 42
        Me.EditInstructlbl.Text = "Enter the details that you want to change:"
        '
        'IDSearchlbl
        '
        Me.IDSearchlbl.AutoSize = True
        Me.IDSearchlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDSearchlbl.Location = New System.Drawing.Point(58, 133)
        Me.IDSearchlbl.Name = "IDSearchlbl"
        Me.IDSearchlbl.Size = New System.Drawing.Size(65, 13)
        Me.IDSearchlbl.TabIndex = 41
        Me.IDSearchlbl.Text = "Customer ID"
        '
        'NameSearchlbl
        '
        Me.NameSearchlbl.AutoSize = True
        Me.NameSearchlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameSearchlbl.Location = New System.Drawing.Point(41, 99)
        Me.NameSearchlbl.Name = "NameSearchlbl"
        Me.NameSearchlbl.Size = New System.Drawing.Size(82, 13)
        Me.NameSearchlbl.TabIndex = 40
        Me.NameSearchlbl.Text = "Customer Name"
        '
        'SearchInstructlbl
        '
        Me.SearchInstructlbl.AutoSize = True
        Me.SearchInstructlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInstructlbl.Location = New System.Drawing.Point(11, 63)
        Me.SearchInstructlbl.Name = "SearchInstructlbl"
        Me.SearchInstructlbl.Size = New System.Drawing.Size(222, 13)
        Me.SearchInstructlbl.TabIndex = 39
        Me.SearchInstructlbl.Text = "Search for the customer that you want to edit:"
        '
        'IDSrchtxtbx
        '
        Me.IDSrchtxtbx.Location = New System.Drawing.Point(122, 133)
        Me.IDSrchtxtbx.Name = "IDSrchtxtbx"
        Me.IDSrchtxtbx.Size = New System.Drawing.Size(339, 20)
        Me.IDSrchtxtbx.TabIndex = 38
        '
        'NameSrchtxtbx
        '
        Me.NameSrchtxtbx.Location = New System.Drawing.Point(122, 99)
        Me.NameSrchtxtbx.Name = "NameSrchtxtbx"
        Me.NameSrchtxtbx.Size = New System.Drawing.Size(339, 20)
        Me.NameSrchtxtbx.TabIndex = 37
        '
        'EditCustomerTitlelbl
        '
        Me.EditCustomerTitlelbl.AutoSize = True
        Me.EditCustomerTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditCustomerTitlelbl.Location = New System.Drawing.Point(172, 11)
        Me.EditCustomerTitlelbl.Name = "EditCustomerTitlelbl"
        Me.EditCustomerTitlelbl.Size = New System.Drawing.Size(186, 31)
        Me.EditCustomerTitlelbl.TabIndex = 36
        Me.EditCustomerTitlelbl.Text = "Edit Customer"
        '
        'Customer_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 444)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Countrylbl)
        Me.Controls.Add(Me.PCodelbl)
        Me.Controls.Add(Me.Citylbl)
        Me.Controls.Add(Me.Streetlbl)
        Me.Controls.Add(Me.ConNamlbl)
        Me.Controls.Add(Me.Emaillbl)
        Me.Controls.Add(Me.Telelbl)
        Me.Controls.Add(Me.Desclbl)
        Me.Controls.Add(Me.CountryChngtxtbx)
        Me.Controls.Add(Me.PCodeChngtxtbx)
        Me.Controls.Add(Me.CityChngtxtbx)
        Me.Controls.Add(Me.StreetChngtxtbx)
        Me.Controls.Add(Me.ConNamChngtxtbx)
        Me.Controls.Add(Me.EmailChngtxtbx)
        Me.Controls.Add(Me.TeleChngtxtbx)
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
        Me.Controls.Add(Me.EditCustomerTitlelbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Customer_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer_Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
    Friend WithEvents Countrylbl As System.Windows.Forms.Label
    Friend WithEvents PCodelbl As System.Windows.Forms.Label
    Friend WithEvents Citylbl As System.Windows.Forms.Label
    Friend WithEvents Streetlbl As System.Windows.Forms.Label
    Friend WithEvents ConNamlbl As System.Windows.Forms.Label
    Friend WithEvents Emaillbl As System.Windows.Forms.Label
    Friend WithEvents Telelbl As System.Windows.Forms.Label
    Friend WithEvents Desclbl As System.Windows.Forms.Label
    Friend WithEvents CountryChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents PCodeChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents CityChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents StreetChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ConNamChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents EmailChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents TeleChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents DescChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents IDChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents NameChngtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents IDlbl As System.Windows.Forms.Label
    Friend WithEvents Namelbl As System.Windows.Forms.Label
    Friend WithEvents EditInstructlbl As System.Windows.Forms.Label
    Friend WithEvents IDSearchlbl As System.Windows.Forms.Label
    Friend WithEvents NameSearchlbl As System.Windows.Forms.Label
    Friend WithEvents SearchInstructlbl As System.Windows.Forms.Label
    Friend WithEvents IDSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents NameSrchtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents EditCustomerTitlelbl As System.Windows.Forms.Label
End Class
