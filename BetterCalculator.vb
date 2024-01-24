'OwenFujii
'RCET 2265
'Spring 2024
'Better Calculator
'https://github.com/Masaharu41/BetterCalculator.git

Option Explicit On
Option Strict On
Module BetterCalculator

    Sub Main()
        'Define variables used through out program
        Dim num1 As String
        Dim numE1 As Integer
        Dim num2 As String
        Dim numE2 As Integer
        Dim operation As String
        Dim operation2 As String
        Dim leave As Boolean = False
        Do
            operation = ""
            operation2 = ""
            'writes condition to exit program as well as asks for first numerical input
            Console.WriteLine("Please enter two numbers. Press 'q' at any point to quit")
            Console.WriteLine("Enter Number 1:")
            num1 = Console.ReadLine()
            'try catch to verify that num1 is an integer
            Try
                numE1 = CInt(num1)
            Catch ex As Exception
                If num1 = "q" Then
                    leave = True
                    Exit Do
                    'when user inputs a "q" exits to next loop
                Else
                    Console.WriteLine($"You entered {num1}. Please input a whole number")
                End If

            End Try
            'reports the prior input while asking for the next number
            Console.WriteLine($"You have Entered {numE1}")
            Console.WriteLine("Enter Number 2:")
            num2 = Console.ReadLine()
            'try catch to verify that num1 is an integer
            Try
                numE2 = CInt(num2)
            Catch ex As Exception
                If num2 = "q" Then
                    leave = True
                    'when user inputs "q" exits to next loop
                    Exit Do
                Else
                    Console.WriteLine($"You entered {num2}. Please input a whole number")
                End If
            End Try

            Console.WriteLine($"You have Entered {numE2}")

            Do
                'asks user to select which operation to perform on the numbers inputed prior
                Console.WriteLine("Please select the desired operation" & vbNewLine _
                                  & "Press 1 for Addition" & vbNewLine _
                                  & "Press 2 for Subtraction" & vbNewLine _
                                  & "Press 3 for Multiplication" & vbNewLine _
                                  & "Press 4 for Division")
                operation = Console.ReadLine()
                'requires that the user choose from one of the four avalible operations
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
                        Exit Do
                    Case Else
                        Console.WriteLine("Please enter a valid selection")
                End Select
            Loop While operation = ""

            If operation = "q" Then
                Exit Do
                'additional code to force program to the highest level Do loop in the program
            Else
                'code which excutes the user selected operation
                Console.WriteLine($"You have Selected {operation}")
                Console.WriteLine($"{numE1} {operation} {numE2}")
                If operation = "+" Then
                    Console.WriteLine(numE1 + numE2)
                ElseIf operation = "-" Then
                    Console.WriteLine(numE1 - numE2)
                ElseIf operation = "*" Then
                    Console.WriteLine(numE1 * numE2)
                ElseIf operation = "/" Then
                    Console.WriteLine(numE1 / numE2)

                End If
            End If

        Loop Until leave

        'gives message to user as well as condition to close console
        Console.WriteLine("Have a Nice Day!")
        Console.WriteLine("Press enter to close window")
        Console.Read()

    End Sub

End Module
