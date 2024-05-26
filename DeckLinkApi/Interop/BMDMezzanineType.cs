using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDMezzanineType enumerates the possible mezzanine boards which can be optionally attached to some DeckLink devices.
	/// <para>NOTE: Applications should check the available interfaces using <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoOutputConnections"/> and <see cref="BMDDeckLinkAttributeID.BMDDeckLinkVideoInputConnections"/> for a particular subdevice rather than expecting interfaces here to be available on any particular subdevice.</para>
	/// </summary>
	public enum BMDMezzanineType
	{
		/// <summary>
		/// No mezzanine board
		/// </summary>
		bmdMezzanineTypeNone = 0,

		/// <summary>
		/// Mezzanine board with HDMI 1.4 and Optical SDI
		/// </summary>
		bmdMezzanineTypeHDMI14OpticalSDI = 1836736817,

		/// <summary>
		/// Mezzanine board with four SDI connectors
		/// </summary>
		bmdMezzanineTypeQuadSDI = 1836725363,

		/// <summary>
		/// Mezzanine board with HDMI 2.0 and Optical SDI
		/// </summary>
		bmdMezzanineTypeHDMI20OpticalSDI = 1836736818,

		/// <summary>
		/// Mezzanine boards with HDMI 2.1 and RS422
		/// </summary>
		bmdMezzanineTypeHDMI21RS422 = 1836738674
	}
}