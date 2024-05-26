using System.Buffers.Text;

namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMD3DPreviewFormat enumerates the dual preview formats available for the DeckLink screen preview. The OpenGL based preview format can be set using <see cref="IDeckLinkGLScreenPreviewHelper.Set3DPreviewFormat"/>. The DirectX based preview format can be set using <see cref="IDeckLinkDX9ScreenPreviewHelper.Set3DPreviewFormat"/>.
	/// </summary>
	public enum BMD3DPreviewFormat
	{
		/// <summary>
		/// Preview frames in the default top-bottom format.
		/// </summary>
		bmd3DPreviewFormatDefault = 1684366945,

		/// <summary>
		/// Preview the left eye frame only.
		/// </summary>
		bmd3DPreviewFormatLeftOnly = 1818584692,

		/// <summary>
		/// Preview the right eye frame only.
		/// </summary>
		bmd3DPreviewFormatRightOnly = 1919510376,

		/// <summary>
		/// Preview the frames frame in side by side format.
		/// </summary>
		bmd3DPreviewFormatSideBySide = 1936286821,

		/// <summary>
		/// Preview the frames in top-bottom format.
		/// </summary>
		bmd3DPreviewFormatTopBottom = 1953460322
	}
}