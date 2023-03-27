Imports System

Module Program
    Sub Main(args As String())
        Dim Circ1 As Circle = New Circle()
        Dim Rect1 As Rectangle = New Rectangle()

        Circ1.getdimensions()
        Circ1.computearea()
        Circ1.computeperimeter()
        Circ1.print()
    End Sub
End Module
