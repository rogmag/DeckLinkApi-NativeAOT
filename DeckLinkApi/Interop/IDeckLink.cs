using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("C418FBDD-0587-48ED-8FE5-640F0A14AF91")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLink
	{
		void GetModelName([MarshalUsing(typeof(BStrStringMarshaller))] out string modelName);

		void GetDisplayName([MarshalUsing(typeof(BStrStringMarshaller))] out string displayName);
	}
}