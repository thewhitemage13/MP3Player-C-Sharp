using Spotify.DataBase;
using Spotify.Operations;
using Spotify.Services;

namespace Spotify.ConsoleMenu
{
    /// <summary>
    /// Represents the menu interface for managing songs in a console application.
    /// </summary>
    public class SongMenu : IMenu
    {
        private bool operation = true;
        /// <summary>
        /// Displays the song menu options and processes user input.
        /// </summary>
        /// <remarks>
        /// This method runs in a loop until the user chooses to exit.
        /// It provides options to add, update, delete, and list songs.
        /// </remarks>
        public void Menu()
        {
            using (var unitOfWork = new UnitOfWork(new Context()))
            {
                var songService = new SongService(unitOfWork.Songs);
                var performerService = new PerformerService(unitOfWork.Performers);
                var songConsoleOperations = new SongConsoleOperations(songService, performerService);

                Console.WriteLine();

                Console.WriteLine("Song Menu");

                while (operation)
                {
                    Console.WriteLine("1) -> Add Song <- ");
                    Console.WriteLine("2) -> Update Song <- ");
                    Console.WriteLine("3) -> Delete Song <- ");
                    Console.WriteLine("4) -> Print All Song <- ");
                    Console.WriteLine("5) -> Print Song By Id <- ");
                    Console.WriteLine("6) -> Exit <- ");

                    Console.Write("Enter Your Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            songConsoleOperations.AddSongOperation();
                            break;
                        case 2:
                            songConsoleOperations.UpdateSongOperation();
                            break;
                        case 3:
                            songConsoleOperations.DeleteSongOperation();
                            break;
                        case 4:
                            songConsoleOperations.ListAllSongsOperation();
                            break;
                        case 5:
                            songConsoleOperations.GetSongByIdOperation();
                            break;
                        case 6:
                            operation = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
