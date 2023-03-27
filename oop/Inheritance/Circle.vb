Public Class Circle 'This class has 7 members(radius, area, perimeter, getdimensions, computearea, computeperimeter and print
    Inherits Shape
    Private radius As Integer

    Public Sub getdimensions()
        Console.Write("Enter the radius :")
        radius = CInt(Console.ReadLine())
    End Sub

    Public Sub computearea()
        area = Math.PI * Math.Pow(radius, 2)
    End Sub

    Public Sub computeperimeter()
        perimeter = Math.PI * radius * 2
    End Sub

    Public Overrides Sub Print()
        MsgBox("Area = " & Format(area, "0.00") & vbNewLine & "Perimeter = " & Format(perimeter, "0.00"))
    End Sub

End Class
