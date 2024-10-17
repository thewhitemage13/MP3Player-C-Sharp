using Spotify.Entity;
using Spotify.Enums;
using Spotify.Services.Interfaces;

namespace Spotify.Operations
{
    /// <summary>
    /// Provides console operations for managing performers.
    /// </summary>
    public class PerformerConsoleOperations
    {
        private readonly IPerformerService performerService;
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformerConsoleOperations"/> class.
        /// </summary>
        /// <param name="performerService">Service for managing performers.</param>
        public PerformerConsoleOperations(IPerformerService performerService) 
        { 
            this.performerService = performerService;
        }
        /// <summary>
        /// Adds a new performer by collecting user input.
        /// </summary>
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
            performer.Genre = selectedGenre;

            Console.WriteLine(performer);

            performerService.AddPerformer(performer);
        }
        /// <summary>
        /// Updates an existing performer based on user input.
        /// </summary>
        public void UpdatePerformerOperation()
        {
            Console.Write("Enter Performer Id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            var performer = performerService.GetPerformerById(id);
        }
        /// <summary>
        /// Retrieves and displays a performer by their ID.
        /// </summary>
        public void GetPerformerByIdOperation()
        {
            Console.Write("Enter Performer Id: ");
            long id = Convert.ToInt64((Console.ReadLine()));
            var performer = performerService.GetPerformerById(id);
            Console.WriteLine(performer);
        }
        /// <summary>
        /// Deletes a performer based on user-provided ID.
        /// </summary>
        public void DeletePerformerOperation()
        {
            Console.Write("Enter Performer Id: ");
            long id = Convert.ToInt64((Console.ReadLine()));
            var performer = performerService.GetPerformerById(id);
            performerService.DeletePerformer(id);
        }
        /// <summary>
        /// Lists all performers.
        /// </summary>
        public void ListAllSongsOperation()
        {
            Console.WriteLine("All Songs: ");
            foreach(var a in performerService.GetAllPerformers())
            {
                Console.WriteLine(a);
            }
        }
    }
}
