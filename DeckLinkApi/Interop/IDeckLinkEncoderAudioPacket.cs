using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("49E8EDC8-693B-4E14-8EF6-12C658F5A07A")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkEncoderAudioPacket : IDeckLinkEncoderPacket
	{
		[PreserveSig]
		BMDAudioFormat GetAudioFormat();
	}
}