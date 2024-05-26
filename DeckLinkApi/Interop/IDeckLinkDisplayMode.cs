using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("3EB2C1AB-0A3D-4523-A3AD-F40D7FB14E78")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkDisplayMode
	{
		void GetName([MarshalUsing(typeof(BStrStringMarshaller))] out string name);

		[PreserveSig]
		BMDDisplayMode GetDisplayMode();

		[PreserveSig]
		int GetWidth();

		[PreserveSig]
		int GetHeight();

		void GetFrameRate(out long frameDuration, out long timeScale);

		[PreserveSig]
		BMDFieldDominance GetFieldDominance();

		[PreserveSig]
		BMDDisplayModeFlags GetFlags();
	}
}