using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("E5F693C1-4283-4716-B18F-C1431521955B")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkDeckControlStatusCallback_v8_1
	{
		void TimecodeUpdate(uint currentTimecode);

		void VTRControlStateChanged(BMDDeckControlVTRControlState_v8_1 newState, BMDDeckControlError error);

		void DeckControlEventReceived(BMDDeckControlEvent @event, BMDDeckControlError error);

		void DeckControlStatusChanged(BMDDeckControlStatusFlags flags, uint mask);
	}
}