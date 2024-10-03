using Spotify.Managers;

namespace Spotify.ConsoleMenu
{
    internal class SongMenu
    {
        private SongManager songManager = new SongManager();
        private bool operation = true;

        public void Menu()
        {
            Console.WriteLine("Song Menu");

            while (operation)
            {
                Console.WriteLine("1) -> Add Song <- ");
                Console.WriteLine("2) -> Update Song <- ");
                Console.WriteLine("3) -> Delete Song <- ");
                Console.WriteLine("4) -> Print Song <- ");
                Console.WriteLine("5) -> Exit <- ");

                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        songManager.add();
                        break;
                    case 2:
                        songManager.update();
                        break;
                    case 3:
                        songManager.delete();
                        break;
                    case 4:
                        songManager.print();
                        break;
                    case 5:
                        operation = false;
                        break;
                }
            }
        }
    }
}
