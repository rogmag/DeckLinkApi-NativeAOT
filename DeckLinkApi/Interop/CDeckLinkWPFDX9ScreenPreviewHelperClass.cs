#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("EF2A8478-7DDF-11E9-8F9E-2A86E4085A59")]
	public partial class CDeckLinkWPFDX9ScreenPreviewHelperClass : IDeckLinkWPFDX9ScreenPreviewHelper, CDeckLinkWPFDX9ScreenPreviewHelper
	{
		public virtual extern void Initialize();

		public virtual extern void Render();

		public virtual extern void SetSurfaceSize(uint width, uint height);

		public virtual extern void SetFrame(IDeckLinkVideoFrame theFrame);

		public virtual extern void Set3DPreviewFormat(BMD3DPreviewFormat previewFormat);

		public virtual extern void GetBackBuffer(out IntPtr backBuffer);
	}
}