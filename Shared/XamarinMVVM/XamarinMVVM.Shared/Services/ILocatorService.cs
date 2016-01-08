using System.Threading.Tasks;
using XamarinMVVM.Shared.Models;

namespace XamarinMVVM.Shared.Services
{
    public interface ILocatorService
    {
        Task<Position> GetPositionAsync();
    }
}
