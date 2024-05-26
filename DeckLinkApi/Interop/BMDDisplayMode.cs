namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDisplayMode enumerates the video modes supported for output and input.
	/// </summary>
	public enum BMDDisplayMode
	{
		/// <summary>
		/// Width: 720, Height: 486, Frames per Second: 30/1.001, Fields per Frame: 2, Suggested Time Scale: 30000, Display Duration: 1001
		/// </summary>
		bmdModeNTSC = 1853125475,

		/// <summary>
		/// Width: 720, Height: 486, Frames per Second: 30/1.001, Fields per Frame: 2, Suggested Time Scale: 24000, Display Duration: 1001
		/// </summary>
		bmdModeNTSC2398 = 1853108787,

		/// <summary>
		/// Width: 720, Height: 486, Frames per Second: 60/1.001, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1001
		/// </summary>
		bmdModeNTSCp = 1853125488,

		/// <summary>
		/// Width: 720, Height: 576, Frames per Second: 25, Fields per Frame: 2, Suggested Time Scale: 25000, Display Duration: 1000
		/// </summary>
		bmdModePAL = 1885432864,
		
		/// <summary>
		/// Width: 720, Height: 576, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdModePALp = 1885432944,

		/// <summary>
		/// Width: 1280, Height: 720, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdModeHD720p50 = 1752184112,

		/// <summary>
		/// Width: 1280, Height: 720, Frames per Second: 60/1.001, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1001
		/// </summary>
		bmdModeHD720p5994 = 1752184121,

		/// <summary>
		/// Width: 1280, Height: 720, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdModeHD720p60 = 1752184368,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 24/1.001, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1001
		/// </summary>
		bmdModeHD1080p2398 = 842231923,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 24, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080p24 = 842297459,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 25, Fields per Frame: 1, Suggested Time Scale: 25000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080p25 = 1215312437,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 30/1.001, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1001
		/// </summary>
		bmdModeHD1080p2997 = 1215312441,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 30, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080p30 = 1215312688,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 48/1.001, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1001
		/// </summary>
		bmdModeHD1080p4795 = 1215312951,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 48, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080p48 = 1215312952,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 25, Fields per Frame: 2, Suggested Time Scale: 25000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080i50 = 1214854448,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 30/1.001, Fields per Frame: 2, Suggested Time Scale: 30000, Display Duration: 1001
		/// </summary>
		bmdModeHD1080i5994 = 1214854457,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 30, Fields per Frame: 2, Suggested Time Scale: 30000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080i6000 = 1214854704,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080p50 = 1215313200,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 60/1.001, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1001
		/// </summary>
		bmdModeHD1080p5994 = 1215313209,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080p6000 = 1215313456,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 96/1.001, Fields per Frame: 1, Suggested Time Scale: 96000, Display Duration: 1001
		/// </summary>
		bmdModeHD1080p9590 = 1215314229,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 96, Fields per Frame: 1, Suggested Time Scale: 96000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080p96 = 1215314230,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 100, Fields per Frame: 1, Suggested Time Scale: 100000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080p100 = 1215312176,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 120/1.001, Fields per Frame: 1, Suggested Time Scale: 120000, Display Duration: 1001
		/// </summary>
		bmdModeHD1080p11988 = 1215312177,

		/// <summary>
		/// Width: 1920, Height: 1080, Frames per Second: 120, Fields per Frame: 1, Suggested Time Scale: 120000, Display Duration: 1000
		/// </summary>
		bmdModeHD1080p120 = 1215312178,

		/// <summary>
		/// Width: 2048, Height: 1556, Frames per Second: 24/1.001, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1001
		/// </summary>
		bmdMode2k2398 = 845886003,

		/// <summary>
		/// Width: 2048, Height: 1556, Frames per Second: 24, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1000
		/// </summary>
		bmdMode2k24 = 845886004,

		/// <summary>
		/// Width: 2048, Height: 1556, Frames per Second: 25, Fields per Frame: 1, Suggested Time Scale: 25000, Display Duration: 1000
		/// </summary>
		bmdMode2k25 = 845886005,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 24/1.001, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1001
		/// </summary>
		bmdMode2kDCI2398 = 845427251,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 24, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1000
		/// </summary>
		bmdMode2kDCI24 = 845427252,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 25, Fields per Frame: 1, Suggested Time Scale: 25000, Display Duration: 1000
		/// </summary>
		bmdMode2kDCI25 = 845427253,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 30/1.001, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1001
		/// </summary>
		bmdMode2kDCI2997 = 845427257,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 30, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1000
		/// </summary>
		bmdMode2kDCI30 = 845427504,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 48/1.001, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1001
		/// </summary>
		bmdMode2kDCI4795 = 845427767,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 48, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1000
		/// </summary>
		bmdMode2kDCI48 = 845427768,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode2kDCI50 = 845428016,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 60/1.001, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1001	
		/// </summary>
		bmdMode2kDCI5994 = 845428025,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode2kDCI60 = 845428272,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 96/1.001, Fields per Frame: 1, Suggested Time Scale: 96000, Display Duration: 1001
		/// </summary>
		bmdMode2kDCI9590 = 845429045,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 96, Fields per Frame: 1, Suggested Time Scale: 96000, Display Duration: 1000
		/// </summary>
		bmdMode2kDCI96 = 845429046,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 100, Fields per Frame: 1, Suggested Time Scale: 100000, Display Duration: 1000
		/// </summary>
		bmdMode2kDCI100 = 845426992,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 120/1.001, Fields per Frame: 1, Suggested Time Scale: 120000, Display Duration: 1001
		/// </summary>
		bmdMode2kDCI11988 = 845426993,

		/// <summary>
		/// Width: 2048, Height: 1080, Frames per Second: 120, Fields per Frame: 1, Suggested Time Scale: 120000, Display Duration: 1000
		/// </summary>
		bmdMode2kDCI120 = 845426994,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 24/1.001, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1001
		/// </summary>
		bmdMode4K2160p2398 = 879440435,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 24, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1000
		/// </summary>
		bmdMode4K2160p24 = 879440436,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 25, Fields per Frame: 1, Suggested Time Scale: 25000, Display Duration: 1000
		/// </summary>
		bmdMode4K2160p25 = 879440437,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 30/1.001, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1001
		/// </summary>
		bmdMode4K2160p2997 = 879440441,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 30, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1000
		/// </summary>
		bmdMode4K2160p30 = 879440688,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 48/1.001, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1001
		/// </summary>
		bmdMode4K2160p4795 = 879440951,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 48, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1000
		/// </summary>
		bmdMode4K2160p48 = 879440952,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode4K2160p50 = 879441200,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 60/1.001, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1001
		/// </summary>
		bmdMode4K2160p5994 = 879441209,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode4K2160p60 = 879441456,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 96/1.001, Fields per Frame: 1, Suggested Time Scale: 96000, Display Duration: 1001
		/// </summary>
		bmdMode4K2160p9590 = 879442229,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 96, Fields per Frame: 1, Suggested Time Scale: 96000, Display Duration: 1000
		/// </summary>
		bmdMode4K2160p96 = 879442230,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 100, Fields per Frame: 1, Suggested Time Scale: 100000, Display Duration: 1000
		/// </summary>
		bmdMode4K2160p100 = 879440176,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 120/1.001, Fields per Frame: 1, Suggested Time Scale: 120000, Display Duration: 1001
		/// </summary>
		bmdMode4K2160p11988 = 879440177,

		/// <summary>
		/// Width: 3840, Height: 2160, Frames per Second: 120, Fields per Frame: 1, Suggested Time Scale: 120000, Display Duration: 1000
		/// </summary>
		bmdMode4K2160p120 = 879440178,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 24/1.001, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1001
		/// </summary>
		bmdMode4kDCI2398 = 878981683,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 24, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1000
		/// </summary>
		bmdMode4kDCI24 = 878981684,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 25, Fields per Frame: 1, Suggested Time Scale: 25000, Display Duration: 1000
		/// </summary>
		bmdMode4kDCI25 = 878981685,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 30/1.001, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1000
		/// </summary>
		bmdMode4kDCI2997 = 878981689,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 30, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1000
		/// </summary>
		bmdMode4kDCI30 = 878981936,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 48/1.001, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1001
		/// </summary>
		bmdMode4kDCI4795 = 878982199,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 48, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1000
		/// </summary>
		bmdMode4kDCI48 = 878982200,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode4kDCI50 = 878982448,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 60/1.001, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1001
		/// </summary>
		bmdMode4kDCI5994 = 878982457,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 96/1.001, Fields per Frame: 1, Suggested Time Scale: 96000, Display Duration: 1001
		/// </summary>
		bmdMode4kDCI9590 = 878983477,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 96, Fields per Frame: 1, Suggested Time Scale: 96000, Display Duration: 1000
		/// </summary>
		bmdMode4kDCI96 = 878983478,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 100, Fields per Frame: 1, Suggested Time Scale: 100000, Display Duration: 1000
		/// </summary>
		bmdMode4kDCI100 = 878981424,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 120/1.001, Fields per Frame: 1, Suggested Time Scale: 120000, Display Duration: 1001
		/// </summary>
		bmdMode4kDCI11988 = 878981425,

		/// <summary>
		/// Width: 4096, Height: 2160, Frames per Second: 120, Fields per Frame: 1, Suggested Time Scale: 120000, Display Duration: 1000
		/// </summary>
		bmdMode4kDCI120 = 878981426,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 24/1.001, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1001
		/// </summary>
		bmdMode8K4320p2398 = 946549299,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 24, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1000
		/// </summary>
		bmdMode8K4320p24 = 946549300,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 25, Fields per Frame: 1, Suggested Time Scale: 25000, Display Duration: 1000
		/// </summary>
		bmdMode8K4320p25 = 946549301,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 30/1.001, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1001
		/// </summary>
		bmdMode8K4320p2997 = 946549305,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 30, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1000
		/// </summary>
		bmdMode8K4320p30 = 946549552,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 48/1.001, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1001
		/// </summary>
		bmdMode8K4320p4795 = 946549815,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 48, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1000
		/// </summary>
		bmdMode8K4320p48 = 946549816,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode8K4320p50 = 946550064,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 60/1.001, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1001
		/// </summary>
		bmdMode8K4320p5994 = 946550073,

		/// <summary>
		/// Width: 7680, Height: 4320, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode8K4320p60 = 946550320,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 24/1.001, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1001
		/// </summary>
		bmdMode8kDCI2398 = 946090547,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 24, Fields per Frame: 1, Suggested Time Scale: 24000, Display Duration: 1000
		/// </summary>
		bmdMode8kDCI24 = 946090548,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 25, Fields per Frame: 1, Suggested Time Scale: 25000, Display Duration: 1000
		/// </summary>
		bmdMode8kDCI25 = 946090549,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 30/1.001, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1001
		/// </summary>
		bmdMode8kDCI2997 = 946090553,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 30, Fields per Frame: 1, Suggested Time Scale: 30000, Display Duration: 1000
		/// </summary>
		bmdMode8kDCI30 = 946090800,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 48/1.001, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1001
		/// </summary>
		bmdMode8kDCI4795 = 946091063,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 48, Fields per Frame: 1, Suggested Time Scale: 48000, Display Duration: 1000
		/// </summary>
		bmdMode8kDCI48 = 946091064,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode8kDCI50 = 946091312,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 60/1.001, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1001
		/// </summary>
		bmdMode8kDCI5994 = 946091321,

		/// <summary>
		/// Width: 8192, Height: 4320, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode8kDCI60 = 946091568,

		/// <summary>
		/// Width: 640, Height: 480, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode640x480p60 = 1986486582,

		/// <summary>
		/// Width: 800, Height: 600, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode800x600p60 = 1937139510,

		/// <summary>
		/// Width: 1440, Height: 900, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode1440x900p50 = 2004379445,

		/// <summary>
		/// Width: 1440, Height: 900, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode1440x900p60 = 2004379446,

		/// <summary>
		/// Width: 1440, Height: 1080, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode1440x1080p50 = 1937270581,

		/// <summary>
		/// Width: 1440, Height: 1080, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode1440x1080p60 = 1937270582,

		/// <summary>
		/// Width: 1600, Height: 1200, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode1600x1200p50 = 1970825013,

		/// <summary>
		/// Width: 1600, Height: 1200, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode1600x1200p60 = 1970825014,

		/// <summary>
		/// Width: 1920, Height: 1200, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode1920x1200p50 = 2004187189,

		/// <summary>
		/// Width: 1920, Height: 1200, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode1920x1200p60 = 2004187190,

		/// <summary>
		/// Width: 1920, Height: 1440, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode1920x1440p50 = 825832501,

		/// <summary>
		/// Width: 1920, Height: 1440, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode1920x1440p60 = 825832502,

		/// <summary>
		/// Width: 2560, Height: 1440, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode2560x1440p50 = 2003920949,

		/// <summary>
		/// Width: 2560, Height: 1440, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode2560x1440p60 = 2003920950,

		/// <summary>
		/// Width: 2560, Height: 1600, Frames per Second: 50, Fields per Frame: 1, Suggested Time Scale: 50000, Display Duration: 1000
		/// </summary>
		bmdMode2560x1600p50 = 2003925045,

		/// <summary>
		/// Width: 2560, Height: 1600, Frames per Second: 60, Fields per Frame: 1, Suggested Time Scale: 60000, Display Duration: 1000
		/// </summary>
		bmdMode2560x1600p60 = 2003925046,

		bmdMode4kDCI60 = 878982704,

		bmdModeHD1080p2398Pulldown = 1211249508,
		
		bmdModeRAW1366p24 = 1920414260,
		bmdModeRAW1112p24 = 1920414002,
		
		bmdMode800x600p50 = 1937139509,
		
		bmdModeCintelRAW = 1920426857,
		bmdModeCintelCompressedRAW = 1920426851,

		bmdModeSpeedTest = 1936745588,
		bmdModeUnknown = 1769303659
	}
}