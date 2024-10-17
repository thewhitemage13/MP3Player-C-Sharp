using Spotify.DataBase;
using Spotify.Operations;
using Spotify.Services;

namespace Spotify.ConsoleMenu
{
    /// <summary>
    /// Represents the menu interface for managing performers in a console application.
    /// </summary>
    public class PerformerMenu
    {
        private bool operation = true;
        /// <summary>
        /// Displays the menu options for managing performers and processes user input.
        /// </summary>
        /// <remarks>
        /// This method runs in a loop until the user chooses to exit.
        /// It provides options to add, delete, update, and list performers.
        /// </remarks>
        public void Menu()
        {
            using (var unitOfWork = new UnitOfWork(new Context()))
            {
                var performerService = new PerformerService(unitOfWork.Performers);
                var performerConsoleOperations = new PerformerConsoleOperations(performerService);

                Console.WriteLine();

                Console.WriteLine("Performer Menu");

                while (operation)
                {
                    Console.WriteLine("1) -> Add Performer <- ");
                    Console.WriteLine("2) -> Delete Performer <- ");
                    Console.WriteLine("3) -> Update Performer <- ");
                    Console.WriteLine("4) -> Print All Performers <- ");
                    Console.WriteLine("5) -> Print Performer By Id <- ");
                    Console.WriteLine("6) -> Exit <- ");

                    Console.Write("Enter Your Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            performerConsoleOperations.AddPerformerOperation();
                            break;
                        case 2:
                            performerConsoleOperations.DeletePerformerOperation();
                            break;
                        case 3:
                            performerConsoleOperations.UpdatePerformerOperation();
                            break;
                        case 4:
                            performerConsoleOperations.ListAllSongsOperation();
                            break;
                        case 5:
                            performerConsoleOperations.GetPerformerByIdOperation();
                            break;
                        case 6:
                            operation = false;
                            break;
                    }
                }
            }
        }
    }
}
