Imports System.IO

'Bring in definitions from validation class.
Imports BusinessManagementSystem.Validation
'On this form, the owner can add a new customer to the system.
Public Class Customer_Add
    'Closes the customers form when the customer add form loads.
    Private Sub Customer_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customers.Close()
    End Sub
    'Allows the user to add a customer to the customers file.
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        'Declare variables.
        Dim Path, Line, CName, CID, CDescription, CEmail, CConName, CStreet, CCity, CPCode, CCountry, CTele As String
        Dim Validation As New Validation
        Dim CustomerCheck, CustomerDupe As Boolean

        CustomerCheck = False

        'Initialize variables.
        CName = NameAddtxtbx.Text.ToUpper
        CID = IDAddtxtbx.Text.ToUpper
        CDescription = DescAddtxtbx.Text.ToUpper
        CTele = TeleAddtxtbx.Text
        CEmail = EmailAddtxtbx.Text.ToUpper
        CConName = ConNamAddtxtbx.Text.ToUpper
        CStreet = StreetAddtxtbx.Text.ToUpper
        CCity = CityAddtxtbx.Text.ToUpper
        CPCode = PCodeAddtxtbx.Text.ToUpper
        CCountry = CountryAddtxtbx.Text.ToUpper

        'Remove commas from all variables so that new fields are't created when saving to the comma seperated files.
        CName = Replace(CName, ",", "")
        CID = Replace(CID, ",", "")
        CDescription = Replace(CDescription, ",", "")
        CTele = Replace(CTele, ",", "")
        CEmail = Replace(CEmail, ",", "")
        CConName = Replace(CConName, ",", "")
        CStreet = Replace(CStreet, ",", "")
        CCity = Replace(CCity, ",", "")
        CPCode = Replace(CPCode, ",", "")
        CCountry = Replace(CCountry, ",", "")

        'Checks the customers folder to ensure that the ID the user has entered doesn't exist already.
        Path = Directory.GetCurrentDirectory() & "\Customers.txt"
        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If CID = Fields(1) Then
                CustomerCheck = True
            End If
        Loop
        FileClose(1)

        'If the ID does exist, the customer cannot be added and a message box will be displayed.
        If CustomerCheck = True Then
            CustomerDupe = True
        End If

        If CustomerDupe = False Then

            'If any of teh following fields are blank, the customer cannot be added.
            If CEmail <> "" Then
                If CTele <> "" Then
                    If CPCode <> "" Then

                        'If certain variables meet validation requirements then the customer will be added to the file.
                        If Validation.AddEmailValidation(CEmail) = True Then
                            If Validation.AddPostCodeValidation(CPCode) = True Then
                                If Validation.AddTelephoneValidation(CTele) = True Then
                                    Path = Directory.GetCurrentDirectory() & "\Customers.txt"

                                    'Opens customer file and appends the new customer.
                                    FileOpen(1, Path, OpenMode.Append)
                                    Line = CName & "," & CID & "," & CDescription & "," & CTele & "," & CEmail & "," & CConName & "," & CStreet & "," & CCity & "," & CPCode & "," & CCountry
                                    PrintLine(1, Line)
                                    FileClose(1)

                                    MsgBox("The customer has been added to the system.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Customer Added")

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
    'When the back button is clicked, the customers form will open.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Customers.Show()
    End Sub
End Class