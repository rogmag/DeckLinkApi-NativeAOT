#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("BA6C6F44-6DA5-4DCE-94AA-EE2D1372A676")]
	public partial class CDeckLinkIteratorClass : IDeckLinkIterator, CDeckLinkIterator
	{
		public virtual extern void Next(out IDeckLink deckLinkInstance);
	}
}