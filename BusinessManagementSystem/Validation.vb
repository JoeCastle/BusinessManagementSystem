'Brings definitions for regular expressions.
Imports System.Text.RegularExpressions
'This class contains all of the functions for validation.
Public Class Validation
    'This function validates new passwords. It must contain a number, an uppercase letter, a lower case letter and it must be at least 6 characters long.
    Function NewPasswordValidation(ByVal Password As String) As Boolean
        'Password must match this regex, must have a number, lowercase letter and a capital letter.
        Dim PasswordNumEx As New Regex("[0-9]")
        Dim PasswordLowerEx As New Regex("[a-z]")
        Dim PasswordUpperEx As New Regex("[A-Z]")
        'If password matches format and is longer than 5 characters, true is returned.
        If PasswordNumEx.IsMatch(Password) = True Then
            If PasswordLowerEx.IsMatch(Password) = True Then
                If PasswordUpperEx.IsMatch(Password) = True Then
                    If Len(Password) > 5 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End If
        End If
        Return False
    End Function
    'This function validates emails. It must match the format below.
    Function AddEmailValidation(ByVal Email As String) As Boolean
        Dim EmailEx As New Regex("^(?<user>[^@]+)@(?<host>.+[.])\w+$")
        'If the email matches the format, true is returned.
        If EmailEx.IsMatch(Email) = True Then
            Return True
        Else
            Return False
        End If
        Return False
    End Function
    'This function validates telephone numbers. It must contain only numbers and be 11 characters long.
    Function AddTelephoneValidation(ByVal Telephone As String) As Boolean
        Dim TelephoneEx As New Regex("^\d+$")
        'If the telephone number matches the format and is 11 characters long, true is returned.
        If TelephoneEx.IsMatch(Telephone) = True Then
            If Len(Telephone) = 11 Then
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function
    'This function validates post codes. It must contain only numbers and uppercase letters. It must also be between 6 and 8 characters long.
    Function AddPostCodeValidation(ByVal PCode As String) As Boolean
        Dim PCodeEx As New Regex("[0-9A-Z]")
        'If the post code matches the format and is between 6 and 8 characters long, true is returned.
        If PCodeEx.IsMatch(PCode) = True Then
            If Len(PCode) > 5 And Len(PCode) < 9 Then
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function
    'This function validates prices. It must fit the format below. It can only contain numbers, it must have a decimal point and it can only have 2 numbers after the decimal point.
    Function AddPrice(ByVal Price As String) As Boolean
        Dim PriceEx As New Regex("^\d+[.]\d{2}$")
        'If the price matches the format, true is returned.
        If PriceEx.IsMatch(Price) = True Then
            Return True
        Else
            Return False
        End If
        Return False
    End Function
    'This function validates weight. It must fit the format below. It can only contain numbers, it must have a decimal point and it can only have 2 numbers after the decimal point.
    Function AddWeight(ByVal Weight As String) As Boolean
        Dim WeightEx As New Regex("^\d+[.]\d{2}$")
        'If the weight matches the format, true is returned.
        If WeightEx.IsMatch(Weight) = True Then
            Return True
        Else
            Return False
        End If
        Return False
    End Function
    'This function validates stock. It can only contain numerical values
    Function AddStock(ByVal Stock As String) As Boolean
        Dim StockEx As New Regex("^\d+$")
        'If the stock matches the format, true is returned.
        If StockEx.IsMatch(Stock) = True Then
            Return True
        Else
            Return False
        End If
        Return False
    End Function
End Class
