using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("455D741F-1779-4800-86F5-0B5D13D79751")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkDisplayModeIterator_v7_6
	{
		void Next(out IDeckLinkDisplayMode_v7_6 deckLinkDisplayMode);
	}
}