Imports System.IO

'On this form, the owner can delete a transaction from the system.
Public Class Transaction_Delete
    'When the transaction delete form loads, the transactions for closes.
    Private Sub Transaction_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Transactions.Close()
    End Sub
    'When the back button is clicked, the transactions form is closed.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Transactions.Show()
    End Sub
    'Clicking the search button allows the suer to search for a transaction.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path1, Path2, Line, TransactionIDSearch As String
        Dim TransactionFound, TransactionDeleted As Boolean
        Dim Response As Integer

        'Initialize variables
        TransactionIDSearch = TransIDSrchtxtbx.Text.ToUpper
        TransactionFound = False
        TransactionDeleted = False

        Path1 = Directory.GetCurrentDirectory() & "\Transactions.txt"
        Path2 = Directory.GetCurrentDirectory() & "\tempfile.txt"

        FileClose(1)
        FileClose(2)
        FileOpen(1, Path1, OpenMode.Input)
        FileOpen(2, Path2, OpenMode.Output)
        'Searches for a specific product.
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            'If the name in the files matches the one entered by the user, product found is set to true.
            If Fields(1) = TransactionIDSearch Then
                TransactionFound = True
            Else
                TransactionFound = False
            End If
            'If found, the user can choose to delete the transaction
            If TransactionFound = True Then
                'Deletes the searched for product if user states yes.
                Response = MsgBox("Are you sure you want to delete this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Transaction Deletion")
                If Response = vbYes Then
                    TransIDSrchtxtbx.Clear()
                    'Saves products to the temp file that don't match the search (deleting the searched for one).
                    If Fields(1) <> TransactionIDSearch Then
                        PrintLine(2, Line)
                    End If
                    TransactionDeleted = True
                    'Clears text boxes if user states no.
                Else
                    TransIDSrchtxtbx.Clear()
                    PrintLine(2, Line)
                End If
            ElseIf TransactionFound = False Then
                PrintLine(2, Line)
            End If
        Loop
        FileClose(1)
        FileClose(2)

        'Deletes current products file. Then renames temp file to products file.
        My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Transactions.txt")
        Rename(Directory.GetCurrentDirectory() & "\tempfile.txt", Directory.GetCurrentDirectory() & "\Transactions.txt")

        'A message box is displayed if no transaction is deleted, and if one is deleted.
        If TransactionDeleted = True Then
            MsgBox("The transaction has been deleted.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Transaction Deleted")
        Else
            MsgBox("The transaction was not deleted.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Transaction Not Deleted")
        End If
    End Sub
End Class