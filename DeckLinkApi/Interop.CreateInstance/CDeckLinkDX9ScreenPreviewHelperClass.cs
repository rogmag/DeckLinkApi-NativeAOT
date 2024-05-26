namespace DeckLinkApi.Interop
{
	public partial class CDeckLinkDX9ScreenPreviewHelperClass : ComHelper
	{
		private CDeckLinkDX9ScreenPreviewHelperClass()
		{
		}

		public static IDeckLinkDX9ScreenPreviewHelper CreateInstance()
		{
			return CoCreateInstance<IDeckLinkDX9ScreenPreviewHelper, CDeckLinkDX9ScreenPreviewHelperClass>();
		}
	}
}