using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("BC6CFBD3-8317-4325-AC1C-1216391E9340")]
	public partial interface IDeckLinkTimecode
	{
		[PreserveSig]
		uint GetBCD();

		void GetComponents(out byte hours, out byte minutes, out byte seconds, out byte frames);

		void GetString([MarshalUsing(typeof(BStrStringMarshaller))] out string timecode);

		[PreserveSig]
		BMDTimecodeFlags GetFlags();

		void GetTimecodeUserBits(out uint userBits);
	}
}