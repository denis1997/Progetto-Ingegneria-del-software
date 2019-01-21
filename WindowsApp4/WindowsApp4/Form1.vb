Option Strict On
Option Explicit On
Option Infer Off


Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1

    Private Const V As String = "nuovoValore"
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=andrea98;database=databasesensori;SslMode=none;")
    Dim connectionH As New MySqlConnection("datasource=localhost;port=3306;username=root;password=andrea98;database=databasehistory;SslMode=none;")
    Dim connectionS As New MySqlConnection("datasource=localhost;port=3306;username=root;password=andrea98;database=databasesimulatore;SslMode=none;")
    'Dim desktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
    Dim a As New Double
    Dim command As MySqlCommand
    Dim command1 As MySqlCommand
    Dim command2 As MySqlCommand
    Dim reader As MySqlDataReader
    Dim s As String
    Dim s1 As String
    Dim s2 As String

    Dim momento() As Integer
    Dim b As New Integer
    Dim massimale As New Double
    Dim generator As New Random

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not (e.KeyChar = ",") And Not (e.KeyChar = "-") Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not (e.KeyChar = ",") And Not (e.KeyChar = "-") Then
            e.Handled = True
        End If
    End Sub



    Private Sub Form1()

        Try

            Dim i As Integer = 1
            While i <= b

                command2 = New MySqlCommand(s2, connectionS)
                command2.Parameters.Add("@id", MySqlDbType.Int32).Value = i
                reader = command2.ExecuteReader

                'Select Case CStr(reader(0))
                'Case "t"
                'CDbl(generator.Next(200, 400) / 10)
                'Case "u"
                '  a = CDbl(generator.Next(0, 1000) / 10)
                ' Case "p"
                'a = CDbl(generator.Next(900, 1600) / 10)
                'Case "l"
                'a = CDbl(generator.Next(0, 10000))

                If reader.Read Then
                    If CInt(reader(5)) = 1 Then
                        a = CDbl(generator.Next(CInt(CDbl(reader(3)) * 10), CInt(CDbl(reader(4)) * 10)) / 10)
                        massimale = CDbl(reader(2))
                    Else

                        a = 0
                    End If


                End If

                reader.Close()

                If momento(i) = 0 Then
                    momento(i) = 1
                    i += 1
                Else
                    i += 1

                    If a <= massimale Then
                        connectionH.Open()
                        s1 = "insert into databaseHistory.storia (ID, valore, IDsensore) values (default,@v, @h);"
                        command1 = New MySqlCommand(s1, connectionH)
                        command1.Parameters.AddWithValue("@v", a)
                        command1.Parameters.AddWithValue("@h", i - 1)
                        command1.ExecuteNonQuery()
                        connectionH.Close()

                    Else
                        momento(i - 1) = 0
                    End If


                    Dim params(1) As MySqlParameter
                    params(0) = New MySqlParameter("_idSensore", MySqlDbType.Int32)
                    params(0).Value = i - 1

                    params(1) = New MySqlParameter("x", MySqlDbType.Double)
                    params(1).Value = a


                    Dim cmd As New MySqlCommand()
                    cmd.Connection = connection
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = V

                    cmd.Parameters.AddRange(params)
                    cmd.ExecuteNonQuery()

                End If


            End While
            'connection.Close()
            'connectionS.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Timer1.Interval = CInt(TimeSpan.FromSeconds(30).TotalMilliseconds)
        Me.Timer1.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Timer1.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Form1()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Open()
        connectionS.Open()
        aggiorna()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        aggiorna()
    End Sub

    Sub aggiorna()
        s = "select left(`IDspecifico`, 1) from databaseSensori.sensore where id = @id"
        s2 = "select count(id) from sensore"

        command2 = New MySqlCommand(s2, connectionS)
        reader = command2.ExecuteReader
        If reader.Read Then
            b = CInt(reader(0))
        End If

        reader.Close()

        ReDim momento(b)

        s2 = "select id, idspecifico, massimale, min_, max_,stato from sensore where id=@id;"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            s1 = "UPDATE sensore SET  state=@s where idspecifico=@id"
            command1 = New MySqlCommand(s1, connection)
            command1.Parameters.AddWithValue("@s", 0)
            command1.Parameters.AddWithValue("@id", TextBox1.Text)
            command1.ExecuteNonQuery()
            s1 = "UPDATE sensore SET  stato=@s where idspecifico=@id"
            command1 = New MySqlCommand(s1, connectionS)
            command1.Parameters.AddWithValue("@s", 0)
            command1.Parameters.AddWithValue("@id", TextBox1.Text)
            command1.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            s1 = "UPDATE sensore SET  min_=@min, max_=@max where idspecifico=@id"
            command1 = New MySqlCommand(s1, connectionS)
            command1.Parameters.AddWithValue("@min", CDbl(TextBox2.Text))
            command1.Parameters.AddWithValue("@max", CDbl(TextBox3.Text))
            command1.Parameters.AddWithValue("@id", TextBox1.Text)
            command1.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class

