using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Inheritance2
{
    //Here A is not inheriting any class so by default it is inheriting from 'Object' class
    public class A
    {
        public A()
        {
            Console.WriteLine("A.Default Constructor");
        }
        public A(int a)
        {
            Console.WriteLine("A.Parameterized Constructor");
        }
    }

    //Here is B class which is child of A
    public class B : A
    {
        public B()
        {
            Console.WriteLine("B.Default Constructor");
        }
        //Here we want that B should call A's parameterized constructor
        //and pass 'b' as parameter to it
        public B(int b)
            : base(b)
        {
            Console.WriteLine("B.Parameterized Constructor");
        }
    }

    //This is tester class to Test above classes
    public class Tester1
    {
        public static void Test()
        {
            Console.WriteLine("---------Tester1.Test() Start------------------");
            // Create Instance of B class

            B obj = new B();//This will call default constructor of B

            B obj1 = new B(10);//This will call parameterize constructor of B
            
            Console.WriteLine("---------Tester1.Test() End------------------");
        }
    }
}
