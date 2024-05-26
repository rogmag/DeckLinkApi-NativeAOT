using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("E232A5B7-4DB4-44C9-9152-F47C12E5F051")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoFrameMetadataExtensions
	{
		void GetInt(BMDDeckLinkFrameMetadataID metadataID, out long value);

		void GetFloat(BMDDeckLinkFrameMetadataID metadataID, out double value);

		void GetFlag(BMDDeckLinkFrameMetadataID metadataID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void GetString(BMDDeckLinkFrameMetadataID metadataID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);

		void GetBytes(BMDDeckLinkFrameMetadataID metadataID, IntPtr buffer, ref uint bufferSize);
	}
}