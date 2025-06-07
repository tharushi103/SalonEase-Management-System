Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connectsalonease()
            Dim cmd As New MySqlCommand("SELECT useername,password FROM userstable WHERE username=@username AND password=@password", conn)
            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim salonservices As New salonservices()
                salonservices.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid UserName or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            reader.Close()
            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show("error:" & ex.Message)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles f_password.Click
        Dim frmpassreset As New frmpassreset()
        frmpassreset.Show()
        Me.Hide()

    End Sub

    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Dim UserDashboard As New UserDashboard()
        UserDashboard.Show()
        Me.Hide()

    End Sub
End Class
