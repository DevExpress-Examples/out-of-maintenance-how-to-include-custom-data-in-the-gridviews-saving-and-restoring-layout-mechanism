Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base

Namespace Serialization
	Public Class MyGridControl
		Inherits GridControl
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("MyGridView")
		End Function

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridInfoRegistrator())
		End Sub
	End Class
End Namespace
