
Imports MySql.Data.MySqlClient

Public Class Form23
    Dim connection As New MySqlConnection
    Dim command As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasesensori;"

        Try
            connection.Open()
            Dim query As String
            query = "select id, nome from zona"
            command = New MySqlCommand(query, connection)
            READER = command.ExecuteReader
            While READER.Read
                ListBox1.Items.Add(READER(0).ToString + "   " + READER(1).ToString)
            End While
            READER.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End Sub
    Dim a As Integer
    Dim b As Integer
    Dim p As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection.Open()
            Dim query As String
            query = "select idcitta, idposizione from zona where id=@id"
            command = New MySqlCommand(query, connection)
            command.Parameters.Add("@id", MySqlDbType.Int24).Value = CInt(TextBox3.Text)
            READER = command.ExecuteReader
            If READER.Read Then
                a = READER(0)
                p = READER(1)
            End If
            READER.Close()
            query = "select count(id) from zona where idcitta = @id"
            command = New MySqlCommand(query, connection)
            command.Parameters.Add("@id", MySqlDbType.Int24).Value = a
            READER = command.ExecuteReader
            If READER.Read Then
                b = READER(0)
            End If
            READER.Close()

            For i As Integer = p To b
                query = "UPDATE zona SET idposizione=@id1 where idposizione=@id2 and idcitta=@id3"
                command = New MySqlCommand(query, connection)
                command.Parameters.Add("@id1", MySqlDbType.Int24).Value = i - 1
                command.Parameters.Add("@id2", MySqlDbType.Int24).Value = i
                command.Parameters.Add("@id3", MySqlDbType.Int24).Value = a
                READER = command.ExecuteReader
                READER.Close()
            Next


            Dim query1 As String
            query1 = "delete from zona where(id) = ('" & TextBox3.Text & "') "
            command = New MySqlCommand(query1, connection)
            READER = command.ExecuteReader

            MessageBox.Show("Zona rimossa")

            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Hide()
    End Sub

End Class