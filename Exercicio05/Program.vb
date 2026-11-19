Imports System

Module Program
    Sub Main(args As String())
        Dim N1 As Double
        Dim N2 As Double


        Console.WriteLine("Digite o primeiro número: ")
        N1 = CDbl(Console.ReadLine())

        Console.WriteLine("Digite o segundo número: ")
        N2 = CDbl(Console.ReadLine())


        Console.WriteLine("Escolha a operção (+, -, *, /): ")
        Dim op As String = Console.ReadLine()

        Dim Resultado as Double

        If op = "+" Then
            Resultado = N1 + N2
        ElseIf op = "-" Then
            Resultado = N1 - N2
        ElseIf op = "*" Then
            Resultado = N1 * N2
        ElseIf op = "/" Then
            If N2 <> 0 Then
                Resultado = N1 / N2
            Else
                Console.WriteLine("Não é possível dividir por zero!") 
                Return
            End If
        Else
            Console.WriteLine("Operação inválida!")
            Return
        End If

        Console.WriteLine("Resultado: " & Resultado)


    End Sub
End Module
