using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_task4
{
    class Program
    {
        static int[] userinputsten;

        static void Main(string[] args)
        {
            userinputsten = new int[10];
            int askednumber;

            askednumber = AskTenInts(); // combo for getting largest number and filling array

            Console.WriteLine("You have inputted following numbers: "); // Next print full array

            foreach (int i in userinputsten)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\nAnd largest number was: {0}", askednumber);
            Console.ReadKey();
        }

        static int AskTenInts()
        {
            int checkedvalue = 0;
            int loopsize = 10;
            //int arraypointer = 0;
            // Ask 10 positive integers
            // Ask correction on wrong numbers
            Console.WriteLine("Insert {0} positive numbers: ", loopsize);

            for (int arraypointer = 0; arraypointer < loopsize; arraypointer++)
            {
                Console.WriteLine("{0}. ", arraypointer);
                userinputsten[arraypointer] = int.Parse(Console.ReadLine());
            }
            // kysyttävä silmukassa ja oikea numero indeksille


            // Return the largest
            return checkedvalue;
        }
    }
}
