Imports System

Module Program
    Sub Main(args As String())

        Dim Names() As String = {"Amina", "Brian", "Faith"}
        Dim marks(,) As Integer = {{70, 39, 60}, {53, 38, 70}, {84, 60, 58}}
        Dim row, col As Integer
        Dim sum As Integer
        Dim grade As Char
        Dim average As Double

        Console.WriteLine("Name BIT2118 ICS2105 ICS2101 Average Grade")

        For row = LBound(marks, 1) To UBound(marks, 1) Step 1
            Console.Write(Names(row) & vbTab)
            sum = 0
            For col = LBound(marks, 2) To UBound(marks, 2) Step 1
                Console.Write(marks(row, col) & vbTab)
                sum = sum + marks(row, col)
            Next
            average = sum / marks.GetLength(1)
            Console.WriteLine(Format(average, "0.0") & vbTab)

            If (average <= 39) Then
                grade = CChar("E")
            ElseIf (average <= 49) Then
                grade = CChar("D")
            ElseIf (average <= 59) Then
                grade = CChar("C")
            ElseIf (average <= 69) Then
                grade = CChar("B")
            ElseIf (average <= 79) Then
                grade = CChar("A")
            End If
            Console.WriteLine(grade & vbTab)

            Console.WriteLine()
        Next

        Console.ReadKey()


    End Sub
End Module
