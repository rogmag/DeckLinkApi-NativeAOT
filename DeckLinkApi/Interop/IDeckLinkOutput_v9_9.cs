using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("A3EF0963-0862-44ED-92A9-EE89ABF431C7")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkOutput_v9_9
	{
		void DoesSupportVideoMode(BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoOutputFlags flags, out BMDDisplayModeSupport_v10_11 result, out IDeckLinkDisplayMode resultDisplayMode);

		void GetDisplayModeIterator(out IDeckLinkDisplayModeIterator iterator);

		void SetScreenPreviewCallback(IDeckLinkScreenPreviewCallback previewCallback);

		void EnableVideoOutput(BMDDisplayMode displayMode, BMDVideoOutputFlags flags);

		void DisableVideoOutput();

		void SetVideoOutputFrameMemoryAllocator(IDeckLinkMemoryAllocator theAllocator);

		void CreateVideoFrame(int width, int height, int rowBytes, BMDPixelFormat pixelFormat, BMDFrameFlags flags, out IDeckLinkMutableVideoFrame outFrame);

		void CreateAncillaryData(BMDPixelFormat pixelFormat, out IDeckLinkVideoFrameAncillary outBuffer);

		void DisplayVideoFrameSync(IDeckLinkVideoFrame theFrame);

		void ScheduleVideoFrame(IDeckLinkVideoFrame theFrame, long displayTime, long displayDuration, long timeScale);

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

		void GetScheduledStreamTime(long desiredTimeScale, out long streamTime, out double playbackSpeed);

		void GetReferenceStatus(out BMDReferenceStatus referenceStatus);

		void GetHardwareReferenceClock(long desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame);
	}
}