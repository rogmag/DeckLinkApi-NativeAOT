using System.Threading;

namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckLinkAttributeID enumerates a set of attributes of a DeckLink device which may be queried (see <see cref="IDeckLinkProfileAttributes"/> Interface for details).
	/// </summary>
	public enum BMDDeckLinkAttributeID
	{
		/// <summary>
		/// Int - The Profile ID for the current <see cref="IDeckLinkProfileAttributes"/>. See <see cref="BMDProfileID"/> for more information
		/// </summary>
		BMDDeckLinkProfileID = 1886546276,

		/// <summary>
		/// Flag - True if internal keying is supported on this device.
		/// </summary>
		BMDDeckLinkSupportsInternalKeying = 1801812329,

		/// <summary>
		/// Flag - True if external keying is supported on this device.
		/// </summary>
		BMDDeckLinkSupportsExternalKeying = 1801812325,

		/// <summary>
		/// String - The operating system name of the RS422 serial port on this device.
		/// <para>This allocated string must be freed by the caller when no longer required.</para>
		/// </summary>
		BMDDeckLinkSerialPortDeviceName = 1936486510,

		/// <summary>
		/// Int - The maximum number of audio channels embedded on digital connections supported by this device.
		/// </summary>
		BMDDeckLinkMaximumAudioChannels = 1835098984,

		/// <summary>
		/// Int - The maximum number of audio channels embedded on HDMI supported by this device.
		/// </summary>
		BMDDeckLinkMaximumHDMIAudioChannels = 1835557736,

		/// <summary>
		/// Int - The maximum number of input analog audio channels supported by this device.
		/// </summary>
		BMDDeckLinkMaximumAnalogAudioInputChannels = 1767990120,

		/// <summary>
		/// Int - The maximum number of output analog audio channels supported by this device.
		/// </summary>
		BMDDeckLinkMaximumAnalogAudioOutputChannels = 1633772392,

		/// <summary>
		/// Flag - True if input format detection is supported on this device.
		/// </summary>
		BMDDeckLinkSupportsInputFormatDetection = 1768842852,

		/// <summary>
		/// Flag - True if the DeckLink device has a genlock reference source input connector.
		/// </summary>
		BMDDeckLinkHasReferenceInput = 1752328558,

		/// <summary>
		/// Flag - True if device has a serial port.
		/// </summary>
		BMDDeckLinkHasSerialPort = 1752395892,

		/// <summary>
		/// Int - Some DeckLink hardware devices contain multiple independent sub-devices.
		/// <para>This attribute will be equal to one for most devices, or two or more on a card with multiple sub-devices (eg DeckLink Duo).</para>
		/// </summary>
		BMDDeckLinkNumberOfSubDevices = 1853055588,

		/// <summary>
		/// Int - Some DeckLink hardware devices contain multiple independent sub-devices.
		/// <para>This attribute indicates the index of the sub-device, starting from zero.</para>
		/// </summary>
		BMDDeckLinkSubDeviceIndex = 1937072745,

		/// <summary>
		/// Int - The video output connections supported by the hardware (see <see cref="BMDVideoConnection"/> for more details).
		/// <para>Multiple video output connections can be active simultaneously.</para>
		/// </summary>
		BMDDeckLinkVideoOutputConnections = 1987011438,

		/// <summary>
		/// Int - The audio output connections supported by the hardware (see <see cref="BMDAudioConnection"/> for more details).
		/// <para>Multiple audio output connections can be active simultaneously. Devices with one or more types of analog connection will have the <see cref="BMDAudioConnection.bmdAudioConnectionAnalog"/> flag set.</para>
		/// <para>Devices with individually selectable XLR/RCA connectors will additionally have the <see cref="BMDAudioConnection.bmdAudioConnectionAnalogXLR"/> and <see cref="BMDAudioConnection.bmdAudioConnectionAnalogRCA"/> flags set.</para>
		/// </summary>
		BMDDeckLinkAudioOutputConnections = 1634689902,

		/// <summary>
		/// Int - The video input connections supported by the hardware (see <see cref="BMDVideoConnection"/> for more details).
		/// </summary>
		BMDDeckLinkVideoInputConnections = 1986618222,

		/// <summary>
		/// Int - The audio input connections supported by the hardware (see <see cref="BMDAudioConnection"/> for more details).
		/// </summary>
		BMDDeckLinkAudioInputConnections = 1634296686,

		/// <summary>
		/// Flag - True if analog video output gain adjustment is supported on this device.
		/// </summary>
		BMDDeckLinkHasAnalogVideoOutputGain = 1635151719,

		/// <summary>
		/// Flag - True if only the overall video output gain can be adjusted. In this case, only the luma gain can be accessed with the <see cref="IDeckLinkConfiguration"/> interface, and it controls all three gains(luma, chroma blue and chroma red).
		/// </summary>
		BMDDeckLinkCanOnlyAdjustOverallVideoOutputGain = 1870032743,

		/// <summary>
		/// Flag - True if there is an antialising filter on the analog video input of this device.
		/// </summary>
		BMDDeckLinkHasVideoInputAntiAliasingFilter = 1633773164,

		/// <summary>
		/// Flag - True if this device has loop-through bypass function.
		/// </summary>
		BMDDeckLinkHasBypass = 1652125811,

		/// <summary>
		/// Float - The minimum video input gain in dB for this device.
		/// </summary>
		BMDDeckLinkVideoInputGainMinimum = 1986619245,

		/// <summary>
		/// Float - The maximum video input gain in dB for this device.
		/// </summary>
		BMDDeckLinkVideoInputGainMaximum = 1986619256,

		/// <summary>
		/// Float - The minimum video output gain in dB for this device.
		/// </summary>
		BMDDeckLinkVideoOutputGainMinimum = 1987012461,

		/// <summary>
		/// Float - The maximum video output gain in dB for this device.
		/// </summary>
		BMDDeckLinkVideoOutputGainMaximum = 1987012472,

		/// <summary>
		/// Int - The capture and/or playback capability of the device. (See <see cref="BMDVideoIOSupport"/> for more information)
		/// </summary>
		BMDDeckLinkVideoIOSupport = 1986621299,

		/// <summary>
		/// Flag - True if this device supports clock timing adjustment (see <see cref="BMDDeckLinkConfigurationID.bmdDeckLinkConfigClockTimingAdjustment"/>). 
		/// </summary>
		BMDDeckLinkSupportsClockTimingAdjustment = 1668571492,

		/// <summary>
		/// Int - A device specific 32 bit unique identifier.
		/// </summary>
		BMDDeckLinkPersistentID = 1885694308,

		/// <summary>
		/// Int - A 32 bit identifier used to group sub-devices belonging to the same DeckLink hardware device. Supported if the subdevice supports <see cref="BMDDeckLinkPersistentID"/>
		/// </summary>
		BMDDeckLinkDeviceGroupID = 1684498788,

		/// <summary>
		/// Int - An identifier for DeckLink devices. This feature is supported on a given device if S_OK is returned. The ID will persist across reboots assuming that devices are not disconnected or moved to a different slot.
		/// </summary>
		BMDDeckLinkTopologicalID = 1953458532,

		/// <summary>
		/// Flag - True if the DeckLink device supports genlock offset adjustment wider than +/511 pixels (see <see cref="BMDDeckLinkConfigurationID.bmdDeckLinkConfigReferenceInputTimingOffset"/> for more information).
		/// </summary>
		BMDDeckLinkSupportsFullFrameReferenceInputTimingOffset = 1718774126,

		/// <summary>
		/// Flag - True if SMPTE Level A output is supported on this device.
		/// </summary>
		BMDDeckLinkSupportsSMPTELevelAOutput = 1819700321,

		/// <summary>
		/// Flag - True if SDI dual-link is supported on this device. 
		/// </summary>
		BMDDeckLinkSupportsDualLinkSDI = 1935961203,

		/// <summary>
		/// Flag - True if SDI quad-link is supported on this device.
		/// </summary>
		BMDDeckLinkSupportsQuadLinkSDI = 1936813171,

		/// <summary>
		/// Flag - True if this device supports idle output. (see <see cref="BMDIdleVideoOutputOperation"/> for idle output options).
		/// </summary>
		BMDDeckLinkSupportsIdleOutput = 1768189813,

		/// <summary>
		/// Int - The deck control connections supported by the hardware (see <see cref="BMDDeckControlConnection"/> for more information).
		/// </summary>
		BMDDeckLinkDeckControlConnections = 1684235118,

		/// <summary>
		/// Float - The minimum microphone input gain in dB for this device.
		/// </summary>
		BMDDeckLinkMicrophoneInputGainMinimum = 1835624301,

		/// <summary>
		/// Float - The maximum microphone input gain in dB for this device.
		/// </summary>
		BMDDeckLinkMicrophoneInputGainMaximum = 1835624312,

		/// <summary>
		/// Int - The active device interface (see <see cref="BMDDeviceInterface"/> for more information)
		/// </summary>
		BMDDeckLinkDeviceInterface = 1684174195,

		/// <summary>
		/// Flag - True if this device has a dedicated LTC input.
		/// </summary>
		BMDDeckLinkHasLTCTimecodeInput = 1751938147,

		/// <summary>
		/// String - Hardware vendor name. Returned as a static string which must not be freed by the caller.
		/// </summary>
		BMDDeckLinkVendorName = 1986946162,

		/// <summary>
		/// String - The device’s display name. See <see cref="IDeckLink.GetDisplayName"/>.
		/// </summary>
		BMDDeckLinkDisplayName = 1685287022,

		/// <summary>
		/// String - Hardware Model Name. See <see cref="IDeckLink.GetModelName"/>.
		/// </summary>
		BMDDeckLinkModelName = 1835297902,

		/// <summary>
		/// Flag - True if the device supports transport of HDR metadata.
		/// </summary>
		BMDDeckLinkSupportsHDRMetadata = 1751413357,

		/// <summary>
		/// Int - Number of input audio RCA channels supported by this device.
		/// </summary>
		BMDDeckLinkAudioInputRCAChannelCount = 1634300515,

		/// <summary>
		/// Int - Number of input audio XLR channels supported by this device.
		/// </summary>
		BMDDeckLinkAudioInputXLRChannelCount = 1634302051,

		/// <summary>
		/// Int - Number of output audio RCA channels supported by this device.
		/// </summary>
		BMDDeckLinkAudioOutputRCAChannelCount = 1634693731,

		/// <summary>
		/// Int - Number of output audio XLR channels supported by this device.
		/// </summary>
		BMDDeckLinkAudioOutputXLRChannelCount = 1634695267,

		/// <summary>
		/// String - String representing a unique identifier for the device. The format of the string is “RevisionID:PersistentID:TopologicalID”.
		/// </summary>
		BMDDeckLinkDeviceHandle = 1684371048,

		/// <summary>
		/// Flag - True if the device supports transport of Colorspace metadata. See <see cref="BMDDeckLinkFrameMetadataID.bmdDeckLinkFrameMetadataColorspace"/> and <see cref="BMDColorspace"/> for more information.
		/// </summary>
		BMDDeckLinkSupportsColorspaceMetadata = 1668113780,

		/// <summary>
		/// Int - The duplex mode for the corresponding profile. See <see cref="BMDDuplexMode"/> for more information.
		/// </summary>
		BMDDeckLinkDuplex = 1685418104,

		/// <summary>
		/// Flag - True if High Frame Rate Timecode (HFRTC) is supported by the device.
		/// </summary>
		BMDDeckLinkSupportsHighFrameRateTimecode = 1212568148,

		/// <summary>
		/// Flag - True if the device can be grouped with other input devices for synchronized capture.
		/// </summary>
		BMDDeckLinkSupportsSynchronizeToCaptureGroup = 1937007463,

		/// <summary>
		/// Flag - True if the device can be grouped with other output devices for synchronized playback.
		/// </summary>
		BMDDeckLinkSupportsSynchronizeToPlaybackGroup = 1937010791,

		/// <summary>
		/// Flag - True if HDMI LTC timecode is supported by the device.
		/// </summary>
		BMDDeckLinkSupportsHDMITimecode = 1752459629,

		/// <summary>
		/// Flag -  True if the device supports VANC only when the active picture is also 10-bit YUV. See <see cref="BMDAncillaryPacketFormat"/> for more information.
		/// </summary>
		BMDDeckLinkVANCRequires10BitYUVVideoFrames = 1986621273,

		/// <summary>
		/// Int - The minimum number of preroll video frames required by the device for scheduled playback
		/// </summary>
		BMDDeckLinkMinimumPrerollFrames = 1836085862,

		/// <summary>
		/// Int - The high dynamic range transfer functions supported by this device. See <see cref="BMDDynamicRange"/> for more information.
		/// </summary>
		BMDDeckLinkSupportedDynamicRange = 1937073266,

		/// <summary>
		/// Flag - True if the DeckLink device supports PsF mode detection on capture.
		/// </summary>
		BMDDeckLinkSupportsAutoSwitchingPPsFOnInput = 1634759526,

		/// <summary>
		/// String - For devices with Ethernet, the local MAC address.
		/// </summary>
		BMDDeckLinkEthernetMACAddress = 1699561795,

		/// <summary>
		/// Flag - True if the device has Monitor Out capability.
		/// </summary>
		BMDDeckLinkHasMonitorOut = 1718447983,

		/// <summary>
		/// Int - The mezzanine board currently attached to this device. See <see cref="BMDMezzanineType"/> for more information.
		/// </summary>
		BMDDeckLinkMezzanineType = 1835367028,

		BMDDeckLinkHasAllAnalogOutputConnectionsActive = 1633775457,

		BMDDeckLinkSupportsAudioMixing = 1935764856,

		BMDDeckLinkSupportsAdvancedVideoOutputConversions = 1635151715,

		BMDDeckLinkSupportsHardwareLetterbox = 1752656994,

		BMDDeckLinkSupportsHardwarePillarbox = 1752658018,

		BMDDeckLinkSupportsOutputConversion = 1936679790,

		BMDDeckLinkLowProfile = 1819244400,

		BMDDeckLinkSDIAlwaysClamp12BitRGB = 1633890610,

		BMDDeckLinkDeviceSerialIsLoopedBack = 1819242352,

		BMDDeckLinkParentPCIBridgeBusNumber = 1886413422
	}
}