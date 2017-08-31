<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mini_Bars
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
        Dim LemonLabel As System.Windows.Forms.Label
        Dim PecanLabel As System.Windows.Forms.Label
        Dim Triple_Berry_BarLabel As System.Windows.Forms.Label
        Dim TigerLabel As System.Windows.Forms.Label
        Dim MagicLabel As System.Windows.Forms.Label
        Dim Classic_BrownieLabel As System.Windows.Forms.Label
        Dim Truffle_BrownieLabel As System.Windows.Forms.Label
        Dim German_BrownieLabel As System.Windows.Forms.Label
        Dim Apple_CrispLabel As System.Windows.Forms.Label
        Dim Date_BarLabel As System.Windows.Forms.Label
        Dim Cranberry_MagicLabel As System.Windows.Forms.Label
        Dim PumpkinLabel As System.Windows.Forms.Label
        Dim Mini_Bar_PackageLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Mini_Bar_Total_PriceLabel As System.Windows.Forms.Label
        Me.Bakery_OrdersDataSet = New Bakery_Ordering_Database.Bakery_OrdersDataSet()
        Me.MINI_PASTRY_ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MINI_PASTRY_ORDERSTableAdapter = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter()
        Me.TableAdapterManager = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.TableAdapterManager()
        Me.LemonCheckBox = New System.Windows.Forms.CheckBox()
        Me.PecanCheckBox = New System.Windows.Forms.CheckBox()
        Me.Triple_Berry_BarCheckBox = New System.Windows.Forms.CheckBox()
        Me.TigerCheckBox = New System.Windows.Forms.CheckBox()
        Me.MagicCheckBox = New System.Windows.Forms.CheckBox()
        Me.Classic_BrownieCheckBox = New System.Windows.Forms.CheckBox()
        Me.Truffle_BrownieCheckBox = New System.Windows.Forms.CheckBox()
        Me.German_BrownieCheckBox = New System.Windows.Forms.CheckBox()
        Me.Apple_CrispCheckBox = New System.Windows.Forms.CheckBox()
        Me.Date_BarCheckBox = New System.Windows.Forms.CheckBox()
        Me.Cranberry_MagicCheckBox = New System.Windows.Forms.CheckBox()
        Me.PumpkinCheckBox = New System.Windows.Forms.CheckBox()
        Me.Mini_Bar_PackageCheckBox = New System.Windows.Forms.CheckBox()
        Me.Lemon_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Pecan_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Triple_Berry_Bar_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Tiger_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Magic_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Classic_Brownie_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Truffle_Brownie_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Apple_Crisp_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.German_Brownie_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Bar_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Cranberry_Magic_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Pumpkin_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Mini_Bar_Package_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Mini_Bar_Total_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        LemonLabel = New System.Windows.Forms.Label()
        PecanLabel = New System.Windows.Forms.Label()
        Triple_Berry_BarLabel = New System.Windows.Forms.Label()
        TigerLabel = New System.Windows.Forms.Label()
        MagicLabel = New System.Windows.Forms.Label()
        Classic_BrownieLabel = New System.Windows.Forms.Label()
        Truffle_BrownieLabel = New System.Windows.Forms.Label()
        German_BrownieLabel = New System.Windows.Forms.Label()
        Apple_CrispLabel = New System.Windows.Forms.Label()
        Date_BarLabel = New System.Windows.Forms.Label()
        Cranberry_MagicLabel = New System.Windows.Forms.Label()
        PumpkinLabel = New System.Windows.Forms.Label()
        Mini_Bar_PackageLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Mini_Bar_Total_PriceLabel = New System.Windows.Forms.Label()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LemonLabel
        '
        LemonLabel.AutoSize = True
        LemonLabel.Location = New System.Drawing.Point(12, 51)
        LemonLabel.Name = "LemonLabel"
        LemonLabel.Size = New System.Drawing.Size(42, 13)
        LemonLabel.TabIndex = 1
        LemonLabel.Text = "Lemon:"
        '
        'PecanLabel
        '
        PecanLabel.AutoSize = True
        PecanLabel.Location = New System.Drawing.Point(12, 73)
        PecanLabel.Name = "PecanLabel"
        PecanLabel.Size = New System.Drawing.Size(41, 13)
        PecanLabel.TabIndex = 2
        PecanLabel.Text = "Pecan:"
        '
        'Triple_Berry_BarLabel
        '
        Triple_Berry_BarLabel.AutoSize = True
        Triple_Berry_BarLabel.Location = New System.Drawing.Point(12, 95)
        Triple_Berry_BarLabel.Name = "Triple_Berry_BarLabel"
        Triple_Berry_BarLabel.Size = New System.Drawing.Size(82, 13)
        Triple_Berry_BarLabel.TabIndex = 4
        Triple_Berry_BarLabel.Text = "Triple Berry Bar:"
        '
        'TigerLabel
        '
        TigerLabel.AutoSize = True
        TigerLabel.Location = New System.Drawing.Point(12, 117)
        TigerLabel.Name = "TigerLabel"
        TigerLabel.Size = New System.Drawing.Size(34, 13)
        TigerLabel.TabIndex = 6
        TigerLabel.Text = "Tiger:"
        '
        'MagicLabel
        '
        MagicLabel.AutoSize = True
        MagicLabel.Location = New System.Drawing.Point(12, 140)
        MagicLabel.Name = "MagicLabel"
        MagicLabel.Size = New System.Drawing.Size(39, 13)
        MagicLabel.TabIndex = 8
        MagicLabel.Text = "Magic:"
        '
        'Classic_BrownieLabel
        '
        Classic_BrownieLabel.AutoSize = True
        Classic_BrownieLabel.Location = New System.Drawing.Point(12, 162)
        Classic_BrownieLabel.Name = "Classic_BrownieLabel"
        Classic_BrownieLabel.Size = New System.Drawing.Size(84, 13)
        Classic_BrownieLabel.TabIndex = 10
        Classic_BrownieLabel.Text = "Classic Brownie:"
        '
        'Truffle_BrownieLabel
        '
        Truffle_BrownieLabel.AutoSize = True
        Truffle_BrownieLabel.Location = New System.Drawing.Point(12, 185)
        Truffle_BrownieLabel.Name = "Truffle_BrownieLabel"
        Truffle_BrownieLabel.Size = New System.Drawing.Size(81, 13)
        Truffle_BrownieLabel.TabIndex = 12
        Truffle_BrownieLabel.Text = "Truffle Brownie:"
        '
        'German_BrownieLabel
        '
        German_BrownieLabel.AutoSize = True
        German_BrownieLabel.Location = New System.Drawing.Point(12, 207)
        German_BrownieLabel.Name = "German_BrownieLabel"
        German_BrownieLabel.Size = New System.Drawing.Size(88, 13)
        German_BrownieLabel.TabIndex = 14
        German_BrownieLabel.Text = "German Brownie:"
        '
        'Apple_CrispLabel
        '
        Apple_CrispLabel.AutoSize = True
        Apple_CrispLabel.Location = New System.Drawing.Point(12, 229)
        Apple_CrispLabel.Name = "Apple_CrispLabel"
        Apple_CrispLabel.Size = New System.Drawing.Size(63, 13)
        Apple_CrispLabel.TabIndex = 16
        Apple_CrispLabel.Text = "Apple Crisp:"
        '
        'Date_BarLabel
        '
        Date_BarLabel.AutoSize = True
        Date_BarLabel.Location = New System.Drawing.Point(12, 251)
        Date_BarLabel.Name = "Date_BarLabel"
        Date_BarLabel.Size = New System.Drawing.Size(52, 13)
        Date_BarLabel.TabIndex = 18
        Date_BarLabel.Text = "Date Bar:"
        '
        'Cranberry_MagicLabel
        '
        Cranberry_MagicLabel.AutoSize = True
        Cranberry_MagicLabel.Location = New System.Drawing.Point(12, 273)
        Cranberry_MagicLabel.Name = "Cranberry_MagicLabel"
        Cranberry_MagicLabel.Size = New System.Drawing.Size(87, 13)
        Cranberry_MagicLabel.TabIndex = 20
        Cranberry_MagicLabel.Text = "Cranberry Magic:"
        '
        'PumpkinLabel
        '
        PumpkinLabel.AutoSize = True
        PumpkinLabel.Location = New System.Drawing.Point(12, 296)
        PumpkinLabel.Name = "PumpkinLabel"
        PumpkinLabel.Size = New System.Drawing.Size(51, 13)
        PumpkinLabel.TabIndex = 22
        PumpkinLabel.Text = "Pumpkin:"
        '
        'Mini_Bar_PackageLabel
        '
        Mini_Bar_PackageLabel.AutoSize = True
        Mini_Bar_PackageLabel.Location = New System.Drawing.Point(12, 318)
        Mini_Bar_PackageLabel.Name = "Mini_Bar_PackageLabel"
        Mini_Bar_PackageLabel.Size = New System.Drawing.Size(94, 13)
        Mini_Bar_PackageLabel.TabIndex = 24
        Mini_Bar_PackageLabel.Text = "Mini Bar Package:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(143, 13)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 65
        IDLabel.Text = "ID:"
        AddHandler IDLabel.Click, AddressOf Me.IDLabel_Click
        '
        'Mini_Bar_Total_PriceLabel
        '
        Mini_Bar_Total_PriceLabel.AutoSize = True
        Mini_Bar_Total_PriceLabel.Location = New System.Drawing.Point(60, 369)
        Mini_Bar_Total_PriceLabel.Name = "Mini_Bar_Total_PriceLabel"
        Mini_Bar_Total_PriceLabel.Size = New System.Drawing.Size(102, 13)
        Mini_Bar_Total_PriceLabel.TabIndex = 67
        Mini_Bar_Total_PriceLabel.Text = "Mini Bar Total Price:"
        '
        'Bakery_OrdersDataSet
        '
        Me.Bakery_OrdersDataSet.DataSetName = "Bakery_OrdersDataSet"
        Me.Bakery_OrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MINI_PASTRY_ORDERSBindingSource
        '
        Me.MINI_PASTRY_ORDERSBindingSource.DataMember = "MINI_PASTRY_ORDERS"
        Me.MINI_PASTRY_ORDERSBindingSource.DataSource = Me.Bakery_OrdersDataSet
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
        'LemonCheckBox
        '
        Me.LemonCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Lemon", True))
        Me.LemonCheckBox.Location = New System.Drawing.Point(114, 46)
        Me.LemonCheckBox.Name = "LemonCheckBox"
        Me.LemonCheckBox.Size = New System.Drawing.Size(39, 24)
        Me.LemonCheckBox.TabIndex = 2
        Me.LemonCheckBox.UseVisualStyleBackColor = True
        '
        'PecanCheckBox
        '
        Me.PecanCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Pecan", True))
        Me.PecanCheckBox.Location = New System.Drawing.Point(114, 68)
        Me.PecanCheckBox.Name = "PecanCheckBox"
        Me.PecanCheckBox.Size = New System.Drawing.Size(39, 24)
        Me.PecanCheckBox.TabIndex = 3
        Me.PecanCheckBox.UseVisualStyleBackColor = True
        '
        'Triple_Berry_BarCheckBox
        '
        Me.Triple_Berry_BarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Triple_Berry_Bar", True))
        Me.Triple_Berry_BarCheckBox.Location = New System.Drawing.Point(114, 90)
        Me.Triple_Berry_BarCheckBox.Name = "Triple_Berry_BarCheckBox"
        Me.Triple_Berry_BarCheckBox.Size = New System.Drawing.Size(39, 24)
        Me.Triple_Berry_BarCheckBox.TabIndex = 5
        Me.Triple_Berry_BarCheckBox.UseVisualStyleBackColor = True
        '
        'TigerCheckBox
        '
        Me.TigerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Tiger", True))
        Me.TigerCheckBox.Location = New System.Drawing.Point(114, 112)
        Me.TigerCheckBox.Name = "TigerCheckBox"
        Me.TigerCheckBox.Size = New System.Drawing.Size(39, 24)
        Me.TigerCheckBox.TabIndex = 7
        Me.TigerCheckBox.UseVisualStyleBackColor = True
        '
        'MagicCheckBox
        '
        Me.MagicCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Magic", True))
        Me.MagicCheckBox.Location = New System.Drawing.Point(114, 135)
        Me.MagicCheckBox.Name = "MagicCheckBox"
        Me.MagicCheckBox.Size = New System.Drawing.Size(39, 24)
        Me.MagicCheckBox.TabIndex = 9
        Me.MagicCheckBox.UseVisualStyleBackColor = True
        '
        'Classic_BrownieCheckBox
        '
        Me.Classic_BrownieCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Classic_Brownie", True))
        Me.Classic_BrownieCheckBox.Location = New System.Drawing.Point(114, 157)
        Me.Classic_BrownieCheckBox.Name = "Classic_BrownieCheckBox"
        Me.Classic_BrownieCheckBox.Size = New System.Drawing.Size(39, 24)
        Me.Classic_BrownieCheckBox.TabIndex = 11
        Me.Classic_BrownieCheckBox.UseVisualStyleBackColor = True
        '
        'Truffle_BrownieCheckBox
        '
        Me.Truffle_BrownieCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Truffle_Brownie", True))
        Me.Truffle_BrownieCheckBox.Location = New System.Drawing.Point(114, 180)
        Me.Truffle_BrownieCheckBox.Name = "Truffle_BrownieCheckBox"
        Me.Truffle_BrownieCheckBox.Size = New System.Drawing.Size(39, 24)
        Me.Truffle_BrownieCheckBox.TabIndex = 13
        Me.Truffle_BrownieCheckBox.UseVisualStyleBackColor = True
        '
        'German_BrownieCheckBox
        '
        Me.German_BrownieCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "German_Brownie", True))
        Me.German_BrownieCheckBox.Location = New System.Drawing.Point(114, 202)
        Me.German_BrownieCheckBox.Name = "German_BrownieCheckBox"
        Me.German_BrownieCheckBox.Size = New System.Drawing.Size(39, 24)
        Me.German_BrownieCheckBox.TabIndex = 15
        Me.German_BrownieCheckBox.UseVisualStyleBackColor = True
        '
        'Apple_CrispCheckBox
        '
        Me.Apple_CrispCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Apple_Crisp", True))
        Me.Apple_CrispCheckBox.Location = New System.Drawing.Point(113, 224)
        Me.Apple_CrispCheckBox.Name = "Apple_CrispCheckBox"
        Me.Apple_CrispCheckBox.Size = New System.Drawing.Size(40, 24)
        Me.Apple_CrispCheckBox.TabIndex = 17
        Me.Apple_CrispCheckBox.UseVisualStyleBackColor = True
        '
        'Date_BarCheckBox
        '
        Me.Date_BarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Date_Bar", True))
        Me.Date_BarCheckBox.Location = New System.Drawing.Point(113, 246)
        Me.Date_BarCheckBox.Name = "Date_BarCheckBox"
        Me.Date_BarCheckBox.Size = New System.Drawing.Size(40, 24)
        Me.Date_BarCheckBox.TabIndex = 19
        Me.Date_BarCheckBox.UseVisualStyleBackColor = True
        '
        'Cranberry_MagicCheckBox
        '
        Me.Cranberry_MagicCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Cranberry_Magic", True))
        Me.Cranberry_MagicCheckBox.Location = New System.Drawing.Point(113, 268)
        Me.Cranberry_MagicCheckBox.Name = "Cranberry_MagicCheckBox"
        Me.Cranberry_MagicCheckBox.Size = New System.Drawing.Size(40, 24)
        Me.Cranberry_MagicCheckBox.TabIndex = 21
        Me.Cranberry_MagicCheckBox.UseVisualStyleBackColor = True
        '
        'PumpkinCheckBox
        '
        Me.PumpkinCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Pumpkin", True))
        Me.PumpkinCheckBox.Location = New System.Drawing.Point(113, 291)
        Me.PumpkinCheckBox.Name = "PumpkinCheckBox"
        Me.PumpkinCheckBox.Size = New System.Drawing.Size(40, 24)
        Me.PumpkinCheckBox.TabIndex = 23
        Me.PumpkinCheckBox.UseVisualStyleBackColor = True
        '
        'Mini_Bar_PackageCheckBox
        '
        Me.Mini_Bar_PackageCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Bar_Package", True))
        Me.Mini_Bar_PackageCheckBox.Location = New System.Drawing.Point(113, 313)
        Me.Mini_Bar_PackageCheckBox.Name = "Mini_Bar_PackageCheckBox"
        Me.Mini_Bar_PackageCheckBox.Size = New System.Drawing.Size(40, 24)
        Me.Mini_Bar_PackageCheckBox.TabIndex = 25
        Me.Mini_Bar_PackageCheckBox.UseVisualStyleBackColor = True
        '
        'Lemon_TotalTextBox
        '
        Me.Lemon_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Lemon_Total", True))
        Me.Lemon_TotalTextBox.Enabled = False
        Me.Lemon_TotalTextBox.Location = New System.Drawing.Point(328, 48)
        Me.Lemon_TotalTextBox.Name = "Lemon_TotalTextBox"
        Me.Lemon_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Lemon_TotalTextBox.TabIndex = 27
        '
        'Pecan_TotalTextBox
        '
        Me.Pecan_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Pecan_Total", True))
        Me.Pecan_TotalTextBox.Enabled = False
        Me.Pecan_TotalTextBox.Location = New System.Drawing.Point(328, 70)
        Me.Pecan_TotalTextBox.Name = "Pecan_TotalTextBox"
        Me.Pecan_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Pecan_TotalTextBox.TabIndex = 29
        '
        'Triple_Berry_Bar_TotalTextBox
        '
        Me.Triple_Berry_Bar_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Triple_Berry_Bar_Total", True))
        Me.Triple_Berry_Bar_TotalTextBox.Enabled = False
        Me.Triple_Berry_Bar_TotalTextBox.Location = New System.Drawing.Point(328, 92)
        Me.Triple_Berry_Bar_TotalTextBox.Name = "Triple_Berry_Bar_TotalTextBox"
        Me.Triple_Berry_Bar_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Triple_Berry_Bar_TotalTextBox.TabIndex = 31
        '
        'Tiger_TotalTextBox
        '
        Me.Tiger_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Tiger_Total", True))
        Me.Tiger_TotalTextBox.Enabled = False
        Me.Tiger_TotalTextBox.Location = New System.Drawing.Point(328, 114)
        Me.Tiger_TotalTextBox.Name = "Tiger_TotalTextBox"
        Me.Tiger_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Tiger_TotalTextBox.TabIndex = 33
        '
        'Magic_TotalTextBox
        '
        Me.Magic_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Magic_Total", True))
        Me.Magic_TotalTextBox.Enabled = False
        Me.Magic_TotalTextBox.Location = New System.Drawing.Point(328, 137)
        Me.Magic_TotalTextBox.Name = "Magic_TotalTextBox"
        Me.Magic_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Magic_TotalTextBox.TabIndex = 35
        '
        'Classic_Brownie_TotalTextBox
        '
        Me.Classic_Brownie_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Classic_Brownie_Total", True))
        Me.Classic_Brownie_TotalTextBox.Enabled = False
        Me.Classic_Brownie_TotalTextBox.Location = New System.Drawing.Point(328, 159)
        Me.Classic_Brownie_TotalTextBox.Name = "Classic_Brownie_TotalTextBox"
        Me.Classic_Brownie_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Classic_Brownie_TotalTextBox.TabIndex = 37
        '
        'Truffle_Brownie_TotalTextBox
        '
        Me.Truffle_Brownie_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Truffle_Brownie_Total", True))
        Me.Truffle_Brownie_TotalTextBox.Enabled = False
        Me.Truffle_Brownie_TotalTextBox.Location = New System.Drawing.Point(328, 182)
        Me.Truffle_Brownie_TotalTextBox.Name = "Truffle_Brownie_TotalTextBox"
        Me.Truffle_Brownie_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Truffle_Brownie_TotalTextBox.TabIndex = 39
        '
        'Apple_Crisp_TotalTextBox
        '
        Me.Apple_Crisp_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Apple_Crisp_Total", True))
        Me.Apple_Crisp_TotalTextBox.Enabled = False
        Me.Apple_Crisp_TotalTextBox.Location = New System.Drawing.Point(328, 226)
        Me.Apple_Crisp_TotalTextBox.Name = "Apple_Crisp_TotalTextBox"
        Me.Apple_Crisp_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Apple_Crisp_TotalTextBox.TabIndex = 41
        '
        'German_Brownie_TotalTextBox
        '
        Me.German_Brownie_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "German_Brownie_Total", True))
        Me.German_Brownie_TotalTextBox.Enabled = False
        Me.German_Brownie_TotalTextBox.Location = New System.Drawing.Point(328, 204)
        Me.German_Brownie_TotalTextBox.Name = "German_Brownie_TotalTextBox"
        Me.German_Brownie_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.German_Brownie_TotalTextBox.TabIndex = 43
        '
        'Date_Bar_TotalTextBox
        '
        Me.Date_Bar_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Date_Bar_Total", True))
        Me.Date_Bar_TotalTextBox.Enabled = False
        Me.Date_Bar_TotalTextBox.Location = New System.Drawing.Point(328, 248)
        Me.Date_Bar_TotalTextBox.Name = "Date_Bar_TotalTextBox"
        Me.Date_Bar_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Date_Bar_TotalTextBox.TabIndex = 45
        '
        'Cranberry_Magic_TotalTextBox
        '
        Me.Cranberry_Magic_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Cranberry_Magic_Total", True))
        Me.Cranberry_Magic_TotalTextBox.Enabled = False
        Me.Cranberry_Magic_TotalTextBox.Location = New System.Drawing.Point(328, 270)
        Me.Cranberry_Magic_TotalTextBox.Name = "Cranberry_Magic_TotalTextBox"
        Me.Cranberry_Magic_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Cranberry_Magic_TotalTextBox.TabIndex = 47
        '
        'Pumpkin_TotalTextBox
        '
        Me.Pumpkin_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Pumpkin_Total", True))
        Me.Pumpkin_TotalTextBox.Enabled = False
        Me.Pumpkin_TotalTextBox.Location = New System.Drawing.Point(328, 293)
        Me.Pumpkin_TotalTextBox.Name = "Pumpkin_TotalTextBox"
        Me.Pumpkin_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Pumpkin_TotalTextBox.TabIndex = 49
        '
        'Mini_Bar_Package_TotalTextBox
        '
        Me.Mini_Bar_Package_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Bar_Package_Total", True))
        Me.Mini_Bar_Package_TotalTextBox.Enabled = False
        Me.Mini_Bar_Package_TotalTextBox.Location = New System.Drawing.Point(328, 315)
        Me.Mini_Bar_Package_TotalTextBox.Name = "Mini_Bar_Package_TotalTextBox"
        Me.Mini_Bar_Package_TotalTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Mini_Bar_Package_TotalTextBox.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Lemon Bar Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Pecan Bar Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Triple Berry Bar Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Tiger Bar Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Magic Bar Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Classic Brownie Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Truffle Brownie Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "German Brownie Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(196, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Apple Crisp Bar Total:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(196, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Date Bar Total:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(196, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Cranberry Magic Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(196, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Pumpkin Bar Total:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(196, 318)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 13)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Mini Bar Package Total:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(168, 10)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(46, 20)
        Me.IDTextBox.TabIndex = 66
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 57)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Save and Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Mini_Bar_Total_PriceTextBox
        '
        Me.Mini_Bar_Total_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Mini_Bar_Total_Price", True))
        Me.Mini_Bar_Total_PriceTextBox.Location = New System.Drawing.Point(168, 366)
        Me.Mini_Bar_Total_PriceTextBox.Name = "Mini_Bar_Total_PriceTextBox"
        Me.Mini_Bar_Total_PriceTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Mini_Bar_Total_PriceTextBox.TabIndex = 68
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(199, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 57)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Mini_Bars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 472)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Mini_Bar_Total_PriceLabel)
        Me.Controls.Add(Me.Mini_Bar_Total_PriceTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mini_Bar_Package_TotalTextBox)
        Me.Controls.Add(Me.Pumpkin_TotalTextBox)
        Me.Controls.Add(Me.Cranberry_Magic_TotalTextBox)
        Me.Controls.Add(Me.Date_Bar_TotalTextBox)
        Me.Controls.Add(Me.German_Brownie_TotalTextBox)
        Me.Controls.Add(Me.Apple_Crisp_TotalTextBox)
        Me.Controls.Add(Me.Truffle_Brownie_TotalTextBox)
        Me.Controls.Add(Me.Classic_Brownie_TotalTextBox)
        Me.Controls.Add(Me.Magic_TotalTextBox)
        Me.Controls.Add(Me.Tiger_TotalTextBox)
        Me.Controls.Add(Me.Triple_Berry_Bar_TotalTextBox)
        Me.Controls.Add(Me.Pecan_TotalTextBox)
        Me.Controls.Add(Me.Lemon_TotalTextBox)
        Me.Controls.Add(Mini_Bar_PackageLabel)
        Me.Controls.Add(Me.Mini_Bar_PackageCheckBox)
        Me.Controls.Add(PumpkinLabel)
        Me.Controls.Add(Me.PumpkinCheckBox)
        Me.Controls.Add(Cranberry_MagicLabel)
        Me.Controls.Add(Me.Cranberry_MagicCheckBox)
        Me.Controls.Add(Date_BarLabel)
        Me.Controls.Add(Me.Date_BarCheckBox)
        Me.Controls.Add(Apple_CrispLabel)
        Me.Controls.Add(Me.Apple_CrispCheckBox)
        Me.Controls.Add(German_BrownieLabel)
        Me.Controls.Add(Me.German_BrownieCheckBox)
        Me.Controls.Add(Truffle_BrownieLabel)
        Me.Controls.Add(Me.Truffle_BrownieCheckBox)
        Me.Controls.Add(Classic_BrownieLabel)
        Me.Controls.Add(Me.Classic_BrownieCheckBox)
        Me.Controls.Add(MagicLabel)
        Me.Controls.Add(Me.MagicCheckBox)
        Me.Controls.Add(TigerLabel)
        Me.Controls.Add(Me.TigerCheckBox)
        Me.Controls.Add(Triple_Berry_BarLabel)
        Me.Controls.Add(Me.Triple_Berry_BarCheckBox)
        Me.Controls.Add(PecanLabel)
        Me.Controls.Add(Me.PecanCheckBox)
        Me.Controls.Add(LemonLabel)
        Me.Controls.Add(Me.LemonCheckBox)
        Me.Name = "Mini_Bars"
        Me.Text = "Mini_Bars"
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bakery_OrdersDataSet As Bakery_OrdersDataSet
    Friend WithEvents MINI_PASTRY_ORDERSBindingSource As BindingSource
    Friend WithEvents MINI_PASTRY_ORDERSTableAdapter As Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter
    Friend WithEvents TableAdapterManager As Bakery_OrdersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LemonCheckBox As CheckBox
    Friend WithEvents PecanCheckBox As CheckBox
    Friend WithEvents Triple_Berry_BarCheckBox As CheckBox
    Friend WithEvents TigerCheckBox As CheckBox
    Friend WithEvents MagicCheckBox As CheckBox
    Friend WithEvents Classic_BrownieCheckBox As CheckBox
    Friend WithEvents Truffle_BrownieCheckBox As CheckBox
    Friend WithEvents German_BrownieCheckBox As CheckBox
    Friend WithEvents Apple_CrispCheckBox As CheckBox
    Friend WithEvents Date_BarCheckBox As CheckBox
    Friend WithEvents Cranberry_MagicCheckBox As CheckBox
    Friend WithEvents PumpkinCheckBox As CheckBox
    Friend WithEvents Mini_Bar_PackageCheckBox As CheckBox
    Friend WithEvents Lemon_TotalTextBox As TextBox
    Friend WithEvents Pecan_TotalTextBox As TextBox
    Friend WithEvents Triple_Berry_Bar_TotalTextBox As TextBox
    Friend WithEvents Tiger_TotalTextBox As TextBox
    Friend WithEvents Magic_TotalTextBox As TextBox
    Friend WithEvents Classic_Brownie_TotalTextBox As TextBox
    Friend WithEvents Truffle_Brownie_TotalTextBox As TextBox
    Friend WithEvents Apple_Crisp_TotalTextBox As TextBox
    Friend WithEvents German_Brownie_TotalTextBox As TextBox
    Friend WithEvents Date_Bar_TotalTextBox As TextBox
    Friend WithEvents Cranberry_Magic_TotalTextBox As TextBox
    Friend WithEvents Pumpkin_TotalTextBox As TextBox
    Friend WithEvents Mini_Bar_Package_TotalTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Mini_Bar_Total_PriceTextBox As TextBox
    Friend WithEvents Button2 As Button
End Class
