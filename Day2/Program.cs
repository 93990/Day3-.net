using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
	public class Program
	{
		static void Main1(string[] args)
		{
			
			StaticExample.pQ = 10456;
			StaticExample obj = new StaticExample();
			obj.i = 1;
			obj.display();
			//Calling  static method and variable by 



		}

	
	}
	//static member are accessed as classname.membername
	public class StaticExample
	{
		public int i;
		public static int si; //static variable - single copy for class

		public void display()
		{
			Console.WriteLine(i);
			Console.WriteLine(si);
		}
		public static void sDisplay()//static method - can call method directly without creating an object of class
		{
			//Console.WriteLine(i); 
			//i can vary for different obj
			//and we can not create object for static method so we can not say which object i refer too
			Console.WriteLine(si);//this will work as si have single copy throughout
			Console.ReadLine();
		}

		private static int pq;

		public static int pQ
		{
			set {
				if (pq > 9)
					pq = value;
				else
				{
					Console.WriteLine("Sorry we dont accept less of 9 value");
				}
			}
			get {
				return pq;
			}
		}
		static StaticExample() // it is implicitly called by class so it does not have any other access specifier than ptivate
		{
			pQ = 90;
			si = 1000;
			Console.WriteLine("Static constructor is called first alwas");
		}
		public StaticExample()
		{
			Console.WriteLine("Not static constructor");
		}
	}


	public  static class class1
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a value ");
			
			
			il = Convert.ToInt32(Console.ReadLine());
			class1.display1();
			Console.ReadLine();
		}
		static int il;

		static void display1()
		{
			il = 9;
		
			if (il > 9)
			{
			
				Console.WriteLine("No I dont accept this value i am sorry");
			}
			if(il < 10 && il != 9)
			{
				Console.WriteLine("Hatt ja yaha sw");
			}
			if(il == 9)
			{
				Console.WriteLine("Thank you i love you");
			}
		}

	}
}
