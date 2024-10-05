using Spotify.Entity;
using Spotify.Enums;

namespace Spotify.ConsoleOperations
{
    public class AddPerformer
    {
        public void AddPerformerOperation() 
        {
            Performer performer = new Performer();
            Console.Write("Enter performer name: ");
            string name = Console.ReadLine();
            performer.Name = name;

            Console.WriteLine("All genres: ");

            foreach (var genre in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine(genre);
            }

            Console.Write("Enter Genre: ");

            string input = Console.ReadLine();
            Genre selectedGenre = (Genre)Enum.Parse(typeof(Genre), input, ignoreCase: true);
            performer.Genre =selectedGenre;

            Console.WriteLine(performer);

        }
    }
}
