using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("91810D1C-4FB3-4AAA-AE56-FA301D3DFA4C")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IBMDStreamingMPEG2TSPacket
	{
		[PreserveSig]
		int GetPayloadSize();

		void GetBytes(out IntPtr buffer);
	}
}