using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("DA0F7E4A-EDC7-48A8-9CDD-2DB51C729CD7")]
	public partial interface IDeckLinkVideoFrame3DExtensions
	{
		[PreserveSig]
		BMDVideo3DPackingFormat Get3DPackingFormat();

		void GetFrameForRightEye(out IDeckLinkVideoFrame rightEyeFrame);
	}
}