namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDuplexMode enumerates the duplex mode associated with a profile.
	/// </summary>
	public enum BMDDuplexMode
	{
		/// <summary>
		/// Capable of simultaneous playback and capture.
		/// </summary>
		bmdDuplexFull = 1685612149,

		/// <summary>
		/// Capable of playback or capture but not both simultaneously
		/// </summary>
		bmdDuplexHalf = 1685612641,

		/// <summary>
		/// Capable of playback only or capture only
		/// </summary>
		bmdDuplexSimplex = 1685615472,

		/// <summary>
		/// Device is inactive for this profile
		/// </summary>
		bmdDuplexInactive = 1685612910
	}
}