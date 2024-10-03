using Spotify.ConsoleMenu;
using Spotify.ConsoleOperations;

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
