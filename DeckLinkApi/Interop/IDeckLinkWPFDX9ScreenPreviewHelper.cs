using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("AD8EC84A-7DDE-11E9-8F9E-2A86E4085A59")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkWPFDX9ScreenPreviewHelper
	{
		void Initialize();

		void Render();

		void SetSurfaceSize(uint width, uint height);

		void SetFrame(IDeckLinkVideoFrame theFrame);

		void Set3DPreviewFormat(BMD3DPreviewFormat previewFormat);

		void GetBackBuffer(out IntPtr backBuffer);
	}
}