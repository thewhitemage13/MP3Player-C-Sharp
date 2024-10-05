using Spotify.Entity;
using Spotify.Enums;

namespace Spotify.ConsoleOperations
{
    internal class AddSong
    {
        public void AddSongOperation()
        {
            Song song = new Song();

            Console.Write("Enter Performer Id: ");
            long performerId = Convert.ToInt32(Console.ReadLine());
            //song.SetPerformerId(performerId);

            Console.Write("Enter song name: ");
            string name = Console.ReadLine();
            song.Name = name;

            Console.WriteLine("All Type Of Song: ");

            foreach (var typeOfSong in Enum.GetValues(typeof(TypeOfSong)))
            {
                Console.WriteLine(typeOfSong);
            }

            Console.Write("Enter Type Of Song: ");
            string input1 = Console.ReadLine();
            TypeOfSong selectedTypeOfSong = (TypeOfSong)Enum.Parse(typeof(TypeOfSong), input1, ignoreCase: true);
            song.TypeOfSong = selectedTypeOfSong;

            Console.WriteLine("All genres: ");

            foreach (var genre in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine(genre);
            }

            Console.Write("Enter Genre: ");

            string input2 = Console.ReadLine();
            Genre selectedGenre = (Genre)Enum.Parse(typeof(Genre), input2, ignoreCase: true);
            song.Genre = selectedGenre;

            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();
            song.FilePath = filePath;

            Console.Write("Enter duration: ");
            int duration = Convert.ToInt32(Console.ReadLine());
            song.Duration = duration;
        }

        public void AddSongOperation(Song song)
        {
            Console.Write("Enter Performer Id: ");
            long performerId = Convert.ToInt32(Console.ReadLine());
            //song.SetPerformerId(performerId);

            Console.Write("Enter song name: ");
            string name = Console.ReadLine();
            song.Name = name;

            Console.WriteLine("All Type Of Song: ");

            foreach (var typeOfSong in Enum.GetValues(typeof(TypeOfSong)))
            {
                Console.WriteLine(typeOfSong);
            }

            Console.Write("Enter Type Of Song: ");
            string input1 = Console.ReadLine();
            TypeOfSong selectedTypeOfSong = (TypeOfSong)Enum.Parse(typeof(TypeOfSong), input1, ignoreCase: true);
            song.TypeOfSong = selectedTypeOfSong;

            Console.WriteLine("All genres: ");

            foreach (var genre in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine(genre);
            }

            Console.Write("Enter Genre: ");

            string input2 = Console.ReadLine();
            Genre selectedGenre = (Genre)Enum.Parse(typeof(Genre), input2, ignoreCase: true);
            song.Genre = selectedGenre;

            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();
            song.FilePath = filePath;

            Console.Write("Enter duration: ");
            int duration = Convert.ToInt32(Console.ReadLine());
            song.Duration = duration;
        }
    }
}
