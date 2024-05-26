using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("FD6F311D-4D00-444B-9ED4-1F25B5730AD0")]
	public partial interface IDeckLinkInputCallback_v7_3
	{
		void VideoInputFormatChanged(BMDVideoInputFormatChangedEvents notificationEvents, IDeckLinkDisplayMode_v7_6 newDisplayMode, BMDDetectedVideoInputFormatFlags detectedSignalFlags);

		void VideoInputFrameArrived(IDeckLinkVideoInputFrame_v7_3 videoFrame, IDeckLinkAudioInputPacket audioPacket);
	}
}