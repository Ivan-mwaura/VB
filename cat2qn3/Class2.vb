Public Class Class2

    Inherits Class1
    Private name, birth_date, address, contact, specialization As String
    Public Sub getStaff_details()

        getDepartment()

        Console.Write("Enter the name of the Staff : ")
        name = CStr(Console.ReadLine())

        Console.Write("Enter the staffs date of birth : ")
        birth_date = CStr(Console.ReadLine())

        Console.Write("Enter the Staffs phone contact : ")
        contact = CStr(Console.ReadLine)

        Console.Write("Enter the employee core specialization : ")
        specialization = CStr(Console.ReadLine())

    End Sub

    Public Sub Print_staff()
        Print()
        Console.Write("Name : " & name)
        Console.ReadLine()
        Console.Write("Date of Birth : " & birth_date)
        Console.ReadLine()
        Console.Write("Phone Contact : " & contact)
        Console.ReadLine()
        Console.Write("Specilization : " & specialization)
        Console.ReadLine()
    End Sub

End Class
