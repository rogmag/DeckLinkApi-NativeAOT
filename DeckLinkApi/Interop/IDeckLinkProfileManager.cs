using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("30D41429-3998-4B6D-84F8-78C94A797C6E")]
	public partial interface IDeckLinkProfileManager
	{
		void GetProfiles(out IDeckLinkProfileIterator profileIterator);

		void GetProfile(BMDProfileID profileID, out IDeckLinkProfile profile);

		void SetCallback(IDeckLinkProfileCallback callback);
	}
}