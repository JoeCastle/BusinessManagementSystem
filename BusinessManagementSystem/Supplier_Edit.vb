Imports System.IO

'Import definitions from validation class
Imports BusinessManagementSystem.Validation
'On this form, the owner can edit an existing supplier in the system.
Public Class Supplier_Edit
    'Glabal variables declared.
    Public Shared NameSearch, IDSearch, SIDInFile As String
    'When the back button is clicked, the suppliers form will open.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Suppliers.Show()
    End Sub
    'When the supplier edit form loads, the suppliers form closes and various text boxes are disabled.
    Private Sub Supplier_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Suppliers.Close()
        'Text boxes are disables as user has to search first.
        NameChngtxtbx.Enabled = False
        IDChngtxtbx.Enabled = False
        DescChngtxtbx.Enabled = False
        TeleChngtxtbx.Enabled = False
        EmailChngtxtbx.Enabled = False
        ConNamChngtxtbx.Enabled = False
        StreetChngtxtbx.Enabled = False
        CityChngtxtbx.Enabled = False
        PCodeChngtxtbx.Enabled = False
        CountryChngtxtbx.Enabled = False
        Editbtn.Enabled = False
    End Sub
    'Allows the user to edit a specifit supplier in the supplier file. 
    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        'Declare variables
        Dim Path1, Path2, Line, SNameEdit, SIDEdit, SDescEdit, STeleEdit, SEmailEdit, SConNameEdit, SStreetEdit, SCityEdit, SPCodeEdit, SCountryEdit As String
        Dim SupplierChanged, SupplierFound, SupplierCheck, SupplierDupe As Boolean
        Dim Validation As New Validation

        'Initialize variables
        SupplierFound = False
        SupplierChanged = False

        SNameEdit = NameChngtxtbx.Text.ToUpper
        SIDEdit = IDChngtxtbx.Text.ToUpper
        SDescEdit = DescChngtxtbx.Text.ToUpper
        STeleEdit = TeleChngtxtbx.Text.ToUpper
        SEmailEdit = EmailChngtxtbx.Text.ToUpper
        SConNameEdit = ConNamChngtxtbx.Text.ToUpper
        SStreetEdit = StreetChngtxtbx.Text.ToUpper
        SCityEdit = CityChngtxtbx.Text.ToUpper
        SPCodeEdit = PCodeChngtxtbx.Text.ToUpper
        SCountryEdit = CountryChngtxtbx.Text.ToUpper

        'Remove commas from all variables so that new fields are't created when saving to the comma seperated files.
        SNameEdit = Replace(SNameEdit, ",", "")
        SIDEdit = Replace(SIDEdit, ",", "")
        SDescEdit = Replace(SDescEdit, ",", "")
        STeleEdit = Replace(STeleEdit, ",", "")
        SEmailEdit = Replace(SEmailEdit, ",", "")
        SConNameEdit = Replace(SConNameEdit, ",", "")
        SStreetEdit = Replace(SStreetEdit, ",", "")
        SCityEdit = Replace(SCityEdit, ",", "")
        SPCodeEdit = Replace(SPCodeEdit, ",", "")
        SCountryEdit = Replace(SCountryEdit, ",", "")

        'Checks the suppliers file to ensure the supplier ID doesn't already exist.
        Path1 = Directory.GetCurrentDirectory() & "\Suppliers.txt"
        FileClose(1)
        FileOpen(1, Path1, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If SIDEdit = Fields(1) Then
                SupplierCheck = True
                If SIDEdit = SIDInFile Then
                    SupplierCheck = False
                End If
            End If
        Loop
        FileClose(1)

        'If the supplier ID exists and doesn't match the old one, the uppier will not be edited.
        If SupplierCheck = True Then
            SupplierDupe = True
        End If

        If SupplierDupe = False Then

            'If the following fields are blank, the supplier will not be edited.
            If SEmailEdit <> "" Then
                If STeleEdit <> "" Then
                    If SPCodeEdit <> "" Then

                        'If certain variables meet validation requirements then the customer will be added to the file.
                        If Validation.AddEmailValidation(SEmailEdit) = True Then
                            If Validation.AddPostCodeValidation(SPCodeEdit) = True Then
                                If Validation.AddTelephoneValidation(STeleEdit) = True Then
                                    Path1 = Directory.GetCurrentDirectory() & "\Suppliers.txt"
                                    Path2 = Directory.GetCurrentDirectory() & "\tempfile.txt"

                                    'Opens the Suppliers file and a temp Suppliers file.
                                    FileClose(1)
                                    FileClose(2)
                                    FileOpen(1, Path1, OpenMode.Input)
                                    FileOpen(2, Path2, OpenMode.Output)
                                    'Finds the specific supplier in the suppliers file and edits it based on what the user entered into the text boxes.
                                    Do While Not EOF(1)
                                        Line = LineInput(1)
                                        Dim Fields As String() = Line.Split(New Char() {","c})
                                        Fields(0) = Replace(Fields(0), " ", "")
                                        'If the name or ID in the file match the ones entered by the user then supplier found is set to true.
                                        If Fields(0) = NameSearch Or Fields(1) = IDSearch Then
                                            SupplierFound = True
                                        Else
                                            SupplierFound = False
                                        End If
                                        'If found, the text from the text boxes will be saved to the file.
                                        If SupplierFound = True Then
                                            Fields(0) = SNameEdit
                                            Fields(1) = SIDEdit
                                            Fields(2) = SDescEdit
                                            Fields(3) = STeleEdit
                                            Fields(4) = SEmailEdit
                                            Fields(5) = SConNameEdit
                                            Fields(6) = SStreetEdit
                                            Fields(7) = SCityEdit
                                            Fields(8) = SPCodeEdit
                                            Fields(9) = SCountryEdit
                                            Line = Fields(0) & "," & Fields(1) & "," & Fields(2) & "," & Fields(3) & "," & Fields(4) & "," & Fields(5) & "," & Fields(6) & "," & Fields(7) & "," & Fields(8) & "," & Fields(9)
                                            PrintLine(2, Line)
                                            SupplierFound = False
                                            SupplierChanged = True
                                            'If not found, the line will be copied over to the temp file.
                                        ElseIf SupplierFound = False Then
                                            PrintLine(2, Line)
                                        End If
                                    Loop
                                    FileClose(1)
                                    FileClose(2)

                                    'Deletes the suppliers file then renames the temp file as the suppliers file.
                                    My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Suppliers.txt")
                                    Rename(Directory.GetCurrentDirectory() & "\tempfile.txt", Directory.GetCurrentDirectory() & "\Suppliers.txt")

                                    'A message box is displayed for each variable that doesn't meet the validation requirements.
                                Else
                                    MsgBox("Telephone is in incorrect format.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                                End If
                            Else
                                MsgBox("Postcode is in incorrect format.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                            End If
                        Else
                            MsgBox("Email is in incorrect format.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                        End If

                        'If the supplier has been edited, it will tell the user. If not, it will also tell the user.
                        If SupplierChanged = True Then
                            MsgBox("The Supplier has been edited.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Supplier Edited")
                            NameChngtxtbx.Enabled = False
                            IDChngtxtbx.Enabled = False
                            DescChngtxtbx.Enabled = False
                            TeleChngtxtbx.Enabled = False
                            EmailChngtxtbx.Enabled = False
                            ConNamChngtxtbx.Enabled = False
                            StreetChngtxtbx.Enabled = False
                            CityChngtxtbx.Enabled = False
                            PCodeChngtxtbx.Enabled = False
                            CountryChngtxtbx.Enabled = False
                            Editbtn.Enabled = False
                        Else
                            MsgBox("The Supplier could not be edited.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Supplier Edit Failure")
                        End If

                    Else
                        MsgBox("Postcode cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                    End If
                Else
                    MsgBox("Telephone cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                End If
            Else
                MsgBox("Email cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
            End If

        Else
            MsgBox("ID already exists, please choose another.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ID Duplicate.")
        End If

    End Sub
    'Allows the user to search for a specific supplier that they want to edit.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables.
        Dim Path1, Line As String
        Dim SupplierSearched, MsgBoxDisplay As Boolean

        'Initialize variables.
        NameSearch = NameSrchtxtbx.Text.ToUpper
        IDSearch = IDSrchtxtbx.Text.ToUpper
        SupplierSearched = False
        MsgBoxDisplay = True

        Path1 = Directory.GetCurrentDirectory() & "\Suppliers.txt"

        FileClose(1)
        FileOpen(1, Path1, OpenMode.Input)
        'Searches suppliers file for a specific Supplier.
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            'If either the name or the ID match the one in the file, supplier searched is set to true.
            If Fields(0) = NameSearch Or Fields(1) = IDSearch Then
                SupplierSearched = True
            Else
                SupplierSearched = False
            End If
            'If found, text boxes will be enables allowing the user to begin editing.
            If SupplierSearched = True Then
                NameChngtxtbx.Enabled = True
                IDChngtxtbx.Enabled = True
                DescChngtxtbx.Enabled = True
                TeleChngtxtbx.Enabled = True
                EmailChngtxtbx.Enabled = True
                ConNamChngtxtbx.Enabled = True
                StreetChngtxtbx.Enabled = True
                CityChngtxtbx.Enabled = True
                PCodeChngtxtbx.Enabled = True
                CountryChngtxtbx.Enabled = True
                Editbtn.Enabled = True

                'Puts text from file into text boxes so the user can easily edit it.
                NameChngtxtbx.Text = Fields(0)
                IDChngtxtbx.Text = Fields(1)
                SIDInFile = Fields(1)
                DescChngtxtbx.Text = Fields(2)
                TeleChngtxtbx.Text = Fields(3)
                EmailChngtxtbx.Text = Fields(4)
                ConNamChngtxtbx.Text = Fields(5)
                StreetChngtxtbx.Text = Fields(6)
                CityChngtxtbx.Text = Fields(7)
                PCodeChngtxtbx.Text = Fields(8)
                CountryChngtxtbx.Text = Fields(9)
                MsgBoxDisplay = False
            End If
        Loop
        FileClose(1)

        'If a specific Supplier is not found, a message box is displayed informing the user.
        If MsgBoxDisplay = True Then
            MsgBox("The Supplier could not be found", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Supplier Not found")
        End If
    End Sub
End Class