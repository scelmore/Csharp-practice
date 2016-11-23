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
            int n1;
            Console.Write("Enter number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you entered is: {0}", n1);
        }
        static void Main(string[] args)
        {
            number();
            Console.ReadLine();
        }
    }
}
