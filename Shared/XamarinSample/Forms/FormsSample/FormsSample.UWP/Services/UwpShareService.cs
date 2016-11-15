﻿using System;
using Windows.ApplicationModel.DataTransfer;
using FormsSample.Services;
using FormsSample.UWP.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(UwpShareService))]
namespace FormsSample.UWP.Services
{
    public class UwpShareService : IShareService
    {
        private string _title;
        private string _url;

        public UwpShareService()
        {
            DataTransferManager.GetForCurrentView().DataRequested += UwpShareService_DataRequested;
        }

        public void Share(string title, string url)
        {
            _title = title;
            _url = url;

            try
            {
                DataTransferManager.ShowShareUI();
            }
            catch { }
        }

        private void UwpShareService_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            var deferral = args.Request.GetDeferral();
            args.Request.Data.Properties.Title = _title;
            args.Request.Data.Properties.Description = _title;
            args.Request.Data.SetWebLink(new Uri(_url));
            deferral.Complete();
        }
    }
}
