using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("C21CDB6E-F414-46E4-A636-80A566E0ED37")]
	public partial interface IDeckLinkInput
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

		void SetCallback(IDeckLinkInputCallback theCallback);

		void GetHardwareReferenceClock(long desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);
	}
}