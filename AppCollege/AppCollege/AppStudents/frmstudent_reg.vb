Imports System.IO
Imports AppCollege.dbconfig
Imports MySql.Data.MySqlClient
Public Class frmstudent_reg

    'Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\NCIT\BCA VP VB.NET\AppStudents\dbstudent.accdb")

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim sql As String
            Dim i As Integer
            Dim gender As String = ""

            con.Open()

            If (radiomale.Checked = True) Then
                gender = "Male"
            ElseIf (radiofemale.Checked = True) Then
                gender = "Female"
            End If


            sql = "INSERT INTO tblstudent_reg (student_fname, student_lname, student_address, student_district, student_faculty, student_sem, student_rollno, student_dob,student_gender) values ('" & txtstudentfname.Text & "', '" & txtstudentlname.Text & "','" & txtaddress.Text & "'," & cmbdistrict.SelectedValue & ",'" & txtfaculty.Text & "', '" & txtsemester.Text & "','" & txtrollno.Text & "','" & txtdob.Text & "','" & gender & "')"
            'MsgBox(sql)
            Dim mysc As New MySqlCommand(sql, con)
            i = mysc.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("New Student record has been inserted successfully!")
                'upload photo 
                If (txtphoto.Text <> "") Then
                    File.Copy(txtphoto.Text, "D:\NCIT\BCA VP VB.NET\AppStudents\AppStudents\images\" + txtrollno.Text & ".jpg")
                End If


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
        txtaddress.Text = ""
        txtdob.Text = ""
        txtfaculty.Text = ""
        txtrollno.Text = ""
        txtsemester.Text = ""
        txtstudentfname.Text = ""
        txtstudentlname.Text = ""
        txtphoto.Text = ""
        txtstudentfname.Select()

    End Sub
    Sub load_grid()
        Try
            Dim sql As String
            Dim dt As New DataTable
            sql = "Select s.student_fname, s.student_lname, s.student_address, d.districtname, d.districtname_nep,s.student_faculty, s.student_sem, s.student_rollno, s.student_dob,s.student_gender from tblstudent_reg s left join defdistrict d on s.student_district=d.districtid"
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
    Sub load_district()
        Try
            Dim sql As String
            Dim ds As New DataSet
            sql = "Select * from defdistrict"
            Dim da As New MySqlDataAdapter(sql, con)

            da.Fill(ds)
            cmbdistrict.DataSource = ds.Tables(0)
            cmbdistrict.DisplayMember = "districtname"
            cmbdistrict.ValueMember = "districtid"


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub frmstudent_reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        load_grid()
        load_district()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnphoto_Click(sender As Object, e As EventArgs) Handles btnphoto.Click

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            txtphoto.Text = OpenFileDialog1.FileName
        End If


    End Sub
End Class