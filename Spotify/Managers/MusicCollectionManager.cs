using Spotify.ConsoleOperations;
using Spotify.Interfaces;

namespace Spotify.Managers
{
    internal class MusicCollectionManager : IMusicCollectionManager
    {
        private AddMusicCollection addMusicCollection = new AddMusicCollection();
        private DeleteMusicCollection deleteMusicCollection = new DeleteMusicCollection();
        private UpdateMusicCollection updateMusicCollection = new UpdateMusicCollection();
        private PrintMusicCollection printMusicCollection = new PrintMusicCollection();

        public void add()
        {
            addMusicCollection.AddMusicCollectionOperation();
        }

        public void delete()
        {
            deleteMusicCollection.DeleteMusicCollectionOperation();
        }

        public void update()
        {
            updateMusicCollection.UpdateMusicCollectionOperation();
        }
        public void print()
        {
            printMusicCollection.PrintMusicCollectionOperation();
        }
    }
}
