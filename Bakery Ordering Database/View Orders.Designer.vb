<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Orders
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Holiday_NumberLabel As System.Windows.Forms.Label
        Dim Order_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Orders))
        Me.MINI_PASTRY_ORDERSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.MINI_PASTRY_ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bakery_OrdersDataSet = New Bakery_Ordering_Database.Bakery_OrdersDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MINI_PASTRY_ORDERSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MINI_PASTRY_ORDERSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn13 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn17 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn18 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn19 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn20 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn21 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn22 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn23 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn24 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn25 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn26 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn27 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn28 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn29 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn30 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn31 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn32 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Holiday_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Order_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SearchCustomer1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Customer_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Customer_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.MINI_PASTRY_ORDERSTableAdapter = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter()
        Me.TableAdapterManager = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Holiday_NumberLabel = New System.Windows.Forms.Label()
        Order_DateLabel = New System.Windows.Forms.Label()
        CType(Me.MINI_PASTRY_ORDERSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MINI_PASTRY_ORDERSBindingNavigator.SuspendLayout()
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINI_PASTRY_ORDERSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchCustomer1ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(704, 101)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(38, 25)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_NameLabel.Location = New System.Drawing.Point(704, 138)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(172, 25)
        Customer_NameLabel.TabIndex = 4
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.Location = New System.Drawing.Point(704, 175)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(161, 25)
        Phone_NumberLabel.TabIndex = 6
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Holiday_NumberLabel
        '
        Holiday_NumberLabel.AutoSize = True
        Holiday_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Holiday_NumberLabel.Location = New System.Drawing.Point(704, 212)
        Holiday_NumberLabel.Name = "Holiday_NumberLabel"
        Holiday_NumberLabel.Size = New System.Drawing.Size(171, 25)
        Holiday_NumberLabel.TabIndex = 8
        Holiday_NumberLabel.Text = "Holiday Number:"
        '
        'Order_DateLabel
        '
        Order_DateLabel.AutoSize = True
        Order_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Order_DateLabel.Location = New System.Drawing.Point(704, 247)
        Order_DateLabel.Name = "Order_DateLabel"
        Order_DateLabel.Size = New System.Drawing.Size(123, 25)
        Order_DateLabel.TabIndex = 10
        Order_DateLabel.Text = "Order Date:"
        '
        'MINI_PASTRY_ORDERSBindingNavigator
        '
        Me.MINI_PASTRY_ORDERSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MINI_PASTRY_ORDERSBindingNavigator.BindingSource = Me.MINI_PASTRY_ORDERSBindingSource
        Me.MINI_PASTRY_ORDERSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MINI_PASTRY_ORDERSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MINI_PASTRY_ORDERSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MINI_PASTRY_ORDERSBindingNavigatorSaveItem})
        Me.MINI_PASTRY_ORDERSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MINI_PASTRY_ORDERSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MINI_PASTRY_ORDERSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MINI_PASTRY_ORDERSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MINI_PASTRY_ORDERSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MINI_PASTRY_ORDERSBindingNavigator.Name = "MINI_PASTRY_ORDERSBindingNavigator"
        Me.MINI_PASTRY_ORDERSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MINI_PASTRY_ORDERSBindingNavigator.Size = New System.Drawing.Size(1163, 25)
        Me.MINI_PASTRY_ORDERSBindingNavigator.TabIndex = 0
        Me.MINI_PASTRY_ORDERSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MINI_PASTRY_ORDERSBindingNavigatorSaveItem
        '
        Me.MINI_PASTRY_ORDERSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MINI_PASTRY_ORDERSBindingNavigatorSaveItem.Name = "MINI_PASTRY_ORDERSBindingNavigatorSaveItem"
        Me.MINI_PASTRY_ORDERSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MINI_PASTRY_ORDERSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MINI_PASTRY_ORDERSDataGridView
        '
        Me.MINI_PASTRY_ORDERSDataGridView.AllowUserToAddRows = False
        Me.MINI_PASTRY_ORDERSDataGridView.AllowUserToDeleteRows = False
        Me.MINI_PASTRY_ORDERSDataGridView.AutoGenerateColumns = False
        Me.MINI_PASTRY_ORDERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MINI_PASTRY_ORDERSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewCheckBoxColumn9, Me.DataGridViewCheckBoxColumn10, Me.DataGridViewCheckBoxColumn11, Me.DataGridViewCheckBoxColumn12, Me.DataGridViewCheckBoxColumn13, Me.DataGridViewCheckBoxColumn14, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewCheckBoxColumn15, Me.DataGridViewCheckBoxColumn16, Me.DataGridViewCheckBoxColumn17, Me.DataGridViewCheckBoxColumn18, Me.DataGridViewCheckBoxColumn19, Me.DataGridViewCheckBoxColumn20, Me.DataGridViewCheckBoxColumn21, Me.DataGridViewCheckBoxColumn22, Me.DataGridViewCheckBoxColumn23, Me.DataGridViewCheckBoxColumn24, Me.DataGridViewCheckBoxColumn25, Me.DataGridViewCheckBoxColumn26, Me.DataGridViewCheckBoxColumn27, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewCheckBoxColumn28, Me.DataGridViewCheckBoxColumn29, Me.DataGridViewCheckBoxColumn30, Me.DataGridViewCheckBoxColumn31, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewCheckBoxColumn32, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56})
        Me.MINI_PASTRY_ORDERSDataGridView.DataSource = Me.MINI_PASTRY_ORDERSBindingSource
        Me.MINI_PASTRY_ORDERSDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.MINI_PASTRY_ORDERSDataGridView.Name = "MINI_PASTRY_ORDERSDataGridView"
        Me.MINI_PASTRY_ORDERSDataGridView.ReadOnly = True
        Me.MINI_PASTRY_ORDERSDataGridView.Size = New System.Drawing.Size(695, 421)
        Me.MINI_PASTRY_ORDERSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn57.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn57.MaxInputLength = 500
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Order_Taken_By"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Order_Taken_By"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Phone_Number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone_Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Holiday_Number"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Holiday_Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Order_Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Order_Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Order_Summary"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Order_Summary"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Order_Status"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Order_Status"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Grand_Total"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Grand_Total"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Order_Deposit"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Order_Deposit"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Order_Balance"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Order_Balance"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Mini_Pastries"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Mini_Pastries"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Mini_Bars"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Mini_Bars"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Mini_Cookies"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Mini_Cookies"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Mini_Cannoli"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Mini_Cannoli"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Mini_Eclair"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Mini_Eclair"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "Mini_Cream_Puff"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "Mini_Cream_Puff"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn7
        '
        Me.DataGridViewCheckBoxColumn7.DataPropertyName = "Mini_Key_Lime_Tart"
        Me.DataGridViewCheckBoxColumn7.HeaderText = "Mini_Key_Lime_Tart"
        Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
        Me.DataGridViewCheckBoxColumn7.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "Mini_Fruit_Tart"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "Mini_Fruit_Tart"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn9
        '
        Me.DataGridViewCheckBoxColumn9.DataPropertyName = "Mini_Lemon_Curd_Tart"
        Me.DataGridViewCheckBoxColumn9.HeaderText = "Mini_Lemon_Curd_Tart"
        Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
        Me.DataGridViewCheckBoxColumn9.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn10
        '
        Me.DataGridViewCheckBoxColumn10.DataPropertyName = "Mini_Assorted_Cheesecake"
        Me.DataGridViewCheckBoxColumn10.HeaderText = "Mini_Assorted_Cheesecake"
        Me.DataGridViewCheckBoxColumn10.Name = "DataGridViewCheckBoxColumn10"
        Me.DataGridViewCheckBoxColumn10.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn11
        '
        Me.DataGridViewCheckBoxColumn11.DataPropertyName = "Mini_Pecan_Truffle_Tart"
        Me.DataGridViewCheckBoxColumn11.HeaderText = "Mini_Pecan_Truffle_Tart"
        Me.DataGridViewCheckBoxColumn11.Name = "DataGridViewCheckBoxColumn11"
        Me.DataGridViewCheckBoxColumn11.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn12
        '
        Me.DataGridViewCheckBoxColumn12.DataPropertyName = "Mini_Ganache_Tart"
        Me.DataGridViewCheckBoxColumn12.HeaderText = "Mini_Ganache_Tart"
        Me.DataGridViewCheckBoxColumn12.Name = "DataGridViewCheckBoxColumn12"
        Me.DataGridViewCheckBoxColumn12.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn13
        '
        Me.DataGridViewCheckBoxColumn13.DataPropertyName = "Mini_Chocolate_Mousse_Cups"
        Me.DataGridViewCheckBoxColumn13.HeaderText = "Mini_Chocolate_Mousse_Cups"
        Me.DataGridViewCheckBoxColumn13.Name = "DataGridViewCheckBoxColumn13"
        Me.DataGridViewCheckBoxColumn13.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn14
        '
        Me.DataGridViewCheckBoxColumn14.DataPropertyName = "Assorted_Mini_Pastry_Package"
        Me.DataGridViewCheckBoxColumn14.HeaderText = "Assorted_Mini_Pastry_Package"
        Me.DataGridViewCheckBoxColumn14.Name = "DataGridViewCheckBoxColumn14"
        Me.DataGridViewCheckBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Mini_Cannoli_Total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Mini_Cannoli_Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Mini_Eclair_Total"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Mini_Eclair_Total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Mini_Cream_Puff_Total"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Mini_Cream_Puff_Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Mini_Key_Lime_Tart_Total"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mini_Key_Lime_Tart_Total"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Mini_Fruit_Tart_Total"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Mini_Fruit_Tart_Total"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Mini_Lemon_Curd_Tart_Total"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Mini_Lemon_Curd_Tart_Total"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Assorted_Cheesecake_Total"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Assorted_Cheesecake_Total"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Pecan_Truffle_Tart_Total"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Pecan_Truffle_Tart_Total"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Ganache_Tart_Total"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Ganache_Tart_Total"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Mini_Chocolate_Mousse_Cups_Total"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Mini_Chocolate_Mousse_Cups_Total"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Assorted_Mini_Pastry_Package_Total"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Assorted_Mini_Pastry_Package_Total"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Mousse_Flavor"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Mousse_Flavor"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Mini_Pastry_Total_Price"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Mini_Pastry_Total_Price"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn15
        '
        Me.DataGridViewCheckBoxColumn15.DataPropertyName = "Lemon"
        Me.DataGridViewCheckBoxColumn15.HeaderText = "Lemon"
        Me.DataGridViewCheckBoxColumn15.Name = "DataGridViewCheckBoxColumn15"
        Me.DataGridViewCheckBoxColumn15.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn16
        '
        Me.DataGridViewCheckBoxColumn16.DataPropertyName = "Pecan"
        Me.DataGridViewCheckBoxColumn16.HeaderText = "Pecan"
        Me.DataGridViewCheckBoxColumn16.Name = "DataGridViewCheckBoxColumn16"
        Me.DataGridViewCheckBoxColumn16.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn17
        '
        Me.DataGridViewCheckBoxColumn17.DataPropertyName = "Triple_Berry_Bar"
        Me.DataGridViewCheckBoxColumn17.HeaderText = "Triple_Berry_Bar"
        Me.DataGridViewCheckBoxColumn17.Name = "DataGridViewCheckBoxColumn17"
        Me.DataGridViewCheckBoxColumn17.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn18
        '
        Me.DataGridViewCheckBoxColumn18.DataPropertyName = "Tiger"
        Me.DataGridViewCheckBoxColumn18.HeaderText = "Tiger"
        Me.DataGridViewCheckBoxColumn18.Name = "DataGridViewCheckBoxColumn18"
        Me.DataGridViewCheckBoxColumn18.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn19
        '
        Me.DataGridViewCheckBoxColumn19.DataPropertyName = "Magic"
        Me.DataGridViewCheckBoxColumn19.HeaderText = "Magic"
        Me.DataGridViewCheckBoxColumn19.Name = "DataGridViewCheckBoxColumn19"
        Me.DataGridViewCheckBoxColumn19.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn20
        '
        Me.DataGridViewCheckBoxColumn20.DataPropertyName = "Classic_Brownie"
        Me.DataGridViewCheckBoxColumn20.HeaderText = "Classic_Brownie"
        Me.DataGridViewCheckBoxColumn20.Name = "DataGridViewCheckBoxColumn20"
        Me.DataGridViewCheckBoxColumn20.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn21
        '
        Me.DataGridViewCheckBoxColumn21.DataPropertyName = "Truffle_Brownie"
        Me.DataGridViewCheckBoxColumn21.HeaderText = "Truffle_Brownie"
        Me.DataGridViewCheckBoxColumn21.Name = "DataGridViewCheckBoxColumn21"
        Me.DataGridViewCheckBoxColumn21.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn22
        '
        Me.DataGridViewCheckBoxColumn22.DataPropertyName = "German_Brownie"
        Me.DataGridViewCheckBoxColumn22.HeaderText = "German_Brownie"
        Me.DataGridViewCheckBoxColumn22.Name = "DataGridViewCheckBoxColumn22"
        Me.DataGridViewCheckBoxColumn22.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn23
        '
        Me.DataGridViewCheckBoxColumn23.DataPropertyName = "Apple_Crisp"
        Me.DataGridViewCheckBoxColumn23.HeaderText = "Apple_Crisp"
        Me.DataGridViewCheckBoxColumn23.Name = "DataGridViewCheckBoxColumn23"
        Me.DataGridViewCheckBoxColumn23.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn24
        '
        Me.DataGridViewCheckBoxColumn24.DataPropertyName = "Date_Bar"
        Me.DataGridViewCheckBoxColumn24.HeaderText = "Date_Bar"
        Me.DataGridViewCheckBoxColumn24.Name = "DataGridViewCheckBoxColumn24"
        Me.DataGridViewCheckBoxColumn24.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn25
        '
        Me.DataGridViewCheckBoxColumn25.DataPropertyName = "Cranberry_Magic"
        Me.DataGridViewCheckBoxColumn25.HeaderText = "Cranberry_Magic"
        Me.DataGridViewCheckBoxColumn25.Name = "DataGridViewCheckBoxColumn25"
        Me.DataGridViewCheckBoxColumn25.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn26
        '
        Me.DataGridViewCheckBoxColumn26.DataPropertyName = "Pumpkin"
        Me.DataGridViewCheckBoxColumn26.HeaderText = "Pumpkin"
        Me.DataGridViewCheckBoxColumn26.Name = "DataGridViewCheckBoxColumn26"
        Me.DataGridViewCheckBoxColumn26.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn27
        '
        Me.DataGridViewCheckBoxColumn27.DataPropertyName = "Mini_Bar_Package"
        Me.DataGridViewCheckBoxColumn27.HeaderText = "Mini_Bar_Package"
        Me.DataGridViewCheckBoxColumn27.Name = "DataGridViewCheckBoxColumn27"
        Me.DataGridViewCheckBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Mini_Bars_Total"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Mini_Bars_Total"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Mini_Bar_Total_Price"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Mini_Bar_Total_Price"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn28
        '
        Me.DataGridViewCheckBoxColumn28.DataPropertyName = "Chocolate_Chip"
        Me.DataGridViewCheckBoxColumn28.HeaderText = "Chocolate_Chip"
        Me.DataGridViewCheckBoxColumn28.Name = "DataGridViewCheckBoxColumn28"
        Me.DataGridViewCheckBoxColumn28.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn29
        '
        Me.DataGridViewCheckBoxColumn29.DataPropertyName = "Sugar"
        Me.DataGridViewCheckBoxColumn29.HeaderText = "Sugar"
        Me.DataGridViewCheckBoxColumn29.Name = "DataGridViewCheckBoxColumn29"
        Me.DataGridViewCheckBoxColumn29.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn30
        '
        Me.DataGridViewCheckBoxColumn30.DataPropertyName = "Double_Chocolate_Chip"
        Me.DataGridViewCheckBoxColumn30.HeaderText = "Double_Chocolate_Chip"
        Me.DataGridViewCheckBoxColumn30.Name = "DataGridViewCheckBoxColumn30"
        Me.DataGridViewCheckBoxColumn30.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn31
        '
        Me.DataGridViewCheckBoxColumn31.DataPropertyName = "Oatmeal_Raisin"
        Me.DataGridViewCheckBoxColumn31.HeaderText = "Oatmeal_Raisin"
        Me.DataGridViewCheckBoxColumn31.Name = "DataGridViewCheckBoxColumn31"
        Me.DataGridViewCheckBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Cookie_Dozen"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Cookie_Dozen"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Cookie_Total"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Cookie_Total"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Platter_or_Box"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Platter_or_Box"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Order_Description"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Order_Description"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Order_Message"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Order_Message"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Item_1"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Item_1"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Item_2"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Item_2"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Item_3"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Item_3"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Item_4"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Item_4"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Item_5"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Item_5"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Item_Price_1"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Item_Price_1"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Item_Price_2"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Item_Price_2"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Item_Price_3"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Item_Price_3"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Item_Price_4"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Item_Price_4"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Item_Price_5"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Item_Price_5"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn32
        '
        Me.DataGridViewCheckBoxColumn32.DataPropertyName = "Cancel_Order"
        Me.DataGridViewCheckBoxColumn32.HeaderText = "Cancel_Order"
        Me.DataGridViewCheckBoxColumn32.Name = "DataGridViewCheckBoxColumn32"
        Me.DataGridViewCheckBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Chocolate_Chip_Total"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Chocolate_Chip_Total"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Sugar_Total"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Sugar_Total"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Double_Chocolate_Chip_Total"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Double_Chocolate_Chip_Total"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "Oatmeal_Raisin_Total"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Oatmeal_Raisin_Total"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "Lemon_Total"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Lemon_Total"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "Pecan_Total"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Pecan_Total"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "Triple_Berry_Bar_Total"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Triple_Berry_Bar_Total"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "Tiger_Total"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Tiger_Total"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "Magic_Total"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Magic_Total"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "Classic_Brownie_Total"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Classic_Brownie_Total"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "Truffle_Brownie_Total"
        Me.DataGridViewTextBoxColumn50.HeaderText = "Truffle_Brownie_Total"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "German_Brownie_Total"
        Me.DataGridViewTextBoxColumn51.HeaderText = "German_Brownie_Total"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "Apple_Crisp_Total"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Apple_Crisp_Total"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "Date_Bar_Total"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Date_Bar_Total"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "Cranberry_Magic_Total"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Cranberry_Magic_Total"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "Pumpkin_Total"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Pumpkin_Total"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "Mini_Bar_Package_Total"
        Me.DataGridViewTextBoxColumn56.HeaderText = "Mini_Bar_Package_Total"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(882, 98)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 31)
        Me.IDTextBox.TabIndex = 3
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Customer_Name", True))
        Me.Customer_NameTextBox.Enabled = False
        Me.Customer_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(882, 135)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(200, 31)
        Me.Customer_NameTextBox.TabIndex = 5
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Phone_Number", True))
        Me.Phone_NumberTextBox.Enabled = False
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(882, 172)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(200, 31)
        Me.Phone_NumberTextBox.TabIndex = 7
        '
        'Holiday_NumberTextBox
        '
        Me.Holiday_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Holiday_Number", True))
        Me.Holiday_NumberTextBox.Enabled = False
        Me.Holiday_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Holiday_NumberTextBox.Location = New System.Drawing.Point(881, 209)
        Me.Holiday_NumberTextBox.Name = "Holiday_NumberTextBox"
        Me.Holiday_NumberTextBox.Size = New System.Drawing.Size(200, 31)
        Me.Holiday_NumberTextBox.TabIndex = 9
        '
        'Order_DateDateTimePicker
        '
        Me.Order_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MINI_PASTRY_ORDERSBindingSource, "Order_Date", True))
        Me.Order_DateDateTimePicker.Enabled = False
        Me.Order_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_DateDateTimePicker.Location = New System.Drawing.Point(881, 246)
        Me.Order_DateDateTimePicker.Name = "Order_DateDateTimePicker"
        Me.Order_DateDateTimePicker.Size = New System.Drawing.Size(269, 26)
        Me.Order_DateDateTimePicker.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(995, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 65)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "View/Print Orders"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(740, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 65)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Edit Orders"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SearchCustomer1ToolStrip
        '
        Me.SearchCustomer1ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.SearchCustomer1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Customer_NameToolStripLabel, Me.Customer_NameToolStripTextBox})
        Me.SearchCustomer1ToolStrip.Location = New System.Drawing.Point(273, 0)
        Me.SearchCustomer1ToolStrip.Name = "SearchCustomer1ToolStrip"
        Me.SearchCustomer1ToolStrip.Size = New System.Drawing.Size(211, 25)
        Me.SearchCustomer1ToolStrip.TabIndex = 14
        Me.SearchCustomer1ToolStrip.Text = "SearchCustomer1ToolStrip"
        '
        'Customer_NameToolStripLabel
        '
        Me.Customer_NameToolStripLabel.Name = "Customer_NameToolStripLabel"
        Me.Customer_NameToolStripLabel.Size = New System.Drawing.Size(97, 22)
        Me.Customer_NameToolStripLabel.Text = "Customer Name:"
        '
        'Customer_NameToolStripTextBox
        '
        Me.Customer_NameToolStripTextBox.BackColor = System.Drawing.Color.Yellow
        Me.Customer_NameToolStripTextBox.Name = "Customer_NameToolStripTextBox"
        Me.Customer_NameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
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
        'View_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 457)
        Me.Controls.Add(Me.SearchCustomer1ToolStrip)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Order_DateLabel)
        Me.Controls.Add(Me.Order_DateDateTimePicker)
        Me.Controls.Add(Holiday_NumberLabel)
        Me.Controls.Add(Me.Holiday_NumberTextBox)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Customer_NameLabel)
        Me.Controls.Add(Me.Customer_NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.MINI_PASTRY_ORDERSDataGridView)
        Me.Controls.Add(Me.MINI_PASTRY_ORDERSBindingNavigator)
        Me.Name = "View_Orders"
        Me.Text = "View_Orders"
        CType(Me.MINI_PASTRY_ORDERSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MINI_PASTRY_ORDERSBindingNavigator.ResumeLayout(False)
        Me.MINI_PASTRY_ORDERSBindingNavigator.PerformLayout()
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINI_PASTRY_ORDERSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchCustomer1ToolStrip.ResumeLayout(False)
        Me.SearchCustomer1ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bakery_OrdersDataSet As Bakery_OrdersDataSet
    Friend WithEvents MINI_PASTRY_ORDERSBindingSource As BindingSource
    Friend WithEvents MINI_PASTRY_ORDERSTableAdapter As Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter
    Friend WithEvents TableAdapterManager As Bakery_OrdersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MINI_PASTRY_ORDERSBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MINI_PASTRY_ORDERSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MINI_PASTRY_ORDERSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn9 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn10 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn11 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn12 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn13 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn14 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn15 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn16 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn17 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn18 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn19 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn20 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn21 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn22 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn23 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn24 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn25 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn26 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn27 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn28 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn29 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn30 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn31 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn32 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Customer_NameTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents Holiday_NumberTextBox As TextBox
    Friend WithEvents Order_DateDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SearchCustomer1ToolStrip As ToolStrip
    Friend WithEvents Customer_NameToolStripLabel As ToolStripLabel
    Friend WithEvents Customer_NameToolStripTextBox As ToolStripTextBox
End Class
