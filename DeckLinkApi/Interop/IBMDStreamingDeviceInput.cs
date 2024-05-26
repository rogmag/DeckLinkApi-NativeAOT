using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("24B6B6EC-1727-44BB-9818-34FF086ACF98")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IBMDStreamingDeviceInput
	{
		void DoesSupportVideoInputMode(BMDDisplayMode inputMode, [MarshalAs(UnmanagedType.Bool)] out bool result);

		void GetVideoInputModeIterator(out IDeckLinkDisplayModeIterator iterator);

		void SetVideoInputMode(BMDDisplayMode inputMode);

		void GetCurrentDetectedVideoInputMode(out BMDDisplayMode detectedMode);

		void GetVideoEncodingMode(out IBMDStreamingVideoEncodingMode encodingMode);

		void GetVideoEncodingModePresetIterator(BMDDisplayMode inputMode, out IBMDStreamingVideoEncodingModePresetIterator iterator);

		void DoesSupportVideoEncodingMode(BMDDisplayMode inputMode, IBMDStreamingVideoEncodingMode encodingMode, out BMDStreamingEncodingSupport result, out IBMDStreamingVideoEncodingMode changedEncodingMode);

		void SetVideoEncodingMode(IBMDStreamingVideoEncodingMode encodingMode);

		void StartCapture();

		void StopCapture();

		void SetCallback([MarshalUsing(typeof(ComInterfaceMarshaller<IBMDStreamingH264InputCallback>))] IBMDStreamingH264InputCallback theCallback);
	}
}