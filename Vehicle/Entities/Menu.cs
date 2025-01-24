using System;
using System.Text;
using Vehicle.Entities.Services;
using Vehicle.Entities.Enums;

namespace Vehicle.Entities
{
    public class Menu
    {
        public static bool Show()
        {
            OrderVehicleService service = new OrderVehicleService();
            
            Console.WriteLine("===== | GERENCIADOR DE VEÍCULOS | =====");
            Console.WriteLine();
            Console.WriteLine("=== Selecione uma opção ===");
            Console.WriteLine("(1) Adicionar veículo");
            Console.WriteLine("(2) Remover veículo");
            Console.WriteLine("(3) Mostrar veículo específico");
            Console.WriteLine("(4) Mostrar todos os veículos da garagem");
            Console.WriteLine("(5) Fechar programa");
            Console.WriteLine();
            Console.Write("Opção: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1 :
                    Console.WriteLine();
                    Console.WriteLine("Insira o tipo do veículo:");
                    Console.WriteLine();
                    Console.Write("Tipos disponíveis: ");
                    foreach (Enums.Type type in Enum.GetValues(typeof(Enums.Type)))
                    {
                        if(type == Enums.Type.Moto)
                        {
                            Console.Write($"{type}, ");
                        }
                        else if(type == Enums.Type.Aeronave)
                        {
                            Console.Write($"{type.ToString().ToLower()}.");
                        }
                        else
                        {
                            Console.Write($"{type.ToString().ToLower()}, ");
                        }
                    }
                    Console.WriteLine();
                    Console.Write("Tipo: ");
                    string t = Console.ReadLine();
                    service.SetType((Enums.Type)Enum.Parse(typeof(Enums.Type), t, true));
                    
                    Console.WriteLine($"Insira o fabricante do {t}:");
                    string f = Console.ReadLine();
                    service.SetManufacturer(f);
                    
                    Console.WriteLine($"Insira o modelo do {t}:");
                    string m = Console.ReadLine();
                    service.SetManufacturer(m);
                    
                    Console.WriteLine($"Insira a cor do {t}:");
                    Console.WriteLine();
                    Console.WriteLine("Cores disponíveis:");
                    foreach (Enums.Color color in Enum.GetValues(typeof(Enums.Color)))
                    {
                        if(color == Enums.Color.Vermelho)
                        {

                            Console.Write($"{color}, ");
                        }
                        else if(color == Enums.Color.Laranja)
                        {
                            Console.Write($"{color.ToString().ToLower()}.");
                        }
                        else
                        {
                            Console.Write($"{color.ToString().ToLower()}, ");
                        }
                    }

                    Console.Write("Cor: ");
                    string c = Console.ReadLine();
                    service.SetColor((Enums.Color)Enum.Parse(typeof(Enums.Color), c, true));

                    Vehicle vehicle = new Vehicle(service);

                    VehicleInventory.AddVehicle(vehicle);
                    break;
                
                case 2 :
                    Console.WriteLine();
                    Console.Write("Insira a placa do veículo a ser removido: ");
                    string removePlate = Console.ReadLine().ToUpper();

                    Vehicle deleteVehicle = VehicleInventory.GetVehicle(removePlate);
                    VehicleInventory.DeleteVehicle(deleteVehicle);
                    System.Console.WriteLine($"{deleteVehicle} removido com sucesso.");
                    break;
                
                case 3 :
                    Console.WriteLine();
                    Console.Write("Insira a placa do veículo a ser mostrado: ");
                    string showPlate = Console.ReadLine().ToUpper();

                    Vehicle getVehicle = VehicleInventory.GetVehicle(showPlate);

                    System.Console.WriteLine();

                    VehicleInventory.ShowVehicle(getVehicle);
                    break;

                case 4 :
                    Console.WriteLine();
                    VehicleInventory.ShowInventory();
                    break;

                case 5 :
                    Console.WriteLine("Fechando o programa.");
                    return false;
                
                default :
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            return true;
        }
    }
}