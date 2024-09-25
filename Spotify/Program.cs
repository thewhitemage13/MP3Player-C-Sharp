using Spotify.ConsoleOperations;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddPerformer performer = new AddPerformer();
            performer.AddPerformerOperation();
        }
    }
}
