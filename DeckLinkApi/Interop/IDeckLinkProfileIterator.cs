using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("29E5A8C0-8BE4-46EB-93AC-31DAAB5B7BF2")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkProfileIterator
	{
		void Next(out IDeckLinkProfile profile);
	}
}