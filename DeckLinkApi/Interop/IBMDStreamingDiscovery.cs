using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2C837444-F989-4D87-901A-47C8A36D096D")]
	public partial interface IBMDStreamingDiscovery
	{
		void InstallDeviceNotifications(IBMDStreamingDeviceNotificationCallback theCallback);

		void UninstallDeviceNotifications();
	}
}