Imports Microsoft.VisualBasic
Imports System

Namespace Serialization
	Public Class AllowSerializePropertyEventArgs
		Inherits EventArgs
		Private serializationObject_Renamed As Object
		Private propertyName_Renamed As String
		Private propertyType_Renamed As Type
		Private propertyValue_Renamed As Object
		Private serializeProperty_Renamed As Boolean

		Public Sub New(ByVal serializationObject As Object, ByVal propertyName As String, ByVal propertyType As Type, ByVal propertyValue As Object)
			Me.serializationObject_Renamed = serializationObject
			Me.propertyName_Renamed = propertyName
			Me.propertyType_Renamed = propertyType
			Me.propertyValue_Renamed = propertyValue
			Me.SerializeProperty = True
		End Sub

		Public ReadOnly Property SerializationObject() As Object
			Get
				Return serializationObject_Renamed
			End Get
		End Property

		Public ReadOnly Property PropertyName() As String
			Get
				Return propertyName_Renamed
			End Get
		End Property

		Public ReadOnly Property PropertyType() As Type
			Get
				Return propertyType_Renamed
			End Get
		End Property

		Public ReadOnly Property PropertyValue() As Object
			Get
				Return propertyValue_Renamed
			End Get
		End Property

		Public Property SerializeProperty() As Boolean
			Get
				Return serializeProperty_Renamed
			End Get
			Set(ByVal value As Boolean)
				serializeProperty_Renamed = value
			End Set
		End Property
	End Class

	Public Class SerializeCustomPropertiesEventArgs
		Inherits EventArgs
		Private serializationObject_Renamed As Object
		Private propertyNames_Renamed() As String

		Public Sub New(ByVal serializationObject As Object)
			Me.serializationObject_Renamed = serializationObject
		End Sub

		Public ReadOnly Property SerializationObject() As Object
			Get
				Return serializationObject_Renamed
			End Get
		End Property

		Public Property PropertyNames() As String()
			Get
				Return propertyNames_Renamed
			End Get
			Set(ByVal value As String())
				propertyNames_Renamed = value
			End Set
		End Property
	End Class

	Public Class CustomPropertyValueEventArgs
		Inherits EventArgs
		Private serializationObject_Renamed As Object
		Private propertyName_Renamed As String
		Private propertyValue_Renamed As Object = Nothing

		Public Sub New(ByVal serializationObject As Object, ByVal propertyName As String)
			Me.serializationObject_Renamed = serializationObject
			Me.propertyName_Renamed = propertyName
		End Sub

		Public ReadOnly Property SerializationObject() As Object
			Get
				Return serializationObject_Renamed
			End Get
		End Property

		Public ReadOnly Property PropertyName() As String
			Get
				Return propertyName_Renamed
			End Get
		End Property

		Public Property PropertyValue() As Object
			Get
				Return propertyValue_Renamed
			End Get
			Set(ByVal value As Object)
				propertyValue_Renamed = value
			End Set
		End Property
	End Class
End Namespace
