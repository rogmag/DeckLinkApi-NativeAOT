namespace DeckLinkApi.Interop
{
	public partial class CBMDStreamingDiscoveryClass : ComHelper
	{
		private CBMDStreamingDiscoveryClass()
		{
		}

		public static IBMDStreamingDiscovery CreateInstance()
		{
			return CoCreateInstance<IBMDStreamingDiscovery, CBMDStreamingDiscoveryClass>();
		}
	}
}