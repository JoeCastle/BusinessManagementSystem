Imports System.IO

'Imports definitions from validation class.
Imports BusinessManagementSystem.Validation
'On this form, the owner can add a new transaction into the system.
Public Class Transaction_Add
    'When the transactions add form loads, the transactions form closes.
    Private Sub Transaction_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Transactions.Close()
        PriceAddtxtbx.Enabled = False
    End Sub
    'When the back button is clicked, the transactions form is closed.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Transactions.Show()
    End Sub
    'Clicking the add button alows the user to add a transaction.
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        'Declare variables
        Dim Path, Path2, Path3, Line, TransactionID, ProductID, CustomerID, Price As String
        Dim TransactionDate As Date
        Dim ProductFound, ProductCheck, ProductDupe, CustomerCheck, CustomerDupe, TransCheck, TransDupe As Boolean
        Dim Validation As New Validation
        Dim ProductStockInFile, Quantity As String


        TransDupe = True
        ProductDupe = False
        CustomerDupe = False

        'Initialize variables
        TransDatedttmpkr.Value = DateTime.Now

        ProductStockInFile = "0"

        TransactionID = TransIDAddtxtbx.Text.ToUpper
        ProductID = ProdIDAddtxtbx.Text.ToUpper
        CustomerID = CustIDAddtxtbx.Text.ToUpper
        TransactionDate = TransDatedttmpkr.Text
        Quantity = QuantAddtxtbx.Text

        'Remove commas from all variables so that new fields are't created when saving to the comma seperated files.
        TransactionID = Replace(TransactionID, ",", "")
        ProductID = Replace(ProductID, ",", "")
        CustomerID = Replace(CustomerID, ",", "")
        Quantity = Replace(Quantity, ",", "")

        'Checks the transaction file to ensure that the transaction ID doesn't exist already.
        Path = Directory.GetCurrentDirectory() & "\Transactions.txt"
        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If TransactionID = Fields(1) Then
                TransCheck = True
            End If
        Loop
        FileClose(1)

        'Checks the products file to ensure that the product ID exists.
        Path2 = Directory.GetCurrentDirectory() & "\Products.txt"
        FileClose(1)
        FileOpen(1, Path2, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(1) = Replace(Fields(1), " ", "")
            If ProductID = Fields(1) Then
                ProductCheck = True
                ProductStockInFile = Fields(6)
                PriceAddtxtbx.Text = Fields(4)
                Price = PriceAddtxtbx.Text
            End If
        Loop
        FileClose(1)

        'Checks the customers file to ensure that the customer ID exists.
        Path3 = Directory.GetCurrentDirectory() & "\Customers.txt"
        FileClose(1)
        FileOpen(1, Path3, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(1) = Replace(Fields(1), " ", "")
            If CustomerID = Fields(1) Then
                CustomerCheck = True
            End If
        Loop
        FileClose(1)

        'If the transaction ID exists, the transaction will not be added.
        If TransCheck = True Then
            TransDupe = False
        End If

        'If the product ID doesn't exist, the transaction will not be added.
        If ProductCheck = True Then
            ProductDupe = True
        End If

        'If the customer ID doesn't exist, the transaction will not be added.
        If CustomerCheck = True Then
            CustomerDupe = True
        End If

        If TransDupe = True Then
            If ProductDupe = True Then
                If CustomerDupe = True Then

                    'If the following fields are blank, the transaction will not be added.
                    If Price <> "" Then
                        If Quantity <> "" Then

                            ''Cheks certain files against some validation requirements.
                            If Validation.AddPrice(Price) = True Then
                                If Validation.AddStock(Quantity) = True Then

                                    'Ensures the stock in the products file cannot be negative.
                                    ProductStockInFile = ProductStockInFile - Quantity
                                    If ProductStockInFile >= "0" Then



                                        Path = Directory.GetCurrentDirectory() & "\Transactions.txt"
                                        FileClose(1)
                                        'Opens transaction file and appends the new transaction.
                                        FileOpen(1, Path, OpenMode.Append)
                                        Line = TransactionDate & "," & TransactionID & "," & ProductID & "," & CustomerID & "," & Quantity & "," & Price
                                        PrintLine(1, Line)
                                        FileClose(1)

                                        Path2 = Directory.GetCurrentDirectory() & "\Products.txt"
                                        Path3 = Directory.GetCurrentDirectory() & "\tempfile.txt"

                                        'Opens the products file and a temp products file.
                                        FileClose(1)
                                        FileClose(2)
                                        FileOpen(1, Path2, OpenMode.Input)
                                        FileOpen(2, Path3, OpenMode.Output)
                                        'Finds the specific product in the products file and edits it based on what the user entered into the text boxes.
                                        Do While Not EOF(1)
                                            Line = LineInput(1)
                                            Dim Fields As String() = Line.Split(New Char() {","c})
                                            Fields(0) = Replace(Fields(0), " ", "")
                                            'If the name or ID in the file match the ones entered by the user then product found is set to true,
                                            If Fields(1) = ProductID Then
                                                ProductFound = True
                                            Else
                                                ProductFound = False
                                            End If
                                            'If found the text from the text boxes will be saved to the file.
                                            If ProductFound = True Then
                                                Fields(6) = Fields(6) - Quantity
                                                Line = Fields(0) & "," & Fields(1) & "," & Fields(2) & "," & Fields(3) & "," & Fields(4) & "," & Fields(5) & "," & Fields(6) & "," & Fields(7) & "," & Fields(8) & "," & Fields(9)
                                                PrintLine(2, Line)
                                                ProductFound = False
                                                'If not found, the line will be copied over to the temp file.
                                            ElseIf ProductFound = False Then
                                                PrintLine(2, Line)
                                            End If
                                        Loop
                                        FileClose(1)
                                        FileClose(2)

                                        'Deletes the products file then renames the temp file as the products file.
                                        My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Products.txt")
                                        Rename(Directory.GetCurrentDirectory() & "\tempfile.txt", Directory.GetCurrentDirectory() & "\Products.txt")


                                        MsgBox("The transaction has been added to the system", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Transaction Added")

                                        TransIDAddtxtbx.Clear()
                                        ProdIDAddtxtbx.Clear()
                                        CustIDAddtxtbx.Clear()
                                        QuantAddtxtbx.Clear()
                                        PriceAddtxtbx.Clear()

                                    ElseIf ProductStockInFile < "0" Then
                                        MsgBox("Not enough stock.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Stock Error")
                                    End If

                                Else
                                    MsgBox("Quantity is in incorrect format." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                                End If
                            Else
                                MsgBox("Price is in incorrect format." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                            End If

                        Else
                            MsgBox("Quantity cannot be blank." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                        End If
                    Else
                        MsgBox("Price cannot be blank." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                    End If

                Else
                    MsgBox("CustomerID does not exist, please choose another.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ID Duplicate.")
                End If
            Else
                MsgBox("ProductID does not exist, please choose another.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ID Duplicate.")
            End If
        Else
            MsgBox("TransactionID already exists, please choose another.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ID Duplicate.")
        End If

    End Sub
    'When the clear buton is clicked, all fo the textboxes are cleared.
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        TransIDAddtxtbx.Clear()
        ProdIDAddtxtbx.Clear()
        CustIDAddtxtbx.Clear()
        QuantAddtxtbx.Clear()
        PriceAddtxtbx.Clear()
    End Sub
End Class