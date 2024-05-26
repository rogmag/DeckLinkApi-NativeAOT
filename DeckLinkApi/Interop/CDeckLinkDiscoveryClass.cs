#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[Guid("22FBFC33-8D07-495C-A5BF-DAB5EA9B82DB")]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	public partial class CDeckLinkDiscoveryClass : IDeckLinkDiscovery, CDeckLinkDiscovery
	{
		public virtual extern void InstallDeviceNotifications(IDeckLinkDeviceNotificationCallback deviceNotificationCallback);

		public virtual extern void UninstallDeviceNotifications();
	}
}