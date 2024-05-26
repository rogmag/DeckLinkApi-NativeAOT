namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDVideoOutputConversionMode enumerates the possible video output conversions.
	/// </summary>
	public enum BMDVideoOutputConversionMode
	{
		/// <summary>
		/// No video output conversion
		/// </summary>
		bmdNoVideoOutputConversion = 1852796517,

		/// <summary>
		/// Down-converted letterbox SD output
		/// </summary>
		bmdVideoOutputLetterboxDownconversion = 1819566712,

		/// <summary>
		/// Down-converted anamorphic SD output
		/// </summary>
		bmdVideoOutputAnamorphicDownconversion = 1634562152,

		/// <summary>
		/// HD720 to HD1080 conversion output
		/// </summary>
		bmdVideoOutputHD720toHD1080Conversion = 926036067,

		/// <summary>
		/// Simultaneous output of HD and down-converted letterbox SD
		/// </summary>
		bmdVideoOutputHardwareLetterboxDownconversion = 1213688930,

		/// <summary>
		/// Simultaneous output of HD and down-converted anamorphic SD
		/// </summary>
		bmdVideoOutputHardwareAnamorphicDownconversion = 1213686125,


		bmdVideoOutputHardware2KToSDAnamorphicDownconversion = 1748136804,

		/// <summary>
		/// Simultaneous output of HD and center cut SD
		/// </summary>
		bmdVideoOutputHardwareCenterCutDownconversion = 1213686627,

		bmdVideoOutputHardwareUHDToHDDownConversion = 1213691236,

		/// <summary>
		/// The simultaneous output of 720p and 1080p cross-conversion
		/// </summary>
		bmdVideoOutputHardware720p1080pCrossconversion = 2019778928,

		/// <summary>
		/// The simultaneous output of SD and up-converted anamorphic 720p
		/// </summary>
		bmdVideoOutputHardwareAnamorphic720pUpconversion = 1969305456,

		/// <summary>
		/// The simultaneous output of SD and up-converted anamorphic 1080i
		/// </summary>
		bmdVideoOutputHardwareAnamorphic1080iUpconversion = 1969303913,

		/// <summary>
		/// The simultaneous output of SD and up-converted anamorphic widescreen aspect ratio 14:9 to 720p.
		/// </summary>
		bmdVideoOutputHardwareAnamorphic149To720pUpconversion = 1966356336,

		/// <summary>
		/// The simultaneous output of SD and up-converted anamorphic widescreen aspect ratio 14:9 to 1080i.
		/// </summary>
		bmdVideoOutputHardwareAnamorphic149To1080iUpconversion = 1966354793,

		/// <summary>
		/// The simultaneous output of SD and up-converted pillarbox 720p
		/// </summary>
		bmdVideoOutputHardwarePillarbox720pUpconversion = 1970288496,

		/// <summary>
		/// The simultaneous output of SD and up-converted pillarbox 1080i
		/// </summary>
		bmdVideoOutputHardwarePillarbox1080iUpconversion = 1970286953,

		bmdVideoOutputHardwareAdvancedConversions = 1633973859
	}
}