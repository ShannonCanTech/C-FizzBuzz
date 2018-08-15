using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To get started, enter an integer value for x and y.");
            Console.WriteLine("To exit, type exit.");
            do
            {
                Console.Write("x = ");
                string str = Console.ReadLine();
                if (str == "exit") {
                    Console.WriteLine("Exiting..");
                    break;
                 }

                int x = Convert.ToInt32(str);

                Console.Write("y = ");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = x + y;
                Console.WriteLine("Result: {0}", sum);
            } while (true);

            Console.ReadKey();
        }
    }
}
