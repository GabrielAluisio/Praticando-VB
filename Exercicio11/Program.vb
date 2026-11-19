Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Digite um número: ")
        Dim n As Integer = Cint(Console.ReadLine())
        Dim f As Long = 1
        Dim frase As string = ""

        For i As Integer = 1 To n
            
            f = f * i

            if i = 1 Then
                frase = i 
            Else
                frase = i & " x " & frase
            End If
            

        Next i
        
        Console.WriteLine(n & "! = " & f)
        Console.WriteLine()
        Console. WriteLine(n & "! = " & frase & " = " & f)

    End Sub
End Module
