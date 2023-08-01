Imports AppCollege.dbconfig
Imports MySql.Data.MySqlClient
Public Class frmuserreg
    'Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\NCIT\BCA VP VB.NET\AppStudents\dbstudent.accdb")

    Private Sub frmuserreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        load_grid()

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim sql As String
            Dim i As Integer

            con.Open()
            sql = "INSERT INTO tbluser (username,upassword,usertype) values ('" & txtuserreg.Text & "', '" & txtpassreg.Text & "','" & cmbusertype.Text & "')"
            Dim mysc As New MySqlCommand(sql, con)

            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
                load_grid()
                empty_fields()
            Else
                MsgBox("No record has been inserted successfully!")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
    Sub empty_fields()
        txtpassreg.Text = ""
        txtuserreg.Text = ""
        txtuserreg.Select()
    End Sub
    Sub load_grid()
        Try


            Dim sql As String

            Dim dt As New DataTable
            sql = "Select * from tbluser"
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
