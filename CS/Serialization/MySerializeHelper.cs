using System.Reflection;
using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.Utils.Serializing.Helpers;
using System;

namespace Serialization
{
	public class MySerializeHelper : SerializeHelper
	{
		public MySerializeHelper(object rootObject)
			: base(rootObject)
		{
		}
		public MySerializeHelper()
			: base()
		{
		}

		protected override IXtraPropertyCollection SerializeObjectCore(object obj, XtraSerializationFlags parentFlags, OptionsLayoutBase options)
		{
			if ( rootObject == null || !(rootObject is MyGridView) )
				return base.SerializeObjectCore(obj, parentFlags, options);

			XtraPropertyInfoCollection properties = base.SerializeObjectCore(obj, parentFlags, options) as XtraPropertyInfoCollection;
			for ( int i = properties.Count - 1; i >= 0; i-- )
			{
				AllowSerializePropertyEventArgs allowArgs = new AllowSerializePropertyEventArgs(obj, properties[i].Name, properties[i].PropertyType, properties[i].Value);
				((MyGridView)rootObject).RaiseAllowSerialzeProperty(allowArgs);
				if ( !allowArgs.SerializeProperty )
					properties.RemoveAt(i);
			}

			SerializeCustomPropertiesEventArgs customArgs = new SerializeCustomPropertiesEventArgs(obj);
			((MyGridView)rootObject).RaiseSerializeCustomProperties(customArgs);
			if ( customArgs.PropertyNames == null || customArgs.PropertyNames.Length == 0 )
				return properties;

			for ( int i = 0; i < customArgs.PropertyNames.Length; i++ )
			{
				PropertyInfo[] propInfos = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
				PropertyInfo property = Array.Find(propInfos, info => info.Name == customArgs.PropertyNames[i]);
				object propertyValue = null;
				if ( property == null )
				{
					CustomPropertyValueEventArgs args = new CustomPropertyValueEventArgs(obj, customArgs.PropertyNames[i]);
					((MyGridView)rootObject).RaiseSetCustomPropertyValue(args);
					if ( args.PropertyValue == null )
						continue;

					propertyValue = args.PropertyValue;
				}
				else
				{
					propertyValue = property.GetValue(obj, null);
					if ( propertyValue == null )
						continue;
				}

				properties.Add(new XtraPropertyInfo(customArgs.PropertyNames[i], propertyValue.GetType(), propertyValue));
			}

			return properties;
		}
	}
}
