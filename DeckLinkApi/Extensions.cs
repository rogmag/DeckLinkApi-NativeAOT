using DeckLinkApi.Interop;
using System.Runtime.InteropServices;

namespace DeckLinkApi
{
	// Some optional extensions, mostly for returning values instead of passing them as out parameters

	public static class Extensions
	{
		#region IBMDStreamingAudioPacket

		public static IntPtr GetBytes(this IBMDStreamingAudioPacket audioPacket)
		{
			audioPacket.GetBytes(out IntPtr buffer);

			return buffer;
		}

		public static ReadOnlySpan<byte> GetBytesSpan(this IBMDStreamingAudioPacket audioPacket)
		{
			audioPacket.GetBytes(out IntPtr buffer);

			unsafe
			{
				return new ReadOnlySpan<byte>(buffer.ToPointer(), audioPacket.GetPayloadSize());
			}
		}

		public static ulong GetPlayTime(this IBMDStreamingAudioPacket audioPacket, ulong requestedTimeScale)
		{
			audioPacket.GetPlayTime(requestedTimeScale, out ulong playTime);

			return playTime;
		}

		public static uint GetPacketIndex(this IBMDStreamingAudioPacket audioPacket)
		{
			audioPacket.GetPacketIndex(out uint packetIndex);

			return packetIndex;
		}

		#endregion

		#region IBMDStreamingDeviceInput

		public static bool DoesSupportVideoInputMode(this IBMDStreamingDeviceInput deviceInput, BMDDisplayMode inputMode)
		{
			deviceInput.DoesSupportVideoInputMode(inputMode, out bool result);

			return result;
		}

		public static IDeckLinkDisplayModeIterator GetVideoInputModeIterator(this IBMDStreamingDeviceInput deviceInput)
		{
			deviceInput.GetVideoInputModeIterator(out IDeckLinkDisplayModeIterator iterator);

			return iterator;
		}

		public static BMDDisplayMode SetVideoInputMode(this IBMDStreamingDeviceInput deviceInput)
		{
			deviceInput.GetCurrentDetectedVideoInputMode(out BMDDisplayMode detectedMode);

			return detectedMode;
		}

		public static IBMDStreamingVideoEncodingMode GetVideoEncodingMode(this IBMDStreamingDeviceInput deviceInput)
		{
			deviceInput.GetVideoEncodingMode(out IBMDStreamingVideoEncodingMode encodingMode);

			return encodingMode;
		}

		public static IBMDStreamingVideoEncodingModePresetIterator GetVideoEncodingModePresetIterator(this IBMDStreamingDeviceInput deviceInput, BMDDisplayMode inputMode)
		{
			deviceInput.GetVideoEncodingModePresetIterator(inputMode, out IBMDStreamingVideoEncodingModePresetIterator iterator);

			return iterator;
		}

		public static (BMDStreamingEncodingSupport result, IBMDStreamingVideoEncodingMode changedEncodingMode) DoesSupportVideoEncodingMode(this IBMDStreamingDeviceInput deviceInput, BMDDisplayMode inputMode, IBMDStreamingVideoEncodingMode encodingMode)
		{
			deviceInput.DoesSupportVideoEncodingMode(inputMode, encodingMode, out BMDStreamingEncodingSupport result, out IBMDStreamingVideoEncodingMode changedEncodingMode);

			return (result, changedEncodingMode);
		}

		#endregion

		#region IBMDStreamingH264NALPacket

		public static IntPtr GetBytes(this IBMDStreamingH264NALPacket nalPacket)
		{
			nalPacket.GetBytes(out IntPtr buffer);

			return buffer;
		}

		public static ReadOnlySpan<byte> GetBytesSpan(this IBMDStreamingH264NALPacket nalPacket)
		{
			nalPacket.GetBytes(out IntPtr buffer);

			unsafe
			{
				return new ReadOnlySpan<byte>(buffer.ToPointer(), nalPacket.GetPayloadSize());
			}
		}

		public static IntPtr GetBytesWithSizePrefix(this IBMDStreamingH264NALPacket nalPacket)
		{
			nalPacket.GetBytesWithSizePrefix(out IntPtr buffer);

			return buffer;
		}

		public static ReadOnlySpan<byte> GetBytesSpanWithSizePrefix(this IBMDStreamingH264NALPacket nalPacket)
		{
			nalPacket.GetBytesWithSizePrefix(out IntPtr buffer);

			unsafe
			{
				return new ReadOnlySpan<byte>(buffer.ToPointer(), nalPacket.GetPayloadSize() + 4);
			}
		}

		public static ulong GetDisplayTime(this IBMDStreamingH264NALPacket nalPacket, ulong requestedTimeScale)
		{
			nalPacket.GetDisplayTime(requestedTimeScale, out ulong displayTime);

			return displayTime;
		}

		public static uint GetPacketIndex(this IBMDStreamingH264NALPacket nalPacket)
		{
			nalPacket.GetPacketIndex(out uint packetIndex);

			return packetIndex;
		}

		#endregion

		#region IBMDStreamingH264NALParser

		public static (uint profileIdc, uint profileCompatability, uint levelIdc) GetProfileAndLevelFromSPS(this IBMDStreamingH264NALParser parser, IBMDStreamingH264NALPacket nal)
		{
			parser.GetProfileAndLevelFromSPS(nal, out uint profileIdc, out uint profileCompatability, out uint levelIdc);

			return (profileIdc, profileCompatability, levelIdc);
		}

		#endregion

		#region IBMDStreamingMPEG2TSPacket

		public static IntPtr GetBytes(this IBMDStreamingMPEG2TSPacket tsPacket)
		{
			tsPacket.GetBytes(out IntPtr buffer);

			return buffer;
		}

		public static ReadOnlySpan<byte> GetBytesSpan(this IBMDStreamingMPEG2TSPacket tsPacket)
		{
			tsPacket.GetBytes(out IntPtr buffer);

			unsafe
			{
				return new ReadOnlySpan<byte>(buffer.ToPointer(), tsPacket.GetPayloadSize());
			}
		}

		#endregion

		#region IBMDStreamingVideoEncodingMode

		public static string GetName(this IBMDStreamingVideoEncodingMode encodingMode)
		{
			encodingMode.GetName(out string name);

			return name;
		}

		public static bool GetFlag(this IBMDStreamingVideoEncodingMode encodingMode, BMDStreamingEncodingModePropertyID cfgID)
		{
			encodingMode.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IBMDStreamingVideoEncodingMode encodingMode, BMDStreamingEncodingModePropertyID cfgID)
		{
			encodingMode.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IBMDStreamingVideoEncodingMode encodingMode, BMDStreamingEncodingModePropertyID cfgID) where T : Enum
		{
			encodingMode.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IBMDStreamingVideoEncodingMode encodingMode, BMDStreamingEncodingModePropertyID cfgID)
		{
			encodingMode.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IBMDStreamingVideoEncodingMode encodingMode, BMDStreamingEncodingModePropertyID cfgID)
		{
			encodingMode.GetString(cfgID, out string value);

			return value;
		}

		public static IBMDStreamingMutableVideoEncodingMode CreateMutableVideoEncodingMode(this IBMDStreamingVideoEncodingMode encodingMode)
		{
			encodingMode.CreateMutableVideoEncodingMode(out IBMDStreamingMutableVideoEncodingMode newEncodingMode);

			return newEncodingMode;
		}

		#endregion

		#region IBMDStreamingVideoEncodingModePresetIterator

		public static IBMDStreamingVideoEncodingMode Next(this IBMDStreamingVideoEncodingModePresetIterator iterator)
		{
			iterator.Next(out IBMDStreamingVideoEncodingMode videoEncodingMode);

			return videoEncodingMode;
		}

		#endregion

		#region IDeckLink

		public static string GetDisplayName(this IDeckLink deckLink)
		{
			deckLink.GetDisplayName(out string name);

			return name;
		}

		public static string GetModelName(this IDeckLink deckLink)
		{
			deckLink.GetModelName(out string name);

			return name;
		}

		#endregion

		#region IDeckLink_v8_0

		public static string GetModelName(this IDeckLink_v8_0 deckLink)
		{
			deckLink.GetModelName(out string name);

			return name;
		}

		#endregion

		#region IDeckLinkAdvancedConversions

		public static long GetConversionLatency(this IDeckLinkAdvancedConversions advancedConversions, BMDDisplayMode fromMode, BMDDisplayMode toMode, long timeScale)
		{
			advancedConversions.GetConversionLatency(fromMode, toMode, timeScale, out long latency);

			return latency;
		}

		#endregion

		#region IDeckLinkAncillaryPacket

		public static (IntPtr data, uint size) GetBytes(this IDeckLinkAncillaryPacket ancillaryPacket, BMDAncillaryPacketFormat format)
		{
			ancillaryPacket.GetBytes(format, out IntPtr data, out uint size);

			return (data, size);
		}

		public static ReadOnlySpan<byte> GetBytesSpan(this IDeckLinkAncillaryPacket ancillaryPacket, BMDAncillaryPacketFormat format)
		{
			ancillaryPacket.GetBytes(format, out IntPtr data, out uint size);

			unsafe
			{
				return new ReadOnlySpan<byte>(data.ToPointer(), (int)size);
			}
		}

		#endregion

		#region IDeckLinkAncillaryPacketIterator

		public static IDeckLinkAncillaryPacket Next(this IDeckLinkAncillaryPacketIterator iterator)
		{
			iterator.Next(out IDeckLinkAncillaryPacket packet);

			return packet;
		}

		#endregion

		#region IDeckLinkAPIInformation

