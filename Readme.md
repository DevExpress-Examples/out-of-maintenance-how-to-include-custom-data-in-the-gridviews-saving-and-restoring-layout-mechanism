# How to include custom data in the GridView's saving and restoring layout mechanism


<p>This sample demonstrates how to add custom data to the GridView's saving layout mechanism and restore it while restoring the layout. To accomplish this, we have created a GridView's descendant and added new events to it. When the SerializeCustomProperties event is raised, we can set an array of property names that will be serialized.<br />
On the SetCustomPropertyValue event, we can set values for these properties. The DeserializeCustomProperties and GetCustomPropertyValue events can be used to get saved data.<br />
Also, in the sample, the AllowSerializeProperty event is implemented at the GridView level. This event is raised when each property is about to be serialized and allows granting or denying its serialization.</p>

<br/>


