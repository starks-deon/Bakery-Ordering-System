Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_OrdersDataSet.MINI_PASTRY_ORDERS' table. You can move, or remove it, as needed.
        MINI_PASTRY_ORDERSTableAdapter.FillReport(Bakery_OrdersDataSet.MINI_PASTRY_ORDERS, Edit_Orders.IDTextBox.Text)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs) Handles ReportViewer1.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class