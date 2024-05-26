using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("B002A1EC-070D-4288-8289-BD5D36E5FF0D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkNotificationCallback
	{
		void Notify(BMDNotifications topic, ulong param1, ulong param2);
	}
}