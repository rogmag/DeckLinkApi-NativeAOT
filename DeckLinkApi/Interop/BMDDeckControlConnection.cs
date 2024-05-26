namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckControlConnection enumerates the possible deck control connections.
	/// </summary>
	[Flags]
	public enum BMDDeckControlConnection
	{
		/// <summary>
		/// First RS422 deck control connection
		/// </summary>
		bmdDeckControlConnectionRS422Remote1 = 1,

		/// <summary>
		/// Second RS422 deck control connection
		/// </summary>
		bmdDeckControlConnectionRS422Remote2
	}
}