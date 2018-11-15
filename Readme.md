<!-- default file list -->
*Files to look at*:

* [EventArgs.cs](./CS/Serialization/EventArgs.cs) (VB: [EventArgs.vb](./VB/Serialization/EventArgs.vb))
* [Form1.cs](./CS/Serialization/Form1.cs) (VB: [Form1.vb](./VB/Serialization/Form1.vb))
* [MyDeserializeHelper.cs](./CS/Serialization/MyDeserializeHelper.cs) (VB: [MyDeserializeHelper.vb](./VB/Serialization/MyDeserializeHelper.vb))
* [MyGridControl.cs](./CS/Serialization/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/Serialization/MyGridControl.vb))
* [MyGridInfoRegistrator.cs](./CS/Serialization/MyGridInfoRegistrator.cs) (VB: [MyGridInfoRegistrator.vb](./VB/Serialization/MyGridInfoRegistrator.vb))
* [MyGridView.cs](./CS/Serialization/MyGridView.cs) (VB: [MyGridView.vb](./VB/Serialization/MyGridView.vb))
* [MySerializationContext.cs](./CS/Serialization/MySerializationContext.cs) (VB: [MySerializationContext.vb](./VB/Serialization/MySerializationContext.vb))
* [MySerializeHelper.cs](./CS/Serialization/MySerializeHelper.cs) (VB: [MySerializeHelper.vb](./VB/Serialization/MySerializeHelper.vb))
* [MyXmlXtraSerializer.cs](./CS/Serialization/MyXmlXtraSerializer.cs) (VB: [MyXmlXtraSerializer.vb](./VB/Serialization/MyXmlXtraSerializer.vb))
<!-- default file list end -->
# How to include custom data in the GridView's saving and restoring layout mechanism


<p>This sample demonstrates how to add custom data to the GridView's saving layout mechanism and restore it while restoring the layout. To accomplish this, we have created a GridView's descendant and added new events to it. When the SerializeCustomProperties event is raised, we can set an array of property names that will be serialized.<br />
On the SetCustomPropertyValue event, we can set values for these properties. The DeserializeCustomProperties and GetCustomPropertyValue events can be used to get saved data.<br />
Also, in the sample, the AllowSerializeProperty event is implemented at the GridView level. This event is raised when each property is about to be serialized and allows granting or denying its serialization.</p>

<br/>


