Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils.Serializing.Helpers

Namespace Serialization
	Public Class MyDeserializeHelper
		Inherits DeserializeHelper
		Public Sub New(ByVal rootObject As Object)
			MyBase.New(rootObject)
		End Sub
		Public Sub New(ByVal rootObject As Object, ByVal resetProperties As Boolean)
			MyBase.New(rootObject, resetProperties)
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function CreateSerializationContext() As SerializationContext
			Dim newContext As New MySerializationContext()
			newContext.DeserializeHelper = Me

			Return newContext
		End Function

		Friend ReadOnly Overloads Property RootObject() As Object
			Get
				Return rootObject
			End Get
		End Property
	End Class
End Namespace
