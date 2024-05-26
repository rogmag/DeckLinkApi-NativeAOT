using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("87451E84-2B7E-439E-A629-4393EA4A8550")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkDisplayMode_v7_6
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
	}
}