Public Class Rectangle
    Inherits Shape

    Private length, width As Integer

    Public Overrides Sub getdimensions()
        Console.Write("Enter the length  :")
        length = CInt(Console.ReadLine())
        Console.Write("Enter the length  :")
        width = CInt(Console.ReadLine())
    End Sub

    Public Overrides Sub computearea()
        area = length * width
    End Sub

    Public Overrides Sub computeperimeter()
        perimeter = 2 * (length + width)
    End Sub
End Class

