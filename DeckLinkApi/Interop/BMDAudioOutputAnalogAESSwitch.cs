namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDAudioOutputAnalogAESSwitch enumerates the settings of the audio output Analog / AES switch.
	/// Refer to the <see cref="IDeckLinkConfiguration"/> interface to get and set analog / AES switch settings.
	/// </summary>
	public enum BMDAudioOutputAnalogAESSwitch
	{
		/// <summary>
		/// AES / EBU audio output.
		/// </summary>
		bmdAudioOutputSwitchAESEBU = 1634038560,

		/// <summary>
		/// Analog audio output.
		/// </summary>
		bmdAudioOutputSwitchAnalog = 1634626663
	}
}