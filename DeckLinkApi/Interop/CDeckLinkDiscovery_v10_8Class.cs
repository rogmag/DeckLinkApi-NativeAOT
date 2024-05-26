#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[Guid("1073A05C-D885-47E9-B3C6-129B3F9F648B")]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	public partial class CDeckLinkDiscovery_v10_8Class : IDeckLinkDiscovery, CDeckLinkDiscovery_v10_8
	{
		public virtual extern void InstallDeviceNotifications(IDeckLinkDeviceNotificationCallback deviceNotificationCallback);

		public virtual extern void UninstallDeviceNotifications();
	}
}