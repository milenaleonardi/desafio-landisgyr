using DesafioEntrevistaTecnica.API.Models;

namespace DesafioEntrevistaTecnica.API.MenuOptions
{
    public class ListAllEnergyCompanyEndpoint
    {
        internal static void ListAllEndpoints(List<EnergyCompany> endpoints)
        {
            Menu.DisplayMenuOption("List all Endpoints");

            Console.WriteLine("Registered Endpoints: \n");
            
            // Iterates over endpoint list and prints its informations
            foreach (var endpoint in endpoints)
            {
                Console.WriteLine($"Endpoint Serial Number: {endpoint.EndpointSerialNumber}");
                Console.WriteLine($"Meter Model: {endpoint.MeterModelId}");
                Console.WriteLine($"Meter Number: {endpoint.MeterNumber}");
                Console.WriteLine($"Meter Firmware Version: {endpoint.MeterFirmwareVersion}");
                Console.WriteLine($"Switch State: {endpoint.SwitchState}");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to return to Menu Options.");
            Console.ReadKey();

            Program.MenuOptions();
        }

    }
}
