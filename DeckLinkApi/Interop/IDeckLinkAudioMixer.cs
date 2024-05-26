using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("631AC603-6838-4FC2-9579-B1C2596847BF")]
	public partial interface IDeckLinkAudioMixer
	{
		void Enable();

		void Disable();

		void Reset();

		void SetSources(BMDAudioMixerSource mixerSources);

		void GetSources(ref BMDAudioMixerSource mixerSources);

		void GetChannelGains(BMDAudioMixerSource mixerSource, BMDAudioMixerInputChannel inputChannel, out byte outputChannelGains, out uint outputChannelCount);

		void SetChannelGains(BMDAudioMixerSource mixerSource, BMDAudioMixerInputChannel inputChannel, ref byte outputChannelGains, uint outputChannelCount);
	}
}