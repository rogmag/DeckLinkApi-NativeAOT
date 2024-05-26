using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("62BFF75D-6569-4E55-8D4D-66AA03829ABC")]
	public partial interface IDeckLink_v8_0
	{
		void GetModelName([MarshalUsing(typeof(BStrStringMarshaller))] out string modelName);
	}
}