namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDVideoEncoderFrameCodingMode enumerates the frame coding mode options.
	/// </summary>
	public enum BMDVideoEncoderFrameCodingMode
	{
		/// <summary>
		/// Video frame data is compressed with reference to neighbouring video frame data.
		/// </summary>
		bmdVideoEncoderFrameCodingModeInter = 1768846437,

		/// <summary>
		/// Video frame data is compressed relative to the current frame only.
		/// </summary>
		bmdVideoEncoderFrameCodingModeIntra = 1768846450
	}
}