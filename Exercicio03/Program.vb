Imports System

Module Program
    Sub Main(args As String())

        Dim idade As Integer

        Console.WriteLine("Digite sua idade: ")
        idade = CInt(Console.ReadLine())
        
        If idade < 18 Then
            Console.WriteLine("Você é menor de idade! ")
        ElseIf idade >= 18 Then 
            Console.WriteLine("Você é maior de idade!")
        Else 
            Console.WriteLine("Idade Incorreta!")       
        End If

    End Sub
End Module
