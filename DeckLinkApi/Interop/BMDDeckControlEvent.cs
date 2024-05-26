namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckControlEvent enumerates the possible deck control events.
	/// </summary>
	public enum BMDDeckControlEvent
	{
		/// <summary>
		/// This event is triggered when a capture or edit-to-tape operation is aborted.
		/// </summary>
		bmdDeckControlAbortedEvent = 1633842277,

		/// <summary>
		/// This export-to-tape event is triggered a few frames before reaching the in-point. At this stage, <see cref="IDeckLinkOutput.StartScheduledPlayback"/> must be called.
		/// </summary>
		bmdDeckControlPrepareForExportEvent = 1885758821,

		/// <summary>
		/// This export-to-tape event is triggered a few frames after reaching the out-point. At this point, it is safe to stop playback. Upon reception of this event the deck’s control mode is set back to <see cref="BMDDeckControlMode.bmdDeckControlVTRControlMode"/>.
		/// </summary>
		bmdDeckControlExportCompleteEvent = 1702388581,

		/// <summary>
		/// This capture event is triggered a few frames before reaching the in-point. The serial timecode attached to <see cref="IDeckLinkVideoInputFrame"/>s is now valid.
		/// </summary>
		bmdDeckControlPrepareForCaptureEvent = 1885758309,

		/// <summary>
		/// This capture event is triggered a few frames after reaching the out-point. Upon reception of this event the deck’s control mode is set back to <see cref="BMDDeckControlMode.bmdDeckControlVTRControlMode"/>.
		/// </summary>
		bmdDeckControlCaptureCompleteEvent = 1667458422
	}
}