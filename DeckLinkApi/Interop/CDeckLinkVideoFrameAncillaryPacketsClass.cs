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
		// Not compatible with Native AOT
		//public virtual extern void GetPacketIterator(out IDeckLinkAncillaryPacketIterator iterator);

		public virtual void GetPacketIterator(out IDeckLinkAncillaryPacketIterator iterator)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}

		// Not compatible with Native AOT
		//public virtual extern void GetFirstPacketByID(byte DID, byte SDID, out IDeckLinkAncillaryPacket packet);

		public virtual void GetFirstPacketByID(byte DID, byte SDID, out IDeckLinkAncillaryPacket packet)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}

		// Not compatible with Native AOT
		//public virtual extern void AttachPacket(IDeckLinkAncillaryPacket packet);

		public virtual void AttachPacket(IDeckLinkAncillaryPacket packet)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}

		// Not compatible with Native AOT
		//public virtual extern void DetachPacket(IDeckLinkAncillaryPacket packet);

		public virtual void DetachPacket(IDeckLinkAncillaryPacket packet)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}

		// Not compatible with Native AOT
		//public virtual extern void DetachAllPackets();

		public virtual void DetachAllPackets()
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}
	}
}