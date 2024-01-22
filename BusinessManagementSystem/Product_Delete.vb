Imports System.IO

'On this sub, the owner can delete an existing product from the system
Public Class Product_Delete
    'This sub runs when the form loads. It closes the products form when the product add form loads.
    Private Sub Product_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Products.Close()
    End Sub
    'When clicked, this sub searches the file for a specific product, then deletes it.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path1, Path2, Line, ProductNameSearch, ProductIDSearch As String
        Dim ProductFound, ProductDeleted As Boolean
        Dim Response As Integer

        'Initialize variables
        ProductNameSearch = ProdNameSrchtxtbx.Text.ToUpper
        ProductIDSearch = ProdIDSrchtxtbx.Text.ToUpper
        ProductFound = False
        ProductDeleted = False

        Path1 = Directory.GetCurrentDirectory() & "\Products.txt"
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
            'If the name or the ID in the files matches the one entered by the user, product found is set to true.
            If Fields(0) = ProductNameSearch And Fields(1) = ProductIDSearch Then
                ProductFound = True
            Else
                ProductFound = False
            End If
            'If found, the user can either choose to delete or not delete the product.
            If ProductFound = True Then
                'Deletes the searched for product if user states yes.
                Response = MsgBox("Are you sure you want to delete this product?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Product Deletion")
                If Response = vbYes Then
                    ProdNameSrchtxtbx.Clear()
                    ProdIDSrchtxtbx.Clear()
                    'Saves products to the temp file that don't match the search (deleting the searched for one).
                    If Fields(0) <> ProductNameSearch Then
                        PrintLine(2, Line)
                    End If
                    ProductDeleted = True
                    'Clears text boxes if user states no.
                Else
                    ProdNameSrchtxtbx.Clear()
                    ProdIDSrchtxtbx.Clear()
                    PrintLine(2, Line)
                End If
                'Each product that does not match the search criteria is copied over to the temp file.
            ElseIf ProductFound = False Then
                PrintLine(2, Line)
            End If
        Loop
        FileClose(1)
        FileClose(2)

        'Deletes current products file. Then renames temp file to products file.
        My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Products.txt")
        Rename(Directory.GetCurrentDirectory() & "\tempfile.txt", Directory.GetCurrentDirectory() & "\Products.txt")

        'A message box stating whether or not the product has been deleted from the file.
        If ProductDeleted = True Then
            MsgBox("The product has been deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Product Deleted")
        Else
            MsgBox("The product was not deleted", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Product Not Deleted")
        End If
    End Sub
    'When clicked, the products form will load.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Products.Show()
    End Sub
End Class