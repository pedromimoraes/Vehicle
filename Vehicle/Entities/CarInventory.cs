using System.Collections.Generic;
using Vehicle.Entities;

namespace Vehicle.Entities
{
    /// <summary>
    /// Esta classe é utilizada para armazenar e gerenciar os veículos criados através de métodos CRUD.
    /// </summary>
    /// <example>
    /// Exemplo de uso:
    /// <code>
    /// Car car = new Car();
    /// CarInventory.AddCar(car);
    /// </code>
    /// </example>
    public static class CarInventory
    {
        /// <summary>
        /// Esta propriedade representa uma lista de veículos.
        /// </summary>
        /// <value>
        /// Uma lista de veículos. Por exemplo: List<Car> Cars = new List<Car>();
        /// </value>
        public static List<Car> Cars { get; private set; } = new List<Car>();

        /// <summary>
        /// Este método adiciona à lista  <see cref="Cars"\> um veículo informado como parâmetro.
        /// </summary>
        /// <param name="car"></param>
        public static void AddCar(Car car)
        {
            Cars.Add(car);
        }
        /// <summary>
        /// Este método retorna da lista <see cref="Cars"/> um veículo que tenha a placa correspondente à placa informada como parâmetro.
        /// </summary>
        /// <param name="plate"></param>
        /// <returns>
        /// Um veículo contendo a placa correspondente à placa informada como parâmetro.
        /// <example>
        /// Exemplo de uso:
        /// <code>
        /// Car car = CarInventory.GetCar("BRA-1B23");
        /// Console.WriteLine(car); // Retorna um veículo com a placa correspondente.
        /// </code>
        ///</example>
        /// </returns>
        public static Car GetCar(string plate)
        {
            return Cars.FirstOrDefault(car => car.Plate == plate);
        }
        /// <summary>
        /// Este método remove da lista: <see cref="Cars"/> o veículo informado como parâmetro.
        /// </summary>
        /// <param name="car"></param>
        /// <example>
        /// Exemplo de uso:
        /// <code>
        /// CarInventory.DeleteCar(car); // Remove o carro informado como parâmetro.
        /// </code>
        /// </example>
        public static void DeleteCar(Car car)
        {
            Cars.Remove(car);
        }
    }
}