using System;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using XamarinMVVM.Shared.Models;
using XamarinMVVM.Shared.Services;

namespace XamarinMVVM.UWP.Services
{
    public class LocatorService: ILocatorService
    {
        public async Task<Position> GetPositionAsync()
        {
            Geolocator locator = new Geolocator();
            Geoposition result = await locator.GetGeopositionAsync();
            Position position = new Position
            {
                Latitude = result.Coordinate.Point.Position.Latitude,
                Longitude = result.Coordinate.Point.Position.Longitude
            };

            return position;
        }
    }
}
