using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ConsoleOperations
{
    internal class PrintRadio
    {
        public void PrintRadioOperation()
        {
            Console.Write("Enter Radio Id: ");
            long radioId = Convert.ToInt64(Console.ReadLine());
        }
    }
}
