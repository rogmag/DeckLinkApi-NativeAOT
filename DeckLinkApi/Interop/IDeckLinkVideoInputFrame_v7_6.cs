using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("9A74FA41-AE9F-47AC-8CF4-01F42DD59965")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoInputFrame_v7_6 : IDeckLinkVideoFrame_v7_6
	{
		void GetStreamTime(out long frameTime, out long frameDuration, long timeScale);

		void GetHardwareReferenceTimestamp(long timeScale, out long frameTime, out long frameDuration);
	}
}