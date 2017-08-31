Public Class Form2
    Private Sub MINI_PASTRY_ORDERSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MINI_PASTRY_ORDERSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bakery_OrdersDataSet)


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_OrdersDataSet.MINI_PASTRY_ORDERS' table. You can move, or remove it, as needed.
        Phone_NumberTextBox.Text = Form1.Phone_Number
        Customer_NameTextBox.Text = Form1.Customer_Name
        Holiday_NumberTextBox.Text = Form1.OrderID
        MINI_PASTRY_ORDERSTableAdapter.StartOrder(Customer_NameTextBox.Text, Phone_NumberTextBox.Text, Holiday_NumberTextBox.Text)
        Mini_Bars.Mini_Bar_Price = 0
        Mini_Pastries.Mini_Pastries_Price = 0
        Cookies.Cookie_Price = 0



    End Sub

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_PastriesCheckBox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cancel_OrderCheckBox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub IDTextBox_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Customer_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Customer_NameTextBox.TextChanged

    End Sub

    Private Sub Mini_BarsCheckBox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_CookiesCheckBox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IDLabel_Click(sender As Object, e As EventArgs)
        Me.TableAdapterManager.UpdateAll(Me.Bakery_OrdersDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MINI_PASTRY_ORDERSTableAdapter.Fill(Me.Bakery_OrdersDataSet.MINI_PASTRY_ORDERS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.MINI_PASTRY_ORDERSTableAdapter.Fill(Me.Bakery_OrdersDataSet.MINI_PASTRY_ORDERS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MINI_PASTRY_ORDERSTableAdapter.UpdateOrders(Order_Taken_ByTextBox.Text, Customer_NameTextBox.Text, Phone_NumberTextBox.Text, Holiday_NumberTextBox.Text, Order_DateDateTimePicker.Text,
                                                    Platter_or_BoxComboBox.Text, Order_DescriptionTextBox.Text, Order_MessageTextBox.Text, Item_1TextBox.Text, Item_2TextBox.Text, Item_3TextBox.Text,
                                                    Item_4TextBox.Text, Item_5TextBox.Text, Item_Price_1TextBox.Text, Item_Price_2TextBox.Text, Item_Price_3TextBox.Text, Item_Price_4TextBox.Text,
                                                    Item_Price_5TextBox.Text, Order_SummaryTextBox.Text, Grand_TotalTextBox.Text, Order_BalanceTextBox.Text, Order_StatusComboBox.Text, Order_DepositTextBox.Text, IDTextBox.Text,
                                                    IDTextBox.Text)
        Me.Hide()
        Form3.Show()



    End Sub
    Public OrderingID As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OrderingID = IDTextBox.Text
        Mini_Pastries.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OrderingID = IDTextBox.Text
        Mini_Bars.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OrderingID = IDTextBox.Text
        Cookies.Show()
    End Sub

    Private Sub Order_Taken_ByTextBox_TextChanged(sender As Object, e As EventArgs) Handles Order_Taken_ByTextBox.TextChanged

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.MINI_PASTRY_ORDERSTableAdapter.FillBy(Me.Bakery_OrdersDataSet.MINI_PASTRY_ORDERS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        FillByToolStripButton.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        IDTextBox.Visible = True
        Order_Taken_ByTextBox.Visible = True
        Holiday_NumberTextBox.Visible = True
        Customer_NameTextBox.Visible = True
        Phone_NumberTextBox.Visible = True
        Order_DateDateTimePicker.Visible = True
        Platter_or_BoxComboBox.Visible = True
        Order_DescriptionTextBox.Visible = True
        Order_MessageTextBox.Visible = True
        Item_1TextBox.Visible = True
        Item_2TextBox.Visible = True
        Item_3TextBox.Visible = True
        Item_4TextBox.Visible = True
        Item_5TextBox.Visible = True
        Item_Price_1TextBox.Visible = True
        Item_Price_2TextBox.Visible = True
        Item_Price_3TextBox.Visible = True
        Item_Price_4TextBox.Visible = True
        Item_Price_5TextBox.Visible = True
        Order_SummaryTextBox.Visible = True
        Button6.Visible = True
        Grand_TotalTextBox.Visible = True
        Order_BalanceTextBox.Text = True
        Order_DepositTextBox.Visible = True
        Order_StatusComboBox.Visible = True
        Button1.Visible = True
        Button5.Visible = True





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MINI_PASTRY_ORDERSTableAdapter.DeleteOrder(IDTextBox.Text)
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Item_Price_1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_Price_1TextBox.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Grand_TotalTextBox.Visible = True
        Order_DepositTextBox.Visible = True
        Order_BalanceTextBox.Visible = True
        Order_StatusComboBox.Visible = True
        Button1.Visible = True
        Button5.Visible = True
        Grand_TotalTextBox.Text = Decimal.Parse(Item_Price_1TextBox.Text) + Decimal.Parse(Item_Price_2TextBox.Text) + Decimal.Parse(Item_Price_3TextBox.Text) + Decimal.Parse(Item_Price_4TextBox.Text) + Decimal.Parse(Item_Price_5TextBox.Text) + Mini_Bars.Mini_Bar_Price + Mini_Pastries.Mini_Pastries_Price + Cookies.Cookie_Price


    End Sub

    Private Sub Order_DepositTextBox_TextChanged(sender As Object, e As EventArgs) Handles Order_DepositTextBox.TextChanged
        Grand_TotalTextBox.Text = Decimal.Parse(Item_Price_1TextBox.Text) + Decimal.Parse(Item_Price_2TextBox.Text) + Decimal.Parse(Item_Price_3TextBox.Text) + Decimal.Parse(Item_Price_4TextBox.Text) + Decimal.Parse(Item_Price_5TextBox.Text) + Mini_Bars.Mini_Bar_Price + Mini_Pastries.Mini_Pastries_Price + Cookies.Cookie_Price

    End Sub

    Private Sub Order_DepositTextBox_Leave(sender As Object, e As EventArgs) Handles Order_DepositTextBox.Leave
        Order_BalanceTextBox.Text = Decimal.Parse(Grand_TotalTextBox.Text) - Decimal.Parse(Order_DepositTextBox.Text)
    End Sub

    Private Sub IDTextBox_TextChanged_2(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged

    End Sub
End Class