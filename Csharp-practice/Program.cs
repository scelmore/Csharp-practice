using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practice
{
    class Program
    {
        public static void number()
        {
            int n1, n2, temp;
            Console.Write("Enter first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //Before swap
            Console.WriteLine("{0} , {1}", n1, n2);
            //swap the two integers
            temp = n1;
            n1 = n2;
            n2 = temp;
            //after swap
            Console.WriteLine("{0} , {1}", n1, n2);
        }
        static void Main(string[] args)
        {
            number();
            Console.ReadLine();
        }
    }
}
