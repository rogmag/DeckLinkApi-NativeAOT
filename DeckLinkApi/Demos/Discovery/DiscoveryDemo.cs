namespace DeckLinkApi.Demos.Discovery
{
	internal class DiscoveryDemo
	{
		public static void Run()
		{
			using (var deckLinkDiscovery = new DeckLinkDiscovery())
			{
		 		deckLinkDiscovery.DeviceArrived += (sender, e) =>
		 		{
		 			Console.WriteLine($"Device arrived: {e.DeckLink.GetModelName()}");
		 		};
		 
		 		deckLinkDiscovery.DeviceRemoved += (sender, e) =>
		 		{
		 			Console.WriteLine($"Device removed: {e.DeckLink.GetModelName()}");
		 		};
		 
		 		deckLinkDiscovery.InstallDeviceNotifications();
		 
		 		Console.ReadLine();

		 		// UninstallDeviceNotifications() will be run automatically when deckLinkDiscovery is disposed
			}
		}
	}
}
