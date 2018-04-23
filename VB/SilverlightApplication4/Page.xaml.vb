Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Controls
Imports System.Windows.Media
Imports DevExpress.Xpf.Editors
Imports DevExpress.AgDataGrid

Namespace SilverlightApplication4
	Partial Public Class Page
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			dataGrid.DataSource = Order.GetOrders()
			dataGrid.ApplyTemplate()
			AddHandler dataGrid.Columns("Price").PrepareCellDisplayElement, AddressOf Page_PrepareCellDisplayElement
		End Sub

		Private Sub Page_PrepareCellDisplayElement(ByVal sender As Object, ByVal e As PrepareCellDisplayElementEventArgs)

			Dim order As Order = CType(e.DisplayElement.DataContext, Order)
			Dim editor As TextEdit = CType(e.DisplayElement, TextEdit)
			If order.Price > 200 Then
				editor.Foreground = New SolidColorBrush(Colors.Red)
			End If
		End Sub
	End Class
End Namespace