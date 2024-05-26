using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("69E2639F-40DA-4E19-B6F2-20ACE815C390")]
	public partial interface IDeckLinkMutableVideoFrame : IDeckLinkVideoFrame
	{
		void SetFlags(BMDFrameFlags newFlags);

		void SetTimecode(BMDTimecodeFormat format, IDeckLinkTimecode timecode);

		void SetTimecodeFromComponents(BMDTimecodeFormat format, byte hours, byte minutes, byte seconds, byte frames, BMDTimecodeFlags flags);

		void SetAncillaryData(IDeckLinkVideoFrameAncillary ancillary);

		void SetTimecodeUserBits(BMDTimecodeFormat format, uint userBits);
	}
}