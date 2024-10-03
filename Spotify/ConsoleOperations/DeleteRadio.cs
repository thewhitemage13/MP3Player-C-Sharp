using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ConsoleOperations
{
    internal class DeleteRadio
    {
        public void DeleteRadioOperation()
        {
            Console.Write("Enter Radio Id: ");
            long radioId = Convert.ToInt64(Console.ReadLine());
        }
    }
}
