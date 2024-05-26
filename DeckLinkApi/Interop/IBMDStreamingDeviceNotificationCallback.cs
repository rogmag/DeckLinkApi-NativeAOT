using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("F9531D64-3305-4B29-A387-7F74BB0D0E84")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IBMDStreamingDeviceNotificationCallback
	{
		void StreamingDeviceArrived(IDeckLink device);

		void StreamingDeviceRemoved(IDeckLink device);

		void StreamingDeviceModeChanged(IDeckLink device, BMDStreamingDeviceMode mode);
	}
}