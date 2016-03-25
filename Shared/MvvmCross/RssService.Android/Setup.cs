using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform;
using RssService.Android.Services;
using RssService.Core.Services;

namespace RssService.Android
{
    public class Setup: MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override void InitializeFirstChance()
        {
            Mvx.RegisterType<IDialogService, DialogService>();
            base.InitializeFirstChance();
        }
    }
}