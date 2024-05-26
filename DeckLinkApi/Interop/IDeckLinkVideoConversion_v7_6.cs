using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("3EB504C9-F97D-40FE-A158-D407D48CB53B")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoConversion_v7_6
	{
		void ConvertFrame(IDeckLinkVideoFrame_v7_6 srcFrame, IDeckLinkVideoFrame_v7_6 dstFrame);
	}
}