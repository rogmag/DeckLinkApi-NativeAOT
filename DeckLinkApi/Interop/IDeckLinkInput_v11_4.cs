using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2A88CF76-F494-4216-A7EF-DC74EEB83882")]
	public partial interface IDeckLinkInput_v11_4
	{
		void DoesSupportVideoMode(BMDVideoConnection connection, BMDDisplayMode requestedMode, BMDPixelFormat requestedPixelFormat, BMDSupportedVideoModeFlags flags, [MarshalAs(UnmanagedType.Bool)] out bool supported);

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