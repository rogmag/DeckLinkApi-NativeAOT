using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("BA575CD9-A15E-497B-B2C2-F9AFE7BE4EBA")]
	public partial interface IDeckLinkGLScreenPreviewHelper_v7_6
	{
		void InitializeGL();

		void PaintGL();

		void SetFrame(IDeckLinkVideoFrame_v7_6 theFrame);
	}
}