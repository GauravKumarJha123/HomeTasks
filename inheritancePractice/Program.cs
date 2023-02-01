using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancePractice
{
    class Class1
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
        }
    }

    class Class2 : Class1
    {
        public void M2()
        {
            Console.WriteLine("Method 2");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Class2 c2 = new Class2();
            //Class1 c1 = c2;
            //c1.M1();  //upcasting implicit casting
            //          //
            Class1 c1 = new Class2();
            Class2 c2 =(Class2) c1; // downcasting
            c1.M1();
            c2.M1();
            c2.M1();
            
            Console.ReadLine();
        }
    }
}
