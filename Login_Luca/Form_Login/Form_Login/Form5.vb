Public Class Form5

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form1.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form12.Show()
        Form12.BringToFront()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form13.Show()
        Form13.BringToFront()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form14.Show()
        Form14.BringToFront()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form15.Show()
        Form15.BringToFront()
    End Sub

End Class