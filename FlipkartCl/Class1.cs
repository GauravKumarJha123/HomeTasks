using FlipkartNUnit;

namespace FlipkartCl
{
    public class Class1
    {
        static void Main(string[] args)
        {
            ChromeTest t = new ChromeTest();
            t.Setup();
            t.Test1();
            t.End();
            FirefoxTest f = new FirefoxTest();
            f.Intialize();
            f.Test2();
            f.End();
            
        }

    }
}