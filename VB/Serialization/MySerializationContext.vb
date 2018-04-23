Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.Utils.Serializing
Imports DevExpress.Utils.Serializing.Helpers

Namespace Serialization
	Public Class MySerializationContext
		Inherits SerializationContext
		Private customProperties() As String

		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function AllowProperty(ByVal helper As SerializeHelperBase, ByVal obj As Object, ByVal prop As PropertyDescriptor, ByVal options As OptionsLayoutBase, ByVal isSerializing As Boolean) As Boolean
			Dim myHelper As MyDeserializeHelper = TryCast(helper, MyDeserializeHelper)
			If myHelper Is Nothing OrElse Not(TypeOf myHelper.RootObject Is MyGridView) Then
				Return MyBase.AllowProperty(helper, obj, prop, options, isSerializing)
			End If

			Dim allow As Boolean = MyBase.AllowProperty(helper, obj, prop, options, isSerializing)
			If customProperties Is Nothing OrElse Array.IndexOf(customProperties, prop.Name) = -1 Then
				Return allow
			End If

			Dim propInfos() As PropertyInfo = obj.GetType().GetProperties(BindingFlags.Public Or BindingFlags.Instance)
			Dim [property] As PropertyInfo = Array.Find(propInfos, Function(info) info.Name = prop.Name)
			Return [property] IsNot Nothing
		End Function

		Protected Overrides Sub CustomGetSerializableProperties(ByVal obj As Object, ByVal pairsList As List(Of SerializablePropertyDescriptorPair), ByVal props As PropertyDescriptorCollection)
			MyBase.CustomGetSerializableProperties(obj, pairsList, props)
			If DeserializeHelper Is Nothing OrElse DeserializeHelper.RootObject Is Nothing OrElse Not(TypeOf DeserializeHelper.RootObject Is MyGridView) Then
				Return
			End If

			Dim args As New SerializeCustomPropertiesEventArgs(obj)
			CType(DeserializeHelper.RootObject, MyGridView).RaiseDeserializeCustomProperties(args)
			customProperties = args.PropertyNames
			If customProperties Is Nothing Then
				Return
			End If

			For Each customProperty As String In customProperties
				For i As Integer = 0 To pairsList.Count - 1
					If pairsList(i).Property.Name = customProperty Then
						Dim attribute As XtraSerializableProperty = TryCast(pairsList(i).Property.Attributes(GetType(XtraSerializableProperty)), XtraSerializableProperty)
						If attribute Is Nothing Then
							attribute = New XtraSerializableProperty()
						End If
						Dim prop As PropertyDescriptor = pairsList(i).Property

						pairsList.RemoveAt(i)
						pairsList.Insert(i, New SerializablePropertyDescriptorPair(prop, attribute))

						Exit For
					End If
				Next i
			Next customProperty
		End Sub

		Protected Overrides Overloads Function GetProperties(ByVal obj As Object, ByVal store As IXtraPropertyCollection) As PropertyDescriptorCollection
			Dim properties As PropertyDescriptorCollection = MyBase.GetProperties(obj, store)

			For Each storeItem As XtraPropertyInfo In store
				Dim args As New CustomPropertyValueEventArgs(obj, storeItem.Name)
				args.PropertyValue = storeItem.Value
				CType(DeserializeHelper.RootObject, MyGridView).RaiseGetCustomPropertyValue(args)
			Next storeItem

			Return properties
		End Function

		Private privateDeserializeHelper As MyDeserializeHelper
		Public Property DeserializeHelper() As MyDeserializeHelper
			Get
				Return privateDeserializeHelper
			End Get
			Set(ByVal value As MyDeserializeHelper)
				privateDeserializeHelper = value
			End Set
		End Property
	End Class
End Namespace
