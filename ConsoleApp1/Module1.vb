Module Module1

    Enum Suits
        Club = 50
        Diamond = 40
        Spade = 30
        Heart = 20
    End Enum

    Sub Main()
        Dim testAr() As Integer = {1, 2, 3}
        Dim testEnum As Suits
        Dim age As Integer = 10

        Console.WriteLine(testAr(0))
        Console.WriteLine(testEnum.Heart)



        If age > 18 Then
            Console.WriteLine("you have milk")
        End If


        Select Case age
            Case Is < 18
                Console.WriteLine("you have milk")
            Case Is = 19
                Console.WriteLine("you have beer")
            Case Else
                Console.WriteLine("you are old")
        End Select

        'Dim count As Integer = Console.ReadLine


        'For i As Integer = 0 To count
        '    Console.WriteLine(Fibo(i))


        'Next

        For Each num As Integer In testAr
            Console.WriteLine(num)
        Next

        Dim count2 As Integer = 0

        While count2 < testAr.Length
            Console.WriteLine(testAr(count2))
            count2 += 1
        End While


        Console.ReadLine()



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
