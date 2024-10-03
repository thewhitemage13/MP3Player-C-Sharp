using Spotify.ConsoleOperations;

namespace Spotify.Managers
{
    internal class PerformerManager
    {
        private AddPerformer addPerformer = new AddPerformer();
        private UpdatePerformer updatePerformer = new UpdatePerformer();
        private PrintPerformer printPerformer = new PrintPerformer();
        private DeletePerformer deletePerformer = new DeletePerformer();

        public void add()
        {
            addPerformer.AddPerformerOperation();
        }

        public void update()
        {
            updatePerformer.UpdatePerformerOperation();
        }

        public void delete()
        {
            deletePerformer.DeletePerformerOperation();
        }

        public void print()
        {
            printPerformer.PrintPerformerOperation();
        }
    }
}
