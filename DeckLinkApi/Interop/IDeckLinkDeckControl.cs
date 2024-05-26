using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[Guid("8E1C3ACE-19C7-4E00-8B92-D80431D958BE")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public partial interface IDeckLinkDeckControl
	{
		void Open(long timeScale, long timeValue, [MarshalAs(UnmanagedType.Bool)] bool timecodeIsDropFrame, out BMDDeckControlError error);

		void Close([MarshalAs(UnmanagedType.Bool)] bool standbyOn);

		void GetCurrentState(out BMDDeckControlMode mode, out BMDDeckControlVTRControlState vtrControlState, out BMDDeckControlStatusFlags flags);

		void SetStandby([MarshalAs(UnmanagedType.Bool)] bool standbyOn);

		void SendCommand(ref byte inBuffer, uint inBufferSize, out byte outBuffer, out uint outDataSize, out uint outBufferSize, out BMDDeckControlError error);

		void Play(out BMDDeckControlError error);

		void Stop(out BMDDeckControlError error);

		void TogglePlayStop(out BMDDeckControlError error);

		void Eject(out BMDDeckControlError error);

		void GoToTimecode(uint timecode, out BMDDeckControlError error);

		void FastForward([MarshalAs(UnmanagedType.Bool)] bool viewTape, out BMDDeckControlError error);

		void Rewind([MarshalAs(UnmanagedType.Bool)] bool viewTape, out BMDDeckControlError error);

		void StepForward(out BMDDeckControlError error);

		void StepBack(out BMDDeckControlError error);

		void Jog(double rate, out BMDDeckControlError error);

		void Shuttle(double rate, out BMDDeckControlError error);

		void GetTimecodeString([MarshalUsing(typeof(BStrStringMarshaller))] out string currentTimecode, out BMDDeckControlError error);

		void GetTimecode(out IDeckLinkTimecode currentTimecode, out BMDDeckControlError error);

		void GetTimecodeBCD(out uint currentTimecode, out BMDDeckControlError error);

		void SetPreroll(uint prerollSeconds);

		void GetPreroll(out uint prerollSeconds);

		void SetExportOffset(int exportOffsetFields);

		void GetExportOffset(out int exportOffsetFields);

		void GetManualExportOffset(out int deckManualExportOffsetFields);

		void SetCaptureOffset(int captureOffsetFields);

		void GetCaptureOffset(out int captureOffsetFields);

		void StartExport(uint inTimecode, uint outTimecode, BMDDeckControlExportModeOpsFlags exportModeOps, out BMDDeckControlError error);

		void StartCapture([MarshalAs(UnmanagedType.Bool)] bool useVITC, uint inTimecode, uint outTimecode, out BMDDeckControlError error);

		void GetDeviceID(out ushort deviceId, out BMDDeckControlError error);

		void Abort();

		void CrashRecordStart(out BMDDeckControlError error);

		void CrashRecordStop(out BMDDeckControlError error);

		void SetCallback(IDeckLinkDeckControlStatusCallback callback);
	}
}