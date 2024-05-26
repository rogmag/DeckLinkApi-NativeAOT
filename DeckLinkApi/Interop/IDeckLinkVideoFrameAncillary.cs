using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("732E723C-D1A4-4E29-9E8E-4A88797A0004")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoFrameAncillary
	{
		void GetBufferForVerticalBlankingLine(uint lineNumber, out IntPtr buffer);

		[PreserveSig]
		BMDPixelFormat GetPixelFormat();

		[PreserveSig]
		BMDDisplayMode GetDisplayMode();
	}
}