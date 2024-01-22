Imports System.IO

'Imports definitions from validation class.
Imports BusinessManagementSystem.Validation
'On this form, the owner can edit a product within the system.
Public Class Product_Edit
    'Glabal variables declared.
    Public Shared NameSearch, IDSearch, PIDInFile As String
    'When the back button is clicked, the products formw will open.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Products.Show()
    End Sub
    'When the product edit form loads, the products form closes and various text boxes are disabled.
    Private Sub Product_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Products.Close()
        'Text boxes are disables as user has to search and find a product in order to edit it.
        NameChngtxtbx.Enabled = False
        IDChngtxtbx.Enabled = False
        DescChngtxtbx.Enabled = False
        WeiChngtxtbx.Enabled = False
        PriChngtxtbx.Enabled = False
        MatChngtxtbx.Enabled = False
        StockChngtxtbx.Enabled = False
        DimChngtxtbx.Enabled = False
        MacNumChngtxtbx.Enabled = False
        WiSiChngtxtbx.Enabled = False
        Editbtn.Enabled = False
    End Sub
    'Allows the user to edit a specifit product in the product file. 
    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        'Declare variables
        Dim Path1, Path2, Line, NameEdit, IDEdit, DescEdit, MatEdit, DimEdit, MacNumEdit, WeiEdit, StockEdit, WiSiEdit, PriEdit As String
        Dim ProductChanged, ProductFound, ProductCheck, ProductDupe As Boolean
        Dim Validation As New Validation

        'Initialize variables
        ProductFound = False
        ProductChanged = False

        NameEdit = NameChngtxtbx.Text.ToUpper
        IDEdit = IDChngtxtbx.Text.ToUpper
        DescEdit = DescChngtxtbx.Text.ToUpper
        WeiEdit = WeiChngtxtbx.Text
        PriEdit = PriChngtxtbx.Text
        MatEdit = MatChngtxtbx.Text.ToUpper
        StockEdit = StockChngtxtbx.Text
        DimEdit = DimChngtxtbx.Text.ToUpper
        MacNumEdit = MacNumChngtxtbx.Text.ToUpper
        WiSiEdit = WiSiChngtxtbx.Text

        'Remove commas from all variables so that new fields are't created when saving to the comma seperated files.
        NameEdit = Replace(NameEdit, ",", "")
        IDEdit = Replace(IDEdit, ",", "")
        DescEdit = Replace(DescEdit, ",", "")
        WeiEdit = Replace(WeiEdit, ",", "")
        PriEdit = Replace(PriEdit, ",", "")
        MatEdit = Replace(MatEdit, ",", "")
        StockEdit = Replace(StockEdit, ",", "")
        DimEdit = Replace(DimEdit, ",", "")
        MacNumEdit = Replace(MacNumEdit, ",", "")
        WiSiEdit = Replace(WiSiEdit, ",", "")

        'Checks the products file to ensure that the product ID doesn't exist already.
        Path1 = Directory.GetCurrentDirectory() & "\Products.txt"
        FileClose(1)
        FileOpen(1, Path1, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If IDEdit = Fields(1) Then
                ProductCheck = True
                If IDEdit = PIDInFile Then
                    ProductCheck = False
                End If
            End If
        Loop
        FileClose(1)

        'If the products ID already exists and doesn't match the old one, the product will not be added.
        If ProductCheck = True Then
            ProductDupe = True
        End If

        If ProductDupe = False Then

            'If the following fields are blank, the product will not be edited.
            If PriEdit <> "" Then
                If WeiEdit <> "" Then
                    If StockEdit <> "" Then

                        'If certain variables meet validation requirements then the customer will be added to the file.
                        If Validation.AddPrice(PriEdit) = True Then
                            If Validation.AddWeight(WeiEdit) = True Then
                                If Validation.AddStock(StockEdit) = True Then

                                    Path1 = Directory.GetCurrentDirectory() & "\Products.txt"
                                    Path2 = Directory.GetCurrentDirectory() & "\tempfile.txt"

                                    'Opens the products file and a temp products file.
                                    FileClose(1)
                                    FileClose(2)
                                    FileOpen(1, Path1, OpenMode.Input)
                                    FileOpen(2, Path2, OpenMode.Output)
                                    'Finds the specific product in the products file and edits it based on what the user entered into the text boxes.
                                    Do While Not EOF(1)
                                        Line = LineInput(1)
                                        Dim Fields As String() = Line.Split(New Char() {","c})
                                        Fields(0) = Replace(Fields(0), " ", "")
                                        'If the name or ID in the file match the ones entered by the user then product found is set to true,
                                        If Fields(0) = NameSearch Or Fields(1) = IDSearch Then
                                            ProductFound = True
                                        Else
                                            ProductFound = False
                                        End If
                                        'If found the text from the text boxes will be saved to the file.
                                        If ProductFound = True Then
                                            Fields(0) = NameEdit
                                            Fields(1) = IDEdit
                                            Fields(2) = DescEdit
                                            Fields(3) = WeiEdit
                                            Fields(4) = PriEdit
                                            Fields(5) = MatEdit
                                            Fields(6) = StockEdit
                                            Fields(7) = DimEdit
                                            Fields(8) = MacNumEdit
                                            Fields(9) = WiSiEdit
                                            Line = Fields(0) & "," & Fields(1) & "," & Fields(2) & "," & Fields(3) & "," & Fields(4) & "," & Fields(5) & "," & Fields(6) & "," & Fields(7) & "," & Fields(8) & "," & Fields(9)
                                            PrintLine(2, Line)
                                            ProductFound = False
                                            ProductChanged = True
                                            'If not found, the line will be copied over to the temp file.
                                        ElseIf ProductFound = False Then
                                            PrintLine(2, Line)
                                        End If
                                    Loop
                                    FileClose(1)
                                    FileClose(2)

                                    'Deletes the products file then renames the temp file as the products file.
                                    My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Products.txt")
                                    Rename(Directory.GetCurrentDirectory() & "\tempfile.txt", Directory.GetCurrentDirectory() & "\Products.txt")

                                    'A message box is displayed for each variable that doesn't meet the validation requirements.
                                Else
                                    MsgBox("Stock is in incorrect format." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                                End If
                            Else
                                MsgBox("Weight is in incorrect format." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                            End If
                        Else
                            MsgBox("Price is in incorrect format." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                        End If

                        'If the product has been edited, it will tell the user. If not, it will also tell the user.
                        If ProductChanged = True Then
                            MsgBox("The product has been edited.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Product Edited")
                            NameChngtxtbx.Enabled = False
                            IDChngtxtbx.Enabled = False
                            DescChngtxtbx.Enabled = False
                            WeiChngtxtbx.Enabled = False
                            PriChngtxtbx.Enabled = False
                            MatChngtxtbx.Enabled = False
                            StockChngtxtbx.Enabled = False
                            DimChngtxtbx.Enabled = False
                            MacNumChngtxtbx.Enabled = False
                            WiSiChngtxtbx.Enabled = False
                            Editbtn.Enabled = False
                        Else
                            MsgBox("The product could not be edited.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Product Edit Failure")
                        End If

                    Else
                        MsgBox("Stock cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                    End If
                Else
                    MsgBox("Weight cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                End If
            Else
                MsgBox("Price cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
            End If

        Else
            MsgBox("ID already exists, please choose another.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ID Duplicate.")
        End If

    End Sub
    'Allows the user to search for a specific product that they want to edit.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path1, Line As String
        Dim ProductSearched, MsgBoxDisplay As Boolean

        'Initialize variables
        NameSearch = NameSrchtxtbx.Text.ToUpper
        IDSearch = IDSrchtxtbx.Text.ToUpper

        ProductSearched = False
        MsgBoxDisplay = True

        Path1 = Directory.GetCurrentDirectory() & "\Products.txt"

        FileClose(1)
        FileOpen(1, Path1, OpenMode.Input)
        'Searches products file for a specific product.
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If Fields(0) = NameSearch Or Fields(1) = IDSearch Then
                ProductSearched = True
            Else
                ProductSearched = False
            End If
            'If found, text boxes will be enables allowing the user to begin editing.
            If ProductSearched = True Then
                NameChngtxtbx.Enabled = True
                IDChngtxtbx.Enabled = True
                DescChngtxtbx.Enabled = True
                WeiChngtxtbx.Enabled = True
                PriChngtxtbx.Enabled = True
                MatChngtxtbx.Enabled = True
                StockChngtxtbx.Enabled = True
                DimChngtxtbx.Enabled = True
                MacNumChngtxtbx.Enabled = True
                WiSiChngtxtbx.Enabled = True
                Editbtn.Enabled = True

                'Puts text from file into text boxes so the user can easily edit it.
                NameChngtxtbx.Text = Fields(0)
                IDChngtxtbx.Text = Fields(1)
                PIDInFile = Fields(1)
                DescChngtxtbx.Text = Fields(2)
                WeiChngtxtbx.Text = Fields(3)
                PriChngtxtbx.Text = Fields(4)
                MatChngtxtbx.Text = Fields(5)
                StockChngtxtbx.Text = Fields(6)
                DimChngtxtbx.Text = Fields(7)
                MacNumChngtxtbx.Text = Fields(8)
                WiSiChngtxtbx.Text = Fields(9)
                MsgBoxDisplay = False
            End If
        Loop
        FileClose(1)

        'If a specific product is not found, a message box is displayed informing the user.
        If MsgBoxDisplay = True Then
            MsgBox("The product could not be found.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Product Not found")
        End If
    End Sub
End Class