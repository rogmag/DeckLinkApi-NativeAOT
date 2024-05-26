namespace DeckLinkApi.Interop
{
	public partial class CDeckLinkWPFDX9ScreenPreviewHelperClass : ComHelper
	{
		private CDeckLinkWPFDX9ScreenPreviewHelperClass()
		{
		}

		public static IDeckLinkWPFDX9ScreenPreviewHelper CreateInstance()
		{
			return CoCreateInstance<IDeckLinkWPFDX9ScreenPreviewHelper, CDeckLinkWPFDX9ScreenPreviewHelperClass>();
		}
	}
}