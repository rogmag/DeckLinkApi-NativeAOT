namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDFieldDominance enumerates settings applicable to video fields.
	/// </summary>
	public enum BMDFieldDominance
	{
		/// <summary>
		/// Indeterminate field dominance.
		/// </summary>
		bmdUnknownFieldDominance = 0,

		/// <summary>
		/// The first frame starts with the lower field (the second-from-the-top scan line).
		/// </summary>
		bmdLowerFieldFirst = 1819244402,

		/// <summary>
		/// The first frame starts with the upper field (the top scan line).
		/// </summary>
		bmdUpperFieldFirst = 1970303090,

		/// <summary>
		/// A complete frame containing all scan lines
		/// </summary>
		bmdProgressiveFrame = 1886547815,

		/// <summary>
		/// A progressive frame encoded as a PsF (See <see cref="IDeckLinkDisplayMode.GetFieldDominance"/> for details)
		/// </summary>
		bmdProgressiveSegmentedFrame = 1886610976
	}
}