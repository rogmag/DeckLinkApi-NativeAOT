#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[Guid("D9EDA3B3-2887-41FA-B724-017CF1EB1D37")]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	public partial class CDeckLinkIterator_v8_0Class : IDeckLinkIterator_v8_0, CDeckLinkIterator_v8_0
	{
		// Not compatible with Native AOT
		//public virtual extern void Next(out IDeckLink_v8_0 deckLinkInstance);

		public virtual void Next(out IDeckLink_v8_0 deckLinkInstance)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}
	}
}