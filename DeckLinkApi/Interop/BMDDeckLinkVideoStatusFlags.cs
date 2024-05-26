namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckLinkVideoStatusFlags enumerates status flags associated with a video signal.
	/// </summary>
	[Flags]
	public enum BMDDeckLinkVideoStatusFlags
	{
		/// <summary>
		/// Progressive frames are encoded as PsF.
		/// </summary>
		bmdDeckLinkVideoStatusPsF = 1,

		/// <summary>
		/// The video signal is dual stream 3D video.
		/// </summary>
		bmdDeckLinkVideoStatusDualStream3D
	}
}