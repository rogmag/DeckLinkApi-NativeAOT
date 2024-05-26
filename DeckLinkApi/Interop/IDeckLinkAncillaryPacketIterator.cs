using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("3FC8994B-88FB-4C17-968F-9AAB69D964A7")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkAncillaryPacketIterator
	{
		void Next(out IDeckLinkAncillaryPacket packet);
	}
}