using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("D5973DC9-6432-46D0-8F0B-2496F8A1238F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoFrameMetadataExtensions_v11_5
	{
		void GetInt(BMDDeckLinkFrameMetadataID_v11_5 metadataID, out long value);

		void GetFloat(BMDDeckLinkFrameMetadataID_v11_5 metadataID, out double value);

		void GetFlag(BMDDeckLinkFrameMetadataID_v11_5 metadataID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void GetString(BMDDeckLinkFrameMetadataID_v11_5 metadataID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);
	}
}