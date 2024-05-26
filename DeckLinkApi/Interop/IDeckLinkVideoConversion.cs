using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("3BBCB8A2-DA2C-42D9-B5D8-88083644E99A")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoConversion
	{
		void ConvertFrame(IDeckLinkVideoFrame srcFrame, IDeckLinkVideoFrame dstFrame);
	}
}