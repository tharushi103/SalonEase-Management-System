Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class frmpassreset
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            Connectsalonease()

            Dim cmd As New MySqlCommand("SELECT f_hairstyle,f_facecream,f_perfume from userstable where f_hairstyle = @hairstyle, f_facecream = @facecream, f_perfume = @perfume", conn)
            cmd.Parameters.AddWithValue("@hairstyle", txthairstyle.Text)
            cmd.Parameters.AddWithValue("@txtfacecream.text", txtfacecream)
            cmd.Parameters.AddWithValue("@txtperfume.text", txtperfume)


            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim resetpassword As New resetpassword()
                resetpassword.Show()
                Me.Hide()

            Else
                MessageBox.Show("Incorrect answers. Please try again.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            reader.Close()
            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try



    End Sub
End Class