using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("AF0CD6D5-8376-435E-8433-54F9DD530AC3")]
	public partial interface IDeckLinkDisplayMode_v7_1
	{
		void GetName([MarshalUsing(typeof(BStrStringMarshaller))] out string name);

		[PreserveSig]
		BMDDisplayMode GetDisplayMode();

		[PreserveSig]
		int GetWidth();

		[PreserveSig]
		int GetHeight();

		void GetFrameRate(out long frameDuration, out long timeScale);
	}
}