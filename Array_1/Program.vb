Imports System

Module Program
    Sub Main(args As String())

        Dim price() As Double = {50, 50, 30, 20, 40, 70, 90, 120, 150, 130}
        Dim total, cheapest, expensive As Double
        Dim i As Integer

        For i = LBound(price) To UBound(price) Step 1
            total = total + price(i)
        Next
        Console.WriteLine("The cost of items = " & total)

        cheapest = price(0)
        expensive = price(0)

        For i = LBound(price) To UBound(price) Step 1

            If (price(i) < cheapest) Then
                cheapest = price(i)
            ElseIf (price(i) > expensive) Then
                expensive = price(i)
            End If
        Next

        Console.WriteLine("cheapest item cost = " & cheapest)
        Console.WriteLine("Expensive item cost = " & expensive)

        Array.Sort(price)
        For i = LBound(price) To UBound(price)
            Console.Write((price(i) & Space(2)))
        Next
        Console.WriteLine()

        Array.Reverse(price)
        For i = LBound(price) To UBound(price)
            Console.Write((price(i) & Space(2)))
        Next

    End Sub
End Module
