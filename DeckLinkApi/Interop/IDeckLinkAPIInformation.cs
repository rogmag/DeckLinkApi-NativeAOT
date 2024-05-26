using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("7BEA3C68-730D-4322-AF34-8A7152B532A4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkAPIInformation
	{
		void GetFlag(BMDDeckLinkAPIInformationID cfgID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void GetInt(BMDDeckLinkAPIInformationID cfgID, out long value);

		void GetFloat(BMDDeckLinkAPIInformationID cfgID, out double value);

		void GetString(BMDDeckLinkAPIInformationID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);
	}
}