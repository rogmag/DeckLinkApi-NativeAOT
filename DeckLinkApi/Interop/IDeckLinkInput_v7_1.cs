using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("2B54EDEF-5B32-429F-BA11-BB990596EACD")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkInput_v7_1
	{
		void DoesSupportVideoMode(BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, out BMDDisplayModeSupport_v10_11 result);

		void GetDisplayModeIterator(out IDeckLinkDisplayModeIterator_v7_1 iterator);

		void EnableVideoInput(BMDDisplayMode displayMode, BMDPixelFormat pixelFormat, BMDVideoInputFlags flags);

		void DisableVideoInput();

		void EnableAudioInput(BMDAudioSampleRate sampleRate, BMDAudioSampleType sampleType, uint channelCount);

		void DisableAudioInput();

		void ReadAudioSamples(IntPtr buffer, uint sampleFrameCount, out uint sampleFramesRead, out long audioPacketTime, long timeScale);

		void GetBufferedAudioSampleFrameCount(out uint bufferedSampleCount);

		void StartStreams();

		void StopStreams();

		void PauseStreams();

		void SetCallback(IDeckLinkInputCallback_v7_1 theCallback);
	}
}