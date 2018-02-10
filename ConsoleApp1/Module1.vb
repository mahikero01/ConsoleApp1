Imports System.Text
Imports EmployeeClass

Module Module1

    Enum Suits
        Club = 50
        Diamond = 40
        Spade = 30
        Heart = 20
    End Enum

    Sub Main()
        'Dim testAr() As Integer = {1, 2, 3}
        'Dim testEnum As Suits
        'Dim age As Integer = 10

        'Console.WriteLine(testAr(0))
        'Console.WriteLine(testEnum.Heart)



        'If age > 18 Then
        '    Console.WriteLine("you have milk")
        'End If


        'Select Case age
        '    Case Is < 18
        '        Console.WriteLine("you have milk")
        '    Case Is = 19
        '        Console.WriteLine("you have beer")
        '    Case Else
        '        Console.WriteLine("you are old")
        'End Select

        'Dim count As Integer = Console.ReadLine


        'For i As Integer = 0 To count
        '    Console.WriteLine(Fibo(i))


        'Next

        'For Each num As Integer In testAr
        '    Console.WriteLine(num)
        'Next

        'Dim count2 As Integer = 0

        'While count2 < testAr.Length
        '    Console.WriteLine(testAr(count2))
        '    count2 += 1
        'End While

        'Dim employee As ContractualEmployee


        'employee = New ContractualEmployee("Rico")

        'Console.WriteLine(employee.FName)



        'Console.WriteLine("56 789 45 - 7890 - 567")
        'FormatPhone("56 789 45 - 7890 - 567")
        'Console.WriteLine("1112221234")
        'FormatPhone("1112221234")
        'Console.WriteLine("11122212345")
        'FormatPhone("11122212345")
        'Console.WriteLine("111222123456")
        'FormatPhone("111222123456")
        'Console.WriteLine("1112221234567")
        'FormatPhone("1112221234567")

        'Dim sb As New StringBuilder
        'sb.Append("abcd")
        'sb.Insert(1, "e")
        'sb.Remove(0, 2)
        'sb.AppendLine("efg")
        'sb.AppendLine("hij")
        'Console.WriteLine(sb)

        'Console.WriteLine("0 is " & CheckIfPrime(0))
        'Console.WriteLine("1 is " & CheckIfPrime(1))
        'Console.WriteLine("2 is " & CheckIfPrime(2))
        'Console.WriteLine("3 is " & CheckIfPrime(3))
        'Console.WriteLine("4 is " & CheckIfPrime(4))
        'Console.WriteLine("5 is " & CheckIfPrime(5))
        'Console.WriteLine("6 is " & CheckIfPrime(6))
        'Console.WriteLine("7 is " & CheckIfPrime(7))
        'Console.WriteLine("8 is " & CheckIfPrime(8))
        'Console.WriteLine("9 is " & CheckIfPrime(9))
        'Console.WriteLine("10 is " & CheckIfPrime(10))
        'Console.WriteLine("11 is " & CheckIfPrime(11))
        'Console.WriteLine("12 is " & CheckIfPrime(12))
        'Console.WriteLine("13 is " & CheckIfPrime(13))
        '


        Console.ReadLine()



    End Sub

    Function CheckIfPrime(number As Integer) As String
        Dim noRemainder As Integer = 0
        'Dim result As String = 

        For count As Integer = 2 To number
            If number Mod count = 0 Then
                noRemainder += 1
            End If
        Next

        If noRemainder = 1 Then
            Return "Prime"
        End If

        Return "Not Prime"
    End Function

    Sub FormatPhone(phone As String)
        Dim sb As New StringBuilder
        Dim sbClean As New StringBuilder
        Dim sbFormat As New StringBuilder
        Dim digiCount As Integer = 0

        sb.Clear()
        sbClean.Clear()
        sbFormat.Clear()
        sb.Append(phone)
        sb.Replace(" ", "")

        For counter As Integer = 0 To sb.Length - 1
            If Char.IsDigit(sb(counter)) Then
                sbClean.Append(sb(counter))
            End If
        Next
        sb = Nothing

        For counter As Integer = 1 To sbClean.Length
            sbFormat.Append(sbClean(counter - 1))
            digiCount += 1
            If digiCount = 3 And counter <> sbClean.Length Then
                sbFormat.Append("-")
                digiCount = 0

                If sbClean.Length - counter = 4 Then
                    For lastCount = 1 To 4
                        sbFormat.Append(sbClean(counter + lastCount - 1))
                        If lastCount = 2 Then
                            sbFormat.Append("-")
                        End If
                    Next
                    Exit For
                End If
            End If
        Next

        sbClean = Nothing

        Console.WriteLine(sbFormat)
    End Sub

    Function Fibo(count As Integer) As Integer
        Dim T1 As Integer = 0
        Dim T2 As Integer = 1

        For index As Integer = 0 To count - 1
            Dim temp As Integer = T1
            T1 = T2
            T2 = temp + T2
        Next
        Return T1
    End Function

End Module
