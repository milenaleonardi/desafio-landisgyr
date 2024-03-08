using DesafioEntrevistaTecnica.API.Models;

namespace DesafioEntrevistaTecnica.API.MenuOptions
{
    public class AddEnergyCompanyEndpoint
    {
        internal static void AddEndpoint(List<EnergyCompany> endpoints)
        {
            Menu.DisplayMenuOption("Add Endpoint");

            // Request information to add a new endpoint
            Console.WriteLine("Provide the information below:");
            Console.Write("Endpoint Serial Number: ");
            string endpointSerialNumber = Console.ReadLine();

            if (endpoints.Any(endpoint => endpoint.EndpointSerialNumber == endpointSerialNumber))
            {
                throw new Exception("Endpoint Serial Number already exists.");
            }
            else
            {
                Console.Write("Meter Model: ");
                string meterModel = Console.ReadLine();
                Console.Write("Meter Number: ");
                int meterNumber = int.Parse(Console.ReadLine());
                Console.Write("Meter Firmware Version: ");
                string meterFirmwareVersion = Console.ReadLine();
                Console.Write("State: ");
                string state = Console.ReadLine();
                    
                // Set information for new endpoint
                EnergyCompany energyCompany = new EnergyCompany(endpointSerialNumber, meterModel, meterNumber, meterFirmwareVersion, state);

                // Add to endpoints list
                endpoints.Add(energyCompany);

                Console.WriteLine("\nEndpoint was created successfully.");
                    
                Console.WriteLine("Press any key to return to Menu Options.");
                Console.ReadKey();

                Program.MenuOptions();
            }
        }
    }
}
