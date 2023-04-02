Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim adp As MySqlDataAdapter
    Dim dtb As New DataTable

    Sub Viewdata()
        cmd = New MySqlCommand("select * from tb_students", con)
        adp = New MySqlDataAdapter(cmd)
        adp.Fill(dtb)
        con.Close()
        con.Dispose()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtb.Clear()
        con = New MySqlConnection("server=localhost;user=root;password='';database=db_students")
        Dim myrpt As New CrystalReport1
        Viewdata()
        myrpt.Database.Tables("tb_students").SetDataSource(dtb)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt

    End Sub
End Class
