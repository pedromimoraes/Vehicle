using Vehicle.Entities;
using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;

// TODO: Implementar retorno Default no Vehicle.
// TODO: Corrigir as mensagens de erro nas 'string' das classes OrderVehicleService e VehicleInventory.
// TODO: Implementar a classe 'Program'.
// TODO: Implementar um menu para interação com o programa.
// TODO: Avaliar a aplicação do try-catch no meu código.

namespace Vehicle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderVehicleService order = new OrderVehicleService();

            order.SetType(Entities.Enums.Type.Carro);
            order.SetManufacturer("Fiat");
            order.SetModel("Uno");
            order.SetColor(Color.Cinza);

            Entities.Vehicle vehicle1 = new Entities.Vehicle(order);

            order.SetType(Entities.Enums.Type.Carro);
            order.SetManufacturer("Honda");
            order.SetModel("Civic");
            order.SetColor(Color.Preto);

            Entities.Vehicle vehicle2 = new Entities.Vehicle(order);

            VehicleInventory.AddVehicle(vehicle1);
            VehicleInventory.AddVehicle(vehicle2);

            VehicleInventory.ShowInventory();

        }
    }
}