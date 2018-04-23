using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.Utils.Serializing.Helpers;

namespace Serialization
{
	public class MyXmlXtraSerializer : XmlXtraSerializer
	{
		public MyXmlXtraSerializer()
			: base()
		{
		}

		protected override SerializeHelper CreateSerializeHelper(object rootObj, bool useRootObj)
		{
			return useRootObj ? new MySerializeHelper(rootObj) : new MySerializeHelper();
		}

		protected override void DeserializeObject(object obj, IXtraPropertyCollection store, OptionsLayoutBase options)
		{
			if ( store == null )
				return;

			if ( options == null )
				options = OptionsLayoutBase.FullLayout;
			
			XtraPropertyCollection coll = new XtraPropertyCollection();
			coll.AddRange(store);
			
			DeserializeHelper helper = new MyDeserializeHelper(obj);
			helper.DeserializeObject(obj, coll, options);
		}
	}
}
