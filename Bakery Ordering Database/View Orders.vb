Public Class View_Orders
    Private Sub MINI_PASTRY_ORDERSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MINI_PASTRY_ORDERSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MINI_PASTRY_ORDERSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bakery_OrdersDataSet)

    End Sub

    Private Sub View_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_OrdersDataSet.MINI_PASTRY_ORDERS' table. You can move, or remove it, as needed.
        Me.MINI_PASTRY_ORDERSTableAdapter.Fill(Me.Bakery_OrdersDataSet.MINI_PASTRY_ORDERS)

    End Sub

    Private Sub MINI_PASTRY_ORDERSDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MINI_PASTRY_ORDERSDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartPage.OrderingID = IDTextBox.Text
        Me.Hide()
        Report_2_form.Show()
    End Sub

    Private Sub SearchCustomer1ToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub Customer_NameToolStripTextBox_TextChanged(sender As Object, e As EventArgs) Handles Customer_NameToolStripTextBox.TextChanged
        Try
            Me.MINI_PASTRY_ORDERSTableAdapter.SearchCustomer1(Me.Bakery_OrdersDataSet.MINI_PASTRY_ORDERS, Customer_NameToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StartPage.OrderingID = IDTextBox.Text
        Me.Hide()
        Editing_Orders.Show()

    End Sub
End Class