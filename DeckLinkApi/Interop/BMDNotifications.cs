namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDNotifications enumerates the possible notifications for DeckLink devices.
	/// </summary>
	public enum BMDNotifications
	{
		/// <summary>
		/// The preferences have changed. This occurs when <see cref="IDeckLinkConfiguration.WriteConfigurationToPreferences"/> is called, or when the preference settings are saved in the Blackmagic Design Control Panel. The param1 and param2 parameters are 0.
		/// </summary>
		bmdPreferencesChanged = 1886545254,
		
		/// <summary>
		/// A status information item has changed. The param1 parameter contains the <see cref="BMDDeckLinkStatusID"/> of the status information item which changed; param2 is 0. Use the <see cref="IDeckLinkStatus"/> interface to retrieve the new status.
		/// </summary>
		bmdStatusChanged = 1937006964,

		bmdDeviceRemoved = 1685218669,

		bmdHardwareConfigurationChanged = 1752656227
	}
}