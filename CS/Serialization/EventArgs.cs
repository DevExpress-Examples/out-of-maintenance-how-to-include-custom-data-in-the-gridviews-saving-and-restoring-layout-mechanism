using System;

namespace Serialization
{
	public class AllowSerializePropertyEventArgs : EventArgs
	{
		private object serializationObject;
		private string propertyName;
		private Type propertyType;
		private object propertyValue;
		private bool serializeProperty;

		public AllowSerializePropertyEventArgs(object serializationObject, string propertyName, Type propertyType, object propertyValue)
		{
			this.serializationObject = serializationObject;
			this.propertyName = propertyName;
			this.propertyType = propertyType;
			this.propertyValue = propertyValue;
			this.SerializeProperty = true;
		}

		public object SerializationObject
		{
			get
			{
				return serializationObject;
			}
		}

		public string PropertyName
		{
			get
			{
				return propertyName;
			}
		}

		public Type PropertyType
		{
			get
			{
				return propertyType;
			}
		}

		public object PropertyValue
		{
			get
			{
				return propertyValue;
			}
		}

		public bool SerializeProperty
		{
			get
			{
				return serializeProperty;
			}
			set
			{
				serializeProperty = value;
			}
		}
	}

	public class SerializeCustomPropertiesEventArgs : EventArgs
	{
		private object serializationObject;
		private string[] propertyNames;

		public SerializeCustomPropertiesEventArgs(object serializationObject)
		{
			this.serializationObject = serializationObject;
		}

		public object SerializationObject
		{
			get
			{
				return serializationObject;
			}
		}

		public string[] PropertyNames
		{
			get
			{
				return propertyNames;
			}
			set
			{
				propertyNames = value;
			}
		}
	}

	public class CustomPropertyValueEventArgs : EventArgs
	{
		private object serializationObject;
		private string propertyName;
		private object propertyValue = null;

		public CustomPropertyValueEventArgs(object serializationObject, string propertyName)
		{
			this.serializationObject = serializationObject;
			this.propertyName = propertyName;
		}

		public object SerializationObject
		{
			get
			{
				return serializationObject;
			}
		}

		public string PropertyName
		{
			get
			{
				return propertyName;
			}
		}

		public object PropertyValue
		{
			get
			{
				return propertyValue;
			}
			set
			{
				propertyValue = value;
			}
		}
	}
}
