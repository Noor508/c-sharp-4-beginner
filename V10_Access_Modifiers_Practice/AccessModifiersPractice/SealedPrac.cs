using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Inheritance2
{
    //This class can't be inherited futher
    sealed class AA
    {
    }

    /* Invalid declaration here
    class BB : AA
    {
    }
     */

    public class Tester6
    {
        public static void Test()
        {
            Console.WriteLine("---------Tester6.Test() Start------------------");



            Console.WriteLine("---------Tester6.Test() End------------------");
        }
    }
}
