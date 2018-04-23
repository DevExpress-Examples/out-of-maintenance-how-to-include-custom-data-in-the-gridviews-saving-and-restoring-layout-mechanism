using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.Utils.Serializing.Helpers;

namespace Serialization
{
	public class MySerializationContext : SerializationContext
	{
		string[] customProperties;

		public MySerializationContext()
			: base()
		{
		}

		protected override bool AllowProperty(SerializeHelperBase helper, object obj, PropertyDescriptor prop, OptionsLayoutBase options, bool isSerializing)
		{
			MyDeserializeHelper myHelper = helper as MyDeserializeHelper;
			if ( myHelper == null || !(myHelper.RootObject is MyGridView) )
				return base.AllowProperty(helper, obj, prop, options, isSerializing);

			bool allow = base.AllowProperty(helper, obj, prop, options, isSerializing);
			if ( customProperties == null || Array.IndexOf(customProperties, prop.Name) == -1 )
				return allow;

			PropertyInfo[] propInfos = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
			PropertyInfo property = Array.Find(propInfos, info => info.Name == prop.Name);
			return property != null;
		}

		protected override void CustomGetSerializableProperties(object obj, List<SerializablePropertyDescriptorPair> pairsList, PropertyDescriptorCollection props)
		{
			base.CustomGetSerializableProperties(obj, pairsList, props);
			if ( DeserializeHelper == null || DeserializeHelper.RootObject == null || !(DeserializeHelper.RootObject is MyGridView) )
				return;

			SerializeCustomPropertiesEventArgs args = new SerializeCustomPropertiesEventArgs(obj);
			((MyGridView)DeserializeHelper.RootObject).RaiseDeserializeCustomProperties(args);
			customProperties = args.PropertyNames;
			if ( customProperties == null )
				return;

			foreach ( string customProperty in customProperties )
			{
				for ( int i = 0; i < pairsList.Count; i++ )
					if ( pairsList[i].Property.Name == customProperty )
					{
						XtraSerializableProperty attribute = pairsList[i].Property.Attributes[typeof(XtraSerializableProperty)] as XtraSerializableProperty;
						if ( attribute == null )
							attribute = new XtraSerializableProperty();
						PropertyDescriptor prop = pairsList[i].Property;

						pairsList.RemoveAt(i);
						pairsList.Insert(i, new SerializablePropertyDescriptorPair(prop, attribute));

						break;
					}
			}
		}

		protected override PropertyDescriptorCollection GetProperties(object obj, IXtraPropertyCollection store)
		{
			PropertyDescriptorCollection properties = base.GetProperties(obj, store);

			foreach ( XtraPropertyInfo storeItem in store )
			{
				CustomPropertyValueEventArgs args = new CustomPropertyValueEventArgs(obj, storeItem.Name);
				args.PropertyValue = storeItem.Value;
				((MyGridView)DeserializeHelper.RootObject).RaiseGetCustomPropertyValue(args);
			}

			return properties;
		}

		public MyDeserializeHelper DeserializeHelper
		{
			get;
			set;
		}
	}
}
