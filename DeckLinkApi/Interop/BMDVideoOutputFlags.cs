namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDVideoOutputFlags enumerates flags which control the output of video data.
	/// </summary>
	[Flags]
	public enum BMDVideoOutputFlags
	{
		/// <summary>
		/// No flags applicable.
		/// </summary>
		bmdVideoOutputFlagDefault = 0,

		/// <summary>
		/// Output VANC data. If supplied see: <see cref="IDeckLinkMutableVideoFrame.SetAncillaryData"/>
		/// </summary>
		bmdVideoOutputVANC = 1,

		/// <summary>
		/// Output VITC timecode data. If supplied see: <see cref="IDeckLinkMutableVideoFrame.SetTimecode"/>
		/// </summary>
		bmdVideoOutputVITC = 2,

		/// <summary>
		/// Output RP188 timecode. If supplied see: <see cref="IDeckLinkMutableVideoFrame.SetTimecode"/>
		/// </summary>
		bmdVideoOutputRP188 = 4,

		bmdVideoOutputLTC = 8,

		/// <summary>
		/// Set the DeckLink device to output the 3D version of the selected <see cref="BMDDisplayMode"/> display mode.
		/// </summary>
		bmdVideoOutputDualStream3D = 0x10,

		bmdVideoOutputSyncExternalAudioToSOF = 0x20,

		/// <summary>
		/// Enable grouping with other DeckLInk devices to synchonize the playback start and stop.
		/// </summary>
		bmdVideoOutputSynchronizeToPlaybackGroup = 0x40
	}
}