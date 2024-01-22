Imports System.IO

'On this form, the owner can view sales analysis between two dates.
Public Class Sales_Analysis
    'When the sales analysis form loads, the owner main form is closed.
    Private Sub Sales_Analysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner_Main.Close()
    End Sub
    'When the back button is clicked, the owner main form loads.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Owner_Main.Show()
    End Sub
    'When the search button is click, sales analysis is created for transactions with a specific date.
    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        'Declare variables
        Dim Path1, Line, CustomerID, ProductID, HighestProd, PreviousText As String
        Dim NumProductsSold, NumTransactions, Sales, ProductQuantity, ProductTransactions, CustomerTransactions, HighestNum As Integer
        Dim StartDate, EndDate As Date
        Dim DatesCorrect, ProductIDMatch, CustomerIDMatch As Boolean

        'Initialize variables
        SalesAnalysisDisplayrchtxtbx.Clear()
        Sales = "0"
        NumProductsSold = "0"
        NumTransactions = "0"
        ProductQuantity = "0"
        ProductTransactions = "0"
        CustomerTransactions = "0"
        HighestNum = "0"
        HighestProd = ""
        DatesCorrect = False
        ProductIDMatch = False
        CustomerIDMatch = False
        StartDate = StartDatedttmpkr.Text
        EndDate = EndDatedttmpkr.Text
        CustomerID = CustIDtxtbx.Text.ToUpper
        ProductID = ProdIDtxtbx.Text.ToUpper
        Path1 = Directory.GetCurrentDirectory() & "\Transactions.txt"

        'The transaction file is opened.
        FileClose(1)
        FileOpen(1, Path1, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            'Any transaction with a date within the perameters is used. the number of products sold, number of sales and nmber of transactions are calculated.
            If CDate(Fields(0)) >= CDate(StartDate) And CDate(Fields(0)) <= CDate(EndDate) Then
                'If the product ID matches one in the file, sales analysis for the product is calculated.
                If Fields(2) = ProductID Then
                    ProductIDMatch = True
                    ProductQuantity = ProductQuantity + Fields(4)
                    ProductTransactions = ProductTransactions + 1
                End If
                'If the customer ID matches one in the file, sales analysis for the customer is calculated.
                If Fields(3) = CustomerID Then
                    CustomerIDMatch = True
                    CustomerTransactions = CustomerTransactions + 1
                End If
                'Works out highest selling product.
                If Fields(4) > HighestNum Then
                    HighestNum = Fields(4)
                    HighestProd = Fields(2)
                End If
                DatesCorrect = True
                NumProductsSold = NumProductsSold + Fields(4)
                Sales = Sales + Fields(5)
                NumTransactions = NumTransactions + 1
            Else
                DatesCorrect = True
            End If
            'If the start date is later than the end date then a msg box is displayed informing the user.
            If CDate(StartDate) > CDate(EndDate) Then
                DatesCorrect = False
            End If
        Loop
        FileClose(1)

        'Displays appropriate sales analysis based on what the user had entered.
        SalesAnalysisDisplayrchtxtbx.Text = ("Overall: " & ChrW(13) & "Total Sales: " & "£" & Sales & ChrW(13) &
                                                     "Total Number Of Products Sold: " & NumProductsSold & ChrW(13) &
                                                     "Total Number Of Transactions: " & NumTransactions & ChrW(13) &
                                                     HighestProd & " is the highest selling product with " & HighestNum & " sold." & ChrW(13) & ChrW(13))

            PreviousText = SalesAnalysisDisplayrchtxtbx.Text

        'The sales analysis is displayed 
        'If both the product ans customer were searched for, both will have sales analysis displayed.
        If ProductIDMatch = True And CustomerIDMatch = True Then
            SalesAnalysisDisplayrchtxtbx.Text = (PreviousText &
                                                     "Products: " & ChrW(13) & ProductQuantity & " of " & ProductID & " were sold." & ChrW(13) &
                                                     ProductID & " was involved in " & ProductTransactions & " different transactions." & ChrW(13) & ChrW(13) &
                                                     "Customers: " & ChrW(13) & CustomerID & " made " & CustomerTransactions & " different transactions.")
            'If the product but not the customer were searched for, only the product will have sales analysis will be displayed.
        ElseIf ProductIDMatch = True And CustomerIDMatch = False Then
            SalesAnalysisDisplayrchtxtbx.Text = (PreviousText &
                                                 "Products: " & ChrW(13) & ProductQuantity & " of " & ProductID & " were sold." & ChrW(13) &
                                                 ProductID & " was involved in " & ProductTransactions & " different transactions.")

            'If the customer but not the product were searched for, only the customer will have sales analysis will be displayed.
        ElseIf ProductIDMatch = False And CustomerIDMatch = True Then
            SalesAnalysisDisplayrchtxtbx.Text = (PreviousText &
                                                 "Customers: " & ChrW(13) & CustomerID & " made " & CustomerTransactions & " different transactions.")

            'If neither the prouct nor customer were searched for only the basic sales analysis was displayed.
        ElseIf ProductIDMatch = False And CustomerIDMatch = False Then
            SalesAnalysisDisplayrchtxtbx.Text = ("Overall: " & ChrW(13) & "Total Sales: " & "£" & Sales & ChrW(13) &
                                                     "Total Number Of Products Sold: " & NumProductsSold & ChrW(13) &
                                                     "Total Number Of Transactions: " & NumTransactions & ChrW(13) &
                                                    HighestProd & " is the highest selling product with " & HighestNum & " sold." & ChrW(13) & ChrW(13))
        End If

            'If the start date is later than the end date then a msg box is displayed informing the user.
        If DatesCorrect = False Then
            MsgBox("Start date must be earlier than end date.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Search Failure")
        End If
    End Sub

End Class