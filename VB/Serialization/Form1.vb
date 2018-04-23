Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace Serialization
	Partial Public Class Form1
		Inherits Form
		Private customValue As Object = Nothing

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			colID.Tag = "1234556789"
			myGridView1.SaveLayoutToXml("C:\1\1.xml")
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            'TODO: This line of code loads data into the 'CarsDBDataSet.Cars' table. You can move, or remove it, as needed.
            Me.CarsTableAdapter.Fill(Me.CarsDBDataSet.Cars)
        End Sub

		Private Sub myGridView1_SerializeCustomProperties(ByVal sender As Object, ByVal e As SerializeCustomPropertiesEventArgs) Handles myGridView1.SerializeCustomProperties
			If e.SerializationObject Is colID Then
				e.PropertyNames = New String() { "ABC", "123", "Tag" }
			End If
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			myGridView1.RestoreLayoutFromXml("C:\1\1.xml")
			If customValue IsNot Nothing Then
				labelControl1.Text = customValue.ToString()
			End If

		End Sub

		Private Sub myGridView1_DeserializeCustomProperties(ByVal sender As Object, ByVal e As SerializeCustomPropertiesEventArgs) Handles myGridView1.DeserializeCustomProperties
			If e.SerializationObject Is colID Then
				e.PropertyNames = New String() { "ABC", "123", "Tag" }
			End If
		End Sub

		Private Sub myGridView1_SetCustomPropertyValue(ByVal sender As Object, ByVal e As CustomPropertyValueEventArgs) Handles myGridView1.SetCustomPropertyValue
			If e.SerializationObject Is colID AndAlso e.PropertyName = "ABC" Then
				e.PropertyValue = 123.456
			End If
		End Sub

		Private Sub myGridView1_GetCustomPropertyValue(ByVal sender As Object, ByVal e As CustomPropertyValueEventArgs) Handles myGridView1.GetCustomPropertyValue
			If e.SerializationObject Is colID AndAlso e.PropertyName = "ABC" Then
				customValue = e.PropertyValue
			End If
		End Sub
	End Class
End Namespace