<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Customer_ListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Customer_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bakery_OrdersDataSet = New Bakery_Ordering_Database.Bakery_OrdersDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Customer_ListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Customer_ListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_NameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Customer_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Customer_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Customer_ListTableAdapter = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.Customer_ListTableAdapter()
        Me.TableAdapterManager = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.TableAdapterManager()
        Me.Customer_ListTableAdapter1 = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.Customer_ListTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.Customer_ListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customer_ListBindingNavigator.SuspendLayout()
        CType(Me.Customer_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_ListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customer_NameToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(558, 88)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(32, 24)
        IDLabel.TabIndex = 3
        IDLabel.Text = "ID:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_NameLabel.Location = New System.Drawing.Point(558, 125)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(152, 24)
        Customer_NameLabel.TabIndex = 5
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.Location = New System.Drawing.Point(558, 162)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(145, 24)
        Phone_NumberLabel.TabIndex = 7
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Customer_ListBindingNavigator
        '
        Me.Customer_ListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Customer_ListBindingNavigator.BindingSource = Me.Customer_ListBindingSource
        Me.Customer_ListBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Customer_ListBindingNavigator.DeleteItem = Nothing
        Me.Customer_ListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Customer_ListBindingNavigatorSaveItem})
        Me.Customer_ListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Customer_ListBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Customer_ListBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Customer_ListBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Customer_ListBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Customer_ListBindingNavigator.Name = "Customer_ListBindingNavigator"
        Me.Customer_ListBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Customer_ListBindingNavigator.Size = New System.Drawing.Size(972, 25)
        Me.Customer_ListBindingNavigator.TabIndex = 0
        Me.Customer_ListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(131, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add New Customer"
        '
        'Customer_ListBindingSource
        '
        Me.Customer_ListBindingSource.DataMember = "Customer_List"
        Me.Customer_ListBindingSource.DataSource = Me.Bakery_OrdersDataSet
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
        'Customer_ListBindingNavigatorSaveItem
        '
        Me.Customer_ListBindingNavigatorSaveItem.Image = CType(resources.GetObject("Customer_ListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Customer_ListBindingNavigatorSaveItem.Name = "Customer_ListBindingNavigatorSaveItem"
        Me.Customer_ListBindingNavigatorSaveItem.Size = New System.Drawing.Size(106, 22)
        Me.Customer_ListBindingNavigatorSaveItem.Text = "Save Customer"
        '
        'Customer_ListDataGridView
        '
        Me.Customer_ListDataGridView.AllowUserToDeleteRows = False
        Me.Customer_ListDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_ListDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Customer_ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customer_ListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Customer_ListDataGridView.DataSource = Me.Customer_ListBindingSource
        Me.Customer_ListDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Customer_ListDataGridView.Name = "Customer_ListDataGridView"
        Me.Customer_ListDataGridView.Size = New System.Drawing.Size(550, 489)
        Me.Customer_ListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 155
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Phone_Number"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 148
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher2
        '
        Me.DirectorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Customer_NameToolStrip
        '
        Me.Customer_NameToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Customer_NameToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Customer_NameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Customer_NameToolStripLabel, Me.Customer_NameToolStripTextBox})
        Me.Customer_NameToolStrip.Location = New System.Drawing.Point(460, 0)
        Me.Customer_NameToolStrip.Name = "Customer_NameToolStrip"
        Me.Customer_NameToolStrip.Size = New System.Drawing.Size(202, 25)
        Me.Customer_NameToolStrip.TabIndex = 2
        Me.Customer_NameToolStrip.Text = "Customer_NameToolStrip"
        '
        'Customer_NameToolStripLabel
        '
        Me.Customer_NameToolStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Customer_NameToolStripLabel.Name = "Customer_NameToolStripLabel"
        Me.Customer_NameToolStripLabel.Size = New System.Drawing.Size(97, 22)
        Me.Customer_NameToolStripLabel.Text = "Customer Name:"
        '
        'Customer_NameToolStripTextBox
        '
        Me.Customer_NameToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Customer_NameToolStripTextBox.Name = "Customer_NameToolStripTextBox"
        Me.Customer_NameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_ListBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(736, 85)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(224, 29)
        Me.IDTextBox.TabIndex = 4
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_ListBindingSource, "Customer_Name", True))
        Me.Customer_NameTextBox.Enabled = False
        Me.Customer_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(736, 122)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(224, 29)
        Me.Customer_NameTextBox.TabIndex = 6
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_ListBindingSource, "Phone_Number", True))
        Me.Phone_NumberTextBox.Enabled = False
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(736, 159)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(224, 29)
        Me.Phone_NumberTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(562, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(398, 69)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Start Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Customer_ListTableAdapter
        '
        Me.Customer_ListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_ListTableAdapter = Me.Customer_ListTableAdapter
        Me.TableAdapterManager.MINI_PASTRY_ORDERSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Customer_ListTableAdapter1
        '
        Me.Customer_ListTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(972, 515)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Customer_NameLabel)
        Me.Controls.Add(Me.Customer_NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Customer_NameToolStrip)
        Me.Controls.Add(Me.Customer_ListDataGridView)
        Me.Controls.Add(Me.Customer_ListBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "                                "
        CType(Me.Customer_ListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customer_ListBindingNavigator.ResumeLayout(False)
        Me.Customer_ListBindingNavigator.PerformLayout()
        CType(Me.Customer_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_ListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customer_NameToolStrip.ResumeLayout(False)
        Me.Customer_NameToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bakery_OrdersDataSet As Bakery_OrdersDataSet
    Friend WithEvents Customer_ListTableAdapter As Bakery_OrdersDataSetTableAdapters.Customer_ListTableAdapter
    Friend WithEvents TableAdapterManager As Bakery_OrdersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Customer_ListBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Customer_ListBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Customer_ListDataGridView As DataGridView
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents Customer_NameToolStrip As ToolStrip
    Friend WithEvents Customer_NameToolStripLabel As ToolStripLabel
    Friend WithEvents Customer_NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents Customer_ListBindingSource As BindingSource
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Customer_NameTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Customer_ListTableAdapter1 As Bakery_OrdersDataSetTableAdapters.Customer_ListTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
