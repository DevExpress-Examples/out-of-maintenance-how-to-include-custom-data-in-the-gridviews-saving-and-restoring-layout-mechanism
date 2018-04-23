Imports Microsoft.VisualBasic
Imports System
Namespace Serialization
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.myGridControl1 = New Serialization.MyGridControl
            Me.myGridView1 = New Serialization.MyGridView
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colHP = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colLiter = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colCyl = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colTransmissSpeedCount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colTransmissAutomatic = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colMPG_City = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colMPG_Highway = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton
            Me.CarsDBDataSet = New CarsDBDataSet
            Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CarsTableAdapter = New CarsDBDataSetTableAdapters.CarsTableAdapter
            CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.CarsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'myGridControl1
            '
            Me.myGridControl1.DataSource = Me.CarsBindingSource
            Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myGridControl1.Location = New System.Drawing.Point(0, 41)
            Me.myGridControl1.MainView = Me.myGridView1
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.Size = New System.Drawing.Size(544, 302)
            Me.myGridControl1.TabIndex = 0
            Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.myGridView1})
            '
            'myGridView1
            '
            Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colTrademark, Me.colModel, Me.colHP, Me.colLiter, Me.colCyl, Me.colTransmissSpeedCount, Me.colTransmissAutomatic, Me.colMPG_City, Me.colMPG_Highway, Me.colCategory, Me.colPrice})
            Me.myGridView1.GridControl = Me.myGridControl1
            Me.myGridView1.Name = "myGridView1"
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colTrademark
            '
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            Me.colTrademark.Visible = True
            Me.colTrademark.VisibleIndex = 1
            '
            'colModel
            '
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 2
            '
            'colHP
            '
            Me.colHP.FieldName = "HP"
            Me.colHP.Name = "colHP"
            Me.colHP.Visible = True
            Me.colHP.VisibleIndex = 3
            '
            'colLiter
            '
            Me.colLiter.FieldName = "Liter"
            Me.colLiter.Name = "colLiter"
            Me.colLiter.Visible = True
            Me.colLiter.VisibleIndex = 4
            '
            'colCyl
            '
            Me.colCyl.FieldName = "Cyl"
            Me.colCyl.Name = "colCyl"
            Me.colCyl.Visible = True
            Me.colCyl.VisibleIndex = 5
            '
            'colTransmissSpeedCount
            '
            Me.colTransmissSpeedCount.FieldName = "TransmissSpeedCount"
            Me.colTransmissSpeedCount.Name = "colTransmissSpeedCount"
            Me.colTransmissSpeedCount.Visible = True
            Me.colTransmissSpeedCount.VisibleIndex = 6
            '
            'colTransmissAutomatic
            '
            Me.colTransmissAutomatic.FieldName = "TransmissAutomatic"
            Me.colTransmissAutomatic.Name = "colTransmissAutomatic"
            Me.colTransmissAutomatic.Visible = True
            Me.colTransmissAutomatic.VisibleIndex = 7
            '
            'colMPG_City
            '
            Me.colMPG_City.FieldName = "MPG_City"
            Me.colMPG_City.Name = "colMPG_City"
            Me.colMPG_City.Visible = True
            Me.colMPG_City.VisibleIndex = 8
            '
            'colMPG_Highway
            '
            Me.colMPG_Highway.FieldName = "MPG_Highway"
            Me.colMPG_Highway.Name = "colMPG_Highway"
            Me.colMPG_Highway.Visible = True
            Me.colMPG_Highway.VisibleIndex = 9
            '
            'colCategory
            '
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 10
            '
            'colPrice
            '
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 11
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.simpleButton2)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.simpleButton1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(544, 41)
            Me.panelControl1.TabIndex = 4
            '
            'simpleButton2
            '
            Me.simpleButton2.Location = New System.Drawing.Point(93, 9)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton2.TabIndex = 6
            Me.simpleButton2.Text = "Restore"
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(181, 14)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(63, 13)
            Me.labelControl1.TabIndex = 5
            Me.labelControl1.Text = "labelControl1"
            '
            'simpleButton1
            '
            Me.simpleButton1.Location = New System.Drawing.Point(12, 9)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 4
            Me.simpleButton1.Text = "Save"
            '
            'CarsDBDataSet
            '
            Me.CarsDBDataSet.DataSetName = "CarsDBDataSet"
            Me.CarsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'CarsBindingSource
            '
            Me.CarsBindingSource.DataMember = "Cars"
            Me.CarsBindingSource.DataSource = Me.CarsDBDataSet
            '
            'CarsTableAdapter
            '
            Me.CarsTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(544, 343)
            Me.Controls.Add(Me.myGridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.CarsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private myGridControl1 As MyGridControl
		Private WithEvents myGridView1 As MyGridView
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn
		Private colModel As DevExpress.XtraGrid.Columns.GridColumn
		Private colHP As DevExpress.XtraGrid.Columns.GridColumn
		Private colLiter As DevExpress.XtraGrid.Columns.GridColumn
		Private colCyl As DevExpress.XtraGrid.Columns.GridColumn
		Private colTransmissSpeedCount As DevExpress.XtraGrid.Columns.GridColumn
		Private colTransmissAutomatic As DevExpress.XtraGrid.Columns.GridColumn
		Private colMPG_City As DevExpress.XtraGrid.Columns.GridColumn
		Private colMPG_Highway As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategory As DevExpress.XtraGrid.Columns.GridColumn
		Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents CarsDBDataSet As CarsDBDataSet
        Friend WithEvents CarsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents CarsTableAdapter As CarsDBDataSetTableAdapters.CarsTableAdapter

	End Class
End Namespace

