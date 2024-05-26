using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("7AC731A3-C950-4AD0-804A-8377AA51C6C4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IBMDStreamingVideoEncodingModePresetIterator
	{
		void Next(out IBMDStreamingVideoEncodingMode videoEncodingMode);
	}
}