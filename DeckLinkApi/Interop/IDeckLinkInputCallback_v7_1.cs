using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7F94F328-5ED4-4E9F-9729-76A86BDC99CC")]
	public partial interface IDeckLinkInputCallback_v7_1
	{
		void VideoInputFrameArrived(IDeckLinkVideoInputFrame_v7_1 videoFrame, IDeckLinkAudioInputPacket_v7_1 audioPacket);
	}
}