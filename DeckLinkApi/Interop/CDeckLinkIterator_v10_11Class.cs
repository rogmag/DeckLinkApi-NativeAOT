#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[Guid("87D2693F-8D4A-45C7-B43F-10ACBA25E68F")]
	public partial class CDeckLinkIterator_v10_11Class : IDeckLinkIterator, CDeckLinkIterator_v10_11
	{
		public virtual extern void Next(out IDeckLink deckLinkInstance);
	}
}