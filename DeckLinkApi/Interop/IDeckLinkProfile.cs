using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("16093466-674A-432B-9DA0-1AC2C5A8241C")]
	public partial interface IDeckLinkProfile
	{
		void GetDevice(out IDeckLink device);

		void IsActive([MarshalAs(UnmanagedType.Bool)] out bool IsActive);

		void SetActive();

		void GetPeers(out IDeckLinkProfileIterator profileIterator);
	}
}