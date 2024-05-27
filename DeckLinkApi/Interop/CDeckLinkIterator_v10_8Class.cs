#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("1F2E109A-8F4F-49E4-9203-135595CB6FA5")]
	public partial class CDeckLinkIterator_v10_8Class : IDeckLinkIterator, CDeckLinkIterator_v10_8
	{
		// Not compatible with Native AOT
		//public virtual extern void Next(out IDeckLink deckLinkInstance);

		public virtual void Next(out IDeckLink deckLinkInstance)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}
	}
}