namespace DeckLinkApi.Interop
{
	/// <summary>
	/// BMDDeckControlError enumerates the possible deck control errors.
	/// </summary>
	public enum BMDDeckControlError
	{
		bmdDeckControlNoError = 1852794226,

		/// <summary>
		/// The deck is not in the correct mode for the desired operation. Eg. A play command is issued, but the current mode is not VTRControlMode
		/// </summary>
		bmdDeckControlModeError = 1836017010,

		/// <summary>
		/// The in point was missed while prerolling as the current timecode has passed the begin in / capture timecode.
		/// </summary>
		bmdDeckControlMissedInPointError = 1835623794,

		/// <summary>
		/// Deck control timeout error.
		/// </summary>
		bmdDeckControlDeckTimeoutError = 1685349746,

		/// <summary>
		/// A deck control command request has failed.
		/// </summary>
		bmdDeckControlCommandFailedError = 1667655026,

		/// <summary>
		/// The deck control device is already open.
		/// </summary>
		bmdDeckControlDeviceAlreadyOpenedError = 1684106351,

		/// <summary>
		/// Deck control failed to open the serial device.
		/// </summary>
		bmdDeckControlFailedToOpenDeviceError = 1717855602,

		/// <summary>
		/// The deck in local mode and is no longer controllable.
		/// </summary>
		bmdDeckControlInLocalModeError = 1819108722,

		/// <summary>
		/// Deck control has reached or is trying to move past the end of the tape.
		/// </summary>
		bmdDeckControlEndOfTapeError = 1702126962,

		/// <summary>
		/// Abort an export-to-tape or capture operation.
		/// </summary>
		bmdDeckControlUserAbortError = 1969317234,

		/// <summary>
		/// There is currently no tape in the deck.
		/// </summary>
		bmdDeckControlNoTapeInDeckError = 1853121906,

		/// <summary>
		/// A capture or export operation was attempted when the input signal was invalid.
		/// </summary>
		bmdDeckControlNoVideoFromCardError = 1853253219,

		/// <summary>
		/// The deck is not responding to requests.
		/// </summary>
		bmdDeckControlNoCommunicationError = 1852010349,

		/// <summary>
		/// When sending a custom command, either the internal buffer is too small for the provided custom command (reduce the size of the custom command), or the buffer provided for the command’s response is too small (provide a larger one).
		/// </summary>
		bmdDeckControlBufferTooSmallError = 1651798893,

		/// <summary>
		/// When sending a custom command, the deck’s response contained an invalid checksum.
		/// </summary>
		bmdDeckControlBadChecksumError = 1667787635,

		/// <summary>
		/// Deck control unknown error.
		/// </summary>
		bmdDeckControlUnknownError = 1970169202
	}
}