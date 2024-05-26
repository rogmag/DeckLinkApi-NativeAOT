using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("C679A35B-610C-4D09-B748-1D0478100FC0")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkConfiguration_v10_2
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