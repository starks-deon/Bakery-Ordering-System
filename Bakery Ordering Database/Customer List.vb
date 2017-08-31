Public Class Form1
    Private Sub Customer_ListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customer_ListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customer_ListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bakery_OrdersDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_OrdersDataSet.Customer_List' table. You can move, or remove it, as needed.
        Me.Customer_ListTableAdapter.Fill(Me.Bakery_OrdersDataSet.Customer_List)


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Customer_ListTableAdapter.Fill(Me.Bakery_OrdersDataSet.Customer_List)
    End Sub
    Public Customer_Name As String
    Public Phone_Number As String
    Public OrderID As String

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Customer_ListTableAdapter.FillBy(Me.Bakery_OrdersDataSet.Customer_List)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Customer_NameToolStripTextBox_TextChanged(sender As Object, e As EventArgs) Handles Customer_NameToolStripTextBox.TextChanged
        Try
            Me.Customer_ListTableAdapter.Customer_Name(Me.Bakery_OrdersDataSet.Customer_List, Customer_NameToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Customer_Name = Customer_NameTextBox.Text
        Phone_Number = Phone_NumberTextBox.Text
        OrderID = IDTextBox.Text
        Me.Hide()
        Edit_Orders.Show()
    End Sub

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged

    End Sub
End Class
