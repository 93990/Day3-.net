
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    internal class Program
    {
        static void Main1()
        {
            //System.Console.WriteLine("Hello World");
            //System.Console.ReadLine();
            System.Console.WriteLine("H W");
            System.Console.ReadLine();
        }
        static void Main2()
        {
            Console.WriteLine("H W");
            Console.ReadLine();
        }
        static void Main3()
        {
            Class1 o; //o is a reference of type Class1
            o = new Class1();  //new Class1() is an object of the class Class1 
             // o refers to (points to) an object of type Class1
            o.Display();
            Console.ReadLine();
        }
        static void Main()
        {
            Class1 o= new Class1();  
            o.Display();
            o.Display("yash");
            SqlConnection cn = new SqlConnection();


            int ans = 0;
            ans = o.Add();
            Console.WriteLine(ans);
            ans = o.Add(10);
            Console.WriteLine(ans);
            ans = o.Add(10, 20);
            Console.WriteLine(ans);
            ans = o.Add(10, 20, 30);
            Console.WriteLine(ans);
        }
    }
    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
        //function overloading
        public void Display(string s)
        {
            Console.WriteLine("Display" + s);
        }
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //default value for a parameter
        public int Add(int a=0, int b=0, int c=0)
        {
            return a + b + c;
        }
    }
    

    
}
namespace MyNamespace
{
    public class C1 {
    
    }
    public class C2 { }
    namespace n2
    {
        public class C3 { } 
    }

}
