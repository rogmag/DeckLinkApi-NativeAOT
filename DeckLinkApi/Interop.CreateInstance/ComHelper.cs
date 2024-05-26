using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DeckLinkApi.Interop
{
	public abstract partial class ComHelper
	{
		private static partial class Ole32
		{
			[LibraryImport("Ole32")]
			internal static partial int CoCreateInstance(Guid rclsid, IntPtr pUnkOuter, int dwClsContext, Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object ppObj);
		}

		/// <summary>
		/// No need to release the instanciated object, it will be released automatically by the GC as it's marshalled by the UniqueComInterfaceMarshaller.
		/// </summary>
		private protected static TInterface CoCreateInstance<TInterface, TClass>() where TInterface : class where TClass : class, TInterface
		{
			Guid clsid = typeof(TClass).GUID;
			Guid iid = typeof(TInterface).GUID;

			int result = Ole32.CoCreateInstance(clsid, IntPtr.Zero, 23 /*CLSCTX_ALL*/, iid, out object obj);

			if (result != 0)
			{
				Marshal.ThrowExceptionForHR(result);
			}

			return obj as TInterface ?? throw new NullReferenceException();
		}
	}
}