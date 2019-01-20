Imports MySql.Data.MySqlClient



Public Class Form1

    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim s As String
    Public abab As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Username" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Password" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
        End If
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        connection.ConnectionString = "datasource=localhost;port=3306;username=root;password=mysql2018;SslMode = none;database=databasegestore"

        s = "select tipoarea, idarea from gestore where username=@u and password_=@p"
        command = New MySqlCommand(s, connection)

        command.Parameters.Add("@u", MySqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@p", MySqlDbType.VarChar).Value = TextBox2.Text
        Try
            connection.Open()
            reader = command.ExecuteReader

            If reader.Read Then
                abab = reader(1)
                Select Case CStr(reader(0))
                    Case "edificio"
                        FormEdificio.Show()
                        connection.Close()
                        Me.Hide()
                    Case "zona"
                        FormZona.Show()
                        connection.Close()
                        Me.Hide()
                    Case "citta"
                        FormCitta.Show()
                        connection.Close()
                        Me.Hide()
                End Select
            Else
                MessageBox.Show("dati errati")
            End If

            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            FormAmministratore.Show()
            Me.Hide()
        Else
            MessageBox.Show("dati errati")
        End If

    End Sub

End Class
