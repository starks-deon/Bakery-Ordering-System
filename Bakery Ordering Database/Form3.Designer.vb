<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MINI_PASTRY_ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bakery_OrdersDataSet = New Bakery_Ordering_Database.Bakery_OrdersDataSet()
        Me.ReportExecutionService1 = New Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService()
        Me.MINI_PASTRY_ORDERSTableAdapter = New Bakery_Ordering_Database.Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportExecutionService1
        '
        Me.ReportExecutionService1.Credentials = Nothing
        Me.ReportExecutionService1.ExecutionHeaderValue = Nothing
        Me.ReportExecutionService1.ServerInfoHeaderValue = Nothing
        Me.ReportExecutionService1.TrustedUserHeaderValue = Nothing
        Me.ReportExecutionService1.Url = "http://localhost/ReportServer/ReportExecution2005.asmx"
        Me.ReportExecutionService1.UseDefaultCredentials = False
        '
        'MINI_PASTRY_ORDERSTableAdapter
        '
        Me.MINI_PASTRY_ORDERSTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Mini_Pastry_Order"
        ReportDataSource1.Value = Me.MINI_PASTRY_ORDERSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Bakery_Ordering_Database.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(902, 593)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(940, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 100)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Edit Order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 593)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.MINI_PASTRY_ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bakery_OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportExecutionService1 As Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService
    Friend WithEvents MINI_PASTRY_ORDERSBindingSource As BindingSource
    Friend WithEvents Bakery_OrdersDataSet As Bakery_OrdersDataSet
    Friend WithEvents MINI_PASTRY_ORDERSTableAdapter As Bakery_OrdersDataSetTableAdapters.MINI_PASTRY_ORDERSTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button2 As Button
End Class
