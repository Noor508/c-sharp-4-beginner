using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDLL
{
    public class A
    {
        private int prvA;
        public int pubA;
        protected int protA;
        internal int intrA;
        protected internal int protIntrA;
    }

    public class B : A
    {
        void Test()
        {
            this.intrA = 0; //internal is inheriteted as it is public within assembly
            this.protA = 0;//protected is inheriteted
            this.pubA = 0;//public is inheriteted
            this.protIntrA = 0; //protected internal is inherited
        }

        void Test2()
        {
            A obj = new A();

            obj.intrA = 0; //internal member is accessible by Object + .
            obj.pubA = 0; //public member is accessible by Object + .
            obj.protIntrA = 0; //protected internal member is accessible by Object + .
        }
    }

    
}
