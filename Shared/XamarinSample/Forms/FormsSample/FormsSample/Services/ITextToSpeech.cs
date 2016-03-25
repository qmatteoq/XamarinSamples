using System.Threading.Tasks;

namespace FormsSample.Services
{
    public interface ITextToSpeech
    {
        Task Speak(string text);
    }
}
