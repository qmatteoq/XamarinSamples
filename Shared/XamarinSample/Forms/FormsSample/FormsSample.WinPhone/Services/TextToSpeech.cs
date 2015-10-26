using System;
using Windows.Phone.Speech.Synthesis;
using FormsSample.Services;
using FormsSample.WinPhone.Services;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeech))]
namespace FormsSample.WinPhone.Services
{
    public class TextToSpeech: ITextToSpeech
    {
        public async void Speak(string text)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            await speech.SpeakTextAsync(text);
        }
    }
}
