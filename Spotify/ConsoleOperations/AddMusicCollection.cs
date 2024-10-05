
using Spotify.Entity;
using Spotify.Enums;

namespace Spotify.ConsoleOperations
{
    internal class AddMusicCollection
    {
        public void AddMusicCollectionOperation()
        {
            MusicCollection musicCollection = new MusicCollection();

            Console.Write("Enter Muisc Collection name: ");
            string name = Console.ReadLine();
            musicCollection.Name = name;

            Console.Write("Enter Performer Id: ");
            long performerId = Convert.ToInt32(Console.ReadLine());
            //musicCollection.Performer; (performerId);

            Console.WriteLine("All Type Of Collection: ");

            foreach (var typeOfCollection in Enum.GetValues(typeof(TypeOfCollection)))
            {
                Console.WriteLine(typeOfCollection);
            }

            Console.Write("Enter Type Of Collection: ");

            string input1 = Console.ReadLine();
            TypeOfCollection selectedGenre = (TypeOfCollection)Enum.Parse(typeof(TypeOfCollection), input1, ignoreCase: true);
            musicCollection.TypeOfCollection = selectedGenre;


            Console.Write("Enter a date (e.g., 01/31/2024): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime dateTime))
            {
                DateTime dateOnly = dateTime.Date;
                Console.WriteLine($"You entered: {dateOnly.ToShortDateString()}");
                musicCollection.ReleaseDate = dateOnly;
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }

            Console.Write("Add songs: ");
            AddSongsToAlbum(musicCollection);

        }

        private void AddSongsToAlbum(MusicCollection musicCollection)
        {
            string addMore;
            do
            {
                Console.WriteLine("Add a new song to the album:");
                Song song = new Song();

                AddSong addSong = new AddSong();
                addSong.AddSongOperation(song);

                musicCollection.AddSong(song);

                Console.Write("Do you want to add another song? (yes/no): ");
                addMore = Console.ReadLine().Trim().ToLower();
            } while (addMore == "yes");
        }
    }
}
