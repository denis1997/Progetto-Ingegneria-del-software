Imports System.IO
Imports MySql.Data.MySqlClient


Public Class Form1
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=andrea98;database=databasesensori;SslMode=none;")
    Dim command1 As MySqlCommand
    Dim command2 As MySqlCommand
    Dim reader As MySqlDataReader
    Dim s1 As String
    Dim s2 As String
    Dim i1 As Integer = 0
    Dim i2 As Integer = 0
    Dim arrayEnd() As Integer
    Dim MyButton(i1)() As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s1 = "select p.nome from edificio e join piano p where e.id=p.idedificio and  e.id = @id"
        command1 = New MySqlCommand(s1, connection)

        command1.Parameters.Add("@id", MySqlDbType.Int32).Value = 1
        Try
            connection.Open()

            reader = command1.ExecuteReader

            While reader.Read()
                i1 += 1
            End While

            reader.Close()
            ReDim arrayEnd(i1)
            ReDim MyButton(i1)

            For i As Integer = 1 To i1
                s2 = "select a.nome from piano p join areapiano a where p.id=a.idpiano and  p.id = @id"
                command2 = New MySqlCommand(s2, connection)

                command2.Parameters.Add("@id", MySqlDbType.Int32).Value = i
                reader = command2.ExecuteReader

                While reader.Read()
                    i2 += 1
                End While
                reader.Close()

                MyButton(i) = New Button(i2 + 1) {}

                reader = command1.ExecuteReader
                Dim x As Integer = 1
                While reader.Read()
                    If x = i Then
                        MyButton(i)(1) = New Button
                        With MyButton(i)(1)
                            .Name = i.ToString
                            .Text = reader.GetString("nome")
                            .Visible = True
                            .Top = 20 + (100 * i)
                            .Width = 180
                            .Height = 60
                            .TextAlign = ContentAlignment.MiddleCenter
                            .Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
                            .BackColor = Color.Green
                            AddHandler .Click, AddressOf myvisible
                        End With
                        Me.Controls.Add(MyButton(i)(1))
                    End If
                    x += 1
                End While
                reader.Close()


                Dim a As Integer = 0
                Dim b As Integer = 0
                Dim w As Integer = 2

                reader = command2.ExecuteReader
                While reader.Read
                    MyButton(i)(w) = New Button
                    If (w - 2) = (a * 3) Then
                        a += 1
                        b = 0
                    End If
                    With MyButton(i)(w)
                        .Name = w.ToString
                        .Text = reader.GetString("nome")
                        .Visible = False
                        .Top = 200 + (100 * a)
                        .Left = 200 + (200 * b)
                        .Width = 180
                        .Height = 60
                        .TextAlign = ContentAlignment.MiddleCenter
                        .Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
                        .BackColor = Color.Green
                        AddHandler .Click, AddressOf mymessage
                    End With
                    Me.Controls.Add(MyButton(i)(w))
                    b += 1
                    w += 1
                End While

                arrayEnd(i) = w

                reader.Close()

            Next
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub mymessage(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myName As String = sender.name
        MessageBox.Show(myName)
    End Sub
    Sub myvisible(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myName As Integer = CInt(sender.name)

        For z As Integer = 1 To i1
            For z1 As Integer = 2 To arrayEnd(z) - 1
                MyButton(z)(z1).Visible = False
            Next

        Next
        For z As Integer = 2 To arrayEnd(myName) - 1
            MyButton(myName)(z).Visible = True
        Next

    End Sub
End Class
