Imports AppCollege.dbconfig
Imports MySql.Data.MySqlClient
Public Class LoginForm1


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        ''for mysql connection
        Try
            Dim sql As String = ""
            sql = "Select * from tbluser where username='" & txtuser.Text & "' and upassword='" & txtpass.Text & "'"
            con.Open()
            'Dim cmd As New MySqlCommand(sql, con)
            Dim da As New MySqlDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                'MsgBox("has rows")
                Me.Hide()
                MDIParent1.Show()
                If (dt.Rows(0).Item("usertype") = "Admin") Then
                    MDIParent1.UerToolStripMenuItem.Visible = True
                End If
            Else
                MsgBox("Invalid Username or Password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                'MsgBox("Connected")
            Else
                MsgBox("Not Connected!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
