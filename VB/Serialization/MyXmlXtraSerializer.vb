Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.Utils.Serializing
Imports DevExpress.Utils.Serializing.Helpers

Namespace Serialization
	Public Class MyXmlXtraSerializer
		Inherits XmlXtraSerializer
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Function CreateSerializeHelper(ByVal rootObj As Object, ByVal useRootObj As Boolean) As SerializeHelper
			Return If(useRootObj, New MySerializeHelper(rootObj), New MySerializeHelper())
		End Function

		Protected Overrides Overloads Sub DeserializeObject(ByVal obj As Object, ByVal store As IXtraPropertyCollection, ByVal options As OptionsLayoutBase)
			If store Is Nothing Then
				Return
			End If

			If options Is Nothing Then
				options = OptionsLayoutBase.FullLayout
			End If

			Dim coll As New XtraPropertyCollection()
			coll.AddRange(store)

			Dim helper As DeserializeHelper = New MyDeserializeHelper(obj)
			helper.DeserializeObject(obj, coll, options)
		End Sub
	End Class
End Namespace
