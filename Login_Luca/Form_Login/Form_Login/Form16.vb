Imports MySql.Data.MySqlClient

Public Class Form16

    Dim connection As New MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasesensori;"
        Dim READER As MySqlDataReader
        Try
            connection.Open()
            Dim query As String
            query = "insert into citta (nome) values ('" & TextBox1.Text & "')"
            command = New MySqlCommand(query, connection)
            READER = command.ExecuteReader

            MessageBox.Show("Nuova città aggiunta")

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Hide()
    End Sub
End Class