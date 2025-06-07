Imports MySql.Data.MySqlClient

Public Class resetpassword

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Try
            If txtreset.Text = "" Then
                MessageBox.Show("Please enter a new password.")
                Exit Sub
            End If
            connectsalonease()
            Dim cmd As New MySqlCommand("Update userstable SET password=@reset WHERE u_name=@username", conn)
            cmd.Parameters.AddWithValue("@reset", txtreset.Text)
            cmd.Parameters.AddWithValue("@username", txtrename.Text)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                ' MessageBox.Show("Password Updated successfully!")

                Dim salonservices As New salonservices()
                salonservices.Show()
                Me.Close()


            Else
                MessageBox.Show("Try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Disconnectsalonease()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class