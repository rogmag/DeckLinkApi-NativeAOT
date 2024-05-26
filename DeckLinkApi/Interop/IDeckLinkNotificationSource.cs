using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2A7320AB-3F9C-4ED1-B364-D17132CDC93D")]
	public partial interface IDeckLinkNotificationSource
	{
		void PostNotification(BMDNotifications topic, ulong param1, ulong param2);
	}
}