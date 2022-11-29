

using Task_4_NUnit;

namespace Task_4_using_NUnit_and_Class_Library
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Setup();
            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4();
            p.Test5();
            //p.NotString();
        }
    }
}