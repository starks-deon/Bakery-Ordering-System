Public Class Mini_Bars
    Private Sub MINI_PASTRY_ORDERSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MINI_PASTRY_ORDERSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bakery_OrdersDataSet)

    End Sub

    Private Sub Mini_Bars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bakery_OrdersDataSet.MINI_PASTRY_ORDERS' table. You can move, or remove it, as needed.
        IDTextBox.Text = Form2.OrderingID
        Me.MINI_PASTRY_ORDERSTableAdapter.SelectMiniBars(Me.Bakery_OrdersDataSet.MINI_PASTRY_ORDERS, CType(IDTextBox.Text, Integer))


    End Sub
    Public Mini_Bar_Price As Int32
    Public Lemon As Boolean
    Public Pecan As Boolean
    Public Triple_Berry_Bar As Boolean
    Public Tiger As Boolean
    Public Magic As Boolean
    Public Class_Brownie As Boolean
    Public Truffle_Brownie As Boolean
    Public German_Brownie As Boolean
    Public Apple_Crisp As Boolean
    Public Date_Bar As Boolean
    Public Cranberry_Magic As Boolean
    Public Pumpkin As Boolean
    Public Mini_Bar_Package As Boolean
    Private Sub LemonCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LemonCheckBox.CheckedChanged
        If LemonCheckBox.Checked = True Then
            Lemon_TotalTextBox.Enabled = True
            Boolean.TryParse(LemonCheckBox.ToString, Lemon)
        Else
            Lemon_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PecanCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles PecanCheckBox.CheckedChanged
        If PecanCheckBox.Checked = True Then
            Pecan_TotalTextBox.Enabled = True
            Boolean.TryParse(PecanCheckBox.ToString, Pecan)
        Else
            Pecan_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Triple_Berry_BarCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Triple_Berry_BarCheckBox.CheckedChanged
        If Triple_Berry_BarCheckBox.Checked = True Then
            Triple_Berry_Bar_TotalTextBox.Enabled = True
            Boolean.TryParse(Triple_Berry_BarCheckBox.ToString, Triple_Berry_Bar)
        Else
            Triple_Berry_Bar_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub TigerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TigerCheckBox.CheckedChanged
        If TigerCheckBox.Checked = True Then
            Tiger_TotalTextBox.Enabled = True
            Boolean.TryParse(TigerCheckBox.ToString, Tiger)
        Else
            Tiger_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub MagicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MagicCheckBox.CheckedChanged
        If MagicCheckBox.Checked = True Then
            Magic_TotalTextBox.Enabled = True
            Boolean.TryParse(MagicCheckBox.ToString, Magic)
        Else
            Magic_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Classic_BrownieCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Classic_BrownieCheckBox.CheckedChanged
        If Classic_BrownieCheckBox.Checked = True Then
            Classic_Brownie_TotalTextBox.Enabled = True
            Boolean.TryParse(Classic_BrownieCheckBox.ToString, Class_Brownie)
        Else
            Classic_Brownie_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Truffle_BrownieCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Truffle_BrownieCheckBox.CheckedChanged
        If Truffle_BrownieCheckBox.Checked = True Then
            Truffle_Brownie_TotalTextBox.Enabled = True
            Boolean.TryParse(Truffle_BrownieCheckBox.ToString, Truffle_Brownie)
        Else
            Truffle_Brownie_TotalTextBox.Enabled = False
        End If
    End Sub
    Private Sub German_BrownieCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles German_BrownieCheckBox.CheckedChanged
        If German_BrownieCheckBox.Checked = True Then
            German_Brownie_TotalTextBox.Enabled = True
            Boolean.TryParse(German_BrownieCheckBox.ToString, German_Brownie)
        Else
            German_Brownie_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Apple_CrispCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Apple_CrispCheckBox.CheckedChanged
        If Apple_CrispCheckBox.Checked = True Then
            Apple_Crisp_TotalTextBox.Enabled = True
            Boolean.TryParse(Apple_CrispCheckBox.ToString, Apple_Crisp)
        Else
            Apple_Crisp_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Date_BarCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Date_BarCheckBox.CheckedChanged
        If Date_BarCheckBox.Checked = True Then
            Date_Bar_TotalTextBox.Enabled = True
            Boolean.TryParse(Date_BarCheckBox.ToString, Date_Bar)
        Else
            Date_Bar_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Cranberry_MagicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Cranberry_MagicCheckBox.CheckedChanged
        If Cranberry_MagicCheckBox.Checked = True Then
            Cranberry_Magic_TotalTextBox.Enabled = True
            Boolean.TryParse(Cranberry_MagicCheckBox.ToString, Cranberry_Magic)
        Else
            Cranberry_Magic_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub PumpkinCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles PumpkinCheckBox.CheckedChanged
        If PumpkinCheckBox.Checked = True Then
            Pumpkin_TotalTextBox.Enabled = True
            Boolean.TryParse(PumpkinCheckBox.ToString, Pumpkin)
        Else
            Pumpkin_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Mini_Bar_PackageCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Mini_Bar_PackageCheckBox.CheckedChanged
        If Mini_Bar_PackageCheckBox.Checked = True Then
            Mini_Bar_Package_TotalTextBox.Enabled = True
            Boolean.TryParse(Mini_Bar_PackageCheckBox.ToString, Mini_Bar_Package)
        Else
            Mini_Bar_Package_TotalTextBox.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LemonCheckBox.Checked = True And Lemon_TotalTextBox.Text = 0 Then
            MsgBox("If Lemon bar is checked then Lemon bar total cannot be 0")
        ElseIf PecanCheckBox.Checked = True And Pecan_TotalTextBox.Text = 0 Then
            MsgBox("If Pecan Bar is checked then Pecan Bar Total cannot be 0")
        ElseIf Triple_Berry_BarCheckBox.Checked = True And Triple_Berry_Bar_TotalTextBox.Text = 0 Then
            MsgBox("If Triple Berry Bar is checked then Triple Berry Bar Total cannot be 0")
        ElseIf TigerCheckBox.Checked = True And Tiger_TotalTextBox.Text = 0 Then
            MsgBox("If Tiger bar is checked then Tiger Bar Total cannot be 0")
        ElseIf MagicCheckBox.Checked = True And Magic_TotalTextBox.Text = 0 Then
            MsgBox("If Magic Bar is checked then Magic Bar Total cannot be 0")
        ElseIf Classic_BrownieCheckBox.Checked = True And Classic_Brownie_TotalTextBox.Text = 0 Then
            MsgBox("If Classic Brownie is checked then Classic Brownie cannot be 0")
        ElseIf Truffle_BrownieCheckBox.Checked = True And Truffle_Brownie_TotalTextBox.Text = 0 Then
            MsgBox("If Truffle Brownie is checked then Truffle Brownie total cannot be 0")
        ElseIf German_BrownieCheckBox.Checked = True And German_Brownie_TotalTextBox.Text = 0 Then
            MsgBox("If German Brownie is checked then German Brownie Total cannot be 0")
        ElseIf Apple_CrispCheckBox.Checked = True And Apple_Crisp_TotalTextBox.Text = 0 Then
            MsgBox("If Apple Crisp Bar is checked then Apple Crisp Bar Total cannot be 0")
        ElseIf Date_BarCheckBox.Checked = True And Date_Bar_TotalTextBox.Text = 0 Then
            MsgBox("If Date bar is checked then Date Bar Total cannot be 0")
        ElseIf Cranberry_MagicCheckBox.Checked = True And Cranberry_Magic_TotalTextBox.Text = 0 Then
            MsgBox("If Cranberry Magic Bar is checked then Cranberry Magic Bar Total cannot be 0")
        ElseIf PumpkinCheckBox.Checked = True And Pumpkin_TotalTextBox.Text = 0 Then
            MsgBox("If Pumpkin Bar is checked then Pumpkin Bar Total cannot be 0")
        ElseIf Mini_Bar_PackageCheckBox.Checked = True And Mini_Bar_Package_TotalTextBox.Text = 0 Then
            MsgBox("If Mini Bar Package is checked then Mini Bar Package Total cannot be 0")
        ElseIf Mini_Bar_Total_PriceTextBox.Text = "0" Then
            MsgBox("Mini Bar Total Price cannot be 0")
        Else
            MINI_PASTRY_ORDERSTableAdapter.UpdateMiniBars(Lemon, Pecan, Triple_Berry_Bar, Tiger, Magic, Class_Brownie, Truffle_Brownie, German_Brownie, Apple_Crisp, Date_Bar, Cranberry_Magic, Pumpkin, Mini_Bar_Package, Mini_Bar_Total_PriceTextBox.Text,
                                                     Lemon_TotalTextBox.Text, Pecan_TotalTextBox.Text, Triple_Berry_Bar_TotalTextBox.Text, Tiger_TotalTextBox.Text, Magic_TotalTextBox.Text, Classic_Brownie_TotalTextBox.Text, Truffle_Brownie_TotalTextBox.
                                                     Text, German_Brownie_TotalTextBox.Text, Apple_Crisp_TotalTextBox.Text, Date_Bar_TotalTextBox.Text, Cranberry_Magic_TotalTextBox.Text, Pumpkin_TotalTextBox.Text, Mini_Bar_Package_TotalTextBox.Text, IDTextBox.Text, IDTextBox.Text)
            Mini_Bar_Price = Mini_Bar_Total_PriceTextBox.Text
            Me.Hide()
        End If

    End Sub

    Private Sub IDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Mini_Bar_Total_PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mini_Bar_Total_PriceTextBox.TextChanged
    End Sub
End Class