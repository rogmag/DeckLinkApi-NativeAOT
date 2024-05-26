namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDInternalKeyingAncillaryDataSource enumerates the source for VANC and timecode data when performing internal keying.
	/// </summary>
	public enum BMDInternalKeyingAncillaryDataSource
	{
		/// <summary>
		/// Output signal sources VANC and timecode from input signal
		/// </summary>
		bmdInternalKeyingUsesAncillaryDataFromInputSignal = 1768644969,

		/// <summary>
		/// Output signal sources VANC and timecode from key frame
		/// </summary>
		bmdInternalKeyingUsesAncillaryDataFromKeyFrame = 1768644971
	}
}