namespace Spotify.ConsoleOperations
{
    internal class DeleteSong
    {
        public void DeleteSongOperation()
        {
            Console.Write("Enter Song Id: ");
            long songId = Convert.ToInt64(Console.ReadLine());
        }
    }
}
