using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("21CB2ED1-4429-42BE-AAF3-22A3B1DD3AE0")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkStatistics
	{
		void GetInt(BMDDeckLinkStatisticID statID, out long value);
	}
}