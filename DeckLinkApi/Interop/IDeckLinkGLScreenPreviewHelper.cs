using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("504E2209-CAC7-4C1A-9FB4-C5BB6274D22F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkGLScreenPreviewHelper
	{
		void InitializeGL();

		void PaintGL();

		void SetFrame(IDeckLinkVideoFrame theFrame);

		void Set3DPreviewFormat(BMD3DPreviewFormat previewFormat);
	}
}