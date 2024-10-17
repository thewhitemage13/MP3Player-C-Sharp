using Spotify.Entity;
using Spotify.Services.Interfaces;

namespace Spotify.Operations
{
    /// <summary>
    /// Provides console operations for managing radio stations.
    /// </summary>
    public class RadioConsoleOperations
    {
        private readonly IRadioService radioService;
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioConsoleOperations"/> class.
        /// </summary>
        /// <param name="radioService">Service for managing radios.</param>
        public RadioConsoleOperations(IRadioService radioService)
        {
            this.radioService = radioService;
        }
        /// <summary>
        /// Adds a new radio station by collecting user input.
        /// </summary>
        public void AddRadioOperation()
        {
            Radio radio = new Radio();
            AddProcessor(radio);
            radioService.AddRadio(radio);
        }
        /// <summary>
        /// Updates an existing radio station based on user input.
        /// </summary>
        public void UpdateRadioOperation()
        {
            Console.Write("Enter Radio Id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            var radio = radioService.GetRadioById(id);
            AddProcessor(radio);
            radioService.UpdateRadio(radio);
        }
        /// <summary>
        /// Retrieves and displays a radio station by its ID.
        /// </summary>
        public void GetRadioByIdOperation()
        {
            Console.Write("Enter Radio Id: ");
            long id = Convert.ToInt64((Console.ReadLine()));
            var radio = radioService.GetRadioById(id);
            Console.WriteLine(radio);
        }
        /// <summary>
        /// Deletes a radio station based on user-provided ID.
        /// </summary>
        public void DeleteRadioOperation()
        {
            Console.WriteLine("Enter Radio Id: ");
            long id = Convert.ToInt64((Console.ReadLine()));
            var radio = radioService.GetRadioById(id);
            radioService.DeleteRadio(id);
        }
        /// <summary>
        /// Lists all radio stations.
        /// </summary>
        public void ListAllRadioOperation()
        {
            Console.WriteLine("All Radio: ");
            foreach (var r in radioService.GetAllRadios())
            {
                Console.WriteLine(r);
            }
        }
        /// <summary>
        /// Collects information about a radio station from user input.
        /// </summary>
        /// <param name="radio">The radio station to populate with user input.</param>
        private void AddProcessor(Radio radio)
        {
            Console.WriteLine("Enter Information About Radio:");

            Console.Write("Enter Radio Name: ");
            string radioName = Console.ReadLine();
            radio.RadioName = radioName;

            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            radio.City = city;

            Console.Write("Radio Url: ");
            string radioUrl = Console.ReadLine();
            radio.RadioUrl = radioUrl;
        }
    }
}
