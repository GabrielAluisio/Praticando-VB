Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Digite a tabuada desejada: ")
        Dim tabu As Integer = CInt(Console.ReadLine())

        Console.WriteLine("Até qual número: ")
        Dim ate As Integer = CInt(Console.ReadLine())

        If ate < 1 Then
            Console.WriteLine("Digite um número maior que zero!")
            Return
        End If

        For i As Integer = 1 To ate
            Console.WriteLine(tabu & " x " & i & " = " & (tabu * i))
        Next i

    End Sub
End Module
