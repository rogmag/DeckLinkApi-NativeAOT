using DeckLinkApi.Interop;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Demos.Discovery
{
	public class DeckLinkDiscoveryEventArgs : EventArgs
	{
		public IDeckLink DeckLink { get; }

		public DeckLinkDiscoveryEventArgs(IDeckLink deckLink)
		{
			this.DeckLink = deckLink;
		}
	}

	[GeneratedComClass]
	public partial class DeckLinkDiscovery : IDeckLinkDiscovery, IDeckLinkDeviceNotificationCallback, IDisposable
	{
		public event EventHandler<DeckLinkDiscoveryEventArgs>? DeviceArrived;
		public event EventHandler<DeckLinkDiscoveryEventArgs>? DeviceRemoved;

		private readonly IDeckLinkDiscovery deckLinkDiscovery;

		public DeckLinkDiscovery()
		{
			deckLinkDiscovery = CDeckLinkDiscoveryClass.CreateInstance();
		}

		public void InstallDeviceNotifications()
		{
			deckLinkDiscovery.InstallDeviceNotifications(this);
		}

		protected virtual void OnDeviceArrived(DeckLinkDiscoveryEventArgs e)
		{
			DeviceArrived?.Invoke(this, e);
		}

		protected virtual void OnDeviceRemoved(DeckLinkDiscoveryEventArgs e)
		{
			DeviceRemoved?.Invoke(this, e);
		}

		#region IDeckLinkDiscovery

		public void InstallDeviceNotifications(IDeckLinkDeviceNotificationCallback deviceNotificationCallback)
		{
			deckLinkDiscovery.InstallDeviceNotifications(deviceNotificationCallback);
		}

		public void UninstallDeviceNotifications()
		{
			deckLinkDiscovery.UninstallDeviceNotifications();
		}

		#endregion

		#region IDeckLinkDeviceNotificationCallback

		public void DeckLinkDeviceArrived(IDeckLink deckLinkDevice)
		{
			OnDeviceArrived(new DeckLinkDiscoveryEventArgs(deckLinkDevice));
		}

		public void DeckLinkDeviceRemoved(IDeckLink deckLinkDevice)
		{
			OnDeviceRemoved(new DeckLinkDiscoveryEventArgs(deckLinkDevice));
		}

		#endregion

		#region IDisposable

		private bool disposedValue;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					//Dispose managed state (managed objects)
				}

				//Free unmanaged resources
				deckLinkDiscovery.UninstallDeviceNotifications();

				disposedValue = true;
			}
		}

		~DeckLinkDiscovery()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		#endregion
	}
}
