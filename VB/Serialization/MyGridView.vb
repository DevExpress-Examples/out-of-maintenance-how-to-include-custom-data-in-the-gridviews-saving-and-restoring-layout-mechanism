Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System

Namespace Serialization
	Public Delegate Sub AllowSerializePropertyEventHandler(ByVal sender As Object, ByVal e As AllowSerializePropertyEventArgs)
	Public Delegate Sub SerializeCustomPropertiesEventHandler(ByVal sender As Object, ByVal e As SerializeCustomPropertiesEventArgs)
	Public Delegate Sub CustomPropertyValueEventHandler(ByVal sender As Object, ByVal e As CustomPropertyValueEventArgs)

	Public Class MyGridView
		Inherits GridView
		Public Sub New(ByVal ownerGrid As GridControl)
			MyBase.New(ownerGrid)
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		Protected Overrides Sub SaveLayoutCore(ByVal serializer As XtraSerializer, ByVal path As Object, ByVal options As OptionsLayoutBase)
			If TypeOf serializer Is XmlXtraSerializer Then
				serializer = New MyXmlXtraSerializer()
			End If

			MyBase.SaveLayoutCore(serializer, path, options)
		End Sub

		Protected Overrides Sub RestoreLayoutCore(ByVal serializer As XtraSerializer, ByVal path As Object, ByVal options As OptionsLayoutBase)
			If TypeOf serializer Is XmlXtraSerializer Then
				serializer = New MyXmlXtraSerializer()
			End If

			MyBase.RestoreLayoutCore(serializer, path, options)
		End Sub

		Public Event AllowSerializeProperty As AllowSerializePropertyEventHandler
		Protected Friend Overridable Sub RaiseAllowSerialzeProperty(ByVal args As AllowSerializePropertyEventArgs)
			RaiseEvent AllowSerializeProperty(Me, args)
		End Sub

		Public Event SerializeCustomProperties As SerializeCustomPropertiesEventHandler
		Protected Friend Overridable Sub RaiseSerializeCustomProperties(ByVal args As SerializeCustomPropertiesEventArgs)
			RaiseEvent SerializeCustomProperties(Me, args)
		End Sub

		Public Event DeserializeCustomProperties As SerializeCustomPropertiesEventHandler
		Protected Friend Overridable Sub RaiseDeserializeCustomProperties(ByVal args As SerializeCustomPropertiesEventArgs)
			RaiseEvent DeserializeCustomProperties(Me, args)
		End Sub

		Public Event SetCustomPropertyValue As CustomPropertyValueEventHandler
		Protected Friend Overridable Sub RaiseSetCustomPropertyValue(ByVal args As CustomPropertyValueEventArgs)
			RaiseEvent SetCustomPropertyValue(Me, args)
		End Sub

		Public Event GetCustomPropertyValue As CustomPropertyValueEventHandler
		Protected Friend Overridable Sub RaiseGetCustomPropertyValue(ByVal args As CustomPropertyValueEventArgs)
			RaiseEvent GetCustomPropertyValue(Me, args)
		End Sub
	End Class
End Namespace
