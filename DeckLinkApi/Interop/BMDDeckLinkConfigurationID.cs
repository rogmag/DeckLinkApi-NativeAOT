using System.Runtime.Intrinsics.X86;

namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckLinkConfigurationID enumerates the set of configuration settings of a DeckLink device which may be queried or set (see <see cref="IDeckLinkConfiguration"/> Interface for details).
	/// </summary>
	public enum BMDDeckLinkConfigurationID
	{
		/// <summary>
		/// Flag - If set, output 1080 or 2K progressive modes as PsF.
		/// </summary>
		bmdDeckLinkConfigOutput1080pAsPsF = 1885761650,

		/// <summary>
		/// Flag - If set, capture 1080 or 2K progressive modes as PsF.
		/// </summary>
		bmdDeckLinkConfigCapture1080pAsPsF = 1667657842,

		/// <summary>
		/// Int - The 3D packing format setting. See <see cref="BMDVideo3DPackingFormat"/> for more details.
		/// </summary>
		bmdDeckLinkConfigHDMI3DPackingFormat = 862220390,

		/// <summary>
		/// Flag - If set true the analog audio levels are set to maximum gain on audio input and maximum attenuation on audio output. If set false the selected analog input and output gain levels are used.
		/// </summary>
		bmdDeckLinkConfigAnalogAudioConsumerLevels = 1633772396,

		/// <summary>
		/// Flag - Sets field flicker removal when paused functionality. True if enabled.
		/// </summary>
		bmdDeckLinkConfigFieldFlickerRemoval = 1717855858,

		/// <summary>
		/// Flag - True if HD 1080p24 to HD 1080i5994 conversion is enabled.
		/// </summary>
		bmdDeckLinkConfigHD1080p24ToHD1080i5994Conversion = 1953445177,

		/// <summary>
		/// Flag - True if 444 video output is enabled.
		/// </summary>
		bmdDeckLinkConfig444SDIVideoOutput = 875836527,

		/// <summary>
		/// Flag - True if black output during capture is enabled. This feature is only supported on legacy DeckLink devices.
		/// </summary>
		bmdDeckLinkConfigBlackVideoOutputDuringCapture = 1651928931,

		/// <summary>
		/// Flag - Reduces output latency on some older products. On newer products, this option will have no effect.
		/// </summary>
		bmdDeckLinkConfigLowLatencyVideoOutput = 1819047535,

		/// <summary>
		/// Int - Adjust genlock timing pixel offset. If the device supports wide genlock offset adjustment (see <see cref="BMDDeckLinkAttributeID.BMDDeckLinkSupportsFullFrameReferenceInputTimingOffset"/> attribute) then the supported range is between +/half the count of total pixels in the video frame. Otherwise the supported range is +/511. 
		/// </summary>
		bmdDeckLinkConfigReferenceInputTimingOffset = 1735159668,

		/// <summary>
		/// Int - The capture pass through mode specifies how the monitoring video output is generated while capture is in progress. See <see cref="BMDDeckLinkCapturePassthroughMode"/> for the available modes.
		/// </summary>
		bmdDeckLinkConfigCapturePassThroughMode = 1668314221,

		/// <summary>
		/// Int - The output video connection. See <see cref="BMDVideoConnection"/> for more details. Enabling video output on one connection will enable output on other available output connections which are compatible. The status of active output connection can be queried with this setting. Multiple video output connections can be active simultaneously. When querying the enabled video outputs, the returned integer is a bitmask of BMDVideoConnection where the corresponding bit is set for each active output connection. When setting active video outputs, only one video output connection can be enabled per call, ie, the integer argument must refer to a single video output connection. Enabling multiple output connections simultaneously requires multiple calls.
		/// </summary>
		bmdDeckLinkConfigVideoOutputConnection = 1987011438,

		/// <summary>
		/// Int - Settings for video output conversion. The possible output modes are enumerated by <see cref="BMDVideoOutputConversionMode"/>.
		/// </summary>
		bmdDeckLinkConfigVideoOutputConversionMode = 1987011437,

		/// <summary>
		/// Int - Settings for analog video output. <see cref="BMDAnalogVideoFlags"/> enumerates the available analog video flags.
		/// </summary>
		bmdDeckLinkConfigAnalogVideoOutputFlags = 1635151718,

		/// <summary>
		/// Int - The input video connection. Only one video input connection can be active at a time. See <see cref="BMDVideoConnection"/> for more details.
		/// </summary>
		bmdDeckLinkConfigVideoInputConnection = 1986618222,

		/// <summary>
		/// Int - The analog video input flags. See <see cref="BMDAnalogVideoFlags"/> for more details.
		/// </summary>
		bmdDeckLinkConfigAnalogVideoInputFlags = 1635150182,

		/// <summary>
		/// Int - The video input conversion mode. See <see cref="BMDVideoInputConversionMode"/> for more details.
		/// </summary>
		bmdDeckLinkConfigVideoInputConversionMode = 1986618221,

		/// <summary>
		/// Int - The A-frame setting for NTSC 23.98, which is used to appropriately adjust the timecode. The frame setting range is between 0 and 29.
		/// </summary>
		bmdDeckLinkConfig32PulldownSequenceInitialTimecodeFrame = 1885628774,

		/// <summary>
		/// Int - The configuration of up to three lines of VANC to be transferred to or from the active picture on capture or output. The acceptable range is between 0 and 30. A value of 0 will disable the capture of that line.
		/// </summary>
		bmdDeckLinkConfigVANCSourceLine1Mapping = 1987275825,

		/// <summary>
		/// Int - The acceptable range is between 0 and 30. A value of 0 will disable the capture of the line.
		/// </summary>
		bmdDeckLinkConfigVANCSourceLine2Mapping = 1987275826,

		/// <summary>
		/// Int - The acceptable range is between 0 and 30. A value of 0 will disable the capture of the line.
		/// </summary>
		bmdDeckLinkConfigVANCSourceLine3Mapping = 1987275827,

		/// <summary>
		/// Int - The configuration of the audio input connection. See <see cref="BMDAudioConnection"/> for more details.
		/// </summary>
		bmdDeckLinkConfigAudioInputConnection = 1634296686,

		/// <summary>
		/// Float - The analog audio input scale in dB.
		/// <para>The supported range is between -12.00 and 12.00.</para>
		/// </summary>
		bmdDeckLinkConfigAnalogAudioInputScaleChannel1 = 1634300721,

		/// <summary>
		/// Float - The analog audio input scale in dB.
		/// <para>The supported range is between -12.00 and 12.00.</para>
		/// </summary>
		bmdDeckLinkConfigAnalogAudioInputScaleChannel2 = 1634300722,

		/// <summary>
		/// Float - The analog audio input scale in dB.
		/// <para>The supported range is between -12.00 and 12.00.</para>
		/// </summary>
		bmdDeckLinkConfigAnalogAudioInputScaleChannel3 = 1634300723,

		/// <summary>
		/// Float - The analog audio input scale in dB. The supported range is between -12.00 and 12.00.
		/// </summary>
		bmdDeckLinkConfigAnalogAudioInputScaleChannel4 = 1634300724,

		/// <summary>
		/// Float - The digital audio input scale in dB. The acceptable range is between -12.00 and 12.00.
		/// </summary>
		bmdDeckLinkConfigDigitalAudioInputScale = 1684105587,

		/// <summary>
		/// Int - The AES / analog audio output selection switch. This is applicable only to cards that support switchable analog audio outputs.
		/// </summary>
		bmdDeckLinkConfigAudioOutputAESAnalogSwitch = 1634689377,

		/// <summary>
		/// Float - The analog audio output scale in dB. The acceptable range is between -12.00 and 12.00.
		/// </summary>
		bmdDeckLinkConfigAnalogAudioOutputScaleChannel1 = 1634693937,
		
		/// <summary>
		/// Float - The analog audio output scale in dB. The acceptable range is between -12.00 and 12.00.
		/// </summary>
		bmdDeckLinkConfigAnalogAudioOutputScaleChannel2 = 1634693938,

		/// <summary>
		/// Float - The analog audio output scale in dB. The acceptable range is between -12.00 and 12.00.
		/// </summary>
		bmdDeckLinkConfigAnalogAudioOutputScaleChannel3 = 1634693939,

		/// <summary>
		/// Float - The analog audio output scale in dB. The acceptable range is between -12.00 and 12.00.
		/// </summary>
		bmdDeckLinkConfigAnalogAudioOutputScaleChannel4 = 1634693940,

		/// <summary>
		/// Float - The digital audio output scale in dB. The acceptable range is between -12.00 and 12.00.
		/// </summary>
		bmdDeckLinkConfigDigitalAudioOutputScale = 1684107123,

		/// <summary>
		/// Flag - Enable down conversion on all analog outputs.
		/// </summary>
		bmdDeckLinkConfigDownConversionOnAllAnalogOutput = 1667326319,

		/// <summary>
		/// Flag - Enable SMPTE level A output.
		/// </summary>
		bmdDeckLinkConfigSMPTELevelAOutput = 1936553057,

		/// <summary>
		/// String - Set the label of the device. This can only be set if the device has a persistent ID.
		/// <para>This information will be saved onto the local machine but not onto the device.</para>
		/// <para>This information will also appear in Product Notes section of the Desktop Video Utility.</para>
		/// </summary>
		bmdDeckLinkConfigDeviceInformationLabel = 1684630625,

		/// <summary>
		/// String - Set the serial number of the device. This can only be set if the device has a persistent ID.
		/// <para>This information will be saved onto the local machine but not onto the device.</para>
		/// <para>This information will also appear in Product Notes section of the Desktop Video Utility.</para>
		/// </summary>
		bmdDeckLinkConfigDeviceInformationSerialNumber = 1684632430,

		/// <summary>
		/// String - Set the device’s seller name. This can only be set if the device has a persistent ID.
		/// <para>This information will be saved onto the local machine but not onto the device.</para>
		/// <para>This information will also appear in Product Notes section of the Desktop Video Utility.</para>
		/// </summary>
		bmdDeckLinkConfigDeviceInformationCompany = 1684628335,

		/// <summary>
		/// String - Set the device’s seller phone number. This can only be set if the device has a persistent ID.
		/// <para>This information will be saved onto the local machine but not onto the device.</para>
		/// <para>This information will also appear in Product Notes section of the Desktop Video Utility.</para>
		/// </summary>
		bmdDeckLinkConfigDeviceInformationPhone = 1684631656,

		/// <summary>
		/// String - Set the device’s seller email address. This can only be set if the device has a persistent ID.
		/// <para>This information will be saved onto the local machine but not onto the device.</para>
		/// <para>This information will also appear in Product Notes section of the Desktop Video Utility.</para>
		/// </summary>
		bmdDeckLinkConfigDeviceInformationEmail = 1684628845,

		/// <summary>
		/// String - Set the device’s purchase date. This can only be set if the device has a persistent ID.
		/// <para>This information will be saved onto the local machine but not onto the device.</para>
		/// <para>This information will also appear in Product Notes section of the Desktop Video Utility.</para>
		/// </summary>
		bmdDeckLinkConfigDeviceInformationDate = 1684628577,

		/// <summary>
		/// Int - Video output idle control. See <see cref="BMDIdleVideoOutputOperation"/> for more details.
		/// </summary>
		bmdDeckLinkConfigVideoOutputIdleOperation = 1987012975,

		/// <summary>
		/// Flag - If set to true, the Rx and Tx lines of the RS422 port on the DeckLink device will be swapped.
		/// </summary>
		bmdDeckLinkConfigSwapSerialRxTx = 1936945780,

		/// <summary>
		/// Int - The state of the bypass feature. This parameter can be set to a value of -1 for normal operation or zero to bypass the card. A timeout of up to 65 seconds may be specified in milliseconds. If the timeout is reached without the parameter being reset, the card will be bypassed automatically. The actual timeout will be approximately the time requested.
		/// </summary>
		bmdDeckLinkConfigBypass = 1652125811,

		/// <summary>
		/// Int - Clock frequency adjustment for fine output control. The acceptable range is from -127 to 127 PPM (Parts Per Million).
		/// </summary>
		bmdDeckLinkConfigClockTimingAdjustment = 1668571492,

		/// <summary>
		/// Flag - The video input connector scanning on the H.264 Pro Recorder. True if enabled.
		/// </summary>
		bmdDeckLinkConfigVideoInputScanning = 1986622307,

		/// <summary>
		/// Flag - Use the timecode from the LTC input rather than from the SDI stream.
		/// </summary>
		bmdDeckLinkConfigUseDedicatedLTCInput = 1684829283,

		/// <summary>
		/// Int - The default video output mode. The <see cref="bmdDeckLinkConfigDefaultVideoOutputModeFlags"/> must be set for 3D video modes before using this setting. See <see cref="BMDDisplayMode"/> for more details.
		/// </summary>
		bmdDeckLinkConfigDefaultVideoOutputMode = 1685483373,

		/// <summary>
		/// Int - The default video output mode 2D or 3D flag setting. See <see cref="BMDVideoOutputFlags.bmdVideoOutputFlagDefault"/> and <see cref="BMDVideoOutputFlags.bmdVideoOutputDualStream3D"/> for more details.
		/// </summary>
		bmdDeckLinkConfigDefaultVideoOutputModeFlags = 1685483366,

		/// <summary>
		/// Int - The SDI link configuration for a single output video stream. See BMDLinkConfiguration for more information.
		/// </summary>
		bmdDeckLinkConfigSDIOutputLinkConfiguration = 1936682083,

		/// <summary>
		/// Float - The component video output luma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoOutputComponentLumaGain = 1868786791,

		/// <summary>
		/// Float - The component video output chroma blue gain in dB.The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoOutputComponentChromaBlueGain = 1868784482,

		/// <summary>
		/// Float - The component video output chroma red gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoOutputComponentChromaRedGain = 1868784498,

		/// <summary>
		/// Float - The composite video output luma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoOutputCompositeLumaGain = 1869180007,

		/// <summary>
		/// Float - The composite video output chroma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoOutputCompositeChromaGain = 1869177703,

		/// <summary>
		/// Float - The s-video output luma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoOutputSVideoLumaGain = 1869835367,

		/// <summary>
		/// Float - The s-video output chroma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoOutputSVideoChromaGain = 1869833063,

		/// <summary>
		/// Float - The component video input luma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoInputComponentLumaGain = 1768123495,

		/// <summary>
		/// Float - The component video input chroma blue gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoInputComponentChromaBlueGain = 1768121186,

		/// <summary>
		/// Float - The component video input chroma red gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoInputComponentChromaRedGain = 1768121202,

		/// <summary>
		/// Float - The composite video input luma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoInputCompositeLumaGain = 1768516711,

		/// <summary>
		/// Float - The composite video input chroma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoInputCompositeChromaGain = 1768514407,

		/// <summary>
		/// Float - The s-video input luma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoInputSVideoLumaGain = 1769172071,

		/// <summary>
		/// Float - The s-video input chroma gain in dB. The accepted range can be determined by using the <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputGainMaximum"/> attributes with <see cref="IDeckLinkProfileAttributes"/> interface.
		/// </summary>
		bmdDeckLinkConfigVideoInputSVideoChromaGain = 1769169767,

		/// <summary>
		/// Int - Set the source of VANC and timecode for output signal when internal keying is enabled (See <see cref="BMDInternalKeyingAncillaryDataSource"/>).
		/// </summary>
		bmdDeckLinkConfigInternalKeyingAncillaryDataSource = 1768644979,

		/// <summary>
		/// Flag - If set to true, the Microphone input will provide +48V Phantom Power.
		/// </summary>
		bmdDeckLinkConfigMicrophonePhantomPower = 1836083312,

		/// <summary>
		/// Float - The microphone input gain in dB. The acceptable range can be determined via <see cref="BMDDeckLinkAttributeID.BMDDeckLinkMicrophoneInputGainMinimum"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkMicrophoneInputGainMaximum"/>. If set to 0dB, the microphone input will be muted.
		/// </summary>
		bmdDeckLinkConfigMicrophoneInputGain = 1835623271,

		/// <summary>
		/// Float - Set the headphone volume, acceptable range is between 0.0 (mute), to 1.0 (full volume)
		/// </summary>
		bmdDeckLinkConfigHeadphoneVolume = 1752592236,

		/// <summary>
		/// Int - The active RS422 deck control connection. See <see cref="BMDDeckControlConnection"/> for more information.
		/// </summary>
		bmdDeckLinkConfigDeckControlConnection = 1684235119,

		/// <summary>
		/// Flag - If set to true, the device will capture two genlocked SDI streams with matching video modes as a 3D stream.
		/// </summary>
		bmdDeckLinkConfigSDIInput3DPayloadOverride = 862217331,

		/// <summary>
		/// Flag - If set to true, device will output Rec.709 frames in Rec.2020 colorspace (See <see cref="BMDColorspace"/>)
		/// </summary>
		bmdDeckLinkConfigRec2020Output = 1919247154,

		/// <summary>
		/// Flag - If set to true, Quad-link SDI is output in Square Division Quad Split mode.
		/// </summary>
		bmdDeckLinkConfigQuadLinkSDIVideoOutputSquareDivisionSplit = 1396986195,

		/// <summary>
		/// Int - Any 32-bit number to identify a capture group. All devices supporting synchronized capture with the same group number are started and stopped together.
		/// </summary>
		bmdDeckLinkConfigCaptureGroup = 1668310898,

		/// <summary>
		/// Int - Any 32-bit number to identify a playback group. All devices supporting synchronized playback with the same group number are started and stopped together.
		/// </summary>
		bmdDeckLinkConfigPlaybackGroup = 1886152562,

		/// <summary>
		/// Int - Set the HDMI timecode packing format for the video output stream (See BMDHDMITimecodePacking).
		/// </summary>
		bmdDeckLinkConfigHDMITimecodePacking = 1752461419,

		/// <summary>
		/// Flag - If set, HDMI audio input channels 3 and 4 are swapped to support 5.1 audio channel ordering
		/// </summary>
		bmdDeckLinkConfigSwapHDMICh3AndCh4OnInput = 1751724852,

		/// <summary>
		/// Flag - If set, HDMI audio output channels 3 and 4 are swapped to support 5.1 audio channel ordering
		/// </summary>
		bmdDeckLinkConfigSwapHDMICh3AndCh4OnOutput = 1752118068,

		/// <summary>
		/// Int - The reference output video mode for DeckLink devices where reference output does not follow SDI output (see BMDDisplayMode). Supports interlaced/progressive modes up to 1080p30.
		/// </summary>
		bmdDeckLinkConfigReferenceOutputMode = 1735151469,

		/// <summary>
		/// Flag - For devices with Ethernet. The local interface assigns a local IP address via DHCP, otherwise static.
		/// </summary>
		bmdDeckLinkConfigEthernetUseDHCP = 1145586512,

		/// <summary>
		/// Flag - For devices that use PTP. Prevents the device from negotiating to become a PTP leader. False by default.
		/// </summary>
		bmdDeckLinkConfigEthernetPTPFollowerOnly = 1347702886,

		/// <summary>
		/// Flag - For devices that use PTP. Sets if UDP Encapsulation will be used, otherwise Ethernet Encapsulation will be used.
		/// </summary>
		bmdDeckLinkConfigEthernetPTPUseUDPEncapsulation = 1347702869,

		/// <summary>
		/// Int - For devices that use PTP. Sets PTP’s Priority1 field. The supported range is 0 to 255 with default value 128.
		/// </summary>
		bmdDeckLinkConfigEthernetPTPPriority1 = 1347702833,

		/// <summary>
		/// Int - For devices that use PTP. Sets PTP’s Priority2 field. The supported range is 0 to 255 with default value 128
		/// </summary>
		bmdDeckLinkConfigEthernetPTPPriority2 = 1347702834,

		/// <summary>
		/// Int - For devices that use PTP. Sets PTP’s Domain field. The supported range is 0 to 127 with default value 127.
		/// </summary>
		bmdDeckLinkConfigEthernetPTPDomain = 1347702852,

		/// <summary>
		/// String - For devices with Ethernet. Manual local IP address. Used when <see cref="bmdDeckLinkConfigEthernetUseDHCP"/> is false.
		/// </summary>
		bmdDeckLinkConfigEthernetStaticLocalIPAddress = 1853057392,

		/// <summary>
		/// String - For devices with Ethernet. Manual subnet mask. Used when <see cref="bmdDeckLinkConfigEthernetUseDHCP"/> is false.
		/// </summary>
		bmdDeckLinkConfigEthernetStaticSubnetMask = 1853059949,

		/// <summary>
		/// String - For devices with Ethernet. Manual gateway IP address. Used when <see cref="bmdDeckLinkConfigEthernetUseDHCP"/> is false.
		/// </summary>
		bmdDeckLinkConfigEthernetStaticGatewayIPAddress = 1853056887,

		/// <summary>
		/// String - For devices with Ethernet. Manual primary DNS. Used when <see cref="bmdDeckLinkConfigEthernetUseDHCP"/> is false.
		/// </summary>
		bmdDeckLinkConfigEthernetStaticPrimaryDNS = 1853059172,

		/// <summary>
		/// String - For devices with Ethernet. Manual secondary DNS. Used when <see cref="bmdDeckLinkConfigEthernetUseDHCP"/> is false.
		/// </summary>
		bmdDeckLinkConfigEthernetStaticSecondaryDNS = 1853059940,

		/// <summary>
		/// String - For devices with Ethernet. Set the output address for the video flow. Omission of either dotted-decimal IP or colon-port represents auto for either, or empty string for both. Get the actual used address from <see cref="BMDDeckLinkStatusID.bmdDeckLinkStatusEthernetVideoOutputAddress"/> status item.
		/// </summary>
		bmdDeckLinkConfigEthernetVideoOutputAddress = 1852793206,

		/// <summary>
		/// String - For devices with Ethernet. Set the output address for the audio flow. Omission of either dotted-decimal IP or colon-port represents auto for either, or empty string for both. Get the actual used address from <see cref="BMDDeckLinkStatusID.bmdDeckLinkStatusEthernetAudioOutputAddress"/> status item.
		/// </summary>
		bmdDeckLinkConfigEthernetAudioOutputAddress = 1852793185,

		/// <summary>
		/// String - For devices with Ethernet. Set the output address for the ancillary flow. Omission of either dotted-decimal IP or colon-port represents auto for either, or empty string for both. Get the actual used address from <see cref="BMDDeckLinkStatusID.bmdDeckLinkStatusEthernetAncillaryOutputAddress"/> status item.
		/// </summary>
		bmdDeckLinkConfigEthernetAncillaryOutputAddress = 1852793153,

		/// <summary>
		/// String - For devices with Ethernet. Sets the output audio SDP channel-order with the convention defined by ST 2110-30.
		/// </summary>
		bmdDeckLinkConfigEthernetAudioOutputChannelOrder = 1667326831,

		bmdDeckLinkConfigVideoOutputUsesInternalClock = 1987012963,

		bmdDeckLinkConfigForceFullRange = 1868981874,

		bmdDeckLinkConfigAdvancedVideoOutputConversionMode = 1634689901,

		bmdDeckLinkConfigAdvancedVideoOutputConversionAspect = 1634689889,

		bmdDeckLinkConfigDeviceActiveProfileID = 1684107369
	}
}