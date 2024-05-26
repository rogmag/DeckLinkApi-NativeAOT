namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDisplayModeFlags enumerates the possible characteristics of an <see cref="IDeckLinkDisplayMode"/> object.
	/// </summary>
	[Flags]
	public enum BMDDisplayModeFlags
	{
		/// <summary>
		/// The 3D equivalent of this display mode is supported by the installed DeckLink device.
		/// </summary>
		bmdDisplayModeSupports3D = 1,

		/// <summary>
		/// This display mode uses the Rec. 601 standard for encoding interlaced analogue video signals in digital form.
		/// </summary>
		bmdDisplayModeColorspaceRec601 = 2,

		/// <summary>
		/// This display mode uses the Rec. 709 standard for encoding high definition video content.
		/// </summary>
		bmdDisplayModeColorspaceRec709 = 4,

		/// <summary>
		/// This display mode uses the Rec. 2020 standard for encoding ultra-high definition video content.
		/// </summary>
		bmdDisplayModeColorspaceRec2020 = 8
	}
}