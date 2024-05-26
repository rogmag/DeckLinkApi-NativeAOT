using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("53436FFB-B434-4906-BADC-AE3060FFE8EF")]
	public partial interface IDeckLinkDeckControlStatusCallback
	{
		void TimecodeUpdate(uint currentTimecode);

		void VTRControlStateChanged(BMDDeckControlVTRControlState newState, BMDDeckControlError error);

		void DeckControlEventReceived(BMDDeckControlEvent @event, BMDDeckControlError error);

		void DeckControlStatusChanged(BMDDeckControlStatusFlags flags, uint mask);
	}
}