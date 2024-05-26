namespace DeckLinkApi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Demos.Iterator.IteratorDemo.Run(); // Shows the IDeckLinkIterator, as well as profile attributes and status items (IDeckLinkProfileAttributes and IDeckLinkStatus)

			//Demos.Discovery.DiscoveryDemo.Run();

			//Demos.Capture.CaptureDemo.Run();
		}
	}
}
