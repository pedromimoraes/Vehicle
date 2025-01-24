using System.Collections.Generic;
using Vehicle.Entities;
using Vehicle.Entities.Services;
namespace Vehicle.Entities
{
    /// <summary>
    /// Esta classe é utilizada para armazenar e gerenciar os veículos criados via métodos CRUD.
    /// </summary>
    /// <example>
    /// Exemplo de uso:
    /// <code>
    /// Vehicle vehicle = new Vehicle();
    /// VehicleInventory.AddVehicle(vehicle);
    /// </code>
    /// </example>
    public static class VehicleInventory
    {
        /// <summary>
        /// Esta propriedade representa uma lista de veículos.
        /// </summary>
        private static List<Vehicle> Vehicles { get;  set; } = new List<Vehicle>();

        /// <summary>
        /// Este método adiciona à lista  <see cref="Vehicles"/> um veículo informado como parâmetro.
        /// </summary>
        /// <param name="vehicle"></param>
        public static void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
        /// <summary>
        /// Este método retorna da lista <see cref="Vehicles"/> um veículo que tenha a placa correspondente à placa informada como parâmetro.
        /// </summary>
        /// <param name="plate"></param>
        /// <returns>
        /// Um veículo contendo a placa correspondente à placa informada como parâmetro.
        /// <example>
        /// Exemplo de uso:
        /// <code>
        /// Vehicle vehicle = VehicleInventory.GetVehicle("BRA-1B23");
        /// Console.WriteLine(vehicle); // Retorna um veículo com a placa correspondente.
        /// </code>
        /// </example>
        /// </returns>
        public static Vehicle? GetVehicle(string plate)
        {
            return Vehicles.FirstOrDefault(vehicle => vehicle.Plate == plate);
        }

        /// <summary>
        /// Este método remove da lista: <see cref="Vehicles"/> o veículo informado como parâmetro.
        /// </summary>
        /// <param name="vehicle"></param>
        /// <example>
        /// Exemplo de uso:
        /// <code>
        /// VehicleInventory.DeleteVehicle(Vehicle); // Remove o carro informado como parâmetro.
        /// </code>
        /// </example>
        public static void DeleteVehicle(Vehicle vehicle)
        {
            Vehicles.Remove(vehicle);
        }

        public static void ShowVehicle(Vehicle vehicle)
        { 
            System.Console.WriteLine($"{vehicle.Type}, {vehicle.Manufacturer} {vehicle.Model} {vehicle.Color}, {vehicle.Plate}");
        }

        /// <summary>
        /// Este método apresenta todos os veículos armazenados na lista: <see cref="Vehicles"/>.
        /// </summary>
        /// <example>
        /// Exemplo de uso:
        /// <code>
        /// VehicleInventory.ShowInventory();
        /// Carro Fiat Uno Cinza, WCV-4O51 // Exemplo de saída.
        /// Carro Honda Civic Preto, RKH-8O0 // Exemplo de saída.
        /// </code>
        /// </example>
        public static void ShowInventory()
        {
            foreach(Vehicle vehicle in Vehicles)
            {
                System.Console.WriteLine($"{vehicle.Type}, {vehicle.Manufacturer} {vehicle.Model} {vehicle.Color}, {vehicle.Plate}");
            }
        }
    }
}