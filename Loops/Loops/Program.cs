using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int counter = 0; counter < 10; counter = counter + 2)
            {
                Console.WriteLine("Hello World number is " + counter);
            }

            ////Console.WriteLine("How many iterations (enter a whole number)?");
            //int repeat = 0; // int.Parse(Console.ReadLine());

            //string another = String.Empty;
            //do
            //{
            //    Console.WriteLine("this is iteration " + repeat--);
            //    Console.WriteLine("Another iteration (yes/no)");
            //    another = Console.ReadLine();

            //} while (another == "yes");

            //while (repeat > 0)
            //{
            //    Console.WriteLine("this is iteration " + repeat--); 
            //}

            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
    }
}
