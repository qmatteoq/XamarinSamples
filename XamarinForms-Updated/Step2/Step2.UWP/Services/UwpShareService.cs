using System;
using Windows.ApplicationModel.DataTransfer;
using Step2.Services;
using Step2.UWP.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(UwpShareService))]
namespace Step2.UWP.Services
{
    public class UwpShareService : IShareService
    {
        private string _title;
        private string _url;

        public void Share(string title, string url)
        {
            _title = title;
            _url = url;

            DataTransferManager.GetForCurrentView().DataRequested += UwpShareService_DataRequested;
            DataTransferManager.ShowShareUI();
        }

        private void UwpShareService_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            args.Request.Data.Properties.Title = _title;
            args.Request.Data.Properties.Description = _title;
            args.Request.Data.SetWebLink(new Uri(_url));
        }
    }
}
