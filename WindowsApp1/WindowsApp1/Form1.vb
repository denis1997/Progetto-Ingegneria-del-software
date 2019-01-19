Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=andrea98;database=databasesensori;SslMode=none;")
    Dim command1 As MySqlCommand
    Dim command2 As MySqlCommand
    Dim command3 As MySqlCommand
    Dim reader As MySqlDataReader
    Dim s1 As String
    Dim s2 As String
    Dim s3 As String


    Dim i1 As Integer = 0
    Dim i2 As Integer = 0

    Dim arrayEnd() As Integer
    Dim MyButton()() As Button
    Dim mymenu()() As MenuStrip

    Dim o1 As Date
    Dim o2 As Date

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s1 = "select p.nome, p.idposizione from edificio e join piano p where e.id=p.idedificio and  e.id = @id"
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
            ReDim mymenu(i1)

            For i As Integer = 1 To i1
                s2 = "select a.nome, a.idposizione from piano p join areapiano a where p.id=a.idpiano and  p.id = @id"
                command2 = New MySqlCommand(s2, connection)

                command2.Parameters.Add("@id", MySqlDbType.Int32).Value = i
                reader = command2.ExecuteReader

                While reader.Read()
                    i2 += 1
                End While
                reader.Close()

                MyButton(i) = New Button(i2) {}
                mymenu(i) = New MenuStrip(i2) {}


                reader = command1.ExecuteReader
                Dim x As Integer = 1
                While reader.Read()
                    If x = i Then

                        MyButton(reader(1))(0) = New Button
                        With MyButton(reader(1))(0)
                            .Name = reader(1).ToString
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
                        Me.Controls.Add(MyButton(reader(1))(0))
                    End If
                    x += 1
                End While
                reader.Close()

                Dim a As Integer = 0
                Dim b As Integer = 0
                Dim w As Integer = 1

                reader = command2.ExecuteReader
                While reader.Read
                    MyButton(i)(w) = New Button
                    If (w - 1) = (a * 3) Then
                        a += 1
                        b = 0
                    End If
                    With MyButton(i)(w)
                        .Name = reader(1).ToString
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

                        mymenu(i)(w) = New MenuStrip

                        With mymenu(i)(w)

                            .Name = i.ToString
                            .Text = i.ToString

                            .Anchor = System.Windows.Forms.AnchorStyles.None
                            .Dock = System.Windows.Forms.DockStyle.None
                            .Visible = False
                            .LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
                            .BackColor = Color.Transparent

                        End With

                        Me.Controls.Add(mymenu(i)(w))

                    End With
                    Me.Controls.Add(MyButton(i)(w))
                    b += 1
                    w += 1


                End While

                arrayEnd(i) = w

                reader.Close()

                i2 = 0
            Next

            connection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Timer1.Interval = CInt(TimeSpan.FromSeconds(10).TotalMilliseconds)
        Me.Timer1.Start()


    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        s3 = "select s.idspecifico, s.valore, s.oraultimoinvio, s.orainvioprecedente, s.idareapiano, a.idpiano, a.idposizione, p.idposizione from piano p join areapiano a join sensore s where a.id=s.idareapiano and p.id=a.idpiano and p.idedificio=@id;"

        command3 = New MySqlCommand(s3, connection)

        command3.Parameters.Add("@id", MySqlDbType.Int32).Value = 1

        For z As Integer = 1 To i1
            For z1 As Integer = 1 To arrayEnd(z) - 1
                mymenu(z)(z1).Items.Clear()
            Next

        Next
        Try
            connection.Open()

            reader = command3.ExecuteReader
            For z As Integer = 1 To i1
                For z1 As Integer = 0 To arrayEnd(z) - 1
                    MyButton(z)(z1).BackColor = Color.Green
                Next

            Next
            Dim g As Integer = 0
            While reader.Read

                o1 = reader(2)
                o2 = reader(3)
                Dim c As Long = DateDiff(DateInterval.Second, o2, o1)


                If Math.Abs(c) < 20 Then
                    MyButton(reader(7))(0).BackColor = Color.Yellow
                    MyButton(reader(7))(reader(6)).BackColor = Color.Yellow

                    mymenu(reader(7))(reader(6)).Items.Add(reader(0).ToString + "       " + reader(1).ToString).BackColor = Color.Yellow
                Else
                    mymenu(reader(7))(reader(6)).Items.Add(reader(0).ToString + "       " + reader(1).ToString).BackColor = Color.Green
                End If
                mymenu(reader(7))(reader(6)).BringToFront()



            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Dim myname As Integer

    Sub myvisible(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myname = CInt(sender.name)

        For z As Integer = 1 To i1
            For z1 As Integer = 1 To arrayEnd(z) - 1
                MyButton(z)(z1).Visible = False
                mymenu(z)(z1).Visible = False
            Next

        Next

        For z As Integer = 1 To arrayEnd(myName) - 1
            MyButton(myName)(z).Visible = True
        Next

    End Sub


    Sub mymessage(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For z As Integer = 1 To i1
            For z1 As Integer = 1 To arrayEnd(z) - 1
                mymenu(z)(z1).Visible = False
            Next

        Next

        mymenu(myname)(CInt(sender.name)).Visible = True
        mymenu(myname)(CInt(sender.name)).Location = New System.Drawing.Point(sender.left, sender.top + sender.height)
    End Sub

End Class
