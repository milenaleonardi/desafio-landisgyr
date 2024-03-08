using DesafioEntrevistaTecnica.API.Models;

namespace DesafioEntrevistaTecnica.API.MenuOptions
{
    public class FindByEnergyCompanyEndpointSerialNumber
    {
        internal static void FindEndpointBySerialNumber(List<EnergyCompany> endpoints)
        {
            Menu.DisplayMenuOption("Find an Endpoint by 'Endpoint Serial Number");

            Console.Write("\nEnter a Endpoint Serial Number: ");
            string endpointSerialNumber = Console.ReadLine();

            var existingEndpoint = endpoints.FirstOrDefault(endpoint => endpoint.EndpointSerialNumber == endpointSerialNumber);

            if (existingEndpoint != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Endpoint Serial Number: {existingEndpoint.EndpointSerialNumber}");
                Console.WriteLine($"Meter Model: {existingEndpoint.MeterModelId}");
                Console.WriteLine($"Meter Number: {existingEndpoint.MeterNumber}");
                Console.WriteLine($"Meter Firmware Version: {existingEndpoint.MeterFirmwareVersion}");
                Console.WriteLine($"Switch State: {existingEndpoint.SwitchState}");
                Console.WriteLine();
            }
            else
            {
                throw new Exception("Endpoint Serial Number not found.");
            }

            Console.WriteLine("Press any key to return to Menu Options.");
            Console.ReadKey();

            Program.MenuOptions();
        }
    }
}
