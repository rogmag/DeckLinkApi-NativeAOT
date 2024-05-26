namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckControlExportModeOpsFlags enumerates the possible deck control edit-to-tape and exportto-tape mode operations.
	/// </summary>
	[Flags]
	public enum BMDDeckControlExportModeOpsFlags
	{
		/// <summary>
		/// Insert video
		/// </summary>
		bmdDeckControlExportModeInsertVideo = 1,

		/// <summary>
		/// Insert audio track 1
		/// </summary>
		bmdDeckControlExportModeInsertAudio1 = 2,

		/// <summary>
		/// Insert audio track 2
		/// </summary>
		bmdDeckControlExportModeInsertAudio2 = 4,

		/// <summary>
		/// Insert audio track 3
		/// </summary>
		bmdDeckControlExportModeInsertAudio3 = 8,

		/// <summary>
		/// Insert audio track 4
		/// </summary>
		bmdDeckControlExportModeInsertAudio4 = 0x10,

		/// <summary>
		/// Insert audio track 5
		/// </summary>
		bmdDeckControlExportModeInsertAudio5 = 0x20,

		/// <summary>
		/// Insert audio track 6
		/// </summary>
		bmdDeckControlExportModeInsertAudio6 = 0x40,

		/// <summary>
		/// Insert audio track 7
		/// </summary>
		bmdDeckControlExportModeInsertAudio7 = 0x80,

		/// <summary>
		/// Insert audio track 8
		/// </summary>
		bmdDeckControlExportModeInsertAudio8 = 0x100,

		/// <summary>
		/// Insert audio track 9
		/// </summary>
		bmdDeckControlExportModeInsertAudio9 = 0x200,

		/// <summary>
		/// Insert audio track 10
		/// </summary>
		bmdDeckControlExportModeInsertAudio10 = 0x400,

		/// <summary>
		/// Insert audio track 11
		/// </summary>
		bmdDeckControlExportModeInsertAudio11 = 0x800,

		/// <summary>
		/// Insert audio track 12
		/// </summary>
		bmdDeckControlExportModeInsertAudio12 = 0x1000,

		/// <summary>
		/// Insert timecode
		/// </summary>
		bmdDeckControlExportModeInsertTimeCode = 0x2000,

		/// <summary>
		/// Enable assemble editing.
		/// </summary>
		bmdDeckControlExportModeInsertAssemble = 0x4000,

		/// <summary>
		/// Enable preview auto editing
		/// </summary>
		bmdDeckControlExportModeInsertPreview = 0x8000,

		/// <summary>
		/// Use edit on/off (TRUE) or autoedit (FALSE). Edit on/off is currently not supported. 
		/// </summary>
		bmdDeckControlUseManualExport = 0x10000
	}
}