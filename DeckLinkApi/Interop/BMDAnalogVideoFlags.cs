namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDAnalogVideoFlags enumerates a set of flags applicable to analog video.
	/// </summary>
	[Flags]
	public enum BMDAnalogVideoFlags
	{
		/// <summary>
		/// This flag is only applicable to NTSC composite video and sets the black level to 7.5 IRE, which is used in the USA, rather than the default of 0.0 IRE which is used in Japan.
		/// </summary>
		bmdAnalogVideoFlagCompositeSetup75 = 1,

		/// <summary>
		/// This flag is only applicable to the component analog video levels. It sets the levels of the color difference channels in accordance to the SMPTE standard or boosts them by a factor of 4/3 for the Betacam format.
		/// </summary>
		bmdAnalogVideoFlagComponentBetacamLevels
	}
}