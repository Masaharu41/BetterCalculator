Option Explicit On
Option Strict On
'OwenFujii
'RCET 2265
'Spring 2024
'Better Calculator
'https://github.com/Masaharu41/BetterCalculator.git

Imports System.Runtime.Remoting.Services

Module BetterCalculator

    Sub Main()

        Dim num1 As String
        Dim numE1 As Integer
        Dim num2 As String
        Dim numE2 As Integer
        Dim operation As String
        Dim leave As Boolean = False
        Do
            operation = ""
            Console.WriteLine("Please enter two numbers. Press 'q' at any point to quit")
            Console.WriteLine("Enter Number 1:")
            num1 = Console.ReadLine()
            Try
                numE1 = CInt(num1)
            Catch ex As Exception
                If num1 = "q" Then
                    leave = True
                Else
                    Console.WriteLine($"You entered {num1}. Please input a whole number")
                End If

            End Try
            Console.WriteLine($"You have Entered {numE1}")
            Console.WriteLine("Enter Number 2:")
            num2 = Console.ReadLine()
            Try
                numE2 = CInt(num2)
            Catch ex As Exception
                If num2 = "q" Then
                    leave = True
                Else
                    Console.WriteLine($"You entered {num2}. Please input a whole number")
                End If
            End Try
            Console.WriteLine($"You have Entered {numE2}")

            Do
                Console.WriteLine("Please select the desired operation ")
                operation = Console.ReadLine()
                Select Case operation
                    Case "1"
                        operation = "+"
                    Case "2"
                        operation = "-"
                    Case "3"
                        operation = "*"
                    Case "4"
                        operation = "/"
                    Case "q"
                        leave = True
                    Case Else
                        Console.WriteLine("Please enter a valid selection")
                End Select
            Loop While operation = ""
            Console.WriteLine($"You have selected {operation}")
            Console.WriteLine($"{numE1} {operation} {numE2}")

        Loop Until leave

        Console.WriteLine("Have a Nice Day!")
        Console.Read()

    End Sub

End Module
