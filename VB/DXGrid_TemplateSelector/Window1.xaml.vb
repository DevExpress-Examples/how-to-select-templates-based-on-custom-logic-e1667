Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid

Namespace DXGrid_TemplateSelector

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = IssueList.GetData()
		End Sub
	End Class

	Public Class RowTemplateSelector
		Inherits DataTemplateSelector
		Public Overrides Function SelectTemplate(ByVal item As Object, _
				ByVal container As DependencyObject) As DataTemplate
			Dim row As RowData = TryCast(item, RowData)
			Dim presenter As FrameworkElement = TryCast(container, FrameworkElement)
			If row IsNot Nothing AndAlso presenter IsNot Nothing Then
				Return If(row.EvenRow, CType(presenter.FindResource("evenRowTemplate"), _
					DataTemplate), CType(presenter.FindResource("oddRowTemplate"), _
					DataTemplate))
			End If
			Return MyBase.SelectTemplate(item, container)
		End Function
	End Class

	Public Class IssueList
		Public Shared Function GetData() As List(Of IssueDataObject)
			Dim data As New List(Of IssueDataObject)()
			data.Add(New IssueDataObject() With {.IssueName = "Transaction History"})
			data.Add(New IssueDataObject() With {.IssueName = "Ledger: Inconsistency"})
			data.Add(New IssueDataObject() With {.IssueName = "Data Import"})
			data.Add(New IssueDataObject() With {.IssueName = "Data Archiving"})
			Return data
		End Function
	End Class

	Public Class IssueDataObject
		Private privateIssueName As String
		Public Property IssueName() As String
			Get
				Return privateIssueName
			End Get
			Set(ByVal value As String)
				privateIssueName = value
			End Set
		End Property
	End Class
End Namespace
