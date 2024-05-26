using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9C88499F-F601-4021-B80B-032E4EB41C35")]
	public partial interface IDeckLinkDisplayModeIterator
	{
		void Next(out IDeckLinkDisplayMode deckLinkDisplayMode);
	}
}