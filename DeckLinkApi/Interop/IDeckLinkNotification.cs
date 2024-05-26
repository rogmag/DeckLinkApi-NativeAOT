using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("B85DF4C8-BDF5-47C1-8064-28162EBDD4EB")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkNotification
	{
		void Subscribe(BMDNotifications topic, IDeckLinkNotificationCallback theCallback);

		void Unsubscribe(BMDNotifications topic, IDeckLinkNotificationCallback theCallback);
	}
}