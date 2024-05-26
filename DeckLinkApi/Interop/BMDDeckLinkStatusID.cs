namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckLinkStatusID enumerates the set of status information for a DeckLink device which may be queried (see the <see cref="IDeckLinkStatus"/> interface for details).
	/// </summary>
	public enum BMDDeckLinkStatusID
	{
		/// <summary>
		/// Int - The detected video input mode (<see cref="BMDDisplayMode"/>), available on devices which support input format detection.
		/// </summary>
		bmdDeckLinkStatusDetectedVideoInputMode = 1685481837,

		/// <summary>
		/// Int - The detected video input format flags (<see cref="BMDDetectedVideoInputFormatFlags"/>), available on devices which support input format detection.
		/// </summary>
		bmdDeckLinkStatusDetectedVideoInputFormatFlags = 1685481062,

		/// <summary>
		/// Int - The field dominance of the detected video input mode (<see cref="BMDFieldDominance"/>).
		/// </summary>
		bmdDeckLinkStatusDetectedVideoInputFieldDominance = 1685481060,

		/// <summary>
		/// Int - The colorspace of the detected video input (<see cref="BMDColorspace"/>).
		/// </summary>
		bmdDeckLinkStatusDetectedVideoInputColorspace = 1685283692,

		/// <summary>
		/// Int - The dynamic range of the detected video input (<see cref="BMDDynamicRange"/>).
		/// </summary>
		bmdDeckLinkStatusDetectedVideoInputDynamicRange = 1685283954,

		/// <summary>
		/// Int - The SDI video link configuration of the detected video input (<see cref="BMDLinkConfiguration"/>).
		/// </summary>
		bmdDeckLinkStatusDetectedSDILinkConfiguration = 1685285987,

		/// <summary>
		/// Int - The current video input mode (<see cref="BMDDisplayMode"/>).
		/// </summary>
		bmdDeckLinkStatusCurrentVideoInputMode = 1668704621,

		/// <summary>
		/// Int - The current video input pixel format (<see cref="BMDPixelFormat"/>).
		/// </summary>
		bmdDeckLinkStatusCurrentVideoInputPixelFormat = 1668704624,

		/// <summary>
		/// Int - The current video input flags (<see cref="BMDDeckLinkVideoStatusFlags"/>).
		/// </summary>
		bmdDeckLinkStatusCurrentVideoInputFlags = 1668704614,

		/// <summary>
		/// Int - The current video output mode (<see cref="BMDDisplayMode"/>).
		/// </summary>
		bmdDeckLinkStatusCurrentVideoOutputMode = 1668706157,

		/// <summary>
		/// Int - The current video output flags (<see cref="BMDDeckLinkVideoStatusFlags"/>).
		/// </summary>
		bmdDeckLinkStatusCurrentVideoOutputFlags = 1668706150,

		/// <summary>
		/// Int - For devices with Ethernet, the state of the link (<see cref="BMDEthernetLinkState"/>).
		/// </summary>
		bmdDeckLinkStatusEthernetLink = 1936026739,

		/// <summary>
		/// Int - For devices with Ethernet, the speed of the link in Mbps.
		/// </summary>
		bmdDeckLinkStatusEthernetLinkMbps = 1936028528,

		/// <summary>
		/// Int - PCIe link width, x1, x4, etc.
		/// </summary>
		bmdDeckLinkStatusPCIExpressLinkWidth = 1886873956,

		/// <summary>
		/// Int - PCIe link speed, Gen. 1, Gen. 2, etc.
		/// </summary>
		bmdDeckLinkStatusPCIExpressLinkSpeed = 1886154347,

		/// <summary>
		/// Int - The last video output pixel format (<see cref="BMDPixelFormat"/>).
		/// </summary>
		bmdDeckLinkStatusLastVideoOutputPixelFormat = 1869638008,

		/// <summary>
		/// Int - The detected reference input mode (<see cref="BMDDisplayMode"/>), available on devices which support reference input format detection.
		/// </summary>
		bmdDeckLinkStatusReferenceSignalMode = 1919247981,

		/// <summary>
		/// Int - The detected reference input flags (<see cref="BMDDeckLinkVideoStatusFlags"/>), available on devices which support reference input format detection.
		/// </summary>
		bmdDeckLinkStatusReferenceSignalFlags = 1919247974,

		/// <summary>
		/// Int - The current busy state of the device. (See <see cref="BMDDeviceBusyState"/> for more information).
		/// </summary>
		bmdDeckLinkStatusBusy = 1651864441,

		/// <summary>
		/// Int - The interchangeable panel installed (<see cref="BMDPanelType"/>).
		/// </summary>
		bmdDeckLinkStatusInterchangeablePanelType = 1768124532,

		/// <summary>
		/// Int - The on-board temperature (°C).
		/// </summary>
		bmdDeckLinkStatusDeviceTemperature = 1685351792,

		/// <summary>
		/// Flag - True if the video input signal is locked.
		/// </summary>
		bmdDeckLinkStatusVideoInputSignalLocked = 1986622316,

		/// <summary>
		/// Flag - True if the reference input signal is locked.
		/// </summary>
		bmdDeckLinkStatusReferenceSignalLocked = 1919247980,

		/// <summary>
		/// String - For devices with Ethernet, the current negotiated or static local IP address. Valid if <see cref="bmdDeckLinkStatusEthernetLink"/> is <see cref="BMDEthernetLinkState.bmdEthernetLinkStateConnectedBound"/>. For other link states, this returns S_FALSE and an empty string.
		/// </summary>
		bmdDeckLinkStatusEthernetLocalIPAddress = 1936025968,

		/// <summary>
		/// String - For devices with Ethernet, the current negotiated or static subnet mask. Valid if <see cref="bmdDeckLinkStatusEthernetLink"/> is <see cref="BMDEthernetLinkState.bmdEthernetLinkStateConnectedBound"/>. For other link states, this returns S_FALSE and an empty string.
		/// </summary>
		bmdDeckLinkStatusEthernetSubnetMask = 1936028525,

		/// <summary>
		/// String - For devices with Ethernet, the current negotiated or static gateway IP address. Valid if <see cref="bmdDeckLinkStatusEthernetLink"/> is <see cref="BMDEthernetLinkState.bmdEthernetLinkStateConnectedBound"/>. For other link states, or unassigned, this returns S_FALSE and an empty string.
		/// </summary>
		bmdDeckLinkStatusEthernetGatewayIPAddress = 1936025463,

		/// <summary>
		/// String - For devices with Ethernet, the current negotiated or static primary DNS IP address. Valid if <see cref="bmdDeckLinkStatusEthernetLink"/> is <see cref="BMDEthernetLinkState.bmdEthernetLinkStateConnectedBound"/>. For other link states, or unassigned, this returns S_FALSE and an empty string.
		/// </summary>
		bmdDeckLinkStatusEthernetPrimaryDNS = 1936027748,

		/// <summary>
		/// String - For devices with Ethernet, the current negotiated or static secondary DNS IP address. Valid if <see cref="bmdDeckLinkStatusEthernetLink"/> is <see cref="BMDEthernetLinkState.bmdEthernetLinkStateConnectedBound"/>. For other link states, or unassigned, this returns S_FALSE and an empty string.
		/// </summary>
		bmdDeckLinkStatusEthernetSecondaryDNS = 1936028516,

		/// <summary>
		/// String - For devices with Ethernet, the current negotiated PTP grandmaster clock identity. If no PTP lock then this returns S_FALSE and an empty string.
		/// </summary>
		bmdDeckLinkStatusEthernetPTPGrandmasterIdentity = 1936746852,

		/// <summary>
		/// String - For devices with Ethernet, the video output destination address.
		/// </summary>
		bmdDeckLinkStatusEthernetVideoOutputAddress = 1936679286,

		/// <summary>
		/// String - For devices with Ethernet, the audio output destination address.
		/// </summary>
		bmdDeckLinkStatusEthernetAudioOutputAddress = 1936679265,

		/// <summary>
		/// String - For devices with Ethernet, the ancillary output destination address.
		/// </summary>
		bmdDeckLinkStatusEthernetAncillaryOutputAddress = 1936679233,

		/// <summary>
		/// String - For devices with Ethernet, the input audio SDP channelorder as per ST 2110-30.
		/// </summary>
		bmdDeckLinkStatusEthernetAudioInputChannelOrder = 1935762287,

		/// <summary>
		/// Bytes - The received EDID of a connected HDMI sink device.
		/// </summary>
		bmdDeckLinkStatusReceivedEDID = 1701079396
	}
}