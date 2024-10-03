using Spotify.Managers;

namespace Spotify.ConsoleMenu
{
    internal class MusicCollectionMenu
    {
        private MusicCollectionManager musicCollectionManager = new MusicCollectionManager();
        private bool operation = true;

        public void Main()
        {
            Console.WriteLine("Music Collection Menu");

            while (operation)
            {
                Console.WriteLine("1) -> Add Music Collection <- ");
                Console.WriteLine("2) -> Update Music Collcetion <- ");
                Console.WriteLine("3) -> Delete Music Collection <- ");
                Console.WriteLine("4) -> Print Music Collcetion <- ");
                Console.WriteLine("5) -> Exit <- ");

                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        musicCollectionManager.add();
                        break;
                    case 2:
                        musicCollectionManager.update();
                        break;
                    case 3:
                        musicCollectionManager.delete();
                        break;
                    case 4:
                        musicCollectionManager.print();
                        break;
                    case 5:
                        operation = false;
                        break;
                }
            }

        }
    }
}
