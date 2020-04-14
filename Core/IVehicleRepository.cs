using System.Threading.Tasks;
using vega.Core.Models;

namespace vega.Core
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeReleted = true);
         void Add(Vehicle vehicle);
         void Remove(Vehicle vehicle);
    }
}