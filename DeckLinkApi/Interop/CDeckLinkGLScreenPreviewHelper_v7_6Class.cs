#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("D398CEE7-4434-4CA3-9BA6-5AE34556B905")]
	public partial class CDeckLinkGLScreenPreviewHelper_v7_6Class : IDeckLinkGLScreenPreviewHelper_v7_6, CDeckLinkGLScreenPreviewHelper_v7_6
	{
		public virtual extern void InitializeGL();

		public virtual extern void PaintGL();

		public virtual extern void SetFrame(IDeckLinkVideoFrame_v7_6 theFrame);
	}
}