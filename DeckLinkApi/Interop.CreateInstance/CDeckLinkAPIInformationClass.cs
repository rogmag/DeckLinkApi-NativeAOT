namespace DeckLinkApi.Interop
{
	public partial class CDeckLinkAPIInformationClass : ComHelper
	{
        private CDeckLinkAPIInformationClass()
        {
        }

        public static IDeckLinkAPIInformation CreateInstance()
		{
			return CoCreateInstance<IDeckLinkAPIInformation, CDeckLinkAPIInformationClass>();
		}
	}
}