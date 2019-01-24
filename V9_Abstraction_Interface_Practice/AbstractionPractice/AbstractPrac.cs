using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnProgramming.Inheritance2
{
    //Instance of 'abstract' class can't be created but 'Reference Variable' can be created
    //Abstract class may have 0 or more 'abstract' methods
    abstract class Car
    {
        //abstract method without any definition
        //abstract method can't be private
        public abstract void Drive();

        //abstract class can contain non-abstract methods
        public void BuildCar()
        {
            Console.WriteLine("Car.BuildCar()");
        }

        //abstract class can also contain virtual methods
        public virtual void BuildCarVirtual()
        {
            Console.WriteLine("Car.BuildCarVirtual()");
        }

    }
    class Suzuki : Car
    {
        public override void Drive()
        {
            System.Console.WriteLine("Suzikie Drive");
        }
    }
    class Honda : Car
    {
        public override void Drive()
        {
            System.Console.WriteLine("Honda Drive");
        }
        public void BuildCarVirtual()
        {
            System.Console.WriteLine("Honda BuildCarVirtual");
        }
    }

    class Mehran : Car
    {
        public override void Drive()
        {
            System.Console.WriteLine("Mehran Drive");
        }
        public override void BuildCarVirtual()
        {
            System.Console.WriteLine("Mehran BuildCarVirtual");
        }
    }

    //This is tester class to Test above classes
    public class Tester3
    {
        public static void Test()
        {
            Console.WriteLine("---------Tester3.Test() Start------------------");

            Car[] cars = new Car[3];

            cars[0] = new Suzuki();
            cars[1] = new Honda();
            cars[2] = new Mehran();


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-------------------------");
                cars[i].Drive();
                cars[i].BuildCar();
                cars[i].BuildCarVirtual();
            }

                Console.WriteLine("---------Tester3.Test() End------------------");
        }
    }
}
