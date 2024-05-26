using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("17D4BF8E-4911-473A-80A0-731CF6FF345B")]
	public partial interface IDeckLinkProfileAttributes
	{
		void GetFlag(BMDDeckLinkAttributeID cfgID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void GetInt(BMDDeckLinkAttributeID cfgID, out long value);

		void GetFloat(BMDDeckLinkAttributeID cfgID, out double value);

		void GetString(BMDDeckLinkAttributeID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);
	}
}