Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows

Namespace DXGrid_TemplateSelector

	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = IssueDataObject.GetData()
		End Sub
	End Class

	Public Class IssueDataObject
		Public Property IssueName() As String
		Public Shared Function GetData() As List(Of IssueDataObject)
			Dim data As New List(Of IssueDataObject)()
			data.Add(New IssueDataObject() With {.IssueName = "Transaction History"})
			data.Add(New IssueDataObject() With {.IssueName = "Ledger: Inconsistency"})
			data.Add(New IssueDataObject() With {.IssueName = "Data Import"})
			data.Add(New IssueDataObject() With {.IssueName = "Data Archiving"})
			Return data
		End Function
	End Class
End Namespace
