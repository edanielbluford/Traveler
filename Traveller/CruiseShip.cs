using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller
{
    class CruiseShip: Travel
    {


        public CruiseShip(int age)
        {
            Age = age;
        }

        public void WhichShip()
        {

            switch (Converter(Age))
            {
                case 1: Console.WriteLine("You will travel on the Santa Maria");
                    break;
                case 2:
                    Console.WriteLine("You will travel on the Disney Cruise Line");
                    break;
                case 3:
                    Console.WriteLine("You will travel one th Pirate Cruise");
                    break;
                case 4:
                    Console.WriteLine("You will travel on the Hogwarts Express");
                    break;
                case 5:
                    Console.WriteLine("You will travel on the Good Time III");
                    break;
            }

            
        }

        
    }
}
