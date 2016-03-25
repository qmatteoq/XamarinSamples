using System.Collections.Generic;
using System.Threading.Tasks;
using Android.OS;
using Android.Speech.Tts;
using FormsSample.Droid.Services;
using FormsSample.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechAndroid))]
namespace FormsSample.Droid.Services
{
   public class TextToSpeechAndroid: Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public TextToSpeechAndroid() { }

        public async Task Speak(string text)
        {
            var ctx = Forms.Context; // useful for many Android SDK features
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(ctx, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, Bundle.Empty, string.Empty);
            }

            await Task.Yield();
        }

        #region IOnInitListener implementation
        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }
        #endregion
    }
}