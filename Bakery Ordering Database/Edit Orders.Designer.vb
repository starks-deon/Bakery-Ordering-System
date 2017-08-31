<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Orders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Order_Taken_ByLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Order_DateLabel As System.Windows.Forms.Label
        Dim Mini_Cannoli_TotalLabel As System.Windows.Forms.Label
        Dim Mini_Eclair_TotalLabel As System.Windows.Forms.Label
        Dim Mini_Cream_Puff_TotalLabel As System.Windows.Forms.Label
        Dim Mini_Key_Lime_Tart_TotalLabel As System.Windows.Forms.Label
        Dim Mini_Fruit_Tart_TotalLabel As System.Windows.Forms.Label
        Dim Mini_Lemon_Curd_Tart_TotalLabel As System.Windows.Forms.Label
        Dim Assorted_Cheesecake_TotalLabel As System.Windows.Forms.Label
        Dim Pecan_Truffle_Tart_TotalLabel As System.Windows.Forms.Label
        Dim Ganache_Tart_TotalLabel As System.Windows.Forms.Label
        Dim Mini_Chocolate_Mousse_Cups_TotalLabel As System.Windows.Forms.Label
        Dim Assorted_Mini_Pastry_Package_TotalLabel As System.Windows.Forms.Label
        Dim Mini_Pastry_Total_PriceLabel As System.Windows.Forms.Label
        Dim Mini_Bars_TotalLabel As System.Windows.Forms.Label
        Dim Mini_Bar_Total_PriceLabel As System.Windows.Forms.Label
        Dim Cookie_DozenLabel As System.Windows.Forms.Label
        Dim Cookie_TotalLabel As System.Windows.Forms.Label
        Dim Platter_or_BoxLabel As System.Windows.Forms.Label
        Dim Order_DescriptionLabel As System.Windows.Forms.Label
        Dim Order_MessageLabel As System.Windows.Forms.Label
        Dim Item_1Label As System.Windows.Forms.Label
        Dim Item_2Label As System.Windows.Forms.Label
        Dim Item_3Label As System.Windows.Forms.Label
        Dim Item_4Label As System.Windows.Forms.Label
        Dim Item_5Label As System.Windows.Forms.Label
        Dim Item_Price_1Label As System.Windows.Forms.Label
        Dim Item_Price_2Label As System.Windows.Forms.Label
        Dim Item_Price_3Label As System.Windows.Forms.Label
        Dim Item_Price_4Label As System.Windows.Forms.Label
        Dim Item_Price_5Label As System.Windows.Forms.Label
        Dim Order_SummaryLabel As System.Windows.Forms.Label
        Dim Grand_TotalLabel As System.Windows.Forms.Label
        Dim Order_DepositLabel As System.Windows.Forms.Label
        Dim Order_BalanceLabel As System.Windows.Forms.Label
        Dim Chocolate_Chip_TotalLabel As System.Windows.Forms.Label
        Dim Sugar_TotalLabel As System.Windows.Forms.Label
        Dim Double_Chocolate_Chip_TotalLabel As System.Windows.Forms.Label
        Dim Oatmeal_Raisin_TotalLabel As System.Windows.Forms.Label
        Dim Lemon_TotalLabel As System.Windows.Forms.Label
        Dim Pecan_TotalLabel As System.Windows.Forms.Label
        Dim Triple_Berry_Bar_TotalLabel As System.Windows.Forms.Label
        Dim Tiger_TotalLabel As System.Windows.Forms.Label
        Dim Magic_TotalLabel As System.Windows.Forms.Label
        Dim Classic_Brownie_TotalLabel As System.Windows.Forms.Label
        Dim Truffle_Brownie_TotalLabel As System.Windows.Forms.Label
        Dim German_Brownie_TotalLabel As System.Windows.Forms.Label
        Dim Apple_Crisp_TotalLabel As System.Windows.Forms.Label
        Dim Date_Bar_TotalLabel As System.Windows.Forms.Label
        Dim Cranberry_Magic_TotalLabel As System.Windows.Forms.Label
        Dim Pumpkin_TotalLabel As System.Windows.Forms.Label
        Dim Mini_Bar_Package_TotalLabel As System.Windows.Forms.Label
        Dim Order_StatusLabel As System.Windows.Forms.Label
        Dim Mousse_FlavorLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Holiday_NumberLabel As System.Windows.Forms.Label
        Me.Order_Taken_ByTextBox = New System.Windows.Forms.TextBox()
        Me.MINI_PASTRY_ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bakery_OrdersDataSet = New Bakery_Ordering_Database.Bakery_OrdersDataSet()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Mini_Cannoli_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Eclair_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Cream_Puff_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Key_Lime_Tart_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Fruit_Tart_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Lemon_Curd_Tart_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Assorted_Cheesecake_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Pecan_Truffle_Tart_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Ganache_Tart_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Chocolate_Mousse_Cups_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Assorted_Mini_Pastry_Package_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Pastry_Total_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Bars_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Bar_Total_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Cookie_DozenTextBox = New System.Windows.Forms.TextBox()
        Me.Cookie_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Platter_or_BoxComboBox = New System.Windows.Forms.ComboBox()
        Me.Order_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Order_MessageTextBox = New System.Windows.Forms.TextBox()
        Me.Item_1TextBox = New System.Windows.Forms.TextBox()
        Me.Item_2TextBox = New System.Windows.Forms.TextBox()
        Me.Item_3TextBox = New System.Windows.Forms.TextBox()
        Me.Item_4TextBox = New System.Windows.Forms.TextBox()
        Me.Item_5TextBox = New System.Windows.Forms.TextBox()
        Me.Item_Price_1TextBox = New System.Windows.Forms.TextBox()
        Me.Item_Price_2TextBox = New System.Windows.Forms.TextBox()
        Me.Item_Price_3TextBox = New System.Windows.Forms.TextBox()
        Me.Item_Price_4TextBox = New System.Windows.Forms.TextBox()
        Me.Item_Price_5TextBox = New System.Windows.Forms.TextBox()
        Me.Order_SummaryTextBox = New System.Windows.Forms.TextBox()
        Me.Grand_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DepositTextBox = New System.Windows.Forms.TextBox()
        Me.Order_BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.Chocolate_Chip_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Sugar_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Double_Chocolate_Chip_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Oatmeal_Raisin_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Lemon_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Pecan_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Triple_Berry_Bar_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Tiger_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Magic_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Classic_Brownie_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Truffle_Brownie_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.German_Brownie_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Apple_Crisp_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Bar_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Cranberry_Magic_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Pumpkin_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Bar_Package_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Order_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Mousse_FlavorComboBox = New System.Windows.Forms.ComboBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Holiday_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.MINI_PASTRY_ORDERSTableAdapter = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter()
        Me.TableAdapterManager = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.TableAdapterManager()
        Order_Taken_ByLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Order_DateLabel = New System.Windows.Forms.Label()
        Mini_Cannoli_TotalLabel = New System.Windows.Forms.Label()
        Mini_Eclair_TotalLabel = New System.Windows.Forms.Label()
        Mini_Cream_Puff_TotalLabel = New System.Windows.Forms.Label()
        Mini_Key_Lime_Tart_TotalLabel = New System.Windows.Forms.Label()
        Mini_Fruit_Tart_TotalLabel = New System.Windows.Forms.Label()
        Mini_Lemon_Curd_Tart_TotalLabel = New System.Windows.Forms.Label()
        Assorted_Cheesecake_TotalLabel = New System.Windows.Forms.Label()
        Pecan_Truffle_Tart_TotalLabel = New System.Windows.Forms.Label()
        Ganache_Tart_TotalLabel = New System.Windows.Forms.Label()
        Mini_Chocolate_Mousse_Cups_TotalLabel = New System.Windows.Forms.Label()
        Assorted_Mini_Pastry_Package_TotalLabel = New System.Windows.Forms.Label()
        Mini_Pastry_Total_PriceLabel = New System.Windows.Forms.Label()
        Mini_Bars_TotalLabel = New System.Windows.Forms.Label()
        Mini_Bar_Total_PriceLabel = New System.Windows.Forms.Label()
        Cookie_DozenLabel = New System.Windows.Forms.Label()
        Cookie_TotalLabel = New System.Windows.Forms.Label()
        Platter_or_BoxLabel = New System.Windows.Forms.Label()
        Order_DescriptionLabel = New System.Windows.Forms.Label()
        Order_MessageLabel = New System.Windows.Forms.Label()
        Item_1Label = New System.Windows.Forms.Label()
        Item_2Label = New System.Windows.Forms.Label()
        Item_3Label = New System.Windows.Forms.Label()
        Item_4Label = New System.Windows.Forms.Label()
        Item_5Label = New System.Windows.Forms.Label()
        Item_Price_1Label = New System.Windows.Forms.Label()
        Item_Price_2Label = New System.Windows.Forms.Label()
        Item_Price_3Label = New System.Windows.Forms.Label()
        Item_Price_4Label = New System.Windows.Forms.Label()
        Item_Price_5Label = New System.Windows.Forms.Label()
        Order_SummaryLabel = New System.Windows.Forms.Label()
        Grand_TotalLabel = New System.Windows.Forms.Label()
        Order_DepositLabel = New System.Windows.Forms.Label()
        Order_BalanceLabel = New System.Windows.Forms.Label()
        Chocolate_Chip_TotalLabel = New System.Windows.Forms.Label()
        Sugar_TotalLabel = New System.Windows.Forms.Label()
        Double_Chocolate_Chip_TotalLabel = New System.Windows.Forms.Label()
        Oatmeal_Raisin_TotalLabel = New System.Windows.Forms.Label()
        Lemon_TotalLabel = New System.Windows.Forms.Label()
        Pecan_TotalLabel = New System.Windows.Forms.Label()
        Triple_Berry_Bar_TotalLabel = New System.Windows.Forms.Label()
        Tiger_TotalLabel = New System.Windows.Forms.Label()
        Magic_TotalLabel = New System.Windows.Forms.Label()
        Classic_Brownie_TotalLabel = New System.Windows.Forms.Label()
        Truffle_Brownie_TotalLabel = New System.Windows.Forms.Label()
        German_Brownie_TotalLabel = New System.Windows.Forms.Label()
        Apple_Crisp_TotalLabel = New System.Windows.Forms.Label()
        Date_Bar_TotalLabel = New System.Windows.Forms.Label()
        Cranberry_Magic_TotalLabel = New System.Windows.Forms.Label()
        Pumpkin_TotalLabel = New System.Windows.Forms.Label()
        Mini_Bar_Package_TotalLabel = New System.Windows.Forms.Label()
        Order_StatusLabel = New System.Windows.Forms.Label()
        Mousse_FlavorLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Holiday_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order_Taken_ByLabel
        '
        Order_Taken_ByLabel.AutoSize = True
        Order_Taken_ByLabel.Location = New System.Drawing.Point(20, 41)
        Order_Taken_ByLabel.Name = "Order_Taken_ByLabel"
        Order_Taken_ByLabel.Size = New System.Drawing.Size(85, 13)
        Order_Taken_ByLabel.TabIndex = 1
        Order_Taken_ByLabel.Text = "Order Taken By:"
        AddHandler Order_Taken_ByLabel.Click, AddressOf Me.Order_Taken_ByLabel_Click
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Location = New System.Drawing.Point(20, 67)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(85, 13)
        Customer_NameLabel.TabIndex = 3
        Customer_NameLabel.Text = "Customer Name:"
        AddHandler Customer_NameLabel.Click, AddressOf Me.Customer_NameLabel_Click
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(343, 17)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 5
        Phone_NumberLabel.Text = "Phone Number:"
        AddHandler Phone_NumberLabel.Click, AddressOf Me.Phone_NumberLabel_Click
        '
        'Order_DateLabel
        '
        Order_DateLabel.AutoSize = True
        Order_DateLabel.Location = New System.Drawing.Point(343, 70)
        Order_DateLabel.Name = "Order_DateLabel"
        Order_DateLabel.Size = New System.Drawing.Size(62, 13)
        Order_DateLabel.TabIndex = 9
        Order_DateLabel.Text = "Order Date:"
        '
        'Mini_Cannoli_TotalLabel
        '
        Mini_Cannoli_TotalLabel.AutoSize = True
        Mini_Cannoli_TotalLabel.Location = New System.Drawing.Point(20, 166)
        Mini_Cannoli_TotalLabel.Name = "Mini_Cannoli_TotalLabel"
        Mini_Cannoli_TotalLabel.Size = New System.Drawing.Size(94, 13)
        Mini_Cannoli_TotalLabel.TabIndex = 39
        Mini_Cannoli_TotalLabel.Text = "Mini Cannoli Total:"
        AddHandler Mini_Cannoli_TotalLabel.Click, AddressOf Me.Mini_Cannoli_TotalLabel_Click
        '
        'Mini_Eclair_TotalLabel
        '
        Mini_Eclair_TotalLabel.AutoSize = True
        Mini_Eclair_TotalLabel.Location = New System.Drawing.Point(20, 192)
        Mini_Eclair_TotalLabel.Name = "Mini_Eclair_TotalLabel"
        Mini_Eclair_TotalLabel.Size = New System.Drawing.Size(85, 13)
        Mini_Eclair_TotalLabel.TabIndex = 41
        Mini_Eclair_TotalLabel.Text = "Mini Eclair Total:"
        AddHandler Mini_Eclair_TotalLabel.Click, AddressOf Me.Mini_Eclair_TotalLabel_Click
        '
        'Mini_Cream_Puff_TotalLabel
        '
        Mini_Cream_Puff_TotalLabel.AutoSize = True
        Mini_Cream_Puff_TotalLabel.Location = New System.Drawing.Point(20, 218)
        Mini_Cream_Puff_TotalLabel.Name = "Mini_Cream_Puff_TotalLabel"
        Mini_Cream_Puff_TotalLabel.Size = New System.Drawing.Size(111, 13)
        Mini_Cream_Puff_TotalLabel.TabIndex = 43
        Mini_Cream_Puff_TotalLabel.Text = "Mini Cream Puff Total:"
        AddHandler Mini_Cream_Puff_TotalLabel.Click, AddressOf Me.Mini_Cream_Puff_TotalLabel_Click
        '
        'Mini_Key_Lime_Tart_TotalLabel
        '
        Mini_Key_Lime_Tart_TotalLabel.AutoSize = True
        Mini_Key_Lime_Tart_TotalLabel.Location = New System.Drawing.Point(20, 244)
        Mini_Key_Lime_Tart_TotalLabel.Name = "Mini_Key_Lime_Tart_TotalLabel"
        Mini_Key_Lime_Tart_TotalLabel.Size = New System.Drawing.Size(124, 13)
        Mini_Key_Lime_Tart_TotalLabel.TabIndex = 45
        Mini_Key_Lime_Tart_TotalLabel.Text = "Mini Key Lime Tart Total:"
        AddHandler Mini_Key_Lime_Tart_TotalLabel.Click, AddressOf Me.Mini_Key_Lime_Tart_TotalLabel_Click
        '
        'Mini_Fruit_Tart_TotalLabel
        '
        Mini_Fruit_Tart_TotalLabel.AutoSize = True
        Mini_Fruit_Tart_TotalLabel.Location = New System.Drawing.Point(20, 270)
        Mini_Fruit_Tart_TotalLabel.Name = "Mini_Fruit_Tart_TotalLabel"
        Mini_Fruit_Tart_TotalLabel.Size = New System.Drawing.Size(101, 13)
        Mini_Fruit_Tart_TotalLabel.TabIndex = 47
        Mini_Fruit_Tart_TotalLabel.Text = "Mini Fruit Tart Total:"
        AddHandler Mini_Fruit_Tart_TotalLabel.Click, AddressOf Me.Mini_Fruit_Tart_TotalLabel_Click
        '
        'Mini_Lemon_Curd_Tart_TotalLabel
        '
        Mini_Lemon_Curd_Tart_TotalLabel.AutoSize = True
        Mini_Lemon_Curd_Tart_TotalLabel.Location = New System.Drawing.Point(20, 296)
        Mini_Lemon_Curd_Tart_TotalLabel.Name = "Mini_Lemon_Curd_Tart_TotalLabel"
        Mini_Lemon_Curd_Tart_TotalLabel.Size = New System.Drawing.Size(138, 13)
        Mini_Lemon_Curd_Tart_TotalLabel.TabIndex = 49
        Mini_Lemon_Curd_Tart_TotalLabel.Text = "Mini Lemon Curd Tart Total:"
        AddHandler Mini_Lemon_Curd_Tart_TotalLabel.Click, AddressOf Me.Mini_Lemon_Curd_Tart_TotalLabel_Click
        '
        'Assorted_Cheesecake_TotalLabel
        '
        Assorted_Cheesecake_TotalLabel.AutoSize = True
        Assorted_Cheesecake_TotalLabel.Location = New System.Drawing.Point(20, 322)
        Assorted_Cheesecake_TotalLabel.Name = "Assorted_Cheesecake_TotalLabel"
        Assorted_Cheesecake_TotalLabel.Size = New System.Drawing.Size(141, 13)
        Assorted_Cheesecake_TotalLabel.TabIndex = 51
        Assorted_Cheesecake_TotalLabel.Text = "Assorted Cheesecake Total:"
        AddHandler Assorted_Cheesecake_TotalLabel.Click, AddressOf Me.Assorted_Cheesecake_TotalLabel_Click
        '
        'Pecan_Truffle_Tart_TotalLabel
        '
        Pecan_Truffle_Tart_TotalLabel.AutoSize = True
        Pecan_Truffle_Tart_TotalLabel.Location = New System.Drawing.Point(343, 159)
        Pecan_Truffle_Tart_TotalLabel.Name = "Pecan_Truffle_Tart_TotalLabel"
        Pecan_Truffle_Tart_TotalLabel.Size = New System.Drawing.Size(123, 13)
        Pecan_Truffle_Tart_TotalLabel.TabIndex = 53
        Pecan_Truffle_Tart_TotalLabel.Text = "Pecan Truffle Tart Total:"
        AddHandler Pecan_Truffle_Tart_TotalLabel.Click, AddressOf Me.Pecan_Truffle_Tart_TotalLabel_Click
        '
        'Ganache_Tart_TotalLabel
        '
        Ganache_Tart_TotalLabel.AutoSize = True
        Ganache_Tart_TotalLabel.Location = New System.Drawing.Point(343, 185)
        Ganache_Tart_TotalLabel.Name = "Ganache_Tart_TotalLabel"
        Ganache_Tart_TotalLabel.Size = New System.Drawing.Size(103, 13)
        Ganache_Tart_TotalLabel.TabIndex = 55
        Ganache_Tart_TotalLabel.Text = "Ganache Tart Total:"
        AddHandler Ganache_Tart_TotalLabel.Click, AddressOf Me.Ganache_Tart_TotalLabel_Click
        '
        'Mini_Chocolate_Mousse_Cups_TotalLabel
        '
        Mini_Chocolate_Mousse_Cups_TotalLabel.AutoSize = True
        Mini_Chocolate_Mousse_Cups_TotalLabel.Location = New System.Drawing.Point(343, 211)
        Mini_Chocolate_Mousse_Cups_TotalLabel.Name = "Mini_Chocolate_Mousse_Cups_TotalLabel"
        Mini_Chocolate_Mousse_Cups_TotalLabel.Size = New System.Drawing.Size(174, 13)
        Mini_Chocolate_Mousse_Cups_TotalLabel.TabIndex = 57
        Mini_Chocolate_Mousse_Cups_TotalLabel.Text = "Mini Chocolate Mousse Cups Total:"
        AddHandler Mini_Chocolate_Mousse_Cups_TotalLabel.Click, AddressOf Me.Mini_Chocolate_Mousse_Cups_TotalLabel_Click
        '
        'Assorted_Mini_Pastry_Package_TotalLabel
        '
        Assorted_Mini_Pastry_Package_TotalLabel.AutoSize = True
        Assorted_Mini_Pastry_Package_TotalLabel.Location = New System.Drawing.Point(343, 237)
        Assorted_Mini_Pastry_Package_TotalLabel.Name = "Assorted_Mini_Pastry_Package_TotalLabel"
        Assorted_Mini_Pastry_Package_TotalLabel.Size = New System.Drawing.Size(178, 13)
        Assorted_Mini_Pastry_Package_TotalLabel.TabIndex = 59
        Assorted_Mini_Pastry_Package_TotalLabel.Text = "Assorted Mini Pastry Package Total:"
        AddHandler Assorted_Mini_Pastry_Package_TotalLabel.Click, AddressOf Me.Assorted_Mini_Pastry_Package_TotalLabel_Click
        '
        'Mini_Pastry_Total_PriceLabel
        '
        Mini_Pastry_Total_PriceLabel.AutoSize = True
        Mini_Pastry_Total_PriceLabel.Location = New System.Drawing.Point(289, 356)
        Mini_Pastry_Total_PriceLabel.Name = "Mini_Pastry_Total_PriceLabel"
        Mini_Pastry_Total_PriceLabel.Size = New System.Drawing.Size(115, 13)
        Mini_Pastry_Total_PriceLabel.TabIndex = 63
        Mini_Pastry_Total_PriceLabel.Text = "Mini Pastry Total Price:"
        AddHandler Mini_Pastry_Total_PriceLabel.Click, AddressOf Me.Mini_Pastry_Total_PriceLabel_Click
        '
        'Mini_Bars_TotalLabel
        '
        Mini_Bars_TotalLabel.AutoSize = True
        Mini_Bars_TotalLabel.Location = New System.Drawing.Point(343, 594)
        Mini_Bars_TotalLabel.Name = "Mini_Bars_TotalLabel"
        Mini_Bars_TotalLabel.Size = New System.Drawing.Size(80, 13)
        Mini_Bars_TotalLabel.TabIndex = 91
        Mini_Bars_TotalLabel.Text = "Mini Bars Total:"
        AddHandler Mini_Bars_TotalLabel.Click, AddressOf Me.Mini_Bars_TotalLabel_Click
        '
        'Mini_Bar_Total_PriceLabel
        '
        Mini_Bar_Total_PriceLabel.AutoSize = True
        Mini_Bar_Total_PriceLabel.Location = New System.Drawing.Point(289, 688)
        Mini_Bar_Total_PriceLabel.Name = "Mini_Bar_Total_PriceLabel"
        Mini_Bar_Total_PriceLabel.Size = New System.Drawing.Size(102, 13)
        Mini_Bar_Total_PriceLabel.TabIndex = 93
        Mini_Bar_Total_PriceLabel.Text = "Mini Bar Total Price:"
        AddHandler Mini_Bar_Total_PriceLabel.Click, AddressOf Me.Mini_Bar_Total_PriceLabel_Click
        '
        'Cookie_DozenLabel
        '
        Cookie_DozenLabel.AutoSize = True
        Cookie_DozenLabel.Location = New System.Drawing.Point(206, 878)
        Cookie_DozenLabel.Name = "Cookie_DozenLabel"
        Cookie_DozenLabel.Size = New System.Drawing.Size(77, 13)
        Cookie_DozenLabel.TabIndex = 103
        Cookie_DozenLabel.Text = "Cookie Dozen:"
        AddHandler Cookie_DozenLabel.Click, AddressOf Me.Cookie_DozenLabel_Click
        '
        'Cookie_TotalLabel
        '
        Cookie_TotalLabel.AutoSize = True
        Cookie_TotalLabel.Location = New System.Drawing.Point(206, 904)
        Cookie_TotalLabel.Name = "Cookie_TotalLabel"
        Cookie_TotalLabel.Size = New System.Drawing.Size(97, 13)
        Cookie_TotalLabel.TabIndex = 105
        Cookie_TotalLabel.Text = "Cookie Total Price:"
        AddHandler Cookie_TotalLabel.Click, AddressOf Me.Cookie_TotalLabel_Click
        '
        'Platter_or_BoxLabel
        '
        Platter_or_BoxLabel.AutoSize = True
        Platter_or_BoxLabel.Location = New System.Drawing.Point(26, 979)
        Platter_or_BoxLabel.Name = "Platter_or_BoxLabel"
        Platter_or_BoxLabel.Size = New System.Drawing.Size(73, 13)
        Platter_or_BoxLabel.TabIndex = 107
        Platter_or_BoxLabel.Text = "Platter or Box:"
        AddHandler Platter_or_BoxLabel.Click, AddressOf Me.Platter_or_BoxLabel_Click
        '
        'Order_DescriptionLabel
        '
        Order_DescriptionLabel.AutoSize = True
        Order_DescriptionLabel.Location = New System.Drawing.Point(26, 1006)
        Order_DescriptionLabel.Name = "Order_DescriptionLabel"
        Order_DescriptionLabel.Size = New System.Drawing.Size(92, 13)
        Order_DescriptionLabel.TabIndex = 109
        Order_DescriptionLabel.Text = "Order Description:"
        AddHandler Order_DescriptionLabel.Click, AddressOf Me.Order_DescriptionLabel_Click
        '
        'Order_MessageLabel
        '
        Order_MessageLabel.AutoSize = True
        Order_MessageLabel.Location = New System.Drawing.Point(26, 1032)
        Order_MessageLabel.Name = "Order_MessageLabel"
        Order_MessageLabel.Size = New System.Drawing.Size(82, 13)
        Order_MessageLabel.TabIndex = 111
        Order_MessageLabel.Text = "Order Message:"
        AddHandler Order_MessageLabel.Click, AddressOf Me.Order_MessageLabel_Click
        '
        'Item_1Label
        '
        Item_1Label.AutoSize = True
        Item_1Label.Location = New System.Drawing.Point(32, 1081)
        Item_1Label.Name = "Item_1Label"
        Item_1Label.Size = New System.Drawing.Size(39, 13)
        Item_1Label.TabIndex = 113
        Item_1Label.Text = "Item 1:"
        AddHandler Item_1Label.Click, AddressOf Me.Item_1Label_Click
        '
        'Item_2Label
        '
        Item_2Label.AutoSize = True
        Item_2Label.Location = New System.Drawing.Point(32, 1107)
        Item_2Label.Name = "Item_2Label"
        Item_2Label.Size = New System.Drawing.Size(39, 13)
        Item_2Label.TabIndex = 115
        Item_2Label.Text = "Item 2:"
        AddHandler Item_2Label.Click, AddressOf Me.Item_2Label_Click
        '
        'Item_3Label
        '
        Item_3Label.AutoSize = True
        Item_3Label.Location = New System.Drawing.Point(32, 1133)
        Item_3Label.Name = "Item_3Label"
        Item_3Label.Size = New System.Drawing.Size(39, 13)
        Item_3Label.TabIndex = 117
        Item_3Label.Text = "Item 3:"
        AddHandler Item_3Label.Click, AddressOf Me.Item_3Label_Click
        '
        'Item_4Label
        '
        Item_4Label.AutoSize = True
        Item_4Label.Location = New System.Drawing.Point(32, 1159)
        Item_4Label.Name = "Item_4Label"
        Item_4Label.Size = New System.Drawing.Size(39, 13)
        Item_4Label.TabIndex = 119
        Item_4Label.Text = "Item 4:"
        AddHandler Item_4Label.Click, AddressOf Me.Item_4Label_Click
        '
        'Item_5Label
        '
        Item_5Label.AutoSize = True
        Item_5Label.Location = New System.Drawing.Point(32, 1185)
        Item_5Label.Name = "Item_5Label"
        Item_5Label.Size = New System.Drawing.Size(39, 13)
        Item_5Label.TabIndex = 121
        Item_5Label.Text = "Item 5:"
        AddHandler Item_5Label.Click, AddressOf Me.Item_5Label_Click
        '
        'Item_Price_1Label
        '
        Item_Price_1Label.AutoSize = True
        Item_Price_1Label.Location = New System.Drawing.Point(349, 1081)
        Item_Price_1Label.Name = "Item_Price_1Label"
        Item_Price_1Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_1Label.TabIndex = 123
        Item_Price_1Label.Text = "Item Price 1:"
        AddHandler Item_Price_1Label.Click, AddressOf Me.Item_Price_1Label_Click
        '
        'Item_Price_2Label
        '
        Item_Price_2Label.AutoSize = True
        Item_Price_2Label.Location = New System.Drawing.Point(349, 1107)
        Item_Price_2Label.Name = "Item_Price_2Label"
        Item_Price_2Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_2Label.TabIndex = 125
        Item_Price_2Label.Text = "Item Price 2:"
        AddHandler Item_Price_2Label.Click, AddressOf Me.Item_Price_2Label_Click
        '
        'Item_Price_3Label
        '
        Item_Price_3Label.AutoSize = True
        Item_Price_3Label.Location = New System.Drawing.Point(349, 1133)
        Item_Price_3Label.Name = "Item_Price_3Label"
        Item_Price_3Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_3Label.TabIndex = 127
        Item_Price_3Label.Text = "Item Price 3:"
        AddHandler Item_Price_3Label.Click, AddressOf Me.Item_Price_3Label_Click
        '
        'Item_Price_4Label
        '
        Item_Price_4Label.AutoSize = True
        Item_Price_4Label.Location = New System.Drawing.Point(349, 1159)
        Item_Price_4Label.Name = "Item_Price_4Label"
        Item_Price_4Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_4Label.TabIndex = 129
        Item_Price_4Label.Text = "Item Price 4:"
        AddHandler Item_Price_4Label.Click, AddressOf Me.Item_Price_4Label_Click
        '
        'Item_Price_5Label
        '
        Item_Price_5Label.AutoSize = True
        Item_Price_5Label.Location = New System.Drawing.Point(349, 1185)
        Item_Price_5Label.Name = "Item_Price_5Label"
        Item_Price_5Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_5Label.TabIndex = 131
        Item_Price_5Label.Text = "Item Price 5:"
        AddHandler Item_Price_5Label.Click, AddressOf Me.Item_Price_5Label_Click
        '
        'Order_SummaryLabel
        '
        Order_SummaryLabel.AutoSize = True
        Order_SummaryLabel.Location = New System.Drawing.Point(26, 1273)
        Order_SummaryLabel.Name = "Order_SummaryLabel"
        Order_SummaryLabel.Size = New System.Drawing.Size(82, 13)
        Order_SummaryLabel.TabIndex = 133
        Order_SummaryLabel.Text = "Order Summary:"
        AddHandler Order_SummaryLabel.Click, AddressOf Me.Order_SummaryLabel_Click
        '
        'Grand_TotalLabel
        '
        Grand_TotalLabel.AutoSize = True
        Grand_TotalLabel.Location = New System.Drawing.Point(26, 1308)
        Grand_TotalLabel.Name = "Grand_TotalLabel"
        Grand_TotalLabel.Size = New System.Drawing.Size(66, 13)
        Grand_TotalLabel.TabIndex = 135
        Grand_TotalLabel.Text = "Grand Total:"
        AddHandler Grand_TotalLabel.Click, AddressOf Me.Grand_TotalLabel_Click
        '
        'Order_DepositLabel
        '
        Order_DepositLabel.AutoSize = True
        Order_DepositLabel.Location = New System.Drawing.Point(349, 1308)
        Order_DepositLabel.Name = "Order_DepositLabel"
        Order_DepositLabel.Size = New System.Drawing.Size(75, 13)
        Order_DepositLabel.TabIndex = 137
        Order_DepositLabel.Text = "Order Deposit:"
        AddHandler Order_DepositLabel.Click, AddressOf Me.Order_DepositLabel_Click
        '
        'Order_BalanceLabel
        '
        Order_BalanceLabel.AutoSize = True
        Order_BalanceLabel.Location = New System.Drawing.Point(26, 1338)
        Order_BalanceLabel.Name = "Order_BalanceLabel"
        Order_BalanceLabel.Size = New System.Drawing.Size(78, 13)
        Order_BalanceLabel.TabIndex = 139
        Order_BalanceLabel.Text = "Order Balance:"
        AddHandler Order_BalanceLabel.Click, AddressOf Me.Order_BalanceLabel_Click
        '
        'Chocolate_Chip_TotalLabel
        '
        Chocolate_Chip_TotalLabel.AutoSize = True
        Chocolate_Chip_TotalLabel.Location = New System.Drawing.Point(26, 815)
        Chocolate_Chip_TotalLabel.Name = "Chocolate_Chip_TotalLabel"
        Chocolate_Chip_TotalLabel.Size = New System.Drawing.Size(109, 13)
        Chocolate_Chip_TotalLabel.TabIndex = 143
        Chocolate_Chip_TotalLabel.Text = "Chocolate Chip Total:"
        AddHandler Chocolate_Chip_TotalLabel.Click, AddressOf Me.Chocolate_Chip_TotalLabel_Click
        '
        'Sugar_TotalLabel
        '
        Sugar_TotalLabel.AutoSize = True
        Sugar_TotalLabel.Location = New System.Drawing.Point(26, 841)
        Sugar_TotalLabel.Name = "Sugar_TotalLabel"
        Sugar_TotalLabel.Size = New System.Drawing.Size(65, 13)
        Sugar_TotalLabel.TabIndex = 145
        Sugar_TotalLabel.Text = "Sugar Total:"
        AddHandler Sugar_TotalLabel.Click, AddressOf Me.Sugar_TotalLabel_Click
        '
        'Double_Chocolate_Chip_TotalLabel
        '
        Double_Chocolate_Chip_TotalLabel.AutoSize = True
        Double_Chocolate_Chip_TotalLabel.Location = New System.Drawing.Point(343, 815)
        Double_Chocolate_Chip_TotalLabel.Name = "Double_Chocolate_Chip_TotalLabel"
        Double_Chocolate_Chip_TotalLabel.Size = New System.Drawing.Size(146, 13)
        Double_Chocolate_Chip_TotalLabel.TabIndex = 147
        Double_Chocolate_Chip_TotalLabel.Text = "Double Chocolate Chip Total:"
        AddHandler Double_Chocolate_Chip_TotalLabel.Click, AddressOf Me.Double_Chocolate_Chip_TotalLabel_Click
        '
        'Oatmeal_Raisin_TotalLabel
        '
        Oatmeal_Raisin_TotalLabel.AutoSize = True
        Oatmeal_Raisin_TotalLabel.Location = New System.Drawing.Point(343, 841)
        Oatmeal_Raisin_TotalLabel.Name = "Oatmeal_Raisin_TotalLabel"
        Oatmeal_Raisin_TotalLabel.Size = New System.Drawing.Size(108, 13)
        Oatmeal_Raisin_TotalLabel.TabIndex = 149
        Oatmeal_Raisin_TotalLabel.Text = "Oatmeal Raisin Total:"
        AddHandler Oatmeal_Raisin_TotalLabel.Click, AddressOf Me.Oatmeal_Raisin_TotalLabel_Click
        '
        'Lemon_TotalLabel
        '
        Lemon_TotalLabel.AutoSize = True
        Lemon_TotalLabel.Location = New System.Drawing.Point(20, 464)
        Lemon_TotalLabel.Name = "Lemon_TotalLabel"
        Lemon_TotalLabel.Size = New System.Drawing.Size(69, 13)
        Lemon_TotalLabel.TabIndex = 151
        Lemon_TotalLabel.Text = "Lemon Total:"
        AddHandler Lemon_TotalLabel.Click, AddressOf Me.Lemon_TotalLabel_Click
        '
        'Pecan_TotalLabel
        '
        Pecan_TotalLabel.AutoSize = True
        Pecan_TotalLabel.Location = New System.Drawing.Point(20, 490)
        Pecan_TotalLabel.Name = "Pecan_TotalLabel"
        Pecan_TotalLabel.Size = New System.Drawing.Size(68, 13)
        Pecan_TotalLabel.TabIndex = 153
        Pecan_TotalLabel.Text = "Pecan Total:"
        AddHandler Pecan_TotalLabel.Click, AddressOf Me.Pecan_TotalLabel_Click
        '
        'Triple_Berry_Bar_TotalLabel
        '
        Triple_Berry_Bar_TotalLabel.AutoSize = True
        Triple_Berry_Bar_TotalLabel.Location = New System.Drawing.Point(20, 516)
        Triple_Berry_Bar_TotalLabel.Name = "Triple_Berry_Bar_TotalLabel"
        Triple_Berry_Bar_TotalLabel.Size = New System.Drawing.Size(109, 13)
        Triple_Berry_Bar_TotalLabel.TabIndex = 155
        Triple_Berry_Bar_TotalLabel.Text = "Triple Berry Bar Total:"
        AddHandler Triple_Berry_Bar_TotalLabel.Click, AddressOf Me.Triple_Berry_Bar_TotalLabel_Click
        '
        'Tiger_TotalLabel
        '
        Tiger_TotalLabel.AutoSize = True
        Tiger_TotalLabel.Location = New System.Drawing.Point(20, 542)
        Tiger_TotalLabel.Name = "Tiger_TotalLabel"
        Tiger_TotalLabel.Size = New System.Drawing.Size(61, 13)
        Tiger_TotalLabel.TabIndex = 157
        Tiger_TotalLabel.Text = "Tiger Total:"
        AddHandler Tiger_TotalLabel.Click, AddressOf Me.Tiger_TotalLabel_Click
        '
        'Magic_TotalLabel
        '
        Magic_TotalLabel.AutoSize = True
        Magic_TotalLabel.Location = New System.Drawing.Point(20, 568)
        Magic_TotalLabel.Name = "Magic_TotalLabel"
        Magic_TotalLabel.Size = New System.Drawing.Size(66, 13)
        Magic_TotalLabel.TabIndex = 159
        Magic_TotalLabel.Text = "Magic Total:"
        AddHandler Magic_TotalLabel.Click, AddressOf Me.Magic_TotalLabel_Click
        '
        'Classic_Brownie_TotalLabel
        '
        Classic_Brownie_TotalLabel.AutoSize = True
        Classic_Brownie_TotalLabel.Location = New System.Drawing.Point(20, 594)
        Classic_Brownie_TotalLabel.Name = "Classic_Brownie_TotalLabel"
        Classic_Brownie_TotalLabel.Size = New System.Drawing.Size(111, 13)
        Classic_Brownie_TotalLabel.TabIndex = 161
        Classic_Brownie_TotalLabel.Text = "Classic Brownie Total:"
        AddHandler Classic_Brownie_TotalLabel.Click, AddressOf Me.Classic_Brownie_TotalLabel_Click
        '
        'Truffle_Brownie_TotalLabel
        '
        Truffle_Brownie_TotalLabel.AutoSize = True
        Truffle_Brownie_TotalLabel.Location = New System.Drawing.Point(20, 620)
        Truffle_Brownie_TotalLabel.Name = "Truffle_Brownie_TotalLabel"
        Truffle_Brownie_TotalLabel.Size = New System.Drawing.Size(108, 13)
        Truffle_Brownie_TotalLabel.TabIndex = 163
        Truffle_Brownie_TotalLabel.Text = "Truffle Brownie Total:"
        AddHandler Truffle_Brownie_TotalLabel.Click, AddressOf Me.Truffle_Brownie_TotalLabel_Click
        '
        'German_Brownie_TotalLabel
        '
        German_Brownie_TotalLabel.AutoSize = True
        German_Brownie_TotalLabel.Location = New System.Drawing.Point(20, 646)
        German_Brownie_TotalLabel.Name = "German_Brownie_TotalLabel"
        German_Brownie_TotalLabel.Size = New System.Drawing.Size(115, 13)
        German_Brownie_TotalLabel.TabIndex = 165
        German_Brownie_TotalLabel.Text = "German Brownie Total:"
        AddHandler German_Brownie_TotalLabel.Click, AddressOf Me.German_Brownie_TotalLabel_Click
        '
        'Apple_Crisp_TotalLabel
        '
        Apple_Crisp_TotalLabel.AutoSize = True
        Apple_Crisp_TotalLabel.Location = New System.Drawing.Point(343, 464)
        Apple_Crisp_TotalLabel.Name = "Apple_Crisp_TotalLabel"
        Apple_Crisp_TotalLabel.Size = New System.Drawing.Size(90, 13)
        Apple_Crisp_TotalLabel.TabIndex = 167
        Apple_Crisp_TotalLabel.Text = "Apple Crisp Total:"
        AddHandler Apple_Crisp_TotalLabel.Click, AddressOf Me.Apple_Crisp_TotalLabel_Click
        '
        'Date_Bar_TotalLabel
        '
        Date_Bar_TotalLabel.AutoSize = True
        Date_Bar_TotalLabel.Location = New System.Drawing.Point(343, 490)
        Date_Bar_TotalLabel.Name = "Date_Bar_TotalLabel"
        Date_Bar_TotalLabel.Size = New System.Drawing.Size(79, 13)
        Date_Bar_TotalLabel.TabIndex = 169
        Date_Bar_TotalLabel.Text = "Date Bar Total:"
        AddHandler Date_Bar_TotalLabel.Click, AddressOf Me.Date_Bar_TotalLabel_Click
        '
        'Cranberry_Magic_TotalLabel
        '
        Cranberry_Magic_TotalLabel.AutoSize = True
        Cranberry_Magic_TotalLabel.Location = New System.Drawing.Point(343, 516)
        Cranberry_Magic_TotalLabel.Name = "Cranberry_Magic_TotalLabel"
        Cranberry_Magic_TotalLabel.Size = New System.Drawing.Size(114, 13)
        Cranberry_Magic_TotalLabel.TabIndex = 171
        Cranberry_Magic_TotalLabel.Text = "Cranberry Magic Total:"
        AddHandler Cranberry_Magic_TotalLabel.Click, AddressOf Me.Cranberry_Magic_TotalLabel_Click
        '
        'Pumpkin_TotalLabel
        '
        Pumpkin_TotalLabel.AutoSize = True
        Pumpkin_TotalLabel.Location = New System.Drawing.Point(343, 542)
        Pumpkin_TotalLabel.Name = "Pumpkin_TotalLabel"
        Pumpkin_TotalLabel.Size = New System.Drawing.Size(78, 13)
        Pumpkin_TotalLabel.TabIndex = 173
        Pumpkin_TotalLabel.Text = "Pumpkin Total:"
        AddHandler Pumpkin_TotalLabel.Click, AddressOf Me.Pumpkin_TotalLabel_Click
        '
        'Mini_Bar_Package_TotalLabel
        '
        Mini_Bar_Package_TotalLabel.AutoSize = True
        Mini_Bar_Package_TotalLabel.Location = New System.Drawing.Point(343, 568)
        Mini_Bar_Package_TotalLabel.Name = "Mini_Bar_Package_TotalLabel"
        Mini_Bar_Package_TotalLabel.Size = New System.Drawing.Size(121, 13)
        Mini_Bar_Package_TotalLabel.TabIndex = 175
        Mini_Bar_Package_TotalLabel.Text = "Mini Bar Package Total:"
        AddHandler Mini_Bar_Package_TotalLabel.Click, AddressOf Me.Mini_Bar_Package_TotalLabel_Click
        '
        'Order_StatusLabel
        '
        Order_StatusLabel.AutoSize = True
        Order_StatusLabel.Location = New System.Drawing.Point(349, 1339)
        Order_StatusLabel.Name = "Order_StatusLabel"
        Order_StatusLabel.Size = New System.Drawing.Size(69, 13)
        Order_StatusLabel.TabIndex = 179
        Order_StatusLabel.Text = "Order Status:"
        AddHandler Order_StatusLabel.Click, AddressOf Me.Order_StatusLabel_Click
        '
        'Mousse_FlavorLabel
        '
        Mousse_FlavorLabel.AutoSize = True
        Mousse_FlavorLabel.Location = New System.Drawing.Point(343, 266)
        Mousse_FlavorLabel.Name = "Mousse_FlavorLabel"
        Mousse_FlavorLabel.Size = New System.Drawing.Size(79, 13)
        Mousse_FlavorLabel.TabIndex = 186
        Mousse_FlavorLabel.Text = "Mousse Flavor:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(20, 17)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 187
        IDLabel.Text = "ID:"
        '
        'Holiday_NumberLabel
        '
        Holiday_NumberLabel.AutoSize = True
        Holiday_NumberLabel.Location = New System.Drawing.Point(343, 41)
        Holiday_NumberLabel.Name = "Holiday_NumberLabel"
        Holiday_NumberLabel.Size = New System.Drawing.Size(85, 13)
        Holiday_NumberLabel.TabIndex = 188
        Holiday_NumberLabel.Text = "Holiday Number:"
        '
        'Order_Taken_ByTextBox
        '
        Me.Order_Taken_ByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Taken_By", True))
        Me.Order_Taken_ByTextBox.Location = New System.Drawing.Point(167, 38)
        Me.Order_Taken_ByTextBox.Name = "Order_Taken_ByTextBox"
        Me.Order_Taken_ByTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Order_Taken_ByTextBox.TabIndex = 2
        '
        'MINI_PASTRY_ORDERSBindingSource
        '
        Me.MINI_PASTRY_ORDERSBindingSource.DataMember = "MINI_PASTRY_ORDERS"
        Me.MINI_PASTRY_ORDERSBindingSource.DataSource = Me.Bakery_OrdersDataSet
        '
        'Bakery_OrdersDataSet
        '
        Me.Bakery_OrdersDataSet.DataSetName = "Bakery_OrdersDataSet"
        Me.Bakery_OrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Customer_Name", True))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(167, 64)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Customer_NameTextBox.TabIndex = 4
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Phone_Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(524, 14)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.ReadOnly = True
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Phone_NumberTextBox.TabIndex = 6
        '
        'Order_DateDateTimePicker
        '
        Me.Order_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Date", True))
        Me.Order_DateDateTimePicker.Location = New System.Drawing.Point(524, 66)
        Me.Order_DateDateTimePicker.Name = "Order_DateDateTimePicker"
        Me.Order_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Order_DateDateTimePicker.TabIndex = 10
        '
        'Mini_Cannoli_TotalTextBox
        '
        Me.Mini_Cannoli_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Cannoli_Total", True))
        Me.Mini_Cannoli_TotalTextBox.Location = New System.Drawing.Point(178, 159)
        Me.Mini_Cannoli_TotalTextBox.Name = "Mini_Cannoli_TotalTextBox"
        Me.Mini_Cannoli_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Mini_Cannoli_TotalTextBox.TabIndex = 40
        '
        'Mini_Eclair_TotalTextBox
        '
        Me.Mini_Eclair_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Eclair_Total", True))
        Me.Mini_Eclair_TotalTextBox.Location = New System.Drawing.Point(178, 185)
        Me.Mini_Eclair_TotalTextBox.Name = "Mini_Eclair_TotalTextBox"
        Me.Mini_Eclair_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Mini_Eclair_TotalTextBox.TabIndex = 42
        '
        'Mini_Cream_Puff_TotalTextBox
        '
        Me.Mini_Cream_Puff_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Cream_Puff_Total", True))
        Me.Mini_Cream_Puff_TotalTextBox.Location = New System.Drawing.Point(178, 211)
        Me.Mini_Cream_Puff_TotalTextBox.Name = "Mini_Cream_Puff_TotalTextBox"
        Me.Mini_Cream_Puff_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Mini_Cream_Puff_TotalTextBox.TabIndex = 44
        '
        'Mini_Key_Lime_Tart_TotalTextBox
        '
        Me.Mini_Key_Lime_Tart_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Key_Lime_Tart_Total", True))
        Me.Mini_Key_Lime_Tart_TotalTextBox.Location = New System.Drawing.Point(178, 237)
        Me.Mini_Key_Lime_Tart_TotalTextBox.Name = "Mini_Key_Lime_Tart_TotalTextBox"
        Me.Mini_Key_Lime_Tart_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Mini_Key_Lime_Tart_TotalTextBox.TabIndex = 46
        '
        'Mini_Fruit_Tart_TotalTextBox
        '
        Me.Mini_Fruit_Tart_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Fruit_Tart_Total", True))
        Me.Mini_Fruit_Tart_TotalTextBox.Location = New System.Drawing.Point(178, 263)
        Me.Mini_Fruit_Tart_TotalTextBox.Name = "Mini_Fruit_Tart_TotalTextBox"
        Me.Mini_Fruit_Tart_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Mini_Fruit_Tart_TotalTextBox.TabIndex = 48
        '
        'Mini_Lemon_Curd_Tart_TotalTextBox
        '
        Me.Mini_Lemon_Curd_Tart_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Lemon_Curd_Tart_Total", True))
        Me.Mini_Lemon_Curd_Tart_TotalTextBox.Location = New System.Drawing.Point(178, 289)
        Me.Mini_Lemon_Curd_Tart_TotalTextBox.Name = "Mini_Lemon_Curd_Tart_TotalTextBox"
        Me.Mini_Lemon_Curd_Tart_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Mini_Lemon_Curd_Tart_TotalTextBox.TabIndex = 50
        '
        'Assorted_Cheesecake_TotalTextBox
        '
        Me.Assorted_Cheesecake_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Assorted_Cheesecake_Total", True))
        Me.Assorted_Cheesecake_TotalTextBox.Location = New System.Drawing.Point(178, 315)
        Me.Assorted_Cheesecake_TotalTextBox.Name = "Assorted_Cheesecake_TotalTextBox"
        Me.Assorted_Cheesecake_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Assorted_Cheesecake_TotalTextBox.TabIndex = 52
        '
        'Pecan_Truffle_Tart_TotalTextBox
        '
        Me.Pecan_Truffle_Tart_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Pecan_Truffle_Tart_Total", True))
        Me.Pecan_Truffle_Tart_TotalTextBox.Location = New System.Drawing.Point(524, 159)
        Me.Pecan_Truffle_Tart_TotalTextBox.Name = "Pecan_Truffle_Tart_TotalTextBox"
        Me.Pecan_Truffle_Tart_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pecan_Truffle_Tart_TotalTextBox.TabIndex = 54
        '
        'Ganache_Tart_TotalTextBox
        '
        Me.Ganache_Tart_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Ganache_Tart_Total", True))
        Me.Ganache_Tart_TotalTextBox.Location = New System.Drawing.Point(524, 185)
        Me.Ganache_Tart_TotalTextBox.Name = "Ganache_Tart_TotalTextBox"
        Me.Ganache_Tart_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ganache_Tart_TotalTextBox.TabIndex = 56
        '
        'Mini_Chocolate_Mousse_Cups_TotalTextBox
        '
        Me.Mini_Chocolate_Mousse_Cups_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Chocolate_Mousse_Cups_Total", True))
        Me.Mini_Chocolate_Mousse_Cups_TotalTextBox.Location = New System.Drawing.Point(524, 211)
        Me.Mini_Chocolate_Mousse_Cups_TotalTextBox.Name = "Mini_Chocolate_Mousse_Cups_TotalTextBox"
        Me.Mini_Chocolate_Mousse_Cups_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mini_Chocolate_Mousse_Cups_TotalTextBox.TabIndex = 58
        '
        'Assorted_Mini_Pastry_Package_TotalTextBox
        '
        Me.Assorted_Mini_Pastry_Package_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Assorted_Mini_Pastry_Package_Total", True))
        Me.Assorted_Mini_Pastry_Package_TotalTextBox.Location = New System.Drawing.Point(524, 237)
        Me.Assorted_Mini_Pastry_Package_TotalTextBox.Name = "Assorted_Mini_Pastry_Package_TotalTextBox"
        Me.Assorted_Mini_Pastry_Package_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Assorted_Mini_Pastry_Package_TotalTextBox.TabIndex = 60
        '
        'Mini_Pastry_Total_PriceTextBox
        '
        Me.Mini_Pastry_Total_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Pastry_Total_Price", True))
        Me.Mini_Pastry_Total_PriceTextBox.Location = New System.Drawing.Point(473, 353)
        Me.Mini_Pastry_Total_PriceTextBox.Name = "Mini_Pastry_Total_PriceTextBox"
        Me.Mini_Pastry_Total_PriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mini_Pastry_Total_PriceTextBox.TabIndex = 64
        '
        'Mini_Bars_TotalTextBox
        '
        Me.Mini_Bars_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Bars_Total", True))
        Me.Mini_Bars_TotalTextBox.Location = New System.Drawing.Point(524, 591)
        Me.Mini_Bars_TotalTextBox.Name = "Mini_Bars_TotalTextBox"
        Me.Mini_Bars_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mini_Bars_TotalTextBox.TabIndex = 92
        '
        'Mini_Bar_Total_PriceTextBox
        '
        Me.Mini_Bar_Total_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Bar_Total_Price", True))
        Me.Mini_Bar_Total_PriceTextBox.Location = New System.Drawing.Point(473, 685)
        Me.Mini_Bar_Total_PriceTextBox.Name = "Mini_Bar_Total_PriceTextBox"
        Me.Mini_Bar_Total_PriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mini_Bar_Total_PriceTextBox.TabIndex = 94
        '
        'Cookie_DozenTextBox
        '
        Me.Cookie_DozenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Cookie_Dozen", True))
        Me.Cookie_DozenTextBox.Location = New System.Drawing.Point(390, 875)
        Me.Cookie_DozenTextBox.Name = "Cookie_DozenTextBox"
        Me.Cookie_DozenTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cookie_DozenTextBox.TabIndex = 104
        '
        'Cookie_TotalTextBox
        '
        Me.Cookie_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Cookie_Total", True))
        Me.Cookie_TotalTextBox.Location = New System.Drawing.Point(390, 901)
        Me.Cookie_TotalTextBox.Name = "Cookie_TotalTextBox"
        Me.Cookie_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cookie_TotalTextBox.TabIndex = 106
        '
        'Platter_or_BoxComboBox
        '
        Me.Platter_or_BoxComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Platter_or_Box", True))
        Me.Platter_or_BoxComboBox.FormattingEnabled = True
        Me.Platter_or_BoxComboBox.Items.AddRange(New Object() {"Platter or Box"})
        Me.Platter_or_BoxComboBox.Location = New System.Drawing.Point(178, 976)
        Me.Platter_or_BoxComboBox.Name = "Platter_or_BoxComboBox"
        Me.Platter_or_BoxComboBox.Size = New System.Drawing.Size(145, 21)
        Me.Platter_or_BoxComboBox.TabIndex = 108
        '
        'Order_DescriptionTextBox
        '
        Me.Order_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Description", True))
        Me.Order_DescriptionTextBox.Location = New System.Drawing.Point(178, 1003)
        Me.Order_DescriptionTextBox.Name = "Order_DescriptionTextBox"
        Me.Order_DescriptionTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Order_DescriptionTextBox.TabIndex = 110
        '
        'Order_MessageTextBox
        '
        Me.Order_MessageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Message", True))
        Me.Order_MessageTextBox.Location = New System.Drawing.Point(178, 1029)
        Me.Order_MessageTextBox.Multiline = True
        Me.Order_MessageTextBox.Name = "Order_MessageTextBox"
        Me.Order_MessageTextBox.Size = New System.Drawing.Size(552, 41)
        Me.Order_MessageTextBox.TabIndex = 112
        '
        'Item_1TextBox
        '
        Me.Item_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_1", True))
        Me.Item_1TextBox.Location = New System.Drawing.Point(184, 1078)
        Me.Item_1TextBox.Name = "Item_1TextBox"
        Me.Item_1TextBox.Size = New System.Drawing.Size(145, 20)
        Me.Item_1TextBox.TabIndex = 114
        '
        'Item_2TextBox
        '
        Me.Item_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_2", True))
        Me.Item_2TextBox.Location = New System.Drawing.Point(184, 1104)
        Me.Item_2TextBox.Name = "Item_2TextBox"
        Me.Item_2TextBox.Size = New System.Drawing.Size(145, 20)
        Me.Item_2TextBox.TabIndex = 116
        '
        'Item_3TextBox
        '
        Me.Item_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_3", True))
        Me.Item_3TextBox.Location = New System.Drawing.Point(184, 1130)
        Me.Item_3TextBox.Name = "Item_3TextBox"
        Me.Item_3TextBox.Size = New System.Drawing.Size(145, 20)
        Me.Item_3TextBox.TabIndex = 118
        '
        'Item_4TextBox
        '
        Me.Item_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_4", True))
        Me.Item_4TextBox.Location = New System.Drawing.Point(184, 1156)
        Me.Item_4TextBox.Name = "Item_4TextBox"
        Me.Item_4TextBox.Size = New System.Drawing.Size(145, 20)
        Me.Item_4TextBox.TabIndex = 120
        '
        'Item_5TextBox
        '
        Me.Item_5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_5", True))
        Me.Item_5TextBox.Location = New System.Drawing.Point(184, 1182)
        Me.Item_5TextBox.Name = "Item_5TextBox"
        Me.Item_5TextBox.Size = New System.Drawing.Size(145, 20)
        Me.Item_5TextBox.TabIndex = 122
        '
        'Item_Price_1TextBox
        '
        Me.Item_Price_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_1", True))
        Me.Item_Price_1TextBox.Location = New System.Drawing.Point(530, 1078)
        Me.Item_Price_1TextBox.Name = "Item_Price_1TextBox"
        Me.Item_Price_1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Item_Price_1TextBox.TabIndex = 124
        '
        'Item_Price_2TextBox
        '
        Me.Item_Price_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_2", True))
        Me.Item_Price_2TextBox.Location = New System.Drawing.Point(530, 1104)
        Me.Item_Price_2TextBox.Name = "Item_Price_2TextBox"
        Me.Item_Price_2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Item_Price_2TextBox.TabIndex = 126
        '
        'Item_Price_3TextBox
        '
        Me.Item_Price_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_3", True))
        Me.Item_Price_3TextBox.Location = New System.Drawing.Point(530, 1130)
        Me.Item_Price_3TextBox.Name = "Item_Price_3TextBox"
        Me.Item_Price_3TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Item_Price_3TextBox.TabIndex = 128
        '
        'Item_Price_4TextBox
        '
        Me.Item_Price_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_4", True))
        Me.Item_Price_4TextBox.Location = New System.Drawing.Point(530, 1156)
        Me.Item_Price_4TextBox.Name = "Item_Price_4TextBox"
        Me.Item_Price_4TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Item_Price_4TextBox.TabIndex = 130
        '
        'Item_Price_5TextBox
        '
        Me.Item_Price_5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_5", True))
        Me.Item_Price_5TextBox.Location = New System.Drawing.Point(530, 1182)
        Me.Item_Price_5TextBox.Name = "Item_Price_5TextBox"
        Me.Item_Price_5TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Item_Price_5TextBox.TabIndex = 132
        '
        'Order_SummaryTextBox
        '
        Me.Order_SummaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Summary", True))
        Me.Order_SummaryTextBox.Location = New System.Drawing.Point(184, 1270)
        Me.Order_SummaryTextBox.Multiline = True
        Me.Order_SummaryTextBox.Name = "Order_SummaryTextBox"
        Me.Order_SummaryTextBox.Size = New System.Drawing.Size(546, 29)
        Me.Order_SummaryTextBox.TabIndex = 134
        '
        'Grand_TotalTextBox
        '
        Me.Grand_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Grand_Total", True))
        Me.Grand_TotalTextBox.Location = New System.Drawing.Point(184, 1305)
        Me.Grand_TotalTextBox.Name = "Grand_TotalTextBox"
        Me.Grand_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Grand_TotalTextBox.TabIndex = 136
        '
        'Order_DepositTextBox
        '
        Me.Order_DepositTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Deposit", True))
        Me.Order_DepositTextBox.Location = New System.Drawing.Point(530, 1301)
        Me.Order_DepositTextBox.Name = "Order_DepositTextBox"
        Me.Order_DepositTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Order_DepositTextBox.TabIndex = 138
        '
        'Order_BalanceTextBox
        '
        Me.Order_BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Balance", True))
        Me.Order_BalanceTextBox.Location = New System.Drawing.Point(184, 1335)
        Me.Order_BalanceTextBox.Name = "Order_BalanceTextBox"
        Me.Order_BalanceTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Order_BalanceTextBox.TabIndex = 140
        '
        'Chocolate_Chip_TotalTextBox
        '
        Me.Chocolate_Chip_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Chocolate_Chip_Total", True))
        Me.Chocolate_Chip_TotalTextBox.Location = New System.Drawing.Point(178, 812)
        Me.Chocolate_Chip_TotalTextBox.Name = "Chocolate_Chip_TotalTextBox"
        Me.Chocolate_Chip_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Chocolate_Chip_TotalTextBox.TabIndex = 144
        '
        'Sugar_TotalTextBox
        '
        Me.Sugar_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Sugar_Total", True))
        Me.Sugar_TotalTextBox.Location = New System.Drawing.Point(178, 838)
        Me.Sugar_TotalTextBox.Name = "Sugar_TotalTextBox"
        Me.Sugar_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Sugar_TotalTextBox.TabIndex = 146
        '
        'Double_Chocolate_Chip_TotalTextBox
        '
        Me.Double_Chocolate_Chip_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Double_Chocolate_Chip_Total", True))
        Me.Double_Chocolate_Chip_TotalTextBox.Location = New System.Drawing.Point(524, 812)
        Me.Double_Chocolate_Chip_TotalTextBox.Name = "Double_Chocolate_Chip_TotalTextBox"
        Me.Double_Chocolate_Chip_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Double_Chocolate_Chip_TotalTextBox.TabIndex = 148
        '
        'Oatmeal_Raisin_TotalTextBox
        '
        Me.Oatmeal_Raisin_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Oatmeal_Raisin_Total", True))
        Me.Oatmeal_Raisin_TotalTextBox.Location = New System.Drawing.Point(524, 838)
        Me.Oatmeal_Raisin_TotalTextBox.Name = "Oatmeal_Raisin_TotalTextBox"
        Me.Oatmeal_Raisin_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Oatmeal_Raisin_TotalTextBox.TabIndex = 150
        '
        'Lemon_TotalTextBox
        '
        Me.Lemon_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Lemon_Total", True))
        Me.Lemon_TotalTextBox.Location = New System.Drawing.Point(178, 461)
        Me.Lemon_TotalTextBox.Name = "Lemon_TotalTextBox"
        Me.Lemon_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Lemon_TotalTextBox.TabIndex = 152
        '
        'Pecan_TotalTextBox
        '
        Me.Pecan_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Pecan_Total", True))
        Me.Pecan_TotalTextBox.Location = New System.Drawing.Point(178, 487)
        Me.Pecan_TotalTextBox.Name = "Pecan_TotalTextBox"
        Me.Pecan_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Pecan_TotalTextBox.TabIndex = 154
        '
        'Triple_Berry_Bar_TotalTextBox
        '
        Me.Triple_Berry_Bar_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Triple_Berry_Bar_Total", True))
        Me.Triple_Berry_Bar_TotalTextBox.Location = New System.Drawing.Point(178, 513)
        Me.Triple_Berry_Bar_TotalTextBox.Name = "Triple_Berry_Bar_TotalTextBox"
        Me.Triple_Berry_Bar_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Triple_Berry_Bar_TotalTextBox.TabIndex = 156
        '
        'Tiger_TotalTextBox
        '
        Me.Tiger_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Tiger_Total", True))
        Me.Tiger_TotalTextBox.Location = New System.Drawing.Point(178, 539)
        Me.Tiger_TotalTextBox.Name = "Tiger_TotalTextBox"
        Me.Tiger_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Tiger_TotalTextBox.TabIndex = 158
        '
        'Magic_TotalTextBox
        '
        Me.Magic_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Magic_Total", True))
        Me.Magic_TotalTextBox.Location = New System.Drawing.Point(178, 565)
        Me.Magic_TotalTextBox.Name = "Magic_TotalTextBox"
        Me.Magic_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Magic_TotalTextBox.TabIndex = 160
        '
        'Classic_Brownie_TotalTextBox
        '
        Me.Classic_Brownie_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Classic_Brownie_Total", True))
        Me.Classic_Brownie_TotalTextBox.Location = New System.Drawing.Point(178, 591)
        Me.Classic_Brownie_TotalTextBox.Name = "Classic_Brownie_TotalTextBox"
        Me.Classic_Brownie_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Classic_Brownie_TotalTextBox.TabIndex = 162
        '
        'Truffle_Brownie_TotalTextBox
        '
        Me.Truffle_Brownie_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Truffle_Brownie_Total", True))
        Me.Truffle_Brownie_TotalTextBox.Location = New System.Drawing.Point(178, 617)
        Me.Truffle_Brownie_TotalTextBox.Name = "Truffle_Brownie_TotalTextBox"
        Me.Truffle_Brownie_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Truffle_Brownie_TotalTextBox.TabIndex = 164
        '
        'German_Brownie_TotalTextBox
        '
        Me.German_Brownie_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "German_Brownie_Total", True))
        Me.German_Brownie_TotalTextBox.Location = New System.Drawing.Point(178, 643)
        Me.German_Brownie_TotalTextBox.Name = "German_Brownie_TotalTextBox"
        Me.German_Brownie_TotalTextBox.Size = New System.Drawing.Size(145, 20)
        Me.German_Brownie_TotalTextBox.TabIndex = 166
        '
        'Apple_Crisp_TotalTextBox
        '
        Me.Apple_Crisp_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Apple_Crisp_Total", True))
        Me.Apple_Crisp_TotalTextBox.Location = New System.Drawing.Point(524, 461)
        Me.Apple_Crisp_TotalTextBox.Name = "Apple_Crisp_TotalTextBox"
        Me.Apple_Crisp_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Apple_Crisp_TotalTextBox.TabIndex = 168
        '
        'Date_Bar_TotalTextBox
        '
        Me.Date_Bar_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Date_Bar_Total", True))
        Me.Date_Bar_TotalTextBox.Location = New System.Drawing.Point(524, 487)
        Me.Date_Bar_TotalTextBox.Name = "Date_Bar_TotalTextBox"
        Me.Date_Bar_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Date_Bar_TotalTextBox.TabIndex = 170
        '
        'Cranberry_Magic_TotalTextBox
        '
        Me.Cranberry_Magic_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Cranberry_Magic_Total", True))
        Me.Cranberry_Magic_TotalTextBox.Location = New System.Drawing.Point(524, 513)
        Me.Cranberry_Magic_TotalTextBox.Name = "Cranberry_Magic_TotalTextBox"
        Me.Cranberry_Magic_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cranberry_Magic_TotalTextBox.TabIndex = 172
        '
        'Pumpkin_TotalTextBox
        '
        Me.Pumpkin_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Pumpkin_Total", True))
        Me.Pumpkin_TotalTextBox.Location = New System.Drawing.Point(524, 539)
        Me.Pumpkin_TotalTextBox.Name = "Pumpkin_TotalTextBox"
        Me.Pumpkin_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pumpkin_TotalTextBox.TabIndex = 174
        '
        'Mini_Bar_Package_TotalTextBox
        '
        Me.Mini_Bar_Package_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Bar_Package_Total", True))
        Me.Mini_Bar_Package_TotalTextBox.Location = New System.Drawing.Point(524, 565)
        Me.Mini_Bar_Package_TotalTextBox.Name = "Mini_Bar_Package_TotalTextBox"
        Me.Mini_Bar_Package_TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mini_Bar_Package_TotalTextBox.TabIndex = 176
        '
        'Order_StatusTextBox
        '
        Me.Order_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Status", True))
        Me.Order_StatusTextBox.Location = New System.Drawing.Point(530, 1332)
        Me.Order_StatusTextBox.Name = "Order_StatusTextBox"
        Me.Order_StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Order_StatusTextBox.TabIndex = 180
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 33)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Mini Pastries"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 33)
        Me.Label2.TabIndex = 182
        Me.Label2.Text = "Mini Bars"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 741)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 33)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "Mini Cookies"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(331, 932)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 33)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "Items"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(258, 1228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 33)
        Me.Label5.TabIndex = 185
        Me.Label5.Text = "Order Information"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(736, 1270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 81)
        Me.Button1.TabIndex = 186
        Me.Button1.Text = "View/Print Order"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Mousse_FlavorComboBox
        '
        Me.Mousse_FlavorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mousse_Flavor", True))
        Me.Mousse_FlavorComboBox.FormattingEnabled = True
        Me.Mousse_FlavorComboBox.Items.AddRange(New Object() {"Dark Chocolate", "White Chocolate", "Mocha", "Strawberry", "Raspberry", "Orange", "Lemon", "Key Lime", "Peppermint"})
        Me.Mousse_FlavorComboBox.Location = New System.Drawing.Point(524, 263)
        Me.Mousse_FlavorComboBox.Name = "Mousse_FlavorComboBox"
        Me.Mousse_FlavorComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Mousse_FlavorComboBox.TabIndex = 187
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(167, 14)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(145, 20)
        Me.IDTextBox.TabIndex = 188
        '
        'Holiday_NumberTextBox
        '
        Me.Holiday_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Holiday_Number", True))
        Me.Holiday_NumberTextBox.Location = New System.Drawing.Point(524, 38)
        Me.Holiday_NumberTextBox.Name = "Holiday_NumberTextBox"
        Me.Holiday_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Holiday_NumberTextBox.TabIndex = 189
        '
        'MINI_PASTRY_ORDERSTableAdapter
        '
        Me.MINI_PASTRY_ORDERSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_ListTableAdapter = Nothing
        Me.TableAdapterManager.MINI_PASTRY_ORDERSTableAdapter = Me.MINI_PASTRY_ORDERSTableAdapter
        Me.TableAdapterManager.UpdateOrder = Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Edit_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Orchid
        Me.ClientSize = New System.Drawing.Size(942, 989)
        Me.Controls.Add(Holiday_NumberLabel)
        Me.Controls.Add(Me.Holiday_NumberTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Mousse_FlavorLabel)
        Me.Controls.Add(Me.Mousse_FlavorComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Order_Taken_ByLabel)
        Me.Controls.Add(Me.Order_Taken_ByTextBox)
        Me.Controls.Add(Customer_NameLabel)
        Me.Controls.Add(Me.Customer_NameTextBox)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Order_DateLabel)
        Me.Controls.Add(Me.Order_DateDateTimePicker)
        Me.Controls.Add(Mini_Cannoli_TotalLabel)
        Me.Controls.Add(Me.Mini_Cannoli_TotalTextBox)
        Me.Controls.Add(Mini_Eclair_TotalLabel)
        Me.Controls.Add(Me.Mini_Eclair_TotalTextBox)
        Me.Controls.Add(Mini_Cream_Puff_TotalLabel)
        Me.Controls.Add(Me.Mini_Cream_Puff_TotalTextBox)
        Me.Controls.Add(Mini_Key_Lime_Tart_TotalLabel)
        Me.Controls.Add(Me.Mini_Key_Lime_Tart_TotalTextBox)
        Me.Controls.Add(Mini_Fruit_Tart_TotalLabel)
        Me.Controls.Add(Me.Mini_Fruit_Tart_TotalTextBox)
        Me.Controls.Add(Mini_Lemon_Curd_Tart_TotalLabel)
        Me.Controls.Add(Me.Mini_Lemon_Curd_Tart_TotalTextBox)
        Me.Controls.Add(Assorted_Cheesecake_TotalLabel)
        Me.Controls.Add(Me.Assorted_Cheesecake_TotalTextBox)
        Me.Controls.Add(Pecan_Truffle_Tart_TotalLabel)
        Me.Controls.Add(Me.Pecan_Truffle_Tart_TotalTextBox)
        Me.Controls.Add(Ganache_Tart_TotalLabel)
        Me.Controls.Add(Me.Ganache_Tart_TotalTextBox)
        Me.Controls.Add(Mini_Chocolate_Mousse_Cups_TotalLabel)
        Me.Controls.Add(Me.Mini_Chocolate_Mousse_Cups_TotalTextBox)
        Me.Controls.Add(Assorted_Mini_Pastry_Package_TotalLabel)
        Me.Controls.Add(Me.Assorted_Mini_Pastry_Package_TotalTextBox)
        Me.Controls.Add(Mini_Pastry_Total_PriceLabel)
        Me.Controls.Add(Me.Mini_Pastry_Total_PriceTextBox)
        Me.Controls.Add(Mini_Bars_TotalLabel)
        Me.Controls.Add(Me.Mini_Bars_TotalTextBox)
        Me.Controls.Add(Mini_Bar_Total_PriceLabel)
        Me.Controls.Add(Me.Mini_Bar_Total_PriceTextBox)
        Me.Controls.Add(Cookie_DozenLabel)
        Me.Controls.Add(Me.Cookie_DozenTextBox)
        Me.Controls.Add(Cookie_TotalLabel)
        Me.Controls.Add(Me.Cookie_TotalTextBox)
        Me.Controls.Add(Platter_or_BoxLabel)
        Me.Controls.Add(Me.Platter_or_BoxComboBox)
        Me.Controls.Add(Order_DescriptionLabel)
        Me.Controls.Add(Me.Order_DescriptionTextBox)
        Me.Controls.Add(Order_MessageLabel)
        Me.Controls.Add(Me.Order_MessageTextBox)
        Me.Controls.Add(Item_1Label)
        Me.Controls.Add(Me.Item_1TextBox)
        Me.Controls.Add(Item_2Label)
        Me.Controls.Add(Me.Item_2TextBox)
        Me.Controls.Add(Item_3Label)
        Me.Controls.Add(Me.Item_3TextBox)
        Me.Controls.Add(Item_4Label)
        Me.Controls.Add(Me.Item_4TextBox)
        Me.Controls.Add(Item_5Label)
        Me.Controls.Add(Me.Item_5TextBox)
        Me.Controls.Add(Item_Price_1Label)
        Me.Controls.Add(Me.Item_Price_1TextBox)
        Me.Controls.Add(Item_Price_2Label)
        Me.Controls.Add(Me.Item_Price_2TextBox)
        Me.Controls.Add(Item_Price_3Label)
        Me.Controls.Add(Me.Item_Price_3TextBox)
        Me.Controls.Add(Item_Price_4Label)
        Me.Controls.Add(Me.Item_Price_4TextBox)
        Me.Controls.Add(Item_Price_5Label)
        Me.Controls.Add(Me.Item_Price_5TextBox)
        Me.Controls.Add(Order_SummaryLabel)
        Me.Controls.Add(Me.Order_SummaryTextBox)
        Me.Controls.Add(Grand_TotalLabel)
        Me.Controls.Add(Me.Grand_TotalTextBox)
        Me.Controls.Add(Order_DepositLabel)
        Me.Controls.Add(Me.Order_DepositTextBox)
        Me.Controls.Add(Order_BalanceLabel)
        Me.Controls.Add(Me.Order_BalanceTextBox)
        Me.Controls.Add(Chocolate_Chip_TotalLabel)
        Me.Controls.Add(Me.Chocolate_Chip_TotalTextBox)
        Me.Controls.Add(Sugar_TotalLabel)
        Me.Controls.Add(Me.Sugar_TotalTextBox)
        Me.Controls.Add(Double_Chocolate_Chip_TotalLabel)
        Me.Controls.Add(Me.Double_Chocolate_Chip_TotalTextBox)
        Me.Controls.Add(Oatmeal_Raisin_TotalLabel)
        Me.Controls.Add(Me.Oatmeal_Raisin_TotalTextBox)
        Me.Controls.Add(Lemon_TotalLabel)
        Me.Controls.Add(Me.Lemon_TotalTextBox)
        Me.Controls.Add(Pecan_TotalLabel)
        Me.Controls.Add(Me.Pecan_TotalTextBox)
        Me.Controls.Add(Triple_Berry_Bar_TotalLabel)
        Me.Controls.Add(Me.Triple_Berry_Bar_TotalTextBox)
        Me.Controls.Add(Tiger_TotalLabel)
        Me.Controls.Add(Me.Tiger_TotalTextBox)
        Me.Controls.Add(Magic_TotalLabel)
        Me.Controls.Add(Me.Magic_TotalTextBox)
        Me.Controls.Add(Classic_Brownie_TotalLabel)
        Me.Controls.Add(Me.Classic_Brownie_TotalTextBox)
        Me.Controls.Add(Truffle_Brownie_TotalLabel)
        Me.Controls.Add(Me.Truffle_Brownie_TotalTextBox)
        Me.Controls.Add(German_Brownie_TotalLabel)
        Me.Controls.Add(Me.German_Brownie_TotalTextBox)
        Me.Controls.Add(Apple_Crisp_TotalLabel)
        Me.Controls.Add(Me.Apple_Crisp_TotalTextBox)
        Me.Controls.Add(Date_Bar_TotalLabel)
        Me.Controls.Add(Me.Date_Bar_TotalTextBox)
        Me.Controls.Add(Cranberry_Magic_TotalLabel)
        Me.Controls.Add(Me.Cranberry_Magic_TotalTextBox)
        Me.Controls.Add(Pumpkin_TotalLabel)
        Me.Controls.Add(Me.Pumpkin_TotalTextBox)
        Me.Controls.Add(Mini_Bar_Package_TotalLabel)
        Me.Controls.Add(Me.Mini_Bar_Package_TotalTextBox)
        Me.Controls.Add(Order_StatusLabel)
        Me.Controls.Add(Me.Order_StatusTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Edit_Orders"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Orders"
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bakery_OrdersDataSet As Bakery_OrdersDataSet
    Friend WithEvents MINI_PASTRY_ORDERSBindingSource As BindingSource
    Friend WithEvents MINI_PASTRY_ORDERSTableAdapter As Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter
    Friend WithEvents TableAdapterManager As Bakery_OrdersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Order_Taken_ByTextBox As TextBox
    Friend WithEvents Customer_NameTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents Order_DateDateTimePicker As DateTimePicker
    Friend WithEvents Mini_Cannoli_TotalTextBox As TextBox
    Friend WithEvents Mini_Eclair_TotalTextBox As TextBox
    Friend WithEvents Mini_Cream_Puff_TotalTextBox As TextBox
    Friend WithEvents Mini_Key_Lime_Tart_TotalTextBox As TextBox
    Friend WithEvents Mini_Fruit_Tart_TotalTextBox As TextBox
    Friend WithEvents Mini_Lemon_Curd_Tart_TotalTextBox As TextBox
    Friend WithEvents Assorted_Cheesecake_TotalTextBox As TextBox
    Friend WithEvents Pecan_Truffle_Tart_TotalTextBox As TextBox
    Friend WithEvents Ganache_Tart_TotalTextBox As TextBox
    Friend WithEvents Mini_Chocolate_Mousse_Cups_TotalTextBox As TextBox
    Friend WithEvents Assorted_Mini_Pastry_Package_TotalTextBox As TextBox
    Friend WithEvents Mini_Pastry_Total_PriceTextBox As TextBox
    Friend WithEvents Mini_Bars_TotalTextBox As TextBox
    Friend WithEvents Mini_Bar_Total_PriceTextBox As TextBox
    Friend WithEvents Cookie_DozenTextBox As TextBox
    Friend WithEvents Cookie_TotalTextBox As TextBox
    Friend WithEvents Platter_or_BoxComboBox As ComboBox
    Friend WithEvents Order_DescriptionTextBox As TextBox
    Friend WithEvents Order_MessageTextBox As TextBox
    Friend WithEvents Item_1TextBox As TextBox
    Friend WithEvents Item_2TextBox As TextBox
    Friend WithEvents Item_3TextBox As TextBox
    Friend WithEvents Item_4TextBox As TextBox
    Friend WithEvents Item_5TextBox As TextBox
    Friend WithEvents Item_Price_1TextBox As TextBox
    Friend WithEvents Item_Price_2TextBox As TextBox
    Friend WithEvents Item_Price_3TextBox As TextBox
    Friend WithEvents Item_Price_4TextBox As TextBox
    Friend WithEvents Item_Price_5TextBox As TextBox
    Friend WithEvents Order_SummaryTextBox As TextBox
    Friend WithEvents Grand_TotalTextBox As TextBox
    Friend WithEvents Order_DepositTextBox As TextBox
    Friend WithEvents Order_BalanceTextBox As TextBox
    Friend WithEvents Chocolate_Chip_TotalTextBox As TextBox
    Friend WithEvents Sugar_TotalTextBox As TextBox
    Friend WithEvents Double_Chocolate_Chip_TotalTextBox As TextBox
    Friend WithEvents Oatmeal_Raisin_TotalTextBox As TextBox
    Friend WithEvents Lemon_TotalTextBox As TextBox
    Friend WithEvents Pecan_TotalTextBox As TextBox
    Friend WithEvents Triple_Berry_Bar_TotalTextBox As TextBox
    Friend WithEvents Tiger_TotalTextBox As TextBox
    Friend WithEvents Magic_TotalTextBox As TextBox
    Friend WithEvents Classic_Brownie_TotalTextBox As TextBox
    Friend WithEvents Truffle_Brownie_TotalTextBox As TextBox
    Friend WithEvents German_Brownie_TotalTextBox As TextBox
    Friend WithEvents Apple_Crisp_TotalTextBox As TextBox
    Friend WithEvents Date_Bar_TotalTextBox As TextBox
    Friend WithEvents Cranberry_Magic_TotalTextBox As TextBox
    Friend WithEvents Pumpkin_TotalTextBox As TextBox
    Friend WithEvents Mini_Bar_Package_TotalTextBox As TextBox
    Friend WithEvents Order_StatusTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Mousse_FlavorComboBox As ComboBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Holiday_NumberTextBox As TextBox
End Class
