
Imports MySql.Data.MySqlClient

Public Class Form26
    Dim connection As New MySqlConnection
    Dim command As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasesensori;"

        Try
            connection.Open()
            Dim query As String
            query = "select id, nome from areaaperto"
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            connection.Open()
            Dim query As String
            query = "select idzona, idposizione from areaaperto where id=@id"
            command = New MySqlCommand(query, connection)
            command.Parameters.Add("@id", MySqlDbType.Int24).Value = CInt(TextBox3.Text)
            READER = command.ExecuteReader
            If READER.Read Then
                a = READER(0)
                p = READER(1)
            End If
            READER.Close()
            query = "select count(id) from areaaperto where idzona = @id"
            command = New MySqlCommand(query, connection)
            command.Parameters.Add("@id", MySqlDbType.Int24).Value = a
            READER = command.ExecuteReader
            If READER.Read Then
                b = READER(0)
            End If
            READER.Close()

            For i As Integer = p To b
                query = "UPDATE areaaperto SET idposizione=@id1 where idposizione=@id2 and idzona=@id3"

                command = New MySqlCommand(query, connection)
                command.Parameters.Add("@id1", MySqlDbType.Int24).Value = i - 1
                command.Parameters.Add("@id2", MySqlDbType.Int24).Value = i
                command.Parameters.Add("@id3", MySqlDbType.Int24).Value = a
                READER = command.ExecuteReader
                READER.Close()
            Next


            Dim query1 As String
            query1 = "delete from areaaperto where(id) = ('" & TextBox3.Text & "') "
            command = New MySqlCommand(query1, connection)
            READER = command.ExecuteReader

            MessageBox.Show("Area all'aperto rimossa")

            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Hide()
    End Sub
End Class