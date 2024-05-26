using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("0A1FB207-E215-441B-9B19-6FA1575946C5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkNotification_v10_11
	{
		void Subscribe(BMDNotifications topic, IDeckLinkNotificationCallback theCallback);

		void Unsubscribe(BMDNotifications topic, IDeckLinkNotificationCallback theCallback);
	}
}