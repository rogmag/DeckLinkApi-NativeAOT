#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[Guid("F891AD29-D0C2-46E9-A926-4E2D0DD8CFAD")]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	public partial class CDeckLinkVideoFrameAncillaryPacketsClass : IDeckLinkVideoFrameAncillaryPackets, CDeckLinkVideoFrameAncillaryPackets
	{
		public virtual extern void GetPacketIterator(out IDeckLinkAncillaryPacketIterator iterator);

		public virtual extern void GetFirstPacketByID(byte DID, byte SDID, out IDeckLinkAncillaryPacket packet);

		public virtual extern void AttachPacket(IDeckLinkAncillaryPacket packet);

		public virtual extern void DetachPacket(IDeckLinkAncillaryPacket packet);

		public virtual extern void DetachAllPackets();
	}
}