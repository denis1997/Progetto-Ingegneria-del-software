﻿
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.Show()
        Form2.BringToFront()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Form3.BringToFront()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
        Form4.BringToFront()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form11.Show()

    End Sub
End Class
