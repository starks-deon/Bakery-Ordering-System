Public Class StartPage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        View_Orders.Show()
        Me.Hide()

    End Sub
    Public OrderingID As String
End Class