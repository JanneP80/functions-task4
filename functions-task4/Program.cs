using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userinputsten = new int[10];
            int askednumber;

            askednumber = AskTenInts();

            Console.WriteLine("You have inputted following numbers: "); // Next print full array
            foreach (int i in userinputsten)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("And largest number was: {0}", askednumber);
            Console.ReadKey();
        }

        public static int AskTenInts()
        {
            int checkedvalue=0;

            // Ask 10 positive integers
            // Ask correction on wrong numbers


            // Return the largest
            return checkedvalue;
        }
    }
}
