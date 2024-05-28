using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfClasses
{
    static public class StClass
    {
        static int abd;//for commit
        public static int i;//static variable  //instance static variable     
        static public int k;
        public static  float ff;
        public static string str;
        static StClass()
        {
            i = 33;
            k = 555;
            ff = 3.14f;
            str = "gth";
        }
        
        static public void display()
        {
            
            Console.WriteLine("i=" + i);
            Console.WriteLine("k=" + k);
            Console.WriteLine("static display called..");
        }
    }
    class myClass
    {
        public const int a = 11;
         public static int i;//static variable  //instance static variable     
        public int k;   //instance variable
     
        public myClass()
        {
            i = 777;
            Console.WriteLine("non staic default constructor####");
        }
        ~ myClass()
        {
            i = 777;
            Console.WriteLine("non staic default constructor####");
        }
        public myClass(int x)
        {
            Console.WriteLine("$$$$ non static 1 parameter constructor called $$$$");
        }
        static  myClass()
        {
            i = 888;
            
            Console.WriteLine("@@@@ staic default constructor");
        }
        public void show()
        {
            int z=11;//local variable
            Console.WriteLine("i="+i);
            Console.WriteLine("k=" + k);
            Console.WriteLine("z=" + z);
        }

        static public void display()
        {
            Console.WriteLine(a);
            Console.WriteLine("i=" + i);
           
            Console.WriteLine("static display called..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myClass mobj1 = new myClass();
            Console.WriteLine("----------------------------");
            myClass mobj2 = new myClass(111);
            Console.WriteLine("----------------------------");
            myClass mobj3 = new myClass();
            Console.WriteLine("last line of main");
          

            Console.ReadKey();
        }
    }
}
