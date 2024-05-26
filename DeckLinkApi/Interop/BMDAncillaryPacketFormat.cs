namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDAncillaryPacketFormat enumerates the possible data formats of the ancillary packet.
	/// </summary>
	public enum BMDAncillaryPacketFormat
	{
		/// <summary>
		/// 8-bit unsigned integer
		/// </summary>
		bmdAncillaryPacketFormatUInt8 = 1969827896,

		/// <summary>
		/// 16-bit unsigned integer
		/// </summary>
		bmdAncillaryPacketFormatUInt16 = 1969828150,

		/// <summary>
		/// Native v210 pixel format (see <see cref="bmdFormat10BitYUV"/> for packing structure).
		/// </summary>
		bmdAncillaryPacketFormatYCbCr10 = 1983000880
	}
}