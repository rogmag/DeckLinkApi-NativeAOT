namespace DeckLinkApi.Interop
{
	public partial class CDeckLinkVideoFrameAncillaryPacketsClass : ComHelper
	{
		private CDeckLinkVideoFrameAncillaryPacketsClass()
		{
		}

		public static IDeckLinkVideoFrameAncillaryPackets CreateInstance()
		{
			return CoCreateInstance<IDeckLinkVideoFrameAncillaryPackets, CDeckLinkVideoFrameAncillaryPacketsClass>();
		}
	}
}