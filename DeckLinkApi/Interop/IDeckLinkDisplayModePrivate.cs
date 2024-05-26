using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("748C33F9-596B-4FF5-A81C-6BAA42D6C9EC")]
	public partial interface IDeckLinkDisplayModePrivate
	{
		void GetSDIRate(BMDPixelFormat pixelFormat, out uint rateMbps);
	}
}