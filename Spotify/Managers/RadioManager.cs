using Spotify.ConsoleOperations;

namespace Spotify.Managers
{
    internal class RadioManager
    {
        private AddRadio addRadio = new AddRadio();
        private UpdateRadio updateRadio = new UpdateRadio();
        private PrintRadio printRadio = new PrintRadio();
        private DeleteRadio deleteRadio = new DeleteRadio();

        public void add()
        {
            addRadio.AddRadioOperation();
        }

        public void update()
        {
            updateRadio.UpdateRadioOperation();
        }

        public void delete()
        {
            deleteRadio.DeleteRadioOperation();
        }

        public void print()
        { 
            printRadio.PrintRadioOperation();
        }
    }
}
