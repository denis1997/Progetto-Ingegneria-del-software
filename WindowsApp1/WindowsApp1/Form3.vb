
Imports MySql.Data.MySqlClient

Public Class Form3
    Dim query As String
    Dim connection As New MySqlConnection
    Dim connection1 As New MySqlConnection
    Dim connection2 As New MySqlConnection
    Dim command As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasesensori;"
        connection1 = New MySqlConnection
        connection1.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasehistory;"
        connection2 = New MySqlConnection
        connection2.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasesimulatore;"

        Try
            connection.Open()
            query = "select s.idspecifico from areapiano a join piano p join sensore s where s.idareapiano=a.id and a.idpiano=p.id and p.idedificio=@id"
            command = New MySqlCommand(query, connection)
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Form1.edificio

            READER = command.ExecuteReader

            While READER.Read
                ListBox1.Items.Add(READER(0).ToString)
            End While

            READER.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            connection.Open()
            query = "select s.idspecifico from areapiano a join piano p join sensore s where s.idareapiano=a.id and a.idpiano=p.id and p.idedificio=@id and s.idspecifico=@ids"
            command = New MySqlCommand(query, connection)
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Form1.edificio
            command.Parameters.Add("@ids", MySqlDbType.String).Value = TextBox1.Text

            Dim a As Integer = 0
            READER = command.ExecuteReader
            If READER.Read Then
                a = 1
            End If
            READER.Close()

            If a = 1 Then
                Dim query1 As String
                query1 = "delete from sensore where(idspecifico) = ('" & TextBox1.Text & "') "
                command = New MySqlCommand(query1, connection)
                READER = command.ExecuteReader
                READER.Close()
                connection1.Open()
                query1 = "delete from sensore where(idspecifico) = ('" & TextBox1.Text & "') "
                command = New MySqlCommand(query1, connection1)
                READER = command.ExecuteReader
                READER.Close()
                connection1.Close()
                connection2.Open()
                query1 = "delete from sensore where(idspecifico) = ('" & TextBox1.Text & "') "
                command = New MySqlCommand(query1, connection2)
                READER = command.ExecuteReader
                READER.Close()
                connection2.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
        Me.Hide()

    End Sub

End Class