using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9434C6E4-B15D-4B1C-979E-661E3DDCB4B9")]
	public partial interface IDeckLinkInput_v11_5_1
	{
		void DoesSupportVideoMode(BMDVideoConnection connection, BMDDisplayMode requestedMode, BMDPixelFormat requestedPixelFormat, BMDVideoInputConversionMode conversionMode, BMDSupportedVideoModeFlags flags, out BMDDisplayMode actualMode, [MarshalAs(UnmanagedType.Bool)] out bool supported);

		void GetDisplayMode(BMDDisplayMode displayMode, out IDeckLinkDisplayMode resultDisplayMode);

		void GetDisplayModeIterator(out IDeckLinkDisplayModeIterator iterator);

		void SetScreenPreviewCallback(IDeckLinkScreenPreviewCallback previewCallback);

		void EnableVideoInput(BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoInputFlags flags);

		void DisableVideoInput();

		void GetAvailableVideoFrameCount(out uint availableFrameCount);

		void SetVideoInputFrameMemoryAllocator(IDeckLinkMemoryAllocator theAllocator);

		void EnableAudioInput(BMDAudioSampleRate sampleRate, BMDAudioSampleType sampleType, uint channelCount);

		void DisableAudioInput();

		void GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount);

		void StartStreams();

		void StopStreams();

		void PauseStreams();

		void FlushStreams();

		void SetCallback(IDeckLinkInputCallback_v11_5_1 theCallback);

		void GetHardwareReferenceClock(long desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);
	}
}