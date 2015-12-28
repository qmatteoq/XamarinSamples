using System;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;
using XamarinForms.Step3.Services;
using XamarinForms.Step3.UWP.Services;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeech))]
namespace XamarinForms.Step3.UWP.Services
{
    public class TextToSpeech: ITextToSpeech
    {
        public async void Speak(string text)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            SpeechSynthesisStream stream = await synthesizer.SynthesizeTextToStreamAsync(text);
            MediaElement player = new MediaElement();
            player.SetSource(stream, stream.ContentType);
            player.Play();
        }
    }
}
