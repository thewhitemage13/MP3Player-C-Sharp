using Spotify.Entity;
using Spotify.Enums;
using Spotify.Services;
using Spotify.Services.Interfaces;

namespace Spotify.Operations
{
    /// <summary>
    /// Provides operations for managing music collections in the console application.
    /// </summary>
    public class MusicCollectionConsoleOperations
    {
        private readonly IMusicCollectionService musicCollectionService;
        private readonly ISongService songService;
        private readonly IPerformerService performerService;
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicCollectionConsoleOperations"/> class.
        /// </summary>
        /// <param name="musicCollectionService">Service for managing music collections.</param>
        /// <param name="songService">Service for managing songs.</param>
        /// <param name="performerService">Service for managing performers.</param>
        public MusicCollectionConsoleOperations(IMusicCollectionService musicCollectionService, ISongService songService, IPerformerService performerService)
        {
            this.musicCollectionService = musicCollectionService;
            this.songService = songService;
            this.performerService = performerService;
        }
        /// <summary>
        /// Adds a new music collection by collecting user input.
        /// </summary>
        public void AddMusicCollectionOperation()
        {
            MusicCollection musicCollection = new MusicCollection();

            AddProcessor(musicCollection);

            musicCollectionService.AddMusicCollection(musicCollection);
        }
        /// <summary>
        /// Updates an existing music collection based on user input.
        /// </summary>
        public void UpdateMusicCollectionOperation()
        {
            Console.Write("Enter Music Collection Id: ");
            long id = Convert.ToInt32(Console.ReadLine());
            var musicCollection = musicCollectionService.GetMusicCollectionById(id);
            AddProcessor(musicCollection);
            musicCollectionService.UpdateMusicCollection(musicCollection);
        }
        /// <summary>
        /// Retrieves and displays a music collection by its ID.
        /// </summary>
        public void GetMusicCollectionByIdOperation()
        {
            Console.Write("Enter Music Collection Id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            var musicCollection = musicCollectionService.GetMusicCollectionById(id);
            Console.WriteLine(musicCollection);
        }
        /// <summary>
        /// Deletes a music collection based on user-provided ID.
        /// </summary>
        public void DeleteMusicCollectionOperation()
        {
            Console.Write("Enter Music Collection Id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            musicCollectionService.DeleteMusicCollection(id);
        }
        /// <summary>
        /// Lists all music collections.
        /// </summary>
        public void ListAllMusicCollectionsOperation()
        {
            Console.WriteLine("All Music Collections: ");
            foreach(var m in  musicCollectionService.GetAllMusicCollections()) 
            {
                Console.WriteLine(m); 
            }
        }
        /// <summary>
        /// Adds songs to a music collection.
        /// </summary>
        /// <param name="musicCollection">The music collection to which songs will be added.</param>
        private void AddSongsToAlbum(MusicCollection musicCollection)
        {
            string addMore;
            do
            {
                Console.WriteLine("Add a new song to the album:");
                Song song = new Song();
                songService.AddSong(song);
                musicCollection.AddSong(song);
                Console.Write("Do you want to add another song? (yes/no): ");
                addMore = Console.ReadLine().Trim().ToLower();
            } while (addMore == "yes");
        }
        /// <summary>
        /// Processes user input for adding or updating a music collection.
        /// </summary>
        /// <param name="musicCollection">The music collection to be processed.</param>
        private void AddProcessor(MusicCollection musicCollection)
        {
            Console.Write("Enter Muisc Collection name: ");
            string name = Console.ReadLine();
            musicCollection.Name = name;

            Console.Write("Enter Performer Id: ");
            long performerId = Convert.ToInt32(Console.ReadLine());
            var performer = performerService.GetPerformerById(performerId);
            musicCollection.Performer = performer;

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
    }
}
