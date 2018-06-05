using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller
{
    class Travel
    {
        public int Age { get; set; }

        public Travel()
        {
            //default constructor
        }

        public Travel(int age)
        {
            Age = age;
        }

        public int Converter(int age)
        {
            
            
            switch (Age)
            {
                case 31: Age = 1;
                    break;
                case 32: Age = 2;
                    break;
                case 33: Age = 3;
                    break;
                case 34:
                    Age = 4;
                    break;
                case 35:
                    Age = 5;
                    break;


            }
            return Age;
        }
    }
}
