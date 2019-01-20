Imports MySql.Data.MySqlClient
Public Class Form2
    Dim connection As New MySqlConnection
    Dim command As MySqlCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost; username=root; database=databasegestore;"
        Dim READER As MySqlDataReader


        Try
            connection.Open()
            Dim query As String
            query = "insert into databasegestore.gestore (ID , username , password_ , tipoArea, IDArea) values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "'  )"
            command = New MySqlCommand(query, connection)
            READER = command.ExecuteReader

            MessageBox.Show("Nuovo gestore aggiunto")

            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try
        Me.Hide()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class