Public MustInherit Class Shape
    Protected area, perimeter As Double

    Public Overridable Sub print()
        Console.WriteLine("Area = " & Format(area, "0.00") & vbNewLine & "Perimeter = " & Format(perimeter, "0.00"))
    End Sub

    Public MustOverride Sub getdimensions()
    Public MustOverride Sub computearea()

    Public MustOverride Sub computeperimeter()

End Class
