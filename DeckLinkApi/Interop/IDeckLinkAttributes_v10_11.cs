using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("ABC11843-D966-44CB-96E2-A1CB5D3135C4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkAttributes_v10_11
	{
		void GetFlag(BMDDeckLinkAttributeID cfgID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void GetInt(BMDDeckLinkAttributeID cfgID, out long value);

		void GetFloat(BMDDeckLinkAttributeID cfgID, out double value);

		void GetString(BMDDeckLinkAttributeID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);
	}
}