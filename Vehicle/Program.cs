using Vehicle.Entities;
using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;

// TODO: Adicionar comentários XML à classe CarInventory.
// TODO: Adicionar comentários XML à classe Car.
// TODO: Substituir a classe 'Car' por 'Vehicle'.
// TODO: Criar uma nova classe 'Car' herdando as características de 'Vehicle'.
// TODO: Aplicar polimorfismo na classe Program se utilizando da classe 'Car' e 'Vehicle'.

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