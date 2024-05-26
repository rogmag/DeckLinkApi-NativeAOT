namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckLinkFrameMetadataID enumerates the set of video frame metadata which may be queried from the <see cref="IDeckLinkVideoFrameMetadataExtensions"/> interface.
	/// </summary>
	public enum BMDDeckLinkFrameMetadataID
	{
		/// <summary>
		/// Int - EOTF in range 0 – 7 as per CEA 861.3
		/// </summary>
		bmdDeckLinkFrameMetadataHDRElectroOpticalTransferFunc = 1701803110,

		/// <summary>
		/// Float - Red display primaries in range 0.0 – 1.0
		/// </summary>
		bmdDeckLinkFrameMetadataHDRDisplayPrimariesRedX = 1751413368,

		/// <summary>
		/// Float - Red display primaries in range 0.0 – 1.0
		/// </summary>
		bmdDeckLinkFrameMetadataHDRDisplayPrimariesRedY = 1751413369,

		/// <summary>
		/// Float - Green display primaries in range 0.0 – 1.0
		/// </summary>
		bmdDeckLinkFrameMetadataHDRDisplayPrimariesGreenX = 1751410552,

		/// <summary>
		/// Float - Green display primaries in range 0.0 – 1.0
		/// </summary>
		bmdDeckLinkFrameMetadataHDRDisplayPrimariesGreenY = 1751410553,

		/// <summary>
		/// Float - Blue display primaries in range 0.0 – 1.0
		/// </summary>
		bmdDeckLinkFrameMetadataHDRDisplayPrimariesBlueX = 1751409272,

		/// <summary>
		/// Float - Blue display primaries in range 0.0 – 1.0
		/// </summary>
		bmdDeckLinkFrameMetadataHDRDisplayPrimariesBlueY = 1751409273,

		/// <summary>
		/// Float - White point in range 0.0 – 1.0
		/// </summary>
		bmdDeckLinkFrameMetadataHDRWhitePointX = 1751414648,

		/// <summary>
		/// Float - White point in range 0.0 – 1.0
		/// </summary>
		bmdDeckLinkFrameMetadataHDRWhitePointY = 1751414649,

		/// <summary>
		/// Float - Max display mastering luminance in range 1 cd/m2 – 65535 cd/m2
		/// </summary>
		bmdDeckLinkFrameMetadataHDRMaxDisplayMasteringLuminance = 1751412076,

		/// <summary>
		/// Float - Min display mastering luminance in range 0.0001 cd/m2 – 6.5535 cd/m2
		/// </summary>
		bmdDeckLinkFrameMetadataHDRMinDisplayMasteringLuminance = 1752000876,

		/// <summary>
		/// Float - Maximum Content Light Level in range 1 cd/m2 – 65535 cd/m2
		/// </summary>
		bmdDeckLinkFrameMetadataHDRMaximumContentLightLevel = 1835232364,

		/// <summary>
		/// Float - Maximum Frame Average Light Level in range 1 cd/m2 – 65535 cd/m2
		/// </summary>
		bmdDeckLinkFrameMetadataHDRMaximumFrameAverageLightLevel = 1717660780,

		/// <summary>
		/// Int - Colorspace of video frame (see <see cref="BMDColorspace"/>)
		/// </summary>
		bmdDeckLinkFrameMetadataColorspace = 1668509795,
		
		bmdDeckLinkFrameMetadataHDMIInputTimecodePacking = 1752461419,

		bmdDeckLinkFrameMetadataCintel = 1667853933
	}
}