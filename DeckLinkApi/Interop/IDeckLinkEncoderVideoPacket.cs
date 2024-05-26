using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4E7FD944-E8C7-4EAC-B8C0-7B77F80F5AE0")]
	public partial interface IDeckLinkEncoderVideoPacket : IDeckLinkEncoderPacket
	{
		[PreserveSig]
		BMDPixelFormat GetPixelFormat();

		void GetHardwareReferenceTimestamp(long timeScale, out long frameTime, out long frameDuration);

		void GetTimecode(BMDTimecodeFormat format, out IDeckLinkTimecode timecode);
	}
}