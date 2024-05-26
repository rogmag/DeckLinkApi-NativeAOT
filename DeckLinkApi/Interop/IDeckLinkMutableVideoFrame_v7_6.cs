using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("46FCEE00-B4E6-43D0-91C0-023A7FCEB34F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkMutableVideoFrame_v7_6 : IDeckLinkVideoFrame_v7_6
	{
		void SetFlags(BMDFrameFlags newFlags);

		void SetTimecode(BMDTimecodeFormat format, IDeckLinkTimecode_v7_6 timecode);

		void SetTimecodeFromComponents(BMDTimecodeFormat format, byte hours, byte minutes, byte seconds, byte frames, BMDTimecodeFlags flags);

		void SetAncillaryData(IDeckLinkVideoFrameAncillary ancillary);
	}
}