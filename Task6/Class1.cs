using OpenQA.Selenium.Chrome;
using Task5NUnit;

namespace Task6
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Chrome c = new Chrome();  
            Firefox f = new Firefox();
            c.Start();
            c.Test2();
            f.Start();
            f.Test3();            
        }

    }
}