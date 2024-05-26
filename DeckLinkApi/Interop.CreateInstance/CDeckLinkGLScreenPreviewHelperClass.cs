namespace DeckLinkApi.Interop
{
	public partial class CDeckLinkGLScreenPreviewHelperClass : ComHelper
	{
		private CDeckLinkGLScreenPreviewHelperClass()
		{
		}

		public static IDeckLinkGLScreenPreviewHelper CreateInstance()
		{
			return CoCreateInstance<IDeckLinkGLScreenPreviewHelper, CDeckLinkGLScreenPreviewHelperClass>();
		}
	}
}