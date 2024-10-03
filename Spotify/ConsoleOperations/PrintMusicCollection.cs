namespace Spotify.ConsoleOperations
{
    internal class PrintMusicCollection
    {
        public void PrintMusicCollectionOperation()
        {
            Console.Write("Enter Music Collection Id: ");
            long musicCollectionId = Convert.ToInt64(Console.ReadLine());

        }
    }
}
