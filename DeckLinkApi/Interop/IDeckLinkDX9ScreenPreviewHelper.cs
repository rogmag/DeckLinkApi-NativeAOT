using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("2094B522-D1A1-40C0-9AC7-1C012218EF02")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkDX9ScreenPreviewHelper
	{
		void Initialize(IntPtr device);

		void Render(ref tagRECT rc);

		void SetFrame(IDeckLinkVideoFrame theFrame);

		void Set3DPreviewFormat(BMD3DPreviewFormat previewFormat);
	}
}