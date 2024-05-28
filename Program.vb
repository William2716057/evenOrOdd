Imports System

Module EvenOrOdd
	Sub Main()
		' Prompt for number
		Console.WriteLine("Enter number: ")
		Dim number As Integer = CInt(Console.ReadLine())
		' Check if odd or even
		If number Mod 2 = 0 Then
			Console.WriteLine("Number is even")
		Else
			Console.WriteLine("Number is odd")
		End If
	End Sub
End Module