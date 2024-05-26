using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("E260E955-14BE-4395-9775-9F02CC0A9D89")]
	public partial interface IBMDStreamingH264NALPacket
	{
		[PreserveSig]
		int GetPayloadSize();

		void GetBytes(out IntPtr buffer);

		void GetBytesWithSizePrefix(out IntPtr buffer);

		void GetDisplayTime(ulong requestedTimeScale, out ulong displayTime);

		void GetPacketIndex(out uint packetIndex);
	}
}