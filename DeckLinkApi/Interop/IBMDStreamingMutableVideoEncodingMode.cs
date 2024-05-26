using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("19BF7D90-1E0A-400D-B2C6-FFC4E78AD49D")]
	public partial interface IBMDStreamingMutableVideoEncodingMode : IBMDStreamingVideoEncodingMode
	{
		void SetSourceRect(uint posX, uint posY, uint width, uint height);

		void SetDestSize(uint width, uint height);

		void SetFlag(BMDStreamingEncodingModePropertyID cfgID, [MarshalAs(UnmanagedType.Bool)] bool value);

		void SetInt(BMDStreamingEncodingModePropertyID cfgID, long value);

		void SetFloat(BMDStreamingEncodingModePropertyID cfgID, double value);

		void SetString(BMDStreamingEncodingModePropertyID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] string value);
	}
}