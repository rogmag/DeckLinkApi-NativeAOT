#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[Guid("652615D4-26CD-4514-B161-2FD5072ED008")]
	public partial class CDeckLinkDiscovery_v10_11Class : IDeckLinkDiscovery, CDeckLinkDiscovery_v10_11
	{
		// Not compatible with Native AOT
		//public virtual extern void InstallDeviceNotifications(IDeckLinkDeviceNotificationCallback deviceNotificationCallback);

		public virtual void InstallDeviceNotifications(IDeckLinkDeviceNotificationCallback deviceNotificationCallback)
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}

		// Not compatible with Native AOT
		//public virtual extern void UninstallDeviceNotifications();

		public virtual void UninstallDeviceNotifications()
		{
			// Won't be thrown - the source generator creates a new implementation
			throw new NotImplementedException();
		}
	}
}