using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("31D28EE7-88B6-4CB1-897A-CDBF79A26414")]
	public partial interface IDeckLinkInputCallback_v7_6
	{
		void VideoInputFormatChanged(BMDVideoInputFormatChangedEvents notificationEvents, IDeckLinkDisplayMode_v7_6 newDisplayMode, BMDDetectedVideoInputFormatFlags detectedSignalFlags);

		void VideoInputFrameArrived(IDeckLinkVideoInputFrame_v7_6 videoFrame, IDeckLinkAudioInputPacket audioPacket);
	}
}