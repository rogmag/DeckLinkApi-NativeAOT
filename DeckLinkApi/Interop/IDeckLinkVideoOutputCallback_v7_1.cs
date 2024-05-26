using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("EBD01AFA-E4B0-49C6-A01D-EDB9D1B55FD9")]
	public partial interface IDeckLinkVideoOutputCallback_v7_1
	{
		void ScheduledFrameCompleted(IDeckLinkVideoFrame_v7_1 completedFrame, BMDOutputFrameCompletionResult result);
	}
}