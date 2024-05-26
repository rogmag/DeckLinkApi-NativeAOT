#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[Guid("FFA84F77-73BE-4FB7-B03E-B5E44B9F759B")]
	public partial class CDeckLinkVideoConversion_v7_6Class : IDeckLinkVideoConversion_v7_6, CDeckLinkVideoConversion_v7_6
	{
		public virtual extern void ConvertFrame(IDeckLinkVideoFrame_v7_6 srcFrame, IDeckLinkVideoFrame_v7_6 dstFrame);
	}
}