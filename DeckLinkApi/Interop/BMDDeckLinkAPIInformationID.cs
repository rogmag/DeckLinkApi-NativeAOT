namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckLinkAPIInformationID enumerates a set of information details which may be queried (see <see cref="IDeckLinkAPIInformation"/> Interface for details).
	/// </summary>
	public enum BMDDeckLinkAPIInformationID
	{
		/// <summary>
		/// <para>String - The user viewable API version number. This allocated string must be freed by the caller when no longer required.</para>
		/// <para>Int - The API version number. Format:</para><para>Byte 4 = Major Version, Byte 3 = Minor Version, Byte 2 = Sub Version, Byte 1 = Extra.</para>
		/// </summary>
		BMDDeckLinkAPIVersion = 1986359923,

		BMDDeckLinkAPIEngineeringModeSetDeviceFilter = 1701405542,
		BMDDeckLinkAPIRCTag = 1952928323,
		BMDDeckLinkAPIEngineeringMode = 1701734253,
		BMDDeckLinkAPIStreamingServerRunning = 1937011570
	}
}