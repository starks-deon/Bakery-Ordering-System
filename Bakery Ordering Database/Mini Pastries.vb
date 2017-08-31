Public Class Mini_Pastries
    Private Sub MINI_PASTRY_ORDERSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MINI_PASTRY_ORDERSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bakery_OrdersDataSet)

    End Sub

    Private Sub Mini_Pastries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_OrdersDataSet.MINI_PASTRY_ORDERS' table. You can move, or remove it, as needed.
        IDTextBox.Text = Form2.OrderingID
        Me.MINI_PASTRY_ORDERSTableAdapter.SelectMiniPastries(Me.Bakery_OrdersDataSet.MINI_PASTRY_ORDERS, CType(IDTextBox.Text, Integer))

    End Sub


    Private Sub Mini_Cream_Puff_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Cream_Puff_TotalTextBox.TextChanged

    End Sub

    Private Sub Assorted_Cheesecake_TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles Assorted_Cheesecake_TotalTextBox.TextChanged

    End Sub
    Public Mini_Pastries_Price As Int32
    Public Mini_Cannoli As Boolean
    Public Mini_Eclair As Boolean
    Public Mini_Cream_Puff As Boolean
    Public Mini_Key_Lime_Tart As Boolean
    Public Fruit_Tart As Boolean
    Public Mini_Lemon_Curd_Tart As Boolean
    Public Assorted_Cheesecake As Boolean
    Public Mini_Pecan_Truffle_Tart As Boolean
    Public Mini_Ganache_Tart As Boolean
    Public Mini_Chocolate_Mousse_Cups As Boolean
    Public Assorted_Mini_Pastry_Package As Boolean
    Private Sub Mini_Assorted_CheesecakeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_Assorted_CheesecakeCheckBox.CheckedChanged
        If Mini_Assorted_CheesecakeCheckBox.Checked = True Then
            Assorted_Cheesecake_TotalTextBox.readonly = False

            Boolean.TryParse(Mini_Assorted_CheesecakeCheckBox.ToString, Assorted_Cheesecake)

        Else
            Assorted_Cheesecake_TotalTextBox.ReadOnly = True
            Assorted_Cheesecake_TotalTextBox.Text = 0


        End If
    End Sub

    Private Sub Assorted_Mini_Pastry_Package_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_CannoliCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_CannoliCheckBox.CheckedChanged
        If Mini_CannoliCheckBox.Checked = True Then
            Mini_Cannoli_TotalTextBox.ReadOnly = False
            Boolean.TryParse(Mini_CannoliCheckBox.ToString, Mini_Cannoli)
        Else
            Mini_Cannoli_TotalTextBox.ReadOnly = True
            Mini_Cannoli_TotalTextBox.Text = 0
        End If
    End Sub

    Private Sub Mini_Cannoli_TotalLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Mini_EclairCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_EclairCheckBox.CheckedChanged
        If Mini_EclairCheckBox.Checked = True Then
            Mini_Eclair_TotalTextBox.ReadOnly = False
            Boolean.TryParse(Mini_EclairCheckBox.ToString, Mini_Eclair)
        Else
            Mini_Eclair_TotalTextBox.ReadOnly = True
            Mini_Eclair_TotalTextBox.Text = 0
        End If
    End Sub

    Private Sub Mini_Cream_PuffCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_Cream_PuffCheckBox.CheckedChanged
        If Mini_Cream_PuffCheckBox.Checked = True Then
            Mini_Cream_Puff_TotalTextBox.ReadOnly = False
            Boolean.TryParse(Mini_Cream_PuffCheckBox.ToString, Mini_Cream_Puff)
        Else
            Mini_Cream_Puff_TotalTextBox.ReadOnly = True
            Mini_Cream_Puff_TotalTextBox.Text = 0

        End If
    End Sub

    Private Sub Mini_Key_Lime_TartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_Key_Lime_TartCheckBox.CheckedChanged
        If Mini_Key_Lime_TartCheckBox.Checked = True Then
            Mini_Key_Lime_Tart_TotalTextBox.ReadOnly = False

            Boolean.TryParse(Mini_Key_Lime_TartCheckBox.ToString, Mini_Key_Lime_Tart)
        Else
            Mini_Key_Lime_Tart_TotalTextBox.ReadOnly = True
            Mini_Key_Lime_Tart_TotalTextBox.Text = 0

        End If
    End Sub

    Private Sub Mini_Fruit_TartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_Fruit_TartCheckBox.CheckedChanged
        If Mini_Fruit_TartCheckBox.Checked = True Then
            Mini_Fruit_Tart_TotalTextBox.ReadOnly = False

            Boolean.TryParse(Mini_Fruit_TartCheckBox.ToString, Fruit_Tart)
        Else
            Mini_Fruit_Tart_TotalTextBox.ReadOnly = True
            Mini_Fruit_Tart_TotalTextBox.Text = 0

        End If
    End Sub

    Private Sub Mini_Lemon_Curd_TartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_Lemon_Curd_TartCheckBox.CheckedChanged
        If Mini_Lemon_Curd_TartCheckBox.Checked = True Then
            Mini_Lemon_Curd_Tart_TotalTextBox.ReadOnly = False

            Boolean.TryParse(Mini_Lemon_Curd_Tart.ToString, Mini_Lemon_Curd_Tart)
        Else
            Mini_Lemon_Curd_Tart_TotalTextBox.ReadOnly = True
            Mini_Lemon_Curd_Tart_TotalTextBox.Text = 0

        End If
    End Sub

    Private Sub Mini_Pecan_Truffle_TartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_Pecan_Truffle_TartCheckBox.CheckedChanged
        If Mini_Pecan_Truffle_TartCheckBox.Checked = True Then
            Pecan_Truffle_Tart_TotalTextBox.ReadOnly = False

            Boolean.TryParse(Mini_Pecan_Truffle_Tart.ToString, Mini_Pecan_Truffle_Tart)
        Else
            Pecan_Truffle_Tart_TotalTextBox.ReadOnly = True
            Pecan_Truffle_Tart_TotalTextBox.Text = 0

        End If
    End Sub

    Private Sub Mini_Ganache_TartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_Ganache_TartCheckBox.CheckedChanged
        If Mini_Ganache_TartCheckBox.Checked = True Then
            Ganache_Tart_TotalTextBox.ReadOnly = False

            Boolean.TryParse(Mini_Ganache_TartCheckBox.ToString, Mini_Ganache_Tart)
        Else
            Ganache_Tart_TotalTextBox.ReadOnly = True
            Ganache_Tart_TotalTextBox.Text = 0

        End If
    End Sub

    Private Sub Mini_Chocolate_Mousse_CupsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_Chocolate_Mousse_CupsCheckBox.CheckedChanged
        If Mini_Chocolate_Mousse_CupsCheckBox.Checked = True Then
            Mini_Chocolate_Mousse_Cups_TotalTextBox.ReadOnly = False
            Mousse_FlavorComboBox.Enabled = True
            Boolean.TryParse(Mini_Chocolate_Mousse_Cups.ToString, Mini_Chocolate_Mousse_Cups)
        Else
            Mini_Chocolate_Mousse_Cups_TotalTextBox.ReadOnly = True
            Mini_Chocolate_Mousse_Cups_TotalTextBox.Text = 0
            Mousse_FlavorComboBox.Enabled = False


        End If
    End Sub

    Private Sub Assorted_Mini_Pastry_PackageCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Assorted_Mini_Pastry_PackageCheckBox.CheckedChanged
        If Assorted_Mini_Pastry_PackageCheckBox.Checked = True Then
            Assorted_Mini_Pastry_Package_TotalTextBox.ReadOnly = False

            Boolean.TryParse(Assorted_Mini_Pastry_PackageCheckBox.ToString, Assorted_Mini_Pastry_Package)
        Else
            Assorted_Mini_Pastry_Package_TotalTextBox.ReadOnly = True
            Assorted_Mini_Pastry_Package_TotalTextBox.Text = 0

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Mini_CannoliCheckBox.Checked = True And Mini_Cannoli_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Cannoli Total:) if you have Mini Cannoli checked.")
        ElseIf Mini_EclairCheckBox.Checked = True And Mini_Eclair_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Eclair Total:) if you have Mini Eclair checked.")
        ElseIf Mini_Cream_PuffCheckBox.Checked = True And Mini_Cream_Puff_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Cream Puff Total:) if you have Mini Cream Puff checked.")
        ElseIf Mini_Key_Lime_TartCheckBox.Checked = True And Mini_Key_Lime_Tart_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Key Lime tart Total:) if you have Mini Key Lime Tart checked.")
        ElseIf Mini_Fruit_TartCheckBox.Checked = True And Mini_Fruit_Tart_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Fruit Tart Total:) if you have Mini Fruit Tart  checked.")
        ElseIf Mini_Lemon_Curd_TartCheckBox.Checked = True And Mini_Lemon_Curd_Tart_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Lemon Curd Total:) if you have Mini Fruit Tart checked.")
        ElseIf Mini_Assorted_CheesecakeCheckBox.Checked = True And Assorted_Cheesecake_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Assorted Cheesecake Total:) if you have Mini Assorted Cheesecake checked.")
        ElseIf Mini_Pecan_Truffle_TartCheckBox.Checked = True And Pecan_Truffle_Tart_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Pecan Truffle Tart Total:) if you have Mini Pecan Truffle Tart checked.")
        ElseIf Mini_Ganache_TartCheckBox.Checked = True And Ganache_Tart_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Ganache Tart Total:) if you have Mini Ganache Tart checked.")
        ElseIf Mini_Chocolate_Mousse_CupsCheckBox.Checked = True And Mini_Chocolate_Mousse_Cups_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Mini Chocolate Mousse Cups Total:) if you have Mini Chocolate Mousse Cups checked.")
        ElseIf Mini_Chocolate_Mousse_CupsCheckBox.Checked = True And IsDBNull(Mousse_FlavorComboBox.Text) Then
            MsgBox("You must select a Mousse Flaver if you have Mini Chocolate Mousse checked.")
        ElseIf Assorted_Mini_Pastry_PackageCheckBox.Checked = True And Assorted_Cheesecake_TotalTextBox.Text = 0 Then
            MsgBox("You must enter a number in (Assorted Mini Pastry Package Total:) if you have Assorted Mini Pastry Package checked.")
        ElseIf Mini_Pastry_Total_PriceTextBox.Text = "0" Then
            MsgBox("You must enter a price")
        Else
            MINI_PASTRY_ORDERSTableAdapter.UpdateMiniPastries(Mini_Key_Lime_Tart, Mini_Key_Lime_Tart, Mini_Lemon_Curd_Tart, Assorted_Cheesecake, Mini_Pecan_Truffle_Tart, Mini_Ganache_Tart, Mini_Chocolate_Mousse_Cups, Assorted_Cheesecake,
                                                         Mini_Cannoli_TotalTextBox.Text, Mini_Eclair_TotalTextBox.Text, Mini_Cream_Puff_TotalTextBox.Text, Mini_Key_Lime_Tart_TotalTextBox.Text, Mini_Fruit_Tart_TotalTextBox.Text,
                                                         Mini_Lemon_Curd_Tart_TotalTextBox.Text, Assorted_Cheesecake_TotalTextBox.Text, Pecan_Truffle_Tart_TotalTextBox.Text, Ganache_Tart_TotalTextBox.Text, Mini_Chocolate_Mousse_Cups_TotalTextBox.Text,
                                                         Assorted_Mini_Pastry_Package_TotalTextBox.Text, Mousse_FlavorComboBox.Text, Mini_Pastry_Total_PriceTextBox.Text, Mini_Cream_Puff, Mini_Cannoli, Mini_Eclair, IDTextBox.Text, IDTextBox.Text)
            Mini_Pastries_Price = Mini_Pastry_Total_PriceTextBox.Text
            Me.Hide()
        End If
    End Sub
    Private Sub Original_IDToolStripTextBox_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Original_IDToolStripLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub IDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mini_Pastry_Total_PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Pastry_Total_PriceTextBox.TextChanged
    End Sub
End Class
