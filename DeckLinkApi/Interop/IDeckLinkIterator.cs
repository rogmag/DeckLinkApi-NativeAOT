using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("50FB36CD-3063-4B73-BDBB-958087F2D8BA")]
	public partial interface IDeckLinkIterator
	{
		void Next(out IDeckLink deckLinkInstance);
	}
}