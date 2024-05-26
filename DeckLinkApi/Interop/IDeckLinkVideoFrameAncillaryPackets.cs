using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6C186C0F-459E-41D8-AEE2-4812D81AEE68")]
	public partial interface IDeckLinkVideoFrameAncillaryPackets
	{
		void GetPacketIterator(out IDeckLinkAncillaryPacketIterator iterator);

		void GetFirstPacketByID(byte DID, byte SDID, out IDeckLinkAncillaryPacket packet);

		void AttachPacket(IDeckLinkAncillaryPacket packet);

		void DetachPacket(IDeckLinkAncillaryPacket packet);

		void DetachAllPackets();
	}
}