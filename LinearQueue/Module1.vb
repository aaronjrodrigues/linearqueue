Module Module1
    Dim Selection, HeadPointer, TailPointer, Input, Length, Counter As Integer
    Dim Queue(10) As Integer
    Sub Main()
        HeadPointer = 0
        TailPointer = -1
        Length = 0
        While Selection < 4
            Console.WriteLine("Input 1 for Enqueue")
            Console.WriteLine("Input 2 for Dequeue")
            Console.WriteLine("Input 3 to view contents of queue")
            Console.WriteLine("Input 4 to exit")
            Selection = Console.ReadLine
            If Selection = 1 Then
                Call Enqueue()
            ElseIf Selection = 2 Then
                Call Dequeue()
            ElseIf Selection = 3 Then
                Call Output()
            End If
        End While
        Console.ReadKey()
    End Sub

    Sub Enqueue()
        If Length = 10 Then
            Console.WriteLine("Queue is full")
        ElseIf Length < 10 Then
            Console.WriteLine("Enter input.")
            TailPointer = TailPointer + 1
            Length = Length + 1
            Queue(TailPointer) = Input
        End If

    End Sub

    Sub Dequeue()
        If Length = 0 Then
            Console.WriteLine("Queue is empty, please enqueue.")
        ElseIf Length > 1 Then
            HeadPointer = HeadPointer + 1
            Length = Length - 1
        End If
    End Sub

    Sub Output()
        If Length = 0 Then
            Console.WriteLine("Queue is empty, please enqueue.")
        Else
            For Counter = HeadPointer To TailPointer
                Console.WriteLine(Queue(Counter))
            Next
        End If


    End Sub
End Module
