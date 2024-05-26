namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDVideoInputConversionMode enumerates the possible video input conversions.
	/// </summary>
	public enum BMDVideoInputConversionMode
	{
		/// <summary>
		/// No video input conversion
		/// </summary>
		bmdNoVideoInputConversion = 1852796517,

		/// <summary>
		/// HD1080 to SD video input down conversion
		/// </summary>
		bmdVideoInputLetterboxDownconversionFromHD1080 = 825257058,

		/// <summary>
		/// Anamorphic from HD1080 to SD video input down conversion
		/// </summary>
		bmdVideoInputAnamorphicDownconversionFromHD1080 = 825254253,

		/// <summary>
		/// Letter box from HD720 to SD video input down conversion
		/// </summary>
		bmdVideoInputLetterboxDownconversionFromHD720 = 926051426,

		/// <summary>
		/// Anamorphic from HD720 to SD video input down conversion
		/// </summary>
		bmdVideoInputAnamorphicDownconversionFromHD720 = 926048621,

		/// <summary>
		/// Letterbox video input up conversion
		/// </summary>
		bmdVideoInputLetterboxUpconversion = 1818391920,

		/// <summary>
		/// Anamorphic video input up conversion
		/// </summary>
		bmdVideoInputAnamorphicUpconversion = 1634563440
	}
}