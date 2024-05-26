using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("A4F9341E-97AA-4E04-8935-15F809898CEA")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkProfileCallback
	{
		void ProfileChanging(IDeckLinkProfile profileToBeActivated, [MarshalAs(UnmanagedType.Bool)] bool streamsWillBeForcedToStop);

		void ProfileActivated(IDeckLinkProfile activatedProfile);
	}
}