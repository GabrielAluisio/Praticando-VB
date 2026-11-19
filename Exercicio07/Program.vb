Imports System

Module Program
    Sub Main(args As String())

        Dim saldo as Double = 1000


        While True
            
        Console.WriteLine("===== MENU =====")
        Console.WriteLine()
        Console.WriteLine("1 - Ver saldo")
        Console.WriteLine("2 - Fazer depósito")
        Console.WriteLine("3 - Fazer saque")
        Console.WriteLine("4 - Sair")
        Console.WriteLine()
        Console.WriteLine("Escolha uma opção:")
            

        Dim numero as Integer = CInt(Console.ReadLine())


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
                
                Exit While               
            Case Else  
                Console.WriteLine("Opção inválida!")

        End Select

        End While
    End Sub
End Module
