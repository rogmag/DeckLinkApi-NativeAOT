using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("A8D8238E-6B18-4196-99E1-5AF717B83D32")]
	public partial interface IDeckLinkVideoFrame_v7_6
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

		void GetBytes(out IntPtr buffer);

		void GetTimecode(BMDTimecodeFormat format, out IDeckLinkTimecode_v7_6 timecode);

		void GetAncillaryData(out IDeckLinkVideoFrameAncillary ancillary);
	}
}