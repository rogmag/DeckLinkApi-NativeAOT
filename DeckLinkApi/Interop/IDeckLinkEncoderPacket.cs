using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B693F36C-316E-4AF1-B6C2-F389A4BCA620")]
	public partial interface IDeckLinkEncoderPacket
	{
		void GetBytes(out IntPtr buffer);

		[PreserveSig]
		int GetSize();

		void GetStreamTime(out long frameTime, long timeScale);

		[PreserveSig]
		BMDPacketType GetPacketType();
	}
}