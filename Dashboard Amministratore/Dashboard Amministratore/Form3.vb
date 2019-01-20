Imports MySql.Data.MySqlClient
Public Class Form3
    Dim connection As New MySqlConnection
    Dim command As MySqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasegestore;"
        Dim READER As MySqlDataReader


        Try
            connection.Open()
            Dim query As String
            query = "delete from databasegestore.gestore where ( username ) = ( '" & TextBox2.Text & "'  )"
            command = New MySqlCommand(query, connection)
            READER = command.ExecuteReader

            MessageBox.Show("Gestore rimosso")

            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try
        Me.Hide()

    End Sub

End Class