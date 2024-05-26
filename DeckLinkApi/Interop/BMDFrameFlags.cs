namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDFrameFlags enumerates a set of flags applicable to a video frame.
	/// </summary>
	[Flags]
	public enum BMDFrameFlags
	{
		/// <summary>
		/// No other flags applicable
		/// </summary>
		bmdFrameFlagDefault = 0,

		/// <summary>
		/// Frame should be flipped vertically on output
		/// </summary>
		bmdFrameFlagFlipVertical = 1,

		/// <summary>
		/// Output this frame on Monitor Output only and black/silence on all other outputs. Only available when <see cref="BMDDeckLinkAttributeID.BMDDeckLinkHasMonitorOut"/> attribute is True.
		/// </summary>
		bmdFrameFlagMonitorOutOnly = 8,

		/// <summary>
		/// Frame contains HDR metadata (See <see cref="IDeckLinkVideoFrameMetadataExtensions"/>)
		/// </summary>
		bmdFrameContainsHDRMetadata = 2,

		/// <summary>
		/// Frame captured as PsF
		/// </summary>
		bmdFrameCapturedAsPsF = 1073741824,

		/// <summary>
		/// No input source was detected – frame is invalid
		/// </summary>
		bmdFrameHasNoInputSource = int.MinValue,

		bmdFrameContainsCintelMetadata = 4
	}
}