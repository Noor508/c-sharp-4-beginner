using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLearning
{
    //Delegate Keyword
    public delegate int MyDelegate(int a, int b);
    public class DelegatesPrac
    {
        int Sum(int a, int b)
        {
            Console.WriteLine("Sum is called");
            int c = a + b;
            return c * 2;
        }

        int Mul(int x, int y)
        {
            Console.WriteLine("Mul is called");
            return x * y;
        }

        public void Show()
        {
            Console.WriteLine("Show is called");
        }
        public void Show1(int a)
        {
            Console.WriteLine("Show1 is called");
        }
        public void Show2(int a,int b)
        {
            Console.WriteLine("Show1 is called");
        }

        public float ShowFunc()
        {
            Console.WriteLine("Show is called");
            return 0;
        }
        public float ShowFunc1(int a)
        {
            Console.WriteLine("Show1 is called");
            return 0;
        }
        public float ShowFunc2(int a, int b)
        {
            Console.WriteLine("Show1 is called");
            return 0;
        }

        public Boolean PredicateTesting(int x)
        {
            return true;
        }
        public void Test()
        {
            MyDelegate f1 = new MyDelegate(Sum);
            MyDelegate f = Sum;
            

            var r = f(5, 10);
            Console.WriteLine("Result is {0}", r);

            r = f1(15, 20);
            Console.WriteLine("Result is {0}", r);

        }

        public void Test2()
        {
            MyDelegate f = Sum;
            f = f + Mul;

            var r = f(5, 10);
            Console.WriteLine("Result:{0}", r);

            Console.WriteLine("Count:{0}", f.GetInvocationList().Count());

            Console.WriteLine("-------------------");
            f = f - Sum;

            r = f(5, 10);
            Console.WriteLine("Result:{0}", r);
            Console.WriteLine("-------------------");

            f = f - Mul;

            //r = f(5, 10);
            //Console.WriteLine("Result:{0}", r);
            Console.WriteLine("-------------------");

        }
        
        public void Test3()
        {
            //Action is used where void is return type

            //No Input
            Action a = Show;
            a();

            //1 input
            Action<int> a1 = Show1;
            a1(5);

            //2 input
            Action<int,int> a2 = Show2;
            a2(5,10);

            //Func is used when there is non-void return type

            //No input, return type is float
            Func<float> f = ShowFunc;

            //int input, return type is float
            Func<int, float> f1 = ShowFunc1;

            //int,int input, return type is float
            Func<int,int, float> f2 = ShowFunc2;

            //Takes a type as input, return type is Boolean
            Predicate<int> p = PredicateTesting;
            var r = p(5);


        }
    }
}
