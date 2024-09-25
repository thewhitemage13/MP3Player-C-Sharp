using Spotify.Enums;

namespace Spotify.Entity
{
    internal class MusicCollection
    {
        private long musicCollectionId;
        private string name;
        private TypeOfCollection typeOfCollection;
        private DateTime releaseDate;
        private long performerId;
        private Performer performer;
        private List<Song> song = new List<Song>();

        public MusicCollection() { }

        public MusicCollection(string name, TypeOfCollection typeOfCollection, DateTime releaseDate, Performer performer) 
        {
            this.name = name;
            this.typeOfCollection = typeOfCollection;
            this.releaseDate = releaseDate;
            this.performer = performer;
        }
        public long GetPerformerId()
        {
            return performerId;
        }
        public void SetPerformerId(long performerId)
        {
            this.performerId = performerId;
        }
        public long GetMusicCollectionId()
        { 
            return musicCollectionId; 
        }
        public void SetMusicCollectionId(long musicCollectionId)
        {
            this.musicCollectionId = musicCollectionId;
        }
        public void AddSong(Song song)
        {
            this.song.Add(song);
        }
        public DateTime GetRealeaseDate()
        {
            return releaseDate;
        }
        public void SetRealeaseDate(DateTime releaseDate)
        {
            this.releaseDate = releaseDate;
        }
        public Performer getPerformer() 
        { 
            return performer; 
        }
        public void SetPerformer(Performer performer) 
        { 
            this.performer = performer;
        }
        public TypeOfCollection GetTypeOfCollection() 
        { 
            return typeOfCollection; 
        }
        public void SetTypeOfSongCollection(TypeOfCollection typeOfCollection) 
        {
            this.typeOfCollection = typeOfCollection;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name) 
        { 
            this.name = name;
        }
    }
}
