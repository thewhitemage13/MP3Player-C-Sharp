using System.ComponentModel.DataAnnotations;

namespace Spotify.Entity
{
    /// <summary>
    /// Represents a radio station in the Spotify application.
    /// This class contains information about the radio station, including its name, city, and streaming URL.
    /// </summary>
    public class Radio
    {
        /// <summary>
        /// Gets or sets the unique identifier for the radio station.
        /// </summary>
        [Key]
        public long RadioId { get; set; }
        /// <summary>
        /// Gets or sets the name of the radio station.
        /// </summary>
        public string RadioName { get; set; }
        /// <summary>
        /// Gets or sets the city where the radio station is located.
        /// </summary>
        public string City {  get; set; }
        /// <summary>
        /// Gets or sets the URL for streaming the radio station.
        /// </summary>
        public string RadioUrl {  get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Radio"/> class.
        /// </summary>
        public Radio() {}
        /// <summary>
        /// Initializes a new instance of the <see cref="Radio"/> class with specified parameters.
        /// </summary>
        /// <param name="radioName">The name of the radio station.</param>
        /// <param name="city">The city where the radio station is located.</param>
        /// <param name="radioUrl">The URL for streaming the radio station.</param>
        public Radio(string radioName, string city, string radioUrl)
        {
            RadioName = radioName;
            City = city;
            RadioUrl = radioUrl;
        }
        /// <summary>
        /// Returns a string that represents the current radio station.
        /// </summary>
        /// <returns>A string containing the name, city, and URL of the radio station.</returns>
        public override string ToString()
        {
            return $"Radio Name: {RadioName}, City: {City} ,URL: {RadioUrl}";
        }
    }
}
