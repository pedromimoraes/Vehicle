using Vehicle.Entities;
using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;

// TODO: Adicionar comentários XML à classe CarInventory.
//TODO: Adicionar comentários XML à classe Car.
namespace Vehicle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderCarService service = new OrderCarService();
            
            Console.Write("Insira o fabricante do carro: ");
            service.SetManufacturer(Console.ReadLine());
            
            Console.Write("Insira o modelo do carro: ");
            service.SetModel(Console.ReadLine());
            
            Console.Write("Insira a cor do carro: ");
            string cor = Console.ReadLine();

            if (Enum.TryParse(cor, true, out Color color))
            {
                service.SetColor(color);
            }
            else
            {
                Console.WriteLine("Cor invalida! Usando cor padrão.");
                service.SetColor(Color.Preto);
            }
            Car car = new Car(service);

            Console.WriteLine(car);
        }
    }
}