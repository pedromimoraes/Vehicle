using Vehicle.Entities;
using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;

// TODO: Adicionar comentários XML à classe Vehicle.
// TODO: Aplicar polimorfismo na classe Program se utilizando da classe 'Car' e 'Vehicle'.
// TODO: Transformar o serviço OrderClassService em OrderVehicleService.

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