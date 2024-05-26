using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("05CFE374-537C-4094-9A57-680525118F44")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoInputFrame : IDeckLinkVideoFrame
	{
		void GetStreamTime(out long frameTime, out long frameDuration, long timeScale);

		void GetHardwareReferenceTimestamp(long timeScale, out long frameTime, out long frameDuration);
	}
}