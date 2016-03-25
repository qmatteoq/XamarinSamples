using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using RssService.Core.Services;

namespace RssService.UWP.Services
{
    public class DialogService: IDialogService
    {
        public async Task ShowDialogAsync(string message)
        {
            MessageDialog dialog = new MessageDialog(message);
            await dialog.ShowAsync();
        }
    }
}
