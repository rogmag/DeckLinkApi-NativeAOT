namespace DeckLinkApi.Interop
{
	/// <summary>
	/// The BMDVideo3DPackingFormat enumerates standard modes where two frames are packed into one.
	/// </summary>
	public enum BMDVideo3DPackingFormat
	{
		/// <summary>
		/// Frames are packed side-by-side as a single stream.
		/// </summary>
		bmdVideo3DPackingSidebySideHalf = 1935831912,

		/// <summary>
		/// The two eye frames are packed on alternating lines of the source frame.
		/// </summary>
		bmdVideo3DPackingLinebyLine = 1818392940,

		/// <summary>
		/// The two eye frames are packed into the top and bottom half of the source frame.
		/// </summary>
		bmdVideo3DPackingTopAndBottom = 1952539247,

		/// <summary>
		/// Frame packing is a standard HDMI 1.4a 3D mode (Top / Bottom full).
		/// </summary>
		bmdVideo3DPackingFramePacking = 1718775915,

		/// <summary>
		/// Only the left eye frame is displayed.
		/// </summary>
		bmdVideo3DPackingLeftOnly = 1818584692,

		/// <summary>
		/// Only the right eye frame is displayed.
		/// </summary>
		bmdVideo3DPackingRightOnly = 1919510376
	}
}