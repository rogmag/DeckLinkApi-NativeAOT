#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[Guid("CC010023-E01D-4525-9D59-80C8AB3DC7A0")]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	public partial class CDeckLinkDX9ScreenPreviewHelperClass : IDeckLinkDX9ScreenPreviewHelper, CDeckLinkDX9ScreenPreviewHelper
	{
		public virtual extern void Initialize(IntPtr device);

		public virtual extern void Render(ref tagRECT rc);

		public virtual extern void SetFrame(IDeckLinkVideoFrame theFrame);

		public virtual extern void Set3DPreviewFormat(BMD3DPreviewFormat previewFormat);
	}
}