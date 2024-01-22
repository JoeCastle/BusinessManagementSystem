Imports System.IO

'Bring in definitions from validation class.
Imports BusinessManagementSystem.Validation
'On this form the owner can edit an existing customer in the system.
Public Class Customer_Edit
    'Glabal variables declared.
    Public Shared NameSearch, IDSearch, CIDInFile As String
    'When the back button is clicked, the customers form will open.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Customers.Show()
    End Sub
    'When the customer edit form loads, the customers form closes and various text boxes are disabled.
    Private Sub Customer_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customers.Close()
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
    'Allows the user to edit a specifit customer in the customer file. 
    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        Dim Path1, Path2, Line, CNameEdit, CIDEdit, CDescEdit, CTeleEdit, CEmailEdit, CConNameEdit, CStreetEdit, CCityEdit, CPCodeEdit, CCountryEdit As String
        Dim CustomerChanged, CustomerFound, CustomerCheck, CustomerDupe As Boolean
        Dim Validation As New Validation

        'Initialize variables.
        CustomerFound = False
        CustomerChanged = False

        CNameEdit = NameChngtxtbx.Text.ToUpper
        CIDEdit = IDChngtxtbx.Text.ToUpper
        CDescEdit = DescChngtxtbx.Text.ToUpper
        CTeleEdit = TeleChngtxtbx.Text.ToUpper
        CEmailEdit = EmailChngtxtbx.Text.ToUpper
        CConNameEdit = ConNamChngtxtbx.Text.ToUpper
        CStreetEdit = StreetChngtxtbx.Text.ToUpper
        CCityEdit = CityChngtxtbx.Text.ToUpper
        CPCodeEdit = PCodeChngtxtbx.Text.ToUpper
        CCountryEdit = CountryChngtxtbx.Text.ToUpper

        'Remove commas from all variables so that new fields are't created when saving to the comma seperated files.
        CNameEdit = Replace(CNameEdit, ",", "")
        CIDEdit = Replace(CIDEdit, ",", "")
        CDescEdit = Replace(CDescEdit, ",", "")
        CTeleEdit = Replace(CTeleEdit, ",", "")
        CEmailEdit = Replace(CEmailEdit, ",", "")
        CConNameEdit = Replace(CConNameEdit, ",", "")
        CStreetEdit = Replace(CStreetEdit, ",", "")
        CCityEdit = Replace(CCityEdit, ",", "")
        CPCodeEdit = Replace(CPCodeEdit, ",", "")
        CCountryEdit = Replace(CCountryEdit, ",", "")

        'Checks the customers file to ensure that the customer Id doesn't exist already.
        Path1 = Directory.GetCurrentDirectory() & "\Customers.txt"
        FileClose(1)
        FileOpen(1, Path1, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If CIDEdit = Fields(1) Then
                CustomerCheck = True
                If CIDEdit = CIDInFile Then
                    CustomerCheck = False
                End If
            End If
        Loop
        FileClose(1)

        'If the customer ID is found and doesn't match the old one, the customer will not be edited.
        If CustomerCheck = True Then
            CustomerDupe = True
        End If

        If CustomerDupe = False Then

            'If the following fields are blank, the custoemr will not be edited.
            If CEmailEdit <> "" Then
                If CTeleEdit <> "" Then
                    If CPCodeEdit <> "" Then

                        'If certain variables meet validation requirements then the customer will be edited.
                        If Validation.AddEmailValidation(CEmailEdit) = True Then
                            If Validation.AddPostCodeValidation(CPCodeEdit) = True Then
                                If Validation.AddTelephoneValidation(CTeleEdit) = True Then
                                    Path1 = Directory.GetCurrentDirectory() & "\Customers.txt"
                                    Path2 = Directory.GetCurrentDirectory() & "\tempfile.txt"

                                    'Opens the customers file and a temp customers file.
                                    FileClose(1)
                                    FileClose(2)
                                    FileOpen(1, Path1, OpenMode.Input)
                                    FileOpen(2, Path2, OpenMode.Output)
                                    'Finds the specific customer in the customers file and edits it based on what the user entered into the text boxes.
                                    Do While Not EOF(1)
                                        Line = LineInput(1)
                                        Dim Fields As String() = Line.Split(New Char() {","c})
                                        Fields(0) = Replace(Fields(0), " ", "")
                                        'If the name or ID in the file match the ones entered by the user then customer found is set to true.
                                        If Fields(0) = NameSearch Or Fields(1) = IDSearch Then
                                            CustomerFound = True
                                        Else
                                            CustomerFound = False
                                        End If
                                        'If found, the text from the text boxes will be saved to the file.
                                        If CustomerFound = True Then
                                            Fields(0) = CNameEdit
                                            Fields(1) = CIDEdit
                                            Fields(2) = CDescEdit
                                            Fields(3) = CTeleEdit
                                            Fields(4) = CEmailEdit
                                            Fields(5) = CConNameEdit
                                            Fields(6) = CStreetEdit
                                            Fields(7) = CCityEdit
                                            Fields(8) = CPCodeEdit
                                            Fields(9) = CCountryEdit
                                            Line = Fields(0) & "," & Fields(1) & "," & Fields(2) & "," & Fields(3) & "," & Fields(4) & "," & Fields(5) & "," & Fields(6) & "," & Fields(7) & "," & Fields(8) & "," & Fields(9)
                                            PrintLine(2, Line)
                                            CustomerFound = False
                                            CustomerChanged = True
                                            'If not found, the line will be copied over to the temp file.
                                        ElseIf CustomerFound = False Then
                                            PrintLine(2, Line)
                                        End If
                                    Loop
                                    FileClose(1)
                                    FileClose(2)

                                    'Deletes the customers file then renames the temp file as the customers file.
                                    My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Customers.txt")
                                    Rename(Directory.GetCurrentDirectory() & "\tempfile.txt", Directory.GetCurrentDirectory() & "\Customers.txt")
                                Else
                                    MsgBox("Telephone is in incorrect format.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                                End If
                            Else
                                MsgBox("Postcode is in incorrect format.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                            End If
                        Else
                            MsgBox("Email is in incorrect format.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                        End If

                        'If the customer has been edited, it will tell the user. If not, it will also tell the user.
                        If CustomerChanged = True Then
                            MsgBox("The customer has been edited", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Customer Edited")
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
                            MsgBox("The customer could not be edited.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Customer Edit Failure")
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
    'Allows the user to search for a specific customer that they want to edit.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path1, Line As String
        Dim CustomerSearched, MsgBoxDisplay As Boolean

        'Initialize variables.
        NameSearch = NameSrchtxtbx.Text.ToUpper
        IDSearch = IDSrchtxtbx.Text.ToUpper
        CustomerSearched = False
        MsgBoxDisplay = True

        Path1 = Directory.GetCurrentDirectory() & "\Customers.txt"

        FileClose(1)
        FileOpen(1, Path1, OpenMode.Input)
        'Searches customers file for a specific customer.
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If Fields(0) = NameSearch Or Fields(1) = IDSearch Then
                CustomerSearched = True
            Else
                CustomerSearched = False
            End If
            'If found, text boxes will be enables allowing the user to begin editing.
            If CustomerSearched = True Then
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
                CIDInFile = Fields(1)
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

        'If a specific customer is not found, a message box is displayed informing the user.
        If MsgBoxDisplay = True Then
            MsgBox("The customer could not be found.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Customer Not found")
        End If
    End Sub
End Class