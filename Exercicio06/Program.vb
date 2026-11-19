Imports System

Module Program
    Sub Main(args As String())


        
        Console.WriteLine("===== MENU =====" & vbCrLf & "1 - Ver saldo" & vbCrLf & "2 - Fazer depósito" & vbCrLf & "3 - Fazer saque" & vbCrLf & "4 - Sair" & vbCrLf & "Escolha uma opção: ")
        Dim numero as Integer = CInt(Console.ReadLine())

        Dim saldo as Double = 1000

        Select Case numero
            Case 1  
                Console.WriteLine("Seu saldo é R$ " & saldo)
            Case 2
                Console.WriteLine("Quanto qual seria o valor do depósito? R$ ")
                Dim Deposito As Double = CDbl(Console.ReadLine())

                If Deposito > 0 Then
                    saldo = saldo + Deposito
                    Console.WriteLine("Depósito realizado!")
                Else
                    Console.WriteLine("Valor de depósito inválido!")
                End If

                Console.WriteLine("Seu saldo é R$ " & saldo)
            Case 3  
                Console.WriteLine("Quanto você deseja sacar? R$ ")
                Dim saque As Double = CDbl(Console.ReadLine())

                If saque > 0 And saque <= saldo Then
                    saldo = saldo - saque
                    Console.WriteLine("Saque realizado!")
                Else
                    Console.WriteLine("Saldo insuficiente ou valor inválido!")
                End If

                Console.WriteLine("Seu saldo é R$ " & saldo)

            Case 4  
                Console.WriteLine("Encerrando o programa...")
            Case Else  
                Console.WriteLine("Opção inválida!")

        End Select
    End Sub
End Module
