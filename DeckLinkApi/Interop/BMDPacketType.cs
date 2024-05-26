namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDPacketType enumerates the possible IDeckLinkEncoderPacket types.
	/// </summary>
	public enum BMDPacketType
	{
		/// <summary>
		/// A packet of this type marks when a video stream was interrupted.
		/// </summary>
		bmdPacketTypeStreamInterruptedMarker = 1936289396,

		/// <summary>
		/// Regular stream data.
		/// </summary>
		bmdPacketTypeStreamData = 1935958388
	}
}