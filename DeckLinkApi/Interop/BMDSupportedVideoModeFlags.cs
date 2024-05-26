namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDSupportedVideoModeFlags enumerates the possible video mode flags when checking support with <see cref="IDeckLinkInput.DoesSupportVideoMode"/>, <see cref="IDeckLinkOutput.DoesSupportVideoMode"/> and <see cref="IDeckLinkEncoderInput.DoesSupportVideoMode"/> methods.
	/// </summary>
	[Flags]
	public enum BMDSupportedVideoModeFlags
	{
		/// <summary>
		/// Check whether video mode is supported by device
		/// </summary>
		bmdSupportedVideoModeDefault = 0,

		/// <summary>
		/// Check whether keying is supported with video mode
		/// </summary>
		bmdSupportedVideoModeKeying = 1,

		/// <summary>
		/// Check whether dual-stream 3D is supported with video mode
		/// </summary>
		bmdSupportedVideoModeDualStream3D = 2,

		/// <summary>
		/// Check whether video mode is supported with single-link SDI connection
		/// </summary>
		bmdSupportedVideoModeSDISingleLink = 4,

		/// <summary>
		/// Check whether video mode is supported with dual-link SDI connection
		/// </summary>
		bmdSupportedVideoModeSDIDualLink = 8,

		/// <summary>
		/// Check whether video mode is supported with quad-link SDI connection
		/// </summary>
		bmdSupportedVideoModeSDIQuadLink = 0x10,

		/// <summary>
		/// Check whether video mode is supported with any device profile (by default only the current profile is checked)
		/// </summary>
		bmdSupportedVideoModeInAnyProfile = 0x20,

		/// <summary>
		/// Check whether device supports PsF interpretation of video mode (refer also to <see cref="BMDDeckLinkConfigurationID.bmdDeckLinkConfigOutput1080pAsPsF"/> or <see cref="BMDDeckLinkConfigurationID.bmdDeckLinkConfigCapture1080pAsPsF"/>)
		/// </summary>
		bmdSupportedVideoModePsF = 0x40
	}
}