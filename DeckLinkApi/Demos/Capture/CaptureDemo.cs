using DeckLinkApi.Interop;

namespace DeckLinkApi.Demos.Capture
{
	internal class CaptureDemo
	{
		public static void Run()
		{
			var deckLinkIterator = CDeckLinkIteratorClass.CreateInstance();
			var deckLinkInput = new DeckLinkInput(deckLinkIterator.Next()); // Use the first DeckLink device that's found
			
			deckLinkInput.FrameArrived += (sender, e) =>
			{
				if (e.VideoFrame != null && !e.VideoFrame.GetFlags().HasFlag(BMDFrameFlags.bmdFrameHasNoInputSource))
				{
					Console.WriteLine($"Frame {e.VideoFrame.GetTimecode(BMDTimecodeFormat.bmdTimecodeRP188Any)?.GetString()} arrived");

					var bytes = e.VideoFrame.GetBytesSpan();
				}
			};
			
			deckLinkInput.FormatChanged += (sender, e) =>
			{
				Console.WriteLine($"Format changed: {e.NewDisplayMode.GetName()}");
			};

			deckLinkInput.SetCallback();
			deckLinkInput.EnableVideoInput(BMDDisplayMode.bmdModeHD1080p2398, BMDPixelFormat.bmdFormat10BitYUV, BMDVideoInputFlags.bmdVideoInputFlagDefault | BMDVideoInputFlags.bmdVideoInputEnableFormatDetection);
			deckLinkInput.StartStreams();
			
			Console.ReadLine();
			
			deckLinkInput.StopStreams();
		}
	}
}
