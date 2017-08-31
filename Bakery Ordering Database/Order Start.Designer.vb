<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Mini_BarsLabel As System.Windows.Forms.Label
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
        Dim Order_StatusLabel As System.Windows.Forms.Label
        Me.Order_Taken_ByTextBox = New System.Windows.Forms.TextBox()
        Me.MINI_PASTRY_ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bakery_OrdersDataSet = New Bakery_Ordering_Database.Bakery_OrdersDataSet()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Holiday_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Order_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.MINI_PASTRY_ORDERSTableAdapter = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter()
        Me.TableAdapterManager = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Mini_BarsLabel = New System.Windows.Forms.Label()
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
        Order_StatusLabel = New System.Windows.Forms.Label()
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mini_BarsLabel
        '
        Mini_BarsLabel.AutoSize = True
        Mini_BarsLabel.Location = New System.Drawing.Point(17, 242)
        Mini_BarsLabel.Name = "Mini_BarsLabel"
        Mini_BarsLabel.Size = New System.Drawing.Size(53, 13)
        Mini_BarsLabel.TabIndex = 14
        Mini_BarsLabel.Text = "Mini Bars:"
        '
        'Item_1Label
        '
        Item_1Label.AutoSize = True
        Item_1Label.Location = New System.Drawing.Point(17, 483)
        Item_1Label.Name = "Item_1Label"
        Item_1Label.Size = New System.Drawing.Size(39, 13)
        Item_1Label.TabIndex = 23
        Item_1Label.Text = "Item 1:"
        '
        'Item_2Label
        '
        Item_2Label.AutoSize = True
        Item_2Label.Location = New System.Drawing.Point(17, 505)
        Item_2Label.Name = "Item_2Label"
        Item_2Label.Size = New System.Drawing.Size(39, 13)
        Item_2Label.TabIndex = 25
        Item_2Label.Text = "Item 2:"
        '
        'Item_3Label
        '
        Item_3Label.AutoSize = True
        Item_3Label.Location = New System.Drawing.Point(17, 527)
        Item_3Label.Name = "Item_3Label"
        Item_3Label.Size = New System.Drawing.Size(39, 13)
        Item_3Label.TabIndex = 27
        Item_3Label.Text = "Item 3:"
        '
        'Item_4Label
        '
        Item_4Label.AutoSize = True
        Item_4Label.Location = New System.Drawing.Point(17, 549)
        Item_4Label.Name = "Item_4Label"
        Item_4Label.Size = New System.Drawing.Size(39, 13)
        Item_4Label.TabIndex = 29
        Item_4Label.Text = "Item 4:"
        '
        'Item_5Label
        '
        Item_5Label.AutoSize = True
        Item_5Label.Location = New System.Drawing.Point(17, 572)
        Item_5Label.Name = "Item_5Label"
        Item_5Label.Size = New System.Drawing.Size(39, 13)
        Item_5Label.TabIndex = 31
        Item_5Label.Text = "Item 5:"
        '
        'Item_Price_1Label
        '
        Item_Price_1Label.AutoSize = True
        Item_Price_1Label.Location = New System.Drawing.Point(351, 483)
        Item_Price_1Label.Name = "Item_Price_1Label"
        Item_Price_1Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_1Label.TabIndex = 33
        Item_Price_1Label.Text = "Item Price 1:"
        '
        'Item_Price_2Label
        '
        Item_Price_2Label.AutoSize = True
        Item_Price_2Label.Location = New System.Drawing.Point(351, 505)
        Item_Price_2Label.Name = "Item_Price_2Label"
        Item_Price_2Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_2Label.TabIndex = 35
        Item_Price_2Label.Text = "Item Price 2:"
        '
        'Item_Price_3Label
        '
        Item_Price_3Label.AutoSize = True
        Item_Price_3Label.Location = New System.Drawing.Point(351, 527)
        Item_Price_3Label.Name = "Item_Price_3Label"
        Item_Price_3Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_3Label.TabIndex = 37
        Item_Price_3Label.Text = "Item Price 3:"
        '
        'Item_Price_4Label
        '
        Item_Price_4Label.AutoSize = True
        Item_Price_4Label.Location = New System.Drawing.Point(351, 549)
        Item_Price_4Label.Name = "Item_Price_4Label"
        Item_Price_4Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_4Label.TabIndex = 39
        Item_Price_4Label.Text = "Item Price 4:"
        '
        'Item_Price_5Label
        '
        Item_Price_5Label.AutoSize = True
        Item_Price_5Label.Location = New System.Drawing.Point(352, 572)
        Item_Price_5Label.Name = "Item_Price_5Label"
        Item_Price_5Label.Size = New System.Drawing.Size(66, 13)
        Item_Price_5Label.TabIndex = 41
        Item_Price_5Label.Text = "Item Price 5:"
        '
        'Order_SummaryLabel
        '
        Order_SummaryLabel.AutoSize = True
        Order_SummaryLabel.Location = New System.Drawing.Point(16, 619)
        Order_SummaryLabel.Name = "Order_SummaryLabel"
        Order_SummaryLabel.Size = New System.Drawing.Size(82, 13)
        Order_SummaryLabel.TabIndex = 43
        Order_SummaryLabel.Text = "Order Summary:"
        '
        'Grand_TotalLabel
        '
        Grand_TotalLabel.AutoSize = True
        Grand_TotalLabel.Location = New System.Drawing.Point(16, 716)
        Grand_TotalLabel.Name = "Grand_TotalLabel"
        Grand_TotalLabel.Size = New System.Drawing.Size(66, 13)
        Grand_TotalLabel.TabIndex = 45
        Grand_TotalLabel.Text = "Grand Total:"
        '
        'Order_DepositLabel
        '
        Order_DepositLabel.AutoSize = True
        Order_DepositLabel.Location = New System.Drawing.Point(251, 716)
        Order_DepositLabel.Name = "Order_DepositLabel"
        Order_DepositLabel.Size = New System.Drawing.Size(75, 13)
        Order_DepositLabel.TabIndex = 47
        Order_DepositLabel.Text = "Order Deposit:"
        '
        'Order_BalanceLabel
        '
        Order_BalanceLabel.AutoSize = True
        Order_BalanceLabel.Location = New System.Drawing.Point(16, 738)
        Order_BalanceLabel.Name = "Order_BalanceLabel"
        Order_BalanceLabel.Size = New System.Drawing.Size(78, 13)
        Order_BalanceLabel.TabIndex = 49
        Order_BalanceLabel.Text = "Order Balance:"
        '
        'Order_StatusLabel
        '
        Order_StatusLabel.AutoSize = True
        Order_StatusLabel.Location = New System.Drawing.Point(251, 738)
        Order_StatusLabel.Name = "Order_StatusLabel"
        Order_StatusLabel.Size = New System.Drawing.Size(69, 13)
        Order_StatusLabel.TabIndex = 51
        Order_StatusLabel.Text = "Order Status:"
        '
        'Order_Taken_ByTextBox
        '
        Me.Order_Taken_ByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Taken_By", True))
        Me.Order_Taken_ByTextBox.Location = New System.Drawing.Point(126, 55)
        Me.Order_Taken_ByTextBox.Name = "Order_Taken_ByTextBox"
        Me.Order_Taken_ByTextBox.Size = New System.Drawing.Size(147, 20)
        Me.Order_Taken_ByTextBox.TabIndex = 3
        Me.Order_Taken_ByTextBox.Visible = False
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
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(126, 99)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(147, 20)
        Me.Customer_NameTextBox.TabIndex = 5
        Me.Customer_NameTextBox.Visible = False
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Phone_Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(126, 122)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(82, 20)
        Me.Phone_NumberTextBox.TabIndex = 7
        Me.Phone_NumberTextBox.Visible = False
        '
        'Holiday_NumberTextBox
        '
        Me.Holiday_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Holiday_Number", True))
        Me.Holiday_NumberTextBox.Location = New System.Drawing.Point(126, 77)
        Me.Holiday_NumberTextBox.Name = "Holiday_NumberTextBox"
        Me.Holiday_NumberTextBox.Size = New System.Drawing.Size(82, 20)
        Me.Holiday_NumberTextBox.TabIndex = 9
        Me.Holiday_NumberTextBox.Visible = False
        '
        'Order_DateDateTimePicker
        '
        Me.Order_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Date", True))
        Me.Order_DateDateTimePicker.Location = New System.Drawing.Point(126, 143)
        Me.Order_DateDateTimePicker.Name = "Order_DateDateTimePicker"
        Me.Order_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Order_DateDateTimePicker.TabIndex = 11
        Me.Order_DateDateTimePicker.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 777)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 56)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Finish Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Platter_or_BoxComboBox
        '
        Me.Platter_or_BoxComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Platter_or_Box", True))
        Me.Platter_or_BoxComboBox.FormattingEnabled = True
        Me.Platter_or_BoxComboBox.Items.AddRange(New Object() {"Platter", "Box"})
        Me.Platter_or_BoxComboBox.Location = New System.Drawing.Point(126, 348)
        Me.Platter_or_BoxComboBox.Name = "Platter_or_BoxComboBox"
        Me.Platter_or_BoxComboBox.Size = New System.Drawing.Size(82, 21)
        Me.Platter_or_BoxComboBox.TabIndex = 19
        '
        'Order_DescriptionTextBox
        '
        Me.Order_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Description", True))
        Me.Order_DescriptionTextBox.Location = New System.Drawing.Point(126, 370)
        Me.Order_DescriptionTextBox.Multiline = True
        Me.Order_DescriptionTextBox.Name = "Order_DescriptionTextBox"
        Me.Order_DescriptionTextBox.Size = New System.Drawing.Size(337, 44)
        Me.Order_DescriptionTextBox.TabIndex = 20
        '
        'Order_MessageTextBox
        '
        Me.Order_MessageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Message", True))
        Me.Order_MessageTextBox.Location = New System.Drawing.Point(126, 426)
        Me.Order_MessageTextBox.Multiline = True
        Me.Order_MessageTextBox.Name = "Order_MessageTextBox"
        Me.Order_MessageTextBox.Size = New System.Drawing.Size(337, 43)
        Me.Order_MessageTextBox.TabIndex = 22
        '
        'Item_1TextBox
        '
        Me.Item_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_1", True))
        Me.Item_1TextBox.Location = New System.Drawing.Point(126, 480)
        Me.Item_1TextBox.Name = "Item_1TextBox"
        Me.Item_1TextBox.Size = New System.Drawing.Size(147, 20)
        Me.Item_1TextBox.TabIndex = 24
        '
        'Item_2TextBox
        '
        Me.Item_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_2", True))
        Me.Item_2TextBox.Location = New System.Drawing.Point(126, 502)
        Me.Item_2TextBox.Name = "Item_2TextBox"
        Me.Item_2TextBox.Size = New System.Drawing.Size(147, 20)
        Me.Item_2TextBox.TabIndex = 26
        '
        'Item_3TextBox
        '
        Me.Item_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_3", True))
        Me.Item_3TextBox.Location = New System.Drawing.Point(126, 524)
        Me.Item_3TextBox.Name = "Item_3TextBox"
        Me.Item_3TextBox.Size = New System.Drawing.Size(147, 20)
        Me.Item_3TextBox.TabIndex = 28
        '
        'Item_4TextBox
        '
        Me.Item_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_4", True))
        Me.Item_4TextBox.Location = New System.Drawing.Point(126, 546)
        Me.Item_4TextBox.Name = "Item_4TextBox"
        Me.Item_4TextBox.Size = New System.Drawing.Size(147, 20)
        Me.Item_4TextBox.TabIndex = 30
        '
        'Item_5TextBox
        '
        Me.Item_5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_5", True))
        Me.Item_5TextBox.Location = New System.Drawing.Point(127, 569)
        Me.Item_5TextBox.Name = "Item_5TextBox"
        Me.Item_5TextBox.Size = New System.Drawing.Size(147, 20)
        Me.Item_5TextBox.TabIndex = 32
        '
        'Item_Price_1TextBox
        '
        Me.Item_Price_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_1", True))
        Me.Item_Price_1TextBox.Location = New System.Drawing.Point(423, 480)
        Me.Item_Price_1TextBox.Name = "Item_Price_1TextBox"
        Me.Item_Price_1TextBox.Size = New System.Drawing.Size(40, 20)
        Me.Item_Price_1TextBox.TabIndex = 34
        Me.Item_Price_1TextBox.Visible = False
        '
        'Item_Price_2TextBox
        '
        Me.Item_Price_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_2", True))
        Me.Item_Price_2TextBox.Location = New System.Drawing.Point(423, 502)
        Me.Item_Price_2TextBox.Name = "Item_Price_2TextBox"
        Me.Item_Price_2TextBox.Size = New System.Drawing.Size(40, 20)
        Me.Item_Price_2TextBox.TabIndex = 36
        Me.Item_Price_2TextBox.Visible = False
        '
        'Item_Price_3TextBox
        '
        Me.Item_Price_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_3", True))
        Me.Item_Price_3TextBox.Location = New System.Drawing.Point(423, 524)
        Me.Item_Price_3TextBox.Name = "Item_Price_3TextBox"
        Me.Item_Price_3TextBox.Size = New System.Drawing.Size(40, 20)
        Me.Item_Price_3TextBox.TabIndex = 38
        Me.Item_Price_3TextBox.Visible = False
        '
        'Item_Price_4TextBox
        '
        Me.Item_Price_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_4", True))
        Me.Item_Price_4TextBox.Location = New System.Drawing.Point(423, 546)
        Me.Item_Price_4TextBox.Name = "Item_Price_4TextBox"
        Me.Item_Price_4TextBox.Size = New System.Drawing.Size(40, 20)
        Me.Item_Price_4TextBox.TabIndex = 40
        Me.Item_Price_4TextBox.Visible = False
        '
        'Item_Price_5TextBox
        '
        Me.Item_Price_5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Item_Price_5", True))
        Me.Item_Price_5TextBox.Location = New System.Drawing.Point(424, 569)
        Me.Item_Price_5TextBox.Name = "Item_Price_5TextBox"
        Me.Item_Price_5TextBox.Size = New System.Drawing.Size(39, 20)
        Me.Item_Price_5TextBox.TabIndex = 42
        Me.Item_Price_5TextBox.Visible = False
        '
        'Order_SummaryTextBox
        '
        Me.Order_SummaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Summary", True))
        Me.Order_SummaryTextBox.Location = New System.Drawing.Point(126, 616)
        Me.Order_SummaryTextBox.Multiline = True
        Me.Order_SummaryTextBox.Name = "Order_SummaryTextBox"
        Me.Order_SummaryTextBox.Size = New System.Drawing.Size(337, 46)
        Me.Order_SummaryTextBox.TabIndex = 44
        '
        'Grand_TotalTextBox
        '
        Me.Grand_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Grand_Total", True))
        Me.Grand_TotalTextBox.Location = New System.Drawing.Point(127, 713)
        Me.Grand_TotalTextBox.Name = "Grand_TotalTextBox"
        Me.Grand_TotalTextBox.Size = New System.Drawing.Size(81, 20)
        Me.Grand_TotalTextBox.TabIndex = 46
        '
        'Order_DepositTextBox
        '
        Me.Order_DepositTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Deposit", True))
        Me.Order_DepositTextBox.Location = New System.Drawing.Point(354, 713)
        Me.Order_DepositTextBox.Name = "Order_DepositTextBox"
        Me.Order_DepositTextBox.Size = New System.Drawing.Size(87, 20)
        Me.Order_DepositTextBox.TabIndex = 48
        '
        'Order_BalanceTextBox
        '
        Me.Order_BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Balance", True))
        Me.Order_BalanceTextBox.Location = New System.Drawing.Point(127, 735)
        Me.Order_BalanceTextBox.Name = "Order_BalanceTextBox"
        Me.Order_BalanceTextBox.Size = New System.Drawing.Size(81, 20)
        Me.Order_BalanceTextBox.TabIndex = 50
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(126, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 35)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Add/Edit Mini Pastries"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(126, 231)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 33)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "Add/Edit Mini Bars"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(125, 279)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(173, 34)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "Add/Edit Mini Cookies"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(127, 33)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(81, 20)
        Me.IDTextBox.TabIndex = 57
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(211, 28)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(72, 25)
        Me.FillByToolStrip.TabIndex = 58
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(69, 22)
        Me.FillByToolStripButton.Text = "Get Order#"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(288, 777)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 56)
        Me.Button5.TabIndex = 59
        Me.Button5.Text = "Delete Order"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(171, 668)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 39)
        Me.Button6.TabIndex = 60
        Me.Button6.Text = "Get Grand Total"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Order_StatusComboBox
        '
        Me.Order_StatusComboBox.CausesValidation = False
        Me.Order_StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Status", True))
        Me.Order_StatusComboBox.FormattingEnabled = True
        Me.Order_StatusComboBox.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.Order_StatusComboBox.Location = New System.Drawing.Point(355, 735)
        Me.Order_StatusComboBox.Name = "Order_StatusComboBox"
        Me.Order_StatusComboBox.Size = New System.Drawing.Size(86, 21)
        Me.Order_StatusComboBox.TabIndex = 61
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Order#:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Order Taken By:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Holiday Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Customer Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Phone Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Order Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Mini Pastries:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Mini Cookies:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 351)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Platter or Box:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Order Description:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 429)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Order Message:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(477, 847)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Order_StatusComboBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Order_StatusLabel)
        Me.Controls.Add(Order_BalanceLabel)
        Me.Controls.Add(Me.Order_BalanceTextBox)
        Me.Controls.Add(Order_DepositLabel)
        Me.Controls.Add(Me.Order_DepositTextBox)
        Me.Controls.Add(Grand_TotalLabel)
        Me.Controls.Add(Me.Grand_TotalTextBox)
        Me.Controls.Add(Order_SummaryLabel)
        Me.Controls.Add(Me.Order_SummaryTextBox)
        Me.Controls.Add(Item_Price_5Label)
        Me.Controls.Add(Me.Item_Price_5TextBox)
        Me.Controls.Add(Item_Price_4Label)
        Me.Controls.Add(Me.Item_Price_4TextBox)
        Me.Controls.Add(Item_Price_3Label)
        Me.Controls.Add(Me.Item_Price_3TextBox)
        Me.Controls.Add(Item_Price_2Label)
        Me.Controls.Add(Me.Item_Price_2TextBox)
        Me.Controls.Add(Item_Price_1Label)
        Me.Controls.Add(Me.Item_Price_1TextBox)
        Me.Controls.Add(Item_5Label)
        Me.Controls.Add(Me.Item_5TextBox)
        Me.Controls.Add(Item_4Label)
        Me.Controls.Add(Me.Item_4TextBox)
        Me.Controls.Add(Item_3Label)
        Me.Controls.Add(Me.Item_3TextBox)
        Me.Controls.Add(Item_2Label)
        Me.Controls.Add(Me.Item_2TextBox)
        Me.Controls.Add(Item_1Label)
        Me.Controls.Add(Me.Item_1TextBox)
        Me.Controls.Add(Me.Order_MessageTextBox)
        Me.Controls.Add(Me.Order_DescriptionTextBox)
        Me.Controls.Add(Me.Platter_or_BoxComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Order_Taken_ByTextBox)
        Me.Controls.Add(Me.Customer_NameTextBox)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Me.Holiday_NumberTextBox)
        Me.Controls.Add(Me.Order_DateDateTimePicker)
        Me.Controls.Add(Mini_BarsLabel)
        Me.Name = "Form2"
        Me.Text = "Mini Pastry Order"
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
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
    Friend WithEvents Holiday_NumberTextBox As TextBox
    Friend WithEvents Order_DateDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Order_StatusComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
End Class
