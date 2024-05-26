using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("B1D3F49A-85FE-4C5D-95C8-0B5D5DCCD438")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkScreenPreviewCallback
	{
		void DrawFrame(IDeckLinkVideoFrame theFrame);
	}
}