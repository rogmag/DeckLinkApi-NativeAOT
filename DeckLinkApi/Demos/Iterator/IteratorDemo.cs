using DeckLinkApi.Interop;

namespace DeckLinkApi.Demos.Iterator
{
	internal class IteratorDemo
	{
		public static void Run()
		{
			var deckLinkIterator = CDeckLinkIteratorClass.CreateInstance();
			
			IDeckLink deckLink;

			while ((deckLink = deckLinkIterator.Next()) != null)
			{
				if (deckLink is IDeckLinkProfileAttributes deckLinkAttributes)
				{
					var name = deckLinkAttributes.GetString(BMDDeckLinkAttributeID.BMDDeckLinkDisplayName);
					var ioSupport = (BMDVideoIOSupport)deckLinkAttributes.GetInt(BMDDeckLinkAttributeID.BMDDeckLinkVideoIOSupport);
					var supportsInputFormatDetection = deckLinkAttributes.GetFlag(BMDDeckLinkAttributeID.BMDDeckLinkSupportsInputFormatDetection);
					var duplexMode = (BMDDuplexMode)deckLinkAttributes.GetInt(BMDDeckLinkAttributeID.BMDDeckLinkDuplex);
					// Could also use the GetEnum extension method
					// var duplexMode = deckLinkAttributes.GetEnum<BMDDuplexMode>(BMDDeckLinkAttributeID.BMDDeckLinkDuplex);

					Console.WriteLine(name);
					Console.WriteLine($"            IO Support: {ioSupport}");
					Console.WriteLine($"Input Format Detection: {supportsInputFormatDetection}");
					Console.WriteLine($"           Duplex Mode: {duplexMode}");
				}

				if (deckLink is IDeckLinkStatus deckLinkStatus)
				{
					var inputMode = (BMDDisplayMode)deckLinkStatus.GetInt(BMDDeckLinkStatusID.bmdDeckLinkStatusDetectedVideoInputMode);
					var inputColorspace = (BMDColorspace)deckLinkStatus.GetInt(BMDDeckLinkStatusID.bmdDeckLinkStatusDetectedVideoInputColorspace);
					var inputDynamicRange = (BMDDynamicRange)deckLinkStatus.GetInt(BMDDeckLinkStatusID.bmdDeckLinkStatusDetectedVideoInputDynamicRange);
					var inputPixelFormat = (BMDPixelFormat)deckLinkStatus.GetInt(BMDDeckLinkStatusID.bmdDeckLinkStatusCurrentVideoInputPixelFormat);

					Console.WriteLine($"            Input Mode: {inputMode}");
					Console.WriteLine($"      Input Colorspace: {inputColorspace}");
					Console.WriteLine($"   Input Dynamic Range: {inputDynamicRange}");
					Console.WriteLine($"    Input Pixel Format: {inputPixelFormat}");
				}

				Console.WriteLine();
			}
		}
	}
}
