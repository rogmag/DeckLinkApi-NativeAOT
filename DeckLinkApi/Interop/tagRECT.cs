using System.Runtime.InteropServices;

namespace DeckLinkApi.Interop
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct tagRECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}
}