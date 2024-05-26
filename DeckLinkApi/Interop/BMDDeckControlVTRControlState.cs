namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckControlVTRControlState enumerates the possible deck control VTR control states.
	/// </summary>
	public enum BMDDeckControlVTRControlState
	{
		/// <summary>
		/// The deck is currently not in VTR control mode.
		/// </summary>
		bmdDeckControlNotInVTRControlMode = 1853252461,

		/// <summary>
		/// The deck is currently playing.
		/// </summary>
		bmdDeckControlVTRControlPlaying = 1987342960,

		/// <summary>
		/// The deck is currently recording.
		/// </summary>
		bmdDeckControlVTRControlRecording = 1987342962,

		/// <summary>
		/// The deck is currently paused.
		/// </summary>
		bmdDeckControlVTRControlStill = 1987342945,

		/// <summary>
		/// The deck is currently in shuttle forward mode.
		/// </summary>
		bmdDeckControlVTRControlShuttleForward = 1987343206,

		/// <summary>
		/// The deck is currently in shuttle reverse mode.
		/// </summary>
		bmdDeckControlVTRControlShuttleReverse = 1987343218,

		/// <summary>
		/// The deck is currently in jog (one frame at a time) forward mode.
		/// </summary>
		bmdDeckControlVTRControlJogForward = 1987340902,

		/// <summary>
		/// The deck is currently in jog (one frame at a time) reverse mode.
		/// </summary>
		bmdDeckControlVTRControlJogReverse = 1987340914,

		/// <summary>
		/// The deck is currently stopped.
		/// </summary>
		bmdDeckControlVTRControlStopped = 1987342959
	}
}