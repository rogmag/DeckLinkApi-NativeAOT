using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B28131B6-59AC-4857-B5AC-CD75D5883E2F")]
	public partial interface IDeckLinkDisplayModeIterator_v7_1
	{
		void Next(out IDeckLinkDisplayMode_v7_1 deckLinkDisplayMode);
	}
}