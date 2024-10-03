using Spotify.ConsoleOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Managers
{
    class SongManager
    {
        private AddSong addSong = new AddSong();
        private UpdateSong updateSong = new UpdateSong();
        private DeleteSong deleteSong = new DeleteSong();
        private PrintSong printSong = new PrintSong();

        public void add()
        {
            addSong.AddSongOperation();
        }

        public void update()
        {
            updateSong.UpdateSongOperation();
        }

        public void delete()
        {
            deleteSong.DeleteSongOperation();
        }

        public void print()
        {
            printSong.PrintSongOperation();
        }
    }
}
