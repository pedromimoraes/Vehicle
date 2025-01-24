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

            Console.Clear();
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
                case 1:
                    Console.Clear();
                    Console.WriteLine("===== | GERENCIADOR DE VEÍCULOS | =====");
                    Console.WriteLine();
                    Console.WriteLine("Insira o tipo do veículo:");
                    Console.WriteLine();

                    Console.Write("Tipos disponíveis: ");
                    EnumFormatService.Format(Enums.Type.Moto);

                    Console.WriteLine();
                    Console.Write("Tipo: ");
                    string t = Console.ReadLine();

                    service.SetType((Enums.Type)Enum.Parse(typeof(Enums.Type), t, true));

                    Console.Clear();
                    Console.WriteLine("===== | GERENCIADOR DE VEÍCULOS | =====");
                    Console.WriteLine();
                    Console.WriteLine($"Insira o fabricante do {t}:");
                    Console.WriteLine();
                    System.Console.Write("Fabricante: ");

                    string f = Console.ReadLine();
                    service.SetManufacturer(f);

                    Console.Clear();
                    Console.WriteLine("===== | GERENCIADOR DE VEÍCULOS | =====");
                    Console.WriteLine();
                    Console.WriteLine($"Insira o modelo do {t}:");
                    Console.WriteLine();
                    System.Console.Write("Modelo: ");

                    string m = Console.ReadLine();
                    service.SetManufacturer(m);

                    Console.Clear();
                    Console.WriteLine("===== | GERENCIADOR DE VEÍCULOS | =====");
                    Console.WriteLine();
                    Console.WriteLine($"Insira a cor do {t}:");

                    Console.WriteLine();

                    Console.Write("Cores disponíveis: ");
                    EnumFormatService.Format(Enums.Color.Preto);

                    Console.WriteLine();
                    Console.Write("Cor: ");

                    string c = Console.ReadLine();
                    service.SetColor((Enums.Color)Enum.Parse(typeof(Enums.Color), c, true));

                    Vehicle vehicle = new Vehicle(service);

                    Console.WriteLine();
                    Console.WriteLine($"{vehicle.Type}, {vehicle.Manufacturer} {vehicle.Model} {vehicle.Color} de placa: {vehicle.Plate} adicionado com sucesso.");
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer botão para continuar..");
                    Console.ReadKey();
                    VehicleInventory.AddVehicle(vehicle);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("===== | GERENCIADOR DE VEÍCULOS | =====");
                    Console.WriteLine();
                    Console.Write("Insira a placa do veículo a ser removido: ");
                    string removePlate = Console.ReadLine().ToUpper();

                    Vehicle deleteVehicle = VehicleInventory.GetVehicle(removePlate);
                    VehicleInventory.DeleteVehicle(deleteVehicle);
                    System.Console.WriteLine($"{deleteVehicle.Manufacturer} {deleteVehicle.Model} {deleteVehicle.Color} removido com sucesso.");

                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer botão para continuar..");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("===== | GERENCIADOR DE VEÍCULOS | =====");
                    Console.WriteLine();
                    Console.Write("Insira a placa do veículo a ser mostrado: ");
                    string showPlate = Console.ReadLine().ToUpper();

                    Vehicle getVehicle = VehicleInventory.GetVehicle(showPlate);

                    System.Console.WriteLine();

                    VehicleInventory.ShowVehicle(getVehicle);
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer botão para continuar..");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("===== | GERENCIADOR DE VEÍCULOS | =====");
                    Console.WriteLine();
                    VehicleInventory.ShowInventory();
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer botão para continuar..");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Fechando o programa.");
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer botão para continuar..");
                    Console.ReadKey();
                    return false;

                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer botão para continuar..");
                    Console.ReadKey();
                    break;
            }
            return true;
        }
    }
}