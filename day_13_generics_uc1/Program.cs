using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_13_generics_uc1
{
    internal class Day_13_uc_Generics
    {
        static void Main(string[] args)
        {

            Console.WriteLine("UseCase 1 Find Max Int  Number");

            int intOutput = MaxNumberCheck.MaxNumbermethod_Int(11, 22, 33);
            Console.Write(intOutput);

        }
    }
}
