using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples1
{
    internal class Program
    {
        static void Main1()
        {
            DerivedClass o = new DerivedClass();
            //o.
            Console.ReadLine();
        }
    }
    public class BaseClass //: Object
    {
        public int a;
    }
    public class DerivedClass : BaseClass
    {
        public int b;
    }

}

namespace InheritanceExamples2
{
    
    internal class Program
    {
        static void Main2()
        {
            //BaseClass o = new BaseClass();
            //o.
            TestAccessSpecifiers.BaseClass o = new TestAccessSpecifiers.BaseClass();
            //o.
        }
    }
    public class BaseClass 
    {
        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
        private protected int PRIVATE_PROTECTED;
    }
    public class DerivedClass : TestAccessSpecifiers.BaseClass //: BaseClass
    {
        void DoSomething()
        {
            //this.
        }
    }

}
/*
public -- everywhere
private -- only within same class
protected -- same class, derived class
internal  -- same class, same assembly(same project)
protected internal -- same class, derived class, same assembly(same project)
private protected -- same class, derived classes that are in the same assembly
*/

//constructors in inheritance
namespace InheritanceExamples3
{
    class Program
    {
        static void Main3()
        {
            //DerivedClass o = new DerivedClass();
            DerivedClass o2 = new DerivedClass(123, 456);
            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("base class no param cons");
            i = 10;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("base class int cons");
            this.i = i;
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("derived class no param cons");
            //i = 10;
            j = 20;
        }
        public DerivedClass(int i, int j) : base(i)
        {
            Console.WriteLine("derived class int,int cons");
            //this.i = i;
            this.j = j;
            int sakshi;
            sakshi = 100000;
        }
    }
}

//overloading, hiding/overriding base class method in derived class
namespace InheritanceExamples4
{
    class Program
    {
        static void Main1()
        {
            DerivedClass o = new DerivedClass();
            o.Display1();
            o.Display1("");
            o.Display2();
            o.Display3();
            Console.ReadLine();
        }

        //difference between hiding and overriding
        static void Main()
        {
            BaseClass o;
            o = new BaseClass();
            //o.Display2();
            o.Display3();

            Console.WriteLine();
            o = new DerivedClass();
            //o.Display2();
            o.Display3();

            Console.WriteLine();
            o = new SubDerivedClass();
            //o.Display2();
            o.Display3();

            Console.WriteLine();
            o = new SubSubDerivedClass();
            //o.Display2();
            o.Display3();

            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("base display1");
        }
        public void Display2()
        {
            Console.WriteLine("base display2");
        }
        public virtual void Display3()
        {
            Console.WriteLine("base display3");
        }
    }
    public class DerivedClass : BaseClass
    {
        //overload the base class method
        public void Display1(string s)
        {
            Console.WriteLine("derived display1");
        }

        //hide the base class method
        public new void Display2()
        {
            Console.WriteLine("derived display2");
        }
        public override void Display3()
        {
            Console.WriteLine("derived display3");
        }
    }
    public class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()
        {
            Console.WriteLine("subderived display3");
        }
    }
    public class SubSubDerivedClass : SubDerivedClass
    {
        //public override void Display3()  // error
        public new void Display3()
        {
            Console.WriteLine("subsubderived display3");
        }
    }
}
