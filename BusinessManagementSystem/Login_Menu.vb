Imports System.IO

'On this form, the user can login to the system or return to the main menu. The user can either login as owner or employee.
Public Class Login_Menu
    'Declare global variables.
    Public Shared Username, Password As String
    'When the login menu for loads, various other forms are closed.
    Private Sub Login_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Close()
        Owner_Main.Close()
        Employee_Main.Close()
    End Sub
    'Clicking the back button will show the main menu.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Main.Show()
    End Sub
    'Clicking the enter button will allow the user to login if the username and password are correct.
    Private Sub Enterbtn_Click(sender As Object, e As EventArgs) Handles Enterbtn.Click
        'Declare variables
        Dim Path, UsernameCheck As String
        Dim LoginFound As Boolean

        'Initialize variables.
        LoginFound = False
        Username = Usernametxtbx.Text
        Password = Passwordtxtbx.Text
        Path = Directory.GetCurrentDirectory() & "\Login_Details.txt"

        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        'Checks if username and password entered by the user match the ones in the file
        'Loops until the end of the file has been reached
        Do While Not EOF(1)
            UsernameCheck = LineInput(1)
            'Splits the strings in the file with commas to create fields
            Dim Fields As String() = UsernameCheck.Split(New Char() {","c})
            'Replaces any spaces in the file with nothing so they are not included when matching the correct characters
            Fields(0) = Replace(Fields(0), " ", "")
            If Fields(0) = Username Then
                Fields(1) = Replace(Fields(1), " ", "")
                If Fields(1) = Password Then
                    LoginFound = True
                    If Fields(2) = "1" Then
                        Owner_Main.Show()
                    ElseIf Fields(2) = "0" Then
                        Employee_Main.Show()
                    End If
                End If
            End If
        Loop
        FileClose(1)

        'This If statement displays an error message if the user enters an incorrect username or password
        If LoginFound = False Then
            MsgBox("The username or password is incorrect.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Login Failure")
        End If

    End Sub
End Class