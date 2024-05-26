#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[Guid("263CA19F-ED09-482E-9F9D-84005783A237")]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	public partial class CDeckLinkAPIInformationClass : IDeckLinkAPIInformation, CDeckLinkAPIInformation
	{
		public virtual extern void GetFlag(BMDDeckLinkAPIInformationID cfgID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		public virtual extern void GetInt(BMDDeckLinkAPIInformationID cfgID, out long value);

		public virtual extern void GetFloat(BMDDeckLinkAPIInformationID cfgID, out double value);

		public virtual extern void GetString(BMDDeckLinkAPIInformationID cfgID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);
	}
}