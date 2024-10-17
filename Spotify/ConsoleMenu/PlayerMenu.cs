using Spotify.DataBase;
using Spotify.Players;
using Spotify.Services;

namespace Spotify.ConsoleMenu
{
    /// <summary>
    /// Represents the menu interface for controlling a music player in a console application.
    /// </summary>
    public class PlayerMenu
    {
        private bool operation = true;
        /// <summary>
        /// Displays the player menu options and processes user input.
        /// </summary>
        /// <remarks>
        /// This method runs in a loop until the user chooses to exit.
        /// It provides options to play a song, play a music collection, or play the radio.
        /// </remarks>
        public void Menu()
        {
            using(var unitOfWork = new UnitOfWork(new Context()))
            {
                var musicCollectionService = new MusicCollectionService(unitOfWork.MusicCollections);
                var songService = new SongService(unitOfWork.Songs);
                var radioService = new RadioService(unitOfWork.Radios);
                var player = new Player(musicCollectionService, songService, radioService);

                Console.WriteLine();

                Console.WriteLine("Player Menu:");

                while (operation)
                {
                    Console.WriteLine("1) -> Play Song <- ");
                    Console.WriteLine("2) -> Play Music Collection <- ");
                    Console.WriteLine("3) -> Play Radio <- ");
                    Console.WriteLine("4) -> Exit <- ");

                    Console.Write("Enter Choice: ");
                    long choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            player.PlayMusic();
                            break;
                        case 2:
                            player.PlayMusicCollection();
                            break;
                        case 3:
                            player.PlayRadio();
                            break;
                        case 4:
                            operation = false;
                            break;
                    }
                }

            }
        }
    }
}
