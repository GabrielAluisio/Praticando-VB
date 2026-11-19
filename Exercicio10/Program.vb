Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Digite um número: ")
        Dim n As Integer = Cint(Console.ReadLine())

        Dim pares As string = ""
        Dim impares As string = ""

        Dim ContI As Integer = 0
        Dim ContP As Integer = 0


        For  i As Integer = 0 To n
            if  i mod 2 = 0 Then

                if pares = "" Then
                    pares = i
                Else
                    pares = pares & ", " & i
                End If 

                ContP += 1
            Else
                if impares = "" Then
                    impares = i
                Else
                    impares = impares & ", " & i
                End If
                 
                ContI += 1
            End If
            

        Next  i

        Console.WriteLine("Pares: " & pares)
        Console.WriteLine("Ímpares: " & impares)
        Console.WriteLine()
        Console.WriteLine("Quantidade de pares: " & ContP)
        Console.WriteLine("Quantidade de ímpares: " & ContI)


    End Sub
End Module
