using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLearning
{
    /* 
     * A delegate is a reference type variable that holds the reference to a method. 
     * The reference can be changed at runtime.
     */
    public delegate int MyFunc(int amount);
    class Anon_LambadaPractice
    {
        public void Test()
        {
            /*
              * Anonymous methods provide a technique to pass a code block as a delegate parameter. 
              * Anonymous methods are the methods without a name, just the body.
             */

            MyFunc f = delegate (int a)
            {
                return a * a;
            };

            var result = f(9);
            Console.WriteLine("Result is:{0}", result);


            f += delegate (int b)
            {
                return b + b;
            };

            var result1 = f(5);
            Console.WriteLine("Result is:{0}", result1);


            Func<int, int> f1 = delegate (int a)
             {
                 return 10;
             };


            //Lambda Expressions
            //Shorter way to write anonymous functions
            //separated by =>

            MyFunc f3 = (int x) => x * x;
            var r = f3(5);

            //Multi statement
            MyFunc f4 = (int x) => {
                int z = x * x;
                return z;
            };

            r = f4(10);

            //using Builtin delegates
            Func<int,int,int> f5 = (int x,int y) => x +y;
            r = f5(5, 10);

            //Multi statement
            Func<int, int, int> f6 = (int x, int y) => {
                int z = x + y;
                return z;
            };

            r = f6(5, 10);

           
            //Predicate example
            Predicate<int> isEven = (int x) => (x % 2 == 0);
            var ie = isEven(5);
        }
    }
}
