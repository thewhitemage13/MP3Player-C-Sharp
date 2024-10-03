using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ConsoleOperations
{
    internal class PrintPerformer
    {
        public void PrintPerformerOperation()
        {
            Console.Write("Enter Perormer Id: ");
            long performerId = Convert.ToInt64(Console.ReadLine());
        }
    }
}
