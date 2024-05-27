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
		//public virtual extern void SetFrame(IDeckLinkVideoFrame theFrame);

		public virtual void SetFrame(IDeckLinkVideoFrame theFrame)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}

		// Not compatible with Native AOT
		//public virtual extern void Set3DPreviewFormat(BMD3DPreviewFormat previewFormat);

		public virtual void Set3DPreviewFormat(BMD3DPreviewFormat previewFormat)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}
	}
}