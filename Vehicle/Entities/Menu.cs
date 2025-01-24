using System;
using System.Text;
using Vehicle.Entities.Services;
using Vehicle.Entities.Enums;

namespace Vehicle.Entities
{
    public class Menu
    {
        public void Show()
        {
            OrderVehicleService service = new OrderVehicleService();
            
            Console.WriteLine("!!!##### GERENCIADOR DE VEÍCULOS #####!!!");
            Console.WriteLine();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("(1) Adicionar carro");
            Console.WriteLine("(2) Remover carro");
            Console.WriteLine("(3) Mostrar carro específico");
            Console.WriteLine("(4) Mostrar todos os carros da garagem");
            Console.Write("Opção: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1 :
                    Console.WriteLine("Insira o tipo do veículo:");
                    Console.WriteLine("Tipos disponíveis:");
                    foreach (Enums.Type type in Enum.GetValues(typeof(Enums.Type)))
                    {
                        Console.Write($"{type} ");
                    }

                    Console.Write("Tipo: ");
                    string t = Console.ReadLine();
                    service.SetType((Enums.Type)Enum.Parse(typeof(Enums.Type), t, true));
                    
                    Console.WriteLine("Insira o fabricante do veículo:");
                    string f = Console.ReadLine();
                    service.SetManufacturer(f);
                    
                    Console.WriteLine("Insira o modelo do veículo:");
                    string m = Console.ReadLine();
                    service.SetManufacturer(m);
                    
                    Console.WriteLine("Insira a cor do veículo:");
                    Console.WriteLine("Tipos disponíveis:");
                    foreach (Enums.Color color in Enum.GetValues(typeof(Enums.Color)))
                    {
                        Console.Write($"{color} ");
                    }

                    Console.Write("Color: ");
                    string c = Console.ReadLine();
                    service.SetColor((Enums.Color)Enum.Parse(typeof(Enums.Color), c, true));

                    Vehicle vehicle = new Vehicle(service);

                    VehicleInventory.AddVehicle(vehicle);
                    break;
                
                case 2 :
                    Console.Write("Insira a placa do veículo a ser removido: ");
                    string removePlate = Console.ReadLine().ToUpper();

                    Vehicle deleteVehicle = VehicleInventory.GetVehicle(removePlate);
                    VehicleInventory.DeleteVehicle(deleteVehicle);
                    break;
                
                case 3 :
                    Console.Write("Insira a placa do veículo a ser mostrado: ");
                    string showPlate = Console.ReadLine().ToUpper();

                    Vehicle getVehicle = VehicleInventory.GetVehicle(showPlate);
                    VehicleInventory.ShowVehicle(getVehicle);
                    break;
                case 4 :
                    VehicleInventory.ShowInventory();
                    break;
                
                default :
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}