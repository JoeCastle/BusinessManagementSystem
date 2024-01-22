<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Analysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales_Analysis))
        Me.StartDatedttmpkr = New System.Windows.Forms.DateTimePicker()
        Me.EndDatedttmpkr = New System.Windows.Forms.DateTimePicker()
        Me.SalesAnalysisDisplayrchtxtbx = New System.Windows.Forms.RichTextBox()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Backbtn = New System.Windows.Forms.Button()
        Me.StartDatelbl = New System.Windows.Forms.Label()
        Me.EndDatelbl = New System.Windows.Forms.Label()
        Me.SalesAnalysisTitlelbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustIDlbl = New System.Windows.Forms.Label()
        Me.ProdIDlbl = New System.Windows.Forms.Label()
        Me.CustIDtxtbx = New System.Windows.Forms.TextBox()
        Me.ProdIDtxtbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StartDatedttmpkr
        '
        Me.StartDatedttmpkr.Location = New System.Drawing.Point(76, 97)
        Me.StartDatedttmpkr.Name = "StartDatedttmpkr"
        Me.StartDatedttmpkr.Size = New System.Drawing.Size(133, 20)
        Me.StartDatedttmpkr.TabIndex = 0
        '
        'EndDatedttmpkr
        '
        Me.EndDatedttmpkr.Location = New System.Drawing.Point(374, 97)
        Me.EndDatedttmpkr.Name = "EndDatedttmpkr"
        Me.EndDatedttmpkr.Size = New System.Drawing.Size(133, 20)
        Me.EndDatedttmpkr.TabIndex = 2
        '
        'SalesAnalysisDisplayrchtxtbx
        '
        Me.SalesAnalysisDisplayrchtxtbx.Location = New System.Drawing.Point(37, 197)
        Me.SalesAnalysisDisplayrchtxtbx.Name = "SalesAnalysisDisplayrchtxtbx"
        Me.SalesAnalysisDisplayrchtxtbx.ReadOnly = True
        Me.SalesAnalysisDisplayrchtxtbx.Size = New System.Drawing.Size(465, 235)
        Me.SalesAnalysisDisplayrchtxtbx.TabIndex = 3
        Me.SalesAnalysisDisplayrchtxtbx.Text = ""
        '
        'Searchbtn
        '
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.Location = New System.Drawing.Point(333, 461)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(169, 51)
        Me.Searchbtn.TabIndex = 4
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Backbtn
        '
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Location = New System.Drawing.Point(37, 461)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(172, 51)
        Me.Backbtn.TabIndex = 6
        Me.Backbtn.Text = "Back"
        Me.Backbtn.UseVisualStyleBackColor = True
        '
        'StartDatelbl
        '
        Me.StartDatelbl.AutoSize = True
        Me.StartDatelbl.Location = New System.Drawing.Point(18, 99)
        Me.StartDatelbl.Name = "StartDatelbl"
        Me.StartDatelbl.Size = New System.Drawing.Size(58, 13)
        Me.StartDatelbl.TabIndex = 7
        Me.StartDatelbl.Text = "Start Date:"
        '
        'EndDatelbl
        '
        Me.EndDatelbl.AutoSize = True
        Me.EndDatelbl.Location = New System.Drawing.Point(319, 99)
        Me.EndDatelbl.Name = "EndDatelbl"
        Me.EndDatelbl.Size = New System.Drawing.Size(55, 13)
        Me.EndDatelbl.TabIndex = 9
        Me.EndDatelbl.Text = "End Date:"
        '
        'SalesAnalysisTitlelbl
        '
        Me.SalesAnalysisTitlelbl.AutoSize = True
        Me.SalesAnalysisTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesAnalysisTitlelbl.Location = New System.Drawing.Point(176, 20)
        Me.SalesAnalysisTitlelbl.Name = "SalesAnalysisTitlelbl"
        Me.SalesAnalysisTitlelbl.Size = New System.Drawing.Size(191, 31)
        Me.SalesAnalysisTitlelbl.TabIndex = 10
        Me.SalesAnalysisTitlelbl.Text = "Sales Analysis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Please select a start date and an end date:"
        '
        'CustIDlbl
        '
        Me.CustIDlbl.AutoSize = True
        Me.CustIDlbl.Location = New System.Drawing.Point(301, 149)
        Me.CustIDlbl.Name = "CustIDlbl"
        Me.CustIDlbl.Size = New System.Drawing.Size(62, 13)
        Me.CustIDlbl.TabIndex = 35
        Me.CustIDlbl.Text = "CustomerID"
        '
        'ProdIDlbl
        '
        Me.ProdIDlbl.AutoSize = True
        Me.ProdIDlbl.Location = New System.Drawing.Point(15, 151)
        Me.ProdIDlbl.Name = "ProdIDlbl"
        Me.ProdIDlbl.Size = New System.Drawing.Size(58, 13)
        Me.ProdIDlbl.TabIndex = 34
        Me.ProdIDlbl.Text = "Product ID"
        '
        'CustIDtxtbx
        '
        Me.CustIDtxtbx.Location = New System.Drawing.Point(377, 148)
        Me.CustIDtxtbx.Name = "CustIDtxtbx"
        Me.CustIDtxtbx.Size = New System.Drawing.Size(130, 20)
        Me.CustIDtxtbx.TabIndex = 37
        '
        'ProdIDtxtbx
        '
        Me.ProdIDtxtbx.Location = New System.Drawing.Point(79, 148)
        Me.ProdIDtxtbx.Name = "ProdIDtxtbx"
        Me.ProdIDtxtbx.Size = New System.Drawing.Size(130, 20)
        Me.ProdIDtxtbx.TabIndex = 36
        '
        'Sales_Analysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 551)
        Me.Controls.Add(Me.CustIDlbl)
        Me.Controls.Add(Me.ProdIDlbl)
        Me.Controls.Add(Me.CustIDtxtbx)
        Me.Controls.Add(Me.ProdIDtxtbx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SalesAnalysisTitlelbl)
        Me.Controls.Add(Me.EndDatelbl)
        Me.Controls.Add(Me.StartDatelbl)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.SalesAnalysisDisplayrchtxtbx)
        Me.Controls.Add(Me.EndDatedttmpkr)
        Me.Controls.Add(Me.StartDatedttmpkr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sales_Analysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales_Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartDatedttmpkr As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndDatedttmpkr As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalesAnalysisDisplayrchtxtbx As System.Windows.Forms.RichTextBox
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
    Friend WithEvents Backbtn As System.Windows.Forms.Button
    Friend WithEvents StartDatelbl As System.Windows.Forms.Label
    Friend WithEvents EndDatelbl As System.Windows.Forms.Label
    Friend WithEvents SalesAnalysisTitlelbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustIDlbl As System.Windows.Forms.Label
    Friend WithEvents ProdIDlbl As System.Windows.Forms.Label
    Friend WithEvents CustIDtxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ProdIDtxtbx As System.Windows.Forms.TextBox
End Class
