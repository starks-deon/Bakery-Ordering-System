Public Class Report_2_form
    Private Sub Report_2_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_OrdersDataSet.MINI_PASTRY_ORDERS' table. You can move, or remove it, as needed.
        Me.ReportViewer1.RefreshReport()
        MINI_PASTRY_ORDERSTableAdapter.FillReport(Me.Bakery_OrdersDataSet.MINI_PASTRY_ORDERS, StartPage.OrderingID)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        Editing_Orders.Show()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class