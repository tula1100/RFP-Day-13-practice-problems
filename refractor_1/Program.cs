using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refractor_1
{
    internal class Day_13_uc_Generics
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Find Max Int  Number using Generic Method");
            Refactor_to_generic.FindMax<int>(11, 22, 9);

            Console.WriteLine("Find Max Double  Number using Generic Method");
            Refactor_to_generic.FindMax<double>(11.3, 22.23, 9.55);

            Console.WriteLine("Find Max String Number using Generic Method");
            Refactor_to_generic.FindMax<string>("22", "33", "44");

        }
    }
}