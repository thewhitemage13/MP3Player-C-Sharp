using NUnit.Framework;
using Spotify.Entity;
using Spotify.Enums;

namespace SpotifyTest.EntitiesTests
{
    public class MusicCollectionTests
    {
        private MusicCollection musicCollection;
        private string testName;
        private TypeOfCollection testCollection;
        private DateTime testDateTime;
        private Performer testPerformer;
        [SetUp]
        public void InitializeTestData()
        {
            musicCollection = new MusicCollection();
            testDateTime = DateTime.Now;
            testName = "Test Name";
            testCollection = TypeOfCollection.Album;
            testPerformer = new Performer("Test Name", Genre.Rock);
        }
        [Test]
        public void SetName_ShouldUpdateMusicCollectionName()
        {
            musicCollection.Name = testName;
            Assert.That(testName, Is.EqualTo(musicCollection.Name));
        }
        [Test]
        public void SetReleaseDate_ShouldUpdateMusicCollectionReleaseDate()
        {
            musicCollection.ReleaseDate = testDateTime;
            Assert.That(testDateTime, Is.EqualTo(musicCollection.ReleaseDate));
        }
        [Test]
        public void SetTypeOfCollection_ShouldUpdateCollectionType()
        {
            musicCollection.TypeOfCollection = testCollection;
            Assert.That(testCollection, Is.EqualTo(musicCollection.TypeOfCollection));
        }
        [Test]
        public void SetPerformer_ShouldUpdatePerformer()
        {
            musicCollection.Performer = testPerformer;
            Assert.That(testPerformer, Is.EqualTo(musicCollection.Performer));
        }
    }
}
