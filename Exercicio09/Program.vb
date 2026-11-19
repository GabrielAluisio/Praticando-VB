Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Digite um número: ")
        Dim n as Integer = CInt(Console.ReadLine())

        Dim soma as Integer = 0
        Dim frase as String = ""

        For i As Integer = 1 To n
            soma = soma + i


            If i <> n Then
                frase = frase
                frase = frase & i & " + " 
            Else 
                frase = frase & i
            End If
        Next 

        Console.WriteLine(frase & " = " & soma)
    End Sub
End Module
