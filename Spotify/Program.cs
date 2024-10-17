using Spotify.ConsoleMenu;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Menu();
        }
    }
}
