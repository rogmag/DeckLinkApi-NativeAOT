namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDAudioConnection enumerates the possible audio connection interfaces.
	/// </summary>
	[Flags]
	public enum BMDAudioConnection
	{
		/// <summary>
		/// Embedded SDI or HDMI audio connection
		/// </summary>
		bmdAudioConnectionEmbedded = 1,

		/// <summary>
		/// AES/EBU audio connection
		/// </summary>
		bmdAudioConnectionAESEBU = 2,

		/// <summary>
		/// Analog audio connection
		/// </summary>
		bmdAudioConnectionAnalog = 4,

		/// <summary>
		/// Analog XLR audio connection
		/// </summary>
		bmdAudioConnectionAnalogXLR = 8,

		/// <summary>
		/// Analog RCA audio connection
		/// </summary>
		bmdAudioConnectionAnalogRCA = 0x10,

		/// <summary>
		/// Analog Microphone audio connection
		/// </summary>
		bmdAudioConnectionMicrophone = 0x20,

		/// <summary>
		/// Analog Headphone audio connection
		/// </summary>
		bmdAudioConnectionHeadphones = 0x40
	}
}