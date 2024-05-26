namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeviceBusyState enumerates the possible busy states for a device
	/// </summary>
	[Flags]
	public enum BMDDeviceBusyState
	{
		/// <summary>
		/// The device is currently being used for capture.
		/// </summary>
		bmdDeviceCaptureBusy = 1,

		/// <summary>
		/// The device is currently being used for playback.
		/// </summary>
		bmdDevicePlaybackBusy = 2,

		/// <summary>
		/// The device’s serial port is currently being used.
		/// </summary>
		bmdDeviceSerialPortBusy = 4
	}
}