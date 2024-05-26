using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3A11E7A2-82AD-11E9-BC42-526AF7764F64")]
	public partial interface IDeckLinkDX9ScreenPreviewHelperPrivate
	{
		void UseDefaultMemoryPool([MarshalAs(UnmanagedType.Bool)] bool useDefault);
	}
}