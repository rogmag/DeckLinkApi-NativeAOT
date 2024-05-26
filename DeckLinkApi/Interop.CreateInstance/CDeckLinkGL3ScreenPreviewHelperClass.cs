namespace DeckLinkApi.Interop
{
	public partial class CDeckLinkGL3ScreenPreviewHelperClass : ComHelper
	{
		private CDeckLinkGL3ScreenPreviewHelperClass()
		{
		}

		public static IDeckLinkGLScreenPreviewHelper CreateInstance()
		{
			return CoCreateInstance<IDeckLinkGLScreenPreviewHelper, CDeckLinkGL3ScreenPreviewHelperClass>();
		}
	}
}