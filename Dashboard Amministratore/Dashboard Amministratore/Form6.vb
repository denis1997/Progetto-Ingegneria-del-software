﻿Imports MySql.Data.MySqlClient

Public Class Form6

    Dim connection As New MySqlConnection
    Dim command As MySqlCommand
    Dim READER As MySqlDataReader



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As New Integer
        Dim query1 As String
        Try
            connection.Open()
            query1 = "select count(ID) from zona where IDcitta=@id"
            command = New MySqlCommand(query1, connection)
            command.Parameters.Add("@id", MySqlDbType.Int24).Value = CInt(TextBox3.Text)

            READER = command.ExecuteReader

            If READER.Read Then
                i = READER(0)
            End If
            READER.Close()

            Dim query As String
            query = "insert into zona (idposizione,nome,idcitta) values ('" & i + 1 & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
            command = New MySqlCommand(query, connection)
            READER = command.ExecuteReader

            MessageBox.Show("Nuova zona aggiunta")

            connection.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Hide()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost; username=root; password=andrea98; database=databasesensori;"

        Try
            connection.Open()
            Dim query As String
            query = "select id, nome from citta"
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
End Class