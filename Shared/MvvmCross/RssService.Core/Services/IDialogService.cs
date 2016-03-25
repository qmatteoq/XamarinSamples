using System.Threading.Tasks;

namespace RssService.Core.Services
{
    public interface IDialogService
    {
        Task ShowDialogAsync(string message);
    }
}
