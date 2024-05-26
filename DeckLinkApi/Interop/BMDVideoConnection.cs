namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDVideoConnection enumerates the possible video connection interfaces.
	/// </summary>
	[Flags]
	public enum BMDVideoConnection
	{
		/// <summary>
		/// Unspecified video connection, for purpose of checking video mode support with <see cref="IDeckLinkInput.DoesSupportVideoMode"/> and <see cref="IDeckLinkOutput.DoesSupportVideoMode"/> methods.
		/// </summary>
		bmdVideoConnectionUnspecified = 0,

		/// <summary>
		/// SDI video connection
		/// </summary>
		bmdVideoConnectionSDI = 1,

		/// <summary>
		/// HDMI video connection
		/// </summary>
		bmdVideoConnectionHDMI = 2,

		/// <summary>
		/// Optical SDI connection
		/// </summary>
		bmdVideoConnectionOpticalSDI = 4,

		/// <summary>
		/// Component video connection
		/// </summary>
		bmdVideoConnectionComponent = 8,

		/// <summary>
		/// Composite video connection
		/// </summary>
		bmdVideoConnectionComposite = 0x10,

		/// <summary>
		/// S-Video connection
		/// </summary>
		bmdVideoConnectionSVideo = 0x20,

		/// <summary>
		/// Ethernet connection
		/// </summary>
		bmdVideoConnectionEthernet = 0x40,

		/// <summary>
		/// Optical Ethernet connection
		/// </summary>
		bmdVideoConnectionOpticalEthernet = 0x80
	}
}