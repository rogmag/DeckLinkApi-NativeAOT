using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDVideoInputFormatChangedEvents enumerates the properties of the video input signal format that have changed. (See <see cref="IDeckLinkInputCallback.VideoInputFormatChanged"/> for details).
	/// </summary>
	[Flags]
	public enum BMDVideoInputFormatChangedEvents
	{
		/// <summary>
		/// Either the video input display mode (see <see cref="BMDDisplayMode"/> for details) or detected video input dual stream 3D has changed (see <see cref="BMDDetectedVideoInputFormatFlags"/> for details).
		/// </summary>
		bmdVideoInputDisplayModeChanged = 1,

		/// <summary>
		/// Video input field dominance has changed (see <see cref="BMDFieldDominance"/> for details)
		/// </summary>
		bmdVideoInputFieldDominanceChanged = 2,

		/// <summary>
		/// Video input color space or depth has changed (see <see cref="BMDDetectedVideoInputFormatFlags"/> for details)
		/// </summary>
		bmdVideoInputColorspaceChanged = 4
	}
}