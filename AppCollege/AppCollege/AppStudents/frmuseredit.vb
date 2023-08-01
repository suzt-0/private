Imports AppCollege.dbconfig
Imports MySql.Data.MySqlClient
Public Class frmuseredit
    'Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\NCIT\BCA VP VB.NET\AppStudents\dbstudent.accdb")

    Sub load_user(ByVal id As Integer)
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select * from tbluser where ID=" & id
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            txtuser.Text = dt.Rows(0).Item("username")
            txtuserid.Text = dt.Rows(0).Item("ID")
            txtpassreg.Text = dt.Rows(0).Item("upassword")
            cmbusertype.Text = dt.Rows(0).Item("usertype")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub frmuseredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        load_grid()
    End Sub





    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim sql As String
            Dim i As Integer

            con.Open()
            sql = "update tbluser set username='" & txtuser.Text & "',upassword='" & txtpassreg.Text & "',usertype='" & cmbusertype.Text & "' where ID=" & txtuserid.Text
            'MsgBox(sql)
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("User record has been updated successfully!")
                load_grid()
                empty_fields()
            Else
                MsgBox("No record has been updated!")
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
        txtuser.Text = ""
        txtuserid.Text = ""
        txtuser.Select()
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        load_user(DataGridView1.Item(0, i).Value)

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim sql As String
            Dim i As Integer

            con.Open()
            sql = "delete from tbluser where ID=" & txtuserid.Text
            Dim mysc As New MySqlCommand(sql, con)

            i = mysc.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Student record has been deleted successfully!")

                load_grid()
                empty_fields()
            Else
                MsgBox("No record has been deleted!")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
End Class