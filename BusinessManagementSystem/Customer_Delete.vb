Imports System.IO

'On this form, the owner can delete an existing customer from the system.
Public Class Customer_Delete
    'This sub runs when the form loads. It closes the customers form when the customer add form loads.
    Private Sub Customer_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customers.Close()
    End Sub
    'When clicked, this sub searches the file for a specific customer, then deletes it.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path1, Path2, Line, CustomerNameSearch, CustomerIDSearch As String
        Dim CustomerFound, CustomerDeleted As Boolean
        Dim Response As Integer

        'Initialize variables
        CustomerNameSearch = CustNameSrchtxtbx.Text.ToUpper
        CustomerIDSearch = CustIDSrchtxtbx.Text.ToUpper
        CustomerFound = False
        CustomerDeleted = False

        Path1 = Directory.GetCurrentDirectory() & "\Customers.txt"
        Path2 = Directory.GetCurrentDirectory() & "\tempfile.txt"

        FileClose(1)
        FileClose(2)
        FileOpen(1, Path1, OpenMode.Input)
        FileOpen(2, Path2, OpenMode.Output)
        'Searches for a specific customer.
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            'If the name in the files matches the one entered by the user, customer found is set to true.
            If Fields(0) = CustomerNameSearch And Fields(1) = CustomerIDSearch Then
                CustomerFound = True
            Else
                CustomerFound = False
            End If
            'If found, the user can either choose to delete or not delete the customer.
            If CustomerFound = True Then
                'Deletes the searched for customer if user states yes.
                Response = MsgBox("Are you sure you want to delete this customer?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Customer Deletion")
                If Response = vbYes Then
                    CustNameSrchtxtbx.Clear()
                    CustIDSrchtxtbx.Clear()
                    'Saves customers to the temp file that don't match the search (deleting the searched for one).
                    If Fields(0) <> CustomerNameSearch Then
                        PrintLine(2, Line)
                    End If
                    CustomerDeleted = True
                    'Clears text boxes if user states no.
                Else
                    CustNameSrchtxtbx.Clear()
                    CustIDSrchtxtbx.Clear()
                    PrintLine(2, Line)
                End If
                'Each product that does not match the search criteria is copied over to the temp file.
            ElseIf CustomerFound = False Then
                PrintLine(2, Line)
            End If
        Loop
        FileClose(1)
        FileClose(2)

        'Deletes current customers file. Then renames temp file to customers file.
        My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Customers.txt")
        Rename(Directory.GetCurrentDirectory() & "\tempfile.txt", Directory.GetCurrentDirectory() & "\Customers.txt")

        'A message box stating whether or not the customer has been deleted from the file.
        If CustomerDeleted = True Then
            MsgBox("The customer has been deleted.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Customer Deleted")
        Else
            MsgBox("The customer was not deleted.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Customer Not Deleted")
        End If
    End Sub
    'When clicked, the Customers form will load.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Customers.Show()
    End Sub
End Class
