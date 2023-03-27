Imports System

Module Program
    Sub Main(args As String())
        Dim x() As Integer = {1, 2, 3, 4, 5}c
        Dim i As Integer

        For i = LBound(x) To UBound(x)
            Console.Write(x(i) & vbTab)
        Next

        Console.WriteLine()
        ReDim Preserve x(9)
        For i = 5 To UBound(x)
            Console.WriteLine("Enter a value for index: " & i)
            x(i) = CInt(Console.ReadLine())

        Next
        For i = LBound(x) To UBound(x)
            Console.Write(x(i) & vbTab)
        Next


    End Sub
End Module
