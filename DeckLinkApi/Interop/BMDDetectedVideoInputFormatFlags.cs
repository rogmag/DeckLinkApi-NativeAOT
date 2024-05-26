namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDetectedVideoInputFormatFlags enumerates the video input signal (See <see cref="IDeckLinkInputCallback.VideoInputFormatChanged"/> for details)
	/// </summary>
	[Flags]
	public enum BMDDetectedVideoInputFormatFlags
	{
		/// <summary>
		/// The video input detected is YCbCr 4:2:2 represention.
		/// </summary>
		bmdDetectedVideoInputYCbCr422 = 1,

		/// <summary>
		/// The video input detected is RGB 4:4:4 represention
		/// </summary>
		bmdDetectedVideoInputRGB444 = 2,

		/// <summary>
		/// The video input detected is dual stream 3D video.
		/// </summary>
		bmdDetectedVideoInputDualStream3D = 4,

		/// <summary>
		/// The video input detected is 12-bit color depth.
		/// </summary>
		bmdDetectedVideoInput12BitDepth = 8,

		/// <summary>
		/// The video input detected is 10-bit color depth.
		/// </summary>
		bmdDetectedVideoInput10BitDepth = 0x10,

		/// <summary>
		/// The video input detected is 8-bit color depth.
		/// </summary>
		bmdDetectedVideoInput8BitDepth = 0x20
	}
}