using Spotify.DataBase;
using Spotify.Operations;
using Spotify.Services;

namespace Spotify.ConsoleMenu
{
    /// <summary>
    /// Represents the menu interface for managing radio stations in a console application.
    /// </summary>
    public class RadioMenu : IMenu
    {
        private bool operation = true;
        /// <summary>
        /// Displays the radio menu options and processes user input.
        /// </summary>
        /// <remarks>
        /// This method runs in a loop until the user chooses to exit.
        /// It provides options to add, update, delete, and list radio stations.
        /// </remarks>
        public void Menu()
        {
            using (var unitOfWork = new UnitOfWork(new Context()))
            {
                var radioService = new RadioService(unitOfWork.Radios);
                var radioConsoleOperations = new RadioConsoleOperations(radioService);

                Console.WriteLine();

                Console.WriteLine("Radio Menu");

                while (operation)
                {
                    Console.WriteLine("1) -> Add Radio <- ");
                    Console.WriteLine("2) -> Update Radio <- ");
                    Console.WriteLine("3) -> Delete Radio <- ");
                    Console.WriteLine("4) -> Print All Radios <- ");
                    Console.WriteLine("5) -> Print Radio By Id <- ");
                    Console.WriteLine("6) -> Exit <- ");

                    Console.Write("Enter Your Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            radioConsoleOperations.AddRadioOperation();
                            break;
                        case 2:
                            radioConsoleOperations.UpdateRadioOperation();
                            break;
                        case 3:
                            radioConsoleOperations.DeleteRadioOperation();
                            break;
                        case 4:
                            radioConsoleOperations.ListAllRadioOperation();
                            break;
                        case 5:
                            radioConsoleOperations.GetRadioByIdOperation();
                            break;
                        case 6:
                            operation = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
