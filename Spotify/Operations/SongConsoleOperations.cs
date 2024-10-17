using Spotify.Entity;
using Spotify.Enums;
using Spotify.Services.Interfaces;

namespace Spotify.Operations
{
    /// <summary>
    /// Provides console operations for managing songs.
    /// </summary>
    public class SongConsoleOperations
    {
        private readonly ISongService songService;
        private readonly IPerformerService performerService;
        /// <summary>
        /// Initializes a new instance of the <see cref="SongConsoleOperations"/> class.
        /// </summary>
        /// <param name="songService">Service for managing songs.</param>
        /// <param name="performerService">Service for managing performers.</param>
        public SongConsoleOperations(ISongService songService, IPerformerService performerService)
        {
            this.songService = songService;
            this.performerService = performerService;
        }
        /// <summary>
        /// Adds a new song by collecting user input.
        /// </summary>
        public void AddSongOperation()
        {
            Song song = new Song();
            song.UploadedTo = DateTime.UtcNow;
            AddProcessor(song);
            songService.AddSong(song);
        }
        /// <summary>
        /// Updates an existing song based on user input.
        /// </summary>
        public void UpdateSongOperation()
        {
            Console.Write("Enter Song Id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            var song = songService.GetSongById(id);
            AddProcessor(song);
            songService.UpdateSong(song);
        }
        /// <summary>
        /// Retrieves and displays a song by its ID.
        /// </summary>
        public void GetSongByIdOperation()
        {
            Console.Write("Enter Song Id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            var song = songService.GetSongById(id);
            Console.WriteLine(song);
        }
        /// <summary>
        /// Deletes a song based on user-provided ID.
        /// </summary>
        public void DeleteSongOperation()
        {
            Console.Write("Enter Song Id: ");
            long songId = Convert.ToInt64(Console.ReadLine());
            songService.DeleteSong(songId);
        }
        /// <summary>
        /// Lists all songs.
        /// </summary>
        public void ListAllSongsOperation()
        {
            var songs = songService.GetAllSongs();

            Console.WriteLine("All Songs: ");
            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
        /// <summary>
        /// Collects information about a song from user input.
        /// </summary>
        /// <param name="song">The song to populate with user input.</param>
        private void AddProcessor(Song song)
        {
            Console.Write("Enter Performer Id: ");
            long performerId = Convert.ToInt32(Console.ReadLine());

            Performer performer = performerService.GetPerformerById(performerId);

            if (performer == null)
            {
                return;
            }
            else
            {
                Console.Write("Enter song name: ");
                string name = Console.ReadLine();
                song.Name = name;
                song.Performer = performer;

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
}
