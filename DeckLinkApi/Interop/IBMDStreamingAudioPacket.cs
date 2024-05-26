using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("D9EB5902-1AD2-43F4-9E2C-3CFA50B5EE19")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IBMDStreamingAudioPacket
	{
		[PreserveSig]
		BMDStreamingAudioCodec GetCodec();

		[PreserveSig]
		int GetPayloadSize();

		void GetBytes(out IntPtr buffer);

		void GetPlayTime(ulong requestedTimeScale, out ulong playTime);

		void GetPacketIndex(out uint packetIndex);
	}
}