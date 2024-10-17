using NUnit.Framework;
using Spotify.Entity;
using Spotify.Enums;

namespace SpotifyTest.EntitiesTests
{
    [TestFixture]
    public class SongTests
    {
        private Song song = null;
        private string testName;
        private TypeOfSong testType;
        private int testDuration;
        private string testFilePath;
        private Genre testGenre;
        private DateTime testUploadedTo;
        private Performer testPerformer;
        [SetUp]
        public void InitializeTestData()
        {
            song = new Song();
            testName = "Test Song Name 1";
            testType = TypeOfSong.Remake;
            testDuration = 5;
            testFilePath = "test/file/path";
            testGenre = Genre.Electronic;
            testUploadedTo = new DateTime(2023, 10, 5, 14, 30, 0);
            testPerformer = new Performer("Test Performer Name", Genre.Country);
        }
        [Test]
        public void SetName_ShouldUpdateSongName() 
        {
            song.Name = testName;
            Assert.That(testName, Is.EqualTo(song.Name));
        }
        [Test]
        public void SetUploadedTo_ShouldUpdateUploadedToDate()
        {
            song.UploadedTo = testUploadedTo;
            Assert.That(testUploadedTo, Is.EqualTo(song.UploadedTo));
        }
        [Test]
        public void SetGenre_ShouldUpdateGenre()
        {
            song.Genre = testGenre;
            Assert.That(testGenre, Is.EqualTo(song.Genre));
        }
        [Test]
        public void SetTypeOfSong_ShouldUpdateSongType()
        {
            song.TypeOfSong = testType;
            Assert.That(testType, Is.EqualTo(song.TypeOfSong));
        }
        [Test]
        public void SetDuration_ShouldUpdateDuration()
        {
            song.Duration = testDuration;
            Assert.That(testDuration, Is.EqualTo(song.Duration));
        }
        [Test]
        public void SetFilePath_ShouldUpdateFilePath()
        {
            song.FilePath = testFilePath;
            Assert.That(testFilePath, Is.EqualTo(song.FilePath));
        }
        [Test]
        public void SetPerformer_ShouldUpdatePerformer()
        {
            song.Performer = testPerformer;
            Assert.That(testPerformer, Is.EqualTo(song.Performer));
        }
        [Test]
        public void Constructor_ShouldInitializeSongCorrectly()
        {
            Song song2 = new Song
                (
                    testName,
                    testType,
                    testDuration,
                    testFilePath,
                    testGenre,
                    testUploadedTo
                );

            Assert.That(song2.Name, Is.EqualTo(testName));
            Assert.That(song2.TypeOfSong, Is.EqualTo(testType));
            Assert.That(song2.Duration, Is.EqualTo(testDuration));
            Assert.That(song2.FilePath, Is.EqualTo(testFilePath));
            Assert.That(song2.Genre, Is.EqualTo(testGenre));
            Assert.That(song2.UploadedTo, Is.EqualTo(testUploadedTo));
        }
    }
}
