using Spotify.Enums;

namespace Spotify.Entity
{
    internal class Song
    {
        private long songId;
        private string name;
        private TypeOfSong typeOfSong;
        private int duration;
        private string filePath;
        private Genre genre;
        private long performerId;

        public Song() {}

        public Song(string name, TypeOfSong typeOfSong, int duration, string filePath, Genre genre)
        {
            this.name = name;
            this.typeOfSong = typeOfSong;
            this.duration = duration;
            this.filePath = filePath;
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

        public long GetSongId()
        {
            return songId;
        }

        public void SetSongId(long songId)
        {
            this.songId = songId;
        }

        public Genre GetGenre()
        {
            return genre;
        }

        public void SetGenre(Genre genre) 
        {
            this.genre = genre;
        }

        public string GetFilePath()
        {
            return filePath;
        }

        public void SetFilePath(string filePath)
        {
            this.filePath = filePath;
        }

        public int GetDuration() 
        {
            return duration;
        }

        public void SetDuration(int duration)
        {
            this.duration = duration;
        }

        public TypeOfSong GetTypeOfSong()
        {
            return typeOfSong;
        }

        public void SetTypeOfSong(TypeOfSong typeOfSong)
        {
            this.typeOfSong = typeOfSong;
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
