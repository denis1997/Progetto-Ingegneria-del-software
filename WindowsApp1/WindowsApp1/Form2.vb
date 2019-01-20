

Imports MySql.Data.MySqlClient

Public Class Form2
    Dim query As String
    Dim connection As New MySqlConnection
    Dim connection1 As New MySqlConnection
    Dim connection2 As New MySqlConnection
    Dim command As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasesensori;"
        connection1 = New MySqlConnection
        connection1.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasehistory;"
        connection2 = New MySqlConnection
        connection2.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasesimulatore;"

        Try
            connection.Open()
            'Dim query As String
            query = "select a.id, a.nome from areapiano a join piano p where a.idpiano=p.id and p.idedificio=@id"
            command = New MySqlCommand(query, connection)
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Form1.edificio

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try



            connection.Open()
            Dim a As Integer = 0
            'Dim query As String
            Dim READER1 As MySqlDataReader
            query = "select a.id from areapiano a join piano p where a.idpiano=p.id and p.idedificio=@id and a.id=@ida"
            command = New MySqlCommand(query, connection)
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Form1.edificio
            command.Parameters.Add("@ida", MySqlDbType.Int32).Value = CInt(TextBox2.Text)

            READER1 = command.ExecuteReader

            If READER1.Read Then
                If READER1.IsDBNull(0) Then
                Else
                    a = 1
                End If
            End If
            READER1.Close()


            If a = 1 Then
                Select Case TextBox1.Text.Substring(0, 1)
                    Case "t"
                        query = "insert into sensore (idspecifico, valore, state, orainvioprecedente, idareapiano) values ('" & TextBox1.Text & "', 0, 1, current_timestamp(), '" & TextBox2.Text & "' )"
                        command = New MySqlCommand(query, connection)
                        READER = command.ExecuteReader
                        connection1.Open()
                        query = "insert into sensore (idspecifico) values ('" & TextBox1.Text & "' )"
                        command = New MySqlCommand(query, connection1)
                        READER = command.ExecuteReader
                        connection1.Close()
                        connection2.Open()
                        query = "insert into sensore (idspecifico, massimale, min_, max_) values ('" & TextBox1.Text & "', 30, 20, 40 )"
                        command = New MySqlCommand(query, connection2)
                        READER = command.ExecuteReader
                        connection2.Close()
                    Case "u"
                        query = "insert into sensore (idspecifico, valore, state, orainvioprecedente, idareapiano) values ('" & TextBox1.Text & "', 0, 1, current_timestamp(), '" & TextBox2.Text & "' )"
                        command = New MySqlCommand(query, connection)
                        READER = command.ExecuteReader
                        connection1.Open()
                        query = "insert into sensore (idspecifico) values ('" & TextBox1.Text & "' )"
                        command = New MySqlCommand(query, connection1)
                        READER = command.ExecuteReader
                        connection1.Close()
                        connection2.Open()
                        query = "insert into sensore (idspecifico, massimale, min_, max_) values ('" & TextBox1.Text & "', 50, 0, 100)"
                        command = New MySqlCommand(query, connection2)
                        READER = command.ExecuteReader
                        connection2.Close()
                    Case "p"
                        query = "insert into sensore (idspecifico, valore, state, orainvioprecedente, idareapiano) values ('" & TextBox1.Text & "', 0, 1, current_timestamp(), '" & TextBox2.Text & "' )"
                        command = New MySqlCommand(query, connection)
                        READER = command.ExecuteReader
                        connection1.Open()
                        query = "insert into sensore (idspecifico) values ('" & TextBox1.Text & "' )"
                        command = New MySqlCommand(query, connection1)
                        READER = command.ExecuteReader
                        connection1.Close()
                        connection2.Open()
                        query = "insert into sensore (idspecifico, massimale, min_, max_) values ('" & TextBox1.Text & "', 100, 90, 160 )"
                        command = New MySqlCommand(query, connection2)
                        READER = command.ExecuteReader
                        connection2.Close()
                    Case "l"
                        query = "insert into sensore (idspecifico, valore, state, orainvioprecedente, idareapiano) values ('" & TextBox1.Text & "', 0, 1, current_timestamp(), '" & TextBox2.Text & "' )"
                        command = New MySqlCommand(query, connection)
                        READER = command.ExecuteReader
                        connection1.Open()
                        query = "insert into sensore (idspecifico) values ('" & TextBox1.Text & "' )"
                        command = New MySqlCommand(query, connection1)
                        READER = command.ExecuteReader
                        connection1.Close()
                        connection2.Open()
                        query = "insert into sensore (idspecifico, massimale, min_, max_) values ('" & TextBox1.Text & "', 5000, 0, 10000 )"
                        command = New MySqlCommand(query, connection2)
                        READER = command.ExecuteReader
                        connection2.Close()
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()
        Me.Hide()

    End Sub


End Class