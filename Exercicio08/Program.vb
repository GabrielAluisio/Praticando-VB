Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Digite um número: ")
        Dim n As Integer = CInt(Console.ReadLine())
        Console.WriteLine("=========================")
        For i As Integer = 1 To 10
            
            Console.WriteLine(n &" x " & i & " = " & n * i) 

        Next 
        Console.WriteLine("=========================")

    End Sub
End Module
