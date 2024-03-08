using DesafioEntrevistaTecnica.API.MenuOptions;
using DesafioEntrevistaTecnica.API.Models;

public class Program
{
    // Initialize endpoints list
    private static List<EnergyCompany> endpoints = new List<EnergyCompany>(); 

    public static void Main(string[] args)
    {
        MenuOptions();
    }

    public static void MenuOptions()
    {
        Console.Clear();

        Console.WriteLine("Insert a number to select the option: \n");
        Console.WriteLine("1 - Add a new Endpoint");
        Console.WriteLine("2 - Edit an existing Endpoint");
        Console.WriteLine("3 - Delete an existing Endpoint");
        Console.WriteLine("4 - List all Endpoints");
        Console.WriteLine("5 - Find an Endpoint by 'Endpoint Serial Number'");
        Console.WriteLine("6 - Exit");

        Console.Write("\nOption: ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1: AddEnergyCompanyEndpoint.AddEndpoint(endpoints); break;
            case 2: EditEnergyCompanyEndpoint.EditEndpoint(endpoints); break;
            case 3: DeleteEnergyCompanyEndpoint.DeleteEndpoint(endpoints); break;
            case 4: ListAllEnergyCompanyEndpoint.ListAllEndpoints(endpoints); break;
            case 5: FindByEnergyCompanyEndpointSerialNumber.FindEndpointBySerialNumber(endpoints); break;
            case 6: ExitApplication.Exit(); break;
        }

        MenuOptions();
    }










}