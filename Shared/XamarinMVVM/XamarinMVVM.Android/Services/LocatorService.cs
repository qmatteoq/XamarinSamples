using System.Threading.Tasks;
using Android.Content;
using Android.Locations;
using GalaSoft.MvvmLight.Views;
using XamarinMVVM.Shared.Models;
using XamarinMVVM.Shared.Services;

namespace XamarinMVVM.Android.Services
{
    public class LocatorService: ILocatorService
    {
        public Task<Position> GetPositionAsync()
        {
            LocationManager locationManager = ActivityBase.CurrentActivity.GetSystemService(Context.LocationService) 
                as LocationManager;

            Location location = locationManager.GetLastKnownLocation(LocationManager.GpsProvider);

            Position position = new Position
            {
                Latitude = location.Latitude,
                Longitude = location.Longitude
            };

            return Task.FromResult<Position>(position);
        }
    }
}