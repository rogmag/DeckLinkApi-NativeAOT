namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeviceInterface enumerates the possible interfaces by which the device is connected.
	/// </summary>
	public enum BMDDeviceInterface
	{
		/// <summary>
		/// PCI
		/// </summary>
		bmdDeviceInterfacePCI = 1885563168,

		/// <summary>
		/// USB
		/// </summary>
		bmdDeviceInterfaceUSB = 1970496032,

		/// <summary>
		/// Thunderbolt
		/// </summary>
		bmdDeviceInterfaceThunderbolt = 1953002862
	}
}