namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDProfileID enumerates the possible profiles for a device.
	/// </summary>
	public enum BMDProfileID
	{
		bmdProfileCollated = 1668246636,

		/// <summary>
		/// Device with a single sub-device in full-duplex mode
		/// </summary>
		bmdProfileOneSubDeviceFullDuplex = 828663396,

		/// <summary>
		/// Device with a single sub-device in half-duplex mode
		/// </summary>
		bmdProfileOneSubDeviceHalfDuplex = 828663908,

		/// <summary>
		/// Device with two sub-devices in full-duplex mode
		/// </summary>
		bmdProfileTwoSubDevicesFullDuplex = 845440612,

		/// <summary>
		/// Device with two sub-devices in half-duplex mode
		/// </summary>
		bmdProfileTwoSubDevicesHalfDuplex = 845441124,

		/// <summary>
		/// Device with four sub-devices in half-duplex mode
		/// </summary>
		bmdProfileFourSubDevicesHalfDuplex = 878995556
	}
}