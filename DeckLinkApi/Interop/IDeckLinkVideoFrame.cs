using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("3F716FE0-F023-4111-BE5D-EF4414C05B17")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoFrame
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

		void GetTimecode(BMDTimecodeFormat format, out IDeckLinkTimecode timecode);

		void GetAncillaryData(out IDeckLinkVideoFrameAncillary ancillary);
	}
}