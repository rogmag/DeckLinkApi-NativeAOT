namespace DeckLinkApi.Interop
{
	public partial class CDeckLinkDiscoveryClass : ComHelper
	{
		private CDeckLinkDiscoveryClass()
		{
		}

		public static IDeckLinkDiscovery CreateInstance()
		{
			return CoCreateInstance<IDeckLinkDiscovery, CDeckLinkDiscoveryClass>();
		}
	}
}