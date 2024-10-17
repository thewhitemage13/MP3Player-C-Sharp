using NUnit.Framework;
using Spotify.Entity;

namespace SpotifyTest.EntitiesTests
{
    [TestFixture]
    public class RadioTests
    {
        private Radio radio = null;
        private string testName;
        private string testCity;
        private string testUrl;
        [SetUp]
        public void InitializeTestData()
        {
            radio = new Radio();
            testName = "Test Radio Name";
            testCity = "Test City";
            testUrl = "test/radio/url";
        }
        [Test]
        public void SetRadioName_ShouldUpdateRadioName()
        {
            radio.RadioName = testName;
            Assert.That(testName, Is.EqualTo(radio.RadioName));
        }
        [Test]
        public void SetRadioUrl_ShouldUpdateRadioUrl()
        {
            radio.RadioUrl = testUrl;
            Assert.That(testUrl, Is.EqualTo(radio.RadioUrl));
        }
        [Test]
        public void SetCity_ShouldUpdateCity()
        {
            radio.City = testCity;
            Assert.That(testCity, Is.EqualTo(radio.City));
        }
        [Test]
        public void Constructor_ShouldInitializeRadioCorrectly()
        {
            Radio radio2 = new Radio
                (
                    testName,
                    testCity,
                    testUrl
                );
            
            Assert.That(testCity, Is.EqualTo(radio2.City));
            Assert.That(testName, Is.EqualTo(radio2.RadioName));
            Assert.That(testUrl, Is.EqualTo(radio2.RadioUrl));
        }
    }
}
