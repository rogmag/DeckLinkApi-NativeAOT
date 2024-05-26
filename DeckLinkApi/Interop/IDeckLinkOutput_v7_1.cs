using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("AE5B3E9B-4E1E-4535-B6E8-480FF52F6CE5")]
	public partial interface IDeckLinkOutput_v7_1
	{
		void DoesSupportVideoMode(BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, out BMDDisplayModeSupport_v10_11 result);

		void GetDisplayModeIterator(out IDeckLinkDisplayModeIterator_v7_1 iterator);

		void EnableVideoOutput(BMDDisplayMode displayMode);

		void DisableVideoOutput();

		void SetVideoOutputFrameMemoryAllocator(IDeckLinkMemoryAllocator theAllocator);

		void CreateVideoFrame(int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags, ref IDeckLinkVideoFrame_v7_1 outFrame);

		void CreateVideoFrameFromBuffer(IntPtr buffer, int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags, ref IDeckLinkVideoFrame_v7_1 outFrame);

		void DisplayVideoFrameSync(IDeckLinkVideoFrame_v7_1 theFrame);

		void ScheduleVideoFrame(IDeckLinkVideoFrame_v7_1 theFrame, long displayTime, long displayDuration, long timeScale);

		void SetScheduledFrameCompletionCallback(IDeckLinkVideoOutputCallback_v7_1 theCallback);

		void EnableAudioOutput(BMDAudioSampleRate sampleRate, BMDAudioSampleType sampleType, uint channelCount);

		void DisableAudioOutput();

		void WriteAudioSamplesSync(IntPtr buffer, uint sampleFrameCount, out uint sampleFramesWritten);

		void BeginAudioPreroll();

		void EndAudioPreroll();

		void ScheduleAudioSamples(IntPtr buffer, uint sampleFrameCount, long streamTime, long timeScale, out uint sampleFramesWritten);

		void GetBufferedAudioSampleFrameCount(out uint bufferedSampleCount);

		void FlushBufferedAudioSamples();

		void SetAudioCallback(IDeckLinkAudioOutputCallback theCallback);

		void StartScheduledPlayback(long playbackStartTime, long timeScale, double playbackSpeed);

		void StopScheduledPlayback(long stopPlaybackAtTime, ref long actualStopTime, long timeScale);

		void GetHardwareReferenceClock(long desiredTimeScale, ref long elapsedTimeSinceSchedulerBegan);
	}
}