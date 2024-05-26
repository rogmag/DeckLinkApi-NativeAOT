#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("F63E77C7-B655-4A4A-9AD0-3CA85D394343")]
	public partial class CDeckLinkGLScreenPreviewHelperClass : IDeckLinkGLScreenPreviewHelper, CDeckLinkGLScreenPreviewHelper
	{
		public virtual extern void InitializeGL();

		public virtual extern void PaintGL();

		public virtual extern void SetFrame(IDeckLinkVideoFrame theFrame);

		public virtual extern void Set3DPreviewFormat(BMD3DPreviewFormat previewFormat);
	}
}