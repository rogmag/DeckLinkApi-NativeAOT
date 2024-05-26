#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("7753EFBD-951C-407C-97A5-23C737B73B52")]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	public partial class CBMDStreamingH264NALParserClass : IBMDStreamingH264NALParser, CBMDStreamingH264NALParser
	{
		public virtual extern void IsNALSequenceParameterSet(IBMDStreamingH264NALPacket nal);

		public virtual extern void IsNALPictureParameterSet(IBMDStreamingH264NALPacket nal);

		public virtual extern void GetProfileAndLevelFromSPS(IBMDStreamingH264NALPacket nal, out uint profileIdc, out uint profileCompatability, out uint levelIdc);
	}
}