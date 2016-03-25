using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using RssService.Core.Services;
using RssService.Core.ViewModels;

namespace RssService.Core
{
    public class App: MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IRssService, Services.RssService>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainViewModel>());
        }
    }
}
