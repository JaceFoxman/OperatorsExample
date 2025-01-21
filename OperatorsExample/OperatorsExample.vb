'Jason Permann
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/JaceFoxman/OperatorsExample.git

'sets the comparison type
Option Compare Text

Module OperatorsExample

    Sub Main()
        'sum operator 
        Console.Write("5 + 3 = ") 'print a string
        Console.WriteLine(5 + 3) 'print the sum
        Console.WriteLine()

        'difference Operator
        Console.Write("5 - 3 = ") 'print a string
        Console.WriteLine(5 - 3) 'print the difference
        Console.WriteLine()

        'product opperator
        Console.Write("5 * 3 = ") 'print a string
        Console.WriteLine(5 * 3) 'print the product
        Console.WriteLine()

        'floating point division operator
        Console.Write("5 / 3 = ") 'print a string
        Console.WriteLine(5 / 3) 'print the floating point division
        Console.WriteLine()

        'Integer division operator
        Console.Write("5 \ 3 = ") 'print a string
        Console.WriteLine(5 \ 3) 'print the Integer division
        Console.WriteLine()

        'modulus operator
        Console.Write("5 mod 3 = ") 'print a string
        Console.Write("Remainder ")
        Console.WriteLine(5 Mod 3) 'print the modulus
        Console.WriteLine()

        'exponent operator
        Console.Write("5 ^ 3 = ") 'print a string
        Console.WriteLine(5 ^ 3) 'print the exponent
        Console.WriteLine()

        'concatenation operator
        Console.Write("5" & " " & "+" & " " & "3" & " " & "=" & " " & "8") 'print a string
        Console.WriteLine()
        Console.WriteLine("wake up neo..." & vbNewLine & "Follow the white rabit...")
        Console.WriteLine()


        'Comparison operator
        Console.Write("5 > 3 = ") 'print a string
        Console.WriteLine(5 > 3) 'print the comparison
        Console.WriteLine()

        'Comparison operator
        Console.Write("5 < 3 = ") 'print a string
        Console.WriteLine(5 < 3) 'print the comparison
        Console.WriteLine()

        'Comparison operator
        Console.Write("does 5 = 3 ? ") 'print a string
        Console.WriteLine(5 = 3) 'print the comparison
        Console.WriteLine()

        'Comparison operator
        Console.Write("is 5 not equal to 3 ? ") 'print a string
        Console.WriteLine(5 <> 3) 'print the comparison
        Console.WriteLine()

        'Comparison operator
        Console.Write("A > B = ") 'print a string
        Console.WriteLine("A" > "B") 'print the comparison
        Console.WriteLine()

        'Comparison operator
        Console.Write("is " & Chr(34) & "A" & Chr(34) & " the same as " & Chr(34) & "a" & Chr(34) & " ") 'print a string
        Console.WriteLine("A" = "a") 'print the comparison
        Console.WriteLine()
    End Sub

End Module
