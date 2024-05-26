using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("FB431287-6D08-4DFA-A9C9-3AD21A6DD79B")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkAdvancedConversions
	{
		void DoesSupportConversion(BMDDisplayMode originalMode, BMDDisplayMode convertToMode);

		void GetConversionLatency(BMDDisplayMode fromMode, BMDDisplayMode toMode, long timeScale, out long latency);
	}
}