using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("138050E5-C60A-4552-BF3F-0F358049327E")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkEncoderConfiguration
	{
		void SetFlag(BMDDeckLinkEncoderConfigurationID cfgID, [MarshalAs(UnmanagedType.Bool)] bool value);

		void GetFlag(BMDDeckLinkEncoderConfigurationID cfgID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void SetInt(BMDDeckLinkEncoderConfigurationID cfgID, long value);

		void GetInt(BMDDeckLinkEncoderConfigurationID cfgID, out long value);

		void SetFloat(BMDDeckLinkEncoderConfigurationID cfgID, double value);

		void GetFloat(BMDDeckLinkEncoderConfigurationID cfgID, out double value);

		void SetString(BMDDeckLinkEncoderConfigurationID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] string value);

		void GetString(BMDDeckLinkEncoderConfigurationID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);

		void GetBytes(BMDDeckLinkEncoderConfigurationID cfgID, IntPtr buffer, ref uint bufferSize);
	}
}