using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ConsoleOperations
{
    internal class PrintSong
    {
        public void PrintSongOperation()
        {
            Console.Write("Enter Song Id: ");
            long songId = Convert.ToInt64(Console.ReadLine());
        }
    }
}
