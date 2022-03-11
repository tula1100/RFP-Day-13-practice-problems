using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_uc3
{
    internal class Day_13_uc_Generics
    {
        static void Main(string[] args)
        {

            Console.WriteLine("UseCase 3 Find Max String  Number");

            string stringOutput = MxNumbercheck_String.MaxNumbermethod_String("11", "22", "44");
            Console.Write(stringOutput);

        }
    }
}