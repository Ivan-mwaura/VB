Public Class Class1

    Private department, dep_description, name, stud_name, address, Contact, specialization, start_date, end_date As String
    Private no_of_staff, duration As Integer


    Public Sub getDepartment()
        'Console.Write("HOSPITAL DEPARTMENTS")
        'Console.WriteLine("Records")
        'Console.WriteLine("Surgery")
        'Console.WriteLine("Pharmacy")
        'Console.WriteLine("Consultation")
        'Console.WriteLine("Non official")



        Console.Write("Which is your department : ")
        department = CStr(Console.ReadLine)

        Console.Write("Enter the No of Staffs in the department : ")
        no_of_staff = CInt(Console.ReadLine())

        Console.Write("Enter a brief description of what the department does : ")
        dep_description = CStr(Console.ReadLine())

    End Sub

    Public Sub Print()

        Console.Write("Department Name : " & department)
        Console.WriteLine()
        Console.Write("No of Staffs : " & no_of_staff)
        Console.WriteLine()
        Console.Write("Department description " & dep_description)


    End Sub

End Class
