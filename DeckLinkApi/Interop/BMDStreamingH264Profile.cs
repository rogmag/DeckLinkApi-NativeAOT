using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDStreamingH264Profile enumerates the possible H.264 video coding profiles that are available on the streaming device. Profiles indicate the complexity of algorithms and coding tools required by a decoder, with Baseline Profile requiring the lowest complexity decoder to decode the encoded video.
	/// </summary>
	public enum BMDStreamingH264Profile
	{
		/// <summary>
		/// High Profile
		/// </summary>
		bmdStreamingH264ProfileHigh = 1751738216,

		/// <summary>
		/// Main Profile
		/// </summary>
		bmdStreamingH264ProfileMain = 1835100526,

		/// <summary>
		/// Baseline Profile
		/// </summary>
		bmdStreamingH264ProfileBaseline = 1650553701
	}
}