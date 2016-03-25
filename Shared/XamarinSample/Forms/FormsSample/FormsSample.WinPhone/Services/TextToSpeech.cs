using System;
using System.Threading.Tasks;
using Windows.Phone.Speech.Synthesis;
using FormsSample.Services;
using FormsSample.WinPhone.Services;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeech))]
namespace FormsSample.WinPhone.Services
{
    public class TextToSpeech: ITextToSpeech
    {
        public async Task Speak(string text)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            await speech.SpeakTextAsync(text);
        }
    }
}
