using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("823C475F-55AE-46F9-890C-537CC5CEDCCA")]
	public partial interface IBMDStreamingH264InputCallback
	{
		void H264NALPacketArrived(IBMDStreamingH264NALPacket nalPacket);

		void H264AudioPacketArrived(IBMDStreamingAudioPacket audioPacket);

		void MPEG2TSPacketArrived(IBMDStreamingMPEG2TSPacket tsPacket);

		void H264VideoInputConnectorScanningChanged();

		void H264VideoInputConnectorChanged();

		void H264VideoInputModeChanged();
	}
}