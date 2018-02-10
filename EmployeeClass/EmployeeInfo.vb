Public Class EmployeeInfo
    Private _fName As String
    Private _monthlyPay As Decimal

    Public Sub New()

    End Sub

    Public Sub New(fname As String)
        Me.FName = fname
    End Sub

    Public Property FName() As String
        Get
            Return _fName
        End Get
        Set(ByVal value As String)
            _fName = value
        End Set
    End Property

    Public Property MonthlyPay As Decimal
        Get
            Return _monthlyPay
        End Get
        Set(value As Decimal)
            _monthlyPay = value
        End Set
    End Property
End Class
