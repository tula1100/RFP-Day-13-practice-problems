using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc_4_5
{
    internal class Day_13_uc_Generics
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Find Max Int  Number using Generic Method");
            Refactor_to_generic<int>.FindMax<int>(11, 22, 9, 44);

            Console.WriteLine("Find Max Double  Number using Generic Method");
            Refactor_to_generic<double>.FindMax<double>(11.3, 22.23, 9.55, 30.5);

            Console.WriteLine("Find Max String Number using Generic Method");
            Refactor_to_generic<double>.FindMax<string>("22", "33", "44", "11");

        }
    }
}
