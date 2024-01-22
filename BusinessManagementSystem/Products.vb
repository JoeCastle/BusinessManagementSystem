Imports System.IO

'In this form, both users can search for a specific product or search for all products in the file. However, only the owner can navigate to the add, edit and delete menus.
Public Class Products
    'This sub runs when the form loads. It closes various forms when the products form loads.
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Product_Add.Close()
        Product_Edit.Close()
        Product_Delete.Close()
        'Creates a level of access based on the users username.
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
    'Allows the user to search for a specific product by entering its name and ID.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path, Line, ProductID, ProductName, PreviousText As String
        Dim ProductFound As Boolean

        'Initialize variables
        ProductFound = False

        ProductName = Nametxtbx.Text.ToUpper
        ProductID = IDtxtbx.Text.ToUpper

        ProductDisplayrchtxtbx.Clear()

        Path = Directory.GetCurrentDirectory() & "\Products.txt"

        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        'Searches the products file to find the correct product.
        'Loops until the end of the file has been reached.
        Do While Not EOF(1)
            Line = LineInput(1)
            'Splits the strings in the file with commas to create fields.
            Dim Fields As String() = Line.Split(New Char() {","c})
            'Replaces any spaces in the file with nothing so they are not included when matching the correct characters
            Fields(0) = Replace(Fields(0), " ", "")
            Fields(1) = Replace(Fields(1), " ", "")
            'If either the name or ID match the one in the file, the product is displayed on screen.
            If Fields(0) = ProductName Or Fields(1) = ProductID Then
                ProductFound = True
                'Displays information about the product.
                Line = ("Name: " + Fields(0) + ChrW(13) + "ID: " + Fields(1) + ChrW(13) + "Description: " + Fields(2) + ChrW(13) + "Weight: " + Fields(3) + ChrW(13) + "Price: " + Fields(4) + ChrW(13) + "Material: " + Fields(5) + ChrW(13) + "Stock: " + Fields(6) + ChrW(13) + "Dimensions: " + Fields(7) + ChrW(13) + "Machine Number: " + Fields(8) + ChrW(13) + "Wire Size: " + Fields(9) + ChrW(13) + ChrW(13))
                PreviousText = ProductDisplayrchtxtbx.Text
                ProductDisplayrchtxtbx.Text = PreviousText + Line
            End If
        Loop
        FileClose(1)

        'This If statement displays an error message if the user enters an incorrect name or ID.
        If ProductFound = False Then
            MsgBox("That product could not be found.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Search Failure")
        End If
    End Sub
    'Searches the entire produts file and displays all of the products.
    Private Sub SearchAllbtn_Click(sender As Object, e As EventArgs) Handles SearchAllbtn.Click
        'Declare variables
        Dim Path, SearchAllLine, PreviousText As String
        Dim ProductFound As Boolean

        'Initialize variables
        ProductDisplayrchtxtbx.Clear()
        ProductFound = False
        Nametxtbx.Clear()
        IDtxtbx.Clear()
        Path = Directory.GetCurrentDirectory() & "\Products.txt"

        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        'Searches the produts file and displayes all products in the file.
        Do While Not EOF(1)
            SearchAllLine = LineInput(1)
            Dim Fields As String() = SearchAllLine.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            'Displays information about the product.
            SearchAllLine = ("Name: " + Fields(0) + ChrW(13) + "ID: " + Fields(1) + ChrW(13) + "Description: " + Fields(2) + ChrW(13) + "Weight: " + Fields(3) + ChrW(13) + "Price: " + Fields(4) + ChrW(13) + "Material: " + Fields(5) + ChrW(13) + "Stock: " + Fields(6) + ChrW(13) + "Dimensions: " + Fields(7) + ChrW(13) + "Machine Number: " + Fields(8) + ChrW(13) + "Wire Size: " + Fields(9) + ChrW(13) + ChrW(13))
            PreviousText = ProductDisplayrchtxtbx.Text
            ProductDisplayrchtxtbx.Text = PreviousText + SearchAllLine
        Loop
        FileClose(1)
    End Sub
    'When the clear button is clicked, all of the text boxes are cleared.
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Nametxtbx.Clear()
        IDtxtbx.Clear()
        ProductDisplayrchtxtbx.Clear()
    End Sub
    'When the add button is clicked, the products add form will open.
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Product_Add.Show()
    End Sub
    'When the edit button is clicked, the products edit form will open.
    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        Product_Edit.Show()
    End Sub
    'When the delete button is clicked, the products delete form will open.
    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        Product_Delete.Show()
    End Sub
End Class