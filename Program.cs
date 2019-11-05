using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize1
{
    class Program
    {
        //Task #2
      /*  static void Main(string[] args)
        {
            
            int a;
            int sum = 0;
            int n = 0;
            Console.Write("Enter number: ");
            a = int.Parse(Console.ReadLine());

            while (a != 0)
            {

                sum += a % 10;
                a = a / 10;
            }
            Console.WriteLine("The results {0} ", sum);
            Console.ReadKey();


        }

    */
       
        //Task# 1
       
      /*  static void Main(string[] args)
        {
             int count = 8;
            string print = "*";
            string space = " ";
            for (int i = 0; i < count; i++)
            {
                for (int j = count - 1; j > i; j--)
                {
                    Console.Write(space);
                }
                Console.WriteLine(print);
                print = print + "*";
            }
            Console.ReadLine();
        }
        */

        //Task#4

        static void Main (string[] args)
        {
            int i,fact = 1, n;
            Console.WriteLine("Enter number");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + n + " is: " + fact);
            Console.ReadKey();
        }
    }




}
    




       
