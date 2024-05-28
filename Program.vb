Imports System

Module EvenOrOdd
    Sub Main()
        While True
            ' Prompt for number
            Console.WriteLine("Enter a number (type 'exit' to quit): ")
            Dim input As String = Console.ReadLine()

            ' Check if the input is 'exit', if so, exit the loop
            If input.ToLower() = "exit" Then
                Exit While
            End If

            ' Try to parse the input as an integer
            Dim number As Integer
            If Integer.TryParse(input, number) Then
                ' Check if odd or even
                If number Mod 2 = 0 Then
                    Console.WriteLine("Number is even")
                Else
                    Console.WriteLine("Number is odd")
                End If
            Else
                ' If input is not a valid number, display an error message
                Console.WriteLine("Invalid input. Please enter a valid number.")
            End If
        End While
    End Sub
End Module