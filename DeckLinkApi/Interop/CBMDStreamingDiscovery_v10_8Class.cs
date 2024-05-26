#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[Guid("0CAA31F6-8A26-40B0-86A4-BF58DCCA710C")]
	public partial class CBMDStreamingDiscovery_v10_8Class : IBMDStreamingDiscovery, CBMDStreamingDiscovery_v10_8
	{
		public virtual extern void InstallDeviceNotifications(IBMDStreamingDeviceNotificationCallback theCallback);

		public virtual extern void UninstallDeviceNotifications();
	}
}