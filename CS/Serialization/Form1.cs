using System;
using System.Windows.Forms;

namespace Serialization
{
	public partial class Form1 : Form
	{
		object customValue = null;
		
		public Form1()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			colID.Tag = "1234556789";
			myGridView1.SaveLayoutToXml("C:\\1\\1.xml");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
		}

		private void myGridView1_SerializeCustomProperties(object sender, SerializeCustomPropertiesEventArgs e)
		{
			if ( e.SerializationObject == colID )
				e.PropertyNames = new string[] { "ABC", "123", "Tag" };
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			myGridView1.RestoreLayoutFromXml("C:\\1\\1.xml");
			if ( customValue != null )
				labelControl1.Text = customValue.ToString();

		}

		private void myGridView1_DeserializeCustomProperties(object sender, SerializeCustomPropertiesEventArgs e)
		{
			if ( e.SerializationObject == colID )
				e.PropertyNames = new string[] { "ABC", "123", "Tag" };
		}

		private void myGridView1_SetCustomPropertyValue(object sender, CustomPropertyValueEventArgs e)
		{
			if ( e.SerializationObject == colID && e.PropertyName == "ABC" )
				e.PropertyValue = 123.456;
		}

		private void myGridView1_GetCustomPropertyValue(object sender, CustomPropertyValueEventArgs e)
		{
			if ( e.SerializationObject == colID && e.PropertyName == "ABC" )
				customValue = e.PropertyValue;
		}
	}
}