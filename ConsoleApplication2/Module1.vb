Module Module1

    Sub Main()
        Dim a, b, i, c, number As Integer
        Randomize()
        i = 0 : number = 0
        'Console.WriteLine("幾個數字")
        'number = Console.ReadLine
        '========================================================================================
        Do Until i = 5
            c = Int(Rnd() * 42) + 1
            a = Int(Rnd() * 42) + 1
            b = Int(Rnd() * 42) + 1
            If a = b Or a = c Or b = c Then
                i = i
            Else
                i += 1
                Console.WriteLine(a & "," & b & "," & c)
            End If
        Loop

        Console.Read()




        Console.Read()

    End Sub

End Module
