Imports System.IO

Imports BusinessManagementSystem.Validation
'On this form, the owner can edit a transaction within the system.
Public Class Transaction_Edit
    'Declare global variables.
    Public Shared IDSearch, ProdIDInFile, CustIDInFile, TransIDInFile As String
    'When the transaction edit form loads, the transaction form is closed, various textboxes and buttons are disabled and the date time piker is given the current date to start.
    Private Sub Transaction_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Transactions.Close()
        TransIDEdittxtbx.Enabled = False
        ProdIDEdittxtbx.Enabled = False
        CustIDEdittxtbx.Enabled = False
        TransDateEditdttmpkr.Enabled = False
        QuantEdittxtbx.Enabled = False
        PriceEdittxtbx.Enabled = False
        Editbtn.Enabled = False
        TransDateEditdttmpkr.Value = DateTime.Now
    End Sub
    'Clicking the edit button allows the user to edit a transaction.
    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        'Declare variables.
        Dim Path1, Path2, Path3, Path4, Line, TransactionID, CustomerID, ProductID, ProductStockInFile, Price, Quantity As String
        Dim OldQuantity, Difference As Integer
        Dim TransactionChanged, TransactionFound, ProductFound, TransCheck, TransDupe, ProductCheck, ProductDupe, CustomerCheck, CustomerDupe As Boolean
        Dim TransactionDate As Date
        Dim Validation As New Validation

        'Initialize variables.
        TransactionFound = False
        TransactionChanged = False
        TransDupe = True
        ProductDupe = False
        CustomerDupe = False

        TransactionID = TransIDEdittxtbx.Text.ToUpper
        ProductID = ProdIDEdittxtbx.Text.ToUpper
        CustomerID = CustIDEdittxtbx.Text.ToUpper
        TransactionDate = TransDateEditdttmpkr.Text
        Quantity = QuantEdittxtbx.Text

        ProductStockInFile = "0"
        Difference = "0"

        'If certain variables meet validation requirements then the customer will be added to the file.
        TransactionID = Replace(TransactionID, ",", "")
        ProductID = Replace(ProductID, ",", "")
        CustomerID = Replace(CustomerID, ",", "")
        Quantity = Replace(Quantity, ",", "")

        'Checks the transaction file to ensure that the transaction ID doesn't exist already.
        Path1 = Directory.GetCurrentDirectory() & "\Transactions.txt"
        FileClose(1)
        FileOpen(1, Path1, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If TransactionID = Fields(1) Then
                TransCheck = True
                If TransactionID = TransIDInFile Then
                    TransCheck = False
                End If
            End If
        Loop
        FileClose(1)

        'Checks the products file to ensure that the product ID does exist.
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
                PriceEdittxtbx.Text = Fields(4)
                Price = PriceEdittxtbx.Text
            End If
        Loop
        FileClose(1)

        'Checks the customers file to ensure that the customer ID does exist.
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

        'If the transaction ID does exist, the transaction will not be edited.
        If TransCheck = True Then
            TransDupe = False
        End If

        'If the product ID doesn't exist the transaction will not be edited.
        If ProductCheck = True Then
            ProductDupe = True
        End If

        'If the customer ID doesn't exist the transaction will not be edited.
        If CustomerCheck = True Then
            CustomerDupe = True
        End If

        If TransDupe = True Then
            If ProductDupe = True Then
                If CustomerDupe = True Then

                    'If the following fields are blank, the transaction will not be edited.
                    If Price <> "" Then
                        If Quantity <> "" Then

                            'Certain fields will be checked against certain validation requirements.
                            If Validation.AddPrice(Price) = True Then
                                If Validation.AddStock(Quantity) = True Then

                                    'If the stock in the products file is less than 0, the transaction will not be edited.
                                    If Quantity > OldQuantity Then
                                        Difference = Quantity - OldQuantity
                                        ProductStockInFile = ProductStockInFile - Difference
                                    Else
                                        ProductStockInFile = ProductStockInFile
                                    End If

                                    If ProductStockInFile >= "0" Then

                                        Path1 = Directory.GetCurrentDirectory() & "\Transactions.txt"
                                        Path2 = Directory.GetCurrentDirectory() & "\tempfile.txt"

                                        'Opens the transactions file and a temp transactions file.
                                        FileClose(1)
                                        FileClose(2)
                                        FileOpen(1, Path1, OpenMode.Input)
                                        FileOpen(2, Path2, OpenMode.Output)
                                        'Finds the specific transaction in the transactions file and edits it based on what the user entered into the text boxes.
                                        Do While Not EOF(1)
                                            Line = LineInput(1)
                                            Dim Fields As String() = Line.Split(New Char() {","c})
                                            Fields(0) = Replace(Fields(0), " ", "")
                                            'If the name or ID in the file match the ones entered by the user then transaction found is set to true.
                                            If Fields(1) = IDSearch Then
                                                TransactionFound = True
                                            Else
                                                TransactionFound = False
                                            End If
                                            'If found, the text from the text boxes will be saved to the file.
                                            If TransactionFound = True Then
                                                OldQuantity = Fields(4)
                                                Fields(0) = TransactionDate
                                                Fields(1) = TransactionID
                                                Fields(2) = ProductID
                                                Fields(3) = CustomerID
                                                Fields(4) = Quantity
                                                Fields(5) = Price
                                                Line = Fields(0) & "," & Fields(1) & "," & Fields(2) & "," & Fields(3) & "," & Fields(4) & "," & Fields(5)
                                                PrintLine(2, Line)
                                                TransactionFound = False
                                                TransactionChanged = True
                                                'If not found, the line will be copied over to the temp file.
                                            ElseIf TransactionFound = False Then
                                                PrintLine(2, Line)
                                            End If
                                        Loop
                                        FileClose(1)
                                        FileClose(2)

                                        'Deletes the transaction file then renames the temp file as the transactions file.
                                        My.Computer.FileSystem.DeleteFile(Directory.GetCurrentDirectory() & "\Transactions.txt")
                                        Rename(Directory.GetCurrentDirectory() & "\tempfile.txt", Directory.GetCurrentDirectory() & "\Transactions.txt")

                                        Path3 = Directory.GetCurrentDirectory() & "\Products.txt"
                                        Path4 = Directory.GetCurrentDirectory() & "\tempfile.txt"

                                        'Opens the products file and a temp products file.
                                        FileClose(1)
                                        FileClose(2)
                                        FileOpen(1, Path3, OpenMode.Input)
                                        FileOpen(2, Path4, OpenMode.Output)
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
                                                Quantity = CInt(Quantity)
                                                'Changes the stock in the products file based on what the quantity in the transactions file is changed to.
                                                If Quantity < OldQuantity Then
                                                    Difference = OldQuantity - Quantity
                                                    Fields(6) = Fields(6) + Difference
                                                ElseIf Quantity > OldQuantity Then
                                                    Difference = Quantity - OldQuantity
                                                    Fields(6) = Fields(6) - Difference
                                                Else
                                                    Fields(6) = Fields(6)
                                                End If
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

                                        'If the transaction has been edited, it will tell the user. If not, it will also tell the user.
                                        If TransactionChanged = True Then
                                            MsgBox("The transaction has been edited.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Transaction Edited")
                                            TransIDEdittxtbx.Enabled = False
                                            ProdIDEdittxtbx.Enabled = False
                                            CustIDEdittxtbx.Enabled = False
                                            TransDateEditdttmpkr.Enabled = False
                                            QuantEdittxtbx.Enabled = False
                                            PriceEdittxtbx.Enabled = False
                                            Editbtn.Enabled = False
                                        Else
                                            MsgBox("The transaction could not be edited.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Transaction Edit Failure")
                                        End If

                                    ElseIf ProductStockInFile < "0" Then
                                        MsgBox("Not enough stock.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Stock Error")
                                    End If

                                Else

                                    MsgBox("Quantity is in incorrect format." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                                End If
                                Else
                                    MsgBox("Price is in incorrect format." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
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
    'Allows the user to search for a transaction in order to edit it.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables.
        Dim Path1, Line As String
        Dim TransactionSearched, MsgBoxDisplay As Boolean

        'Initialize variables.
        IDSearch = IDSrchtxtbx.Text.ToUpper
        TransactionSearched = False
        MsgBoxDisplay = True

        Path1 = Directory.GetCurrentDirectory() & "\Transactions.txt"

        FileClose(1)
        FileOpen(1, Path1, OpenMode.Input)
        'Searches transactions file for a specific transaction.
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If Fields(1) = IDSearch Then
                TransactionSearched = True
            Else
                TransactionSearched = False
            End If
            'If found, text boxes will be enables allowing the user to begin editing.
            If TransactionSearched = True Then
                TransIDEdittxtbx.Enabled = True
                ProdIDEdittxtbx.Enabled = True
                CustIDEdittxtbx.Enabled = True
                TransDateEditdttmpkr.Enabled = True
                QuantEdittxtbx.Enabled = True
                Editbtn.Enabled = True

                'Puts text from file into text boxes so the user can easily edit it.
                TransDateEditdttmpkr.Text = Fields(0)
                TransIDEdittxtbx.Text = Fields(1)
                TransIDInFile = Fields(1)
                ProdIDEdittxtbx.Text = Fields(2)
                CustIDEdittxtbx.Text = Fields(3)
                QuantEdittxtbx.Text = Fields(4)
                PriceEdittxtbx.Text = Fields(5)
                MsgBoxDisplay = False
            End If
        Loop
        FileClose(1)

        'If a specific transaction is not found, a message box is displayed informing the user.
        If MsgBoxDisplay = True Then
            MsgBox("The transaction could not be found", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Transaction Not found")
        End If
    End Sub
    'When the back button is clicked, the transacions form is shown.
    Private Sub Backbtn_Click_1(sender As Object, e As EventArgs) Handles Backbtn.Click
        Transactions.Show()
    End Sub
End Class