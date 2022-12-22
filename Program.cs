using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Starting number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the End number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The perfect numbers: ");
            for (int i = num1; i <= num2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == i)
                {
                    Console.Write("\t" + i + "\n");
                }
            }
            Console.WriteLine("--------------");
        }
    }
}
