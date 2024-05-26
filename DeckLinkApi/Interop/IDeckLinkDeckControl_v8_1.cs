using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComInterface]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("522A9E39-0F3C-4742-94EE-D80DE335DA1D")]
	public partial interface IDeckLinkDeckControl_v8_1
	{
		void Open(long timeScale, long timeValue, [MarshalAs(UnmanagedType.Bool)] bool timecodeIsDropFrame, out BMDDeckControlError error);

		void Close([MarshalAs(UnmanagedType.Bool)] bool standbyOn);

		void GetCurrentState(out BMDDeckControlMode mode, out BMDDeckControlVTRControlState_v8_1 vtrControlState, out BMDDeckControlStatusFlags flags);

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

		void SetCallback(IDeckLinkDeckControlStatusCallback_v8_1 callback);
	}
}