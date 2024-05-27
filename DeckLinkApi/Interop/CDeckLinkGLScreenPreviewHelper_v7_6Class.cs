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
		// Not compatible with Native AOT
		//public virtual extern void InitializeGL();

		public virtual void InitializeGL()
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}

		// Not compatible with Native AOT
		//public virtual extern void PaintGL();

		public virtual void PaintGL()
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}

		// Not compatible with Native AOT
		//public virtual extern void SetFrame(IDeckLinkVideoFrame_v7_6 theFrame);

		public virtual void SetFrame(IDeckLinkVideoFrame_v7_6 theFrame)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}
	}
}