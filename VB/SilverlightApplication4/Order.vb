Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Namespace SilverlightApplication4
	Public Class Order
		Private privateOrderId As Integer
		Public Property OrderId() As Integer
			Get
				Return privateOrderId
			End Get
			Set(ByVal value As Integer)
				privateOrderId = value
			End Set
		End Property
		Private privateDescription As String
		Public Property Description() As String
			Get
				Return privateDescription
			End Get
			Set(ByVal value As String)
				privateDescription = value
			End Set
		End Property
		Private privatePrice As Decimal
		Public Property Price() As Decimal
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Decimal)
				privatePrice = value
			End Set
		End Property

		Public Shared Function GetOrders() As List(Of Order)
			Dim orders As List(Of Order) = New List(Of Order)()
			orders.Add(New Order() With {.OrderId = 0, .Description = "Sterio", .Price = 2000})
			orders.Add(New Order() With {.OrderId = 1, .Description = "XP Radio", .Price = 1000})
			orders.Add(New Order() With {.OrderId = 2, .Description = "Cell Phone", .Price = 200})
			orders.Add(New Order() With {.OrderId = 3, .Description = "Sterio", .Price = 2000})
			orders.Add(New Order() With {.OrderId = 4, .Description = "Cell Phone", .Price = 200})
			orders.Add(New Order() With {.OrderId = 5, .Description = "Head Set", .Price = 100})
			orders.Add(New Order() With {.OrderId = 6, .Description = "Keyboard", .Price = 100})
			orders.Add(New Order() With {.OrderId = 7, .Description = "Cell Phone", .Price = 200})
			Return orders
		End Function
	End Class
End Namespace
