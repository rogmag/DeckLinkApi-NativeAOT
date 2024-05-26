namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDVideoIOSupport enumerates the capture and playback capabilities of a device.
	/// </summary>
	[Flags]
	public enum BMDVideoIOSupport
	{
		/// <summary>
		/// The DeckLink device supports capture operations.
		/// </summary>
		bmdDeviceSupportsCapture = 1,

		/// <summary>
		/// The DeckLink device supports playback operation.
		/// </summary>
		bmdDeviceSupportsPlayback
	}
}