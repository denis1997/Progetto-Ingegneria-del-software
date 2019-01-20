

Imports System.IO
Imports MySql.Data.MySqlClient



Public Class Formzona

    Public zona As New Integer
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=andrea98;database=databasesensori;SslMode=none;")
    Dim command1 As MySqlCommand
    Dim command2 As MySqlCommand
    Dim reader As MySqlDataReader
    Dim s1 As String
    Dim s2 As String


    Dim position(4) As Integer
    Dim arrayEnd(4) As Integer
    Dim myButtonAA(4)() As Button
    Dim mymenuAA(4)() As MenuStrip


    Dim i1 As Integer = 0
    Dim i3 As Integer = 0
    Dim i4 As Integer = 0
    Dim i5 As Integer = 0

    Dim o1 As Date
    Dim o2 As Date

    Dim myButtonE()()() As Button
    Dim arrayEndE()() As Integer
    Dim arrayEndE1() As Integer
    Dim mymenuE()()() As MenuStrip

    Dim command3 As MySqlCommand
    Dim command4 As MySqlCommand
    Dim command5 As MySqlCommand
    Dim command6 As MySqlCommand
    Dim s3 As String
    Dim s4 As String
    Dim s5 As String
    Dim s6 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        zona = Form1.abab
        generateAA()

        s3 = "select e.nome, e.idposizione from edificio e where e.idzona = @id"
        command3 = New MySqlCommand(s3, connection)

        command3.Parameters.Add("@id", MySqlDbType.Int32).Value = zona


        connection.Open()

        reader = command3.ExecuteReader
        While reader.Read()
            i3 += 1
        End While

        reader.Close()
        ReDim arrayEndE(i3)
        ReDim myButtonE(i3)
        ReDim mymenuE(i3)
        ReDim arrayEndE1(i3)

        For i As Integer = 1 To i3
            s4 = "select p.nome, p.idposizione from piano p where p.idedificio= @id"

            command4 = New MySqlCommand(s4, connection)

            command4.Parameters.Add("@id", MySqlDbType.Int32).Value = i
            reader = command4.ExecuteReader

            While reader.Read()
                i4 += 1
            End While
            reader.Close()

            myButtonE(i) = New Button(i4)() {}
            mymenuE(i) = New MenuStrip(i4)() {}

            arrayEndE(i) = New Integer(i4) {}

            myButtonE(i)(0) = New Button(0) {}
            mymenuE(i)(0) = New MenuStrip(0) {}

            myButtonE(i)(0) = New Button(0) {}
            Dim x As Integer = 1
            reader = command3.ExecuteReader

            While reader.Read

                If x = i Then

                    myButtonE(reader(1))(0)(0) = New Button

                    With myButtonE(reader(1))(0)(0)
                        .Name = reader(1).ToString
                        .Text = reader.GetString("nome")
                        .Visible = False
                        .Top = 50 + (50 * i)
                        .Left = 200
                        .Width = 100
                        .Height = 40
                        .TextAlign = ContentAlignment.MiddleCenter
                        .Font = New Font("Microsoft Sans Serif", 10)
                        .BackColor = Color.Green
                        AddHandler .Click, AddressOf myvisible1

                    End With
                    Me.Controls.Add(myButtonE(reader(1))(0)(0))

                End If
                x += 1

            End While
            reader.Close()

            For j As Integer = 1 To i4
                s5 = "select a.nome, a.idposizione from areapiano a join piano p where p.id=a.idpiano and a.idpiano = @id and p.idedificio=@id1"

                command5 = New MySqlCommand(s5, connection)
                command5.Parameters.Add("@id", MySqlDbType.Int32).Value = j
                command5.Parameters.Add("@id1", MySqlDbType.Int32).Value = i
                reader = command5.ExecuteReader
                While reader.Read()
                    i5 += 1
                End While
                reader.Close()

                myButtonE(i)(j) = New Button(i5) {}
                mymenuE(i)(j) = New MenuStrip(i5) {}



                Dim y As Integer = 1
                reader = command4.ExecuteReader
                While reader.Read
                    If y = j Then
                        myButtonE(i)(reader(1))(0) = New Button
                        With myButtonE(i)(reader(1))(0)
                            .Name = reader(1).ToString
                            .Text = reader.GetString("nome")
                            .Visible = False
                            .Top = 50 + (50 * j)
                            .Left = 310
                            .Width = 100
                            .Height = 40
                            .TextAlign = ContentAlignment.MiddleCenter
                            .Font = New Font("Microsoft Sans Serif", 10)
                            .BackColor = Color.Green
                            AddHandler .Click, AddressOf myvisible2
                        End With
                        Me.Controls.Add(myButtonE(i)(reader(1))(0))
                    End If
                    y += 1
                End While
                reader.Close()

                Dim a As Integer = 0
                Dim b As Integer = 0
                Dim w As Integer = 1

                reader = command5.ExecuteReader
                While reader.Read
                    myButtonE(i)(j)(w) = New Button
                    If (w - 1) = (a * 3) Then
                        a += 1
                        b = 0
                    End If
                    With myButtonE(i)(j)(w)
                        .Name = reader(1).ToString
                        .Text = reader.GetString("nome")
                        .Visible = False
                        .Top = 70 + (50 * a)
                        .Left = 460 + (120 * b)
                        .Width = 100
                        .Height = 40
                        .TextAlign = ContentAlignment.MiddleCenter
                        .Font = New Font("Microsoft Sans Serif", 10)
                        .BackColor = Color.Green
                        AddHandler .Click, AddressOf myvisible3


                        mymenuE(i)(j)(w) = New MenuStrip

                        With mymenuE(i)(j)(w)

                            .Name = i.ToString
                            .Text = i.ToString

                            .Anchor = System.Windows.Forms.AnchorStyles.None
                            .Dock = System.Windows.Forms.DockStyle.None
                            .Visible = False
                            .LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
                            .BackColor = Color.Transparent

                        End With

                        Me.Controls.Add(mymenuE(i)(j)(w))

                    End With
                    Me.Controls.Add(myButtonE(i)(j)(w))
                    b += 1
                    w += 1


                End While

                arrayEndE(i)(j) = w

                reader.Close()

                i5 = 0

            Next
            arrayEndE1(i) = i4
            i4 = 0

        Next
        connection.Close()
        Me.Timer1.Interval = CInt(TimeSpan.FromSeconds(10).TotalMilliseconds)
        Me.Timer1.Start()

    End Sub

    Dim indice As New Integer

    Sub mymessage(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For z As Integer = 1 To i1
            For z1 As Integer = 1 To arrayEnd(z)
                mymenuAA(z)(z1).Visible = False
            Next
        Next

        mymenuAA(indice)(CInt(sender.name)).Visible = True
        mymenuAA(indice)(CInt(sender.name)).Location = New System.Drawing.Point(sender.left, sender.top + sender.height)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True

        For z As Integer = 1 To 4

            For z1 As Integer = 1 To arrayEnd(z)

                myButtonAA(z)(z1).Visible = False
            Next
        Next

        For z As Integer = 1 To 4
            For z1 As Integer = 1 To arrayEnd(z)
                mymenuAA(z)(z1).Visible = False
            Next

        Next
        For z As Integer = 1 To i3
            myButtonE(z)(0)(0).Visible = False
            For z1 As Integer = 1 To arrayEndE1(z)
                For z2 As Integer = 0 To arrayEndE(z)(z1) - 1

                    myButtonE(z)(z1)(z2).Visible = False
                Next
            Next

        Next
        For z As Integer = 1 To i3
            For z1 As Integer = 1 To arrayEndE1(z)
                For z2 As Integer = 1 To arrayEndE(z)(z1) - 1

                    mymenuE(z)(z1)(z2).Visible = False
                Next
            Next

        Next

        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20)
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20, System.Drawing.FontStyle.Bold)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        For z As Integer = 1 To 4
            For z1 As Integer = 1 To arrayEnd(z)
                myButtonAA(z)(z1).Visible = False
            Next
        Next

        For z As Integer = 1 To 4
            For z1 As Integer = 1 To arrayEnd(z)
                mymenuAA(z)(z1).Visible = False
            Next

        Next

        For z As Integer = 1 To i3
            For z1 As Integer = 1 To arrayEndE1(z)
                For z2 As Integer = 0 To arrayEndE(z)(z1) - 1

                    myButtonE(z)(z1)(z2).Visible = False
                Next
            Next

        Next

        For z As Integer = 1 To i3
            For z1 As Integer = 1 To arrayEndE1(z)
                For z2 As Integer = 1 To arrayEndE(z)(z1) - 1

                    mymenuE(z)(z1)(z2).Visible = False
                Next
            Next

        Next

        For z As Integer = 1 To i3
            myButtonE(z)(0)(0).Visible = True
        Next

        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20)
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20, System.Drawing.FontStyle.Bold)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        indice = 1
        Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold)
        buttondisplay()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        indice = 2
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold)
        buttondisplay()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        indice = 3
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold)
        buttondisplay()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        indice = 4
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
        Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold)
        buttondisplay()
    End Sub

    Sub buttondisplay()

        For z As Integer = 1 To 4
            For z1 As Integer = 1 To arrayEnd(z)
                mymenuAA(z)(z1).Visible = False
            Next

        Next

        For z As Integer = 1 To 4
            For z1 As Integer = 1 To arrayEnd(z)
                myButtonAA(z)(z1).Visible = False
            Next
        Next


        For z As Integer = 1 To arrayEnd(indice)
            myButtonAA(indice)(z).Visible = True
        Next

    End Sub


    Sub generateAA()
        s1 = "select a.nome, s.id, a.id, a.idposizione  from areaaperto a join sottocategorie s where a.idzona = @id and a.idsottocategorie=s.id"
        command1 = New MySqlCommand(s1, connection)

        command1.Parameters.Add("@id", MySqlDbType.Int32).Value = zona

        Try
            connection.Open()

            reader = command1.ExecuteReader

            While reader.Read()
                arrayEnd(reader(1)) += 1
            End While


            reader.Close()

            myButtonAA(1) = New Button(arrayEnd(1)) {}
            myButtonAA(2) = New Button(arrayEnd(2)) {}
            myButtonAA(3) = New Button(arrayEnd(3)) {}
            myButtonAA(4) = New Button(arrayEnd(4)) {}

            mymenuAA(1) = New MenuStrip(arrayEnd(1)) {}
            mymenuAA(2) = New MenuStrip(arrayEnd(2)) {}
            mymenuAA(3) = New MenuStrip(arrayEnd(3)) {}
            mymenuAA(4) = New MenuStrip(arrayEnd(4)) {}

            Dim a(4) As Integer
            Dim b(4) As Integer

            reader = command1.ExecuteReader
            While reader.Read

                position(reader(1)) += 1
                If (position(reader(1)) - 1) = (a(reader(1)) * 3) Then
                    a(reader(1)) += 1
                    b(reader(1)) = 0
                End If

                myButtonAA(reader(1))(position(reader(1))) = New Button
                With myButtonAA(reader(1))(position(reader(1)))
                    .Name = position(reader(1)).ToString
                    .Text = reader.GetString("nome")
                    .Visible = False
                    .Top = 50 + (50 * a(reader(1)))
                    .Left = 400 + (120 * b(reader(1)))
                    .Width = 100
                    .Height = 40
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Font = New Font("Microsoft Sans Serif", 10)
                    .BackColor = Color.Green
                    AddHandler .Click, AddressOf mymessage

                    mymenuAA(reader(1))(position(reader(1))) = New MenuStrip

                    With mymenuAA(reader(1))(position(reader(1)))

                        .Name = position(reader(1)).ToString
                        .Text = reader(1).ToString

                        .Anchor = System.Windows.Forms.AnchorStyles.None
                        .Dock = System.Windows.Forms.DockStyle.None
                        .Visible = False
                        .LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
                        .BackColor = Color.Transparent

                    End With

                    Me.Controls.Add(mymenuAA(reader(1))(position(reader(1))))

                End With
                Me.Controls.Add(myButtonAA(reader(1))(position(reader(1))))

                b(reader(1)) += 1

            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        s2 = "select s.idspecifico, s.valore, s.oraultimoinvio, s.orainvioprecedente, s.idareaaperto, a.idposizione, st.id from areaaperto a join sensore s join sottocategorie st where a.id=s.idareaaperto and a.idsottocategorie=st.id and a.idzona=@id;"

        command2 = New MySqlCommand(s2, connection)

        command2.Parameters.Add("@id", MySqlDbType.Int32).Value = zona

        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Green
        Button5.BackColor = Color.Green
        Button6.BackColor = Color.Green


        For z As Integer = 1 To 4
            For z1 As Integer = 1 To arrayEnd(z)
                mymenuAA(z)(z1).Items.Clear()
            Next

        Next
        For i As Integer = 1 To 4
            position(i) = 1
        Next

        connection.Open()

        reader = command2.ExecuteReader
        For z As Integer = 1 To 4
            For z1 As Integer = 1 To arrayEnd(z)
                myButtonAA(z)(z1).BackColor = Color.Green
            Next

        Next

        While reader.Read

            o1 = reader(2)
            o2 = reader(3)
            Dim c As Long = DateDiff(DateInterval.Second, o2, o1)


            If Math.Abs(c) < 20 Then

                Button2.BackColor = Color.Yellow

                Select Case reader(6)
                    Case 1
                        Button3.BackColor = Color.Yellow
                    Case 2
                        Button4.BackColor = Color.Yellow
                    Case 3
                        Button5.BackColor = Color.Yellow
                    Case 4
                        Button6.BackColor = Color.Yellow
                End Select

                myButtonAA(reader(6))(position(reader(6))).BackColor = Color.Yellow

                mymenuAA(reader(6))(position(reader(6))).Items.Add(reader(0).ToString + "       " + reader(1).ToString).BackColor = Color.Yellow
            Else
                mymenuAA(reader(6))(position(reader(6))).Items.Add(reader(0).ToString + "       " + reader(1).ToString).BackColor = Color.Green
            End If
            mymenuAA(reader(6))(position(reader(6))).BringToFront()

        End While
        connection.Close()




        s6 = "select s.idspecifico, s.valore, s.oraultimoinvio, s.orainvioprecedente, a.idposizione, p.idposizione, e.idposizione from sensore s join areapiano a join piano p join edificio e where s.idareapiano=a.id and a.idpiano=p.id and p.idedificio=e.id and e.idzona= @id"

        command6 = New MySqlCommand(s6, connection)

        command6.Parameters.Add("@id", MySqlDbType.Int32).Value = zona

        For z As Integer = 1 To i3
            For z1 As Integer = 1 To arrayEndE1(z)
                For z2 As Integer = 1 To arrayEndE(z)(z1) - 1

                    mymenuE(z)(z1)(z2).Items.Clear()
                Next
            Next

        Next

        For z1 As Integer = 1 To arrayEndE1(myname1)
            For z2 As Integer = 1 To arrayEndE(myname1)(z1) - 1

                myButtonE(myname1)(z1)(z2).BackColor = Color.Green
            Next
        Next

        connection.Open()

        reader = command6.ExecuteReader

        While reader.Read

            o1 = reader(2)
            o2 = reader(3)
            Dim c As Long = DateDiff(DateInterval.Second, o2, o1)
            If Math.Abs(c) < 20 Then
                Button1.BackColor = Color.Yellow
                myButtonE(reader(6))(0)(0).BackColor = Color.Yellow
                myButtonE(reader(6))(reader(5))(0).BackColor = Color.Yellow
                myButtonE(reader(6))(reader(5))(reader(4)).BackColor = Color.Yellow

                mymenuE(reader(6))(reader(5))(reader(4)).Items.Add(reader(0).ToString + "       " + reader(1).ToString).BackColor = Color.Yellow
            Else
                mymenuE(reader(6))(reader(5))(reader(4)).Items.Add(reader(0).ToString + "       " + reader(1).ToString).BackColor = Color.Green
            End If
            mymenuE(reader(6))(reader(5))(reader(4)).BringToFront()

        End While
        connection.Close()
    End Sub

    Dim myname1 As New Integer
    Dim myname2 As New Integer

    Sub myvisible1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        myname1 = CInt(sender.name)

        For z As Integer = 1 To i3

            myButtonE(z)(0)(0).Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
            For z1 As Integer = 1 To arrayEndE1(z)
                For z2 As Integer = 0 To arrayEndE(z)(z1) - 1

                    myButtonE(z)(z1)(z2).Visible = False
                Next
            Next

        Next
        For z As Integer = 1 To i3
            For z1 As Integer = 1 To arrayEndE1(z)
                For z2 As Integer = 1 To arrayEndE(z)(z1) - 1

                    mymenuE(z)(z1)(z2).Visible = False
                Next
            Next

        Next

        For z As Integer = 1 To arrayEndE1(myname1)
            myButtonE(myname1)(z)(0).Visible = True
        Next
        sender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold)
    End Sub
    Sub myvisible2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myname2 = CInt(sender.name)

        For z1 As Integer = 1 To arrayEndE1(myname1)
            myButtonE(myname1)(z1)(0).Font = New System.Drawing.Font("Microsoft Sans Serif", 10)
            For z2 As Integer = 1 To arrayEndE(myname1)(z1) - 1

                myButtonE(myname1)(z1)(z2).Visible = False
            Next
        Next
        For z As Integer = 1 To i3
            For z1 As Integer = 1 To arrayEndE1(z)
                For z2 As Integer = 1 To arrayEndE(z)(z1) - 1

                    mymenuE(z)(z1)(z2).Visible = False
                Next
            Next

        Next

        For z As Integer = 1 To arrayEndE(myname1)(myname2) - 1
            myButtonE(myname1)(myname2)(z).Visible = True
        Next
        sender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold)
    End Sub
    Sub myvisible3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For z As Integer = 1 To i3
            For z1 As Integer = 1 To arrayEndE1(z)
                For z2 As Integer = 1 To arrayEndE(z)(z1) - 1

                    mymenuE(z)(z1)(z2).Visible = False
                Next
            Next

        Next

        mymenuE(myname1)(myname2)(CInt(sender.name)).Visible = True
        mymenuE(myname1)(myname2)(CInt(sender.name)).Location = New System.Drawing.Point(sender.left, sender.top + sender.height)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form9.Show()
        Form9.BringToFront()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form10.Show()
        Form10.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form11.Show()
        Form11.BringToFront()
    End Sub
End Class
