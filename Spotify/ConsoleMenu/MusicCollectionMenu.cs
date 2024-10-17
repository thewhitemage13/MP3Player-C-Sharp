using Spotify.DataBase;
using Spotify.Operations;
using Spotify.Services;

namespace Spotify.ConsoleMenu
{
    /// <summary>
    /// Represents the menu interface for managing a music collection in a console application.
    /// </summary>
    public class MusicCollectionMenu : IMenu
    {
        private bool operation = true;
        /// <summary>
        /// Displays the menu options for managing the music collection and processes user input.
        /// </summary>
        /// <remarks>
        /// This method runs in a loop until the user chooses to exit.
        /// It provides options to add, update, delete, and list music collections.
        /// </remarks>
        public void Menu()
        {
            using (var unitOfWork = new UnitOfWork(new Context()))
            {
                var musicCollectionService = new MusicCollectionService(unitOfWork.MusicCollections);
                var songService = new SongService(unitOfWork.Songs);
                var performerService = new PerformerService(unitOfWork.Performers);
                var musicCollectionConsoleOperations = new MusicCollectionConsoleOperations(musicCollectionService, songService, performerService);

                Console.WriteLine();

                Console.WriteLine("Music Collection Menu");

                while (operation)
                {
                    Console.WriteLine("1) -> Add Music Collection <- ");
                    Console.WriteLine("2) -> Update Music Collcetion <- ");
                    Console.WriteLine("3) -> Delete Music Collection <- ");
                    Console.WriteLine("4) -> Print All Music Collcetions <- ");
                    Console.WriteLine("5) -> Print Music Collcetion By Id <- ");
                    Console.WriteLine("6) -> Exit <- ");

                    Console.Write("Enter Your Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            musicCollectionConsoleOperations.AddMusicCollectionOperation();
                            break;
                        case 2:
                            musicCollectionConsoleOperations.UpdateMusicCollectionOperation();
                            break;
                        case 3:
                            musicCollectionConsoleOperations.DeleteMusicCollectionOperation();
                            break;
                        case 4:
                            musicCollectionConsoleOperations.ListAllMusicCollectionsOperation();
                            break;
                        case 5:
                            musicCollectionConsoleOperations.GetMusicCollectionByIdOperation();
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
