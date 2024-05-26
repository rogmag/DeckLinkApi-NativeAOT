namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckLinkCapturePassthroughMode enumerates whether the video output is electrical connected to the video input or if the clean switching mode is enabled.
	/// </summary>
	public enum BMDDeckLinkCapturePassthroughMode
	{
		/// <summary>
		/// In direct mode the monitoring video output is directly electrically connected to the video input.
		/// </summary>
		bmdDeckLinkCapturePassthroughModeDirect = 1885628786,

		/// <summary>
		/// In clean switch mode, the captured video is played back out the monitoring outputs allowing a clean switch between monitoring and playback if the video modes are compatible. The monitoring output signal is affected by the options specified on capture and some latency is introduced between capture and monitoring.
		/// </summary>
		bmdDeckLinkCapturePassthroughModeCleanSwitch = 1885564014,

		/// <summary>
		/// In disabled mode the video input is not displayed out the monitoring outputs, which instead display black frames or the last frame played, dependant on the configuration of the Idle Output setting (see <see cref="BMDIdleVideoOutputOperation"/>).
		/// </summary>
		bmdDeckLinkCapturePassthroughModeDisabled = 1885628787
	}
}