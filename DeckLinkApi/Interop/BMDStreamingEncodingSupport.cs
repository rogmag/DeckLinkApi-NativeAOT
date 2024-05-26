namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDStreamingEncodingSupport enumerates the possible types of support for an encoding mode.
	/// </summary>
	public enum BMDStreamingEncodingSupport
	{
		/// <summary>
		/// The encoding mode is not supported.
		/// </summary>
		bmdStreamingEncodingModeNotSupported,

		/// <summary>
		/// The encoding mode is supported.
		/// </summary>
		bmdStreamingEncodingModeSupported,

		/// <summary>
		/// The encoding mode is supported with changes to encoding parameters.
		/// </summary>
		bmdStreamingEncodingModeSupportedWithChanges
	}
}