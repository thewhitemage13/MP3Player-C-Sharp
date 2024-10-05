namespace Spotify.ConsoleOperations
{
    internal class PrintPerformer
    {
        public void PrintPerformerOperation()
        {
            Console.Write("Enter Perormer Id: ");
            long performerId = Convert.ToInt64(Console.ReadLine());
        }
    }
}
