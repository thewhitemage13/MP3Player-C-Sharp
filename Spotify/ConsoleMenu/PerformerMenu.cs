using Spotify.Managers;

namespace Spotify.ConsoleMenu
{
    internal class PerformerMenu
    {
        private PerformerManager performerManager = new PerformerManager();
        private bool operation = true;

        public void Menu()
        {
            Console.WriteLine("Performer Menu");

            while (operation)
            {
                Console.WriteLine("1) -> Add Performer <- ");
                Console.WriteLine("2) -> Delete Performer <- ");
                Console.WriteLine("3) -> Update Performer <- ");
                Console.WriteLine("4) -> Print Performer <- ");
                Console.WriteLine("5) -> Exit <- ");

                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        performerManager.add();
                        break;
                    case 2:
                        performerManager.delete();
                        break;
                    case 3:
                        performerManager.update();
                        break;
                    case 4:
                        performerManager.print();
                        break;
                    case 5:
                        operation = false;
                        break;
                }
            }
        }
    }
}
