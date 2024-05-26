namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDStreamingEncodingFrameRate enumerates the possible encoded frame rates of the streaming device.
	/// </summary>
	public enum BMDStreamingEncodingFrameRate
	{
		/// <summary>
		/// The encoded interlaced frame rate is 50 fields per second.
		/// </summary>
		bmdStreamingEncodedFrameRate50i = 1697984617,

		/// <summary>
		/// The encoded interlaced frame rate is 59.94 fields per second.
		/// </summary>
		bmdStreamingEncodedFrameRate5994i = 1697986921,

		/// <summary>
		/// The encoded interlaced frame rate is 60 fields per second.
		/// </summary>
		bmdStreamingEncodedFrameRate60i = 1698050153,

		/// <summary>
		/// The encoded progressive frame rate is 23.98 frames per second.
		/// </summary>
		bmdStreamingEncodedFrameRate2398p = 1697788784,

		/// <summary>
		/// The encoded progressive frame rate is 24 frames per second.
		/// </summary>
		bmdStreamingEncodedFrameRate24p = 1697789040,

		/// <summary>
		/// The encoded progressive frame rate is 25 frames per second.
		/// </summary>
		bmdStreamingEncodedFrameRate25p = 1697789296,

		/// <summary>
		/// The encoded progressive frame rate is 29.97 frames per second.
		/// </summary>
		bmdStreamingEncodedFrameRate2997p = 1697790320,

		/// <summary>
		/// The encoded progressive frame rate is 30 frames per second.
		/// </summary>
		bmdStreamingEncodedFrameRate30p = 1697853552,

		/// <summary>
		/// The encoded progressive frame rate is 50 frames per second.
		/// </summary>
		bmdStreamingEncodedFrameRate50p = 1697984624,

		/// <summary>
		/// The encoded progressive frame rate is 59.94 frames per second.
		/// </summary>
		bmdStreamingEncodedFrameRate5994p = 1697986928,

		/// <summary>
		/// The encoded progressive frame rate is 60 frames per second. 
		/// </summary>
		bmdStreamingEncodedFrameRate60p = 1698050160
	}
}