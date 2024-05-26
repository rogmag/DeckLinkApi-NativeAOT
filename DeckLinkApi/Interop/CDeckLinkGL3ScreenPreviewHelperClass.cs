#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("00696A71-EBC7-491F-AC02-18D3393F33F0")]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	public partial class CDeckLinkGL3ScreenPreviewHelperClass : IDeckLinkGLScreenPreviewHelper, CDeckLinkGL3ScreenPreviewHelper
	{
		public virtual extern void InitializeGL();

		public virtual extern void PaintGL();

		public virtual extern void SetFrame(IDeckLinkVideoFrame theFrame);

		public virtual extern void Set3DPreviewFormat(BMD3DPreviewFormat previewFormat);
	}
}