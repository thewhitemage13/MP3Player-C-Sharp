using System.ComponentModel.DataAnnotations;

namespace Spotify.Entity
{
    internal class Radio
    {
        [Key]
        public long RadioId { get; set; }
        public string RadioName { get; set; }
        public string City {  get; set; }
        public string RadioUrl {  get; set; }
    }
}
