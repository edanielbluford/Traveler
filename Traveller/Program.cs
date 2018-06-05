using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the age of your best friend");
            int userInput = int.Parse(Console.ReadLine());

            CruiseShip Cat = new CruiseShip(userInput);
            Cat.WhichShip();

        }
    }
}
