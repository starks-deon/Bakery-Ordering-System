<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cookies
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
        Dim Chocolate_ChipLabel As System.Windows.Forms.Label
        Dim SugarLabel As System.Windows.Forms.Label
        Dim Double_Chocolate_ChipLabel As System.Windows.Forms.Label
        Dim Oatmeal_RaisinLabel As System.Windows.Forms.Label
        Dim Cookie_TotalLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.Chocolate_ChipCheckBox = New System.Windows.Forms.CheckBox()
        Me.MINI_PASTRY_ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bakery_OrdersDataSet = New Bakery_Ordering_Database.Bakery_OrdersDataSet()
        Me.SugarCheckBox = New System.Windows.Forms.CheckBox()
        Me.Double_Chocolate_ChipCheckBox = New System.Windows.Forms.CheckBox()
        Me.Oatmeal_RaisinCheckBox = New System.Windows.Forms.CheckBox()
        Me.Chocolate_Chip_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Sugar_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Double_Chocolate_Chip_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Oatmeal_Raisin_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Cookie_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MINI_PASTRY_ORDERSTableAdapter = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter()
        Me.TableAdapterManager = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.TableAdapterManager()
        Me.Button2 = New System.Windows.Forms.Button()
        Chocolate_ChipLabel = New System.Windows.Forms.Label()
        SugarLabel = New System.Windows.Forms.Label()
        Double_Chocolate_ChipLabel = New System.Windows.Forms.Label()
        Oatmeal_RaisinLabel = New System.Windows.Forms.Label()
        Cookie_TotalLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chocolate_ChipLabel
        '
        Chocolate_ChipLabel.AutoSize = True
        Chocolate_ChipLabel.Location = New System.Drawing.Point(12, 52)
        Chocolate_ChipLabel.Name = "Chocolate_ChipLabel"
        Chocolate_ChipLabel.Size = New System.Drawing.Size(82, 13)
        Chocolate_ChipLabel.TabIndex = 1
        Chocolate_ChipLabel.Text = "Chocolate Chip:"
        '
        'SugarLabel
        '
        SugarLabel.AutoSize = True
        SugarLabel.Location = New System.Drawing.Point(12, 74)
        SugarLabel.Name = "SugarLabel"
        SugarLabel.Size = New System.Drawing.Size(38, 13)
        SugarLabel.TabIndex = 2
        SugarLabel.Text = "Sugar:"
        '
        'Double_Chocolate_ChipLabel
        '
        Double_Chocolate_ChipLabel.AutoSize = True
        Double_Chocolate_ChipLabel.Location = New System.Drawing.Point(12, 96)
        Double_Chocolate_ChipLabel.Name = "Double_Chocolate_ChipLabel"
        Double_Chocolate_ChipLabel.Size = New System.Drawing.Size(119, 13)
        Double_Chocolate_ChipLabel.TabIndex = 4
        Double_Chocolate_ChipLabel.Text = "Double Chocolate Chip:"
        '
        'Oatmeal_RaisinLabel
        '
        Oatmeal_RaisinLabel.AutoSize = True
        Oatmeal_RaisinLabel.Location = New System.Drawing.Point(13, 119)
        Oatmeal_RaisinLabel.Name = "Oatmeal_RaisinLabel"
        Oatmeal_RaisinLabel.Size = New System.Drawing.Size(81, 13)
        Oatmeal_RaisinLabel.TabIndex = 6
        Oatmeal_RaisinLabel.Text = "Oatmeal Raisin:"
        '
        'Cookie_TotalLabel
        '
        Cookie_TotalLabel.AutoSize = True
        Cookie_TotalLabel.Location = New System.Drawing.Point(108, 159)
        Cookie_TotalLabel.Name = "Cookie_TotalLabel"
        Cookie_TotalLabel.Size = New System.Drawing.Size(70, 13)
        Cookie_TotalLabel.TabIndex = 16
        Cookie_TotalLabel.Text = "Cookie Total:"
        AddHandler Cookie_TotalLabel.Click, AddressOf Me.Cookie_TotalLabel_Click
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(157, 14)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 21
        IDLabel.Text = "ID:"
        '
        'Chocolate_ChipCheckBox
        '
        Me.Chocolate_ChipCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Chocolate_Chip", True))
        Me.Chocolate_ChipCheckBox.Location = New System.Drawing.Point(137, 47)
        Me.Chocolate_ChipCheckBox.Name = "Chocolate_ChipCheckBox"
        Me.Chocolate_ChipCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.Chocolate_ChipCheckBox.TabIndex = 2
        Me.Chocolate_ChipCheckBox.UseVisualStyleBackColor = True
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
        'SugarCheckBox
        '
        Me.SugarCheckBox.Location = New System.Drawing.Point(137, 69)
        Me.SugarCheckBox.Name = "SugarCheckBox"
        Me.SugarCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.SugarCheckBox.TabIndex = 3
        Me.SugarCheckBox.UseVisualStyleBackColor = True
        '
        'Double_Chocolate_ChipCheckBox
        '
        Me.Double_Chocolate_ChipCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Double_Chocolate_Chip", True))
        Me.Double_Chocolate_ChipCheckBox.Location = New System.Drawing.Point(137, 91)
        Me.Double_Chocolate_ChipCheckBox.Name = "Double_Chocolate_ChipCheckBox"
        Me.Double_Chocolate_ChipCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.Double_Chocolate_ChipCheckBox.TabIndex = 5
        Me.Double_Chocolate_ChipCheckBox.UseVisualStyleBackColor = True
        '
        'Oatmeal_RaisinCheckBox
        '
        Me.Oatmeal_RaisinCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MINI_PASTRY_ORDERSBindingSource, "Oatmeal_Raisin", True))
        Me.Oatmeal_RaisinCheckBox.Location = New System.Drawing.Point(137, 114)
        Me.Oatmeal_RaisinCheckBox.Name = "Oatmeal_RaisinCheckBox"
        Me.Oatmeal_RaisinCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.Oatmeal_RaisinCheckBox.TabIndex = 7
        Me.Oatmeal_RaisinCheckBox.UseVisualStyleBackColor = True
        '
        'Chocolate_Chip_TotalTextBox
        '
        Me.Chocolate_Chip_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Chocolate_Chip_Total", True))
        Me.Chocolate_Chip_TotalTextBox.Enabled = False
        Me.Chocolate_Chip_TotalTextBox.Location = New System.Drawing.Point(346, 49)
        Me.Chocolate_Chip_TotalTextBox.Name = "Chocolate_Chip_TotalTextBox"
        Me.Chocolate_Chip_TotalTextBox.Size = New System.Drawing.Size(49, 20)
        Me.Chocolate_Chip_TotalTextBox.TabIndex = 9
        '
        'Sugar_TotalTextBox
        '
        Me.Sugar_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Sugar_Total", True))
        Me.Sugar_TotalTextBox.Enabled = False
        Me.Sugar_TotalTextBox.Location = New System.Drawing.Point(346, 71)
        Me.Sugar_TotalTextBox.Name = "Sugar_TotalTextBox"
        Me.Sugar_TotalTextBox.Size = New System.Drawing.Size(49, 20)
        Me.Sugar_TotalTextBox.TabIndex = 11
        '
        'Double_Chocolate_Chip_TotalTextBox
        '
        Me.Double_Chocolate_Chip_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Double_Chocolate_Chip_Total", True))
        Me.Double_Chocolate_Chip_TotalTextBox.Enabled = False
        Me.Double_Chocolate_Chip_TotalTextBox.Location = New System.Drawing.Point(346, 93)
        Me.Double_Chocolate_Chip_TotalTextBox.Name = "Double_Chocolate_Chip_TotalTextBox"
        Me.Double_Chocolate_Chip_TotalTextBox.Size = New System.Drawing.Size(49, 20)
        Me.Double_Chocolate_Chip_TotalTextBox.TabIndex = 13
        '
        'Oatmeal_Raisin_TotalTextBox
        '
        Me.Oatmeal_Raisin_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Oatmeal_Raisin_Total", True))
        Me.Oatmeal_Raisin_TotalTextBox.Enabled = False
        Me.Oatmeal_Raisin_TotalTextBox.Location = New System.Drawing.Point(346, 116)
        Me.Oatmeal_Raisin_TotalTextBox.Name = "Oatmeal_Raisin_TotalTextBox"
        Me.Oatmeal_Raisin_TotalTextBox.Size = New System.Drawing.Size(49, 20)
        Me.Oatmeal_Raisin_TotalTextBox.TabIndex = 15
        '
        'Cookie_TotalTextBox
        '
        Me.Cookie_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "Cookie_Total", True))
        Me.Cookie_TotalTextBox.Location = New System.Drawing.Point(184, 156)
        Me.Cookie_TotalTextBox.Name = "Cookie_TotalTextBox"
        Me.Cookie_TotalTextBox.Size = New System.Drawing.Size(34, 20)
        Me.Cookie_TotalTextBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Chocolate Chip Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Sugar Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Double Chocolate Chip Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Oatmeal Raisin Total:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MINI_PASTRY_ORDERSBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(184, 11)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(34, 20)
        Me.IDTextBox.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 53)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Save and Close"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(229, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 53)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Cookies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 244)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Cookie_TotalLabel)
        Me.Controls.Add(Me.Cookie_TotalTextBox)
        Me.Controls.Add(Me.Oatmeal_Raisin_TotalTextBox)
        Me.Controls.Add(Me.Double_Chocolate_Chip_TotalTextBox)
        Me.Controls.Add(Me.Sugar_TotalTextBox)
        Me.Controls.Add(Me.Chocolate_Chip_TotalTextBox)
        Me.Controls.Add(Oatmeal_RaisinLabel)
        Me.Controls.Add(Me.Oatmeal_RaisinCheckBox)
        Me.Controls.Add(Double_Chocolate_ChipLabel)
        Me.Controls.Add(Me.Double_Chocolate_ChipCheckBox)
        Me.Controls.Add(SugarLabel)
        Me.Controls.Add(Me.SugarCheckBox)
        Me.Controls.Add(Chocolate_ChipLabel)
        Me.Controls.Add(Me.Chocolate_ChipCheckBox)
        Me.Name = "Cookies"
        Me.Text = " "
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bakery_OrdersDataSet As Bakery_OrdersDataSet
    Friend WithEvents MINI_PASTRY_ORDERSBindingSource As BindingSource
    Friend WithEvents MINI_PASTRY_ORDERSTableAdapter As Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter
    Friend WithEvents TableAdapterManager As Bakery_OrdersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Chocolate_ChipCheckBox As CheckBox
    Friend WithEvents SugarCheckBox As CheckBox
    Friend WithEvents Double_Chocolate_ChipCheckBox As CheckBox
    Friend WithEvents Oatmeal_RaisinCheckBox As CheckBox
    Friend WithEvents Chocolate_Chip_TotalTextBox As TextBox
    Friend WithEvents Sugar_TotalTextBox As TextBox
    Friend WithEvents Double_Chocolate_Chip_TotalTextBox As TextBox
    Friend WithEvents Oatmeal_Raisin_TotalTextBox As TextBox
    Friend WithEvents Cookie_TotalTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
