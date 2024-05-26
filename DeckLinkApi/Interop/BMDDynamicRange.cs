namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDynamicRange enumerates the possible dynamic range standards
	/// </summary>
	public enum BMDDynamicRange
	{
		/// <summary>
		/// Standard Dynamic Range
		/// </summary>
		bmdDynamicRangeSDR = 0,

		/// <summary>
		/// High Dynamic Range PQ (SMPTE ST 2084)
		/// </summary>
		bmdDynamicRangeHDRStaticPQ = 0x20000000,

		/// <summary>
		/// High Dynamic Range HLG (ITU-R BT.2100-0)
		/// </summary>
		bmdDynamicRangeHDRStaticHLG = 0x40000000
	}
}