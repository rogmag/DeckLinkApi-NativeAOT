using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("5F558200-4028-49BC-BEAC-DB3FA4A96E46")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkStatus
	{
		void GetFlag(BMDDeckLinkStatusID statusID, [MarshalAs(UnmanagedType.Bool)] out bool value);

		void GetInt(BMDDeckLinkStatusID statusID, out long value);

		void GetFloat(BMDDeckLinkStatusID statusID, out double value);

		void GetString(BMDDeckLinkStatusID statusID, [MarshalUsing(typeof(BStrStringMarshaller))] out string value);

		void GetBytes(BMDDeckLinkStatusID statusID, IntPtr buffer, ref uint bufferSize);
	}
}