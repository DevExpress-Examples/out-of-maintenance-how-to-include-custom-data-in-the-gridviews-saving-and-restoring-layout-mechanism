using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace Serialization
{
	public delegate void AllowSerializePropertyEventHandler(object sender, AllowSerializePropertyEventArgs e);
	public delegate void SerializeCustomPropertiesEventHandler(object sender, SerializeCustomPropertiesEventArgs e);
	public delegate void CustomPropertyValueEventHandler(object sender, CustomPropertyValueEventArgs e);

	public class MyGridView : GridView
	{
		public MyGridView(GridControl ownerGrid)
			: base(ownerGrid)
		{
		}
		public MyGridView()
			: base()
		{
		}

		protected override string ViewName
		{
			get
			{
				return "MyGridView";
			}
		}

		protected override void SaveLayoutCore(XtraSerializer serializer, object path, OptionsLayoutBase options)
		{
			if ( serializer is XmlXtraSerializer )
				serializer = new MyXmlXtraSerializer();

			base.SaveLayoutCore(serializer, path, options);
		}

		protected override void RestoreLayoutCore(XtraSerializer serializer, object path, OptionsLayoutBase options)
		{
			if ( serializer is XmlXtraSerializer )
				serializer = new MyXmlXtraSerializer();

			base.RestoreLayoutCore(serializer, path, options);
		}

		public event AllowSerializePropertyEventHandler AllowSerializeProperty;
		protected internal virtual void RaiseAllowSerialzeProperty(AllowSerializePropertyEventArgs args)
		{
			if ( AllowSerializeProperty != null )
				AllowSerializeProperty(this, args);
		}

		public event SerializeCustomPropertiesEventHandler SerializeCustomProperties;
		protected internal virtual void RaiseSerializeCustomProperties(SerializeCustomPropertiesEventArgs args)
		{
			if ( SerializeCustomProperties != null )
				SerializeCustomProperties(this, args);
		}

		public event SerializeCustomPropertiesEventHandler DeserializeCustomProperties;
		protected internal virtual void RaiseDeserializeCustomProperties(SerializeCustomPropertiesEventArgs args)
		{
			if ( DeserializeCustomProperties != null )
				DeserializeCustomProperties(this, args);
		}

		public event CustomPropertyValueEventHandler SetCustomPropertyValue;
		protected internal virtual void RaiseSetCustomPropertyValue(CustomPropertyValueEventArgs args)
		{
			if ( SetCustomPropertyValue != null )
				SetCustomPropertyValue(this, args);
		}

		public event CustomPropertyValueEventHandler GetCustomPropertyValue;
		protected internal virtual void RaiseGetCustomPropertyValue(CustomPropertyValueEventArgs args)
		{
			if ( GetCustomPropertyValue != null )
				GetCustomPropertyValue(this, args);
		}
	}
}
