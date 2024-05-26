namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDPixelFormat enumerates the pixel formats supported for output and input.
	/// </summary>
	public enum BMDPixelFormat
	{
		/// <summary>
		/// This represents any pixel format for the purpose of checking display mode support with the <see cref="IDeckLinkInput.DoesSupportVideoMode"/> and <see cref="IDeckLinkOutput.DoesSupportVideoMode"/> methods.
		/// </summary>
		bmdFormatUnspecified = 0,

		/// <summary>
		/// <para>‘UYVY’ 4:2:2 Representation</para>
		/// <para>Four 8-bit unsigned components (CCIR 601) are packed into one 32-bit little-endian word.</para>
		/// </summary>
		bmdFormat8BitYUV = 846624121,

		/// <summary>
		/// <para>‘v210’ 4:2:2 Representation</para>
		/// <para>Twelve 10-bit unsigned components are packed into four 32-bit little-endian words.</para>
		/// </summary>
		bmdFormat10BitYUV = 1983000880,

		/// <summary>
		/// <para>‘Ay10’ 4:2:2 raw</para>
		/// <para>Six 10-bit unsigned components are packed into two 32-bit big-endian words. The alpha channel is valid and full range.</para>
		/// </summary>
		bmdFormat10BitYUVA = 1098461488,

		/// <summary>
		/// <para>ARGB (or ARGB32) 4:4:4:4 raw</para>
		/// <para>Four 8-bit unsigned components are packed into one 32-bit little-endian word. Alpha channel is valid.</para>
		/// </summary>
		bmdFormat8BitARGB = 32,

		/// <summary>
		/// <para>BGRA (or RGB32) 4:4:4:x raw</para>
		/// <para>Four 8-bit unsigned components are packed into one 32-bit little-endian word. The alpha channel may be valid.</para>
		/// </summary>
		bmdFormat8BitBGRA = 1111970369,

		/// <summary>
		/// <para>‘r210’ 4:4:4 raw</para>
		/// <para>Three 10-bit unsigned components are packed into one 32-bit big-endian word.</para>
		/// </summary>
		bmdFormat10BitRGB = 1915892016,

		/// <summary>
		/// <para>‘R12B’</para>
		/// <para>Big-endian RGB 12-bit per component with full range (0-4095). Packed as 12-bit per component.</para>
		/// <para>This 12-bit pixel format is compatible with SMPTE 268M Digital Moving-Picture Exchange version 1, Annex C, Method C4 packing.</para>
		/// </summary>
		bmdFormat12BitRGB = 1378955842,

		/// <summary>
		/// <para>‘R12L’</para>
		/// <para>Little-endian RGB 12-bit per component with full range (0-4095). Packed as 12-bit per component.</para>
		/// <para>This 12-bit pixel format is compatible with SMPTE 268M Digital Moving-Picture Exchange version 1, Annex C, Method C4 packing.</para>
		/// </summary>
		bmdFormat12BitRGBLE = 1378955852,

		bmdFormat10BitXYZ = 2021208368,

		bmdFormat8BitRGBA = 1380401729,

		/// <summary>
		/// <para>‘R10l’ 4:4:4 raw</para>
		/// <para>Three 10-bit unsigned components are packed into one 32-bit little-endian word.</para>
		/// </summary>
		bmdFormat10BitRGBXLE = 1378955372,

		/// <summary>
		/// <para>‘R10b’ 4:4:4 raw</para>
		/// <para>Three 10-bit unsigned components are packed into one 32-bit big-endian word.</para>
		/// </summary>
		bmdFormat10BitRGBX = 1378955362,


		bmdFormat8BitvRGB = 1985103682,
		bmdFormat8BitBGRv = 1111970422,
		bmdFormat12BitRGB_SMPTE = 1378955874,
		bmdFormat12BitRGBLE_SMPTE = 1378955884,
		bmdFormat10BitRGBXLE_FULL = 1378955340,
		bmdFormat10BitRGBX_FULL = 1378955330,
		bmdFormatProRes4444XQ = 1634743416,
		bmdFormatProRes4444 = 1634743400,
		bmdFormatProResHQ = 1634755432,
		bmdFormatProRes = 1634755438,
		bmdFormatProResLT = 1634755443,
		bmdFormatProResProxy = 1634755439,

		/// <summary>
		/// <para>‘hev1’</para>
		/// <para>This pixel format represents compressed H.265 encoded video data.</para>
		/// <para>This pixel format is compatible with ITU-T H.265 High Efficiency Video Coding.</para>
		/// </summary>
		bmdFormatH265 = 1751479857,

		bmdFormatDNxHD = 1096180846,

		/// <summary>
		/// <para>‘AVdh’</para>
		/// <para>This pixel format represents compressed DNxHR encoded video data.</para>
		/// </summary>
		bmdFormatDNxHR = 1096180840,

		bmdFormat12BitRAWGRBG = 1915826800,
		bmdFormat12BitRAWJPEG = 1915827824
	}
}