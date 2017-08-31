Public Class Editing_Orders
    Private Sub MINI_PASTRY_ORDERSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MINI_PASTRY_ORDERSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bakery_OrdersDataSet)

    End Sub

    Private Sub Edit_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_OrdersDataSet.MINI_PASTRY_ORDERS' table. You can move, or remove it, as needed.
        MINI_PASTRY_ORDERSTableAdapter.FillEditingForm(Bakery_OrdersDataSet.MINI_PASTRY_ORDERS, StartPage.OrderingID)
    End Sub


    Private Sub Customer_NameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Phone_NumberLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Cannoli_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Eclair_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Cream_Puff_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Key_Lime_Tart_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Fruit_Tart_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Lemon_Curd_Tart_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Assorted_Cheesecake_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pecan_Truffle_Tart_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Ganache_Tart_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Chocolate_Mousse_Cups_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Assorted_Mini_Pastry_Package_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mousse_FlavorLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Pastry_Total_PriceLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Bars_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Bar_Total_PriceLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cookie_DozenLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cookie_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Platter_or_BoxLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Order_DescriptionLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Order_MessageLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_1Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_2Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_3Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_4Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_5Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_Price_1Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_Price_2Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_Price_3Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_Price_4Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Item_Price_5Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Order_SummaryLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Grand_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Order_DepositLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Order_BalanceLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cancel_OrderLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Chocolate_Chip_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Sugar_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Double_Chocolate_Chip_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Oatmeal_Raisin_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Lemon_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pecan_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Triple_Berry_Bar_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tiger_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Magic_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Classic_Brownie_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Truffle_Brownie_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub German_Brownie_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Apple_Crisp_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Date_Bar_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cranberry_Magic_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pumpkin_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Bar_Package_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Order_StatusLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MINI_PASTRY_ORDERSBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MINI_PASTRY_ORDERSBindingSource.CurrentChanged

    End Sub

    Private Sub Mini_Cannoli_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Cannoli_TotalTextBox.TextChanged

    End Sub

    Private Sub Mini_Eclair_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Eclair_TotalTextBox.TextChanged

    End Sub

    Private Sub Mini_Cream_Puff_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Cream_Puff_TotalTextBox.TextChanged

    End Sub

    Private Sub Mini_Key_Lime_Tart_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Key_Lime_Tart_TotalTextBox.TextChanged

    End Sub

    Private Sub Mini_Fruit_Tart_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Fruit_Tart_TotalTextBox.TextChanged

    End Sub

    Private Sub Mini_Lemon_Curd_Tart_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Lemon_Curd_Tart_TotalTextBox.TextChanged

    End Sub

    Private Sub Assorted_Cheesecake_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Assorted_Cheesecake_TotalTextBox.TextChanged

    End Sub

    Private Sub Pecan_Truffle_Tart_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Pecan_Truffle_Tart_TotalTextBox.TextChanged

    End Sub

    Private Sub Ganache_Tart_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Ganache_Tart_TotalTextBox.TextChanged

    End Sub

    Private Sub Mini_Chocolate_Mousse_Cups_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Chocolate_Mousse_Cups_TotalTextBox.TextChanged

    End Sub

    Private Sub Assorted_Mini_Pastry_Package_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Assorted_Mini_Pastry_Package_TotalTextBox.TextChanged, Mini_Pastry_Total_PriceTextBox.TextChanged

    End Sub

    Private Sub Mousse_FlavorTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Pastry_Total_PriceTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Bars_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Bars_TotalTextBox.TextChanged

    End Sub

    Private Sub Mini_Bar_Total_PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Bar_Total_PriceTextBox.TextChanged

    End Sub

    Private Sub Cookie_DozenTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cookie_DozenTextBox.TextChanged

    End Sub

    Private Sub Cookie_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cookie_TotalTextBox.TextChanged

    End Sub

    Private Sub Platter_or_BoxComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Platter_or_BoxComboBox.SelectedIndexChanged

    End Sub

    Private Sub Order_DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles Order_DescriptionTextBox.TextChanged

    End Sub

    Private Sub Order_MessageTextBox_TextChanged(sender As Object, e As EventArgs) Handles Order_MessageTextBox.TextChanged

    End Sub

    Private Sub Item_1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_1TextBox.TextChanged

    End Sub

    Private Sub Item_2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_2TextBox.TextChanged

    End Sub

    Private Sub Item_3TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_3TextBox.TextChanged

    End Sub

    Private Sub Item_4TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_4TextBox.TextChanged

    End Sub

    Private Sub Item_5TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_5TextBox.TextChanged

    End Sub

    Private Sub Item_Price_1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_Price_1TextBox.TextChanged

    End Sub

    Private Sub Item_Price_2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_Price_2TextBox.TextChanged

    End Sub

    Private Sub Item_Price_3TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_Price_3TextBox.TextChanged


    End Sub

    Private Sub Item_Price_4TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_Price_4TextBox.TextChanged

    End Sub

    Private Sub Item_Price_5TextBox_TextChanged(sender As Object, e As EventArgs) Handles Item_Price_5TextBox.TextChanged

    End Sub

    Private Sub Order_SummaryTextBox_TextChanged(sender As Object, e As EventArgs) Handles Order_SummaryTextBox.TextChanged

    End Sub

    Private Sub Grand_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Grand_TotalTextBox.TextChanged


    End Sub

    Private Sub Order_DepositTextBox_TextChanged(sender As Object, e As EventArgs) Handles Order_DepositTextBox.TextChanged

    End Sub

    Private Sub Order_BalanceTextBox_TextChanged(sender As Object, e As EventArgs) Handles Order_BalanceTextBox.TextChanged

    End Sub

    Private Sub Cancel_OrderCheckBox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Chocolate_Chip_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Chocolate_Chip_TotalTextBox.TextChanged

    End Sub

    Private Sub Sugar_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Sugar_TotalTextBox.TextChanged

    End Sub

    Private Sub Double_Chocolate_Chip_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Double_Chocolate_Chip_TotalTextBox.TextChanged

    End Sub

    Private Sub Oatmeal_Raisin_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Oatmeal_Raisin_TotalTextBox.TextChanged

    End Sub

    Private Sub Lemon_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Lemon_TotalTextBox.TextChanged

    End Sub

    Private Sub Pecan_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Pecan_TotalTextBox.TextChanged

    End Sub

    Private Sub Triple_Berry_Bar_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Triple_Berry_Bar_TotalTextBox.TextChanged

    End Sub

    Private Sub Tiger_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Tiger_TotalTextBox.TextChanged

    End Sub

    Private Sub Magic_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Magic_TotalTextBox.TextChanged

    End Sub

    Private Sub Classic_Brownie_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Classic_Brownie_TotalTextBox.TextChanged

    End Sub

    Private Sub Truffle_Brownie_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Truffle_Brownie_TotalTextBox.TextChanged

    End Sub

    Private Sub German_Brownie_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles German_Brownie_TotalTextBox.TextChanged

    End Sub

    Private Sub Apple_Crisp_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Apple_Crisp_TotalTextBox.TextChanged

    End Sub

    Private Sub Date_Bar_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Date_Bar_TotalTextBox.TextChanged

    End Sub

    Private Sub Cranberry_Magic_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cranberry_Magic_TotalTextBox.TextChanged

    End Sub

    Private Sub Pumpkin_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Pumpkin_TotalTextBox.TextChanged

    End Sub

    Private Sub Mini_Bar_Package_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Bar_Package_TotalTextBox.TextChanged

    End Sub

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Order_StatusTextBox_TextChanged(sender As Object, e As EventArgs) Handles Order_StatusTextBox.TextChanged

    End Sub

    Private Sub Order_Taken_ByLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MINI_PASTRY_ORDERSTableAdapter.UpdateSubmitOrder(Order_Taken_ByTextBox.Text, Customer_NameTextBox.Text, Phone_NumberTextBox.Text, Holiday_NumberTextBox.Text,
                                                         Order_DateDateTimePicker.Text, Mini_Cannoli_TotalTextBox.Text, Mini_Eclair_TotalTextBox.Text, Mini_Cream_Puff_TotalTextBox.Text, Mini_Key_Lime_Tart_TotalTextBox.Text,
                                                         Mini_Fruit_Tart_TotalTextBox.Text, Mini_Lemon_Curd_Tart_TotalTextBox.Text, Assorted_Cheesecake_TotalTextBox.Text, Pecan_Truffle_Tart_TotalTextBox.Text, Ganache_Tart_TotalTextBox.Text,
                                                         Mini_Chocolate_Mousse_Cups_TotalTextBox.Text, Assorted_Cheesecake_TotalTextBox.Text, Mousse_FlavorComboBox.Text, Decimal.Parse(Mini_Pastry_Total_PriceTextBox.Text), Mini_Bars_TotalTextBox.Text,
                                                         Decimal.Parse(Mini_Bar_Total_PriceTextBox.Text), Cookie_DozenTextBox.Text, Decimal.Parse(Cookie_TotalTextBox.Text), Platter_or_BoxComboBox.Text, Order_DescriptionTextBox.Text, Order_MessageTextBox.Text, Item_1TextBox.Text, Item_2TextBox.Text,
                                                         Item_3TextBox.Text, Item_4TextBox.Text, Item_5TextBox.Text, Decimal.Parse(Item_Price_1TextBox.Text), Decimal.Parse(Item_Price_2TextBox.Text), Decimal.Parse(Item_Price_3TextBox.Text), Decimal.Parse(Item_Price_4TextBox.Text),
                                                         Decimal.Parse(Item_Price_5TextBox.Text), Order_SummaryTextBox.Text, Decimal.Parse(Grand_TotalTextBox.Text), Decimal.Parse(Order_DepositTextBox.Text), Order_BalanceTextBox.Text, Chocolate_Chip_TotalTextBox.Text, Sugar_TotalTextBox.Text,
                                                         Double_Chocolate_Chip_TotalTextBox.Text, Oatmeal_Raisin_TotalTextBox.Text, Lemon_TotalTextBox.Text, Pecan_TotalTextBox.Text, Triple_Berry_Bar_TotalTextBox.Text, Tiger_TotalTextBox.Text, Magic_TotalTextBox.Text, Classic_Brownie_TotalTextBox.Text,
                                                         Truffle_Brownie_TotalTextBox.Text, German_Brownie_TotalTextBox.Text, Apple_Crisp_TotalTextBox.Text, Date_Bar_TotalTextBox.Text, Cranberry_Magic_TotalTextBox.Text, Pumpkin_TotalTextBox.Text, Mini_Bar_Package_TotalTextBox.Text, Order_StatusTextBox.Text, IDTextBox.Text,
                                                         IDTextBox.Text)



        Me.Close()
        Report_2_form.Show()
    End Sub

    Private Sub Mini_Pastry_Total_PriceTextBox_Enter(sender As Object, e As EventArgs) Handles Mini_Pastry_Total_PriceTextBox.Enter

    End Sub

    Private Sub Mini_Bar_Total_PriceTextBox_Leave(sender As Object, e As EventArgs) Handles Mini_Bar_Total_PriceTextBox.Leave

    End Sub

    Private Sub Mini_Pastry_Total_PriceTextBox_Leave(sender As Object, e As EventArgs) Handles Mini_Pastry_Total_PriceTextBox.Leave

    End Sub

    Private Sub Cookie_TotalTextBox_Enter(sender As Object, e As EventArgs) Handles Cookie_TotalTextBox.Enter

    End Sub

    Private Sub Cookie_TotalTextBox_Leave(sender As Object, e As EventArgs) Handles Cookie_TotalTextBox.Leave

    End Sub

    Private Sub Item_Price_1TextBox_Leave(sender As Object, e As EventArgs) Handles Item_Price_1TextBox.Leave

    End Sub

    Private Sub Item_Price_2TextBox_Enter(sender As Object, e As EventArgs) Handles Item_Price_2TextBox.Enter

    End Sub

    Private Sub Item_Price_3TextBox_Leave(sender As Object, e As EventArgs) Handles Item_Price_3TextBox.Leave

    End Sub

    Private Sub Item_Price_4TextBox_Leave(sender As Object, e As EventArgs) Handles Item_Price_4TextBox.Leave

    End Sub

    Private Sub Item_Price_5TextBox_Enter(sender As Object, e As EventArgs) Handles Item_Price_5TextBox.Enter

    End Sub

    Private Sub Item_Price_5TextBox_Leave(sender As Object, e As EventArgs) Handles Item_Price_5TextBox.Leave

    End Sub

    Private Sub Item_Price_2TextBox_Leave(sender As Object, e As EventArgs) Handles Item_Price_2TextBox.Leave

    End Sub

    Private Sub Grand_TotalTextBox_Enter(sender As Object, e As EventArgs) Handles Grand_TotalTextBox.Enter

    End Sub

    Private Sub Grand_TotalTextBox_Leave(sender As Object, e As EventArgs) Handles Grand_TotalTextBox.Leave
        Grand_TotalTextBox.Text = Decimal.Parse(Mini_Pastry_Total_PriceTextBox.Text) + Decimal.Parse(Mini_Bar_Total_PriceTextBox.Text) + Decimal.Parse(Cookie_TotalTextBox.Text) + Decimal.Parse(Item_Price_1TextBox.Text) + Decimal.Parse(Item_Price_2TextBox.Text) + Decimal.Parse(Item_Price_3TextBox.Text) + Decimal.Parse(Item_Price_4TextBox.Text) + Decimal.Parse(Item_Price_5TextBox.Text)

    End Sub

    Private Sub Order_DepositTextBox_Leave(sender As Object, e As EventArgs) Handles Order_DepositTextBox.Leave
        Order_BalanceTextBox.Text = Decimal.Parse(Grand_TotalTextBox.Text) - Decimal.Parse(Order_DepositTextBox.Text)
    End Sub

    Private Sub Holiday_NumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles Holiday_NumberTextBox.TextChanged

    End Sub

    Private Sub Order_Taken_ByTextBox_Leave(sender As Object, e As EventArgs) Handles Order_Taken_ByTextBox.Leave

    End Sub
End Class