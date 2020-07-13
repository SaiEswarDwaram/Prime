using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,num;
            int value = 0;

            Console.WriteLine("Enter the number to be checked");
            num = Convert.ToInt32(Console.ReadLine());

            for (i=1;i<=num;i++)
            {
                if (num % i == 0)
                    value = value + 1;
            }
            if (value == 2)
                Console.WriteLine("The number is prime");
            else
                Console.WriteLine("The number is not prime");
        }
    }
}
