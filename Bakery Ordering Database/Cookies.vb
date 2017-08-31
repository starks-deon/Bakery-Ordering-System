Public Class Cookies
    Private Sub MINI_PASTRY_ORDERSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.MINI_PASTRY_ORDERSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bakery_OrdersDataSet)

    End Sub

    Private Sub Cookies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_OrdersDataSet.MINI_PASTRY_ORDERS' table. You can move, or remove it, as needed.
        IDTextBox.Text = Form2.OrderingID
        Me.MINI_PASTRY_ORDERSTableAdapter.SelectCookies(Me.Bakery_OrdersDataSet.MINI_PASTRY_ORDERS, CType(IDTextBox.Text, Integer))

    End Sub
    Public Cookie_Price As Int32
    Public Chocolate_Chip As Boolean
    Public Sugar As Boolean
    Public Double_Chocolate As Boolean
    Public Oatmeal As Boolean
    Private Sub Chocolate_ChipCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Chocolate_ChipCheckBox.CheckedChanged
        If Chocolate_ChipCheckBox.Checked = True Then
            Chocolate_Chip_TotalTextBox.Enabled = True
            Boolean.TryParse(Chocolate_ChipCheckBox.Text, Chocolate_Chip)
        Else
            Chocolate_Chip_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub SugarCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SugarCheckBox.CheckedChanged
        If SugarCheckBox.Checked = True Then
            Sugar_TotalTextBox.Enabled = True
            Boolean.TryParse(SugarCheckBox.Text, Sugar)
        Else
            Sugar_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Double_Chocolate_ChipCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Double_Chocolate_ChipCheckBox.CheckedChanged
        If Double_Chocolate_ChipCheckBox.Checked = True Then
            Double_Chocolate_Chip_TotalTextBox.Enabled = True
            Boolean.TryParse(Double_Chocolate_ChipCheckBox.Text, Double_Chocolate)
        Else
            Double_Chocolate_Chip_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Oatmeal_RaisinCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Oatmeal_RaisinCheckBox.CheckedChanged
        If Oatmeal_RaisinCheckBox.Checked = True Then
            Oatmeal_Raisin_TotalTextBox.Enabled = True
            Boolean.TryParse(Oatmeal_RaisinCheckBox.Text, Oatmeal)
        Else
            Oatmeal_Raisin_TotalTextBox.Enabled = False
        End If
    End Sub
    Private Sub Validation()

    End Sub

    Private Sub Cookie_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Chocolate_ChipCheckBox.Checked = True And Chocolate_Chip_TotalTextBox.Text = 0 Then
            MsgBox("If Chocolate Chip is checked then Chocolate Chip Total cannot be 0")
        ElseIf SugarCheckBox.Checked = True And Sugar_TotalTextBox.Text = 0 Then
            MsgBox("If Sugar is checked then Sugar Total Cannot be 0")
        ElseIf Double_Chocolate_ChipCheckBox.Checked = True And Double_Chocolate_Chip_TotalTextBox.Text = 0 Then
            MsgBox("If Double Chocolate Chip is checked then Double Chocolate Chip total cannot be 0")
        ElseIf Oatmeal_RaisinCheckBox.Checked = True And Oatmeal_Raisin_TotalTextBox.Text = 0 Then
            MsgBox("IF Oatmeal Raisin is checked then Oatmeal Raisin total cannot be 0")
        ElseIf Cookie_TotalTextBox.Text = "0" Then
            MsgBox("Cookie Total Price Cannot be 0")
        Else
            MINI_PASTRY_ORDERSTableAdapter.UpdateCookies(Sugar, Double_Chocolate, Oatmeal, Chocolate_Chip, Cookie_TotalTextBox.Text, Sugar_TotalTextBox.Text, Double_Chocolate_Chip_TotalTextBox.Text, Oatmeal_Raisin_TotalTextBox.Text, IDTextBox.Text, IDTextBox.Text)
            Cookie_Price = Cookie_TotalTextBox.Text
            Me.Hide()
        End If
    End Sub

    Private Sub Cookie_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cookie_TotalTextBox.TextChanged
    End Sub
End Class