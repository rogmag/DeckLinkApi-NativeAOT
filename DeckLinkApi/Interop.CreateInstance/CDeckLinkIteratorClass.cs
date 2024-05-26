namespace DeckLinkApi.Interop
{
	public partial class CDeckLinkIteratorClass : ComHelper
	{
		private CDeckLinkIteratorClass()
		{
		}

		public static IDeckLinkIterator CreateInstance()
		{
			return CoCreateInstance<IDeckLinkIterator, CDeckLinkIteratorClass>();
		}
	}
}