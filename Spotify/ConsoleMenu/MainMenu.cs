namespace Spotify.ConsoleMenu
{
    internal class MainMenu
    {
        private MusicCollectionMenu muicCollectionMenu = new MusicCollectionMenu();
        private PerformerMenu performerMenu = new PerformerMenu();
        private RadioMenu radioMenu = new RadioMenu();
        private SongMenu songMenu = new SongMenu();
        private bool operation = true;

        public void Menu()
        {
            while (operation)
            {
                Console.WriteLine("Main Menu");

                Console.WriteLine("1) -> Music Collcetion Menu <- ");
                Console.WriteLine("2) -> Performer Menu <- ");
                Console.WriteLine("3) -> Radio Menu <- ");
                Console.WriteLine("4) -> Song Menu <- ");
                Console.WriteLine("5) -> Exit <- ");

                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        muicCollectionMenu.Main();
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
                        operation = false;
                        break;
                }
            }
        }
    }
}
