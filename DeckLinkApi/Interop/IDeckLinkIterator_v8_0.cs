using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("74E936FC-CC28-4A67-81A0-1E94E52D4E69")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkIterator_v8_0
	{
		void Next(out IDeckLink_v8_0 deckLinkInstance);
	}
}