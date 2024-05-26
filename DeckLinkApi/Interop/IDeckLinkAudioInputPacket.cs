using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("E43D5870-2894-11DE-8C30-0800200C9A66")]
	public partial interface IDeckLinkAudioInputPacket
	{
		[PreserveSig]
		int GetSampleFrameCount();

		void GetBytes(out IntPtr buffer);

		void GetPacketTime(out long packetTime, long timeScale);
	}
}