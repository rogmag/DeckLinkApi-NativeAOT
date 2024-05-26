using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("639C8E0B-68D5-4BDE-A6D4-95F3AEAFF2E7")]
	public partial interface IDeckLinkH265NALPacket : IDeckLinkEncoderVideoPacket
	{
		void GetUnitType(out byte unitType);

		void GetBytesNoPrefix(out IntPtr buffer);

		[PreserveSig]
		int GetSizeNoPrefix();
	}
}