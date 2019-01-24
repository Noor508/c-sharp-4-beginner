using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Inheritance2
{
    public class Parent
    {
        public void Show1()
        {
            Console.WriteLine("Parent.Show1");
        }
        public void Show2()
        {
            Console.WriteLine("Parent.Show2");
        }
        public virtual void Show3()
        {
            Console.WriteLine("Parent.Show3");
        }
        public virtual void Show4()
        {
            Console.WriteLine("Parent.Show4");
        }
    }

    public class Child : Parent
    {
        //This is hiding parent 'Show2' method
        public void Show2()
        {
            Console.WriteLine("Child.Show4");
        }
        //Here we've overriden parent 'Show3' method
        public override void Show3()
        {
            Console.WriteLine("Child.Show4");
        }

        //Here instead of overriding, we had 'hidden' parent 'Show4' method
        public new void Show4()
        {
            Console.WriteLine("Child.Show4");
        }
    }

    //This is tester class to Test above classes
    public class Tester2
    {
        public static void Test()
        {
            Console.WriteLine("---------Tester2.Test() Start------------------");

            Console.WriteLine("---------Parent obj = new Parent() Starts------------------");
            Parent obj = new Parent();
            obj.Show1();
            obj.Show2();
            obj.Show3();
            obj.Show4();

            Console.WriteLine("---------Child obj1 = new Child(); Starts------------------");
            Child obj1 = new Child();
            obj1.Show1();
            obj1.Show2();
            obj1.Show3();
            obj1.Show4();

            Console.WriteLine("---------Parent obj2 = new Child(); Starts------------------");
            Parent obj2 = new Child();
            obj2.Show1();
            obj2.Show2();

            //Here it will go to 'Parent' and will see that 'Show4' is virtual
            //Then it will go to 'Child' to see if 'Child' has overriden 'Show4'
            //Child has overriden so it will execute 'Show4' method of 'Child'
            obj2.Show3();
            
            //Here it will go to 'Parent' and will see that 'Show4' is virtual
            //Then it will go to 'Child' to see if 'Child' has overriden 'Show4'
            //Child has not overriden but provided definition with 'new' so it will
            //execute the 'Parent' 'Show4' method
            obj2.Show4();


            Console.WriteLine("---------Tester2.Test() End------------------");
        }
    }
}
