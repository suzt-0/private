Imports System.Windows.Forms

Public Class MDIParent1
   
    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Welcome " & LoginForm1.txtuser.Text & " !!"
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        frmuserreg.Show()
       
    End Sub

    Private Sub StudentNewEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentNewEntryToolStripMenuItem.Click
        frmstudent_reg.Show()
    End Sub

    Private Sub UpdateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateUserToolStripMenuItem.Click
        frmuseredit.show()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        frmuseredit.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
