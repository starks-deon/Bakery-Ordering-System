Partial Class Bakery_OrdersDataSet
    Partial Public Class MINI_PASTRY_ORDERSDataTable
        Private Sub MINI_PASTRY_ORDERSDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Mini_Bars_TotalColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub MINI_PASTRY_ORDERSDataTable_MINI_PASTRY_ORDERSRowChanging(sender As Object, e As MINI_PASTRY_ORDERSRowChangeEvent) Handles Me.MINI_PASTRY_ORDERSRowChanging

        End Sub

    End Class

    Partial Public Class MINI_PASTRY_ORDERS2DataTable




    End Class

    Partial Public Class Customer_ListDataTable
        Private Sub Customer_ListDataTable_Customer_ListRowChanging(sender As Object, e As Customer_ListRowChangeEvent) Handles Me.Customer_ListRowChanging

        End Sub

    End Class
End Class

Namespace Bakery_OrdersDataSetTableAdapters
    Partial Public Class MINI_PASTRY_ORDERSTableAdapter
    End Class

    Partial Public Class MINI_PASTRY_ORDERS2TableAdapter
    End Class
End Namespace

Namespace Bakery_OrdersDataSetTableAdapters
    Partial Public Class MINI_PASTRY_ORDERSTableAdapter
    End Class
End Namespace

Namespace Bakery_OrdersDataSetTableAdapters
    Partial Public Class MINI_PASTRY_ORDERSTableAdapter
    End Class
End Namespace

Namespace Bakery_OrdersDataSetTableAdapters
    Partial Public Class MINI_PASTRY_ORDERSTableAdapter
    End Class
End Namespace
