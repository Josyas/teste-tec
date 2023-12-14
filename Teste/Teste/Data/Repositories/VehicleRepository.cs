using Microsoft.EntityFrameworkCore;
using Teste.Models;

namespace Teste.Data.Repositories
{
    public class VehicleRepository
    {
        private readonly VehicleContext _vehicleContext;

        public VehicleRepository()
        {
            _vehicleContext = new VehicleContext();
        }

        public async Task Insert(Vehicle vehicle)
        {
            _vehicleContext.Vehicles.Add(vehicle);
            await _vehicleContext.SaveChangesAsync();
        }

        public async Task Update(Vehicle vehicle)
        {
            _vehicleContext.Vehicles.Update(vehicle);
            await _vehicleContext.SaveChangesAsync();
        }

        public async Task Delete(Vehicle vehicle)
        {
            _vehicleContext.Vehicles.Remove(vehicle);
            await _vehicleContext.SaveChangesAsync();
        }

        public async Task<List<Vehicle>> GetAll()
        {
            var list = await _vehicleContext.Vehicles.AsNoTracking().ToListAsync();

            return list;
        }
    }
}
