Imports Microsoft.VisualBasic
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.Utils.Serializing
Imports DevExpress.Utils.Serializing.Helpers
Imports System

Namespace Serialization
	Public Class MySerializeHelper
		Inherits SerializeHelper
		Public Sub New(ByVal rootObject As Object)
			MyBase.New(rootObject)
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function SerializeObjectCore(ByVal obj As Object, ByVal parentFlags As XtraSerializationFlags, ByVal options As OptionsLayoutBase) As IXtraPropertyCollection
			If rootObject Is Nothing OrElse Not(TypeOf rootObject Is MyGridView) Then
				Return MyBase.SerializeObjectCore(obj, parentFlags, options)
			End If

			Dim properties As XtraPropertyInfoCollection = TryCast(MyBase.SerializeObjectCore(obj, parentFlags, options), XtraPropertyInfoCollection)
			For i As Integer = properties.Count - 1 To 0 Step -1
				Dim allowArgs As New AllowSerializePropertyEventArgs(obj, properties(i).Name, properties(i).PropertyType, properties(i).Value)
				CType(rootObject, MyGridView).RaiseAllowSerialzeProperty(allowArgs)
				If (Not allowArgs.SerializeProperty) Then
					properties.RemoveAt(i)
				End If
			Next i

			Dim customArgs As New SerializeCustomPropertiesEventArgs(obj)
			CType(rootObject, MyGridView).RaiseSerializeCustomProperties(customArgs)
			If customArgs.PropertyNames Is Nothing OrElse customArgs.PropertyNames.Length = 0 Then
				Return properties
			End If

			For i As Integer = 0 To customArgs.PropertyNames.Length - 1
				Dim propInfos() As PropertyInfo = obj.GetType().GetProperties(BindingFlags.Instance Or BindingFlags.Public)
				Dim [property] As PropertyInfo = Array.Find(propInfos, Function(info) info.Name = customArgs.PropertyNames(i))
				Dim propertyValue As Object = Nothing
				If [property] Is Nothing Then
					Dim args As New CustomPropertyValueEventArgs(obj, customArgs.PropertyNames(i))
					CType(rootObject, MyGridView).RaiseSetCustomPropertyValue(args)
					If args.PropertyValue Is Nothing Then
						Continue For
					End If

					propertyValue = args.PropertyValue
				Else
					propertyValue = [property].GetValue(obj, Nothing)
					If propertyValue Is Nothing Then
						Continue For
					End If
				End If

				properties.Add(New XtraPropertyInfo(customArgs.PropertyNames(i), propertyValue.GetType(), propertyValue))
			Next i

			Return properties
		End Function
	End Class
End Namespace
