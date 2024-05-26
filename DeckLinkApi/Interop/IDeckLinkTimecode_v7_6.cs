using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("EFB9BCA6-A521-44F7-BD69-2332F24D9EE6")]
	public partial interface IDeckLinkTimecode_v7_6
	{
		[PreserveSig]
		uint GetBCD();

		void GetComponents(out byte hours, out byte minutes, out byte seconds, out byte frames);

		void GetString([MarshalUsing(typeof(BStrStringMarshaller))] out string timecode);

		[PreserveSig]
		BMDTimecodeFlags GetFlags();
	}
}