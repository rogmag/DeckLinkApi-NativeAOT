using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ACF13E61-F4A0-4974-A6A7-59AFF6268B31")]
	public partial interface IDeckLinkEncoderInputCallback
	{
		void VideoInputSignalChanged(BMDVideoInputFormatChangedEvents notificationEvents, IDeckLinkDisplayMode newDisplayMode, BMDDetectedVideoInputFormatFlags detectedSignalFlags);

		void VideoPacketArrived(IDeckLinkEncoderVideoPacket videoPacket);

		void AudioPacketArrived(IDeckLinkEncoderAudioPacket audioPacket);
	}
}