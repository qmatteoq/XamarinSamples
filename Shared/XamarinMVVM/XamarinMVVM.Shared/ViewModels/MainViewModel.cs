using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using XamarinMVVM.Shared.Models;
using XamarinMVVM.Shared.Services;

namespace XamarinMVVM.Shared.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private readonly ILocatorService _locatorService;
        public MainViewModel(ILocatorService locatorService)
        {
            _locatorService = locatorService;
        }

        private RelayCommand _getPositionCommand;

        public RelayCommand GetPositionCommand
        {
            get
            {
                if (_getPositionCommand == null)
                {
                    _getPositionCommand = new RelayCommand(async () =>
                    {
                        Position position = await _locatorService.GetPositionAsync();
                        Coordinates = $"{position.Latitude},{position.Longitude}";
                    });
                }

                return _getPositionCommand;
            }
        }

        private string _coordinates;

        public string Coordinates
        {
            get { return _coordinates; }
            set { Set(ref _coordinates, value); }
        }
    }
}