		public static bool GetFlag(this IDeckLinkAPIInformation apiInformation, BMDDeckLinkAPIInformationID cfgID)
		{
			apiInformation.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkAPIInformation apiInformation, BMDDeckLinkAPIInformationID cfgID)
		{
			apiInformation.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkAPIInformation apiInformation, BMDDeckLinkAPIInformationID cfgID) where T : Enum
		{
			apiInformation.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkAPIInformation apiInformation, BMDDeckLinkAPIInformationID cfgID)
		{
			apiInformation.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkAPIInformation apiInformation, BMDDeckLinkAPIInformationID cfgID)
		{
			apiInformation.GetString(cfgID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkAttributes_v10_11

		public static bool GetFlag(this IDeckLinkAttributes_v10_11 deckLinkAttributes, BMDDeckLinkAttributeID cfgID)
		{
			deckLinkAttributes.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkAttributes_v10_11 deckLinkAttributes, BMDDeckLinkAttributeID cfgID)
		{
			deckLinkAttributes.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkAttributes_v10_11 deckLinkAttributes, BMDDeckLinkAttributeID cfgID) where T : Enum
		{
			deckLinkAttributes.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkAttributes_v10_11 deckLinkAttributes, BMDDeckLinkAttributeID cfgID)
		{
			deckLinkAttributes.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkAttributes_v10_11 deckLinkAttributes, BMDDeckLinkAttributeID cfgID)
		{
			deckLinkAttributes.GetString(cfgID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkAudioInputPacket

		public static IntPtr GetBytes(this IDeckLinkAudioInputPacket audioInputPacket)
		{
			audioInputPacket.GetBytes(out IntPtr buffer);

			return buffer;
		}

		public static ReadOnlySpan<byte> GetBytesSpan(this IDeckLinkAudioInputPacket audioInputPacket)
		{
			audioInputPacket.GetBytes(out IntPtr buffer);

			unsafe
			{
				return new ReadOnlySpan<byte>(buffer.ToPointer(), audioInputPacket.GetSampleFrameCount());
			}
		}

		public static long GetPacketTime(this IDeckLinkAudioInputPacket audioInputPacket, long timeScale)
		{
			audioInputPacket.GetPacketTime(out long packetTime, timeScale);

			return packetTime;
		}

		#endregion

		#region IDeckLinkAudioInputPacket_v7_1

		public static IntPtr GetBytes(this IDeckLinkAudioInputPacket_v7_1 audioInputPacket)
		{
			IntPtr buffer = IntPtr.Zero;
			audioInputPacket.GetBytes(ref buffer);

			return buffer;
		}

		public static long GetAudioPacketTime(this IDeckLinkAudioInputPacket_v7_1 audioInputPacket, long timeScale)
		{
			long packetTime = 0;
			audioInputPacket.GetAudioPacketTime(ref packetTime, timeScale);
			
			return packetTime;
		}

		#endregion

		#region IDeckLinkAudioMixer

		public static BMDAudioMixerSource GetSources(this IDeckLinkAudioMixer deckLinkAudioMixer)
		{
			BMDAudioMixerSource mixerSources = BMDAudioMixerSource.bmdAudioMixerSourceAll;
			deckLinkAudioMixer.GetSources(ref mixerSources);

			return mixerSources;
		}

		public static (byte outputChannelGains, uint outputChannelCount) GetChannelGains(this IDeckLinkAudioMixer deckLinkAudioMixer, BMDAudioMixerSource mixerSource, BMDAudioMixerInputChannel inputChannel)
		{
			deckLinkAudioMixer.GetChannelGains(mixerSource, inputChannel, out byte outputChannelGains, out uint outputChannelCount);

			return (outputChannelGains, outputChannelCount);
		}

		#endregion

		#region IDeckLinkConfiguration

		public static bool GetFlag(this IDeckLinkConfiguration deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkConfiguration deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkConfiguration deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID) where T : Enum
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkConfiguration deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkConfiguration deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetString(cfgID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkConfiguration_v10_11

		public static bool GetFlag(this IDeckLinkConfiguration_v10_11 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkConfiguration_v10_11 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkConfiguration_v10_11 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID) where T : Enum
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkConfiguration_v10_11 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkConfiguration_v10_11 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetString(cfgID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkConfiguration_v10_2

		public static bool GetFlag(this IDeckLinkConfiguration_v10_2 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkConfiguration_v10_2 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkConfiguration_v10_2 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID) where T : Enum
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkConfiguration_v10_2 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkConfiguration_v10_2 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetString(cfgID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkConfiguration_v10_4

		public static bool GetFlag(this IDeckLinkConfiguration_v10_4 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkConfiguration_v10_4 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkConfiguration_v10_4 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID) where T : Enum
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkConfiguration_v10_4 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkConfiguration_v10_4 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetString(cfgID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkConfiguration_v10_9

		public static bool GetFlag(this IDeckLinkConfiguration_v10_9 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkConfiguration_v10_9 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkConfiguration_v10_9 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID) where T : Enum
		{
			deckLinkConfiguration.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkConfiguration_v10_9 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkConfiguration_v10_9 deckLinkConfiguration, BMDDeckLinkConfigurationID cfgID)
		{
			deckLinkConfiguration.GetString(cfgID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkConfiguration_v7_6

		public static IDeckLinkConfiguration_v7_6 GetConfigurationValidator(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.GetConfigurationValidator(out IDeckLinkConfiguration_v7_6 configObject);

			return configObject;
		}

		public static bool IsVideoOutputActive(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration, BMDVideoConnection_v7_6 videoOutputConnection)
		{
			deckLinkConfiguration.IsVideoOutputActive(videoOutputConnection, out bool active);

			return active;
		}

		public static BMDAnalogVideoFlags GetAnalogVideoOutputFlags(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.GetAnalogVideoOutputFlags(out BMDAnalogVideoFlags analogVideoFlags);

			return analogVideoFlags;
		}

		public static bool IsEnabledFieldFlickerRemovalWhenPaused(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.IsEnabledFieldFlickerRemovalWhenPaused(out bool enabled);

			return enabled;
		}

		public static (bool is444VideoOutputEnabled, bool threeGbsOutputEnabled) Get444And3GBpsVideoOutput(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.Get444And3GBpsVideoOutput(out bool is444VideoOutputEnabled, out bool threeGbsOutputEnabled);

			return (is444VideoOutputEnabled, threeGbsOutputEnabled);
		}

		public static BMDVideoOutputConversionMode GetVideoOutputConversionMode(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.GetVideoOutputConversionMode(out BMDVideoOutputConversionMode conversionMode);

			return conversionMode;
		}

		public static bool Get_HD1080p24_to_HD1080i5994_Conversion(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.Get_HD1080p24_to_HD1080i5994_Conversion(out bool enabled);

			return enabled;
		}

		public static BMDVideoConnection_v7_6 GetVideoInputFormat(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.GetVideoInputFormat(out BMDVideoConnection_v7_6 videoInputFormat);

			return videoInputFormat;
		}

		public static BMDAnalogVideoFlags GetAnalogVideoInputFlags(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.GetAnalogVideoInputFlags(out BMDAnalogVideoFlags analogVideoFlags);

			return analogVideoFlags;
		}

		public static BMDVideoInputConversionMode GetVideoInputConversionMode(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.GetVideoInputConversionMode(out BMDVideoInputConversionMode conversionMode);

			return conversionMode;
		}

		public static bool GetBlackVideoOutputDuringCapture(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.GetBlackVideoOutputDuringCapture(out bool blackOutInCapture);

			return blackOutInCapture;
		}

		public static uint Get32PulldownSequenceInitialTimecodeFrame(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.Get32PulldownSequenceInitialTimecodeFrame(out uint aFrameTimecode);

			return aFrameTimecode;
		}

		public static (uint activeLine1VANCsource, uint activeLine2VANCsource, uint activeLine3VANCsource) GetVancSourceLineMapping(this IDeckLinkConfiguration_v7_6 deckLinkConfiguration)
		{
			deckLinkConfiguration.GetVancSourceLineMapping(out uint activeLine1VANCsource, out uint activeLine2VANCsource, out uint activeLine3VANCsource);

			return (activeLine1VANCsource, activeLine2VANCsource, activeLine3VANCsource);
		}

		#endregion

		#region IDeckLinkDeckControl

		public static BMDDeckControlError Open(this IDeckLinkDeckControl deckControl, long timeScale, long timeValue, bool timecodeIsDropFrame)
		{
			deckControl.Open(timeScale, timeValue, timecodeIsDropFrame, out BMDDeckControlError error);

			return error;
		}

		public static (BMDDeckControlMode mode, BMDDeckControlVTRControlState vtrControlState, BMDDeckControlStatusFlags flags) GetCurrentState(this IDeckLinkDeckControl deckControl)
		{
			deckControl.GetCurrentState(out BMDDeckControlMode mode, out BMDDeckControlVTRControlState vtrControlState, out BMDDeckControlStatusFlags flags);

			return (mode, vtrControlState, flags);
		}

		public static (byte outBuffer, uint outDataSize, uint outBufferSize, BMDDeckControlError error) SendCommand(this IDeckLinkDeckControl deckControl, ref byte inBuffer, uint inBufferSize)
		{
			deckControl.SendCommand(ref inBuffer, inBufferSize, out byte outBuffer, out uint outDataSize, out uint outBufferSize, out BMDDeckControlError error);

			return (outBuffer, outDataSize, outBufferSize, error);
		}

		public static BMDDeckControlError Play(this IDeckLinkDeckControl deckControl)
		{
			deckControl.Play(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Stop(this IDeckLinkDeckControl deckControl)
		{
			deckControl.Stop(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError TogglePlayStop(this IDeckLinkDeckControl deckControl)
		{
			deckControl.TogglePlayStop(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Eject(this IDeckLinkDeckControl deckControl)
		{
			deckControl.Eject(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError GoToTimecode(this IDeckLinkDeckControl deckControl, uint timecode)
		{
			deckControl.GoToTimecode(timecode, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError FastForward(this IDeckLinkDeckControl deckControl, bool viewTape)
		{
			deckControl.FastForward(viewTape, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Rewind(this IDeckLinkDeckControl deckControl, bool viewTape)
		{
			deckControl.Rewind(viewTape, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError StepForward(this IDeckLinkDeckControl deckControl)
		{
			deckControl.StepForward(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError StepBack(this IDeckLinkDeckControl deckControl)
		{
			deckControl.StepBack(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Jog(this IDeckLinkDeckControl deckControl, double rate)
		{
			deckControl.Jog(rate, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Shuttle(this IDeckLinkDeckControl deckControl, double rate)
		{
			deckControl.Shuttle(rate, out BMDDeckControlError error);

			return error;
		}

		public static (string currentTimecode, BMDDeckControlError error) GetTimecodeString(this IDeckLinkDeckControl deckControl)
		{
			deckControl.GetTimecodeString(out string currentTimecode, out BMDDeckControlError error);

			return (currentTimecode, error);
		}

		public static (IDeckLinkTimecode currentTimecode, BMDDeckControlError error) GetTimecode(this IDeckLinkDeckControl deckControl)
		{
			deckControl.GetTimecode(out IDeckLinkTimecode currentTimecode, out BMDDeckControlError error);

			return (currentTimecode, error);
		}

		public static (uint currentTimecode, BMDDeckControlError error) GetTimecodeBCD(this IDeckLinkDeckControl deckControl)
		{
			deckControl.GetTimecodeBCD(out uint currentTimecode, out BMDDeckControlError error);

			return (currentTimecode, error);
		}

		public static uint GetPreroll(this IDeckLinkDeckControl deckControl)
		{
			deckControl.GetPreroll(out uint prerollSeconds);

			return prerollSeconds;
		}

		public static int GetExportOffset(this IDeckLinkDeckControl deckControl)
		{
			deckControl.GetExportOffset(out int exportOffsetFields);

			return exportOffsetFields;
		}

		public static int GetManualExportOffset(this IDeckLinkDeckControl deckControl)
		{
			deckControl.GetManualExportOffset(out int deckManualExportOffsetFields);

			return deckManualExportOffsetFields;
		}

		public static int GetCaptureOffset(this IDeckLinkDeckControl deckControl)
		{
			deckControl.GetCaptureOffset(out int captureOffsetFields);

			return captureOffsetFields;
		}

		public static BMDDeckControlError StartExport(this IDeckLinkDeckControl deckControl, uint inTimecode, uint outTimecode, BMDDeckControlExportModeOpsFlags exportModeOps)
		{
			deckControl.StartExport(inTimecode, outTimecode, exportModeOps, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError StartCapture(this IDeckLinkDeckControl deckControl, bool useVITC, uint inTimecode, uint outTimecode)
		{
			deckControl.StartCapture(useVITC, inTimecode, outTimecode, out BMDDeckControlError error);

			return error;
		}

		public static (ushort deviceId, BMDDeckControlError error) GetDeviceID(this IDeckLinkDeckControl deckControl)
		{
			deckControl.GetDeviceID(out ushort deviceId, out BMDDeckControlError error);

			return (deviceId, error);
		}

		public static BMDDeckControlError CrashRecordStart(this IDeckLinkDeckControl deckControl)
		{
			deckControl.CrashRecordStart(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError CrashRecordStop(this IDeckLinkDeckControl deckControl)
		{
			deckControl.CrashRecordStop(out BMDDeckControlError error);

			return error;
		}

		#endregion

		#region IDeckLinkDeckControl_v7_9

		public static BMDDeckControlError Open(this IDeckLinkDeckControl_v7_9 deckControl, long timeScale, long timeValue, bool timecodeIsDropFrame)
		{
			deckControl.Open(timeScale, timeValue, timecodeIsDropFrame, out BMDDeckControlError error);

			return error;
		}

		public static (BMDDeckControlMode mode, BMDDeckControlVTRControlState vtrControlState, BMDDeckControlStatusFlags flags) GetCurrentState(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.GetCurrentState(out BMDDeckControlMode mode, out BMDDeckControlVTRControlState vtrControlState, out BMDDeckControlStatusFlags flags);

			return (mode, vtrControlState, flags);
		}

		public static BMDDeckControlError Play(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.Play(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Stop(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.Stop(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError TogglePlayStop(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.TogglePlayStop(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Eject(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.Eject(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError GoToTimecode(this IDeckLinkDeckControl_v7_9 deckControl, uint timecode)
		{
			deckControl.GoToTimecode(timecode, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError FastForward(this IDeckLinkDeckControl_v7_9 deckControl, bool viewTape)
		{
			deckControl.FastForward(viewTape, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Rewind(this IDeckLinkDeckControl_v7_9 deckControl, bool viewTape)
		{
			deckControl.Rewind(viewTape, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError StepForward(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.StepForward(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError StepBack(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.StepBack(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Jog(this IDeckLinkDeckControl_v7_9 deckControl, double rate)
		{
			deckControl.Jog(rate, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Shuttle(this IDeckLinkDeckControl_v7_9 deckControl, double rate)
		{
			deckControl.Shuttle(rate, out BMDDeckControlError error);

			return error;
		}

		public static (string currentTimecode, BMDDeckControlError error) GetTimecodeString(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.GetTimecodeString(out string currentTimecode, out BMDDeckControlError error);

			return (currentTimecode, error);
		}

		public static (IDeckLinkTimecode currentTimecode, BMDDeckControlError error) GetTimecode(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.GetTimecode(out IDeckLinkTimecode currentTimecode, out BMDDeckControlError error);

			return (currentTimecode, error);
		}

		public static (uint currentTimecode, BMDDeckControlError error) GetTimecodeBCD(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.GetTimecodeBCD(out uint currentTimecode, out BMDDeckControlError error);

			return (currentTimecode, error);
		}

		public static uint GetPreroll(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.GetPreroll(out uint prerollSeconds);

			return prerollSeconds;
		}

		public static int GetExportOffset(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.GetExportOffset(out int exportOffsetFields);

			return exportOffsetFields;
		}

		public static int GetManualExportOffset(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.GetManualExportOffset(out int deckManualExportOffsetFields);

			return deckManualExportOffsetFields;
		}

		public static int GetCaptureOffset(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.GetCaptureOffset(out int captureOffsetFields);

			return captureOffsetFields;
		}

		public static BMDDeckControlError StartExport(this IDeckLinkDeckControl_v7_9 deckControl, uint inTimecode, uint outTimecode, BMDDeckControlExportModeOpsFlags exportModeOps)
		{
			deckControl.StartExport(inTimecode, outTimecode, exportModeOps, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError StartCapture(this IDeckLinkDeckControl_v7_9 deckControl, bool useVITC, uint inTimecode, uint outTimecode)
		{
			deckControl.StartCapture(useVITC, inTimecode, outTimecode, out BMDDeckControlError error);

			return error;
		}

		public static (ushort deviceId, BMDDeckControlError error) GetDeviceID(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.GetDeviceID(out ushort deviceId, out BMDDeckControlError error);

			return (deviceId, error);
		}

		public static BMDDeckControlError CrashRecordStart(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.CrashRecordStart(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError CrashRecordStop(this IDeckLinkDeckControl_v7_9 deckControl)
		{
			deckControl.CrashRecordStop(out BMDDeckControlError error);

			return error;
		}

		#endregion

		#region IDeckLinkDeckControl_v8_1

		public static BMDDeckControlError Open(this IDeckLinkDeckControl_v8_1 deckControl, long timeScale, long timeValue, bool timecodeIsDropFrame)
		{
			deckControl.Open(timeScale, timeValue, timecodeIsDropFrame, out BMDDeckControlError error);

			return error;
		}

		public static (BMDDeckControlMode mode, BMDDeckControlVTRControlState_v8_1 vtrControlState, BMDDeckControlStatusFlags flags) GetCurrentState(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.GetCurrentState(out BMDDeckControlMode mode, out BMDDeckControlVTRControlState_v8_1 vtrControlState, out BMDDeckControlStatusFlags flags);

			return (mode, vtrControlState, flags);
		}

		public static (byte outBuffer, uint outDataSize, uint outBufferSize, BMDDeckControlError error) SendCommand(this IDeckLinkDeckControl_v8_1 deckControl, ref byte inBuffer, uint inBufferSize)
		{
			deckControl.SendCommand(ref inBuffer, inBufferSize, out byte outBuffer, out uint outDataSize, out uint outBufferSize, out BMDDeckControlError error);

			return (outBuffer, outDataSize, outBufferSize, error);
		}

		public static BMDDeckControlError Play(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.Play(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Stop(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.Stop(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError TogglePlayStop(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.TogglePlayStop(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Eject(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.Eject(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError GoToTimecode(this IDeckLinkDeckControl_v8_1 deckControl, uint timecode)
		{
			deckControl.GoToTimecode(timecode, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError FastForward(this IDeckLinkDeckControl_v8_1 deckControl, bool viewTape)
		{
			deckControl.FastForward(viewTape, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Rewind(this IDeckLinkDeckControl_v8_1 deckControl, bool viewTape)
		{
			deckControl.Rewind(viewTape, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError StepForward(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.StepForward(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError StepBack(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.StepBack(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Jog(this IDeckLinkDeckControl_v8_1 deckControl, double rate)
		{
			deckControl.Jog(rate, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError Shuttle(this IDeckLinkDeckControl_v8_1 deckControl, double rate)
		{
			deckControl.Shuttle(rate, out BMDDeckControlError error);

			return error;
		}

		public static (string currentTimecode, BMDDeckControlError error) GetTimecodeString(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.GetTimecodeString(out string currentTimecode, out BMDDeckControlError error);

			return (currentTimecode, error);
		}

		public static (IDeckLinkTimecode currentTimecode, BMDDeckControlError error) GetTimecode(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.GetTimecode(out IDeckLinkTimecode currentTimecode, out BMDDeckControlError error);

			return (currentTimecode, error);
		}

		public static (uint currentTimecode, BMDDeckControlError error) GetTimecodeBCD(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.GetTimecodeBCD(out uint currentTimecode, out BMDDeckControlError error);

			return (currentTimecode, error);
		}

		public static uint GetPreroll(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.GetPreroll(out uint prerollSeconds);

			return prerollSeconds;
		}

		public static int GetExportOffset(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.GetExportOffset(out int exportOffsetFields);

			return exportOffsetFields;
		}

		public static int GetManualExportOffset(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.GetManualExportOffset(out int deckManualExportOffsetFields);

			return deckManualExportOffsetFields;
		}

		public static int GetCaptureOffset(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.GetCaptureOffset(out int captureOffsetFields);

			return captureOffsetFields;
		}

		public static BMDDeckControlError StartExport(this IDeckLinkDeckControl_v8_1 deckControl, uint inTimecode, uint outTimecode, BMDDeckControlExportModeOpsFlags exportModeOps)
		{
			deckControl.StartExport(inTimecode, outTimecode, exportModeOps, out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError StartCapture(this IDeckLinkDeckControl_v8_1 deckControl, bool useVITC, uint inTimecode, uint outTimecode)
		{
			deckControl.StartCapture(useVITC, inTimecode, outTimecode, out BMDDeckControlError error);

			return error;
		}

		public static (ushort deviceId, BMDDeckControlError error) GetDeviceID(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.GetDeviceID(out ushort deviceId, out BMDDeckControlError error);

			return (deviceId, error);
		}

		public static BMDDeckControlError CrashRecordStart(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.CrashRecordStart(out BMDDeckControlError error);

			return error;
		}

		public static BMDDeckControlError CrashRecordStop(this IDeckLinkDeckControl_v8_1 deckControl)
		{
			deckControl.CrashRecordStop(out BMDDeckControlError error);

			return error;
		}

		#endregion

		#region IDeckLinkDisplayMode

		public static string GetName(this IDeckLinkDisplayMode displayMode)
		{
			displayMode.GetName(out string name);

			return name;
		}

		public static (long frameDuration, long timeScale) GetFrameRate(this IDeckLinkDisplayMode displayMode)
		{
			displayMode.GetFrameRate(out long frameDuration, out long timeScale);

			return (frameDuration, timeScale);
		}

		#endregion

		#region IDeckLinkDisplayMode_v7_1

		public static string GetName(this IDeckLinkDisplayMode_v7_1 displayMode)
		{
			displayMode.GetName(out string name);

			return name;
		}

		public static (long frameDuration, long timeScale) GetFrameRate(this IDeckLinkDisplayMode_v7_1 displayMode)
		{
			displayMode.GetFrameRate(out long frameDuration, out long timeScale);

			return (frameDuration, timeScale);
		}

		#endregion

		#region IDeckLinkDisplayMode_v7_6

		public static string GetName(this IDeckLinkDisplayMode_v7_6 displayMode)
		{
			displayMode.GetName(out string name);

			return name;
		}

		public static (long frameDuration, long timeScale) GetFrameRate(this IDeckLinkDisplayMode_v7_6 displayMode)
		{
			displayMode.GetFrameRate(out long frameDuration, out long timeScale);

			return (frameDuration, timeScale);
		}

		#endregion

		#region IDeckLinkDisplayModeIterator

		public static IDeckLinkDisplayMode Next(this IDeckLinkDisplayModeIterator deckLinkDisplayModeIterator)
		{
			deckLinkDisplayModeIterator.Next(out IDeckLinkDisplayMode deckLinkDisplayMode);

			return deckLinkDisplayMode;
		}

		#endregion

		#region IDeckLinkDisplayModeIterator_v7_1

		public static IDeckLinkDisplayMode_v7_1 Next(this IDeckLinkDisplayModeIterator_v7_1 deckLinkDisplayModeIterator)
		{
			deckLinkDisplayModeIterator.Next(out IDeckLinkDisplayMode_v7_1 deckLinkDisplayMode);

			return deckLinkDisplayMode;
		}

		#endregion

		#region IDeckLinkDisplayModeIterator_v7_6

		public static IDeckLinkDisplayMode_v7_6 Next(this IDeckLinkDisplayModeIterator_v7_6 deckLinkDisplayModeIterator)
		{
			deckLinkDisplayModeIterator.Next(out IDeckLinkDisplayMode_v7_6 deckLinkDisplayMode);

			return deckLinkDisplayMode;
		}

		#endregion

		#region IDeckLinkDisplayModePrivate

		public static uint GetSDIRate(this IDeckLinkDisplayModePrivate deckLinkDisplayModePrivate, BMDPixelFormat pixelFormat)
		{
			deckLinkDisplayModePrivate.GetSDIRate(pixelFormat, out uint rateMbps);

			return rateMbps;
		}

		#endregion

		#region IDeckLinkEncoderConfiguration

		public static bool GetFlag(this IDeckLinkEncoderConfiguration deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID)
		{
			deckLinkEncoderConfiguration.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkEncoderConfiguration deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID)
		{
			deckLinkEncoderConfiguration.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkEncoderConfiguration deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID) where T : Enum
		{
			deckLinkEncoderConfiguration.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkEncoderConfiguration deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID)
		{
			deckLinkEncoderConfiguration.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkEncoderConfiguration deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID)
		{
			deckLinkEncoderConfiguration.GetString(cfgID, out string value);

			return value;
		}

		/// <returns>A buffer pointer and bufferSize tuple. The buffer must be freed by the caller with Marshal.FreeHGlobal(buffer).</returns>
		public static (IntPtr buffer, uint bufferSize) GetBytes(this IDeckLinkEncoderConfiguration deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID)
		{
			uint bufferSize = 0;

			// First call to get the required buffer size
			deckLinkEncoderConfiguration.GetBytes(cfgID, IntPtr.Zero, ref bufferSize);

			// Allocate the buffer
			IntPtr buffer = Marshal.AllocHGlobal((int)bufferSize); //TODO: I'm assuming we don't have to use Marshal.AllocCoTaskMem

			// Second call to get the actual bytes
			deckLinkEncoderConfiguration.GetBytes(cfgID, buffer, ref bufferSize);

			return (buffer, bufferSize);
		}

		#endregion

		#region IDeckLinkEncoderConfiguration_v10_5

		public static bool GetFlag(this IDeckLinkEncoderConfiguration_v10_5 deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID)
		{
			deckLinkEncoderConfiguration.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkEncoderConfiguration_v10_5 deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID)
		{
			deckLinkEncoderConfiguration.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkEncoderConfiguration_v10_5 deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID) where T : Enum
		{
			deckLinkEncoderConfiguration.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkEncoderConfiguration_v10_5 deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID)
		{
			deckLinkEncoderConfiguration.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkEncoderConfiguration_v10_5 deckLinkEncoderConfiguration, BMDDeckLinkEncoderConfigurationID cfgID)
		{
			deckLinkEncoderConfiguration.GetString(cfgID, out string value);

			return value;
		}

		public static int GetDecoderConfigurationInfo(this IDeckLinkEncoderConfiguration_v10_5 deckLinkEncoderConfiguration, IntPtr buffer, int bufferSize)
		{
			deckLinkEncoderConfiguration.GetDecoderConfigurationInfo(buffer, bufferSize, out int returnedSize);

			return returnedSize;
		}

		#endregion

		#region IDeckLinkEncoderInput

		public static bool DoesSupportVideoMode(this IDeckLinkEncoderInput deckLinkEncoderInput, BMDVideoConnection connection, BMDDisplayMode requestedMode, BMDPixelFormat requestedCodec, uint requestedCodecProfile, BMDSupportedVideoModeFlags flags)
		{
			deckLinkEncoderInput.DoesSupportVideoMode(connection, requestedMode, requestedCodec, requestedCodecProfile, flags, out bool supported);

			return supported;
		}

		public static IDeckLinkDisplayMode GetDisplayMode(this IDeckLinkEncoderInput deckLinkEncoderInput, BMDDisplayMode displayMode)
		{
			deckLinkEncoderInput.GetDisplayMode(displayMode, out IDeckLinkDisplayMode displayModeObj);

			return displayModeObj;
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkEncoderInput deckLinkEncoderInput)
		{
			deckLinkEncoderInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static uint GetAvailablePacketsCount(this IDeckLinkEncoderInput deckLinkEncoderInput)
		{
			deckLinkEncoderInput.GetAvailablePacketsCount(out uint availablePacketsCount);

			return availablePacketsCount;
		}

		public static uint GetAvailableAudioSampleFrameCount(this IDeckLinkEncoderInput deckLinkEncoderInput)
		{
			deckLinkEncoderInput.GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

			return availableSampleFrameCount;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkEncoderInput deckLinkEncoderInput, long desiredTimeScale)
		{
			deckLinkEncoderInput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkEncoderInput_v10_11

		public static (BMDDisplayModeSupport_v10_11 result, IDeckLinkDisplayMode resultDisplayMode) DoesSupportVideoMode(this IDeckLinkEncoderInput_v10_11 deckLinkEncoderInput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoInputFlags flags)
		{
			deckLinkEncoderInput.DoesSupportVideoMode(displayMode, pixelFormat, flags, out BMDDisplayModeSupport_v10_11 result, out IDeckLinkDisplayMode resultDisplayMode);

			return (result, resultDisplayMode);
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkEncoderInput_v10_11 deckLinkEncoderInput)
		{
			deckLinkEncoderInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static uint GetAvailablePacketsCount(this IDeckLinkEncoderInput_v10_11 deckLinkEncoderInput)
		{
			deckLinkEncoderInput.GetAvailablePacketsCount(out uint availablePacketsCount);

			return availablePacketsCount;
		}

		public static uint GetAvailableAudioSampleFrameCount(this IDeckLinkEncoderInput_v10_11 deckLinkEncoderInput)
		{
			deckLinkEncoderInput.GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

			return availableSampleFrameCount;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkEncoderInput_v10_11 deckLinkEncoderInput, long desiredTimeScale)
		{
			deckLinkEncoderInput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkEncoderPacket

		public static IntPtr GetBytes(this IDeckLinkEncoderPacket deckLinkEncoderPacket)
		{
			deckLinkEncoderPacket.GetBytes(out IntPtr buffer);

			return buffer;
		}

		public static ReadOnlySpan<byte> GetBytesSpan(this IDeckLinkEncoderPacket deckLinkEncoderPacket)
		{
			IntPtr buffer = deckLinkEncoderPacket.GetBytes();

			unsafe
			{
				return new ReadOnlySpan<byte>(buffer.ToPointer(), deckLinkEncoderPacket.GetSize());
			}
		}

		public static long GetStreamTime(this IDeckLinkEncoderPacket deckLinkEncoderPacket, long timeScale)
		{
			deckLinkEncoderPacket.GetStreamTime(out long frameTime, timeScale);

			return frameTime;
		}

		#endregion

		#region IDeckLinkEncoderVideoPacket

		public static (long frameTime, long frameDuration) GetHardwareReferenceTimestamp(this IDeckLinkEncoderVideoPacket deckLinkEncoderVideoPacket, long timeScale)
		{
			deckLinkEncoderVideoPacket.GetHardwareReferenceTimestamp(timeScale, out long frameTime, out long frameDuration);

			return (frameTime, frameDuration);
		}

		public static IDeckLinkTimecode GetTimecode(this IDeckLinkEncoderVideoPacket deckLinkEncoderVideoPacket, BMDTimecodeFormat format)
		{
			deckLinkEncoderVideoPacket.GetTimecode(format, out IDeckLinkTimecode timecode);

			return timecode;
		}

		#endregion

		#region IDeckLinkH265NALPacket

		public static byte GetUnitType(this IDeckLinkH265NALPacket deckLinkH265NALPacket)
		{
			deckLinkH265NALPacket.GetUnitType(out byte unitType);

			return unitType;
		}

		public static IntPtr GetBytesNoPrefix(this IDeckLinkH265NALPacket deckLinkH265NALPacket)
		{
			deckLinkH265NALPacket.GetBytesNoPrefix(out IntPtr buffer);

			return buffer;
		}

		public static ReadOnlySpan<byte> GetBytesSpanNoPrefix(this IDeckLinkH265NALPacket deckLinkH265NALPacket)
		{
			IntPtr buffer = deckLinkH265NALPacket.GetBytesNoPrefix();

			unsafe
			{
				return new ReadOnlySpan<byte>(buffer.ToPointer(), deckLinkH265NALPacket.GetSize());
			}
		}

		#endregion

		#region IDeckLinkHDMIInputEDID

		public static long GetInt(this IDeckLinkHDMIInputEDID deckLinkHDMIInputEDID, BMDDeckLinkHDMIInputEDIDID cfgID)
		{
			deckLinkHDMIInputEDID.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkHDMIInputEDID deckLinkHDMIInputEDID, BMDDeckLinkHDMIInputEDIDID cfgID) where T : Enum
		{
			deckLinkHDMIInputEDID.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		#endregion

		#region IDeckLinkInput

		public static (BMDDisplayMode actualMode, bool supported) DoesSupportVideoMode(this IDeckLinkInput deckLinkInput, BMDVideoConnection connection, BMDDisplayMode requestedMode, BMDPixelFormat requestedPixelFormat, BMDVideoInputConversionMode conversionMode, BMDSupportedVideoModeFlags flags)
		{
			deckLinkInput.DoesSupportVideoMode(connection, requestedMode, requestedPixelFormat, conversionMode, flags, out BMDDisplayMode actualMode, out bool supported);

			return (actualMode, supported);
		}

		public static IDeckLinkDisplayMode GetDisplayMode(this IDeckLinkInput deckLinkInput, BMDDisplayMode displayMode)
		{
			deckLinkInput.GetDisplayMode(displayMode, out IDeckLinkDisplayMode resultDisplayMode);

			return resultDisplayMode;
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkInput deckLinkInput)
		{
			deckLinkInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static uint GetAvailableVideoFrameCount(this IDeckLinkInput deckLinkInput)
		{
			deckLinkInput.GetAvailableVideoFrameCount(out uint availableFrameCount);

			return availableFrameCount;
		}

		public static uint GetAvailableAudioSampleFrameCount(this IDeckLinkInput deckLinkInput)
		{
			deckLinkInput.GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

			return availableSampleFrameCount;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkInput deckLinkInput, long desiredTimeScale)
		{
			deckLinkInput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkInput_v10_11

		public static (BMDDisplayModeSupport_v10_11 result, IDeckLinkDisplayMode resultDisplayMode) DoesSupportVideoMode(this IDeckLinkInput_v10_11 deckLinkInput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoInputFlags flags)
		{
			deckLinkInput.DoesSupportVideoMode(displayMode, pixelFormat, flags, out BMDDisplayModeSupport_v10_11 result, out IDeckLinkDisplayMode resultDisplayMode);

			return (result, resultDisplayMode);
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkInput_v10_11 deckLinkInput)
		{
			deckLinkInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static uint GetAvailableVideoFrameCount(this IDeckLinkInput_v10_11 deckLinkInput)
		{
			deckLinkInput.GetAvailableVideoFrameCount(out uint availableFrameCount);

			return availableFrameCount;
		}

		public static uint GetAvailableAudioSampleFrameCount(this IDeckLinkInput_v10_11 deckLinkInput)
		{
			deckLinkInput.GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

			return availableSampleFrameCount;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkInput_v10_11 deckLinkInput, long desiredTimeScale)
		{
			deckLinkInput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkInput_v11_4

		public static bool DoesSupportVideoMode(this IDeckLinkInput_v11_4 deckLinkInput, BMDVideoConnection connection, BMDDisplayMode requestedMode, BMDPixelFormat requestedPixelFormat, BMDSupportedVideoModeFlags flags)
		{
			deckLinkInput.DoesSupportVideoMode(connection, requestedMode, requestedPixelFormat, flags, out bool supported);

			return supported;
		}

		public static IDeckLinkDisplayMode GetDisplayMode(this IDeckLinkInput_v11_4 deckLinkInput, BMDDisplayMode displayMode)
		{
			deckLinkInput.GetDisplayMode(displayMode, out IDeckLinkDisplayMode resultDisplayMode);

			return resultDisplayMode;
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkInput_v11_4 deckLinkInput)
		{
			deckLinkInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static uint GetAvailableVideoFrameCount(this IDeckLinkInput_v11_4 deckLinkInput)
		{
			deckLinkInput.GetAvailableVideoFrameCount(out uint availableFrameCount);

			return availableFrameCount;
		}

		public static uint GetAvailableAudioSampleFrameCount(this IDeckLinkInput_v11_4 deckLinkInput)
		{
			deckLinkInput.GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

			return availableSampleFrameCount;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkInput_v11_4 deckLinkInput, long desiredTimeScale)
		{
			deckLinkInput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkInput_v11_5_1

		public static (BMDDisplayMode actualMode, bool supported) DoesSupportVideoMode(this IDeckLinkInput_v11_5_1 deckLinkInput, BMDVideoConnection connection, BMDDisplayMode requestedMode, BMDPixelFormat requestedPixelFormat, BMDVideoInputConversionMode conversionMode, BMDSupportedVideoModeFlags flags)
		{
			deckLinkInput.DoesSupportVideoMode(connection, requestedMode, requestedPixelFormat, conversionMode, flags, out BMDDisplayMode actualMode, out bool supported);

			return (actualMode, supported);
		}

		public static IDeckLinkDisplayMode GetDisplayMode(this IDeckLinkInput_v11_5_1 deckLinkInput, BMDDisplayMode displayMode)
		{
			deckLinkInput.GetDisplayMode(displayMode, out IDeckLinkDisplayMode resultDisplayMode);

			return resultDisplayMode;
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkInput_v11_5_1 deckLinkInput)
		{
			deckLinkInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static uint GetAvailableVideoFrameCount(this IDeckLinkInput_v11_5_1 deckLinkInput)
		{
			deckLinkInput.GetAvailableVideoFrameCount(out uint availableFrameCount);

			return availableFrameCount;
		}

		public static uint GetAvailableAudioSampleFrameCount(this IDeckLinkInput_v11_5_1 deckLinkInput)
		{
			deckLinkInput.GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

			return availableSampleFrameCount;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkInput_v11_5_1 deckLinkInput, long desiredTimeScale)
		{
			deckLinkInput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkInput_v7_1

		public static BMDDisplayModeSupport_v10_11 DoesSupportVideoMode(this IDeckLinkInput_v7_1 deckLinkInput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat)
		{
			deckLinkInput.DoesSupportVideoMode(displayMode, pixelFormat, out BMDDisplayModeSupport_v10_11 result);

			return result;
		}

		public static IDeckLinkDisplayModeIterator_v7_1 GetDisplayModeIterator(this IDeckLinkInput_v7_1 deckLinkInput)
		{
			deckLinkInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator_v7_1 displayModeIterator);

			return displayModeIterator;
		}

		public static (uint sampleFramesRead, long audioPacketTime) ReadAudioSamples(this IDeckLinkInput_v7_1 deckLinkInput, IntPtr buffer, uint sampleFrameCount, long timeScale)
		{
			deckLinkInput.ReadAudioSamples(buffer, sampleFrameCount, out uint sampleFramesRead, out long audioPacketTime, timeScale);

			return (sampleFramesRead, audioPacketTime);
		}

		public static uint GetBufferedAudioSampleFrameCount(this IDeckLinkInput_v7_1 deckLinkInput)
		{
			deckLinkInput.GetBufferedAudioSampleFrameCount(out uint bufferedSampleCount);

			return bufferedSampleCount;
		}

		#endregion

		#region IDeckLinkInput_v7_3

		public static BMDDisplayModeSupport_v10_11 DoesSupportVideoMode(this IDeckLinkInput_v7_3 deckLinkInput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat)
		{
			deckLinkInput.DoesSupportVideoMode(displayMode, pixelFormat, out BMDDisplayModeSupport_v10_11 result);

			return result;
		}

		public static IDeckLinkDisplayModeIterator_v7_6 GetDisplayModeIterator(this IDeckLinkInput_v7_3 deckLinkInput)
		{
			deckLinkInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator_v7_6 displayModeIterator);

			return displayModeIterator;
		}

		public static uint GetAvailableVideoFrameCount(this IDeckLinkInput_v7_3 deckLinkInput)
		{
			deckLinkInput.GetAvailableVideoFrameCount(out uint availableFrameCount);

			return availableFrameCount;
		}

		public static uint GetAvailableAudioSampleFrameCount(this IDeckLinkInput_v7_3 deckLinkInput)
		{
			deckLinkInput.GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

			return availableSampleFrameCount;
		}

		#endregion

		#region IDeckLinkInput_v7_6

		public static BMDDisplayModeSupport_v10_11 DoesSupportVideoMode(this IDeckLinkInput_v7_6 deckLinkInput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat)
		{
			deckLinkInput.DoesSupportVideoMode(displayMode, pixelFormat, out BMDDisplayModeSupport_v10_11 result);

			return result;
		}

		public static IDeckLinkDisplayModeIterator_v7_6 GetDisplayModeIterator(this IDeckLinkInput_v7_6 deckLinkInput)
		{
			deckLinkInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator_v7_6 displayModeIterator);

			return displayModeIterator;
		}

		public static uint GetAvailableVideoFrameCount(this IDeckLinkInput_v7_6 deckLinkInput)
		{
			deckLinkInput.GetAvailableVideoFrameCount(out uint availableFrameCount);

			return availableFrameCount;
		}

		public static uint GetAvailableAudioSampleFrameCount(this IDeckLinkInput_v7_6 deckLinkInput)
		{
			deckLinkInput.GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

			return availableSampleFrameCount;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkInput_v7_6 deckLinkInput, long desiredTimeScale)
		{
			deckLinkInput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkInput_v9_2

		public static (BMDDisplayModeSupport_v10_11 result, IDeckLinkDisplayMode resultDisplayMode) DoesSupportVideoMode(this IDeckLinkInput_v9_2 deckLinkInput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoInputFlags flags)
		{
			deckLinkInput.DoesSupportVideoMode(displayMode, pixelFormat, flags, out BMDDisplayModeSupport_v10_11 result, out IDeckLinkDisplayMode resultDisplayMode);

			return (result, resultDisplayMode);
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkInput_v9_2 deckLinkInput)
		{
			deckLinkInput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static uint GetAvailableVideoFrameCount(this IDeckLinkInput_v9_2 deckLinkInput)
		{
			deckLinkInput.GetAvailableVideoFrameCount(out uint availableFrameCount);

			return availableFrameCount;
		}

		public static uint GetAvailableAudioSampleFrameCount(this IDeckLinkInput_v9_2 deckLinkInput)
		{
			deckLinkInput.GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

			return availableSampleFrameCount;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkInput_v9_2 deckLinkInput, long desiredTimeScale)
		{
			deckLinkInput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkIterator

		public static IDeckLink Next(this IDeckLinkIterator deckLinkIterator)
		{
			deckLinkIterator.Next(out IDeckLink deckLink);

			return deckLink;
		}

		#endregion

		#region IDeckLinkIterator_v8_0

		public static IDeckLink_v8_0 Next(this IDeckLinkIterator_v8_0 deckLinkIterator)
		{
			deckLinkIterator.Next(out IDeckLink_v8_0 deckLink);

			return deckLink;
		}

		#endregion

		#region IDeckLinkMemoryAllocator

		public static IntPtr AllocateBuffer(this IDeckLinkMemoryAllocator deckLinkMemoryAllocator, uint bufferSize)
		{
			deckLinkMemoryAllocator.AllocateBuffer(bufferSize, out IntPtr allocatedBuffer);

			return allocatedBuffer;
		}

		#endregion

		#region IDeckLinkOutput

		public static (BMDDisplayMode actualMode, bool supported) DoesSupportVideoMode(this IDeckLinkOutput deckLinkOutput, BMDVideoConnection connection, BMDDisplayMode requestedMode, BMDPixelFormat requestedPixelFormat, BMDVideoOutputConversionMode conversionMode, BMDSupportedVideoModeFlags flags)
		{
			deckLinkOutput.DoesSupportVideoMode(connection, requestedMode, requestedPixelFormat, conversionMode, flags, out BMDDisplayMode actualMode, out bool supported);

			return (actualMode, supported);
		}

		public static IDeckLinkDisplayMode GetDisplayMode(this IDeckLinkOutput deckLinkOutput, BMDDisplayMode displayMode)
		{
			deckLinkOutput.GetDisplayMode(displayMode, out IDeckLinkDisplayMode resultDisplayMode);

			return resultDisplayMode;
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkOutput deckLinkOutput)
		{
			deckLinkOutput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static IDeckLinkMutableVideoFrame CreateVideoFrame(this IDeckLinkOutput deckLinkOutput, int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags)
		{
			deckLinkOutput.CreateVideoFrame(width, height, rowBytes, pixelFormat, flags, out IDeckLinkMutableVideoFrame outFrame);

			return outFrame;
		}

		public static IDeckLinkVideoFrameAncillary CreateAncillaryData(this IDeckLinkOutput deckLinkOutput, BMDPixelFormat pixelFormat)
		{
			deckLinkOutput.CreateAncillaryData(pixelFormat, out IDeckLinkVideoFrameAncillary outBuffer);

			return outBuffer;
		}

		public static uint GetBufferedVideoFrameCount(this IDeckLinkOutput deckLinkOutput)
		{
			deckLinkOutput.GetBufferedVideoFrameCount(out uint bufferedFrameCount);

			return bufferedFrameCount;
		}

		public static uint WriteAudioSamplesSync(this IDeckLinkOutput deckLinkOutput, IntPtr buffer, uint sampleFrameCount)
		{
			deckLinkOutput.WriteAudioSamplesSync(buffer, sampleFrameCount, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint ScheduleAudioSamples(this IDeckLinkOutput deckLinkOutput, IntPtr buffer, uint sampleFrameCount, long streamTime, long timeScale)
		{
			deckLinkOutput.ScheduleAudioSamples(buffer, sampleFrameCount, streamTime, timeScale, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint GetBufferedAudioSampleFrameCount(this IDeckLinkOutput deckLinkOutput)
		{
			deckLinkOutput.GetBufferedAudioSampleFrameCount(out uint bufferedSampleFrameCount);

			return bufferedSampleFrameCount;
		}

		public static long StopScheduledPlayback(this IDeckLinkOutput deckLinkOutput, long stopPlaybackAtTime, long timeScale)
		{
			deckLinkOutput.StopScheduledPlayback(stopPlaybackAtTime, out long actualStopTime, timeScale);

			return actualStopTime;
		}

		public static bool IsScheduledPlaybackRunning(this IDeckLinkOutput deckLinkOutput)
		{
			deckLinkOutput.IsScheduledPlaybackRunning(out bool active);

			return active;
		}

		public static (long streamTime, double playbackSpeed) GetScheduledStreamTime(this IDeckLinkOutput deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetScheduledStreamTime(desiredTimeScale, out long streamTime, out double playbackSpeed);

			return (streamTime, playbackSpeed);
		}

		public static BMDReferenceStatus GetReferenceStatus(this IDeckLinkOutput deckLinkOutput)
		{
			deckLinkOutput.GetReferenceStatus(out BMDReferenceStatus referenceStatus);

			return referenceStatus;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkOutput deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		public static long GetFrameCompletionReferenceTimestamp(this IDeckLinkOutput deckLinkOutput, IDeckLinkVideoFrame theFrame, long desiredTimeScale)
		{
			deckLinkOutput.GetFrameCompletionReferenceTimestamp(theFrame, desiredTimeScale, out long frameCompletionTimestamp);

			return frameCompletionTimestamp;
		}

		#endregion

		#region IDeckLinkOutput_v10_11

		public static (BMDDisplayModeSupport_v10_11 result, IDeckLinkDisplayMode resultDisplayMode) DoesSupportVideoMode(this IDeckLinkOutput_v10_11 deckLinkOutput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoOutputFlags flags)
		{
			deckLinkOutput.DoesSupportVideoMode(displayMode, pixelFormat, flags, out BMDDisplayModeSupport_v10_11 result, out IDeckLinkDisplayMode resultDisplayMode);

			return (result, resultDisplayMode);
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkOutput_v10_11 deckLinkOutput)
		{
			deckLinkOutput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static IDeckLinkMutableVideoFrame CreateVideoFrame(this IDeckLinkOutput_v10_11 deckLinkOutput, int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags)
		{
			deckLinkOutput.CreateVideoFrame(width, height, rowBytes, pixelFormat, flags, out IDeckLinkMutableVideoFrame outFrame);

			return outFrame;
		}

		public static IDeckLinkVideoFrameAncillary CreateAncillaryData(this IDeckLinkOutput_v10_11 deckLinkOutput, BMDPixelFormat pixelFormat)
		{
			deckLinkOutput.CreateAncillaryData(pixelFormat, out IDeckLinkVideoFrameAncillary outBuffer);

			return outBuffer;
		}

		public static uint GetBufferedVideoFrameCount(this IDeckLinkOutput_v10_11 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedVideoFrameCount(out uint bufferedFrameCount);

			return bufferedFrameCount;
		}

		public static uint WriteAudioSamplesSync(this IDeckLinkOutput_v10_11 deckLinkOutput, IntPtr buffer, uint sampleFrameCount)
		{
			deckLinkOutput.WriteAudioSamplesSync(buffer, sampleFrameCount, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint ScheduleAudioSamples(this IDeckLinkOutput_v10_11 deckLinkOutput, IntPtr buffer, uint sampleFrameCount, long streamTime, long timeScale)
		{
			deckLinkOutput.ScheduleAudioSamples(buffer, sampleFrameCount, streamTime, timeScale, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint GetBufferedAudioSampleFrameCount(this IDeckLinkOutput_v10_11 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedAudioSampleFrameCount(out uint bufferedSampleFrameCount);

			return bufferedSampleFrameCount;
		}

		public static long StopScheduledPlayback(this IDeckLinkOutput_v10_11 deckLinkOutput, long stopPlaybackAtTime, long timeScale)
		{
			deckLinkOutput.StopScheduledPlayback(stopPlaybackAtTime, out long actualStopTime, timeScale);

			return actualStopTime;
		}

		public static bool IsScheduledPlaybackRunning(this IDeckLinkOutput_v10_11 deckLinkOutput)
		{
			deckLinkOutput.IsScheduledPlaybackRunning(out bool active);

			return active;
		}

		public static (long streamTime, double playbackSpeed) GetScheduledStreamTime(this IDeckLinkOutput_v10_11 deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetScheduledStreamTime(desiredTimeScale, out long streamTime, out double playbackSpeed);

			return (streamTime, playbackSpeed);
		}

		public static BMDReferenceStatus GetReferenceStatus(this IDeckLinkOutput_v10_11 deckLinkOutput)
		{
			deckLinkOutput.GetReferenceStatus(out BMDReferenceStatus referenceStatus);

			return referenceStatus;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkOutput_v10_11 deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		public static long GetFrameCompletionReferenceTimestamp(this IDeckLinkOutput_v10_11 deckLinkOutput, IDeckLinkVideoFrame theFrame, long desiredTimeScale)
		{
			deckLinkOutput.GetFrameCompletionReferenceTimestamp(theFrame, desiredTimeScale, out long frameCompletionTimestamp);

			return frameCompletionTimestamp;
		}

		#endregion

		#region IDeckLinkOutput_v11_4

		public static (BMDDisplayMode actualMode, bool supported) DoesSupportVideoMode(this IDeckLinkOutput_v11_4 deckLinkOutput, BMDVideoConnection connection, BMDDisplayMode requestedMode, BMDPixelFormat requestedPixelFormat, BMDSupportedVideoModeFlags flags)
		{
			deckLinkOutput.DoesSupportVideoMode(connection, requestedMode, requestedPixelFormat, flags, out BMDDisplayMode actualMode, out bool supported);

			return (actualMode, supported);
		}

		public static IDeckLinkDisplayMode GetDisplayMode(this IDeckLinkOutput_v11_4 deckLinkOutput, BMDDisplayMode displayMode)
		{
			deckLinkOutput.GetDisplayMode(displayMode, out IDeckLinkDisplayMode resultDisplayMode);

			return resultDisplayMode;
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkOutput_v11_4 deckLinkOutput)
		{
			deckLinkOutput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static IDeckLinkMutableVideoFrame CreateVideoFrame(this IDeckLinkOutput_v11_4 deckLinkOutput, int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags)
		{
			deckLinkOutput.CreateVideoFrame(width, height, rowBytes, pixelFormat, flags, out IDeckLinkMutableVideoFrame outFrame);

			return outFrame;
		}

		public static IDeckLinkVideoFrameAncillary CreateAncillaryData(this IDeckLinkOutput_v11_4 deckLinkOutput, BMDPixelFormat pixelFormat)
		{
			deckLinkOutput.CreateAncillaryData(pixelFormat, out IDeckLinkVideoFrameAncillary outBuffer);

			return outBuffer;
		}

		public static uint GetBufferedVideoFrameCount(this IDeckLinkOutput_v11_4 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedVideoFrameCount(out uint bufferedFrameCount);

			return bufferedFrameCount;
		}

		public static uint WriteAudioSamplesSync(this IDeckLinkOutput_v11_4 deckLinkOutput, IntPtr buffer, uint sampleFrameCount)
		{
			deckLinkOutput.WriteAudioSamplesSync(buffer, sampleFrameCount, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint ScheduleAudioSamples(this IDeckLinkOutput_v11_4 deckLinkOutput, IntPtr buffer, uint sampleFrameCount, long streamTime, long timeScale)
		{
			deckLinkOutput.ScheduleAudioSamples(buffer, sampleFrameCount, streamTime, timeScale, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint GetBufferedAudioSampleFrameCount(this IDeckLinkOutput_v11_4 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedAudioSampleFrameCount(out uint bufferedSampleFrameCount);

			return bufferedSampleFrameCount;
		}

		public static long StopScheduledPlayback(this IDeckLinkOutput_v11_4 deckLinkOutput, long stopPlaybackAtTime, long timeScale)
		{
			deckLinkOutput.StopScheduledPlayback(stopPlaybackAtTime, out long actualStopTime, timeScale);

			return actualStopTime;
		}

		public static bool IsScheduledPlaybackRunning(this IDeckLinkOutput_v11_4 deckLinkOutput)
		{
			deckLinkOutput.IsScheduledPlaybackRunning(out bool active);

			return active;
		}

		public static (long streamTime, double playbackSpeed) GetScheduledStreamTime(this IDeckLinkOutput_v11_4 deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetScheduledStreamTime(desiredTimeScale, out long streamTime, out double playbackSpeed);

			return (streamTime, playbackSpeed);
		}

		public static BMDReferenceStatus GetReferenceStatus(this IDeckLinkOutput_v11_4 deckLinkOutput)
		{
			deckLinkOutput.GetReferenceStatus(out BMDReferenceStatus referenceStatus);

			return referenceStatus;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkOutput_v11_4 deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		public static long GetFrameCompletionReferenceTimestamp(this IDeckLinkOutput_v11_4 deckLinkOutput, IDeckLinkVideoFrame theFrame, long desiredTimeScale)
		{
			deckLinkOutput.GetFrameCompletionReferenceTimestamp(theFrame, desiredTimeScale, out long frameCompletionTimestamp);

			return frameCompletionTimestamp;
		}

		#endregion

		#region IDeckLinkOutput_v7_1

		public static BMDDisplayModeSupport_v10_11 DoesSupportVideoMode(this IDeckLinkOutput_v7_1 deckLinkOutput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat)
		{
			deckLinkOutput.DoesSupportVideoMode(displayMode, pixelFormat, out BMDDisplayModeSupport_v10_11 result);

			return result;
		}

		public static IDeckLinkDisplayModeIterator_v7_1 GetDisplayModeIterator(this IDeckLinkOutput_v7_1 deckLinkOutput)
		{
			deckLinkOutput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator_v7_1 displayModeIterator);

			return displayModeIterator;
		}

		public static uint WriteAudioSamplesSync(this IDeckLinkOutput_v7_1 deckLinkOutput, IntPtr buffer, uint sampleFrameCount)
		{
			deckLinkOutput.WriteAudioSamplesSync(buffer, sampleFrameCount, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint ScheduleAudioSamples(this IDeckLinkOutput_v7_1 deckLinkOutput, IntPtr buffer, uint sampleFrameCount, long streamTime, long timeScale)
		{
			deckLinkOutput.ScheduleAudioSamples(buffer, sampleFrameCount, streamTime, timeScale, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint GetBufferedAudioSampleFrameCount(this IDeckLinkOutput_v7_1 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedAudioSampleFrameCount(out uint bufferedSampleCount);

			return bufferedSampleCount;
		}

		#endregion

		#region IDeckLinkOutput_v7_3

		public static BMDDisplayModeSupport_v10_11 DoesSupportVideoMode(this IDeckLinkOutput_v7_3 deckLinkOutput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat)
		{
			deckLinkOutput.DoesSupportVideoMode(displayMode, pixelFormat, out BMDDisplayModeSupport_v10_11 result);

			return result;
		}

		public static IDeckLinkDisplayModeIterator_v7_6 GetDisplayModeIterator(this IDeckLinkOutput_v7_3 deckLinkOutput)
		{
			deckLinkOutput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator_v7_6 displayModeIterator);

			return displayModeIterator;
		}

		public static IDeckLinkMutableVideoFrame_v7_6 CreateVideoFrame(this IDeckLinkOutput_v7_3 deckLinkOutput, int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags)
		{
			deckLinkOutput.CreateVideoFrame(width, height, rowBytes, pixelFormat, flags, out IDeckLinkMutableVideoFrame_v7_6 outFrame);

			return outFrame;
		}


		public static IDeckLinkVideoFrameAncillary CreateAncillaryData(this IDeckLinkOutput_v7_3 deckLinkOutput, BMDPixelFormat pixelFormat)
		{
			deckLinkOutput.CreateAncillaryData(pixelFormat, out IDeckLinkVideoFrameAncillary outBuffer);

			return outBuffer;
		}

		public static uint GetBufferedVideoFrameCount(this IDeckLinkOutput_v7_3 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedVideoFrameCount(out uint bufferedFrameCount);

			return bufferedFrameCount;
		}

		public static uint WriteAudioSamplesSync(this IDeckLinkOutput_v7_3 deckLinkOutput, IntPtr buffer, uint sampleFrameCount)
		{
			deckLinkOutput.WriteAudioSamplesSync(buffer, sampleFrameCount, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint ScheduleAudioSamples(this IDeckLinkOutput_v7_3 deckLinkOutput, IntPtr buffer, uint sampleFrameCount, long streamTime, long timeScale)
		{
			deckLinkOutput.ScheduleAudioSamples(buffer, sampleFrameCount, streamTime, timeScale, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint GetBufferedAudioSampleFrameCount(this IDeckLinkOutput_v7_3 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedAudioSampleFrameCount(out uint bufferedSampleFrameCount);

			return bufferedSampleFrameCount;
		}

		public static long StopScheduledPlayback(this IDeckLinkOutput_v7_3 deckLinkOutput, long stopPlaybackAtTime, long timeScale)
		{
			deckLinkOutput.StopScheduledPlayback(stopPlaybackAtTime, out long actualStopTime, timeScale);

			return actualStopTime;
		}

		public static bool IsScheduledPlaybackRunning(this IDeckLinkOutput_v7_3 deckLinkOutput)
		{
			deckLinkOutput.IsScheduledPlaybackRunning(out bool active);

			return active;
		}

		public static long GetHardwareReferenceClock(this IDeckLinkOutput_v7_3 deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetHardwareReferenceClock(desiredTimeScale, out long elapsedTimeSinceSchedulerBegan);

			return elapsedTimeSinceSchedulerBegan;
		}

		#endregion

		#region IDeckLinkOutput_v7_6

		public static BMDDisplayModeSupport_v10_11 DoesSupportVideoMode(this IDeckLinkOutput_v7_6 deckLinkOutput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat)
		{
			deckLinkOutput.DoesSupportVideoMode(displayMode, pixelFormat, out BMDDisplayModeSupport_v10_11 result);

			return result;
		}

		public static IDeckLinkDisplayModeIterator_v7_6 GetDisplayModeIterator(this IDeckLinkOutput_v7_6 deckLinkOutput)
		{
			deckLinkOutput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator_v7_6 displayModeIterator);

			return displayModeIterator;
		}

		public static IDeckLinkMutableVideoFrame_v7_6 CreateVideoFrame(this IDeckLinkOutput_v7_6 deckLinkOutput, int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags)
		{
			deckLinkOutput.CreateVideoFrame(width, height, rowBytes, pixelFormat, flags, out IDeckLinkMutableVideoFrame_v7_6 outFrame);

			return outFrame;
		}

		public static IDeckLinkVideoFrameAncillary CreateAncillaryData(this IDeckLinkOutput_v7_6 deckLinkOutput, BMDPixelFormat pixelFormat)
		{
			deckLinkOutput.CreateAncillaryData(pixelFormat, out IDeckLinkVideoFrameAncillary outBuffer);

			return outBuffer;
		}

		public static uint GetBufferedVideoFrameCount(this IDeckLinkOutput_v7_6 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedVideoFrameCount(out uint bufferedFrameCount);

			return bufferedFrameCount;
		}

		public static uint WriteAudioSamplesSync(this IDeckLinkOutput_v7_6 deckLinkOutput, IntPtr buffer, uint sampleFrameCount)
		{
			deckLinkOutput.WriteAudioSamplesSync(buffer, sampleFrameCount, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint ScheduleAudioSamples(this IDeckLinkOutput_v7_6 deckLinkOutput, IntPtr buffer, uint sampleFrameCount, long streamTime, long timeScale)
		{
			deckLinkOutput.ScheduleAudioSamples(buffer, sampleFrameCount, streamTime, timeScale, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint GetBufferedAudioSampleFrameCount(this IDeckLinkOutput_v7_6 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedAudioSampleFrameCount(out uint bufferedSampleFrameCount);

			return bufferedSampleFrameCount;
		}

		public static long StopScheduledPlayback(this IDeckLinkOutput_v7_6 deckLinkOutput, long stopPlaybackAtTime, long timeScale)
		{
			deckLinkOutput.StopScheduledPlayback(stopPlaybackAtTime, out long actualStopTime, timeScale);

			return actualStopTime;
		}

		public static bool IsScheduledPlaybackRunning(this IDeckLinkOutput_v7_6 deckLinkOutput)
		{
			deckLinkOutput.IsScheduledPlaybackRunning(out bool active);

			return active;
		}

		public static (long streamTime, double playbackSpeed) GetScheduledStreamTime(this IDeckLinkOutput_v7_6 deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetScheduledStreamTime(desiredTimeScale, out long streamTime, out double playbackSpeed);

			return (streamTime, playbackSpeed);
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkOutput_v7_6 deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkOutput_v9_9

		public static (BMDDisplayModeSupport_v10_11 result, IDeckLinkDisplayMode resultDisplayMode) DoesSupportVideoMode(this IDeckLinkOutput_v9_9 deckLinkOutput, BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoOutputFlags flags)
		{
			deckLinkOutput.DoesSupportVideoMode(displayMode, pixelFormat, flags, out BMDDisplayModeSupport_v10_11 result, out IDeckLinkDisplayMode resultDisplayMode);

			return (result, resultDisplayMode);
		}

		public static IDeckLinkDisplayModeIterator GetDisplayModeIterator(this IDeckLinkOutput_v9_9 deckLinkOutput)
		{
			deckLinkOutput.GetDisplayModeIterator(out IDeckLinkDisplayModeIterator displayModeIterator);

			return displayModeIterator;
		}

		public static IDeckLinkMutableVideoFrame CreateVideoFrame(this IDeckLinkOutput_v9_9 deckLinkOutput, int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags)
		{
			deckLinkOutput.CreateVideoFrame(width, height, rowBytes, pixelFormat, flags, out IDeckLinkMutableVideoFrame outFrame);

			return outFrame;
		}

		public static IDeckLinkVideoFrameAncillary CreateAncillaryData(this IDeckLinkOutput_v9_9 deckLinkOutput, BMDPixelFormat pixelFormat)
		{
			deckLinkOutput.CreateAncillaryData(pixelFormat, out IDeckLinkVideoFrameAncillary outBuffer);

			return outBuffer;
		}

		public static uint GetBufferedVideoFrameCount(this IDeckLinkOutput_v9_9 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedVideoFrameCount(out uint bufferedFrameCount);

			return bufferedFrameCount;
		}

		public static uint WriteAudioSamplesSync(this IDeckLinkOutput_v9_9 deckLinkOutput, IntPtr buffer, uint sampleFrameCount)
		{
			deckLinkOutput.WriteAudioSamplesSync(buffer, sampleFrameCount, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint ScheduleAudioSamples(this IDeckLinkOutput_v9_9 deckLinkOutput, IntPtr buffer, uint sampleFrameCount, long streamTime, long timeScale)
		{
			deckLinkOutput.ScheduleAudioSamples(buffer, sampleFrameCount, streamTime, timeScale, out uint sampleFramesWritten);

			return sampleFramesWritten;
		}

		public static uint GetBufferedAudioSampleFrameCount(this IDeckLinkOutput_v9_9 deckLinkOutput)
		{
			deckLinkOutput.GetBufferedAudioSampleFrameCount(out uint bufferedSampleFrameCount);

			return bufferedSampleFrameCount;
		}

		public static long StopScheduledPlayback(this IDeckLinkOutput_v9_9 deckLinkOutput, long stopPlaybackAtTime, long timeScale)
		{
			deckLinkOutput.StopScheduledPlayback(stopPlaybackAtTime, out long actualStopTime, timeScale);

			return actualStopTime;
		}

		public static bool IsScheduledPlaybackRunning(this IDeckLinkOutput_v9_9 deckLinkOutput)
		{
			deckLinkOutput.IsScheduledPlaybackRunning(out bool active);

			return active;
		}

		public static (long streamTime, double playbackSpeed) GetScheduledStreamTime(this IDeckLinkOutput_v9_9 deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetScheduledStreamTime(desiredTimeScale, out long streamTime, out double playbackSpeed);

			return (streamTime, playbackSpeed);
		}

		public static BMDReferenceStatus GetReferenceStatus(this IDeckLinkOutput_v9_9 deckLinkOutput)
		{
			deckLinkOutput.GetReferenceStatus(out BMDReferenceStatus referenceStatus);

			return referenceStatus;
		}

		public static (long hardwareTime, long timeInFrame, long ticksPerFrame) GetHardwareReferenceClock(this IDeckLinkOutput_v9_9 deckLinkOutput, long desiredTimeScale)
		{
			deckLinkOutput.GetHardwareReferenceClock(desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);

			return (hardwareTime, timeInFrame, ticksPerFrame);
		}

		#endregion

		#region IDeckLinkProfile

		public static IDeckLink GetDevice(this IDeckLinkProfile deckLinkProfile)
		{
			deckLinkProfile.GetDevice(out IDeckLink device);

			return device;
		}

		public static bool IsActive(this IDeckLinkProfile deckLinkProfile)
		{
			deckLinkProfile.IsActive(out bool isActive);

			return isActive;
		}

		public static IDeckLinkProfileIterator GetPeers(this IDeckLinkProfile deckLinkProfile)
		{
			deckLinkProfile.GetPeers(out IDeckLinkProfileIterator profileIterator);

			return profileIterator;
		}

		#endregion

		#region IDeckLinkProfileAttributes

		public static bool GetFlag(this IDeckLinkProfileAttributes profileAttributes, BMDDeckLinkAttributeID cfgID)
		{
			profileAttributes.GetFlag(cfgID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkProfileAttributes profileAttributes, BMDDeckLinkAttributeID cfgID)
		{
			profileAttributes.GetInt(cfgID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkProfileAttributes profileAttributes, BMDDeckLinkAttributeID cfgID) where T : Enum
		{
			profileAttributes.GetInt(cfgID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkProfileAttributes profileAttributes, BMDDeckLinkAttributeID cfgID)
		{
			profileAttributes.GetFloat(cfgID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkProfileAttributes profileAttributes, BMDDeckLinkAttributeID cfgID)
		{
			profileAttributes.GetString(cfgID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkProfileIterator

		public static IDeckLinkProfile Next(this IDeckLinkProfileIterator profileIterator)
		{
			profileIterator.Next(out IDeckLinkProfile profile);

			return profile;
		}

		#endregion

		#region IDeckLinkProfileManager

		public static IDeckLinkProfileIterator GetProfiles(this IDeckLinkProfileManager profileManager)
		{
			profileManager.GetProfiles(out IDeckLinkProfileIterator profileIterator);

			return profileIterator;
		}

		public static IDeckLinkProfile GetProfile(this IDeckLinkProfileManager profileManager, BMDProfileID profileID)
		{
			profileManager.GetProfile(profileID, out IDeckLinkProfile profile);

			return profile;
		}

		#endregion

		#region IDeckLinkStatistics

		public static long GetInt(this IDeckLinkStatistics deckLinkStatistics, BMDDeckLinkStatisticID statID)
		{
			deckLinkStatistics.GetInt(statID, out long value);

			return value;
		}

		#endregion

		#region IDeckLinkStatus

		public static bool GetFlag(this IDeckLinkStatus deckLinkStatus, BMDDeckLinkStatusID statusID)
		{
			deckLinkStatus.GetFlag(statusID, out bool value);

			return value;
		}

		public static long GetInt(this IDeckLinkStatus deckLinkStatus, BMDDeckLinkStatusID statusID)
		{
			deckLinkStatus.GetInt(statusID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkStatus deckLinkStatus, BMDDeckLinkStatusID statusID) where T : Enum
		{
			deckLinkStatus.GetInt(statusID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkStatus deckLinkStatus, BMDDeckLinkStatusID statusID)
		{
			deckLinkStatus.GetFloat(statusID, out double value);

			return value;
		}

		public static string GetString(this IDeckLinkStatus deckLinkStatus, BMDDeckLinkStatusID statusID)
		{
			deckLinkStatus.GetString(statusID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkTimecode

		public static (byte hours, byte minutes, byte seconds, byte frames) GetComponents(this IDeckLinkTimecode timecode)
		{
			timecode.GetComponents(out byte hours, out byte minutes, out byte seconds, out byte frames);

			return (hours, minutes, seconds, frames);
		}

		public static string GetString(this IDeckLinkTimecode timecode)
		{
			timecode.GetString(out string timecodeStr);

			return timecodeStr;
		}

		public static uint GetTimecodeUserBits(this IDeckLinkTimecode timecode)
		{
			timecode.GetTimecodeUserBits(out uint userBits);

			return userBits;
		}

		#endregion

		#region IDeckLinkTimecode_v7_6

		public static (byte hours, byte minutes, byte seconds, byte frames) GetComponents(this IDeckLinkTimecode_v7_6 timecode)
		{
			timecode.GetComponents(out byte hours, out byte minutes, out byte seconds, out byte frames);

			return (hours, minutes, seconds, frames);
		}

		public static string GetString(this IDeckLinkTimecode_v7_6 timecode)
		{
			timecode.GetString(out string timecodeStr);

			return timecodeStr;
		}

		#endregion

		#region IDeckLinkVideoFrame

		public static IntPtr GetBytes(this IDeckLinkVideoFrame videoFrame)
		{
			videoFrame.GetBytes(out IntPtr buffer);

			return buffer;
		}

		public static ReadOnlySpan<byte> GetBytesSpan(this IDeckLinkVideoFrame videoFrame)
		{
			IntPtr buffer = videoFrame.GetBytes();

			unsafe
			{
				return new ReadOnlySpan<byte>(buffer.ToPointer(), videoFrame.GetRowBytes() * videoFrame.GetHeight());
			}
		}

		public static IDeckLinkTimecode GetTimecode(this IDeckLinkVideoFrame videoFrame, BMDTimecodeFormat format)
		{
			videoFrame.GetTimecode(format, out IDeckLinkTimecode timecode);

			return timecode;
		}

		public static IDeckLinkVideoFrameAncillary GetAncillaryData(this IDeckLinkVideoFrame videoFrame)
		{
			videoFrame.GetAncillaryData(out IDeckLinkVideoFrameAncillary ancillary);

			return ancillary;
		}

		#endregion

		#region IDeckLinkVideoFrame_v7_6

		public static IntPtr GetBytes(this IDeckLinkVideoFrame_v7_6 videoFrame)
		{
			videoFrame.GetBytes(out IntPtr buffer);

			return buffer;
		}

		public static ReadOnlySpan<byte> GetBytesSpan(this IDeckLinkVideoFrame_v7_6 videoFrame)
		{
			IntPtr buffer = videoFrame.GetBytes();

			unsafe
			{
				return new ReadOnlySpan<byte>(buffer.ToPointer(), videoFrame.GetRowBytes() * videoFrame.GetHeight());
			}
		}

		public static IDeckLinkTimecode_v7_6 GetTimecode(this IDeckLinkVideoFrame_v7_6 videoFrame, BMDTimecodeFormat format)
		{
			videoFrame.GetTimecode(format, out IDeckLinkTimecode_v7_6 timecode);

			return timecode;
		}

		public static IDeckLinkVideoFrameAncillary GetAncillaryData(this IDeckLinkVideoFrame_v7_6 videoFrame)
		{
			videoFrame.GetAncillaryData(out IDeckLinkVideoFrameAncillary ancillary);

			return ancillary;
		}

		#endregion

		#region IDeckLinkVideoFrame3DExtensions

		public static IDeckLinkVideoFrame GetFrameForRightEye(this IDeckLinkVideoFrame3DExtensions videoFrame3DExtensions)
		{
			videoFrame3DExtensions.GetFrameForRightEye(out IDeckLinkVideoFrame rightEyeFrame);

			return rightEyeFrame;
		}

		#endregion

		#region IDeckLinkVideoFrameAncillary

		public static IntPtr GetBufferForVerticalBlankingLine(this IDeckLinkVideoFrameAncillary videoFrameAncillary, uint lineNumber)
		{
			videoFrameAncillary.GetBufferForVerticalBlankingLine(lineNumber, out IntPtr buffer);

			return buffer;
		}

		#endregion

		#region IDeckLinkVideoFrameAncillaryPackets

		public static IDeckLinkAncillaryPacketIterator GetPacketIterator(this IDeckLinkVideoFrameAncillaryPackets videoFrameAncillaryPackets)
		{
			videoFrameAncillaryPackets.GetPacketIterator(out IDeckLinkAncillaryPacketIterator iterator);

			return iterator;
		}

		public static IDeckLinkAncillaryPacket GetFirstPacketByID(this IDeckLinkVideoFrameAncillaryPackets videoFrameAncillaryPackets, byte DID, byte SDID)
		{
			videoFrameAncillaryPackets.GetFirstPacketByID(DID, SDID, out IDeckLinkAncillaryPacket packet);

			return packet;
		}

		#endregion

		#region IDeckLinkVideoFrameMetadataExtensions

		public static long GetInt(this IDeckLinkVideoFrameMetadataExtensions videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID metadataID)
		{
			videoFrameMetadataExtensions.GetInt(metadataID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkVideoFrameMetadataExtensions videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID metadataID) where T : Enum
		{
			videoFrameMetadataExtensions.GetInt(metadataID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkVideoFrameMetadataExtensions videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID metadataID)
		{
			videoFrameMetadataExtensions.GetFloat(metadataID, out double value);

			return value;
		}

		public static bool GetFlag(this IDeckLinkVideoFrameMetadataExtensions videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID metadataID)
		{
			videoFrameMetadataExtensions.GetFlag(metadataID, out bool value);

			return value;
		}

		public static string GetString(this IDeckLinkVideoFrameMetadataExtensions videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID metadataID)
		{
			videoFrameMetadataExtensions.GetString(metadataID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkVideoFrameMetadataExtensions_v11_5

		public static long GetInt(this IDeckLinkVideoFrameMetadataExtensions_v11_5 videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID_v11_5 metadataID)
		{
			videoFrameMetadataExtensions.GetInt(metadataID, out long value);

			return value;
		}

		public static T GetEnum<T>(this IDeckLinkVideoFrameMetadataExtensions_v11_5 videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID_v11_5 metadataID) where T : Enum
		{
			videoFrameMetadataExtensions.GetInt(metadataID, out long value);

			return (T)Enum.ToObject(typeof(T), value);
		}

		public static double GetFloat(this IDeckLinkVideoFrameMetadataExtensions_v11_5 videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID_v11_5 metadataID)
		{
			videoFrameMetadataExtensions.GetFloat(metadataID, out double value);

			return value;
		}

		public static bool GetFlag(this IDeckLinkVideoFrameMetadataExtensions_v11_5 videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID_v11_5 metadataID)
		{
			videoFrameMetadataExtensions.GetFlag(metadataID, out bool value);

			return value;
		}

		public static string GetString(this IDeckLinkVideoFrameMetadataExtensions_v11_5 videoFrameMetadataExtensions, BMDDeckLinkFrameMetadataID_v11_5 metadataID)
		{
			videoFrameMetadataExtensions.GetString(metadataID, out string value);

			return value;
		}

		#endregion

		#region IDeckLinkVideoInputFrame

		public static (long frameTime, long frameDuration) GetStreamTime(this IDeckLinkVideoInputFrame videoFrame, long timeScale)
		{
			videoFrame.GetStreamTime(out long frameTime, out long frameDuration, timeScale);

			return (frameTime, frameDuration);
		}

		public static (long frameTime, long frameDuration) GetHardwareReferenceTimestamp(this IDeckLinkVideoInputFrame videoFrame, long timeScale)
		{
			videoFrame.GetHardwareReferenceTimestamp(timeScale, out long frameTime, out long frameDuration);

			return (frameTime, frameDuration);
		}

		#endregion

		#region IDeckLinkVideoInputFrame_v7_3

		public static (long frameTime, long frameDuration) GetStreamTime(this IDeckLinkVideoInputFrame_v7_3 videoFrame, long timeScale)
		{
			videoFrame.GetStreamTime(out long frameTime, out long frameDuration, timeScale);

			return (frameTime, frameDuration);
		}

		#endregion

		#region IDeckLinkVideoInputFrame_v7_6

		public static (long frameTime, long frameDuration) GetStreamTime(this IDeckLinkVideoInputFrame_v7_6 videoFrame, long timeScale)
		{
			videoFrame.GetStreamTime(out long frameTime, out long frameDuration, timeScale);

			return (frameTime, frameDuration);
		}

		public static (long frameTime, long frameDuration) GetHardwareReferenceTimestamp(this IDeckLinkVideoInputFrame_v7_6 videoFrame, long timeScale)
		{
			videoFrame.GetHardwareReferenceTimestamp(timeScale, out long frameTime, out long frameDuration);

			return (frameTime, frameDuration);
		}

		#endregion

		#region IDeckLinkWPFDX9ScreenPreviewHelper

		public static IntPtr GetBackBuffer(this IDeckLinkWPFDX9ScreenPreviewHelper deckLinkWPFDX9ScreenPreviewHelper)
		{
			deckLinkWPFDX9ScreenPreviewHelper.GetBackBuffer(out IntPtr backBuffer);

			return backBuffer;
		}

		#endregion
	}
}
