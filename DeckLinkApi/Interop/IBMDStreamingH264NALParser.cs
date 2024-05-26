using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5867F18C-5BFA-4CCC-B2A7-9DFD140417D2")]
	public partial interface IBMDStreamingH264NALParser
	{
		void IsNALSequenceParameterSet(IBMDStreamingH264NALPacket nal);

		void IsNALPictureParameterSet(IBMDStreamingH264NALPacket nal);

		void GetProfileAndLevelFromSPS(IBMDStreamingH264NALPacket nal, out uint profileIdc, out uint profileCompatability, out uint levelIdc);
	}
}