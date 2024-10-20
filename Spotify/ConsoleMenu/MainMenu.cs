﻿namespace Spotify.ConsoleMenu
{
    /// <summary>
    /// Represents the main menu interface of a console application for managing a music collection.
    /// </summary>
    public class MainMenu : IMenu
    {
        private MusicCollectionMenu muicCollectionMenu;
        private PerformerMenu performerMenu;
        private RadioMenu radioMenu;
        private SongMenu songMenu;
        private PlayerMenu playerMenu;
        private bool operation = true;
        public MainMenu()
        {
            muicCollectionMenu = new MusicCollectionMenu();
            performerMenu = new PerformerMenu();
            radioMenu = new RadioMenu();
            songMenu = new SongMenu();
            playerMenu = new PlayerMenu();
        }
        /// <summary>
        /// Displays the main menu options to the user and handles their input to navigate to different sub-menus or exit the application.
        /// </summary>
        /// <example>
        /// <code>
        /// MainMenu mainMenu = new MainMenu();
        /// mainMenu.Menu();
        /// </code>
        /// </example>
        public void Menu()
        {
            Console.WriteLine();

            Console.WriteLine("Main Menu");

            while (operation)
            {
                Console.WriteLine("1) -> Music Collcetion Menu <- ");
                Console.WriteLine("2) -> Performer Menu <- ");
                Console.WriteLine("3) -> Radio Menu <- ");
                Console.WriteLine("4) -> Song Menu <- ");
                Console.WriteLine("5) -> Player Menu <- ");
                Console.WriteLine("6) -> Exit <- ");

                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        muicCollectionMenu.Menu();
                        break;
                    case 2:
                        performerMenu.Menu();
                        break;
                    case 3:
                        radioMenu.Menu();
                        break;
                    case 4:
                        songMenu.Menu();
                        break;
                    case 5:
                        playerMenu.Menu();
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
