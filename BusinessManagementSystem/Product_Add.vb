Imports System.IO

'Imports definitions from validation class.
Imports BusinessManagementSystem.Validation
'On this form, the owner can add a new product to the system.
Public Class Product_Add
    'Closes the products form when the product add form loads.
    Private Sub Product_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Products.Close()
    End Sub
    'Allows the user to add a product to the products file.
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        'Declare variables
        Dim Path, Line, PName, PID, PDescription, PMaterial, PDimensions, PMachineNumber As String
        Dim PWeight, PStock, PWireSize As String
        Dim PPrice As String
        Dim ProductCheck, ProductDupe As Boolean
        Dim Validation As New Validation

        'Initialize variables.
        PName = NameAddtxtbx.Text.ToUpper
        PID = IDAddtxtbx.Text.ToUpper
        PDescription = DescAddtxtbx.Text.ToUpper
        PWeight = WeiAddtxtbx.Text
        PPrice = PriAddtxtbx.Text
        PMaterial = MatAddtxtbx.Text.ToUpper
        PStock = StockAddtxtbx.Text
        PDimensions = DimAddtxtbx.Text.ToUpper
        PMachineNumber = MacNumAddtxtbx.Text.ToUpper
        PWireSize = WiSiAddtxtbx.Text

        'Remove commas from all variables so that new fields are't created when saving to the comma seperated files.
        PName = Replace(PName, ",", "")
        PID = Replace(PID, ",", "")
        PDescription = Replace(PDescription, ",", "")
        PWeight = Replace(PWeight, ",", "")
        PPrice = Replace(PPrice, ",", "")
        PMaterial = Replace(PMaterial, ",", "")
        PStock = Replace(PStock, ",", "")
        PDimensions = Replace(PDimensions, ",", "")
        PMachineNumber = Replace(PMachineNumber, ",", "")
        PWireSize = Replace(PWireSize, ",", "")

        'Checks the products file to ensure that the procutd ID doesn't exist already.
        Path = Directory.GetCurrentDirectory() & "\Products.txt"
        FileClose(1)
        FileOpen(1, Path, OpenMode.Input)
        Do While Not EOF(1)
            Line = LineInput(1)
            Dim Fields As String() = Line.Split(New Char() {","c})
            Fields(0) = Replace(Fields(0), " ", "")
            If PID = Fields(1) Then
                ProductCheck = True
            End If
        Loop
        FileClose(1)

        'If the ID does exist, the product will not be added to the system.
        If ProductCheck = True Then
            ProductDupe = True
        End If

        If ProductDupe = False Then

            'If any of the following fields are blank, the product will not be added to the system.
            If PPrice <> "" Then
                If PWeight <> "" Then
                    If PStock <> "" Then

                        'If certain variables meet validation requirements then the customer will be added to the file.
                        If Validation.AddPrice(PPrice) = True Then
                            If Validation.AddWeight(PWeight) = True Then
                                If Validation.AddStock(PStock) = True Then

                                    Path = Directory.GetCurrentDirectory() & "\Products.txt"
                                    FileClose(1)
                                    'Opens product file and appends the new product.
                                    FileOpen(1, Path, OpenMode.Append)
                                    Line = PName & "," & PID & "," & PDescription & "," & PWeight & "," & PPrice & "," & PMaterial & "," & PStock & "," & PDimensions & "," & PMachineNumber & "," & PWireSize
                                    PrintLine(1, Line)
                                    FileClose(1)

                                    MsgBox("The product has been added to the system.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Product Added")
                                    'A message box is displayed for each variable that doesn't meet the validation requirements.
                                Else
                                    MsgBox("Stock is in incorrect format." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                                End If
                            Else
                                MsgBox("Weight is in incorrect format." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                            End If
                        Else
                            MsgBox("Price is in incorrect format." + Environment.NewLine + "See Example", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Incorrect Format")
                        End If

                    Else
                        MsgBox("Stock cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                    End If
                Else
                    MsgBox("Weight cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
                End If
            Else
                MsgBox("Price cannot be blank." + Environment.NewLine + "See example.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Format Incorrect.")
            End If

        Else
            MsgBox("ID already exists, please choose another.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ID Duplicate.")
        End If

    End Sub
    'When the clear button is clicked, all of the text boxes are cleared.
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        NameAddtxtbx.Clear()
        IDAddtxtbx.Clear()
        DescAddtxtbx.Clear()
        WeiAddtxtbx.Clear()
        PriAddtxtbx.Clear()
        MatAddtxtbx.Clear()
        StockAddtxtbx.Clear()
        DimAddtxtbx.Clear()
        MacNumAddtxtbx.Clear()
        WiSiAddtxtbx.Clear()
    End Sub
    'When the back button is clicked, the products form will open.
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Products.Show()
    End Sub
End Class