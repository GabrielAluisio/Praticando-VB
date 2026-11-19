Imports System

Module Program
    Sub Main(args As String())
        Dim nota As Double = 0 

        Console.WriteLine("Digite a nota do aluno: ")
        nota =CDbl(Console.ReadLine())

        If nota < 5 Then
            Console.WriteLine("Reprovado!")
        ElseIf nota < 7 Then
            Console.WriteLine("Recuperação!")
        Else
            Console.WriteLine("Aprovado!")
        End If
    End Sub
End Module
