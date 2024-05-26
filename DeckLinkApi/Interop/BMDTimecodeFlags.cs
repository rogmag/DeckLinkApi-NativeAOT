namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDTimecodeFlags enumerates the possible flags that accompany a timecode.
	/// </summary>
	[Flags]
	public enum BMDTimecodeFlags
	{
		/// <summary>
		/// Timecode is a non-drop timecode
		/// </summary>
		bmdTimecodeFlagDefault = 0,

		/// <summary>
		/// Timecode is a drop timecode
		/// </summary>
		bmdTimecodeIsDropFrame = 1,

		/// <summary>
		/// Timecode field mark flag used with frame rates above 30 FPS
		/// </summary>
		bmdTimecodeFieldMark = 2,

		/// <summary>
		/// Timecode color frame frame flag
		/// </summary>
		bmdTimecodeColorFrame = 4,

		/// <summary>
		/// Timecode embeds recording trigger
		/// </summary>
		bmdTimecodeEmbedRecordingTrigger = 8,

		/// <summary>
		/// Timecode recording is triggered flag
		/// </summary>
		bmdTimecodeRecordingTriggered = 0x10
	}
}