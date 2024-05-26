namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDOutputFrameCompletionResult enumerates the possible frame output completion statuses.
	/// </summary>
	public enum BMDOutputFrameCompletionResult
	{
		/// <summary>
		/// Frame was displayed normally
		/// </summary>
		bmdOutputFrameCompleted,

		/// <summary>
		/// Frame was displayed late
		/// </summary>
		bmdOutputFrameDisplayedLate,

		/// <summary>
		/// Frame was dropped
		/// </summary>
		bmdOutputFrameDropped,

		/// <summary>
		/// Frame was flushed
		/// </summary>
		bmdOutputFrameFlushed
	}
}