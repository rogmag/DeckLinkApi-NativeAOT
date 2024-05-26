namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDStreamingEncodingModePropertyID enumerates the possible properties of the encoding mode.
	/// </summary>
	public enum BMDStreamingEncodingModePropertyID
	{
		/// <summary>
		/// Video frame rate as a <see cref="BMDStreamingEncodingFrameRate"/> value
		/// </summary>
		bmdStreamingEncodingPropertyVideoFrameRate = 1986425460,

		/// <summary>
		/// Video codec bitrate in kilobits per second
		/// </summary>
		bmdStreamingEncodingPropertyVideoBitRateKbps = 1986163316,

		/// <summary>
		/// Video codec profile as a <see cref="BMDStreamingH264Profile"/> value
		/// </summary>
		bmdStreamingEncodingPropertyH264Profile = 1752199782,

		/// <summary>
		/// Video codec level as a <see cref="BMDStreamingH264Level"/> value
		/// </summary>
		bmdStreamingEncodingPropertyH264Level = 1751938668,

		/// <summary>
		/// Video codec entropy coding as a <see cref="BMDStreamingH264EntropyCoding"/> value
		/// </summary>
		bmdStreamingEncodingPropertyH264EntropyCoding = 1751477876,

		/// <summary>
		/// Boolean value indicating whether B-Frames will be output by encoding mode
		/// </summary>
		bmdStreamingEncodingPropertyH264HasBFrames = 1749182066,

		/// <summary>
		/// Audio codec as a <see cref="BMDStreamingAudioCodec"/> value
		/// </summary>
		bmdStreamingEncodingPropertyAudioCodec = 1633903715,

		/// <summary>
		/// Audio sampling rate in Hertz
		/// </summary>
		bmdStreamingEncodingPropertyAudioSampleRate = 1634955892,

		/// <summary>
		/// Number of audio channels
		/// </summary>
		bmdStreamingEncodingPropertyAudioChannelCount = 1633904739,

		/// <summary>
		/// Audio codec bitrate in kilobits per second
		/// </summary>
		bmdStreamingEncodingPropertyAudioBitRateKbps = 1633841780
	}
}