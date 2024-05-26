using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("C6FCE4C9-C4E4-4047-82FB-5D238232A902")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkInputCallback
	{
		void VideoInputFormatChanged(BMDVideoInputFormatChangedEvents notificationEvents, IDeckLinkDisplayMode newDisplayMode, BMDDetectedVideoInputFormatFlags detectedSignalFlags);

		void VideoInputFrameArrived(IDeckLinkVideoInputFrame videoFrame, IDeckLinkAudioInputPacket audioPacket);
	}
}