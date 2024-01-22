Imports System.IO

'On this form, the owner can choose to do one of a few options. This may include, view products, customer’s suppliers or transactions, sales analysis, change password or backup the system.
Public Class Owner_Main
    'Declare global variables
    Public Shared LastBackUp As Date
    'Closes various forms and gets the last backup date from the last backup file when Owner main loads
    Private Sub Owner_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login_Menu.Close()
        Change_Password.Close()
        Products.Close()
        Customers.Close()
        Suppliers.Close()
        Transactions.Close()
        Sales_Analysis.Close()

        Dim Path, Line As String

        Path = Directory.GetCurrentDirectory() & "\Last_Backup_Details.txt"
        'Opens the last backup file to retrieve the last backup date.
        FileClose(2)
        FileOpen(2, Path, OpenMode.Input)
        Do While Not EOF(2)
            Line = LineInput(2)
            LastBackUp = Line
            LastBackupDatelbl.Text = LastBackUp
        Loop
        FileClose(2)
    End Sub
    'When the logout button is clicked, the login menu will open.
    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles Logoutbtn.Click
        Login_Menu.Show()
    End Sub
    'When the change password button is clicked, the change password form will open.
    Private Sub ChangePasswordbtn_Click(sender As Object, e As EventArgs) Handles ChangePasswordbtn.Click
        Change_Password.Show()
    End Sub
    'When the products button is clicked, the products form will open.
    Private Sub Productsbtn_Click(sender As Object, e As EventArgs) Handles Productsbtn.Click
        Products.Show()
    End Sub
    'When the suppliers button is clicked, the suppliers form will open.
    Private Sub Suppliersbtn_Click(sender As Object, e As EventArgs) Handles Suppliersbtn.Click
        Suppliers.Show()
    End Sub
    'When the customers button is clicked, the customers form will open.
    Private Sub Customersbtn_Click(sender As Object, e As EventArgs) Handles Customersbtn.Click
        Customers.Show()
    End Sub
    'When clicked, the ystem will save a copy of all text files to a new folder.
    Private Sub BackUpbtn_Click(sender As Object, e As EventArgs) Handles BackUpbtn.Click
        'Declare variables.
        Dim LastBackUp As Date
        Dim Path, Line As String

        'Stores the current time and date to a variable.
        LastBackUp = DateTime.Now

        Path = Directory.GetCurrentDirectory() & "\Last_Backup_Details.txt"

        'Opens the last backup file and saves the last backup date.
        FileOpen(1, Path, OpenMode.Output)
        Line = LastBackUp
        PrintLine(1, Line)
        FileClose(1)

        'Displays the last backup date on a label.
        LastBackupDatelbl.Text = LastBackUp

        ' Copies the products file to a new folder and renames it (Backing it up).
        My.Computer.FileSystem.CopyFile(
            Directory.GetCurrentDirectory() & "\Products.txt",
            Directory.GetCurrentDirectory() & "\Backup_Files\Products_Backup.txt",
            True)

        ' Copies the suppliers file to a new folder and renames it (Backing it up).
        My.Computer.FileSystem.CopyFile(
            Directory.GetCurrentDirectory() & "\Suppliers.txt",
            Directory.GetCurrentDirectory() & "\Backup_Files\Suppliers_Backup.txt",
            True)

        ' Copies the customers file to a new folder and renames it (Backing it up).
        My.Computer.FileSystem.CopyFile(
            Directory.GetCurrentDirectory() & "\Customers.txt",
            Directory.GetCurrentDirectory() & "\Backup_Files\Customers_Backup.txt",
            True)

        ' Copies the login details file to a new folder and renames it (Backing it up).
        My.Computer.FileSystem.CopyFile(
            Directory.GetCurrentDirectory() & "\Login_Details.txt",
            Directory.GetCurrentDirectory() & "\Backup_Files\Login_Details_Backup.txt",
            True)

        ' Copies the transactions file to a new folder and renames it (Backing it up).
        My.Computer.FileSystem.CopyFile(
            Directory.GetCurrentDirectory() & "\Transactions.txt",
            Directory.GetCurrentDirectory() & "\Backup_Files\Transactions_Backup.txt",
            True)

        ' Copies the last backup details file to a new folder and renames it (Backing it up).
        My.Computer.FileSystem.CopyFile(
            Directory.GetCurrentDirectory() & "\Last_Backup_Details.txt",
            Directory.GetCurrentDirectory() & "\Backup_Files\Last_Backup_Details_Backup.txt",
            True)

        MsgBox("All files have been backed up successfully.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Backup Complete")
    End Sub
    'When the transactions button is clicked, the transactions form will open.
    Private Sub Transactionsbtn_Click(sender As Object, e As EventArgs) Handles Transactionsbtn.Click
        Transactions.Show()
    End Sub
    'When the sales analysis button is clicked, the sales analysis form will open
    Private Sub SalesAnalysisbtn_Click(sender As Object, e As EventArgs) Handles SalesAnalysisbtn.Click
        Sales_Analysis.Show()
    End Sub
End Class