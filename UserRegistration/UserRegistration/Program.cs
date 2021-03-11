using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.isValidUserName("Nandini"));
            Console.WriteLine(pattern.isValidUserName("Abc"));
            Console.WriteLine(pattern.isValidUserName("abc"));
            Console.WriteLine(pattern.isValidUserName("ABC"));
            Console.WriteLine(pattern.isValidUserName("AB"));



        }
    }
}
