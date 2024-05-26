using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4997053B-0ADF-4CC8-AC70-7A50C4BE728F")]
	public partial interface IDeckLinkDeviceNotificationCallback
	{
		void DeckLinkDeviceArrived(IDeckLink deckLinkDevice);

		void DeckLinkDeviceRemoved(IDeckLink deckLinkDevice);
	}
}