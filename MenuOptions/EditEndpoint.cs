using DesafioEntrevistaTecnica.API.Models;

namespace DesafioEntrevistaTecnica.API.MenuOptions
{
    public class EditEnergyCompanyEndpoint
    {
        internal static void EditEndpoint(List<EnergyCompany> endpoints)
        {
            Menu.DisplayMenuOption("Edit an existing Endpoint");

            Console.Write("Enter a Endpoint Serial Number: ");
            string endpointSerialNumber = Console.ReadLine();

            // Find the endpoint with the given serial number
            var existingEndpoint = endpoints.FirstOrDefault(endpoint => endpoint.EndpointSerialNumber == endpointSerialNumber);

            if (existingEndpoint != null)
            {
                Console.Write("Enter new value for 'Switch State'");
                Console.Write("\nState: ");
                string state = Console.ReadLine();
                
                // Update switch state of the endpoint
                existingEndpoint.SwitchState = EnergyCompany.SetSwitchState(state);

                Console.WriteLine("\nEndpoint was edited with success.");
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
