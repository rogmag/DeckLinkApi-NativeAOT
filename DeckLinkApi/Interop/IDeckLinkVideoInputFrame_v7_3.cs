using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("CF317790-2894-11DE-8C30-0800200C9A66")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoInputFrame_v7_3 : IDeckLinkVideoFrame_v7_6
	{
		void GetStreamTime(out long frameTime, out long frameDuration, long timeScale);
	}
}