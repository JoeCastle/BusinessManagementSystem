Imports System.IO

'Imports definitions from validation class.
Imports BusinessManagementSystem.Validation
'On this form, the owner can add a new supplier into the system.
Public Class Supplier_Add
    'Closes the suppliers form when the supplier add form loads.
    Private Sub Supplier_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Suppliers.Close()
    End Sub
    'Allows the user to add a supplier to the suppliers file.
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        'Declare variables.
        Dim Path, Line, SName, SID, SDescription, SEmail, SConName, SStreet, SCity, SPCode, SCountry As String
        Dim STele As String
        Dim SupplierCheck, SupplierDupe As Boolean
        Dim Validation As New Validation

        'Initialize variables
        SName = NameAddtxtbx.Text.ToUpper
        SID = IDAddtxtbx.Text.ToUpper
        SDescription = DescAddtxtbx.Text.ToUpper
        STele = TeleAddtxtbx.Text
        SEmail = EmailAddtxtbx.Text.ToUpper
        SConName = ConNamAddtxtbx.Text.ToUpper
        SStreet = StreetAddtxtbx.Text.ToUpper
        SCity = CityAddtxtbx.Text.ToUpper
        SPCode = PCodeAddtxtbx.Text.ToUpper
        SCountry = CountryAddtxtbx.Text.ToUpper

        'Remove commas from all variables so that new fields are't created when saving to the comma seperated files.
        SName = Replace(SName, ",", "")
        SID = Replace(SID, ",", "")
        SDescription = Replace(SDescription, ",", "")
        STele = Replace(STele, ",", "")
        SEmail = Replace(SEmail, ",", "")
        SConName = Replace(SConName, ",", "")
        SStreet = Replace(SStreet, ",", "")
        SCity = Replace(SCity, ",", "")
        SPCode = Replace(SPCode, ",", "")
        SCountry = Replace(SCountry, ",", "")

        'Searches the supplier file to ensure that the supplier ID doesn't exist already.
        Path = Directory.GetCurrentDirectory() & "\Suppliers.txt"
        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If SID = Fields(1) Then
                SupplierCheck = True
            End If
        Loop
        FileClose(1)

        'If the ID is found, the supplier will not be added.
        If SupplierCheck = True Then
            SupplierDupe = True
        End If

        If SupplierDupe = False Then

            'If any of the following fields are blank, the supplier will not be added to the system.
            If SEmail <> "" Then
                If STele <> "" Then
                    If SPCode <> "" Then

                        'If certain variables meet validation requirements then the customer will be added to the file.
                        If Validation.AddEmailValidation(SEmail) = True Then
                            If Validation.AddPostCodeValidation(SPCode) = True Then
                                If Validation.AddTelephoneValidation(STele) = True Then

                                    Path = Directory.GetCurrentDirectory() & "\Suppliers.txt"
                                    FileClose(1)
                                    'Opens supplier file and appends the new supplier.
                                    FileOpen(1, Path, OpenMode.Append)
                                    Line = SName & "," & SID & "," & SDescription & "," & STele & "," & SEmail & "," & SConName & "," & SStreet & "," & SCity & "," & SPCode & "," & SCountry
                                    PrintLine(1, Line)
                                    FileClose(1)

                                    MsgBox("The supplier has been added to the system.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Supplier Added")

                                    NameAddtxtbx.Clear()
                                    IDAddtxtbx.Clear()
                                    DescAddtxtbx.Clear()
                                    TeleAddtxtbx.Clear()
                                    EmailAddtxtbx.Clear()
                                    ConNamAddtxtbx.Clear()
                                    StreetAddtxtbx.Clear()
                                    CityAddtxtbx.Clear()
                                    PCodeAddtxtbx.Clear()
                                    CountryAddtxtbx.Clear()
                                    'A message box is displayed for each variable that doesn't meet the validation requirements.
                                Else
                                    MsgBox("Telephone is in incorrect format." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                                End If
                            Else
                                MsgBox("Postcode is in incorrect format." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                            End If
                        Else
                            MsgBox("Email is in incorrect format." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
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
    'When the clear button is clicked, all of the text boxes are cleared.
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        NameAddtxtbx.Clear()
        IDAddtxtbx.Clear()
        DescAddtxtbx.Clear()
        TeleAddtxtbx.Clear()
        EmailAddtxtbx.Clear()
        ConNamAddtxtbx.Clear()
        StreetAddtxtbx.Clear()
        CityAddtxtbx.Clear()
        PCodeAddtxtbx.Clear()
        CountryAddtxtbx.Clear()
    End Sub
    'When the back button is clicked, the suppliers form will open.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Suppliers.Show()
    End Sub
End Class