namespace Spotify.Entity
{
    internal class Radio
    {
        private long radioId;
        private string radioName;
        private string city;
        private string radioUrl;

        public string GetRadioUrl()
        {
            return radioUrl;
        }

        public void SetRadioUrl(string radioUrl)
        {
            radioUrl = radioUrl.ToLower();
        }

        public string GetCity()
        {
            return city;
        }

        public void SetCity(string city)
        {
            this.city = city;
        }

        public string GetRadioName()
        {
            return radioName;
        }

        public void SetRadioName(string radioName)
        {
            this.radioName = radioName;
        }

        public long GetRadioId()
        {
            return radioId;
        }

        public void SetRadioId(long radioId)
        {
            this.radioId = radioId;
        }
    }
}
