'On this form, the employee can choose to do one of a few options. This may include, view products, customers or suppliers.
Public Class Employee_Main
    'Closes various forms when the employee main form loads.
    Private Sub Employee_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login_Menu.Close()
        Products.Close()
        Customers.Close()
        Suppliers.Close()
    End Sub
    'When the products button is clicked, the products form will open.
    Private Sub Productsbtn_Click(sender As Object, e As EventArgs) Handles Productsbtn.Click
        Products.Show()
    End Sub
    'When the customers button is clicked, the customers form will open.
    Private Sub Customersbtn_Click(sender As Object, e As EventArgs) Handles Customersbtn.Click
        Customers.Show()
    End Sub
    'When the logout button is clicked, the login menu will open.
    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles Logoutbtn.Click
        Login_Menu.Show()
    End Sub
    'When the suppliers button is clicked, the supplirs form will open.
    Private Sub Suppliersbtn_Click(sender As Object, e As EventArgs) Handles Suppliersbtn.Click
        Suppliers.Show()
    End Sub
End Class