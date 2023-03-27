Public Class Shape
    Protected area, perimeter As Double

    Public Overridable Sub Print()
        Console.WriteLine("Area = " & Format(area, "0.00") & vbNewLine & "Perimeter = " & Format(perimeter, "0.00"))
    End Sub

End Class
