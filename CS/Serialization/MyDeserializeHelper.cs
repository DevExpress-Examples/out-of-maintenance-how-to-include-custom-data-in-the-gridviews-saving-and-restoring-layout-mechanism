using DevExpress.Utils.Serializing.Helpers;

namespace Serialization
{
	public class MyDeserializeHelper : DeserializeHelper
	{
		public MyDeserializeHelper(object rootObject)
			: base(rootObject)
		{
		}
		public MyDeserializeHelper(object rootObject, bool resetProperties)
			: base(rootObject, resetProperties)
		{
		}
		public MyDeserializeHelper()
			: base()
		{
		}

		protected override SerializationContext CreateSerializationContext()
		{
			MySerializationContext newContext = new MySerializationContext();
			newContext.DeserializeHelper = this;

			return newContext;
		}

		internal object RootObject
		{
			get
			{
				return rootObject;
			}
		}
	}
}
