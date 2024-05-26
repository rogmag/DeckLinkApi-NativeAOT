using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("403C681B-7F46-4A12-B993-2BB127084EE6")]
	public partial interface IDeckLinkAudioOutputCallback
	{
		void RenderAudioSamples([MarshalAs(UnmanagedType.Bool)] bool preroll);
	}
}