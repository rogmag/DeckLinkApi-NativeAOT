using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("C86DE4F6-A29F-42E3-AB3A-1363E29F0788")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkAudioInputPacket_v7_1
	{
		[PreserveSig]
		int GetSampleCount();

		void GetBytes(ref IntPtr buffer);

		void GetAudioPacketTime(ref long packetTime, long timeScale);
	}
}