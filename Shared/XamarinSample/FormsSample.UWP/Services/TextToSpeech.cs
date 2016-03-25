using System;
using System.Threading.Tasks;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;
using FormsSample.Services;
using FormsSample.UWP.Services;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeech))]
namespace FormsSample.UWP.Services
{
    public class TextToSpeech: ITextToSpeech
    {
        public async Task Speak(string text)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            SpeechSynthesisStream stream = await speech.SynthesizeTextToStreamAsync(text);
            MediaElement element = new MediaElement();
            element.SetSource(stream, stream.ContentType);
            element.Play();
        }
    }
}
