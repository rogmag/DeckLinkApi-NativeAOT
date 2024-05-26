using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("333F3A10-8C2D-43CF-B79D-46560FEEA1CE")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoFrame_v7_1
	{
		[PreserveSig]
		int GetWidth();

		[PreserveSig]
		int GetHeight();

		[PreserveSig]
		int GetRowBytes();

		[PreserveSig]
		BMDPixelFormat GetPixelFormat();

		[PreserveSig]
		BMDFrameFlags GetFlags();

		void GetBytes(ref IntPtr buffer);
	}
}