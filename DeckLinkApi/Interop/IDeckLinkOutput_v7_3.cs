using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("271C65E3-C323-4344-A30F-D908BCB20AA3")]
	public partial interface IDeckLinkOutput_v7_3
	{
		void DoesSupportVideoMode(BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, out BMDDisplayModeSupport_v10_11 result);

		void GetDisplayModeIterator(out IDeckLinkDisplayModeIterator_v7_6 iterator);

		void SetScreenPreviewCallback(IDeckLinkScreenPreviewCallback previewCallback);

		void EnableVideoOutput(BMDDisplayMode displayMode, BMDVideoOutputFlags flags);

		void DisableVideoOutput();

		void SetVideoOutputFrameMemoryAllocator(IDeckLinkMemoryAllocator theAllocator);

		void CreateVideoFrame(int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags, out IDeckLinkMutableVideoFrame_v7_6 outFrame);

		void CreateAncillaryData(BMDPixelFormat pixelFormat, out IDeckLinkVideoFrameAncillary outBuffer);

		void DisplayVideoFrameSync(IDeckLinkVideoFrame_v7_6 theFrame);

		void ScheduleVideoFrame(IDeckLinkVideoFrame_v7_6 theFrame, long displayTime, long displayDuration, long timeScale);

		void SetScheduledFrameCompletionCallback(IDeckLinkVideoOutputCallback theCallback);

		void GetBufferedVideoFrameCount(out uint bufferedFrameCount);

		void EnableAudioOutput(BMDAudioSampleRate sampleRate, BMDAudioSampleType sampleType, uint channelCount, BMDAudioOutputStreamType streamType);

		void DisableAudioOutput();

		void WriteAudioSamplesSync(IntPtr buffer, uint sampleFrameCount, out uint sampleFramesWritten);

		void BeginAudioPreroll();

		void EndAudioPreroll();

		void ScheduleAudioSamples(IntPtr buffer, uint sampleFrameCount, long streamTime, long timeScale, out uint sampleFramesWritten);

		void GetBufferedAudioSampleFrameCount(out uint bufferedSampleFrameCount);

		void FlushBufferedAudioSamples();

		void SetAudioCallback(IDeckLinkAudioOutputCallback theCallback);

		void StartScheduledPlayback(long playbackStartTime, long timeScale, double playbackSpeed);

		void StopScheduledPlayback(long stopPlaybackAtTime, out long actualStopTime, long timeScale);

		void IsScheduledPlaybackRunning([MarshalAs(UnmanagedType.Bool)] out bool active);

		void GetHardwareReferenceClock(long desiredTimeScale, out long elapsedTimeSinceSchedulerBegan);
	}
}