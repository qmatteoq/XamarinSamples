using System;
using System.Threading.Tasks;
using CoreLocation;
using XamarinMVVM.Shared.Models;
using XamarinMVVM.Shared.Services;

namespace XamarinMVVM.iOS.Services
{
    public class LocatorService: ILocatorService
    {
        public Task<Position> GetPositionAsync()
        {
            //CLLocationManager manager = new CLLocationManager();
            //manager.RequestWhenInUseAuthorization();
            //manager.RequestLocation();

            Position position = new Position
            {
                Latitude = 120.29385,
                Longitude = 9.19485746748
            };

            return Task.FromResult(position);
        }
    }
}
