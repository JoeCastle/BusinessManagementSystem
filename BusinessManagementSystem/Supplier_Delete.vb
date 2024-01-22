Imports System.IO

'On this form, the owner can delete an existing supplier from the system.
Public Class Supplier_Delete
    'This sub runs when the form loads. It closes the suppliers form when the supplier add form loads.
    Private Sub Supplier_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Suppliers.Close()
    End Sub
    'When clicked, this sub searches the file for a specific supplier, then deletes it.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path1, Path2, Line, SupplierNameSearch, SupplierIDSearch As String
        Dim SupplierFound, SupplierDeleted As Boolean
        Dim Response As Integer

        'Initialize variables
        SupplierNameSearch = SuppNameSrchtxtbx.Text.ToUpper
        SupplierIDSearch = SuppIDSrchtxtbx.Text.ToUpper
        SupplierFound = False
        SupplierDeleted = False

        Path1 = Directory.GetCurrentDirectory() & "\Suppliers.txt"
        Path2 = Directory.GetCurrentDirectory() & "\tempfile.txt"

        FileClose(1)
        FileClose(2)
        FileOpen(1, Path1, OpenMode.Input)
        FileOpen(2, Path2, OpenMode.Output)
        'Searches for a specific Supplier.
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            'If the name in the files matches the one entered by the user, supplier found is set to true.
            If Fields(0) = SupplierNameSearch And Fields(1) = SupplierIDSearch Then
                SupplierFound = True
            Else
                SupplierFound = False
            End If
            'If found, the user can either choose to delete or not delete the customer.
            If SupplierFound = True Then
                'Deletes the searched for supplier if user states yes.
                Response = MsgBox("Are you sure you want to delete this supplier?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Supplier Deletion")
                If Response = vbYes Then
                    SuppNameSrchtxtbx.Clear()
                    SuppIDSrchtxtbx.Clear()
                    'Saves suppliers to the temp file that don't match the search (deleting the searched for one).
                    If Fields(0) <> SupplierNameSearch Then
                        PrintLine(2, Line)
                    End If
                    SupplierDeleted = True
                    'Clears text boxes if user states no.
                Else
                    SuppNameSrchtxtbx.Clear()
                    SuppIDSrchtxtbx.Clear()
                    PrintLine(2, Line)
                End If
                'If no supplier is found, all suppliers are copied over to the temp file.
            ElseIf SupplierFound = False Then
                PrintLine(2, Line)
            End If
        Loop
        FileClose(1)
        FileClose(2)

        'Deletes current suppliers file. Then renames temp file to suppliers file.
        My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Suppliers.txt")
        Rename(Directory.GetCurrentDirectory() & "\tempfile.txt", Directory.GetCurrentDirectory() & "\Suppliers.txt")

        'A message box stating whether or not the supplier has been deleted from the file.
        If SupplierDeleted = True Then
            MsgBox("The supplier has been deleted.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Supplier Deleted")
        Else
            MsgBox("The supplier was not deleted.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Supplier Not Deleted")
        End If
    End Sub
    'When clicked, the suppliers form will load.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Suppliers.Show()
    End Sub
End Class