namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDIdleVideoOutputOperation enumerates the possible output modes when idle.
	/// </summary>
	public enum BMDIdleVideoOutputOperation
	{
		/// <summary>
		/// When not playing video, the device will output black frames.
		/// </summary>
		bmdIdleVideoOutputBlack = 1651269987,

		/// <summary>
		/// When not playing video, the device will output the last frame played.
		/// </summary>
		bmdIdleVideoOutputLastFrame = 1818322529
	}
}