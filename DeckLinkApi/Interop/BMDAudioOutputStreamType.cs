namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDAudioOutputStreamType enumerates the Audio output stream type (see <see cref="IDeckLinkOutput.EnableAudioOutput"/> for details).
	/// </summary>
	public enum BMDAudioOutputStreamType
	{
		/// <summary>
		/// Audio stream is continuous.
		/// </summary>
		bmdAudioOutputStreamContinuous,

		bmdAudioOutputStreamContinuousDontResample,

		/// <summary>
		/// Audio stream is time stamped.
		/// </summary>
		bmdAudioOutputStreamTimestamped
	}
}