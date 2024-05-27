#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[Guid("7DBBBB11-5B7B-467D-AEA4-CEA468FD368C")]
	public partial class CDeckLinkVideoConversionClass : IDeckLinkVideoConversion, CDeckLinkVideoConversion
	{
		// Not compatible with Native AOT
		//public virtual extern void ConvertFrame(IDeckLinkVideoFrame srcFrame, IDeckLinkVideoFrame dstFrame);

		public virtual void ConvertFrame(IDeckLinkVideoFrame srcFrame, IDeckLinkVideoFrame dstFrame)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}
	}
}