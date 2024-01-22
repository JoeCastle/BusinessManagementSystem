'This is the first form that opens when they start the system. From here the user can continue to the login menu or exit the system.
Public Class Main
    'When Main form loads, Login Menu form closes
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login_Menu.Close()
    End Sub
    'When continue button clicked, the Login Menu form shown
    Private Sub Continuebtn_Click(sender As Object, e As EventArgs) Handles Continuebtn.Click
        Login_Menu.Show()
    End Sub
    'When exit button is clicked, a message box is shown.
    'If yes is clicked the system will close.
    'If no is clicked, thhe message box will close.
    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Dim QuitResponse As Integer
        QuitResponse = MsgBox("Are you sure that you want to quit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Quit")
        If QuitResponse = vbYes Then
            Close()
        End If
    End Sub
End Class
