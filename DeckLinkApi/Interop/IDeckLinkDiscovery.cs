using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("CDBF631C-BC76-45FA-B44D-C55059BC6101")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkDiscovery
	{
		void InstallDeviceNotifications(IDeckLinkDeviceNotificationCallback deviceNotificationCallback);

		void UninstallDeviceNotifications();
	}
}