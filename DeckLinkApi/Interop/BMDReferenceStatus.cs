namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDReferenceStatus enumerates the genlock reference statuses of the DeckLink device.
	/// </summary>
	public enum BMDReferenceStatus
	{
		/// <summary>
		/// Genlock reference lock has not been achieved.
		/// </summary>
		bmdReferenceUnlocked,

		/// <summary>
		/// The DeckLink device does not have a genlock input connector.
		/// </summary>
		bmdReferenceNotSupportedByHardware,

		/// <summary>
		/// Genlock reference lock has been achieved.
		/// </summary>
		bmdReferenceLocked
	}
}