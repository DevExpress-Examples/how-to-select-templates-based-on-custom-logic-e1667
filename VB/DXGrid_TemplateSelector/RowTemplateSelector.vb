Imports DevExpress.Xpf.Grid
Imports System
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls

Namespace DXGrid_TemplateSelector
	Public Class RowTemplateSelector
		Inherits DataTemplateSelector

		Public Property EvenRowTemplate() As DataTemplate
		Public Property OddRowTemplate() As DataTemplate
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim row As RowData = TryCast(item, RowData)
			If row IsNot Nothing Then
				Return If(row.EvenRow, EvenRowTemplate, OddRowTemplate)
			End If
			Return MyBase.SelectTemplate(item, container)
		End Function
	End Class
End Namespace
