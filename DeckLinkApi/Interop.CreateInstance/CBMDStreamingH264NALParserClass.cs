namespace DeckLinkApi.Interop
{
	public partial class CBMDStreamingH264NALParserClass : ComHelper
	{
		private CBMDStreamingH264NALParserClass()
		{
		}

		public static IBMDStreamingH264NALParser CreateInstance()
		{
			return CoCreateInstance<IBMDStreamingH264NALParser, CBMDStreamingH264NALParserClass>();
		}
	}
}