using Teste.Data.Repositories;
using Teste.Models;

namespace Teste.Service
{
    public class VehicleService
    {
        private readonly VehicleRepository _vehicleRepository = new();

        public async Task SaveVehicle(Vehicle vehicle)
        {
            await _vehicleRepository.Insert(vehicle);
        }

        public async Task UpdateVehicle(Vehicle vehicle)
        {
            await _vehicleRepository.Update(vehicle);
        }

        public async Task DeleteVehicle(Vehicle vehicle)
        {
           await _vehicleRepository.Delete(vehicle);
        }

        public async Task<List<Vehicle>> GetAllVehicle()
        {
            return await _vehicleRepository.GetAll();
        }
    }
}
