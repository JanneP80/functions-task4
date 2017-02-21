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
            int askednumber = 0;

            askednumber = AskTenInts(); // combo for getting largest number and filling array

            Console.WriteLine("You have inputted following numbers: "); // Next print full array

            foreach (int i in userinputsten)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nAnd largest number was: {0}", askednumber);
            Console.ReadKey();
        }

        static int AskTenInts()
        {
            int checkedvalue = 0;
            int loopsize = 10;
            int arraypointer = 0;
            // Ask 10 positive integers
            // Ask correction on wrong numbers
            Console.WriteLine("Insert {0} positive numbers: ", loopsize);

            for (int i = 1; i <= loopsize; i++)
            {
                do
                {
                    Console.Write("{0}. ", i);
                    userinputsten[i - 1] = int.Parse(Console.ReadLine());
                    if (userinputsten[i - 1] < 0)
                    {
                        Console.WriteLine("Incorrect input, please try again: ");
                    }

                }
                while (userinputsten[arraypointer] < 0);
                arraypointer++;
            }
                // kysyttävä silmukassa ja oikea numero indeksille
                // Return the largest
                return checkedvalue;

            }
        }
    }
