namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDEthernetLinkState enumerates the state of the Ethernet link.
	/// </summary>
	public enum BMDEthernetLinkState
	{
		/// <summary>
		/// The physical Ethernet link is disconnected
		/// </summary>
		bmdEthernetLinkStateDisconnected = 1701602419,

		/// <summary>
		/// Ethernet is connected but not bound to an IP configuration
		/// </summary>
		bmdEthernetLinkStateConnectedUnbound = 1701602165,

		/// <summary>
		/// Ethernet is connected and bound to an IP configuration
		/// </summary>
		bmdEthernetLinkStateConnectedBound = 1701602146
	}
}