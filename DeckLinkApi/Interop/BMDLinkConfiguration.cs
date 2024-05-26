namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDLinkConfiguration enumerates the SDI video link configuration on a DeckLink device.
	/// </summary>
	public enum BMDLinkConfiguration
	{
		/// <summary>
		/// A single link video connection. A single video stream uses one connector.
		/// </summary>
		bmdLinkConfigurationSingleLink = 1818456940,

		/// <summary>
		/// A dual-link video connection. A single video stream uses two connectors.
		/// </summary>
		bmdLinkConfigurationDualLink = 1818453100,

		/// <summary>
		/// A quad-link video connection. A single video stream uses four connectors.
		/// </summary>
		bmdLinkConfigurationQuadLink = 1818456428
	}
}