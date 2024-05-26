namespace DeckLinkApi.Interop
{
	public partial class CDeckLinkVideoConversionClass : ComHelper
	{
		private CDeckLinkVideoConversionClass()
		{
		}

		public static IDeckLinkVideoConversion CreateInstance()
		{
			return CoCreateInstance<IDeckLinkVideoConversion, CDeckLinkVideoConversionClass>();
		}
	}
}