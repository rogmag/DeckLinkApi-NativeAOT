#pragma warning disable CS0626 // "Method, operator, or accessor is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation."

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	[GeneratedComClass]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("23A4EDF5-A0E5-432C-94EF-3BABB5F81C82")]
	public partial class CBMDStreamingDiscoveryClass : IBMDStreamingDiscovery, CBMDStreamingDiscovery
	{
		// Not compatible with Native AOT
		//public virtual extern void InstallDeviceNotifications(IBMDStreamingDeviceNotificationCallback theCallback);

		public virtual void InstallDeviceNotifications(IBMDStreamingDeviceNotificationCallback theCallback)
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