using Spotify.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.ConsoleOperations
{
    internal class AddRadio
    {
        public void AddRadioOperation()
        {
            Radio radio = new Radio();
            Console.WriteLine("Enter Information About Radio:");
            
            Console.Write("Enter Radio Name: ");
            string radioName = Console.ReadLine();
            radio.City = radioName;

            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            radio.City = city;

            Console.Write("Radio Url: ");
            string radioUrl = Console.ReadLine();
            radio.RadioUrl = radioUrl;
        }
    }
}
