Imports System

Module Program
    Sub Main(args As String())
        Dim anoAtual As Integer = 2026
        Dim anoNascimento as Integer
        
        Console.WriteLine("Digite seu ano de nascimento: ")
        anoNascimento = CInt(Console.ReadLine())

        Dim idade As Integer = anoAtual - anoNascimento

        Console.WriteLine("Você tem " & idade & " anos!")
    End Sub
End Module
