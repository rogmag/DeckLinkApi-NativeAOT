namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDTimecodeFormat enumerates the possible video frame timecode formats.
	/// </summary>
	public enum BMDTimecodeFormat
	{
		/// <summary>
		/// RP188 VITC1 timecode (DBB1=1) on line 9.
		/// </summary>
		bmdTimecodeRP188VITC1 = 1919972913,

		/// <summary>
		/// RP188 VITC2 timecode (DBB1=2) on line 571.
		/// </summary>
		bmdTimecodeRP188VITC2 = 1919955250,

		/// <summary>
		/// RP188 LTC timecode (DBB1=0) on line 10, or the dedicated LTC input if bmdDeckLinkConfigUseDedicatedLTCInput is true.
		/// </summary>
		bmdTimecodeRP188LTC = 1919970420,

		/// <summary>
		/// RP188 HFR timecode (DBB1=8xh)
		/// </summary>
		bmdTimecodeRP188HighFrameRate = 1919969394,

		/// <summary>
		/// In capture mode the first valid RP188 timecode will be returned. In playback mode the timecode is set as RP188 VITC1.
		/// </summary>
		bmdTimecodeRP188Any = 1919955256,

		bmdTimecodeLTC = 1819566880,

		/// <summary>
		/// VITC timecode field 1.
		/// </summary>
		bmdTimecodeVITC = 1986622563,

		/// <summary>
		/// VITC timecode field 2.
		/// </summary>
		bmdTimecodeVITCField2 = 1986622514,

		/// <summary>
		/// Serial timecode.
		/// </summary>
		bmdTimecodeSerial = 1936028265
	}
}