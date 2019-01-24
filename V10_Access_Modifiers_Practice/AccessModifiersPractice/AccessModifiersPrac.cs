using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Inheritance2
{
    class D : TestDLL.A
    {
        void Test()
        {
            //this.intrA is not accessible here as it is internal to that assembly

            this.protA = 0;//protected is inheriteted
            this.pubA = 0;//public is inheriteted
            this.protIntrA = 0; //protected internal is inherited and accessible here
        }
    }
    public class AAA
    {
        protected static int a;
    }
    class BBB : AAA
    {
        public void show()
        {
            a = 10;
        }
    }
    class CCC : BBB
    {
        public void show1()
        {
            a = 10;
        }
    }

    public class Tester5
    {
        public static void Test()
        {
            Console.WriteLine("---------Tester5.Test() Start------------------");

            TestDLL.A objA = new TestDLL.A(); //A class was public so accessible in this assembly
            TestDLL.B objB = new TestDLL.B();//B class was public so accessible in this assembly
            TestDLL.Class1 objClass1 = new TestDLL.Class1(); //Class1 class was public so accessible in this assembly

            /*
             * TestDLL.Class2 is not accessible as it was 'internal'
             * TestDLL.Class3 is not accessible as it was 'internal'
             */

            objA.pubA = 0; // This property is accessible here as it was public in 'A' class

            //objA.prvA is not accessible as it is private in 'A' class
            //objA.protA is not accessible as it is protected in 'A' class
            //objA.intrA is not accessible as it is internal in 'A' class (means only accessible in that assembly)
            //objA.protIntrA is not accessible as it is protected internal in 'A' class (means only accessible in that assembly or in class which will inherit A in this assembly)





            Console.WriteLine("---------Tester5.Test() End------------------");
        }
    }
}
