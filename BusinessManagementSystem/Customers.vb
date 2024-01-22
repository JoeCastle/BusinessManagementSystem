Imports System.IO

'On this form, the user can search for a specific customer or all customers in the system.
Public Class Customers
    'Closes various forms when the customers form loads
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customer_Add.Close()
        Customer_Edit.Close()
        Customer_Delete.Close()
        'Creates a "level of access" based on the users username.
        'Closes various forms and enables or disables various buttons based on the users username.
        If Login_Menu.Username = "owner" Then
            Owner_Main.Close()
            Addbtn.Enabled = True
            Editbtn.Enabled = True
            Deletebtn.Enabled = True
        ElseIf Login_Menu.Username = "notowner" Then
            Employee_Main.Close()
            Addbtn.Enabled = False
            Editbtn.Enabled = False
            Deletebtn.Enabled = False
        End If
    End Sub
    'When the back button is clicked, a different form opens based on the users username.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        If Login_Menu.Username = "owner" Then
            Owner_Main.Show()
        ElseIf Login_Menu.Username = "notowner" Then
            Employee_Main.Show()
        End If
    End Sub
    'Allows the user to search for a specific customer by entering its name and ID.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path, Line, CustomerID, CustomerName, PreviousText As String
        Dim CustomerFound As Boolean

        'Initialize variables
        CustomerDisplayrchtxtbx.Clear()
        CustomerFound = False
        CustomerName = Nametxtbx.Text.ToUpper
        CustomerID = IDtxtbx.Text.ToUpper
        Path = Directory.GetCurrentDirectory() & "\Customers.txt"

        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        'Searches the customers file to find the correct customer.
        'Loops until the end of the file has been reached.
        Do While Not EOF(1)
            Line = LineInput(1)
            'Splits the strings in the file with commas to create fields.
            Dim Fields As String() = Line.Split(New Char() {","c})
            'Replaces any spaces in the file with nothing so they are not included when matching the correct characters
            Fields(0) = Replace(Fields(0), " ", "")
            Fields(1) = Replace(Fields(1), " ", "")
            'If either the customer name or customer id match the name or id in the file, that customer is displayed on screen.
            If Fields(0) = CustomerName Or Fields(1) = CustomerID Then
                CustomerFound = True
                Line = ("Name: " + Fields(0) + ChrW(13) + "ID: " + Fields(1) + ChrW(13) + "Description: " + Fields(2) + ChrW(13) + "Telephone: " + Fields(3) + ChrW(13) + "Email: " + Fields(4) + ChrW(13) + "Contact Name: " + Fields(5) + ChrW(13) + "Street: " + Fields(6) + ChrW(13) + "City: " + Fields(7) + ChrW(13) + "Postcode: " + Fields(8) + ChrW(13) + "Country: " + Fields(9) + ChrW(13) + ChrW(13))
                PreviousText = CustomerDisplayrchtxtbx.Text
                CustomerDisplayrchtxtbx.Text = PreviousText + Line
            End If
        Loop
        FileClose(1)

        'This If statement displays an error message if the user enters an incorrect name or ID.
        If CustomerFound = False Then
            MsgBox("That customer could not be found.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Search Failure")
        End If

    End Sub
    'Searches the entire customers file and displays all of the customers.
    Private Sub SearchAllbtn_Click(sender As Object, e As EventArgs) Handles SearchAllbtn.Click
        'Declare variables
        Dim Path, SearchAllLine, PreviousText As String
        Dim CustomerFound As Boolean

        'Initialize variables
        CustomerDisplayrchtxtbx.Clear()
        CustomerFound = False
        IDtxtbx.Clear()
        Nametxtbx.Clear()
        Path = Directory.GetCurrentDirectory() & "\Customers.txt"

        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        'Searches the customers file and displayes all customers in the file.
        Do While Not EOF(1)
            SearchAllLine = LineInput(1)
            Dim Fields As String() = SearchAllLine.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            SearchAllLine = ("Name: " + Fields(0) + ChrW(13) + "ID: " + Fields(1) + ChrW(13) + "Description: " + Fields(2) + ChrW(13) + "Telephone: " + Fields(3) + ChrW(13) + "Email: " + Fields(4) + ChrW(13) + "Contact Name: " + Fields(5) + ChrW(13) + "Street: " + Fields(6) + ChrW(13) + "City: " + Fields(7) + ChrW(13) + "Postcode: " + Fields(8) + ChrW(13) + "Country: " + Fields(9) + ChrW(13) + ChrW(13))
            PreviousText = CustomerDisplayrchtxtbx.Text
            CustomerDisplayrchtxtbx.Text = PreviousText + SearchAllLine
        Loop
        FileClose(1)
    End Sub
    'When the clear button is clicked, al of the text boxes are cleared.
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        IDtxtbx.Clear()
        Nametxtbx.Clear()
        CustomerDisplayrchtxtbx.Clear()
    End Sub
    'When the add button is clicked, the customers add form will open.
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Customer_Add.Show()
    End Sub
    'When the edit button is clicked, the customers edit form will open.
    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        Customer_Edit.Show()
    End Sub
    'When the delete button is clicked, the customers delete form will open.
    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        Customer_Delete.Show()
    End Sub
End Class