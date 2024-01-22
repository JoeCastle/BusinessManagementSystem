Imports System.IO

'On this form, the owner can search for a specific transaction or all transactions in the system.
Public Class Transactions
    'When the transactions form loads, various other forms are closed, the date time picker is given the value of the current date and it's check box is set to false.
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner_Main.Close()
        Employee_Main.Close()
        Transaction_Add.Close()
        Transaction_Delete.Close()
        Transaction_Edit.Close()
        Datedttmpkr.Value = DateTime.Now
        Datedttmpkr.Checked = False
    End Sub
    'When the back button is click, a different form will be shown based on the users username.
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Owner_Main.Show()
    End Sub
    'Clicking the search button allows the user to search for a transaction.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables.
        Dim Path, Line, ProductID, CustomerID, TransactionID, PreviousText As String
        Dim TransactionFound As Boolean
        Dim TransactionDate As Date

        'Initialize variables.
        TransDisplayrchtxtbx.Clear()
        TransactionFound = False
        TransactionID = TransIDtxtbx.Text.ToUpper
        ProductID = ProdIDtxtbx.Text.ToUpper
        CustomerID = CustIDtxtbx.Text.ToUpper
        Path = Directory.GetCurrentDirectory() & "\Transactions.txt"

        'If the user has checked the date time picker, the value in it is stored into a variable.
        If Datedttmpkr.Checked = True Then
            TransactionDate = Datedttmpkr.Text
        End If

        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        'Loops until the end of the file has been reached
        Do While Not EOF(1)
            Line = LineInput(1)
            'Splits the strings in the file with commas to create fields
            Dim Fields As String() = Line.Split(New Char() {","c})
            'Replaces any spaces in the file with nothing so they are not included when matching the correct characters
            Fields(0) = Replace(Fields(0), " ", "")
            Fields(1) = Replace(Fields(1), " ", "")
            Fields(2) = Replace(Fields(2), " ", "")
            Fields(3) = Replace(Fields(3), " ", "")
            'If any of the fields match the search criteria, the transaction is displayed.
            If Fields(0) = TransactionDate Or Fields(1) = TransactionID Or Fields(2) = ProductID Or Fields(3) = CustomerID Then
                TransactionFound = True
                Line = ("Transaction ID: " + Fields(1) + ChrW(13) + "Transaction Date: " + Fields(0) + ChrW(13) + "Product ID: " + Fields(2) + ChrW(13) + "Customer ID: " + Fields(3) + ChrW(13) + "Price: £" + Fields(5) + ChrW(13) + "Quantity: " + Fields(4) + ChrW(13) + ChrW(13))
                PreviousText = TransDisplayrchtxtbx.Text
                TransDisplayrchtxtbx.Text = PreviousText + Line
            End If
        Loop
        FileClose(1)

        'If no transaction is found, an eror message is displayed.
        If TransactionFound = False Then
            MsgBox("That transaction could not be found.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Search Failure")
        End If
    End Sub
    'Clicking the search all button will allow the user to view all transactions currently stored in the system.
    Private Sub SearchAllbtn_Click(sender As Object, e As EventArgs) Handles SearchAllbtn.Click
        'Declare variables.
        Dim Path, SearchAllLine, PreviousText As String
        Dim TransactionFound As Boolean

        'Initialize variables.
        TransactionFound = False
        ProdIDtxtbx.Clear()
        CustIDtxtbx.Clear()
        TransDisplayrchtxtbx.Clear()
        Path = Directory.GetCurrentDirectory() & "\Transactions.txt"

        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        'Searches the transactions file for transactions and displays all of them.
        'Loops until the end of the file has been reached
        Do While Not EOF(1)
            SearchAllLine = LineInput(1)
            'Splits the strings in the file with commas to create fields
            Dim Fields As String() = SearchAllLine.Split(New Char() {","c})
            'Replaces any spaces in the file with nothing so they are not included when matching the correct characters
            Fields(0) = Replace(Fields(0), " ", "")
            SearchAllLine = ("Transaction ID: " + Fields(1) + ChrW(13) + "Transaction Date: " + Fields(0) + ChrW(13) + "Product ID: " + Fields(2) + ChrW(13) + "Customer ID: " + Fields(3) + ChrW(13) + "Price: £" + Fields(5) + ChrW(13) + "Quantity: " + Fields(4) + ChrW(13) + ChrW(13))
            PreviousText = TransDisplayrchtxtbx.Text
            TransDisplayrchtxtbx.Text = PreviousText + SearchAllLine
        Loop
        FileClose(1)
    End Sub
    'clicking the clear button will clear various textboxes and uncheck the date time picker text box.
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        ProdIDtxtbx.Clear()
        CustIDtxtbx.Clear()
        TransIDtxtbx.Clear()
        Datedttmpkr.Checked = False
        TransDisplayrchtxtbx.Clear()
    End Sub
    'Clicking the add button will show the transaction add form.
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Transaction_Add.Show()
    End Sub
    'clicking the edit button will show the transaction edit form.
    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        Transaction_Edit.Show()
    End Sub
    'Clicking the delete button will show the transaction delete form.
    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        Transaction_Delete.Show()
    End Sub
End Class