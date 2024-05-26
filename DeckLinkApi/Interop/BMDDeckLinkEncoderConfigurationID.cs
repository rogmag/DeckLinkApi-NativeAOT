using System.Runtime.Intrinsics.X86;

namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckLinkEncoderConfigurationID enumerates the set of video encoder configuration settings which may be set or queried(see <see cref="IDeckLinkEncoderConfiguration"/> for details).
	/// </summary>
	public enum BMDDeckLinkEncoderConfigurationID
	{
		/// <summary>
		/// Int - Video encoder bit depth. Acceptable values are 8, 10, representing 8bit, 10bit respectively.
		/// </summary>
		bmdDeckLinkEncoderConfigPreferredBitDepth = 1701864050,

		/// <summary>
		/// Int - Video encoder frame coding mode. See <see cref="BMDVideoEncoderFrameCodingMode"/> for more information.
		/// </summary>
		bmdDeckLinkEncoderConfigFrameCodingMode = 1701208941,

		/// <summary>
		/// Int - H.265 target bitrate. Acceptable range is between 2500 (2.5Mbit/s) and 50000000 (50Mbit/s).
		/// </summary>
		bmdDeckLinkEncoderConfigH265TargetBitrate = 1752457842,

		/// <summary>
		/// Bytes - Codec configuration data represented as a full MPEG4 sample description (aka SampleEntry of an ‘stsd’ atom-box). Useful for MediaFoundation, QuickTime, MKV and more.
		/// <para>Note: The buffer returned by this configuration item is only valid while encoded video input is enabled (i.e. <see cref="IDeckLinkEncoderInput.EnableVideoInput"/> has been called).</para>
		/// </summary>
		bmdDeckLinkEncoderConfigMPEG4SampleDescription = 1937011525,

		/// <summary>
		/// Bytes - Codec configuration data represented as sample description extensions only (atom stream, each with size and fourCC header). Useful for AVFoundation, VideoToolbox, MKV and more.
		/// Note: The buffer returned by this configuration item is only valid while encoded video input is enabled (i.e. <see cref="IDeckLinkEncoderInput.EnableVideoInput"/> has been called).
		/// </summary>
		bmdDeckLinkEncoderConfigMPEG4CodecSpecificDesc = 1702061171,

		/// <summary>
		/// Int - DNxHR Compression ID.
		/// </summary>
		bmdDeckLinkEncoderConfigDNxHRCompressionID = 1684236644,

		/// <summary>
		/// Int - DNxHR Level. <see cref="BMDDNxHRLevel"/> enumerates the available DNxHR levels.
		/// </summary>
		bmdDeckLinkEncoderConfigDNxHRLevel = 1684825462
	}
}