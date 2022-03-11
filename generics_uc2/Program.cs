using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_uc2
{
    internal class Day_13_uc_Generics
    {
        static void Main(string[] args)
        {

            Console.WriteLine("UseCase 2 Find Max Double  Number");

            double doubleOutput = MaxNumberCheck_Double.MaxNumbermethod_Double(112.3, 22.23, 33.6);
            Console.Write(doubleOutput);

        }
    }
}