using DesafioEntrevistaTecnica.API.Models;

namespace DesafioEntrevistaTecnica.API.MenuOptions
{
    public class DeleteEnergyCompanyEndpoint
    {
        internal static void DeleteEndpoint(List<EnergyCompany> endpoints)
        {
            Menu.DisplayMenuOption("Delete an existing Endpoint");

            Console.Write("Enter a Endpoint Serial Number: ");
            string endpointSerialNumber = Console.ReadLine();

            // Search for the endpoint with the given Endpoint Serial Number
            var existingEndpoint = endpoints.FirstOrDefault(endpoint => endpoint.EndpointSerialNumber == endpointSerialNumber);
            if (existingEndpoint != null)
            {
                Console.WriteLine($"Are you sure you want to delete the Endpoint? Type yes to confirm, or no to cancel.");
                string answer = Console.ReadLine();
                if (answer.ToLower().Equals("yes"))
                {
                    endpoints.Remove(existingEndpoint);
                    Console.WriteLine("\nEndpoint was deleted.");
                }
                else
                {
                    Console.WriteLine("Request to delete Endpoint was canceled by you.");
                }
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
