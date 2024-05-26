namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDStreamingDeviceMode enumerates the possible device modes for the streaming device.
	/// </summary>
	public enum BMDStreamingDeviceMode
	{
		bmdStreamingDeviceNotPowered = 1886353266,
		bmdStreamingDeviceBooting = 1651470196,
		bmdStreamingDeviceNeedsFirmwareUpdate = 1718186605,
		bmdStreamingDeviceUpdatingFirmware = 1718972516,

		/// <summary>
		/// The streaming device is idle.
		/// </summary>
		bmdStreamingDeviceIdle = 1768189029,

		/// <summary>
		/// The streaming device is encoding.
		/// </summary>
		bmdStreamingDeviceEncoding = 1701733231,

		/// <summary>
		/// The streaming device is stopping.
		/// </summary>
		bmdStreamingDeviceStopping = 1937010544,

		/// <summary>
		/// The streaming device is in an unknown state.
		/// </summary>
		bmdStreamingDeviceUnknown = 1836412523
	}
}