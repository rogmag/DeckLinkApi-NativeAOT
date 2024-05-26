using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("CB71734A-FE37-4E8D-8E13-802133A1C3F2")]
	public partial interface IDeckLinkConfiguration_v10_9
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