using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("ABBBACBC-45BC-4665-9D92-ACE6E5A97902")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkHDMIInputEDID
	{
		void SetInt(BMDDeckLinkHDMIInputEDIDID cfgID, long value);

		void GetInt(BMDDeckLinkHDMIInputEDIDID cfgID, out long value);

		void WriteToEDID();
	}
}