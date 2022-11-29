namespace Task_4_NUnit
{
    public class Program
    {
        string[] userPass;
        int i = 0;
        bool CheckPassword(String p)
        {
            if (string.IsNullOrEmpty(p)) Console.WriteLine("Empty string");
            return (p.Length >= 8 && p.Length <= 12) ? true : false;
   
        }

        void check(string pass)
        {
            if (CheckPassword(pass) == true)
            {
                Console.WriteLine(pass + " is following conventions");
            }
            else
            {
                Console.WriteLine(pass + " is not following conventions");

            }
        }

        [SetUp]
        public void Setup()
        {
            userPass = new String[6] {"1234" , "12345678", "T@ta9eM@ina", "" , "asdfghjklqwer" , "12345678912345"};
        }
        
        [Test]
        public void Test1()
        {
            check((userPass[i]));
            i++;
        }
        [Test]
        public void Test2()
        {
            check((userPass[i]));
            i++;
        }
        [Test]
        public void Test3()
        {
            check((userPass[i]));
            i++;
        }
        [Test]
        public void Test4()
        {
            check((userPass[i]));
            i++;
        }
        [Test]
        public void Test5()
        {
            check((userPass[i]));
            i++;
        }
        [Test]
        public void Test6()
        {
            check((userPass[i]));
            i++;
        }

    }

}