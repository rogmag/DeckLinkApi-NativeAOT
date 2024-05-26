using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("89AFCAF5-65F8-421E-98F7-96FE5F5BFBA3")]
	public partial interface IDeckLinkKeyer
	{
		void Enable([MarshalAs(UnmanagedType.Bool)] bool isExternal);

		void SetLevel(byte level);

		void RampUp(uint numberOfFrames);

		void RampDown(uint numberOfFrames);

		void Disable();
	}
}