using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("B36EB6E7-9D29-4AA8-92EF-843B87A289E8")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkMemoryAllocator
	{
		void AllocateBuffer(uint bufferSize, out IntPtr allocatedBuffer);

		void ReleaseBuffer(IntPtr buffer);

		void Commit();

		void Decommit();
	}
}