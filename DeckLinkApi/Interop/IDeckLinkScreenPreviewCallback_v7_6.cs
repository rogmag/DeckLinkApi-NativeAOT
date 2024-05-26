using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("373F499D-4B4D-4518-AD22-6354E5A5825E")]
	public partial interface IDeckLinkScreenPreviewCallback_v7_6
	{
		void DrawFrame(IDeckLinkVideoFrame_v7_6 theFrame);
	}
}