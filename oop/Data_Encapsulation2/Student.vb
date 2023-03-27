Imports System.Linq.Expressions
Imports System

Public Class Student
    Private cat, assign, exam As Integer
    Private reg_no As String
    Private grade As Char
    Private avg As Double

    Public Sub getdetails()

        Console.Write("Enter the cat marks :")
        Pro_cat = CInt(Console.ReadLine())

        Console.Write("Enter the assignment marks :")
        Pro_assign = CInt(Console.ReadLine())

        Console.Write("Enter the exam marks :")
        Pro_exam = CInt(Console.ReadLine())

        Console.Write("Enter the registration number of the student :")
        Pro_reg_no = Console.ReadLine()
    End Sub

    Public Sub determinegrade()
        avg = cat + assign + exam

        If (avg <= 39) Then
            grade = CChar("E")
        ElseIf (avg <= 49) Then
            grade = CChar("D")
        ElseIf (avg <= 59) Then
            grade = CChar("C")
        ElseIf (avg <= 69) Then
            grade = CChar("B")
        Else
            grade = CChar("A")
        End If
    End Sub

    Public Sub print()
        Console.WriteLine("Registration number is " & reg_no & vbNewLine & "Grade = " & grade)
    End Sub

    Public WriteOnly Property Pro_cat()
        Set(ByVal value)
Here:
            If value > 30 Or value < 0 Then
                Console.WriteLine("------Cat marks should be > 0 and <= 30.------")
                Console.Write("Please enter the cat marks again :")
                value = CInt(Console.ReadLine())
                Console.WriteLine()
                GoTo Here
            Else
                cat = value
            End If
        End Set
    End Property

    Public WriteOnly Property Pro_assign()
        Set(ByVal value)
Here:
            If value > 10 Or value < 0 Then
                Console.WriteLine("------Assignment marks should be > 0 and <= 10.------")
                Console.Write("Please enter the assignment marks again :")
                value = CInt(Console.ReadLine())
                Console.WriteLine()
                GoTo Here
            Else
                assign = value
            End If
        End Set
    End Property
    Public WriteOnly Property Pro_exam()
        Set(ByVal value)
Here:
            If value > 70 Or value < 0 Then
                Console.WriteLine("------The exam marks should be > 0 and <= 70.------")
                Console.Write("Please enter the exam marks again :")
                value = CInt(Console.ReadLine())
                Console.WriteLine()
                GoTo Here
            Else
                exam = value
            End If
        End Set
    End Property

    Public Property Pro_reg_no()
        Get
            Return reg_no
        End Get
        Set(ByVal value)
Here:
            If String.IsNullOrEmpty(value) Then
                Console.WriteLine("------The registration number should not be an empty string.------")
                Console.Write("Please enter the registration number again :")
                value = Console.ReadLine()
                Console.WriteLine()
                GoTo Here
            Else
                reg_no = value
            End If
        End Set
    End Property

    Public ReadOnly Property Pro_grade()
        Get
            Return grade
        End Get
    End Property
End Class
