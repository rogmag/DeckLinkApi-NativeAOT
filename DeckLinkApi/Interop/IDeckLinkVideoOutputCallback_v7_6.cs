using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("E763A626-4A3C-49D1-BF13-E7AD3692AE52")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkVideoOutputCallback_v7_6
	{
		void ScheduledFrameCompleted(IDeckLinkVideoFrame_v7_6 completedFrame, BMDOutputFrameCompletionResult result);

		void ScheduledPlaybackHasStopped();
	}
}