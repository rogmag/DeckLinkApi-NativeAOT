using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("912F634B-2D4E-40A4-8AAB-8D80B73F1289")]
	public partial interface IDeckLinkConfiguration
	{
		void SetFlag(BMDDeckLinkConfigurationID cfgID, [MarshalAs(UnmanagedType.Bool)] bool value);

		void GetFlag(BMDDeckLinkConfigurationID cfgID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void SetInt(BMDDeckLinkConfigurationID cfgID, long value);

		void GetInt(BMDDeckLinkConfigurationID cfgID, out long value);

		void SetFloat(BMDDeckLinkConfigurationID cfgID, double value);

		void GetFloat(BMDDeckLinkConfigurationID cfgID, out double value);

		void SetString(BMDDeckLinkConfigurationID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] string value);

		void GetString(BMDDeckLinkConfigurationID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);

		void WriteConfigurationToPreferences();
	}
}