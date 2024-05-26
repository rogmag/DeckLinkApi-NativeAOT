using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("20AA5225-1958-47CB-820B-80A8D521A6EE")]
	public partial interface IDeckLinkVideoOutputCallback
	{
		void ScheduledFrameCompleted(IDeckLinkVideoFrame completedFrame, BMDOutputFrameCompletionResult result);

		void ScheduledPlaybackHasStopped();
	}
}