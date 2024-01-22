Imports System.IO

Public Class Suppliers
    'This sub runs when the form loads. It closes various forms when the suppliers form loads.
    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Supplier_Add.Close()
        Supplier_Edit.Close()
        Supplier_Delete.Close()
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
    'Allows the user to search for a specific supplier by entering its name and ID.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path, Line, SupplierID, SupplierName, PreviousText As String
        Dim SupplierFound As Boolean

        'Initialize variables
        SupplierDisplayrchtxtbx.Clear()
        SupplierFound = False
        SupplierName = Nametxtbx.Text.ToUpper
        SupplierID = IDtxtbx.Text.ToUpper
        Path = Directory.GetCurrentDirectory() & "\Suppliers.txt"

        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        'Searches the suppliers file to find the correct supplier.
        'Loops until the end of the file has been reached.
        Do While Not EOF(1)
            Line = LineInput(1)
            'Splits the strings in the file with commas to create fields.
            Dim Fields As String() = Line.Split(New Char() {","c})
            'Replaces any spaces in the file with nothing so they are not included when matching the correct characters
            Fields(0) = Replace(Fields(0), " ", "")
            Fields(1) = Replace(Fields(1), " ", "")
            'If either the name or ID match the one in the file, the supplier is displayed.
            If Fields(0) = SupplierName Or Fields(1) = SupplierID Then
                SupplierFound = True
                Line = ("Name: " + Fields(0) + ChrW(13) + "ID: " + Fields(1) + ChrW(13) + "Description: " + Fields(2) + ChrW(13) + "Telephone: " + Fields(3) + ChrW(13) + "Email: " + Fields(4) + ChrW(13) + "Contact Name: " + Fields(5) + ChrW(13) + "Street: " + Fields(6) + ChrW(13) + "City: " + Fields(7) + ChrW(13) + "Postcode: " + Fields(8) + ChrW(13) + "Country: " + Fields(9) + ChrW(13) + ChrW(13))
                PreviousText = SupplierDisplayrchtxtbx.Text
                SupplierDisplayrchtxtbx.Text = PreviousText + Line
            End If
        Loop
        FileClose(1)

        'This If statement displays an error message if the user enters an incorrect name or ID.
        If SupplierFound = False Then
            MsgBox("That supplier could not be found.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Search Failure")
        End If

    End Sub
    'Searches the entire suppliers file and displays all of the suppliers.
    Private Sub SearchAllbtn_Click(sender As Object, e As EventArgs) Handles SearchAllbtn.Click
        'Declare variables
        Dim Path, SearchAllLine, PreviousText As String
        Dim SupplierFound As Boolean

        'Initialize variables
        SupplierDisplayrchtxtbx.Clear()
        SupplierFound = False
        IDtxtbx.Clear()
        Nametxtbx.Clear()
        Path = Directory.GetCurrentDirectory() & "\Suppliers.txt"

        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        'Searches the suppliers file and displayes all suppliers in the file.
        Do While Not EOF(1)
            SearchAllLine = LineInput(1)
            Dim Fields As String() = SearchAllLine.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            SearchAllLine = ("Name: " + Fields(0) + ChrW(13) + "ID: " + Fields(1) + ChrW(13) + "Description: " + Fields(2) + ChrW(13) + "Telephone: " + Fields(3) + ChrW(13) + "Email: " + Fields(4) + ChrW(13) + "Contact Name: " + Fields(5) + ChrW(13) + "Street: " + Fields(6) + ChrW(13) + "City: " + Fields(7) + ChrW(13) + "Postcode: " + Fields(8) + ChrW(13) + "Country: " + Fields(9) + ChrW(13) + ChrW(13))
            PreviousText = SupplierDisplayrchtxtbx.Text
            SupplierDisplayrchtxtbx.Text = PreviousText + SearchAllLine
        Loop
        FileClose(1)
    End Sub
    'When the clear button is clicked, al of the text boxes are cleared.
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        IDtxtbx.Clear()
        Nametxtbx.Clear()
        SupplierDisplayrchtxtbx.Clear()
    End Sub
    'When the add button is clicked, the suppliers add form will open.
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Supplier_Add.Show()
    End Sub
    'When the edit button is clicked, the suppliers edit form will open.
    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        Supplier_Edit.Show()
    End Sub
    'When the delete button is clicked, the suppliers delete form will open.
    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        Supplier_Delete.Show()
    End Sub
End Class