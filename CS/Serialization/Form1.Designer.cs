namespace Serialization
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.myGridControl1 = new Serialization.MyGridControl();
			this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carsDBDataSet = new Serialization.CarsDBDataSet();
			this.myGridView1 = new Serialization.MyGridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTrademark = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLiter = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCyl = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransmissSpeedCount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransmissAutomatic = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMPG_City = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMPG_Highway = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.carsTableAdapter = new Serialization.CarsDBDataSetTableAdapters.CarsTableAdapter();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// myGridControl1
			// 
			this.myGridControl1.DataSource = this.carsBindingSource;
			this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myGridControl1.Location = new System.Drawing.Point(0, 41);
			this.myGridControl1.MainView = this.myGridView1;
			this.myGridControl1.Name = "myGridControl1";
			this.myGridControl1.Size = new System.Drawing.Size(544, 302);
			this.myGridControl1.TabIndex = 0;
			this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
			// 
			// carsBindingSource
			// 
			this.carsBindingSource.DataMember = "Cars";
			this.carsBindingSource.DataSource = this.carsDBDataSet;
			// 
			// carsDBDataSet
			// 
			this.carsDBDataSet.DataSetName = "CarsDBDataSet";
			this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// myGridView1
			// 
			this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTrademark,
            this.colModel,
            this.colHP,
            this.colLiter,
            this.colCyl,
            this.colTransmissSpeedCount,
            this.colTransmissAutomatic,
            this.colMPG_City,
            this.colMPG_Highway,
            this.colCategory,
            this.colPrice});
			this.myGridView1.GridControl = this.myGridControl1;
			this.myGridView1.Name = "myGridView1";
			this.myGridView1.SerializeCustomProperties += new Serialization.SerializeCustomPropertiesEventHandler(this.myGridView1_SerializeCustomProperties);
			this.myGridView1.DeserializeCustomProperties += new Serialization.SerializeCustomPropertiesEventHandler(this.myGridView1_DeserializeCustomProperties);
			this.myGridView1.GetCustomPropertyValue += new Serialization.CustomPropertyValueEventHandler(this.myGridView1_GetCustomPropertyValue);
			this.myGridView1.SetCustomPropertyValue += new Serialization.CustomPropertyValueEventHandler(this.myGridView1_SetCustomPropertyValue);
			// 
			// colID
			// 
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.Visible = true;
			this.colID.VisibleIndex = 0;
			// 
			// colTrademark
			// 
			this.colTrademark.FieldName = "Trademark";
			this.colTrademark.Name = "colTrademark";
			this.colTrademark.Visible = true;
			this.colTrademark.VisibleIndex = 1;
			// 
			// colModel
			// 
			this.colModel.FieldName = "Model";
			this.colModel.Name = "colModel";
			this.colModel.Visible = true;
			this.colModel.VisibleIndex = 2;
			// 
			// colHP
			// 
			this.colHP.FieldName = "HP";
			this.colHP.Name = "colHP";
			this.colHP.Visible = true;
			this.colHP.VisibleIndex = 3;
			// 
			// colLiter
			// 
			this.colLiter.FieldName = "Liter";
			this.colLiter.Name = "colLiter";
			this.colLiter.Visible = true;
			this.colLiter.VisibleIndex = 4;
			// 
			// colCyl
			// 
			this.colCyl.FieldName = "Cyl";
			this.colCyl.Name = "colCyl";
			this.colCyl.Visible = true;
			this.colCyl.VisibleIndex = 5;
			// 
			// colTransmissSpeedCount
			// 
			this.colTransmissSpeedCount.FieldName = "TransmissSpeedCount";
			this.colTransmissSpeedCount.Name = "colTransmissSpeedCount";
			this.colTransmissSpeedCount.Visible = true;
			this.colTransmissSpeedCount.VisibleIndex = 6;
			// 
			// colTransmissAutomatic
			// 
			this.colTransmissAutomatic.FieldName = "TransmissAutomatic";
			this.colTransmissAutomatic.Name = "colTransmissAutomatic";
			this.colTransmissAutomatic.Visible = true;
			this.colTransmissAutomatic.VisibleIndex = 7;
			// 
			// colMPG_City
			// 
			this.colMPG_City.FieldName = "MPG_City";
			this.colMPG_City.Name = "colMPG_City";
			this.colMPG_City.Visible = true;
			this.colMPG_City.VisibleIndex = 8;
			// 
			// colMPG_Highway
			// 
			this.colMPG_Highway.FieldName = "MPG_Highway";
			this.colMPG_Highway.Name = "colMPG_Highway";
			this.colMPG_Highway.Visible = true;
			this.colMPG_Highway.VisibleIndex = 9;
			// 
			// colCategory
			// 
			this.colCategory.FieldName = "Category";
			this.colCategory.Name = "colCategory";
			this.colCategory.Visible = true;
			this.colCategory.VisibleIndex = 10;
			// 
			// colPrice
			// 
			this.colPrice.FieldName = "Price";
			this.colPrice.Name = "colPrice";
			this.colPrice.Visible = true;
			this.colPrice.VisibleIndex = 11;
			// 
			// carsTableAdapter
			// 
			this.carsTableAdapter.ClearBeforeFill = true;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.simpleButton2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(544, 41);
			this.panelControl1.TabIndex = 4;
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(93, 9);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(75, 23);
			this.simpleButton2.TabIndex = 6;
			this.simpleButton2.Text = "Restore";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(181, 14);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(63, 13);
			this.labelControl1.TabIndex = 5;
			this.labelControl1.Text = "labelControl1";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(12, 9);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(75, 23);
			this.simpleButton1.TabIndex = 4;
			this.simpleButton1.Text = "Save";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 343);
			this.Controls.Add(this.myGridControl1);
			this.Controls.Add(this.panelControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MyGridControl myGridControl1;
		private MyGridView myGridView1;
		private CarsDBDataSet carsDBDataSet;
		private System.Windows.Forms.BindingSource carsBindingSource;
		private Serialization.CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colTrademark;
		private DevExpress.XtraGrid.Columns.GridColumn colModel;
		private DevExpress.XtraGrid.Columns.GridColumn colHP;
		private DevExpress.XtraGrid.Columns.GridColumn colLiter;
		private DevExpress.XtraGrid.Columns.GridColumn colCyl;
		private DevExpress.XtraGrid.Columns.GridColumn colTransmissSpeedCount;
		private DevExpress.XtraGrid.Columns.GridColumn colTransmissAutomatic;
		private DevExpress.XtraGrid.Columns.GridColumn colMPG_City;
		private DevExpress.XtraGrid.Columns.GridColumn colMPG_Highway;
		private DevExpress.XtraGrid.Columns.GridColumn colCategory;
		private DevExpress.XtraGrid.Columns.GridColumn colPrice;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;

	}
}

