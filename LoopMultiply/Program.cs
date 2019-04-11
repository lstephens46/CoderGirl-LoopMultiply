using System;
using System.Collections.Generic;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {

            Console.Write("Enter a number: ");
            int userInt = Int32.Parse(Console.ReadLine());
            //List<int> values = new List<int>();
            int added = 0; 
            for (int i = 2; i <= 20; i++)
            {
                int value = userInt * i;
                //values.Add(value);
                Console.WriteLine(value);
                added += value;
            }
            Console.WriteLine(added);
            Console.ReadLine();




            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 
            

        }

    }

} 
