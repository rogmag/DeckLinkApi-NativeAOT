using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("AF22762B-DFAC-4846-AA79-FA8883560995")]
	public partial interface IDeckLinkInput_v10_11
	{
		void DoesSupportVideoMode(BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoInputFlags flags, out BMDDisplayModeSupport_v10_11 result, out IDeckLinkDisplayMode resultDisplayMode);

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