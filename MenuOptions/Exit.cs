namespace DesafioEntrevistaTecnica.API.MenuOptions
{
    public class ExitApplication
    {
        internal static void Exit()
        {
            Menu.DisplayMenuOption("Exit");

            Console.WriteLine("Do you want to exit the application? Type yes or no.");
            var answer = Console.ReadLine();
            if (answer.ToLower().Equals("yes"))
            {
                Console.WriteLine("Exiting the application...");
                Environment.Exit(0);
            }
            else
            {
                Program.MenuOptions();
            }
        }
    }
}
