using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ConsoleOperations
{
    internal class DeletePerformer
    {
        public void DeletePerformerOperation()
        {
            Console.Write("Enter Performer Id: ");
            long performerId = Convert.ToInt64(Console.ReadLine());
        }
    }
}
