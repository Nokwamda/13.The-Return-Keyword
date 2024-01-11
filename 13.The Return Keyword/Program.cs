using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.The_Return_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling methods with a return types
            Console.WriteLine(cube(5));
            //this wont give anything to console
            cube(5);

            //freeze console
            Console.ReadLine();
        }
        static int cube(int number)
        {
            int result = number * number * number;
            return result;
        }
    }
}
