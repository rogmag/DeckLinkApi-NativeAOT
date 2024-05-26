using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("CC5BBF7E-029C-4D3B-9158-6000EF5E3670")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkAncillaryPacket
	{
		void GetBytes(BMDAncillaryPacketFormat format, out IntPtr data, out uint size);

		[PreserveSig]
		byte GetDID();

		[PreserveSig]
		byte GetSDID();

		[PreserveSig]
		uint GetLineNumber();

		[PreserveSig]
		byte GetDataStreamIndex();
	}
}