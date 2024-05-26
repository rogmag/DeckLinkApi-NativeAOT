using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("67455668-0848-45DF-8D8E-350A77C9A028")]
	public partial interface IDeckLinkEncoderConfiguration_v10_5
	{
		void SetFlag(BMDDeckLinkEncoderConfigurationID cfgID, [MarshalAs(UnmanagedType.Bool)] bool value);

		void GetFlag(BMDDeckLinkEncoderConfigurationID cfgID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void SetInt(BMDDeckLinkEncoderConfigurationID cfgID, long value);

		void GetInt(BMDDeckLinkEncoderConfigurationID cfgID, out long value);

		void SetFloat(BMDDeckLinkEncoderConfigurationID cfgID, double value);

		void GetFloat(BMDDeckLinkEncoderConfigurationID cfgID, out double value);

		void SetString(BMDDeckLinkEncoderConfigurationID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] string value);

		void GetString(BMDDeckLinkEncoderConfigurationID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);

		void GetDecoderConfigurationInfo(IntPtr buffer, int bufferSize, out int returnedSize);
	}
}