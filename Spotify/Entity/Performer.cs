using Spotify.Enums;

namespace Spotify.Entity
{
    internal class Performer
    {
        private long performerId;
        private string name;
        private Genre genre;
        private List<MusicCollection> musicCollection = new List<MusicCollection>();
        private List<Song> songs = new List<Song>();

        public Performer() { }

        public Performer(string name, Genre genre)
        {
            this.name = name;
            this.genre = genre;
        }

        public long GetPerformerId()
        {
            return performerId;
        }

        public void SetPerformerId(long performerId)
        {
            this.performerId = performerId;
        }

        public List<Song> GetSongs() 
        {
            return songs;
        }

        public void AddSong(Song song)
        {
            this.songs.Add(song);
        }

        public List<MusicCollection> GetMusicCollections() 
        {
            return musicCollection;
        }

        public void AddMusicCollection(MusicCollection musicCollection) 
        {
            this.musicCollection.Add(musicCollection);
        }

        public Genre GetGenre() 
        { 
            return genre; 
        }

        public void SetGenre(Genre genre)
        {
            this.genre = genre;
        }

        public string GetName() 
        { 
            return name; 
        }

        public void SetName(string name)
        { 
            this.name = name; 
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Performer: {name}, Genre: {genre}, Songs Count: {songs.Count}, Music Collections Count: {musicCollection.Count}";
        }
    }
}
