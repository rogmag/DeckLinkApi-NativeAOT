using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B8EAD569-B764-47F0-A73F-AE40DF6CBF10")]
	public partial interface IDeckLinkConfiguration_v7_6
	{
		void GetConfigurationValidator(out IDeckLinkConfiguration_v7_6 configObject);

		void WriteConfigurationToPreferences();

		void SetVideoOutputFormat(BMDVideoConnection_v7_6 videoOutputConnection);

		void IsVideoOutputActive(BMDVideoConnection_v7_6 videoOutputConnection, [MarshalAs(UnmanagedType.Bool)] out bool active);

		void SetAnalogVideoOutputFlags(BMDAnalogVideoFlags analogVideoFlags);

		void GetAnalogVideoOutputFlags(out BMDAnalogVideoFlags analogVideoFlags);

		void EnableFieldFlickerRemovalWhenPaused([MarshalAs(UnmanagedType.Bool)] bool Enable);

		void IsEnabledFieldFlickerRemovalWhenPaused([MarshalAs(UnmanagedType.Bool)] out bool enabled);

		void Set444And3GBpsVideoOutput([MarshalAs(UnmanagedType.Bool)] bool enable444VideoOutput, [MarshalAs(UnmanagedType.Bool)] bool enable3GbsOutput);

		void Get444And3GBpsVideoOutput([MarshalAs(UnmanagedType.Bool)] out bool is444VideoOutputEnabled, [MarshalAs(UnmanagedType.Bool)] out bool threeGbsOutputEnabled);

		void SetVideoOutputConversionMode(BMDVideoOutputConversionMode conversionMode);

		void GetVideoOutputConversionMode(out BMDVideoOutputConversionMode conversionMode);

		void Set_HD1080p24_to_HD1080i5994_Conversion([MarshalAs(UnmanagedType.Bool)] bool Enable);

		void Get_HD1080p24_to_HD1080i5994_Conversion([MarshalAs(UnmanagedType.Bool)] out bool enabled);

		void SetVideoInputFormat(BMDVideoConnection_v7_6 videoInputFormat);

		void GetVideoInputFormat(out BMDVideoConnection_v7_6 videoInputFormat);

		void SetAnalogVideoInputFlags(BMDAnalogVideoFlags analogVideoFlags);

		void GetAnalogVideoInputFlags(out BMDAnalogVideoFlags analogVideoFlags);

		void SetVideoInputConversionMode(BMDVideoInputConversionMode conversionMode);

		void GetVideoInputConversionMode(out BMDVideoInputConversionMode conversionMode);

		void SetBlackVideoOutputDuringCapture([MarshalAs(UnmanagedType.Bool)] bool blackOutInCapture);

		void GetBlackVideoOutputDuringCapture([MarshalAs(UnmanagedType.Bool)] out bool blackOutInCapture);

		void Set32PulldownSequenceInitialTimecodeFrame(uint aFrameTimecode);

		void Get32PulldownSequenceInitialTimecodeFrame(out uint aFrameTimecode);

		void SetVancSourceLineMapping(uint activeLine1VANCsource, uint activeLine2VANCsource, uint activeLine3VANCsource);

		void GetVancSourceLineMapping(out uint activeLine1VANCsource, out uint activeLine2VANCsource, out uint activeLine3VANCsource);

		void SetAudioInputFormat(BMDAudioConnection_v10_2 audioInputFormat);

		void GetAudioInputFormat(out BMDAudioConnection_v10_2 audioInputFormat);
	}
}