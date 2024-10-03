namespace Spotify.ConsoleOperations
{
    internal class DeleteMusicCollection
    {
        public void DeleteMusicCollectionOperation()
        {
            Console.Write("Enter Radio Id: ");
            long radioId = Convert.ToInt64(Console.ReadLine());
        }
    }
}
