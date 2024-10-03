using Spotify.Managers;

namespace Spotify.ConsoleMenu
{
    internal class RadioMenu
    {
        private RadioManager radioManager = new RadioManager();
        private bool operation = true;

        public void Menu()
        {
            Console.WriteLine("Radio Menu");

            while (operation)
            {
                Console.WriteLine("1) -> Add Radio <- ");
                Console.WriteLine("2) -> Update Radio <- ");
                Console.WriteLine("3) -> Delete Radio <- ");
                Console.WriteLine("4) -> Print Radio <- ");
                Console.WriteLine("5) -> Exit <- ");

                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        radioManager.add();
                        break;
                    case 2:
                        radioManager.update(); 
                        break;
                    case 3:
                        radioManager.delete(); 
                        break;
                    case 4:
                        radioManager.print(); 
                        break;
                    case 5:
                        operation = false;
                        break;
                }
            }
        }
    }
}
