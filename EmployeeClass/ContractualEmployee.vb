Public Class ContractualEmployee
    Inherits EmployeeInfo

    Public Sub New(fName As String)
        'Me.FName = fName
        MyBase.New(fName)
    End Sub

    Public Sub ComputeSalary()
        MonthlyPay = 100.0
    End Sub
End Class
