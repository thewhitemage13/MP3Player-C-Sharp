using NUnit.Framework;
using Spotify.Entity;
using Spotify.Enums;

namespace SpotifyTest.EntitiesTests
{
    public class PerformerTest
    {
        private Performer performer = null;
        private string testName;
        private Genre testGenre;
        [SetUp]
        public void InitializeTestData()
        {
            performer = new Performer();
            testName = "Test Name 1";
            testGenre = Genre.Classical;
        }
        [Test]
        public void SetName_ShouldUpdatePerformerName()
        {
            performer.Name = testName;
            Assert.That(performer.Name, Is.EqualTo(testName));
        }
        [Test]
        public void SetGenre_ShouldUpdatePerformerGenre()
        {
            performer.Genre = testGenre;
            Assert.That(performer.Genre, Is.EqualTo(testGenre));
        }
        [Test]
        public void Constructor_ShouldInitializePerformerCorrectly()
        {
            Performer performer = new Performer
                (
                    testName,
                    testGenre
                );
            Assert.That(performer.Name, Is.EqualTo(testName));
            Assert.That(performer.Genre, Is.EqualTo(testGenre));
        }
    }
}