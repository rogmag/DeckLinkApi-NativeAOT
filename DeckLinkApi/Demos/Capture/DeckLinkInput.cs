using DeckLinkApi.Interop;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Demos.Capture
{
	[GeneratedComClass]
	public partial class DeckLinkInput : IDeckLinkInput, IDeckLinkInputCallback
	{
		public event EventHandler<InputFormatChangedEventArgs>? FormatChanged;
		public event EventHandler<VideoFrameArrivedEventArgs>? FrameArrived;
		private readonly IDeckLinkInput deckLinkInput;

		public DeckLinkInput(IDeckLink deckLink)
		{
			deckLinkInput = (IDeckLinkInput)deckLink;
		}

		public void SetCallback()
		{
			deckLinkInput.SetCallback(this);
		}

		#region IDeckLinkInput

		public void DoesSupportVideoMode(BMDVideoConnection connection, BMDDisplayMode requestedMode, BMDPixelFormat requestedPixelFormat, BMDVideoInputConversionMode conversionMode, BMDSupportedVideoModeFlags flags, out BMDDisplayMode actualMode, out bool supported)
		{
			deckLinkInput.DoesSupportVideoMode(connection, requestedMode, requestedPixelFormat, conversionMode, flags, out actualMode, out supported);
		}

		public void GetDisplayMode(BMDDisplayMode displayMode, out IDeckLinkDisplayMode resultDisplayMode)
		{
			deckLinkInput.GetDisplayMode(displayMode, out resultDisplayMode);
		}

		public void GetDisplayModeIterator(out IDeckLinkDisplayModeIterator iterator)
		{
			deckLinkInput.GetDisplayModeIterator(out iterator);
		}

		public void SetScreenPreviewCallback(IDeckLinkScreenPreviewCallback previewCallback)
		{
			deckLinkInput.SetScreenPreviewCallback(previewCallback);
		}

		public void EnableVideoInput(BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoInputFlags flags)
		{
			deckLinkInput.EnableVideoInput(displayMode, pixelFormat, flags);
		}

		public void DisableVideoInput()
		{
			deckLinkInput.DisableVideoInput();
		}

		public void GetAvailableVideoFrameCount(out uint availableFrameCount)
		{
			deckLinkInput.GetAvailableVideoFrameCount(out availableFrameCount);
		}

		public void SetVideoInputFrameMemoryAllocator(IDeckLinkMemoryAllocator theAllocator)
		{
			deckLinkInput.SetVideoInputFrameMemoryAllocator(theAllocator);
		}

		public void EnableAudioInput(BMDAudioSampleRate sampleRate, BMDAudioSampleType sampleType, uint channelCount)
		{
			deckLinkInput.EnableAudioInput(sampleRate, sampleType, channelCount);
		}

		public void DisableAudioInput()
		{
			deckLinkInput.DisableAudioInput();
		}

		public void GetAvailableAudioSampleFrameCount(out uint availableSampleFrameCount)
		{
			deckLinkInput.GetAvailableAudioSampleFrameCount(out availableSampleFrameCount);
		}

		public void StartStreams()
		{
			deckLinkInput.StartStreams();
		}

		public void StopStreams()
		{
			deckLinkInput.StopStreams();
		}

		public void PauseStreams()
		{
			deckLinkInput.PauseStreams();
		}

		public void FlushStreams()
		{
			deckLinkInput.FlushStreams();
		}

		public void SetCallback(IDeckLinkInputCallback theCallback)
		{
			deckLinkInput.SetCallback(theCallback);
		}

		public void GetHardwareReferenceClock(long desiredTimeScale, out long hardwareTime, out long timeInFrame, out long ticksPerFrame)
		{
			deckLinkInput.GetHardwareReferenceClock(desiredTimeScale, out hardwareTime, out timeInFrame, out ticksPerFrame);
		}

		#endregion

		#region IDeckLinkInputCallback

		private static readonly Dictionary<(BMDDetectedVideoInputFormatFlags, BMDDetectedVideoInputFormatFlags), BMDPixelFormat> pixelFormatMap = new()
		{
			{(BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputYCbCr422, BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInput8BitDepth), BMDPixelFormat.bmdFormat8BitYUV},
			{(BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputYCbCr422, BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInput10BitDepth), BMDPixelFormat.bmdFormat10BitYUV},
			{(BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputRGB444, BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInput8BitDepth), BMDPixelFormat.bmdFormat8BitARGB},
			{(BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputRGB444, BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInput10BitDepth), BMDPixelFormat.bmdFormat10BitRGB},
			{(BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputRGB444, BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInput12BitDepth), BMDPixelFormat.bmdFormat12BitRGB},
		};

		public void VideoInputFormatChanged(BMDVideoInputFormatChangedEvents notificationEvents, IDeckLinkDisplayMode newDisplayMode, BMDDetectedVideoInputFormatFlags detectedSignalFlags)
		{
			BMDVideoInputFlags videoInputFlags = BMDVideoInputFlags.bmdVideoInputEnableFormatDetection;
			BMDPixelFormat pixelFormat = BMDPixelFormat.bmdFormat10BitYUV;

			#region Check if the pixel format has changed

			if (notificationEvents.HasFlag(BMDVideoInputFormatChangedEvents.bmdVideoInputColorspaceChanged))
			{
				var pixelFormatKey = (
					detectedSignalFlags & (BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputYCbCr422 | BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputRGB444),
					detectedSignalFlags & (BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInput8BitDepth | BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInput10BitDepth | BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInput12BitDepth)
				);

				if (!pixelFormatMap.TryGetValue(pixelFormatKey, out pixelFormat))
				{
					return; // Unknown pixel format
				}
			}

			#endregion

			#region Check if the video mode has changed

			if (notificationEvents.HasFlag(BMDVideoInputFormatChangedEvents.bmdVideoInputDisplayModeChanged) && detectedSignalFlags.HasFlag(BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputDualStream3D))
			{
				videoInputFlags |= BMDVideoInputFlags.bmdVideoInputDualStream3D;
			}

			#endregion

			#region Restart video stream if changes were detected

			if (notificationEvents.HasFlag(BMDVideoInputFormatChangedEvents.bmdVideoInputDisplayModeChanged) | notificationEvents.HasFlag(BMDVideoInputFormatChangedEvents.bmdVideoInputColorspaceChanged))
			{
				deckLinkInput.PauseStreams();
				deckLinkInput.EnableVideoInput(newDisplayMode.GetDisplayMode(), pixelFormat, videoInputFlags);
				deckLinkInput.FlushStreams();
				deckLinkInput.StartStreams();
			}

			#endregion

			FormatChanged?.Invoke(this, new InputFormatChangedEventArgs(notificationEvents, newDisplayMode, detectedSignalFlags));
		}

		public void VideoInputFrameArrived(IDeckLinkVideoInputFrame videoFrame, IDeckLinkAudioInputPacket audioPacket)
		{
			FrameArrived?.Invoke(this, new VideoFrameArrivedEventArgs(videoFrame, audioPacket));

			if (videoFrame != null)
			{
				GC.AddMemoryPressure(videoFrame.GetRowBytes() * videoFrame.GetHeight());
			}
		}

		#endregion
	}

	public class InputFormatChangedEventArgs : EventArgs
	{
		public BMDVideoInputFormatChangedEvents NotificationEvents { get; }

		public IDeckLinkDisplayMode NewDisplayMode { get; }

		public BMDDetectedVideoInputFormatFlags DetectedSignalFlags { get; }

		public InputFormatChangedEventArgs(BMDVideoInputFormatChangedEvents notificationEvents, IDeckLinkDisplayMode newDisplayMode, BMDDetectedVideoInputFormatFlags detectedSignalFlags)
		{
			this.NotificationEvents = notificationEvents;
			this.NewDisplayMode = newDisplayMode;
			this.DetectedSignalFlags = detectedSignalFlags;
		}
	}

	public class VideoFrameArrivedEventArgs : EventArgs
	{
		public IDeckLinkVideoInputFrame VideoFrame { get; }

		public IDeckLinkAudioInputPacket AudioPacket { get; }

		public VideoFrameArrivedEventArgs(IDeckLinkVideoInputFrame videoFrame, IDeckLinkAudioInputPacket audioPacket)
		{
			this.VideoFrame = videoFrame;
			this.AudioPacket = audioPacket;
		}
	}
}
