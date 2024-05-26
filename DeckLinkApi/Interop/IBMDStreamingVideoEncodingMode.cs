using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1AB8035B-CD13-458D-B6DF-5E8F7C2141D9")]
	public partial interface IBMDStreamingVideoEncodingMode
	{
		void GetName([MarshalUsing(typeof(BStrStringMarshaller))] out string name);

		[PreserveSig]
		uint GetPresetID();

		[PreserveSig]
		uint GetSourcePositionX();

		[PreserveSig]
		uint GetSourcePositionY();

		[PreserveSig]
		uint GetSourceWidth();

		[PreserveSig]
		uint GetSourceHeight();

		[PreserveSig]
		uint GetDestWidth();

		[PreserveSig]
		uint GetDestHeight();

		void GetFlag(BMDStreamingEncodingModePropertyID cfgID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void GetInt(BMDStreamingEncodingModePropertyID cfgID, out long value);

		void GetFloat(BMDStreamingEncodingModePropertyID cfgID, out double value);

		void GetString(BMDStreamingEncodingModePropertyID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);

		void CreateMutableVideoEncodingMode(out IBMDStreamingMutableVideoEncodingMode newEncodingMode);
	}
}