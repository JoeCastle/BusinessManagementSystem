Imports System.IO

'Bring in definitions from validation class.
Imports BusinessManagementSystem.Validation
'On this form, the owner can change the password for either the owner or employee account.
Public Class Change_Password
    'This sub runs when the form loads. It closes the owner main form when the change password form loads.
    Private Sub Change_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner_Main.Close()
    End Sub
    'When the back button is clicked, the owner main form opens.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Owner_Main.Show()
    End Sub
    'Clicking the change password button will allow the user to change a password for their chosen account.
    Private Sub ChangePassbtn_Click(sender As Object, e As EventArgs) Handles ChangePassbtn.Click
        'Declare variables.
        Dim UsernameChoice, CurrentPassword, NewPassword, ConfirmPassword, UsernameInFile, Path, Path2, Line As String
        Dim AccountFound, PasswordChanged, PasswordMatch As Boolean
        Dim AccessLevel As Integer
        Dim Validation As New Validation

        'Initialize variables.
        PasswordMatch = True
        AccountFound = False
        UsernameChoice = Usernametxtbx.Text
        CurrentPassword = CurrentPasstxtbx.Text
        NewPassword = NewPasstxtbx.Text
        ConfirmPassword = ConfirmPasstxtbx.Text

        'Remove commas from selected variables so that new fields aran't added to the file.
        NewPassword = Replace(NewPassword, ",", "")
        ConfirmPassword = Replace(ConfirmPassword, ",", "")

        If NewPassword <> "" Then

            'New password user entered goes into a function. If it matches the validation requirements it returns true.
            If Validation.NewPasswordValidation(NewPassword) = False Then
                MsgBox("New password does not meet requirements.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Change Password Failure.")
            ElseIf Validation.NewPasswordValidation(NewPassword) = True Then
                Path = Directory.GetCurrentDirectory() & "\Login_Details.txt"
                Path2 = Directory.GetCurrentDirectory() & "\Temp_Login_Details.txt"

                'Login details file and temp file are opened.
                FileClose(1)
                FileClose(2)
                FileOpen(1, Path, OpenMode.Input)
                FileOpen(2, Path2, OpenMode.Output)
                'Loops until the end of the file has been reached.
                Do While Not EOF(1)
                    Line = LineInput(1)
                    'Splits the strings in the file with commas to create fields.
                    Dim Fields As String() = Line.Split(New Char() {","c})
                    'Replaces any spaces in the file with nothing so they are not included when matching the correct characters.
                    Fields(0) = Replace(Fields(0), " ", "")
                    UsernameInFile = Fields(0)
                    'Checks if username in file matches the username the user chose.
                    If Fields(0) = UsernameChoice Then
                        Fields(1) = Replace(Fields(1), " ", "")
                        AccessLevel = Fields(2)
                        'Checks if password in file matches the password the user entered.
                        If Fields(1) = CurrentPassword Then
                            AccountFound = True
                            'Checks to see if the new password and confirm password match.
                            If NewPassword = ConfirmPassword Then
                                PasswordMatch = True
                            Else
                                PasswordMatch = False
                            End If
                        Else
                            AccountFound = False
                        End If
                    End If

                    'If both the username and password match, account found is se to true and the username, new password and access level are added to the temp file.
                    If AccountFound = True And PasswordMatch = True Then
                        Line = UsernameInFile & "," & NewPassword & "," & AccessLevel
                        PrintLine(2, Line)
                        AccountFound = False
                        PasswordChanged = True
                        'If not, then they are copied over to the temp file.
                    Else
                        PrintLine(2, Line)
                    End If
                Loop
                FileClose(1)
                FileClose(2)

                'Deletes the origional login details file and renames the temporary file to the login details file.
                My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Login_Details.txt")
                Rename(Directory.GetCurrentDirectory() & "\Temp_Login_Details.txt", Directory.GetCurrentDirectory() & "\Login_Details.txt")

                'A message box will be displayed to informa the user whether or not the password has been changed.
                If PasswordChanged = False Then
                    If PasswordMatch = False Then
                        MsgBox("New and confirm password do not match", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Passwords Do Not Match")
                    End If
                    If AccountFound = False Then
                        MsgBox("The account could not be found.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Account Not Found")
                    End If
                ElseIf PasswordChanged = True Then
                    MsgBox("The password has been changed", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Change Complete")
                    Usernametxtbx.Clear()
                    CurrentPasstxtbx.Clear()
                    NewPasstxtbx.Clear()
                    ConfirmPasstxtbx.Clear()
                End If
            End If
        Else
            MsgBox("New password cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
        End If
    End Sub
End Class