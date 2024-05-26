namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDVideoInputFlags enumerates a set of flags applicable to video input.
	/// </summary>
	[Flags]
	public enum BMDVideoInputFlags
	{
		/// <summary>
		/// No other flags applicable
		/// </summary>
		bmdVideoInputFlagDefault = 0,

		/// <summary>
		/// Enable video input mode detection. (See <see cref="IDeckLinkInputCallback.VideoInputFormatChanged"/> for details)
		/// </summary>
		bmdVideoInputEnableFormatDetection = 1,

		/// <summary>
		/// Set the DeckLink device to capture the 3D mode version of the selected <see cref="BMDDisplayMode"/> display mode. 
		/// </summary>
		bmdVideoInputDualStream3D = 2,

		/// <summary>
		/// Enable grouping with other DeckLInk devices to synchonize the capture start and stop
		/// </summary>
		bmdVideoInputSynchronizeToCaptureGroup = 4
	}
}