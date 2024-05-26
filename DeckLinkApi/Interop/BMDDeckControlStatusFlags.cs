namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckControlStatusFlags enumerates the possible deck control status flags.
	/// </summary>
	[Flags]
	public enum BMDDeckControlStatusFlags
	{
		/// <summary>
		/// The deck has been connected (TRUE) / disconnected (FALSE).
		/// </summary>
		bmdDeckControlStatusDeckConnected = 1,

		/// <summary>
		/// The deck is in remote (TRUE) / local mode (FALSE).
		/// </summary>
		bmdDeckControlStatusRemoteMode = 2,

		/// <summary>
		/// Recording is inhibited (TRUE) / allowed(FALSE).
		/// </summary>
		bmdDeckControlStatusRecordInhibited = 4,

		/// <summary>
		/// The deck does not have a cassette (TRUE).
		/// </summary>
		bmdDeckControlStatusCassetteOut = 8
	}
}