using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("C8B41D95-8848-40EE-9B37-6E3417FB114B")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoInputFrame_v7_1 : IDeckLinkVideoFrame_v7_1
	{
		void GetFrameTime(ref long frameTime, ref long frameDuration, long timeScale);
	}
}