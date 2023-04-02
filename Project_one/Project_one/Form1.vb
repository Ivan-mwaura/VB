
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Windows.Forms
Public Class Form1

    Private score As Integer

    Private grade As String
    'Private _cat, _assign, _exam As Integer


    'Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Cbostudy.Items.AddRange(New String() {"1.1", "1.2", "2.1", "2.2", "3.1", "3.2", "4.1", "4.2"})
        Cbostudy.SelectedIndex = 1
        Cbostudy.SelectedIndex = 2
        Cbostudy.SelectedIndex = 3
        Cbostudy.SelectedIndex = 4
        Cbostudy.SelectedIndex = 5
        Cbostudy.SelectedIndex = 6
        Cbostudy.SelectedIndex = 7


        'Try
        'Pro_cat = CInt(txtcat.Text)
        'Pro_assign = CInt(txtassign.Text)
        'Pro_exam = CInt(txtexam.Text)
        'Catch ex As Exception
        'MessageBox.Show("Please enter valid numbers")
        'End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Cbostudy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbostudy.SelectedIndexChanged
        If Cbostudy.SelectedIndex = 1 Then
            Cbounits.Items.Clear()
            Cbounits.Items.AddRange(New String() {"BIT2118", "ICS2104", "SMa2100", "BIT2305"})
        ElseIf Cbostudy.SelectedIndex = 2 Then
            Cbounits.Items.Clear()
            Cbounits.Items.AddRange(New String() {"BIT2118", "ICS2104", "SMa2100", "BIT2305"})
        ElseIf Cbostudy.SelectedIndex = 3 Then
            Cbounits.Items.Clear()
            Cbounits.Items.AddRange(New String() {"BIT2118", "ICS2104", "SMa2100", "BIT2305"})
        ElseIf Cbostudy.SelectedIndex = 4 Then
            Cbounits.Items.Clear()
            Cbounits.Items.AddRange(New String() {"BIT2118", "ICS2104", "SMa2100", "BIT2305"})
        ElseIf Cbostudy.SelectedIndex = 5 Then
            Cbounits.Items.Clear()
            Cbounits.Items.AddRange(New String() {"BIT2118", "ICS2104", "SMa2100", "BIT2305"})
        ElseIf Cbostudy.SelectedIndex = 6 Then
            Cbounits.Items.Clear()
            Cbounits.Items.AddRange(New String() {"BIT2118", "ICS2104", "SMa2100", "BIT2305"})
        ElseIf Cbostudy.SelectedIndex = 7 Then
            Cbounits.Items.Clear()
            Cbounits.Items.AddRange(New String() {"BIT2118", "ICS2104", "SMa2100", "BIT2305"})
        Else
            Cbounits.Items.Clear()
            Cbounits.Items.Add("Not Defined")
        End If
    End Sub

    Public Function determinegender() As String
        If rbmale.Checked = True Then
            rbfemale.Checked = False
            rbother.Checked = False
            Return rbmale.Text

        ElseIf rbfemale.Checked = True Then
            rbmale.Checked = False
            rbother.Checked = False
            Return rbfemale.Text

        Else
            rbmale.Checked = False
            rbfemale.Checked = False
            Return rbother.Text
        End If
    End Function




    Public Property CrystalReportViewer1 As Object

    Public Sub computescore()
        score = CInt(txtcat.Text) + CInt(txtassign.Text) + CInt(txtexam.Text)
        If score <= 39 Then
            grade = "E"
        ElseIf score <= 49 Then
            grade = "D"
        ElseIf score <= 59 Then
            grade = "C"
        ElseIf score <= 69 Then
            grade = "B"
        Else
            grade = "A"
        End If
    End Sub
    Public Sub print()
        lstoutput.Items.Clear()
        lstoutput.Items.Add("Name: " & txtname.Text)
        lstoutput.Items.Add("RegNo: " & txtregno.Text)
        lstoutput.Items.Add("Gender: " & determinegender())
        lstoutput.Items.Add("Year of Study: " & Cbostudy.Text)
        lstoutput.Items.Add("Unit: " & Cbounits.Text)
        lstoutput.Items.Add("Score: " & score)
        lstoutput.Items.Add("Grade: " & grade)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        computescore()
        print()

        'connection = New MySqlConnection
        'connection.ConnectionString = "server=localhost;username=root;password="";database=student_details"
        Dim connectionString As String = "server=localhost;user=root;password='';database=db_students"
        Dim connection As New MySqlConnection(connectionString)


        Try
            connection.Open()
            Dim query As String = "INSERT INTO tb_students (RegistrationNumber, StudentName, Yearofstudy, Units, Gender, Cat, Assignment, Exam, Grade) VALUES (@regno, @name, @study, @units, @gender, @cat, @assign, @exam, @grade)"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@regno", txtregno.Text)
            command.Parameters.AddWithValue("@name", txtname.Text)
            command.Parameters.AddWithValue("@study", Cbostudy.Text)
            command.Parameters.AddWithValue("@units", Cbounits.Text)
            command.Parameters.AddWithValue("@gender", determinegender())
            command.Parameters.AddWithValue("@cat", txtcat.Text)
            command.Parameters.AddWithValue("@assign", txtassign.Text)
            command.Parameters.AddWithValue("@exam", txtexam.Text)
            command.Parameters.AddWithValue("@grade", grade)
            command.ExecuteNonQuery()
            MessageBox.Show("Data Saved")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        Dim connectionString As String = "server=localhost;user=root;password='';database=db_students"
        Dim connection As New MySqlConnection(connectionString)
        Try

            connection.Open()

            Dim query As String = "UPDATE tb_students SET StudentName = @name, Yearofstudy = @study, Units = @units, Gender = @gender, Cat = @cat, Assignment = @assign, Exam = @exam, Grade = @grade WHERE RegistrationNumber = @regno"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@name", txtname.Text)
            command.Parameters.AddWithValue("@study", Cbostudy.Text)
            command.Parameters.AddWithValue("@units", Cbounits.Text)
            command.Parameters.AddWithValue("@gender", determinegender())
            command.Parameters.AddWithValue("@cat", txtcat.Text)
            command.Parameters.AddWithValue("@assign", txtassign.Text)
            command.Parameters.AddWithValue("@exam", txtexam.Text)
            command.Parameters.AddWithValue("@grade", grade)
            command.Parameters.AddWithValue("@regno", txtregno.Text)

            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Data updated successfully.")
            Else
                MessageBox.Show("No rows were updated.")
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim connectionString As String = "server=localhost;user=root;password='';database=db_students"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim query As String = "DELETE FROM tb_students WHERE RegistrationNumber = @regno"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@regno", txtregno.Text)
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Data deleted successfully.")
            Else
                MessageBox.Show("No rows were deleted.")
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class
